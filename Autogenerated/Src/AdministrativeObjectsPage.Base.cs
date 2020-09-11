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

	#region Class: AdministrativeObjectsPage_Base_TerrasoftSchema

	/// <exclude/>
	public class AdministrativeObjectsPage_Base_TerrasoftSchema : Terrasoft.WebApp.BaseModulePageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _checkMenuItemAll;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAll {
			get {
				return _checkMenuItemAll;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _checkMenuItemModule;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemModule {
			get {
				return _checkMenuItemModule;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuSeparator _menuSeparator;
		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparator {
			get {
				return _menuSeparator;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _checkMenuItemLookup;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemLookup {
			get {
				return _checkMenuItemLookup;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _checkMenuItemAdministratedByRecords;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAdministratedByRecords {
			get {
				return _checkMenuItemAdministratedByRecords;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _checkMenuItemAdministratedByColumns;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAdministratedByColumns {
			get {
				return _checkMenuItemAdministratedByColumns;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _checkMenuItemAdministratedByOperations;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAdministratedByOperations {
			get {
				return _checkMenuItemAdministratedByOperations;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrativeObjectsPage_Base_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectsPage_Base_TerrasoftSchema(AdministrativeObjectsPage_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.Enabled = false;
			LeftControlLayout.Hidden = true;
			LeftControlLayout.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		private void UpdateGrid() {
			Grid.PageSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
			Grid.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ShowMenuItemCaption = true;
			GridTab.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
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
			RightControlLayout.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			RealUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			Name = "AdministrativeObjectsPage_Base_Terrasoft";
			ParentSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema();
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
			LeftControlLayout.MoveItem(0, CustomSearchContainer);
			LeftControlLayout.MoveItem(1, FolderLayout);
			FolderLayout.MoveItem(0, BaseFolder);
			LeftControlLayout.MoveItem(2, FilterEditLayout);
			FilterEditLayout.MoveItem(0, FilterEdit);
			FilterEdit.MoveItem(0, SaveToolButton);
			FilterEdit.MoveItem(1, ApplyToolButton);
			MainControlLayout.MoveItem(1, RightControlLayout);
			RightControlLayout.MoveItem(0, GridTabPanel);
			GridTabPanel.MoveItem(0, GridTab);
			GridTab.MoveItem(0, Grid);
			GridTab.InsertItem(0, CreateCheckMenuItemAll());
			GridTab.InsertItem(1, CreateCheckMenuItemModule());
			GridTab.InsertItem(2, CreateCheckMenuItemLookup());
			GridTab.InsertItem(3, CreateMenuSeparator());
			GridTab.InsertItem(4, CreateCheckMenuItemAdministratedByRecords());
			GridTab.InsertItem(5, CreateCheckMenuItemAdministratedByColumns());
			GridTab.InsertItem(6, CreateCheckMenuItemAdministratedByOperations());
			RightControlLayout.MoveItem(1, DetailsTabPanel);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema() {
			var schema = new AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateCheckMenuItemAll() {
			_checkMenuItemAll = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_checkMenuItemAll.UId = new Guid("09883597-f46e-42f1-a25d-7d4b93c9e921");
			_checkMenuItemAll.Name = "CheckMenuItemAll";
			_checkMenuItemAll.CreatedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAll.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAll.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkMenuItemAll.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_checkMenuItemAll.Group = "AdministratedObjects";
			_checkMenuItemAll.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkMenuItemAll.Image = new ControlImage {};
			_checkMenuItemAll.Tag = "All";
			return _checkMenuItemAll;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateCheckMenuItemModule() {
			_checkMenuItemModule = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_checkMenuItemModule.UId = new Guid("8a5455e2-506b-450b-b45d-54702d374c0f");
			_checkMenuItemModule.Name = "CheckMenuItemModule";
			_checkMenuItemModule.CreatedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemModule.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemModule.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkMenuItemModule.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_checkMenuItemModule.Group = "AdministratedObjects";
			_checkMenuItemModule.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkMenuItemModule.Image = new ControlImage {};
			_checkMenuItemModule.Tag = "Module";
			return _checkMenuItemModule;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateCheckMenuItemLookup() {
			_checkMenuItemLookup = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_checkMenuItemLookup.UId = new Guid("9ce4a0c9-433a-412f-b433-f6c7caeb59bf");
			_checkMenuItemLookup.Name = "CheckMenuItemLookup";
			_checkMenuItemLookup.CreatedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemLookup.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemLookup.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkMenuItemLookup.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_checkMenuItemLookup.Group = "AdministratedObjects";
			_checkMenuItemLookup.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkMenuItemLookup.Image = new ControlImage {};
			_checkMenuItemLookup.Tag = "Lookup";
			return _checkMenuItemLookup;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparator() {
			_menuSeparator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
			_menuSeparator.UId = new Guid("5515e37e-ec38-41f5-8c14-901cb4347888");
			_menuSeparator.Name = "MenuSeparator";
			_menuSeparator.CreatedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_menuSeparator.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_menuSeparator.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_menuSeparator.Tag = "";
			_menuSeparator.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_menuSeparator.Image = new ControlImage {};
			return _menuSeparator;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateCheckMenuItemAdministratedByRecords() {
			_checkMenuItemAdministratedByRecords = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_checkMenuItemAdministratedByRecords.UId = new Guid("a9260900-fec8-4376-bb4e-59c71f30054a");
			_checkMenuItemAdministratedByRecords.Name = "CheckMenuItemAdministratedByRecords";
			_checkMenuItemAdministratedByRecords.CreatedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAdministratedByRecords.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAdministratedByRecords.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkMenuItemAdministratedByRecords.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_checkMenuItemAdministratedByRecords.Group = "AdministratedObjects";
			_checkMenuItemAdministratedByRecords.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkMenuItemAdministratedByRecords.Image = new ControlImage {};
			_checkMenuItemAdministratedByRecords.Tag = "AdministratedByRecords";
			return _checkMenuItemAdministratedByRecords;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateCheckMenuItemAdministratedByColumns() {
			_checkMenuItemAdministratedByColumns = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_checkMenuItemAdministratedByColumns.UId = new Guid("183f07f5-1278-44bf-8ebc-e3cfe5fa0f70");
			_checkMenuItemAdministratedByColumns.Name = "CheckMenuItemAdministratedByColumns";
			_checkMenuItemAdministratedByColumns.CreatedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAdministratedByColumns.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAdministratedByColumns.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkMenuItemAdministratedByColumns.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_checkMenuItemAdministratedByColumns.Group = "AdministratedObjects";
			_checkMenuItemAdministratedByColumns.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkMenuItemAdministratedByColumns.Image = new ControlImage {};
			_checkMenuItemAdministratedByColumns.Tag = "AdministratedByColumns";
			return _checkMenuItemAdministratedByColumns;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateCheckMenuItemAdministratedByOperations() {
			_checkMenuItemAdministratedByOperations = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_checkMenuItemAdministratedByOperations.UId = new Guid("8641d345-6a5c-4ac3-bae7-ad195be33ed0");
			_checkMenuItemAdministratedByOperations.Name = "CheckMenuItemAdministratedByOperations";
			_checkMenuItemAdministratedByOperations.CreatedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAdministratedByOperations.ModifiedInSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			_checkMenuItemAdministratedByOperations.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkMenuItemAdministratedByOperations.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_checkMenuItemAdministratedByOperations.Group = "AdministratedObjects";
			_checkMenuItemAdministratedByOperations.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkMenuItemAdministratedByOperations.Image = new ControlImage {};
			_checkMenuItemAdministratedByOperations.Tag = "AdministratedByOperations";
			return _checkMenuItemAdministratedByOperations;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectsPage_Base_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectsPage_Base_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectsPage_Base_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsPage_Base_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseModulePageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeObjectsPage_Base_TerrasoftSchemaUserControl
	{

		public AdministrativeObjectsPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectsPage_Base_TerrasoftEventsProcess";
			SchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
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

		private ProcessFlowElement _subProcess14;
		public ProcessFlowElement SubProcess14 {
			get {
				return _subProcess14 ?? (_subProcess14 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess14",
					SchemaElementUId = new Guid("ccdceab0-441b-48c9-9ed8-0084919a847d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageCheckMenuItemAllCheckChange;
		public ProcessFlowElement StartMessageCheckMenuItemAllCheckChange {
			get {
				return _startMessageCheckMenuItemAllCheckChange ?? (_startMessageCheckMenuItemAllCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageCheckMenuItemAllCheckChange",
					SchemaElementUId = new Guid("790fca53-3580-42da-8316-d02d41bc2e1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_AdministratedObjectsAll;
		public ProcessScriptTask ScriptTask_AdministratedObjectsAll {
			get {
				return _scriptTask_AdministratedObjectsAll ?? (_scriptTask_AdministratedObjectsAll = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_AdministratedObjectsAll",
					SchemaElementUId = new Guid("0cf07833-9ba0-4986-9a3f-224d608be047"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_AdministratedObjectsAllExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess15;
		public ProcessFlowElement SubProcess15 {
			get {
				return _subProcess15 ?? (_subProcess15 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess15",
					SchemaElementUId = new Guid("46206f19-fe71-4af1-8405-ff31adc07db1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2CheckMenuItemModuleCheckChange;
		public ProcessFlowElement StartMessage2CheckMenuItemModuleCheckChange {
			get {
				return _startMessage2CheckMenuItemModuleCheckChange ?? (_startMessage2CheckMenuItemModuleCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2CheckMenuItemModuleCheckChange",
					SchemaElementUId = new Guid("d4f31f08-8aa8-437a-9ea4-fcf50c090877"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_AdministratedObjectsModule;
		public ProcessScriptTask ScriptTask_AdministratedObjectsModule {
			get {
				return _scriptTask_AdministratedObjectsModule ?? (_scriptTask_AdministratedObjectsModule = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_AdministratedObjectsModule",
					SchemaElementUId = new Guid("266da258-e50e-4f18-a0c3-56be54a6b9c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_AdministratedObjectsModuleExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess16;
		public ProcessFlowElement SubProcess16 {
			get {
				return _subProcess16 ?? (_subProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess16",
					SchemaElementUId = new Guid("5c90e11f-4258-4093-8144-08ad464d6f7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageCheckMenuItemLookupCheckChange;
		public ProcessFlowElement StartMessageCheckMenuItemLookupCheckChange {
			get {
				return _startMessageCheckMenuItemLookupCheckChange ?? (_startMessageCheckMenuItemLookupCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageCheckMenuItemLookupCheckChange",
					SchemaElementUId = new Guid("14bd841c-1d33-4e40-bbdb-34a5f6273e74"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_AdministratedObjectsLookup;
		public ProcessScriptTask ScriptTask_AdministratedObjectsLookup {
			get {
				return _scriptTask_AdministratedObjectsLookup ?? (_scriptTask_AdministratedObjectsLookup = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_AdministratedObjectsLookup",
					SchemaElementUId = new Guid("dcbbf799-cdc8-47fc-bd22-02d92a7ad0fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_AdministratedObjectsLookupExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess17;
		public ProcessFlowElement SubProcess17 {
			get {
				return _subProcess17 ?? (_subProcess17 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess17",
					SchemaElementUId = new Guid("373bb5b6-a232-48b2-9b59-fd320f7b658f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageCheckMenuItemAdministratedByRecordsCheckChange;
		public ProcessFlowElement StartMessageCheckMenuItemAdministratedByRecordsCheckChange {
			get {
				return _startMessageCheckMenuItemAdministratedByRecordsCheckChange ?? (_startMessageCheckMenuItemAdministratedByRecordsCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageCheckMenuItemAdministratedByRecordsCheckChange",
					SchemaElementUId = new Guid("d4f5bb95-ef57-49c5-975c-b2ee380aafc8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_AdministratedObjectsByRecords;
		public ProcessScriptTask ScriptTask_AdministratedObjectsByRecords {
			get {
				return _scriptTask_AdministratedObjectsByRecords ?? (_scriptTask_AdministratedObjectsByRecords = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_AdministratedObjectsByRecords",
					SchemaElementUId = new Guid("4e2b5356-204d-4da0-8ea9-2019b72981fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_AdministratedObjectsByRecordsExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess18;
		public ProcessFlowElement SubProcess18 {
			get {
				return _subProcess18 ?? (_subProcess18 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess18",
					SchemaElementUId = new Guid("993521a0-352a-4091-ab08-8e7cbcbdce7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2CheckMenuItemAdministratedByColumnsCheckChange;
		public ProcessFlowElement StartMessage2CheckMenuItemAdministratedByColumnsCheckChange {
			get {
				return _startMessage2CheckMenuItemAdministratedByColumnsCheckChange ?? (_startMessage2CheckMenuItemAdministratedByColumnsCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2CheckMenuItemAdministratedByColumnsCheckChange",
					SchemaElementUId = new Guid("9352cf88-1d92-45d7-9fcd-d0d3eb9c007b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_AdministratedObjectsByColumns;
		public ProcessScriptTask ScriptTask_AdministratedObjectsByColumns {
			get {
				return _scriptTask_AdministratedObjectsByColumns ?? (_scriptTask_AdministratedObjectsByColumns = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_AdministratedObjectsByColumns",
					SchemaElementUId = new Guid("180a0af7-ed24-4e0d-b8bd-901ca021a0e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_AdministratedObjectsByColumnsExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess13;
		public ProcessFlowElement SubProcess13 {
			get {
				return _subProcess13 ?? (_subProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess13",
					SchemaElementUId = new Guid("f3c31cb5-77eb-4d93-a23b-7bea85e5247e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChild;
		public ProcessFlowElement PageLoadCompleteChild {
			get {
				return _pageLoadCompleteChild ?? (_pageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChild",
					SchemaElementUId = new Guid("2baeba51-db0d-42a2-9f2e-42120b8c87b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadCompleteChild;
		public ProcessScriptTask ScriptPageLoadCompleteChild {
			get {
				return _scriptPageLoadCompleteChild ?? (_scriptPageLoadCompleteChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadCompleteChild",
					SchemaElementUId = new Guid("113b8cc2-8fca-4f8a-98d8-9a695917eccb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess20;
		public ProcessFlowElement SubProcess20 {
			get {
				return _subProcess20 ?? (_subProcess20 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess20",
					SchemaElementUId = new Guid("ba310071-e84f-4252-b1f6-d6a1ef326348"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _folderActiveRowChangedChild;
		public ProcessFlowElement FolderActiveRowChangedChild {
			get {
				return _folderActiveRowChangedChild ?? (_folderActiveRowChangedChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FolderActiveRowChangedChild",
					SchemaElementUId = new Guid("ec6b9b2f-43a1-47aa-8de3-13685be9771d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptFolderActiveRowChangedChild;
		public ProcessScriptTask ScriptFolderActiveRowChangedChild {
			get {
				return _scriptFolderActiveRowChangedChild ?? (_scriptFolderActiveRowChangedChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptFolderActiveRowChangedChild",
					SchemaElementUId = new Guid("f6b0501e-f07e-489a-9c9d-2867ceb6dec2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptFolderActiveRowChangedChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess21;
		public ProcessFlowElement SubProcess21 {
			get {
				return _subProcess21 ?? (_subProcess21 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess21",
					SchemaElementUId = new Guid("ca50cd36-03b0-4826-b8c4-8b1b2938d3f7"),
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
					SchemaElementUId = new Guid("34195cdc-5dd4-41d9-ab49-31ea4a3c4db5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("68b56631-3b56-49ba-99da-307480c93793"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitChildExecute,
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
					SchemaElementUId = new Guid("a71fc9f3-5e78-427a-b0cd-56103f115335"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _processAdministratedByOperationsCheckChange;
		public ProcessFlowElement ProcessAdministratedByOperationsCheckChange {
			get {
				return _processAdministratedByOperationsCheckChange ?? (_processAdministratedByOperationsCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessAdministratedByOperationsCheckChange",
					SchemaElementUId = new Guid("086d27db-1d53-46f9-929c-8023d0ae1b71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startAdministratedByOperationsCheckChange;
		public ProcessFlowElement StartAdministratedByOperationsCheckChange {
			get {
				return _startAdministratedByOperationsCheckChange ?? (_startAdministratedByOperationsCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartAdministratedByOperationsCheckChange",
					SchemaElementUId = new Guid("e17abcba-40b3-4c57-bd21-d5f92d727b97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAdministratedByOperationsCheckChange;
		public ProcessScriptTask ScriptAdministratedByOperationsCheckChange {
			get {
				return _scriptAdministratedByOperationsCheckChange ?? (_scriptAdministratedByOperationsCheckChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdministratedByOperationsCheckChange",
					SchemaElementUId = new Guid("d66be0c7-69c7-4204-8636-85333b074536"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdministratedByOperationsCheckChangeExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess14 };
			FlowElements[StartMessageCheckMenuItemAllCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageCheckMenuItemAllCheckChange };
			FlowElements[ScriptTask_AdministratedObjectsAll.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_AdministratedObjectsAll };
			FlowElements[SubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess15 };
			FlowElements[StartMessage2CheckMenuItemModuleCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2CheckMenuItemModuleCheckChange };
			FlowElements[ScriptTask_AdministratedObjectsModule.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_AdministratedObjectsModule };
			FlowElements[SubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess16 };
			FlowElements[StartMessageCheckMenuItemLookupCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageCheckMenuItemLookupCheckChange };
			FlowElements[ScriptTask_AdministratedObjectsLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_AdministratedObjectsLookup };
			FlowElements[SubProcess17.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess17 };
			FlowElements[StartMessageCheckMenuItemAdministratedByRecordsCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageCheckMenuItemAdministratedByRecordsCheckChange };
			FlowElements[ScriptTask_AdministratedObjectsByRecords.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_AdministratedObjectsByRecords };
			FlowElements[SubProcess18.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess18 };
			FlowElements[StartMessage2CheckMenuItemAdministratedByColumnsCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2CheckMenuItemAdministratedByColumnsCheckChange };
			FlowElements[ScriptTask_AdministratedObjectsByColumns.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_AdministratedObjectsByColumns };
			FlowElements[SubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess13 };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[SubProcess20.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess20 };
			FlowElements[FolderActiveRowChangedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { FolderActiveRowChangedChild };
			FlowElements[ScriptFolderActiveRowChangedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptFolderActiveRowChangedChild };
			FlowElements[SubProcess21.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess21 };
			FlowElements[InitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitChild };
			FlowElements[ScriptInitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitChild };
			FlowElements[ThrowInitParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowInitParent };
			FlowElements[ProcessAdministratedByOperationsCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessAdministratedByOperationsCheckChange };
			FlowElements[StartAdministratedByOperationsCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartAdministratedByOperationsCheckChange };
			FlowElements[ScriptAdministratedByOperationsCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdministratedByOperationsCheckChange };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess14":
						break;
					case "StartMessageCheckMenuItemAllCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptTask_AdministratedObjectsAll");
						break;
					case "ScriptTask_AdministratedObjectsAll":
						break;
					case "SubProcess15":
						break;
					case "StartMessage2CheckMenuItemModuleCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptTask_AdministratedObjectsModule");
						break;
					case "ScriptTask_AdministratedObjectsModule":
						break;
					case "SubProcess16":
						break;
					case "StartMessageCheckMenuItemLookupCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptTask_AdministratedObjectsLookup");
						break;
					case "ScriptTask_AdministratedObjectsLookup":
						break;
					case "SubProcess17":
						break;
					case "StartMessageCheckMenuItemAdministratedByRecordsCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptTask_AdministratedObjectsByRecords");
						break;
					case "ScriptTask_AdministratedObjectsByRecords":
						break;
					case "SubProcess18":
						break;
					case "StartMessage2CheckMenuItemAdministratedByColumnsCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptTask_AdministratedObjectsByColumns");
						break;
					case "ScriptTask_AdministratedObjectsByColumns":
						break;
					case "SubProcess13":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						break;
					case "SubProcess20":
						break;
					case "FolderActiveRowChangedChild":
						e.Context.QueueTasks.Enqueue("ScriptFolderActiveRowChangedChild");
						break;
					case "ScriptFolderActiveRowChangedChild":
						break;
					case "SubProcess21":
						break;
					case "InitChild":
						e.Context.QueueTasks.Enqueue("ScriptInitChild");
						break;
					case "ScriptInitChild":
						e.Context.QueueTasks.Enqueue("ThrowInitParent");
						break;
					case "ThrowInitParent":
						break;
					case "ProcessAdministratedByOperationsCheckChange":
						break;
					case "StartAdministratedByOperationsCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptAdministratedByOperationsCheckChange");
						break;
					case "ScriptAdministratedByOperationsCheckChange":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageCheckMenuItemAllCheckChange");
			ActivatedEventElements.Add("StartMessage2CheckMenuItemModuleCheckChange");
			ActivatedEventElements.Add("StartMessageCheckMenuItemLookupCheckChange");
			ActivatedEventElements.Add("StartMessageCheckMenuItemAdministratedByRecordsCheckChange");
			ActivatedEventElements.Add("StartMessage2CheckMenuItemAdministratedByColumnsCheckChange");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("FolderActiveRowChangedChild");
			ActivatedEventElements.Add("InitChild");
			ActivatedEventElements.Add("StartAdministratedByOperationsCheckChange");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageCheckMenuItemAllCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageCheckMenuItemAllCheckChange";
					result = StartMessageCheckMenuItemAllCheckChange.Execute(context);
					break;
				case "ScriptTask_AdministratedObjectsAll":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_AdministratedObjectsAll";
					result = ScriptTask_AdministratedObjectsAll.Execute(context, ScriptTask_AdministratedObjectsAllExecute);
					break;
				case "SubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2CheckMenuItemModuleCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2CheckMenuItemModuleCheckChange";
					result = StartMessage2CheckMenuItemModuleCheckChange.Execute(context);
					break;
				case "ScriptTask_AdministratedObjectsModule":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_AdministratedObjectsModule";
					result = ScriptTask_AdministratedObjectsModule.Execute(context, ScriptTask_AdministratedObjectsModuleExecute);
					break;
				case "SubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageCheckMenuItemLookupCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageCheckMenuItemLookupCheckChange";
					result = StartMessageCheckMenuItemLookupCheckChange.Execute(context);
					break;
				case "ScriptTask_AdministratedObjectsLookup":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_AdministratedObjectsLookup";
					result = ScriptTask_AdministratedObjectsLookup.Execute(context, ScriptTask_AdministratedObjectsLookupExecute);
					break;
				case "SubProcess17":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageCheckMenuItemAdministratedByRecordsCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageCheckMenuItemAdministratedByRecordsCheckChange";
					result = StartMessageCheckMenuItemAdministratedByRecordsCheckChange.Execute(context);
					break;
				case "ScriptTask_AdministratedObjectsByRecords":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_AdministratedObjectsByRecords";
					result = ScriptTask_AdministratedObjectsByRecords.Execute(context, ScriptTask_AdministratedObjectsByRecordsExecute);
					break;
				case "SubProcess18":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2CheckMenuItemAdministratedByColumnsCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2CheckMenuItemAdministratedByColumnsCheckChange";
					result = StartMessage2CheckMenuItemAdministratedByColumnsCheckChange.Execute(context);
					break;
				case "ScriptTask_AdministratedObjectsByColumns":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_AdministratedObjectsByColumns";
					result = ScriptTask_AdministratedObjectsByColumns.Execute(context, ScriptTask_AdministratedObjectsByColumnsExecute);
					break;
				case "SubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
					break;
				case "SubProcess20":
					context.QueueTasks.Dequeue();
					break;
				case "FolderActiveRowChangedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "FolderActiveRowChangedChild";
					result = FolderActiveRowChangedChild.Execute(context);
					break;
				case "ScriptFolderActiveRowChangedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptFolderActiveRowChangedChild";
					result = ScriptFolderActiveRowChangedChild.Execute(context, ScriptFolderActiveRowChangedChildExecute);
					break;
				case "SubProcess21":
					context.QueueTasks.Dequeue();
					break;
				case "InitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitChild";
					result = InitChild.Execute(context);
					break;
				case "ScriptInitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitChild";
					result = ScriptInitChild.Execute(context, ScriptInitChildExecute);
					break;
				case "ThrowInitParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ThrowInitParent.Execute(context);
					break;
				case "ProcessAdministratedByOperationsCheckChange":
					context.QueueTasks.Dequeue();
					break;
				case "StartAdministratedByOperationsCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartAdministratedByOperationsCheckChange";
					result = StartAdministratedByOperationsCheckChange.Execute(context);
					break;
				case "ScriptAdministratedByOperationsCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdministratedByOperationsCheckChange";
					result = ScriptAdministratedByOperationsCheckChange.Execute(context, ScriptAdministratedByOperationsCheckChangeExecute);
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

		public virtual bool ScriptTask_AdministratedObjectsAllExecute(ProcessExecutingContext context) {
			MenuItemClick("All");
			return true;
		}

		public virtual bool ScriptTask_AdministratedObjectsModuleExecute(ProcessExecutingContext context) {
			MenuItemClick("Module");
			return true;
		}

		public virtual bool ScriptTask_AdministratedObjectsLookupExecute(ProcessExecutingContext context) {
			MenuItemClick("Lookup");
			return true;
		}

		public virtual bool ScriptTask_AdministratedObjectsByRecordsExecute(ProcessExecutingContext context) {
			MenuItemClick("AdministratedByRecords");
			return true;
		}

		public virtual bool ScriptTask_AdministratedObjectsByColumnsExecute(ProcessExecutingContext context) {
			MenuItemClick("AdministratedByColumns");
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteAnyOperation("CanManageAdministration", "CanViewConfiguration");
			SetDefaultModuleParameters();
			var process = Page.BaseFolder.PageInstance.Process as Terrasoft.WebApp.BaseModuleFoldersPageEventsProcess<
			Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl>;
			process.EntitySchemaUId = FolderEntitySchemaUId;
			process.ListenerPage = Page;
			process.ListenerPageProcessUId = Page.Process.InstanceUId;
			var gridInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			gridInstance.Process.SetPropertyValue("ListenerPage", Page);
			gridInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			DataSource activeDataSource = GetActiveDataSource();
			Page.FilterEdit.DataSourceId = activeDataSource.ClientID;
			var pageInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var dataSource = pageInstance.DataSource;
			dataSource.LoadRows();
			Page.FilterEdit.DataSourceId = null;
			Page.CheckMenuItemAll.Checked = true;
			HasAnalytics = false;
			return true;
		}

		public virtual bool ScriptFolderActiveRowChangedChildExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptInitChildExecute(ProcessExecutingContext context) {
			SysModuleId = new Guid("FE571096-F36B-1410-2781-485B39B2EDCC");
			FolderEntitySchemaUId = new Guid("D5D01FCD-6D8C-4B29-9E58-CCA3FFE62364");
			FolderEntryEntitySchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			return true;
		}

		public virtual bool ScriptAdministratedByOperationsCheckChangeExecute(ProcessExecutingContext context) {
			MenuItemClick("AdministratedByOperations");
			return true;
		}

		public virtual void MenuItemClick(string tag) {
			var gridPage = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var dataSource = gridPage.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			var filters = currentStructure.Filters;
			foreach (var filter in filters) {
				if (filter.Name.StartsWith("AdminObjects")) {
					filter.IsEnabled = false;
				}
			}
			var sysWorkspaceFilter = filters.FindByName("SysWorkspaceFilter");
			if (sysWorkspaceFilter == null) {
				sysWorkspaceFilter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", Page.UserConnection.Workspace.Id);
				sysWorkspaceFilter.Name = "SysWorkspaceFilter";
				currentStructure.Filters.Add(sysWorkspaceFilter);
			}
			sysWorkspaceFilter.IsEnabled = true;
			
			switch (tag) {
				case "All":
					//dataSource.StructureName = "All";
					break;
				case "Module":
					var moduleFilter = filters.FindByName("AdminObjectsIsModule");
					if (moduleFilter == null) {
						moduleFilter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "IsModule", true);
						moduleFilter.Name = "AdminObjectsIsModule";
						currentStructure.Filters.Add(moduleFilter);
					}
					moduleFilter.IsEnabled = true;
					break;
				case "Lookup":
					var lookupFilter = filters.FindByName("AdminObjectsIsLookup");
					if (lookupFilter == null) {
						lookupFilter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "IsLookup", true);
						lookupFilter.Name = "AdminObjectsIsLookup";
						currentStructure.Filters.Add(lookupFilter);
					}
					lookupFilter.IsEnabled = true;
					break;
				case "AdministratedByRecords":
					var adminByRecordsFilter = filters.FindByName("AdminObjectsAdministratedByRecords");
					if (adminByRecordsFilter == null) {
						adminByRecordsFilter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "AdministratedByRecords", true);
						adminByRecordsFilter.Name = "AdminObjectsAdministratedByRecords";
						currentStructure.Filters.Add(adminByRecordsFilter);
					}
					adminByRecordsFilter.IsEnabled = true;
					break;
				case "AdministratedByColumns":
					var adminByColumnsFilter = filters.FindByName("AdminObjectsAdministratedByColumns");
					if (adminByColumnsFilter == null) {
						adminByColumnsFilter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "AdministratedByColumns", true);
						adminByColumnsFilter.Name = "AdminObjectsAdministratedByColumns";
						currentStructure.Filters.Add(adminByColumnsFilter);
					}
					adminByColumnsFilter.IsEnabled = true;
					break;
				case "AdministratedByOperations":
					var adminByOperationsFilter = filters.FindByName("AdminObjectsAdministratedByOperations");
					if (adminByOperationsFilter == null) {
						adminByOperationsFilter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "AdministratedByOperations", true);
						adminByOperationsFilter.Name = "AdminObjectsAdministratedByOperations";
						currentStructure.Filters.Add(adminByOperationsFilter);
					}
					adminByOperationsFilter.IsEnabled = true;
					break;
			}
			gridPage.TreeGrid.Clear();
			gridPage.TreeGrid.RefreshData();
			//dataSource.LoadRows();
		}

		public override DataSourceRowConfig GetModuleRowConfig(Entity module) {
			var dataSource = GetActiveDataSource();
			var config = new DataSourceRowConfig(module.PrimaryColumnValue);
			
			bool checkWorkspace = false;
			checkWorkspace = module.GetTypedColumnValue<Guid>("SysWorkspaceId") == UserConnection.Workspace.Id;
			
			if (checkWorkspace) {
				var icons = new Dictionary<string, ImageConfigValue>();
				foreach (var column in dataSource.CurrentStructure.Columns) {
					ISchemaManagerItem<EntitySchema> item = UserConnection.EntitySchemaManager.FindItemByUId(module.PrimaryColumnValue);
					string columnName = column.Name;
					if (columnName.Contains("Is") || columnName.Contains("Administrated")) {
						bool columnValue = module.GetTypedColumnValue<bool>(columnName);
						if(columnName.Contains("Administrated")) {
							if(item != null) {
								var property = item.ExtraProperties.FindByName(columnName);
								if(property != null) {
									columnValue = (bool)property.Value;
								}
							}
						}
						string columnIconImageName = columnValue ? "Allow.png" : "Deny.png";
						var imageConfig = new ImageConfigValue(columnIconImageName);
						imageConfig.DisplayImageOnly = true;
						imageConfig.ImagePosition = ImagePosition.Center;
						if (!icons.ContainsKey(columnName))  {
							icons.Add(columnName, imageConfig);
						}
					}
				}
				var iconConfig = new DataSourceRowColumnIconsConfigValue(icons);		
				config.AddConfig(iconConfig);
			}
			return config;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CheckMenuItemAllCheckChange":
							if (ActivatedEventElements.Contains("StartMessageCheckMenuItemAllCheckChange")) {
							context.QueueTasks.Enqueue("StartMessageCheckMenuItemAllCheckChange");
						}
						break;
					case "CheckMenuItemModuleCheckChange":
							if (ActivatedEventElements.Contains("StartMessage2CheckMenuItemModuleCheckChange")) {
							context.QueueTasks.Enqueue("StartMessage2CheckMenuItemModuleCheckChange");
						}
						break;
					case "CheckMenuItemLookupCheckChange":
							if (ActivatedEventElements.Contains("StartMessageCheckMenuItemLookupCheckChange")) {
							context.QueueTasks.Enqueue("StartMessageCheckMenuItemLookupCheckChange");
						}
						break;
					case "CheckMenuItemAdministratedByRecordsCheckChange":
							if (ActivatedEventElements.Contains("StartMessageCheckMenuItemAdministratedByRecordsCheckChange")) {
							context.QueueTasks.Enqueue("StartMessageCheckMenuItemAdministratedByRecordsCheckChange");
						}
						break;
					case "CheckMenuItemAdministratedByColumnsCheckChange":
							if (ActivatedEventElements.Contains("StartMessage2CheckMenuItemAdministratedByColumnsCheckChange")) {
							context.QueueTasks.Enqueue("StartMessage2CheckMenuItemAdministratedByColumnsCheckChange");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "FolderActiveRowChanged":
							if (ActivatedEventElements.Contains("FolderActiveRowChangedChild")) {
							context.QueueTasks.Enqueue("FolderActiveRowChangedChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitChild")) {
							context.QueueTasks.Enqueue("InitChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "CheckMenuItemAdministratedByOperationsCheckChange":
							if (ActivatedEventElements.Contains("StartAdministratedByOperationsCheckChange")) {
							context.QueueTasks.Enqueue("StartAdministratedByOperationsCheckChange");
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

	#region Class: AdministrativeObjectsPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsPage_Base_TerrasoftEventsProcess : AdministrativeObjectsPage_Base_TerrasoftEventsProcess<Terrasoft.WebApp.AdministrativeObjectsPage_Base_TerrasoftSchemaUserControl>
	{

		public AdministrativeObjectsPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectsPage_Base_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectsPage_Base_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseModulePageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAll {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("CheckMenuItemAll", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemModule {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("CheckMenuItemModule", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparator {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuSeparator)PageContainer.FindPageControl("MenuSeparator", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemLookup {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("CheckMenuItemLookup", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAdministratedByRecords {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("CheckMenuItemAdministratedByRecords", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAdministratedByColumns {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("CheckMenuItemAdministratedByColumns", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemAdministratedByOperations {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("CheckMenuItemAdministratedByOperations", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			CheckMenuItemAll.AjaxEvents.CheckChange.Event += CheckMenuItemAllCheckChange;
			CheckMenuItemModule.AjaxEvents.CheckChange.Event += CheckMenuItemModuleCheckChange;
			CheckMenuItemLookup.AjaxEvents.CheckChange.Event += CheckMenuItemLookupCheckChange;
			CheckMenuItemAdministratedByRecords.AjaxEvents.CheckChange.Event += CheckMenuItemAdministratedByRecordsCheckChange;
			CheckMenuItemAdministratedByColumns.AjaxEvents.CheckChange.Event += CheckMenuItemAdministratedByColumnsCheckChange;
			CheckMenuItemAdministratedByOperations.AjaxEvents.CheckChange.Event += CheckMenuItemAdministratedByOperationsCheckChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			CheckMenuItemAll.AjaxEvents.CheckChange.Event -= CheckMenuItemAllCheckChange;
			CheckMenuItemModule.AjaxEvents.CheckChange.Event -= CheckMenuItemModuleCheckChange;
			CheckMenuItemLookup.AjaxEvents.CheckChange.Event -= CheckMenuItemLookupCheckChange;
			CheckMenuItemAdministratedByRecords.AjaxEvents.CheckChange.Event -= CheckMenuItemAdministratedByRecordsCheckChange;
			CheckMenuItemAdministratedByColumns.AjaxEvents.CheckChange.Event -= CheckMenuItemAdministratedByColumnsCheckChange;
			CheckMenuItemAdministratedByOperations.AjaxEvents.CheckChange.Event -= CheckMenuItemAdministratedByOperationsCheckChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeObjectsPage_Base_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectsPage_Base_TerrasoftEventsProcess(UserConnection);
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

		public virtual void CheckMenuItemAllCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("CheckMenuItemAllCheckChange");
		}

		public virtual void CheckMenuItemModuleCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("CheckMenuItemModuleCheckChange");
		}

		public virtual void CheckMenuItemLookupCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("CheckMenuItemLookupCheckChange");
		}

		public virtual void CheckMenuItemAdministratedByRecordsCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("CheckMenuItemAdministratedByRecordsCheckChange");
		}

		public virtual void CheckMenuItemAdministratedByColumnsCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("CheckMenuItemAdministratedByColumnsCheckChange");
		}

		public virtual void CheckMenuItemAdministratedByOperationsCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("CheckMenuItemAdministratedByOperationsCheckChange");
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
			SchemaName = "AdministrativeObjectsPage_Base_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseModulePageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema(AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectsPage_Base_TerrasoftEventsProcess";
			UId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet271 = CreateLaneSet271LaneSet();
			LaneSets.Add(schemaLaneSet271);
			ProcessSchemaLane schemaLane768 = CreateLane768Lane();
			schemaLaneSet271.Lanes.Add(schemaLane768);
			ProcessSchemaEventSubProcess subprocess14 = CreateSubProcess14EventSubProcess();
			FlowElements.Add(subprocess14);
			ProcessSchemaEventSubProcess subprocess15 = CreateSubProcess15EventSubProcess();
			FlowElements.Add(subprocess15);
			ProcessSchemaEventSubProcess subprocess16 = CreateSubProcess16EventSubProcess();
			FlowElements.Add(subprocess16);
			ProcessSchemaEventSubProcess subprocess17 = CreateSubProcess17EventSubProcess();
			FlowElements.Add(subprocess17);
			ProcessSchemaEventSubProcess subprocess18 = CreateSubProcess18EventSubProcess();
			FlowElements.Add(subprocess18);
			ProcessSchemaEventSubProcess subprocess13 = CreateSubProcess13EventSubProcess();
			FlowElements.Add(subprocess13);
			ProcessSchemaEventSubProcess subprocess20 = CreateSubProcess20EventSubProcess();
			FlowElements.Add(subprocess20);
			ProcessSchemaEventSubProcess subprocess21 = CreateSubProcess21EventSubProcess();
			FlowElements.Add(subprocess21);
			ProcessSchemaEventSubProcess processadministratedbyoperationscheckchange = CreateProcessAdministratedByOperationsCheckChangeEventSubProcess();
			FlowElements.Add(processadministratedbyoperationscheckchange);
			ProcessSchemaStartMessageEvent startmessagecheckmenuitemallcheckchange = CreateStartMessageCheckMenuItemAllCheckChangeStartMessageEvent();
			subprocess14.FlowElements.Add(startmessagecheckmenuitemallcheckchange);
			ProcessSchemaScriptTask scripttask_administratedobjectsall = CreateScriptTask_AdministratedObjectsAllScriptTask();
			subprocess14.FlowElements.Add(scripttask_administratedobjectsall);
			ProcessSchemaStartMessageEvent startmessage2checkmenuitemmodulecheckchange = CreateStartMessage2CheckMenuItemModuleCheckChangeStartMessageEvent();
			subprocess15.FlowElements.Add(startmessage2checkmenuitemmodulecheckchange);
			ProcessSchemaScriptTask scripttask_administratedobjectsmodule = CreateScriptTask_AdministratedObjectsModuleScriptTask();
			subprocess15.FlowElements.Add(scripttask_administratedobjectsmodule);
			ProcessSchemaStartMessageEvent startmessagecheckmenuitemlookupcheckchange = CreateStartMessageCheckMenuItemLookupCheckChangeStartMessageEvent();
			subprocess16.FlowElements.Add(startmessagecheckmenuitemlookupcheckchange);
			ProcessSchemaScriptTask scripttask_administratedobjectslookup = CreateScriptTask_AdministratedObjectsLookupScriptTask();
			subprocess16.FlowElements.Add(scripttask_administratedobjectslookup);
			ProcessSchemaStartMessageEvent startmessagecheckmenuitemadministratedbyrecordscheckchange = CreateStartMessageCheckMenuItemAdministratedByRecordsCheckChangeStartMessageEvent();
			subprocess17.FlowElements.Add(startmessagecheckmenuitemadministratedbyrecordscheckchange);
			ProcessSchemaScriptTask scripttask_administratedobjectsbyrecords = CreateScriptTask_AdministratedObjectsByRecordsScriptTask();
			subprocess17.FlowElements.Add(scripttask_administratedobjectsbyrecords);
			ProcessSchemaStartMessageEvent startmessage2checkmenuitemadministratedbycolumnscheckchange = CreateStartMessage2CheckMenuItemAdministratedByColumnsCheckChangeStartMessageEvent();
			subprocess18.FlowElements.Add(startmessage2checkmenuitemadministratedbycolumnscheckchange);
			ProcessSchemaScriptTask scripttask_administratedobjectsbycolumns = CreateScriptTask_AdministratedObjectsByColumnsScriptTask();
			subprocess18.FlowElements.Add(scripttask_administratedobjectsbycolumns);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			subprocess13.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocess13.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaStartMessageEvent folderactiverowchangedchild = CreateFolderActiveRowChangedChildStartMessageEvent();
			subprocess20.FlowElements.Add(folderactiverowchangedchild);
			ProcessSchemaScriptTask scriptfolderactiverowchangedchild = CreateScriptFolderActiveRowChangedChildScriptTask();
			subprocess20.FlowElements.Add(scriptfolderactiverowchangedchild);
			ProcessSchemaStartMessageEvent initchild = CreateInitChildStartMessageEvent();
			subprocess21.FlowElements.Add(initchild);
			ProcessSchemaScriptTask scriptinitchild = CreateScriptInitChildScriptTask();
			subprocess21.FlowElements.Add(scriptinitchild);
			ProcessSchemaIntermediateThrowMessageEvent throwinitparent = CreateThrowInitParentIntermediateThrowMessageEvent();
			subprocess21.FlowElements.Add(throwinitparent);
			ProcessSchemaStartMessageEvent startadministratedbyoperationscheckchange = CreateStartAdministratedByOperationsCheckChangeStartMessageEvent();
			processadministratedbyoperationscheckchange.FlowElements.Add(startadministratedbyoperationscheckchange);
			ProcessSchemaScriptTask scriptadministratedbyoperationscheckchange = CreateScriptAdministratedByOperationsCheckChangeScriptTask();
			processadministratedbyoperationscheckchange.FlowElements.Add(scriptadministratedbyoperationscheckchange);
			FlowElements.Add(CreateSequenceFlow4425SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4426SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4427SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4428SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4429SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4433SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4434SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4435SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4436SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4471SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4425SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4425",
				UId = new Guid("c108ac0c-5537-4541-971e-0d455a2de039"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("790fca53-3580-42da-8316-d02d41bc2e1c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0cf07833-9ba0-4986-9a3f-224d608be047"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4426SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4426",
				UId = new Guid("3cdcbeed-a153-4364-b9ef-007e6e944f34"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4f31f08-8aa8-437a-9ea4-fcf50c090877"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("266da258-e50e-4f18-a0c3-56be54a6b9c2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4427SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4427",
				UId = new Guid("7058afbb-1cfd-4494-bf57-10cb0058675d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14bd841c-1d33-4e40-bbdb-34a5f6273e74"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dcbbf799-cdc8-47fc-bd22-02d92a7ad0fa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4428SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4428",
				UId = new Guid("23ab126f-b500-431e-b689-d8dfc570e35a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4f5bb95-ef57-49c5-975c-b2ee380aafc8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4e2b5356-204d-4da0-8ea9-2019b72981fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4429SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4429",
				UId = new Guid("ab6b5468-5ac3-4491-9668-4252e77155a4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9352cf88-1d92-45d7-9fcd-d0d3eb9c007b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("180a0af7-ed24-4e0d-b8bd-901ca021a0e2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4433SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4433",
				UId = new Guid("33ca64a1-c2e5-4240-a8bd-ae39a928f082"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(176, 330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2baeba51-db0d-42a2-9f2e-42120b8c87b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("113b8cc2-8fca-4f8a-98d8-9a695917eccb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4434SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4434",
				UId = new Guid("60247a9c-06f1-41c3-8f0b-6b055f7523b8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(454, 532),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec6b9b2f-43a1-47aa-8de3-13685be9771d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6b0501e-f07e-489a-9c9d-2867ceb6dec2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4435SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4435",
				UId = new Guid("af9f9993-a2e9-4b1b-82fd-d3ba5c695ece"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(594, 537),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("34195cdc-5dd4-41d9-ab49-31ea4a3c4db5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68b56631-3b56-49ba-99da-307480c93793"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4436SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4436",
				UId = new Guid("210f9f1c-d735-4555-8564-da962d1b2304"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(695, 538),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68b56631-3b56-49ba-99da-307480c93793"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a71fc9f3-5e78-427a-b0cd-56103f115335"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4471SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4471",
				UId = new Guid("96148835-3b3f-4613-ad1f-786492f48657"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CurveCenterPosition = new Point(752, 392),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e17abcba-40b3-4c57-bd21-d5f92d727b97"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d66be0c7-69c7-4204-8636-85333b074536"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet271LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet271 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4c4c644d-8e3f-4ae5-b4dd-92d8e2c2008a"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"LaneSet271",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1527, 622),
				UseBackgroundMode = false
			};
			return schemaLaneSet271;
		}

		protected virtual ProcessSchemaLane CreateLane768Lane() {
			ProcessSchemaLane schemaLane768 = new ProcessSchemaLane(this) {
				UId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4c4c644d-8e3f-4ae5-b4dd-92d8e2c2008a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"Lane768",
				Position = new Point(29, 0),
				Size = new Size(1498, 622),
				UseBackgroundMode = false
			};
			return schemaLane768;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ccdceab0-441b-48c9-9ed8-0084919a847d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess14",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageCheckMenuItemAllCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("790fca53-3580-42da-8316-d02d41bc2e1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ccdceab0-441b-48c9-9ed8-0084919a847d"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CheckMenuItemAllCheckChange",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"StartMessageCheckMenuItemAllCheckChange",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_AdministratedObjectsAllScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0cf07833-9ba0-4986-9a3f-224d608be047"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ccdceab0-441b-48c9-9ed8-0084919a847d"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptTask_AdministratedObjectsAll",
				Position = new Point(162, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,205,43,245,44,73,205,117,206,201,76,206,214,80,114,204,201,81,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,244,12,172,49,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("46206f19-fe71-4af1-8405-ff31adc07db1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess15",
				Position = new Point(337, 8),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(271, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2CheckMenuItemModuleCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d4f31f08-8aa8-437a-9ea4-fcf50c090877"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("46206f19-fe71-4af1-8405-ff31adc07db1"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CheckMenuItemModuleCheckChange",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"StartMessage2CheckMenuItemModuleCheckChange",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_AdministratedObjectsModuleScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("266da258-e50e-4f18-a0c3-56be54a6b9c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("46206f19-fe71-4af1-8405-ff31adc07db1"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptTask_AdministratedObjectsModule",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,205,43,245,44,73,205,117,206,201,76,206,214,80,242,205,79,41,205,73,85,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,201,124,228,101,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5c90e11f-4258-4093-8144-08ad464d6f7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess16",
				Position = new Point(35, 154),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 134),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageCheckMenuItemLookupCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("14bd841c-1d33-4e40-bbdb-34a5f6273e74"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c90e11f-4258-4093-8144-08ad464d6f7a"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CheckMenuItemLookupCheckChange",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"StartMessageCheckMenuItemLookupCheckChange",
				Position = new Point(43, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_AdministratedObjectsLookupScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dcbbf799-cdc8-47fc-bd22-02d92a7ad0fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c90e11f-4258-4093-8144-08ad464d6f7a"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptTask_AdministratedObjectsLookup",
				Position = new Point(162, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,205,43,245,44,73,205,117,206,201,76,206,214,80,242,201,207,207,46,45,80,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,233,159,222,242,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess17EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess17 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("373bb5b6-a232-48b2-9b59-fd320f7b658f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess17",
				Position = new Point(336, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(275, 146),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess17;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageCheckMenuItemAdministratedByRecordsCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d4f5bb95-ef57-49c5-975c-b2ee380aafc8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("373bb5b6-a232-48b2-9b59-fd320f7b658f"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CheckMenuItemAdministratedByRecordsCheckChange",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"StartMessageCheckMenuItemAdministratedByRecordsCheckChange",
				Position = new Point(43, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_AdministratedObjectsByRecordsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4e2b5356-204d-4da0-8ea9-2019b72981fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("373bb5b6-a232-48b2-9b59-fd320f7b658f"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptTask_AdministratedObjectsByRecords",
				Position = new Point(155, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,205,43,245,44,73,205,117,206,201,76,206,214,80,114,76,201,205,204,203,44,46,41,74,44,73,77,113,170,12,74,77,206,47,74,41,86,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,88,27,148,7,53,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess18EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess18 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("993521a0-352a-4091-ab08-8e7cbcbdce7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess18",
				Position = new Point(35, 301),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess18;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2CheckMenuItemAdministratedByColumnsCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9352cf88-1d92-45d7-9fcd-d0d3eb9c007b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("993521a0-352a-4091-ab08-8e7cbcbdce7e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CheckMenuItemAdministratedByColumnsCheckChange",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"StartMessage2CheckMenuItemAdministratedByColumnsCheckChange",
				Position = new Point(43, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_AdministratedObjectsByColumnsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("180a0af7-ed24-4e0d-b8bd-901ca021a0e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("993521a0-352a-4091-ab08-8e7cbcbdce7e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptTask_AdministratedObjectsByColumns",
				Position = new Point(162, 43),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,205,43,245,44,73,205,117,206,201,76,206,214,80,114,76,201,205,204,203,44,46,41,74,44,73,77,113,170,116,206,207,41,205,205,43,86,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,62,116,24,179,53,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f3c31cb5-77eb-4d93-a23b-7bea85e5247e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 478),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(230, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2baeba51-db0d-42a2-9f2e-42120b8c87b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3c31cb5-77eb-4d93-a23b-7bea85e5247e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("113b8cc2-8fca-4f8a-98d8-9a695917eccb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3c31cb5-77eb-4d93-a23b-7bea85e5247e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,209,110,219,48,12,124,47,208,127,48,242,148,2,131,126,96,235,0,55,113,187,0,13,22,44,107,247,204,217,76,42,76,161,2,138,74,151,191,31,101,201,139,27,180,64,49,236,201,246,241,238,68,158,232,135,128,60,243,68,216,138,245,100,230,55,107,108,35,91,57,54,180,181,132,102,246,132,237,175,25,80,243,91,113,193,154,142,95,247,200,144,200,211,137,226,75,32,216,98,221,237,44,217,32,185,48,249,80,165,210,163,197,103,181,222,216,109,44,248,213,199,203,139,53,202,28,55,16,157,44,125,23,29,174,128,97,135,130,28,166,169,124,0,174,246,236,91,12,161,186,174,86,234,109,110,32,224,173,119,29,178,73,223,11,10,2,212,162,89,21,26,132,234,59,50,67,240,27,49,63,240,103,189,223,247,154,236,159,149,33,41,155,3,146,132,34,251,116,121,241,62,213,186,125,194,29,60,228,156,132,189,251,172,109,150,22,77,67,162,89,21,202,162,211,150,179,242,12,31,41,238,53,38,36,228,100,93,38,124,163,90,26,205,182,125,18,5,49,67,4,217,57,69,182,101,219,13,232,192,190,83,236,69,98,111,38,149,152,175,142,170,238,99,231,191,13,232,37,234,171,46,130,28,31,193,69,156,78,198,141,235,253,167,199,213,191,169,79,99,23,159,215,198,78,222,115,16,88,251,200,105,48,221,222,3,142,128,235,234,14,165,62,67,251,5,235,29,111,173,211,141,107,58,43,230,84,238,115,62,119,50,51,103,117,107,22,243,97,55,199,121,254,215,160,147,123,55,158,96,124,212,168,77,165,158,104,230,222,67,247,205,63,135,247,204,70,209,185,129,213,255,215,75,164,184,16,220,213,206,101,0,19,77,56,166,67,190,64,168,9,220,81,108,155,126,197,13,184,144,96,70,137,76,153,244,7,139,83,235,233,61,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess20EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess20 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ba310071-e84f-4252-b1f6-d6a1ef326348"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess20",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 478),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(201, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess20;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFolderActiveRowChangedChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec6b9b2f-43a1-47aa-8de3-13685be9771d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba310071-e84f-4252-b1f6-d6a1ef326348"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FolderActiveRowChanged",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"FolderActiveRowChangedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptFolderActiveRowChangedChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f6b0501e-f07e-489a-9c9d-2867ceb6dec2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba310071-e84f-4252-b1f6-d6a1ef326348"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptFolderActiveRowChangedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(91, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess21EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess21 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ca50cd36-03b0-4826-b8c4-8b1b2938d3f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"SubProcess21",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(498, 478),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(257, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess21;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("34195cdc-5dd4-41d9-ab49-31ea4a3c4db5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca50cd36-03b0-4826-b8c4-8b1b2938d3f7"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"InitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("68b56631-3b56-49ba-99da-307480c93793"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca50cd36-03b0-4826-b8c4-8b1b2938d3f7"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptInitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,206,61,10,194,48,24,0,208,221,83,148,78,58,124,144,255,52,20,7,155,31,113,112,42,30,160,54,41,22,106,11,49,65,122,123,117,212,193,11,60,94,187,62,206,139,207,83,56,249,98,95,204,225,89,28,243,232,183,165,179,92,98,164,4,56,42,26,192,12,35,32,178,194,192,42,222,80,213,16,107,180,46,119,245,198,45,147,15,209,206,105,76,107,219,223,194,189,187,252,72,134,27,132,157,54,32,76,165,129,53,68,129,178,188,2,173,15,212,57,43,8,21,236,75,138,235,63,142,93,137,28,56,34,208,147,247,142,201,126,128,110,224,30,40,86,210,115,22,144,39,221,135,139,33,229,56,23,41,230,80,191,0,89,31,21,206,229,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowInitParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a71fc9f3-5e78-427a-b0cd-56103f115335"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca50cd36-03b0-4826-b8c4-8b1b2938d3f7"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ThrowInitParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessAdministratedByOperationsCheckChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessAdministratedByOperationsCheckChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("086d27db-1d53-46f9-929c-8023d0ae1b71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e294d2-5b8e-4f3a-b6dc-5e19913e5225"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ProcessAdministratedByOperationsCheckChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 317),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(222, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessAdministratedByOperationsCheckChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartAdministratedByOperationsCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e17abcba-40b3-4c57-bd21-d5f92d727b97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("086d27db-1d53-46f9-929c-8023d0ae1b71"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CheckMenuItemAdministratedByOperationsCheckChange",
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"StartAdministratedByOperationsCheckChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdministratedByOperationsCheckChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d66be0c7-69c7-4204-8636-85333b074536"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("086d27db-1d53-46f9-929c-8023d0ae1b71"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Name = @"ScriptAdministratedByOperationsCheckChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,205,43,245,44,73,205,117,206,201,76,206,214,80,114,76,201,205,204,203,44,46,41,74,44,73,77,113,170,244,47,72,5,178,50,243,243,138,149,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,183,249,116,50,56,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateMenuItemClickMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c732b9ff-923d-459f-8aed-c923e5d34b12"),
				Name = "System.Data",
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
				UId = new Guid("73f3d5bd-cd68-4d27-aa1a-e5db86afbb5c"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,203,110,219,48,16,60,203,128,255,129,209,73,2,2,125,64,253,40,28,59,13,132,162,173,81,39,237,153,145,214,14,17,137,20,72,202,174,208,228,223,187,92,74,178,92,59,190,72,224,114,56,59,179,187,228,158,107,150,115,203,55,170,214,25,176,25,123,0,187,200,172,216,195,170,143,70,241,100,60,218,35,48,83,114,43,118,8,146,112,96,199,253,159,234,176,164,157,168,84,121,93,64,178,214,162,228,186,89,170,162,46,229,47,94,212,224,24,198,163,103,165,10,150,189,64,246,250,91,233,87,83,113,202,184,229,133,1,220,63,219,104,217,80,209,99,83,65,62,160,155,62,212,34,159,71,225,166,49,253,129,52,15,99,54,155,177,39,3,26,229,72,64,23,74,38,253,126,146,230,36,66,108,89,116,154,42,102,127,199,163,192,25,20,232,208,116,254,4,17,160,143,169,177,90,200,221,45,75,75,190,3,111,149,100,204,169,50,193,86,105,224,217,11,139,124,141,156,74,38,228,160,172,201,178,214,26,164,221,88,93,103,182,214,24,32,148,241,153,131,116,131,130,74,254,141,75,228,215,169,133,114,122,47,173,176,141,143,207,153,192,16,59,179,54,196,180,103,147,47,66,230,142,224,174,121,74,243,235,253,8,2,239,171,149,252,157,151,174,232,126,145,184,21,97,168,92,61,0,133,75,203,133,52,81,152,26,172,247,219,27,187,184,185,200,75,33,5,242,115,11,216,151,214,103,224,7,224,40,227,122,147,29,122,62,72,238,69,163,162,203,130,62,200,233,240,84,191,27,236,107,93,20,125,156,58,94,105,85,129,182,13,42,113,160,228,254,15,158,95,251,160,0,67,245,188,107,92,166,115,33,68,221,19,156,209,7,167,70,35,103,39,238,224,9,133,59,158,119,255,247,63,255,61,233,77,138,115,73,195,119,210,36,207,252,153,133,139,162,80,135,164,146,187,144,125,98,225,10,100,67,11,207,78,115,125,28,220,118,186,255,31,229,232,66,162,174,222,71,104,178,18,166,42,120,67,144,31,178,112,101,195,153,134,115,32,33,214,202,8,55,169,136,58,89,39,75,188,12,160,187,118,178,232,134,46,94,223,203,175,208,12,171,29,179,190,149,4,91,228,249,96,251,118,232,174,149,76,37,116,159,247,193,197,94,94,121,189,58,239,102,88,18,202,22,79,130,0,73,252,211,231,82,183,79,221,145,209,229,196,60,26,240,102,203,246,141,156,252,3,255,17,107,97,88,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMenuItemClickMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2997e1ba-0312-40e4-95ba-f536713fb5ba"),
				Name = "MenuItemClick",
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8cdd0d12-b34a-4e02-b55b-0c17957bce45"),
				Name = "tag",
				CreatedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				ModifiedInSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,150,205,110,226,48,20,133,215,65,226,29,162,172,130,132,220,253,84,93,80,218,169,144,58,211,10,24,117,109,18,7,50,56,118,198,118,90,161,17,239,62,118,156,31,59,113,80,6,177,1,98,223,123,238,241,249,34,225,79,200,252,61,75,227,119,184,71,254,131,175,190,192,139,124,6,234,215,138,112,1,73,132,124,200,253,45,98,12,114,154,8,240,129,118,139,60,7,143,144,163,151,170,115,19,29,80,6,127,113,196,150,148,8,70,241,253,116,242,41,149,99,40,224,134,22,44,82,218,245,24,240,212,172,86,101,81,193,24,34,98,35,88,17,137,130,169,226,182,19,44,59,187,85,83,146,98,129,24,151,181,221,118,240,93,111,201,194,132,50,4,163,131,31,182,29,126,74,234,222,153,255,119,58,241,210,196,15,245,2,248,9,51,4,54,2,50,193,63,82,113,8,131,69,156,165,228,109,247,27,69,130,7,51,93,239,85,197,43,254,76,224,14,163,88,90,72,32,230,202,152,119,158,78,206,218,31,63,241,15,202,142,60,135,17,210,134,84,157,30,44,29,146,248,241,164,198,133,193,166,87,24,204,164,148,178,229,210,120,240,73,129,177,182,226,156,97,70,39,79,47,170,29,117,160,119,200,228,72,229,32,212,139,75,154,229,144,165,156,146,237,41,71,224,249,79,1,241,220,183,44,5,115,253,86,84,116,137,140,34,165,4,52,251,96,21,43,187,14,47,101,156,210,144,235,132,170,99,136,27,88,196,177,227,232,106,138,204,214,49,199,36,33,197,20,8,89,247,149,10,69,94,192,189,14,43,146,47,172,31,44,48,14,190,41,138,119,119,70,80,141,135,218,178,42,83,30,189,157,140,240,120,223,180,255,160,113,129,145,86,80,148,179,242,249,34,95,243,29,90,241,74,160,140,172,124,245,108,5,147,174,231,117,212,111,64,182,49,48,47,147,210,54,172,57,13,53,167,111,93,127,145,156,41,166,245,207,234,195,154,225,32,214,139,250,149,210,99,145,183,81,227,242,249,63,162,174,4,218,168,109,5,59,234,142,250,77,162,174,12,88,81,155,115,6,162,174,218,70,68,109,138,25,81,91,51,198,68,93,206,79,185,96,242,160,50,204,53,138,40,139,121,27,61,84,251,205,250,104,4,3,178,45,16,183,174,13,102,96,246,13,0,13,216,179,112,185,166,59,177,13,136,141,128,232,26,97,192,116,58,184,2,234,146,226,34,35,125,168,213,250,181,80,107,217,30,212,142,174,19,106,119,246,237,161,214,246,92,80,173,233,99,160,214,98,227,161,90,35,250,80,109,7,87,64,125,203,145,252,37,255,143,251,92,219,173,107,209,26,226,61,186,125,117,39,96,135,137,219,51,54,124,186,48,119,61,140,33,109,72,142,135,221,29,212,231,221,179,114,17,185,236,108,238,204,91,134,202,219,54,88,98,4,89,168,164,251,123,107,148,48,196,15,234,126,93,86,88,87,156,87,10,227,53,253,226,114,231,31,142,16,65,223,245,11,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f57f612-25ad-4044-abb3-39b430df3900"));
		}

		#endregion

	}

	#endregion

}

