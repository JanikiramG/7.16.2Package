namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System = System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
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

	#region Class: SysSSPEntitySchemaAccessListGridPageSchema

	/// <exclude/>
	public class SysSSPEntitySchemaAccessListGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addEntitySchema;
		public Terrasoft.UI.WebControls.Controls.Button AddEntitySchema {
			get {
				return _addEntitySchema;
			}
		}

		#endregion

		#region Constructors: Public

		public SysSSPEntitySchemaAccessListGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysSSPEntitySchemaAccessListGridPageSchema(SysSSPEntitySchemaAccessListGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Enabled = true;
			AddButton.Hidden = true;
			AddButton.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.Enabled = true;
			DeleteButton.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			RealUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			Name = "SysSSPEntitySchemaAccessListGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			ValidationMessagePanel = "BaseMessagePanel";
			PrimaryDataSourceName = "DataSource";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSSPEntitySchemaAccessListGridPageEventsProcessSchema();
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
			Controls.AddAt(0, CreateBaseMessagePanel());
			TopLevelControl.MoveItem(1, ButtonsControlLayout);
			ButtonsControlLayout.InsertItem(0, CreateAddEntitySchema());
			ButtonsControlLayout.MoveItem(1, AddButton);
			ButtonsControlLayout.MoveItem(2, CopyButton);
			ButtonsControlLayout.MoveItem(3, EditButton);
			ButtonsControlLayout.MoveItem(4, DeleteButton);
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, ActionButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			TopLevelControl.MoveItem(2, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysSSPEntitySchemaAccessListGridPageEventsProcessSchema() {
			var schema = new SysSSPEntitySchemaAccessListGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("bae966b5-dbc1-4484-b695-be2a51905390");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			_baseMessagePanel.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddEntitySchema() {
			_addEntitySchema = new Terrasoft.UI.WebControls.Controls.Button();
			_addEntitySchema.UId = new Guid("afcbc158-5d1a-4cee-9ac8-e3b1e6f579dc");
			_addEntitySchema.Name = "AddEntitySchema";
			_addEntitySchema.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			_addEntitySchema.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			_addEntitySchema.CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866");
			_addEntitySchema.AjaxEvents.Click.IsProcessEventHandler = true;
			_addEntitySchema.Tag = "";
			_addEntitySchema.Image = new ControlImage {};
			_addEntitySchema.ImageAsSprite = false;
			return _addEntitySchema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			DataSource.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("da7b10af-63a6-47b1-9d7e-9480b02ee1a8");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("ac45e0a3-b636-409e-a0e9-28fb5bc09636");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("c26d70dd-e44b-4763-9db2-cd6cbf686f1f");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("7d15c9ea-6685-4b3f-a687-149a951d98db");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("0a960f07-c241-43de-be4f-d04d20067b3f");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("7aa019c4-18cf-4a4c-9ba4-0445fd5e6c7b");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("317015be-6ee9-410c-9498-b07b82cfb6f3");
			if (column != null) {
				column.UId = new Guid("e9aab534-91a6-4666-a6a5-bb3f2f0fd32e");
				column.Name = @"EntitySchemaUId";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4fa3d6c4-bcbe-4a4f-b36d-de76dd97e2a9");
			if (column != null) {
				column.UId = new Guid("7d432d46-1da6-4680-bb2e-2f74c0d8d8a0");
				column.Name = @"WorkspaceId";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("229a3213-ff4e-4e32-a76d-b1098b341659");
			if (column != null) {
				column.UId = new Guid("e43b9b1a-c28f-4bac-ae85-bb863035acad");
				column.Name = @"SysSchema";
				column.CreatedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.ModifiedInSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysSSPEntitySchemaAccessListGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysSSPEntitySchemaAccessListGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysSSPEntitySchemaAccessListGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessListGridPageEventsProcess

	/// <exclude/>
	public class SysSSPEntitySchemaAccessListGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysSSPEntitySchemaAccessListGridPageSchemaUserControl
	{

		#region Class: OpenEntitySchemaLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenEntitySchemaLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenEntitySchemaLookupUserTaskFlowElement(UserConnection userConnection, SysSSPEntitySchemaAccessListGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEntitySchemaLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowMessageSSPMaxSchemaCountFlowElement

		/// <exclude/>
		public class ShowMessageSSPMaxSchemaCountFlowElement : QuestionUserTask
		{

			public ShowMessageSSPMaxSchemaCountFlowElement(UserConnection userConnection, SysSSPEntitySchemaAccessListGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowMessageSSPMaxSchemaCount";
				IsLogging = false;
				SchemaElementUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SysSSPEntitySchemaAccessListGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSSPEntitySchemaAccessListGridPageEventsProcess";
			SchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba");
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

		private int _sSPCurrentSchemaCount = 0;
		public int SSPCurrentSchemaCount {
			get {
				return _sSPCurrentSchemaCount;
			}
			set {
				_sSPCurrentSchemaCount = value;
			}
		}

		private bool _showOverflowSchemaCountMessage = false;
		public bool ShowOverflowSchemaCountMessage {
			get {
				return _showOverflowSchemaCountMessage;
			}
			set {
				_showOverflowSchemaCountMessage = value;
			}
		}

		public virtual bool ShowOverflowAdminSchemaCountMessage {
			get;
			set;
		}

		private int _sSPCurrentAdministratedSchemaCount = 0;
		public int SSPCurrentAdministratedSchemaCount {
			get {
				return _sSPCurrentAdministratedSchemaCount;
			}
			set {
				_sSPCurrentAdministratedSchemaCount = value;
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
					SchemaElementUId = new Guid("c3429833-b350-4703-bdcb-f78ab1328065"),
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
					SchemaElementUId = new Guid("346b1cb2-fa6a-454e-a81a-d1bdd96082c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteThrowMessage;
		public ProcessThrowMessageEvent PageLoadCompleteThrowMessage {
			get {
				return _pageLoadCompleteThrowMessage ?? (_pageLoadCompleteThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteThrowMessage",
					SchemaElementUId = new Guid("904dfb17-3e27-4ddc-8fae-8541851a81f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("8b62e20c-d78c-4a73-ae85-0dd0df0e71f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addEntitySchemaClick;
		public ProcessFlowElement AddEntitySchemaClick {
			get {
				return _addEntitySchemaClick ?? (_addEntitySchemaClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddEntitySchemaClick",
					SchemaElementUId = new Guid("54fab5c9-8fd3-48c4-9e40-95638def9e40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initFilters;
		public ProcessScriptTask InitFilters {
			get {
				return _initFilters ?? (_initFilters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitFilters",
					SchemaElementUId = new Guid("a76247e2-fc48-4082-986f-90615df862cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitFiltersExecute,
				});
			}
		}

		private OpenEntitySchemaLookupUserTaskFlowElement _openEntitySchemaLookupUserTask;
		public OpenEntitySchemaLookupUserTaskFlowElement OpenEntitySchemaLookupUserTask {
			get {
				return _openEntitySchemaLookupUserTask ?? (_openEntitySchemaLookupUserTask = new OpenEntitySchemaLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEvent1;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEvent1 {
			get {
				return _intermediateCatchMessageEvent1 ?? (_intermediateCatchMessageEvent1 = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEvent1",
					SchemaElementUId = new Guid("b40042b7-81bf-40de-8938-872a4b760038"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _insertEntity;
		public ProcessScriptTask InsertEntity {
			get {
				return _insertEntity ?? (_insertEntity = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertEntity",
					SchemaElementUId = new Guid("79289b74-a8d0-41ec-a638-a62e738453e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertEntityExecute,
				});
			}
		}

		private ProcessScriptTask _calculateSSPSchemaCount;
		public ProcessScriptTask CalculateSSPSchemaCount {
			get {
				return _calculateSSPSchemaCount ?? (_calculateSSPSchemaCount = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CalculateSSPSchemaCount",
					SchemaElementUId = new Guid("60bb7c8c-ba4c-407e-b8c3-e2069dffe7af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CalculateSSPSchemaCountExecute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("a74f4a78-9bee-4082-a3bf-9c786f50a00d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.InclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ShowMessageSSPMaxSchemaCountFlowElement _showMessageSSPMaxSchemaCount;
		public ShowMessageSSPMaxSchemaCountFlowElement ShowMessageSSPMaxSchemaCount {
			get {
				return _showMessageSSPMaxSchemaCount ?? (_showMessageSSPMaxSchemaCount = new ShowMessageSSPMaxSchemaCountFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("596cc95d-bd41-421a-8aa2-b5eba7f97d3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway2;
		public ProcessInclusiveGateway InclusiveGateway2 {
			get {
				return _inclusiveGateway2 ?? (_inclusiveGateway2 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway2",
					SchemaElementUId = new Guid("75736147-4fc7-41f3-bec2-7622b491040f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.InclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _initUserMessage;
		public ProcessScriptTask InitUserMessage {
			get {
				return _initUserMessage ?? (_initUserMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitUserMessage",
					SchemaElementUId = new Guid("b68f71bd-b3b0-45e6-a7e9-fab03b03ffc3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitUserMessageExecute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway3;
		public ProcessInclusiveGateway InclusiveGateway3 {
			get {
				return _inclusiveGateway3 ?? (_inclusiveGateway3 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway3",
					SchemaElementUId = new Guid("5af0d422-1063-4b35-ba72-187f728658b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.InclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("a9d504b2-2983-46a3-a77d-0e3446af9ed1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
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
					SchemaElementUId = new Guid("f37a4656-2586-438f-8df2-782cd9b78cc8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteEntitySchemaClick;
		public ProcessFlowElement DeleteEntitySchemaClick {
			get {
				return _deleteEntitySchemaClick ?? (_deleteEntitySchemaClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteEntitySchemaClick",
					SchemaElementUId = new Guid("f714df29-baa3-4f60-8715-e0877e5cecf4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteEntitySchemaScriptTask;
		public ProcessScriptTask DeleteEntitySchemaScriptTask {
			get {
				return _deleteEntitySchemaScriptTask ?? (_deleteEntitySchemaScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteEntitySchemaScriptTask",
					SchemaElementUId = new Guid("ab9ff4c1-c423-48ad-9a5f-512c37fd9373"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteEntitySchemaScriptTaskExecute,
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
					SchemaElementUId = new Guid("e931cf35-f26a-4e3f-b8ef-6912fcafe1fb"),
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
					SchemaElementUId = new Guid("34a97359-f071-4caf-b025-0b721e6d89f9"),
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
					SchemaElementUId = new Guid("8c4a48d9-c865-4fc1-a973-39e03a1afc5e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("b2ad7408-6387-4997-a7e9-2164e80b86cc"),
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
					SchemaElementUId = new Guid("f0c47752-b625-4444-be8e-3fb21d578918"),
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
					SchemaElementUId = new Guid("4445a6ae-ba0e-47b5-992f-c27d51c395bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _overflowSSPSchemaCountMessage;
		public LocalizableString OverflowSSPSchemaCountMessage {
			get {
				return _overflowSSPSchemaCountMessage ?? (_overflowSSPSchemaCountMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OverflowSSPSchemaCountMessage.Value"));
			}
		}

		private LocalizableString _overflowSSPAdministratedSchemaCountMessage;
		public LocalizableString OverflowSSPAdministratedSchemaCountMessage {
			get {
				return _overflowSSPAdministratedSchemaCountMessage ?? (_overflowSSPAdministratedSchemaCountMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OverflowSSPAdministratedSchemaCountMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteThrowMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[AddEntitySchemaClick.SchemaElementUId] = new Collection<ProcessFlowElement> { AddEntitySchemaClick };
			FlowElements[InitFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { InitFilters };
			FlowElements[OpenEntitySchemaLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEntitySchemaLookupUserTask };
			FlowElements[IntermediateCatchMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent1 };
			FlowElements[InsertEntity.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertEntity };
			FlowElements[CalculateSSPSchemaCount.SchemaElementUId] = new Collection<ProcessFlowElement> { CalculateSSPSchemaCount };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
			FlowElements[ShowMessageSSPMaxSchemaCount.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageSSPMaxSchemaCount };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[InclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway2 };
			FlowElements[InitUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitUserMessage };
			FlowElements[InclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway3 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[DeleteEntitySchemaClick.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteEntitySchemaClick };
			FlowElements[DeleteEntitySchemaScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteEntitySchemaScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteThrowMessage");
						break;
					case "PageLoadCompleteThrowMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess8":
						break;
					case "AddEntitySchemaClick":
						e.Context.QueueTasks.Enqueue("CalculateSSPSchemaCount");
						break;
					case "InitFilters":
						e.Context.QueueTasks.Enqueue("OpenEntitySchemaLookupUserTask");
						break;
					case "OpenEntitySchemaLookupUserTask":
						ActivatedEventElements.Add("IntermediateCatchMessageEvent1");
						break;
					case "IntermediateCatchMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "InsertEntity":
						break;
					case "CalculateSSPSchemaCount":
						e.Context.QueueTasks.Enqueue("InclusiveGateway1");
						break;
					case "InclusiveGateway1":
						bool isInclusiveGateway1ConditionsEvulateted = false;
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("InitUserMessage");
							isInclusiveGateway1ConditionsEvulateted = true;
						} 
						if (!isInclusiveGateway1ConditionsEvulateted) {
							e.Context.QueueTasks.Enqueue("InitFilters");
						} 
						break;
					case "ShowMessageSSPMaxSchemaCount":
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("InclusiveGateway2");
						break;
					case "InclusiveGateway2":
						bool isInclusiveGateway2ConditionsEvulateted = false;
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("InitUserMessage");
							isInclusiveGateway2ConditionsEvulateted = true;
						} 
						if (!isInclusiveGateway2ConditionsEvulateted) {
							e.Context.QueueTasks.Enqueue("InclusiveGateway3");
						} 
						break;
					case "InitUserMessage":
						e.Context.QueueTasks.Enqueue("ShowMessageSSPMaxSchemaCount");
						break;
					case "InclusiveGateway3":
						bool isInclusiveGateway3ConditionsEvulateted = false;
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask3");
							isInclusiveGateway3ConditionsEvulateted = true;
						} 
						if (!isInclusiveGateway3ConditionsEvulateted) {
							e.Context.QueueTasks.Enqueue("InsertEntity");
						} 
						break;
					case "ScriptTask3":
						e.Context.QueueTasks.Enqueue("ShowMessageSSPMaxSchemaCount");
						break;
					case "EventSubProcess9":
						break;
					case "DeleteEntitySchemaClick":
						e.Context.QueueTasks.Enqueue("DeleteEntitySchemaScriptTask");
						break;
					case "DeleteEntitySchemaScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(ShowOverflowSchemaCountMessage == true);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(ShowOverflowSchemaCountMessage == true);
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(ShowOverflowAdminSchemaCountMessage == true);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("AddEntitySchemaClick");
			ActivatedEventElements.Add("DeleteEntitySchemaClick");
			ActivatedEventElements.Add("StartMessage1");
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
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteThrowMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "AddEntitySchemaClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddEntitySchemaClick";
					result = AddEntitySchemaClick.Execute(context);
					break;
				case "InitFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitFilters";
					result = InitFilters.Execute(context, InitFiltersExecute);
					break;
				case "OpenEntitySchemaLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenEntitySchemaLookupUserTask";
					result = OpenEntitySchemaLookupUserTask.Execute(context);
					break;
				case "IntermediateCatchMessageEvent1":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent1";
					result = IntermediateCatchMessageEvent1.Execute(context);
					break;
				case "InsertEntity":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertEntity";
					result = InsertEntity.Execute(context, InsertEntityExecute);
					break;
				case "CalculateSSPSchemaCount":
					context.QueueTasks.Dequeue();
					context.SenderName = "CalculateSSPSchemaCount";
					result = CalculateSSPSchemaCount.Execute(context, CalculateSSPSchemaCountExecute);
					break;
				case "InclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "InclusiveGateway1";
					result = InclusiveGateway1.Execute(context);
					break;
				case "ShowMessageSSPMaxSchemaCount":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMessageSSPMaxSchemaCount";
					result = ShowMessageSSPMaxSchemaCount.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "InclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "InclusiveGateway2";
					result = InclusiveGateway2.Execute(context);
					break;
				case "InitUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitUserMessage";
					result = InitUserMessage.Execute(context, InitUserMessageExecute);
					break;
				case "InclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "InclusiveGateway3";
					result = InclusiveGateway3.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteEntitySchemaClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteEntitySchemaClick";
					result = DeleteEntitySchemaClick.Execute(context);
					break;
				case "DeleteEntitySchemaScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteEntitySchemaScriptTask";
					result = DeleteEntitySchemaScriptTask.Execute(context, DeleteEntitySchemaScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
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
				case "SSPCurrentAdministratedSchemaCount":
					SSPCurrentAdministratedSchemaCount = reader.GetValue<System.Int32>();
				break;
				case "ShowOverflowAdminSchemaCountMessage":
					ShowOverflowAdminSchemaCountMessage = reader.GetValue<System.Boolean>();
				break;
				case "ShowOverflowSchemaCountMessage":
					ShowOverflowSchemaCountMessage = reader.GetValue<System.Boolean>();
				break;
				case "SSPCurrentSchemaCount":
					SSPCurrentSchemaCount = reader.GetValue<System.Int32>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			EditPageUId = Guid.Parse("9014b3af-3822-490b-b35a-ebb89e72fce8");
			var structure = Page.DataSource.CurrentStructure;
			var filter = structure.CreateFilterWithParameters(Page.DataSource.Schema,
				FilterComparisonType.Equal, "WorkspaceId", UserConnection.Workspace.Id);
			structure.Filters.Add(filter);
			Page.DataSource.LoadRows();
			return true;
		}

		public virtual bool InitFiltersExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			UserConnection userConnection = Page.UserConnection;
			OpenEntitySchemaLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			string schemaUId = "90fa6d02-3e93-45d6-a72b-58dcffa411ae"; //VwSysSchemaInfo
			OpenEntitySchemaLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenEntitySchemaLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			
			var filters = new Collection<Dictionary<string, object>>();
			filters.Add(new Dictionary<string, object> {
				{ "comparisonType", FilterComparisonType.Equal },
				{ "leftExpressionColumnPath", "SysWorkspace" },
				{ "useDisplayValue", false },
				{ "rightExpressionParameterValues", new object[] { userConnection.Workspace.Id } } });
			filters.Add(new Dictionary<string, object> {
				{ "comparisonType", FilterComparisonType.Equal },
				{ "leftExpressionColumnPath", "ManagerName" },
				{ "useDisplayValue", false },
				{ "rightExpressionParameterValues", new object[] { "EntitySchemaManager" } } });
			pageParameters.Add("LookupFilters", filters);
			return true;
		}

		public virtual bool InsertEntityExecute(ProcessExecutingContext context) {
			UserConnection userConnection = Page.UserConnection;
			var values = OpenEntitySchemaLookupUserTask.GetSelectedValues(userConnection) as Dictionary <string, object>;
			if (values == null){
				return true;
			}
			foreach(var value in values) {
				var uid = value.Key;
				var entity = new SysSSPEntitySchemaAccessList(userConnection);
				if(!entity.FetchFromDB("EntitySchemaUId", uid)){
					entity.SetDefColumnValues();
					entity.EntitySchemaUId = new Guid(uid);
					entity.Save();
				}
			}
			Page.TreeGrid.RefreshData();
			return true;
		}

		public virtual bool CalculateSSPSchemaCountExecute(ProcessExecutingContext context) {
			ICollection<Guid> sspSchemaUids = GetSSPCurrentSchemaUIds();
			SSPCurrentSchemaCount = sspSchemaUids.Count;
			ShowOverflowSchemaCountMessage = SSPCurrentSchemaCount >= Page.UserConnection.LicHelper.SSPSchemaCount;
			ICollection<Guid> sspAdminSchemaUids = GetAdministratedByRecordSchemaUIds(sspSchemaUids);
			SSPCurrentAdministratedSchemaCount = sspAdminSchemaUids.Count;
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			ShowOverflowSchemaCountMessage = false;
			ShowOverflowAdminSchemaCountMessage = false;
			var userConnection = Page.UserConnection;
			var values = OpenEntitySchemaLookupUserTask.GetSelectedValues(userConnection) as Dictionary <string, object>;
			if (values != null){
				SSPCurrentSchemaCount += values.Count;
				ShowOverflowSchemaCountMessage = SSPCurrentSchemaCount > userConnection.LicHelper.SSPSchemaCount;
				ICollection<Guid> schemaUId = new Collection<Guid>();
				foreach(var value in values){
					schemaUId.Add(new Guid(value.Key));
				}
				int administratedByRecordSchemaCount = GetAdministratedByRecordSchemaUIds(schemaUId).Count;
				SSPCurrentAdministratedSchemaCount += administratedByRecordSchemaCount;
				ShowOverflowAdminSchemaCountMessage = SSPCurrentAdministratedSchemaCount > userConnection.LicHelper.SSPAdministratedSchemaCount;
			}
			return true;
		}

		public virtual bool InitUserMessageExecute(ProcessExecutingContext context) {
			int maxSSPSchemaCount = Page.UserConnection.LicHelper.SSPSchemaCount;
			ShowMessageSSPMaxSchemaCount.Page = Page;
			ShowMessageSSPMaxSchemaCount.MessageText = string.Format(OverflowSSPSchemaCountMessage.Value, maxSSPSchemaCount, SSPCurrentSchemaCount);
			ShowMessageSSPMaxSchemaCount.Icon = "INFO";
			ShowMessageSSPMaxSchemaCount.Buttons = "OK";
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			int maxSSPAdministratedSchemaCount = Page.UserConnection.LicHelper.SSPSchemaCount;
			ShowMessageSSPMaxSchemaCount.Page = Page;
			ShowMessageSSPMaxSchemaCount.MessageText = string.Format(OverflowSSPAdministratedSchemaCountMessage.Value, maxSSPAdministratedSchemaCount, SSPCurrentAdministratedSchemaCount);
			ShowMessageSSPMaxSchemaCount.Icon = "INFO";
			ShowMessageSSPMaxSchemaCount.Buttons = "OK";
			return true;
		}

		public virtual bool DeleteEntitySchemaScriptTaskExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count == 0){
				return true;
			}
			UserConnection userConnection = Page.UserConnection;
			foreach(var node in selectedNodes){
				var id = node.Values["Id"];
				var entity = new SysSSPEntitySchemaAccessList(userConnection);
				if(entity.FetchFromDB("Id", id)){
					entity.Delete();
				}
			}
			Page.TreeGrid.RefreshData();
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			return true;
		}

		public override string GetRegisterTreeGridDblClickScript(string defaultScript) {
			return string.Empty;
		}

		public virtual ICollection<Guid> GetSSPCurrentSchemaUIds() {
			var userConnection = Page.UserConnection;
			var schemaUIds = new Collection<Guid>();
			var select =
				new Select(userConnection)
					.Column("EntitySchemaUId")
				.From("VwSysSSPEntitySchemaAccessList")
				.Where("WorkspaceId").IsEqual(Column.Parameter(userConnection.Workspace.Id))
					as Select;
			select.ExecuteReader(dataReader => {
				schemaUIds.Add(dataReader.GetColumnValue<Guid>("EntitySchemaUId"));
			});
			return schemaUIds;
		}

		public virtual ICollection<Guid> GetAdministratedByRecordSchemaUIds(ICollection<Guid> schemaUIds) {
			var uids = new Collection<Guid>();
			if (schemaUIds.Count > 0){
				var userConnection = Page.UserConnection;
				var select =
					new Select(userConnection)
						.Column("UId")
					.From("VwAdministrativeObjects")
					.Where("AdministratedByRecords").IsEqual(Column.Parameter(1))
					.And("SysWorkspaceId").IsEqual(Column.Parameter(userConnection.Workspace.Id))
					.And("UId").In(Column.Parameters(schemaUIds)) as Select;
				select.ExecuteReader(dataReader => {
					uids.Add(dataReader.GetColumnValue<Guid>("UId"));
				});
			}
			return uids;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "AddEntitySchemaClick":
							if (ActivatedEventElements.Contains("AddEntitySchemaClick")) {
							context.QueueTasks.Enqueue("AddEntitySchemaClick");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent1")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent1");
					}
					break;
					case "DeleteEntitySchemaClick":
							if (ActivatedEventElements.Contains("DeleteEntitySchemaClick")) {
							context.QueueTasks.Enqueue("DeleteEntitySchemaClick");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
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
			if (!HasMapping("SSPCurrentAdministratedSchemaCount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SSPCurrentAdministratedSchemaCount", SSPCurrentAdministratedSchemaCount, 0);
			}
			if (!HasMapping("ShowOverflowAdminSchemaCountMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ShowOverflowAdminSchemaCountMessage", ShowOverflowAdminSchemaCountMessage, false);
			}
			if (!HasMapping("ShowOverflowSchemaCountMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ShowOverflowSchemaCountMessage", ShowOverflowSchemaCountMessage, false);
			}
			if (!HasMapping("SSPCurrentSchemaCount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SSPCurrentSchemaCount", SSPCurrentSchemaCount, 0);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessListGridPageEventsProcess

	/// <exclude/>
	public class SysSSPEntitySchemaAccessListGridPageEventsProcess : SysSSPEntitySchemaAccessListGridPageEventsProcess<Terrasoft.WebApp.SysSSPEntitySchemaAccessListGridPageSchemaUserControl>
	{

		public SysSSPEntitySchemaAccessListGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessListGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysSSPEntitySchemaAccessListGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddEntitySchema {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddEntitySchema", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddEntitySchema.AjaxEvents.Click.Event += AddEntitySchemaClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddEntitySchema.AjaxEvents.Click.Event -= AddEntitySchemaClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysSSPEntitySchemaAccessListGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysSSPEntitySchemaAccessListGridPageEventsProcess(UserConnection);
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

		public virtual void AddEntitySchemaClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddEntitySchemaClick");
		}

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
			SchemaName = "SysSSPEntitySchemaAccessListGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysSSPEntitySchemaAccessListGridPageEventsProcessSchema

	/// <exclude/>
	public class SysSSPEntitySchemaAccessListGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysSSPEntitySchemaAccessListGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSSPEntitySchemaAccessListGridPageEventsProcessSchema(SysSSPEntitySchemaAccessListGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSSPEntitySchemaAccessListGridPageEventsProcess";
			UId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e");
			CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
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

		protected virtual ProcessSchemaParameter CreateSSPCurrentSchemaCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("80ab837e-1b81-4c28-9ff8-5685fb5700fa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"SSPCurrentSchemaCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateShowOverflowSchemaCountMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8cdfd90f-4bbf-43b4-9562-7524c88cb4ca"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"ShowOverflowSchemaCountMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateShowOverflowAdminSchemaCountMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("60b51c0f-a964-44b1-902d-ec1077b7ba24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"ShowOverflowAdminSchemaCountMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSSPCurrentAdministratedSchemaCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("85b61cc4-67ce-4168-86fc-3bcc0414cd60"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"SSPCurrentAdministratedSchemaCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSSPCurrentSchemaCountParameter());
			Parameters.Add(CreateShowOverflowSchemaCountMessageParameter());
			Parameters.Add(CreateShowOverflowAdminSchemaCountMessageParameter());
			Parameters.Add(CreateSSPCurrentAdministratedSchemaCountParameter());
		}

		protected virtual void InitializeOpenEntitySchemaLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f6007e0f-7d57-4010-991c-5e06e257e0dc"),
				ContainerUId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981"),
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
				UId = new Guid("2532a864-188c-4387-a1ba-acbb5b2cdd94"),
				ContainerUId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981"),
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
				UId = new Guid("019c89bd-18e7-49be-8397-b9c0762eb834"),
				ContainerUId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981"),
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
				UId = new Guid("ae30d718-5528-483f-960c-ac5184056cc7"),
				ContainerUId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeShowMessageSSPMaxSchemaCountParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("24e1cdc8-6026-4259-a34c-1c887437d24b"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
				UId = new Guid("d27d816b-d43b-44d5-b64c-a05ad63b4332"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
				UId = new Guid("7f8cbdae-48c4-49df-98d7-1c995c5ca0ea"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
				UId = new Guid("7fa5ba07-ee3d-4e7b-ab28-f61160b62dbb"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
				UId = new Guid("53c4c095-c9bd-4a45-9b11-52599fc0c35c"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
				UId = new Guid("0d0372db-6481-4aa5-a34f-3523cf0f43cd"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
				UId = new Guid("15a5f938-7c04-44f7-9a89-a4d921c4e5a2"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
				UId = new Guid("0ff69888-142c-4c45-bb13-a29a3470a3d2"),
				ContainerUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
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
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompletethrowmessage = CreatePageLoadCompleteThrowMessageIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletethrowmessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent addentityschemaclick = CreateAddEntitySchemaClickStartMessageEvent();
			eventsubprocess8.FlowElements.Add(addentityschemaclick);
			ProcessSchemaScriptTask initfilters = CreateInitFiltersScriptTask();
			eventsubprocess8.FlowElements.Add(initfilters);
			ProcessSchemaUserTask openentityschemalookupusertask = CreateOpenEntitySchemaLookupUserTaskUserTask();
			eventsubprocess8.FlowElements.Add(openentityschemalookupusertask);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent1 = CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatecatchmessageevent1);
			ProcessSchemaScriptTask insertentity = CreateInsertEntityScriptTask();
			eventsubprocess8.FlowElements.Add(insertentity);
			ProcessSchemaScriptTask calculatesspschemacount = CreateCalculateSSPSchemaCountScriptTask();
			eventsubprocess8.FlowElements.Add(calculatesspschemacount);
			ProcessSchemaInclusiveGateway inclusivegateway1 = CreateInclusiveGateway1InclusiveGateway();
			eventsubprocess8.FlowElements.Add(inclusivegateway1);
			ProcessSchemaUserTask showmessagesspmaxschemacount = CreateShowMessageSSPMaxSchemaCountUserTask();
			eventsubprocess8.FlowElements.Add(showmessagesspmaxschemacount);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask2);
			ProcessSchemaInclusiveGateway inclusivegateway2 = CreateInclusiveGateway2InclusiveGateway();
			eventsubprocess8.FlowElements.Add(inclusivegateway2);
			ProcessSchemaScriptTask initusermessage = CreateInitUserMessageScriptTask();
			eventsubprocess8.FlowElements.Add(initusermessage);
			ProcessSchemaInclusiveGateway inclusivegateway3 = CreateInclusiveGateway3InclusiveGateway();
			eventsubprocess8.FlowElements.Add(inclusivegateway3);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent deleteentityschemaclick = CreateDeleteEntitySchemaClickStartMessageEvent();
			eventsubprocess9.FlowElements.Add(deleteentityschemaclick);
			ProcessSchemaScriptTask deleteentityschemascripttask = CreateDeleteEntitySchemaScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(deleteentityschemascripttask);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask4);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOverflowSSPSchemaCountMessageLocalizableString());
			LocalizableStrings.Add(CreateOverflowSSPAdministratedSchemaCountMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOverflowSSPSchemaCountMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("87960e29-5a8e-4b23-8a98-3aca65ed7dee"),
				Name = "OverflowSSPSchemaCountMessage",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOverflowSSPAdministratedSchemaCountMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1f5f5115-5315-4da4-9e41-79a2c51982ff"),
				Name = "OverflowSSPAdministratedSchemaCountMessage",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("46ef0103-c6f0-4015-b51e-e3c797011250"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(180, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("346b1cb2-fa6a-454e-a81a-d1bdd96082c6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("904dfb17-3e27-4ddc-8fae-8541851a81f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("096d6ba2-016b-4a8a-97f6-2862d11c6bc1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(269, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("904dfb17-3e27-4ddc-8fae-8541851a81f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b62e20c-d78c-4a73-ae85-0dd0df0e71f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b5be2a82-d99f-48f6-a78a-7150184aced0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54fab5c9-8fd3-48c4-9e40-95638def9e40"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60bb7c8c-ba4c-407e-b8c3-e2069dffe7af"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b80ea818-518f-45e2-8f12-122775affa34"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(242, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a76247e2-fc48-4082-986f-90615df862cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("3b3778b5-cf8a-4212-8436-2d1afc5f362d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(370, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b40042b7-81bf-40de-8938-872a4b760038"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("b192c1bc-a5cc-4a7b-a1f4-8f5bc165ed51"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(428, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b40042b7-81bf-40de-8938-872a4b760038"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("596cc95d-bd41-421a-8aa2-b5eba7f97d3e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("7361603f-8417-478f-bb04-5ec15f50b929"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f714df29-baa3-4f60-8715-e0877e5cecf4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab9ff4c1-c423-48ad-9a5f-512c37fd9373"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow8",
				UId = new Guid("1ad2ebe9-b9c4-428d-a737-d9ead8b5dfbd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(310, 246),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a74f4a78-9bee-4082-a3bf-9c786f50a00d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a76247e2-fc48-4082-986f-90615df862cc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("f3055681-56c6-4fe2-b303-426139a96916"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(268, 245),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60bb7c8c-ba4c-407e-b8c3-e2069dffe7af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a74f4a78-9bee-4082-a3bf-9c786f50a00d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("b2ad7408-6387-4997-a7e9-2164e80b86cc"),
				ConditionExpression = @"ShowOverflowSchemaCountMessage == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(322, 296),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a74f4a78-9bee-4082-a3bf-9c786f50a00d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b68f71bd-b3b0-45e6-a7e9-fab03b03ffc3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("5e5e2343-2eea-44c2-9a01-bca774c1c08a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(718, 338),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("596cc95d-bd41-421a-8aa2-b5eba7f97d3e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75736147-4fc7-41f3-bec2-7622b491040f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f0c47752-b625-4444-be8e-3fb21d578918"),
				ConditionExpression = @"ShowOverflowSchemaCountMessage == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(546, 335),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75736147-4fc7-41f3-bec2-7622b491040f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b68f71bd-b3b0-45e6-a7e9-fab03b03ffc3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("ef6679ab-f70f-41ad-8b50-bb734ae6283b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(812, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75736147-4fc7-41f3-bec2-7622b491040f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5af0d422-1063-4b35-ba72-187f728658b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("98d12877-66ab-45bb-b890-ba12e4238089"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(846, 364),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b68f71bd-b3b0-45e6-a7e9-fab03b03ffc3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow13",
				UId = new Guid("a55fed1a-fad9-4c13-a546-9aa551e55efe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(812, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5af0d422-1063-4b35-ba72-187f728658b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79289b74-a8d0-41ec-a638-a62e738453e9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("4445a6ae-ba0e-47b5-992f-c27d51c395bf"),
				ConditionExpression = @"ShowOverflowAdminSchemaCountMessage == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(915, 307),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5af0d422-1063-4b35-ba72-187f728658b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a9d504b2-2983-46a3-a77d-0e3446af9ed1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("9659a140-4d71-4605-beae-f55a0dcc7628"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(986, 366),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9d504b2-2983-46a3-a77d-0e3446af9ed1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("48210305-ed3a-4ce6-8a82-3f35bbc3e359"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("34a97359-f071-4caf-b025-0b721e6d89f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8c4a48d9-c865-4fc1-a973-39e03a1afc5e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("befd1877-f871-4265-9331-62551ebdcc52"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1139, 875),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b3a834cf-e429-4ed2-b948-b0b20043dedc"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("befd1877-f871-4265-9331-62551ebdcc52"),
				CreatedInOwnerSchemaUId = new Guid("deb3872c-e0ad-4570-b02f-19a6caf5adba"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 698),
				Size = new Size(1110, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("8317635e-7924-41a4-9e8b-35bdb85f350c"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("befd1877-f871-4265-9331-62551ebdcc52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"Lane2",
				Position = new Point(29, 328),
				Size = new Size(1110, 365),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("416b09b1-5a8a-4eef-891e-f2f87e5c2ead"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("befd1877-f871-4265-9331-62551ebdcc52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"Lane3",
				Position = new Point(29, 164),
				Size = new Size(1110, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("5963cbe2-78c7-414f-ba96-fcbf387f5339"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("befd1877-f871-4265-9331-62551ebdcc52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"Lane4",
				Position = new Point(29, 0),
				Size = new Size(1110, 159),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c3429833-b350-4703-bdcb-f78ab1328065"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3a834cf-e429-4ed2-b948-b0b20043dedc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(312, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("346b1cb2-fa6a-454e-a81a-d1bdd96082c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c3429833-b350-4703-bdcb-f78ab1328065"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("904dfb17-3e27-4ddc-8fae-8541851a81f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c3429833-b350-4703-bdcb-f78ab1328065"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"PageLoadCompleteThrowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8b62e20c-d78c-4a73-ae85-0dd0df0e71f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c3429833-b350-4703-bdcb-f78ab1328065"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,65,75,195,64,16,133,207,22,250,31,150,156,34,36,75,77,42,38,148,30,36,86,9,120,40,198,210,243,100,119,98,151,54,187,113,118,87,241,223,187,49,90,161,199,225,123,239,227,205,70,42,183,133,55,220,213,146,173,217,147,87,146,111,129,44,198,81,185,184,89,182,57,116,105,94,100,89,186,44,23,109,218,230,183,144,98,219,22,37,222,101,157,192,34,186,94,205,103,31,64,204,58,242,194,121,194,32,25,117,252,1,28,52,198,147,64,94,121,34,212,174,249,139,252,86,58,117,114,72,33,127,238,242,138,16,28,62,254,128,189,114,135,176,4,122,12,135,141,47,165,141,56,96,15,201,124,118,53,197,43,211,15,64,202,26,253,250,53,32,223,188,123,56,37,44,218,27,58,218,1,4,214,50,74,216,206,142,65,173,81,56,101,52,63,67,94,203,241,145,255,33,147,211,242,123,41,227,105,231,200,47,55,60,27,144,47,230,211,198,35,36,12,77,205,130,2,87,223,69,120,66,166,85,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8317635e-7924-41a4-9e8b-35bdb85f350c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"EventSubProcess8",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1061, 344),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddEntitySchemaClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("54fab5c9-8fd3-48c4-9e40-95638def9e40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddEntitySchemaClick",
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"AddEntitySchemaClick",
				Position = new Point(15, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitFiltersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a76247e2-fc48-4082-986f-90615df862cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"InitFilters",
				Position = new Point(323, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,82,93,107,219,48,20,125,94,161,255,65,248,41,161,137,250,221,173,164,29,148,36,3,179,175,64,146,246,97,236,225,198,190,78,180,56,146,43,201,237,76,232,127,239,149,20,156,56,140,141,61,12,134,65,96,251,158,115,207,57,58,198,106,33,231,76,72,99,65,38,24,167,236,150,181,90,19,212,26,140,202,44,159,198,252,1,103,125,37,173,86,185,225,35,152,99,219,29,252,206,20,254,133,199,53,148,79,212,216,211,181,218,189,195,131,169,65,77,56,137,137,21,74,178,178,249,122,203,60,75,115,136,80,95,11,148,67,105,133,173,198,201,2,87,240,73,169,101,89,184,177,9,152,37,31,105,149,160,49,31,177,34,134,29,209,71,129,206,29,78,43,8,137,154,79,165,120,44,49,30,16,173,9,54,141,231,156,122,151,209,245,73,6,87,233,201,89,247,28,175,207,187,23,151,233,85,23,222,158,205,186,151,239,210,36,203,224,226,244,20,48,234,177,227,227,251,231,113,101,130,156,88,102,234,207,34,73,197,8,52,172,208,162,54,180,74,226,51,27,8,111,17,116,197,110,130,154,14,83,179,31,100,252,189,143,235,9,52,43,246,129,173,223,160,218,127,165,130,54,52,217,249,93,154,182,162,58,144,168,179,13,199,201,9,130,50,145,239,88,232,171,60,15,23,117,179,213,181,47,43,184,217,0,253,146,166,251,253,121,182,62,60,120,179,102,81,162,86,5,104,97,148,156,84,5,146,156,15,158,162,223,248,204,135,143,37,228,236,165,19,48,57,102,118,248,179,208,212,8,34,39,121,229,74,142,192,46,8,29,209,149,61,40,189,52,5,36,24,213,8,106,225,64,152,34,135,234,30,242,210,173,201,32,55,88,255,215,98,190,216,161,172,227,242,211,134,198,157,153,160,252,219,119,182,222,107,53,175,55,114,170,216,139,123,254,143,48,62,131,164,203,215,95,200,204,191,203,34,218,45,227,102,99,180,77,225,87,245,11,149,13,230,28,227,38,41,55,174,209,150,90,50,171,75,236,189,2,236,92,197,234,165,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEntitySchemaLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2d3cfd23-e0eb-4c8b-bf9e-64b2c1fc8981"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"OpenEntitySchemaLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(442, 41),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenEntitySchemaLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("b40042b7-81bf-40de-8938-872a4b760038"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"IntermediateCatchMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(547, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertEntityScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("79289b74-a8d0-41ec-a638-a62e738453e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"InsertEntity",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(953, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,81,95,111,130,48,16,127,150,132,239,112,243,9,18,195,23,112,46,217,100,146,101,38,51,171,236,189,43,135,116,66,107,250,135,133,44,126,247,149,138,6,124,235,221,253,254,221,53,215,168,214,82,8,100,134,75,1,118,90,174,96,71,15,152,228,147,238,50,12,90,170,160,165,181,69,237,32,31,39,20,175,194,112,211,17,86,97,67,183,82,30,237,169,231,236,169,62,38,25,26,130,181,163,98,241,229,41,209,212,36,6,170,33,229,254,77,85,7,143,218,40,46,14,11,144,223,63,14,241,228,236,120,9,209,213,110,5,194,214,117,252,23,6,51,133,198,42,1,70,89,116,160,115,24,148,82,33,101,85,116,139,7,92,12,57,99,232,25,253,192,242,194,133,246,221,228,29,187,229,208,70,191,129,155,8,252,5,210,105,66,118,227,165,158,25,67,173,183,92,155,251,248,189,0,47,163,135,139,64,178,65,195,170,141,146,77,250,18,205,199,10,249,91,49,95,244,238,177,15,63,27,240,4,77,138,229,90,214,182,17,195,125,188,228,117,126,39,49,4,204,156,78,212,107,141,161,132,182,120,33,159,253,57,252,223,237,21,98,166,120,145,124,98,169,80,87,41,53,212,131,198,215,251,7,38,234,44,51,6,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCalculateSSPSchemaCountScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60bb7c8c-ba4c-407e-b8c3-e2069dffe7af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"CalculateSSPSchemaCount",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,75,14,130,48,16,134,247,38,222,161,75,221,244,2,8,137,118,129,36,26,137,132,3,144,118,148,38,165,37,211,86,226,237,173,104,12,69,182,243,63,102,190,41,152,81,10,184,147,70,239,114,47,69,70,172,237,43,222,66,215,212,82,88,146,146,28,92,85,149,204,35,130,118,95,165,16,118,179,77,214,171,185,192,140,215,46,100,162,14,58,78,223,238,214,12,151,7,224,77,153,97,226,63,131,181,205,29,66,108,185,46,75,73,25,116,90,91,64,102,180,254,92,75,79,146,31,65,245,128,52,196,38,254,176,168,88,130,218,139,78,234,57,217,56,148,214,97,227,64,28,158,87,224,6,197,4,50,2,137,137,163,232,31,254,108,219,239,7,8,206,163,38,14,61,36,47,232,94,10,123,124,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway1InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("a74f4a78-9bee-4082-a3bf-9c786f50a00d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"InclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateShowMessageSSPMaxSchemaCountUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c90251ce-66b7-42a1-9d93-2562f7480a9c"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"ShowMessageSSPMaxSchemaCount",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(953, 160),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowMessageSSPMaxSchemaCountParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("596cc95d-bd41-421a-8aa2-b5eba7f97d3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(617, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,221,78,194,64,16,133,175,33,225,29,198,187,54,154,190,0,148,4,171,65,34,6,98,197,251,181,59,133,149,101,151,236,15,164,49,190,187,211,210,52,165,17,241,162,201,182,253,206,156,153,51,155,110,244,113,113,64,147,75,125,76,179,13,238,88,162,189,114,47,104,45,91,35,196,144,51,105,113,56,232,167,45,112,194,119,66,253,73,31,152,1,111,209,36,90,41,204,156,208,138,126,46,137,137,86,103,95,107,244,192,164,71,75,200,98,143,234,81,57,225,138,83,249,185,214,91,191,47,53,111,204,110,163,41,186,20,37,73,145,191,87,146,224,220,36,4,102,225,65,84,103,102,10,24,89,103,132,90,223,129,254,248,36,98,76,118,34,135,160,182,187,137,65,121,41,195,175,65,191,151,166,203,196,27,131,202,181,230,130,219,184,110,45,170,222,135,37,120,45,176,223,43,141,59,113,68,115,145,61,161,220,163,137,72,208,34,75,143,89,162,165,60,113,163,169,23,124,12,182,2,86,51,78,6,10,143,208,5,130,176,212,229,218,32,203,54,65,19,41,8,85,15,80,13,217,107,202,68,19,206,131,178,80,169,62,229,17,61,99,17,86,101,190,233,17,212,51,43,215,44,40,66,70,121,223,23,175,152,105,195,219,67,197,64,11,153,92,166,200,200,6,141,103,216,10,177,201,232,76,221,137,254,154,127,119,29,151,175,229,63,252,254,94,208,37,25,181,64,105,25,116,222,40,112,198,227,240,7,185,139,53,101,81,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway2InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("75736147-4fc7-41f3-bec2-7622b491040f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"InclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(722, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateInitUserMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b68f71bd-b3b0-45e6-a7e9-fab03b03ffc3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"InitUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(715, 244),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,11,130,64,16,133,239,65,255,65,60,21,200,254,1,233,146,32,73,153,194,86,247,101,153,84,208,217,152,157,77,127,126,187,32,148,116,240,56,239,125,243,230,77,135,28,13,106,146,178,150,186,133,65,101,198,121,229,16,213,170,1,113,183,64,153,65,4,205,157,65,113,233,244,9,250,23,144,88,226,233,118,35,91,51,150,96,173,223,242,94,233,3,191,182,8,89,115,228,26,58,27,55,152,66,9,203,212,97,35,114,67,131,226,93,245,6,122,246,102,92,30,159,55,196,67,245,14,146,255,95,146,200,207,153,35,2,228,31,121,191,214,164,208,6,125,133,184,184,230,85,188,6,31,29,179,65,27,248,234,28,104,2,118,132,17,147,131,244,3,93,17,190,44,99,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway3InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("5af0d422-1063-4b35-ba72-187f728658b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"InclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(813, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a9d504b2-2983-46a3-a77d-0e3446af9ed1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0817dd0-2129-41ca-b79a-f0c0da45fc22"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(806, 160),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,193,10,130,64,16,134,239,65,239,32,158,10,100,95,64,58,148,32,73,153,130,213,125,209,73,23,220,217,152,157,77,31,191,21,132,186,148,231,239,155,159,111,20,114,160,229,88,85,229,190,209,10,149,101,146,12,77,85,119,160,101,98,156,199,187,160,148,45,136,155,5,74,12,34,212,172,12,138,179,170,143,208,63,129,132,191,253,210,227,245,170,234,204,144,131,181,254,202,179,220,175,127,176,152,182,230,201,37,117,6,87,24,167,8,95,166,176,21,169,33,45,121,83,188,128,30,189,25,254,132,207,231,226,46,123,7,209,194,151,81,224,97,226,136,0,249,151,179,93,10,206,106,131,190,52,204,46,105,17,46,201,7,199,108,208,78,126,113,154,108,2,118,132,1,147,131,248,13,216,39,178,156,151,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f37a4656-2586-438f-8df2-782cd9b78cc8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("416b09b1-5a8a-4eef-891e-f2f87e5c2ead"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"EventSubProcess9",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteEntitySchemaClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f714df29-baa3-4f60-8715-e0877e5cecf4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f37a4656-2586-438f-8df2-782cd9b78cc8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteEntitySchemaClick",
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"DeleteEntitySchemaClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteEntitySchemaScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ab9ff4c1-c423-48ad-9a5f-512c37fd9373"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f37a4656-2586-438f-8df2-782cd9b78cc8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"DeleteEntitySchemaScriptTask",
				Position = new Point(127, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,77,75,3,49,16,134,207,93,216,255,48,244,148,5,9,222,203,30,180,107,69,16,41,70,189,136,135,144,204,186,129,54,129,201,164,82,164,255,221,108,220,67,115,76,230,121,63,102,78,154,32,226,1,13,163,125,9,22,35,244,176,215,223,40,223,8,241,145,156,149,234,122,186,105,27,55,130,168,20,114,27,146,103,232,123,184,237,126,219,102,69,200,137,60,48,37,204,248,165,109,222,35,210,54,120,159,37,46,120,72,245,115,201,171,161,44,28,3,161,54,147,56,229,134,62,231,128,243,117,211,18,54,79,157,205,38,51,34,63,244,33,97,252,92,63,217,245,215,102,153,162,103,199,231,153,192,31,80,231,168,212,254,161,124,41,51,225,81,223,25,131,49,62,187,200,162,46,214,205,6,110,20,255,122,185,67,54,211,142,194,113,184,23,179,255,77,142,237,74,133,213,66,12,185,28,163,40,186,75,89,188,62,228,43,142,132,113,26,52,235,2,93,223,233,15,5,128,24,99,135,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e931cf35-f26a-4e3f-b8ef-6912fcafe1fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5963cbe2-78c7-414f-ba96-fcbf387f5339"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"EventSubProcess10",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("34a97359-f071-4caf-b025-0b721e6d89f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e931cf35-f26a-4e3f-b8ef-6912fcafe1fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"StartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8c4a48d9-c865-4fc1-a973-39e03a1afc5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e931cf35-f26a-4e3f-b8ef-6912fcafe1fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Name = @"ScriptTask4",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetSSPCurrentSchemaUIdsMethod());
			Methods.Add(CreateGetAdministratedByRecordSchemaUIdsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("041fcb2d-16ba-477c-9741-12c21b0a1395"),
				Name = "System",
				Alias = "System",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8a855b91-4072-4098-a1b9-21ecf8d621b2"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
		}

		protected override SchemaMethod CreateGetRegisterTreeGridDblClickScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterTreeGridDblClickScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSSPCurrentSchemaUIdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb749258-ee04-4ef1-8e14-3f1fae14b4c1"),
				Name = "GetSSPCurrentSchemaUIds",
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				ResultValueTypeName = "ICollection<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,207,110,194,48,12,198,207,32,241,14,81,79,233,197,47,192,138,132,80,135,42,113,168,136,128,179,149,88,163,90,155,108,249,3,67,211,222,125,9,129,173,108,151,200,177,127,182,63,127,39,180,44,56,178,43,163,53,73,223,25,205,42,214,226,11,193,238,33,59,159,77,79,17,117,242,72,3,238,26,229,34,166,233,204,86,166,239,51,241,180,14,157,90,240,242,78,82,202,179,106,54,157,36,78,92,191,252,113,85,25,139,19,136,35,194,160,121,81,107,223,249,139,184,111,40,82,21,158,173,25,120,177,63,139,139,19,162,29,35,75,41,201,185,77,231,124,38,15,71,178,196,139,131,177,175,238,13,37,165,9,208,184,250,61,96,207,243,14,104,209,226,64,158,236,31,33,240,211,5,141,42,175,178,208,221,52,199,123,242,45,80,127,144,12,158,182,132,42,78,80,232,49,135,172,90,176,207,216,243,107,14,44,149,26,1,176,38,159,21,236,177,15,116,115,234,255,193,201,187,175,244,88,242,193,234,145,219,243,111,250,69,73,210,168,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAdministratedByRecordSchemaUIdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c69f02bc-b85a-4a81-929b-abda2a4fc9f8"),
				Name = "GetAdministratedByRecordSchemaUIds",
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				ResultValueTypeName = "ICollection<Guid>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f8c5a2bd-e2b4-45f2-8d80-84c788e99245"),
				Name = "schemaUIds",
				CreatedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				ModifiedInSchemaUId = new Guid("379e1992-f260-4988-aeec-5c653cd8940e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ICollection<Guid>",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,59,107,195,48,16,158,29,240,127,16,158,228,69,180,115,106,131,107,210,144,169,33,193,201,124,181,174,141,90,91,106,245,72,26,74,254,123,37,203,20,135,208,69,72,119,223,227,248,78,71,208,196,9,110,72,65,36,158,72,173,186,14,91,43,148,124,88,250,114,73,243,121,58,19,175,132,154,246,128,61,52,43,110,88,173,156,180,164,36,119,249,79,58,75,142,65,192,160,174,149,148,145,233,165,214,240,134,172,185,170,206,71,172,193,96,64,10,255,76,130,227,118,120,211,107,137,60,116,19,239,212,185,94,210,204,219,102,67,137,61,105,213,211,108,119,170,120,47,164,48,86,131,21,71,124,126,121,247,60,51,98,246,7,212,72,179,9,4,249,227,121,131,173,210,220,99,216,202,44,190,28,116,52,170,179,53,104,232,209,162,166,247,121,20,168,36,167,217,246,108,246,74,127,152,79,104,49,216,255,79,187,30,157,253,177,216,138,79,5,155,168,34,111,4,204,36,220,60,39,96,198,76,66,98,49,45,182,248,198,214,89,220,32,112,111,200,193,66,188,146,162,36,97,9,73,88,33,171,56,159,244,216,18,109,180,218,65,231,112,220,103,28,35,108,53,185,132,243,146,206,52,90,167,229,240,11,230,191,189,84,86,193,15,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysSSPEntitySchemaAccessListGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("379e1992-f260-4988-aeec-5c653cd8940e"));
		}

		#endregion

	}

	#endregion

}

