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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TerrasoftWebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: AdministrationOrganizationalStructureGridPageSchema

	/// <exclude/>
	public class AdministrationOrganizationalStructureGridPageSchema : Terrasoft.WebApp.BaseModuleFoldersPageSchema
	{

		#region Constructors: Public

		public AdministrationOrganizationalStructureGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrationOrganizationalStructureGridPageSchema(AdministrationOrganizationalStructureGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdatePreloadMenuItem() {
			PreloadMenuItem.Image = new ControlImage {};
			PreloadMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateNoActiveMenuItem() {
			NoActiveMenuItem.Image = new ControlImage {};
			NoActiveMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateAddGeneralFolderMenuItem() {
			AddGeneralFolderMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			AddGeneralFolderMenuItem.Image = new ControlImage {};
			AddGeneralFolderMenuItem.Enabled = false;
			AddGeneralFolderMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateAddSearchFolderMenuItem() {
			AddSearchFolderMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			AddSearchFolderMenuItem.Image = new ControlImage {};
			AddSearchFolderMenuItem.Enabled = false;
			AddSearchFolderMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateAddSubEmailFolderMenuItem() {
			AddSubEmailFolderMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			AddSubEmailFolderMenuItem.Image = new ControlImage {};
			AddSubEmailFolderMenuItem.Enabled = false;
			AddSubEmailFolderMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateEditMenuItem() {
			EditMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			EditMenuItem.Image = new ControlImage {};
			EditMenuItem.Enabled = false;
			EditMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateRemoveMenuItem() {
			RemoveMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			RemoveMenuItem.Image = new ControlImage {};
			RemoveMenuItem.Enabled = false;
			RemoveMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateAdminRightMenuItem() {
			AdminRightMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			AdminRightMenuItem.Image = new ControlImage {};
			AdminRightMenuItem.Enabled = false;
			AdminRightMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateConfigureDuplicatesMenuItem() {
			ConfigureDuplicatesMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ConfigureDuplicatesMenuItem.Image = new ControlImage {};
			ConfigureDuplicatesMenuItem.Enabled = false;
			ConfigureDuplicatesMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateStartDuplicatesSearchMenuItem() {
			StartDuplicatesSearchMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			StartDuplicatesSearchMenuItem.Image = new ControlImage {};
			StartDuplicatesSearchMenuItem.Enabled = false;
			StartDuplicatesSearchMenuItem.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
		}

		private void UpdateGroupImageList() {
			GroupImageList.MoveItem(0, FindDesignItemByUId(new Guid("12694e7f-d1d9-43d1-b0cd-93cf4926201d")));
			GroupImageList.MoveItem(1, FindDesignItemByUId(new Guid("e44c0dff-34ef-4af6-8d3c-e2f4b2b6b81a")));
			GroupImageList.MoveItem(2, FindDesignItemByUId(new Guid("eaa8d35d-7110-42a0-a62d-6b169783febe")));
			GroupImageList.MoveItem(3, FindDesignItemByUId(new Guid("a1dc01d7-c902-4411-ba28-0cd6eaa03113")));
			GroupImageList.MoveItem(4, FindDesignItemByUId(new Guid("33057df5-588a-411a-a63a-7f5e8be8b3f2")));
			GroupImageList.MoveItem(5, FindDesignItemByUId(new Guid("3fae3b1c-9861-48e7-9595-29bece11255a")));
			GroupImageList.MoveItem(6, FindDesignItemByUId(new Guid("cca3aeff-c90f-4868-b3bd-0a3dfb5dc83e")));
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
			RealUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
			Name = "AdministrationOrganizationalStructureGridPage";
			ParentSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrationOrganizationalStructureGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateGroupImageList();
			UpdateTreeGrid();
			UpdateStartDuplicatesSearchMenuItem();
			UpdateConfigureDuplicatesMenuItem();
			UpdateAdminRightMenuItem();
			UpdateRemoveMenuItem();
			UpdateEditMenuItem();
			UpdateAddSubEmailFolderMenuItem();
			UpdateAddSearchFolderMenuItem();
			UpdateAddGeneralFolderMenuItem();
			UpdateNoActiveMenuItem();
			UpdatePreloadMenuItem();
			TopLevelControl.MoveItem(0, TreeGrid);
			TreeGrid.MoveItem(0, PreloadMenuItem);
			TreeGrid.MoveItem(1, NoActiveMenuItem);
			TreeGrid.MoveItem(2, AddGeneralFolderMenuItem);
			TreeGrid.MoveItem(3, AddSearchFolderMenuItem);
			TreeGrid.MoveItem(4, AddSubEmailFolderMenuItem);
			TreeGrid.MoveItem(5, EditMenuItem);
			TreeGrid.MoveItem(6, RemoveMenuItem);
			TreeGrid.MoveItem(7, AdminRightMenuItem);
			TreeGrid.MoveItem(8, ConfigureDuplicatesMenuItem);
			TreeGrid.MoveItem(9, StartDuplicatesSearchMenuItem);
			TopLevelControl.MoveItem(1, DataSource);
			TopLevelControl.MoveItem(2, GroupImageList);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrationOrganizationalStructureGridPageEventsProcessSchema() {
			var schema = new AdministrationOrganizationalStructureGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			DataSource.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("beb868b7-c8d5-4291-90c2-411fcd6cc87c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("49b4287f-0bb4-47a3-b28c-1e2484bc6161");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1");
			if (column != null) {
				column.UId = new Guid("aada030e-a51b-421e-acba-15e5cfecc629");
				column.Name = @"SysAdminUnitType";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("184336ef-e07a-4f5a-9850-8d4ccaff520f");
			if (column != null) {
				column.UId = new Guid("31776af1-3727-427e-b38b-241f320be041");
				column.Name = @"SynchronizeWithLDAP";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2e25fe29-ea38-4db2-84d5-03a8db9b2491");
			if (column != null) {
				column.UId = new Guid("29b93d64-a620-4bc6-88af-98b617373ae9");
				column.Name = @"LDAPEntry";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c2748d54-0f48-4251-bfc0-ff6e2478348d");
			if (column != null) {
				column.UId = new Guid("3d110397-5989-470f-ae11-e42df2b771f7");
				column.Name = @"LDAPEntryId";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e161e2fc-4fac-4ae0-ba3c-e9f70d52ecb4");
			if (column != null) {
				column.UId = new Guid("8bed0184-a5ae-49ff-b633-98b3daf1ffa3");
				column.Name = @"LDAPEntryDN";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.UId = new Guid("832814a5-67c7-4f52-bf4d-321e2c2673f0");
				column.Name = @"ParentRole";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("0d7b9966-0735-42ec-aafb-3d84c375073d");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4acc2d13-7573-41ec-9a30-e20696bf0314");
			if (column != null) {
				column.UId = new Guid("e3e99630-b206-43bf-add8-761a1c79b0f2");
				column.Name = @"ConnectionType";
				column.CreatedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.ModifiedInSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrationOrganizationalStructureGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrationOrganizationalStructureGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrationOrganizationalStructureGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationOrganizationalStructureGridPageEventsProcess

	/// <exclude/>
	public class AdministrationOrganizationalStructureGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseModuleFoldersPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrationOrganizationalStructureGridPageSchemaUserControl
	{

		#region Class: UserTaskOpenPageFlowElement

		/// <exclude/>
		public class UserTaskOpenPageFlowElement : OpenPageUserTask
		{

			public UserTaskOpenPageFlowElement(UserConnection userConnection, AdministrationOrganizationalStructureGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskOpenPage";
				IsLogging = false;
				SchemaElementUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenLDAPUsersListUserTaskFlowElement

		/// <exclude/>
		public class OpenLDAPUsersListUserTaskFlowElement : OpenPageUserTask
		{

			public OpenLDAPUsersListUserTaskFlowElement(UserConnection userConnection, AdministrationOrganizationalStructureGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLDAPUsersListUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AdministrationOrganizationalStructureGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrationOrganizationalStructureGridPageEventsProcess";
			SchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
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

		private ProcessFlowElement _eventSubProcess104;
		public ProcessFlowElement EventSubProcess104 {
			get {
				return _eventSubProcess104 ?? (_eventSubProcess104 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess104",
					SchemaElementUId = new Guid("581a6a41-2a37-4479-8351-c4c655dbcb24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openPageAfterAdminUnitAddingEditingStartMessage;
		public ProcessFlowElement OpenPageAfterAdminUnitAddingEditingStartMessage {
			get {
				return _openPageAfterAdminUnitAddingEditingStartMessage ?? (_openPageAfterAdminUnitAddingEditingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenPageAfterAdminUnitAddingEditingStartMessage",
					SchemaElementUId = new Guid("cc3d0387-e5cb-4b48-88fd-bccbaf9f147d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private UserTaskOpenPageFlowElement _userTaskOpenPage;
		public UserTaskOpenPageFlowElement UserTaskOpenPage {
			get {
				return _userTaskOpenPage ?? (_userTaskOpenPage = new UserTaskOpenPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _subProcess101;
		public ProcessFlowElement SubProcess101 {
			get {
				return _subProcess101 ?? (_subProcess101 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess101",
					SchemaElementUId = new Guid("68ce32ea-bf91-4025-9433-2c031b27e6d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initMessage;
		public ProcessFlowElement InitMessage {
			get {
				return _initMessage ?? (_initMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitMessage",
					SchemaElementUId = new Guid("763034a1-5bbb-442c-a562-c70bed084b8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInit_OS;
		public ProcessScriptTask ScriptInit_OS {
			get {
				return _scriptInit_OS ?? (_scriptInit_OS = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInit_OS",
					SchemaElementUId = new Guid("7a80f75a-9b0a-4ea0-89cf-396fee7b1a95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInit_OSExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess106;
		public ProcessFlowElement SubProcess106 {
			get {
				return _subProcess106 ?? (_subProcess106 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess106",
					SchemaElementUId = new Guid("2229b127-9bec-4361-ac4a-c7c0b9c19ff9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceActiveRowChangedChild;
		public ProcessFlowElement DataSourceActiveRowChangedChild {
			get {
				return _dataSourceActiveRowChangedChild ?? (_dataSourceActiveRowChangedChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceActiveRowChangedChild",
					SchemaElementUId = new Guid("345e3cbf-93d2-4470-a7a5-a22c399c1a43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceActiveRowChanged;
		public ProcessScriptTask ScriptDataSourceActiveRowChanged {
			get {
				return _scriptDataSourceActiveRowChanged ?? (_scriptDataSourceActiveRowChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceActiveRowChanged",
					SchemaElementUId = new Guid("bbc383e1-6a2e-476a-b120-b64a251f008a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceActiveRowChangedExecute,
				});
			}
		}

		private ProcessFlowElement _initializeChild;
		public ProcessFlowElement InitializeChild {
			get {
				return _initializeChild ?? (_initializeChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitializeChild",
					SchemaElementUId = new Guid("7b9b5480-7461-47c2-acb1-45dda589c53d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInitializeChild;
		public ProcessScriptTask ScriptInitializeChild {
			get {
				return _scriptInitializeChild ?? (_scriptInitializeChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInitializeChild",
					SchemaElementUId = new Guid("ff6bbdc1-cf91-468b-bf19-1f2fa7c0fbc2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitializeChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess107;
		public ProcessFlowElement SubProcess107 {
			get {
				return _subProcess107 ?? (_subProcess107 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess107",
					SchemaElementUId = new Guid("245e6c36-605c-43b9-b502-7f50c6190d08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeLoadChild;
		public ProcessFlowElement DataSourceBeforeLoadChild {
			get {
				return _dataSourceBeforeLoadChild ?? (_dataSourceBeforeLoadChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeLoadChild",
					SchemaElementUId = new Guid("d423344b-b362-44a8-b707-8d027436d6da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceBeforeLoadChild;
		public ProcessScriptTask ScriptDataSourceBeforeLoadChild {
			get {
				return _scriptDataSourceBeforeLoadChild ?? (_scriptDataSourceBeforeLoadChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceBeforeLoadChild",
					SchemaElementUId = new Guid("46aec364-13b1-4d73-bb65-17c39a083ab5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceBeforeLoadChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess108;
		public ProcessFlowElement SubProcess108 {
			get {
				return _subProcess108 ?? (_subProcess108 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess108",
					SchemaElementUId = new Guid("4ab40cd0-0ae9-4fae-bcee-befff4a08e13"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadCompleteChild;
		public ProcessThrowMessageEvent ThrowPageLoadCompleteChild {
			get {
				return _throwPageLoadCompleteChild ?? (_throwPageLoadCompleteChild = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadCompleteChild",
					SchemaElementUId = new Guid("800c312b-26f8-4774-a5c3-d400b3aa1c82"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("cb807065-925b-442b-8ca6-d2f0a2954a9d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
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
					SchemaElementUId = new Guid("0856fc09-35fc-4cf3-931d-be675aff2a52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildDeleteYesMessage;
		public ProcessFlowElement EventSubProcessChildDeleteYesMessage {
			get {
				return _eventSubProcessChildDeleteYesMessage ?? (_eventSubProcessChildDeleteYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildDeleteYesMessage",
					SchemaElementUId = new Guid("0372dee4-1679-4feb-9573-e71ef367c502"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildDeleteYesMessage;
		public ProcessFlowElement StartMessageChildDeleteYesMessage {
			get {
				return _startMessageChildDeleteYesMessage ?? (_startMessageChildDeleteYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildDeleteYesMessage",
					SchemaElementUId = new Guid("43e9646d-836f-4ccd-bade-c3e8bbdbdf26"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskChildDeleteYesMessage;
		public ProcessScriptTask ScriptTaskChildDeleteYesMessage {
			get {
				return _scriptTaskChildDeleteYesMessage ?? (_scriptTaskChildDeleteYesMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskChildDeleteYesMessage",
					SchemaElementUId = new Guid("2a1d6a36-cb0f-4507-b21d-12cfea3e7458"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskChildDeleteYesMessageExecute,
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
					SchemaElementUId = new Guid("1ea3f202-6d4f-4c80-8071-14175449706d"),
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
					SchemaElementUId = new Guid("2becc203-986f-4a4e-8483-2425852ffafa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent PageLoadIntermediateThrowMessageEvent1 {
			get {
				return _pageLoadIntermediateThrowMessageEvent1 ?? (_pageLoadIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("2f55599e-524b-4629-90bf-9454919b0cd7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptExcludeSSPUserGroup;
		public ProcessScriptTask ScriptExcludeSSPUserGroup {
			get {
				return _scriptExcludeSSPUserGroup ?? (_scriptExcludeSSPUserGroup = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptExcludeSSPUserGroup",
					SchemaElementUId = new Guid("959eb46c-86ba-49d3-b264-ca5620a338f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptExcludeSSPUserGroupExecute,
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
					SchemaElementUId = new Guid("a2af9340-0bb9-4a8e-bd8e-6e47b8bc5ded"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadedStartMessage;
		public ProcessFlowElement DataSourceLoadedStartMessage {
			get {
				return _dataSourceLoadedStartMessage ?? (_dataSourceLoadedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadedStartMessage",
					SchemaElementUId = new Guid("3f1e99bd-c31f-45b0-b8d5-724e0ccbe2b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowDataSourceLoadedMessageEvent;
		public ProcessThrowMessageEvent IntermediateThrowDataSourceLoadedMessageEvent {
			get {
				return _intermediateThrowDataSourceLoadedMessageEvent ?? (_intermediateThrowDataSourceLoadedMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowDataSourceLoadedMessageEvent",
					SchemaElementUId = new Guid("92818466-644f-4a09-8926-c90be294e4c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceLoaded",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _dataSourceLoadedScriptTask;
		public ProcessScriptTask DataSourceLoadedScriptTask {
			get {
				return _dataSourceLoadedScriptTask ?? (_dataSourceLoadedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceLoadedScriptTask",
					SchemaElementUId = new Guid("e9769a42-4f05-4f32-add2-985e82522bfa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceLoadedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openLDAPUsersListEventSubProcess;
		public ProcessFlowElement OpenLDAPUsersListEventSubProcess {
			get {
				return _openLDAPUsersListEventSubProcess ?? (_openLDAPUsersListEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenLDAPUsersListEventSubProcess",
					SchemaElementUId = new Guid("eb632d8f-bf82-4bdc-b317-5ba169766abc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openLDAPUsersGrid;
		public ProcessFlowElement OpenLDAPUsersGrid {
			get {
				return _openLDAPUsersGrid ?? (_openLDAPUsersGrid = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenLDAPUsersGrid",
					SchemaElementUId = new Guid("ff780bb1-a1e2-43d9-a072-1e30cc77731c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private OpenLDAPUsersListUserTaskFlowElement _openLDAPUsersListUserTask;
		public OpenLDAPUsersListUserTaskFlowElement OpenLDAPUsersListUserTask {
			get {
				return _openLDAPUsersListUserTask ?? (_openLDAPUsersListUserTask = new OpenLDAPUsersListUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("68e58fd7-7ca7-477f-98f1-72633c3af1a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lDAPUsersGridClosed;
		public ProcessFlowElement LDAPUsersGridClosed {
			get {
				return _lDAPUsersGridClosed ?? (_lDAPUsersGridClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LDAPUsersGridClosed",
					SchemaElementUId = new Guid("7288d7b8-a644-4d16-a7a0-c11a58b7878a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLDAPUsersGridClosed;
		public ProcessScriptTask ScriptLDAPUsersGridClosed {
			get {
				return _scriptLDAPUsersGridClosed ?? (_scriptLDAPUsersGridClosed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLDAPUsersGridClosed",
					SchemaElementUId = new Guid("79c62626-7cf3-489f-9274-feb1d0b405ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLDAPUsersGridClosedExecute,
				});
			}
		}

		private LocalizableString _addOrganizationStructureMenuSeparatorCaption;
		public LocalizableString AddOrganizationStructureMenuSeparatorCaption {
			get {
				return _addOrganizationStructureMenuSeparatorCaption ?? (_addOrganizationStructureMenuSeparatorCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddOrganizationStructureMenuSeparatorCaption.Value"));
			}
		}

		private LocalizableString _editOrganizationStructureMenuItemCaption;
		public LocalizableString EditOrganizationStructureMenuItemCaption {
			get {
				return _editOrganizationStructureMenuItemCaption ?? (_editOrganizationStructureMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EditOrganizationStructureMenuItemCaption.Value"));
			}
		}

		private LocalizableString _deleteOrganizationStructureMenuItemCaption;
		public LocalizableString DeleteOrganizationStructureMenuItemCaption {
			get {
				return _deleteOrganizationStructureMenuItemCaption ?? (_deleteOrganizationStructureMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteOrganizationStructureMenuItemCaption.Value"));
			}
		}

		private LocalizableString _openLDAPUsersListCaption;
		public LocalizableString OpenLDAPUsersListCaption {
			get {
				return _openLDAPUsersListCaption ?? (_openLDAPUsersListCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenLDAPUsersListCaption.Value"));
			}
		}

		private LocalizableString _importLDAPUsersLS;
		public LocalizableString ImportLDAPUsersLS {
			get {
				return _importLDAPUsersLS ?? (_importLDAPUsersLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportLDAPUsersLS.Value"));
			}
		}

		private LocalizableString _addOrganization;
		public LocalizableString AddOrganization {
			get {
				return _addOrganization ?? (_addOrganization = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddOrganization.Value"));
			}
		}

		private LocalizableString _addDepartment;
		public LocalizableString AddDepartment {
			get {
				return _addDepartment ?? (_addDepartment = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddDepartment.Value"));
			}
		}

		private LocalizableString _addChief;
		public LocalizableString AddChief {
			get {
				return _addChief ?? (_addChief = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddChief.Value"));
			}
		}

		private LocalizableString _addTeam;
		public LocalizableString AddTeam {
			get {
				return _addTeam ?? (_addTeam = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddTeam.Value"));
			}
		}

		private LocalizableString _dependencyWarningMessage;
		public LocalizableString DependencyWarningMessage {
			get {
				return _dependencyWarningMessage ?? (_dependencyWarningMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DependencyWarningMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess104.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess104 };
			FlowElements[OpenPageAfterAdminUnitAddingEditingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenPageAfterAdminUnitAddingEditingStartMessage };
			FlowElements[UserTaskOpenPage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskOpenPage };
			FlowElements[SubProcess101.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess101 };
			FlowElements[InitMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMessage };
			FlowElements[ScriptInit_OS.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit_OS };
			FlowElements[SubProcess106.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess106 };
			FlowElements[DataSourceActiveRowChangedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceActiveRowChangedChild };
			FlowElements[ScriptDataSourceActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceActiveRowChanged };
			FlowElements[InitializeChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitializeChild };
			FlowElements[ScriptInitializeChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitializeChild };
			FlowElements[SubProcess107.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess107 };
			FlowElements[DataSourceBeforeLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeLoadChild };
			FlowElements[ScriptDataSourceBeforeLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceBeforeLoadChild };
			FlowElements[SubProcess108.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess108 };
			FlowElements[ThrowPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadCompleteChild };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[EventSubProcessChildDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildDeleteYesMessage };
			FlowElements[StartMessageChildDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildDeleteYesMessage };
			FlowElements[ScriptTaskChildDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskChildDeleteYesMessage };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PageLoadStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadStartMessage };
			FlowElements[PageLoadIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadIntermediateThrowMessageEvent1 };
			FlowElements[ScriptExcludeSSPUserGroup.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptExcludeSSPUserGroup };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[DataSourceLoadedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadedStartMessage };
			FlowElements[IntermediateThrowDataSourceLoadedMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowDataSourceLoadedMessageEvent };
			FlowElements[DataSourceLoadedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadedScriptTask };
			FlowElements[OpenLDAPUsersListEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLDAPUsersListEventSubProcess };
			FlowElements[OpenLDAPUsersGrid.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLDAPUsersGrid };
			FlowElements[OpenLDAPUsersListUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLDAPUsersListUserTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[LDAPUsersGridClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPUsersGridClosed };
			FlowElements[ScriptLDAPUsersGridClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLDAPUsersGridClosed };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess104":
						break;
					case "OpenPageAfterAdminUnitAddingEditingStartMessage":
						e.Context.QueueTasks.Enqueue("UserTaskOpenPage");
						break;
					case "UserTaskOpenPage":
						break;
					case "SubProcess101":
						break;
					case "InitMessage":
						e.Context.QueueTasks.Enqueue("ScriptInit_OS");
						break;
					case "ScriptInit_OS":
						break;
					case "SubProcess106":
						break;
					case "DataSourceActiveRowChangedChild":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceActiveRowChanged");
						break;
					case "ScriptDataSourceActiveRowChanged":
						break;
					case "InitializeChild":
						e.Context.QueueTasks.Enqueue("ScriptInitializeChild");
						break;
					case "ScriptInitializeChild":
						break;
					case "SubProcess107":
						break;
					case "DataSourceBeforeLoadChild":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceBeforeLoadChild");
						break;
					case "ScriptDataSourceBeforeLoadChild":
						break;
					case "SubProcess108":
						break;
					case "ThrowPageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadCompleteChild");
						break;
					case "EventSubProcessChildDeleteYesMessage":
						break;
					case "StartMessageChildDeleteYesMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskChildDeleteYesMessage");
						break;
					case "ScriptTaskChildDeleteYesMessage":
						break;
					case "EventSubProcess3":
						break;
					case "PageLoadStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadIntermediateThrowMessageEvent1");
						break;
					case "PageLoadIntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptExcludeSSPUserGroup");
						break;
					case "ScriptExcludeSSPUserGroup":
						break;
					case "EventSubProcess2":
						break;
					case "DataSourceLoadedStartMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowDataSourceLoadedMessageEvent");
						break;
					case "IntermediateThrowDataSourceLoadedMessageEvent":
						e.Context.QueueTasks.Enqueue("DataSourceLoadedScriptTask");
						break;
					case "DataSourceLoadedScriptTask":
						break;
					case "OpenLDAPUsersListEventSubProcess":
						break;
					case "OpenLDAPUsersGrid":
						e.Context.QueueTasks.Enqueue("OpenLDAPUsersListUserTask");
						break;
					case "OpenLDAPUsersListUserTask":
						break;
					case "EventSubProcess1":
						break;
					case "LDAPUsersGridClosed":
						e.Context.QueueTasks.Enqueue("ScriptLDAPUsersGridClosed");
						break;
					case "ScriptLDAPUsersGridClosed":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OpenPageAfterAdminUnitAddingEditingStartMessage");
			ActivatedEventElements.Add("InitMessage");
			ActivatedEventElements.Add("DataSourceActiveRowChangedChild");
			ActivatedEventElements.Add("InitializeChild");
			ActivatedEventElements.Add("DataSourceBeforeLoadChild");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("StartMessageChildDeleteYesMessage");
			ActivatedEventElements.Add("PageLoadStartMessage");
			ActivatedEventElements.Add("DataSourceLoadedStartMessage");
			ActivatedEventElements.Add("OpenLDAPUsersGrid");
			ActivatedEventElements.Add("LDAPUsersGridClosed");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess104":
					context.QueueTasks.Dequeue();
					break;
				case "OpenPageAfterAdminUnitAddingEditingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenPageAfterAdminUnitAddingEditingStartMessage";
					result = OpenPageAfterAdminUnitAddingEditingStartMessage.Execute(context);
					break;
				case "UserTaskOpenPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskOpenPage";
					result = UserTaskOpenPage.Execute(context);
					break;
				case "SubProcess101":
					context.QueueTasks.Dequeue();
					break;
				case "InitMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitMessage";
					result = InitMessage.Execute(context);
					break;
				case "ScriptInit_OS":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit_OS";
					result = ScriptInit_OS.Execute(context, ScriptInit_OSExecute);
					break;
				case "SubProcess106":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceActiveRowChangedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceActiveRowChangedChild";
					result = DataSourceActiveRowChangedChild.Execute(context);
					break;
				case "ScriptDataSourceActiveRowChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceActiveRowChanged";
					result = ScriptDataSourceActiveRowChanged.Execute(context, ScriptDataSourceActiveRowChangedExecute);
					break;
				case "InitializeChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitializeChild";
					result = InitializeChild.Execute(context);
					break;
				case "ScriptInitializeChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitializeChild";
					result = ScriptInitializeChild.Execute(context, ScriptInitializeChildExecute);
					break;
				case "SubProcess107":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeLoadChild";
					result = DataSourceBeforeLoadChild.Execute(context);
					break;
				case "ScriptDataSourceBeforeLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceBeforeLoadChild";
					result = ScriptDataSourceBeforeLoadChild.Execute(context, ScriptDataSourceBeforeLoadChildExecute);
					break;
				case "SubProcess108":
					context.QueueTasks.Dequeue();
					break;
				case "ThrowPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ThrowPageLoadCompleteChild.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "EventSubProcessChildDeleteYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildDeleteYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildDeleteYesMessage";
					result = StartMessageChildDeleteYesMessage.Execute(context);
					break;
				case "ScriptTaskChildDeleteYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskChildDeleteYesMessage";
					result = ScriptTaskChildDeleteYesMessage.Execute(context, ScriptTaskChildDeleteYesMessageExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadStartMessage";
					result = PageLoadStartMessage.Execute(context);
					break;
				case "PageLoadIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = PageLoadIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptExcludeSSPUserGroup":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptExcludeSSPUserGroup";
					result = ScriptExcludeSSPUserGroup.Execute(context, ScriptExcludeSSPUserGroupExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadedStartMessage";
					result = DataSourceLoadedStartMessage.Execute(context);
					break;
				case "IntermediateThrowDataSourceLoadedMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceLoaded");
					result = IntermediateThrowDataSourceLoadedMessageEvent.Execute(context);
					break;
				case "DataSourceLoadedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadedScriptTask";
					result = DataSourceLoadedScriptTask.Execute(context, DataSourceLoadedScriptTaskExecute);
					break;
				case "OpenLDAPUsersListEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OpenLDAPUsersGrid":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLDAPUsersGrid";
					result = OpenLDAPUsersGrid.Execute(context);
					break;
				case "OpenLDAPUsersListUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLDAPUsersListUserTask";
					result = OpenLDAPUsersListUserTask.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "LDAPUsersGridClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPUsersGridClosed";
					result = LDAPUsersGridClosed.Execute(context);
					break;
				case "ScriptLDAPUsersGridClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLDAPUsersGridClosed";
					result = ScriptLDAPUsersGridClosed.Execute(context, ScriptLDAPUsersGridClosedExecute);
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

		public virtual bool ScriptInit_OSExecute(ProcessExecutingContext context) {
			var selectAdminUnitTypes = new Terrasoft.Core.DB.Select(Page.UserConnection)
					.Column("Id")
					.Column("Value")
				.From("SysAdminUnitType")
				.Where("Value").IsLess(Terrasoft.Core.DB.Column.Parameter(4)) as Terrasoft.Core.DB.Select;
			var treeGridMenu = Page.TreeGrid.Menu as MenuBaseCollection;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = selectAdminUnitTypes.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						Guid id = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]);
						string name;
						
						var shemaUId = Page.GetParameterValue("Id");
						int value = UserConnection.DBTypeConverter.DBValueToInt(reader[1]);
						
						switch (value) {
							case 0 : 
								name = AddOrganization;
								break;
							case 1 : 
								name = AddDepartment;
								break;
							case 2 : 
								name = AddChief;
								break;
							case 3 : 
								name = AddTeam;
								break;
							default : 
								name = string.Empty;
								break;
						}
						
						var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem(string.Concat("MenuItem_", value), name);
						menuItem.Attributes["ValueId"] = id.ToString();
						treeGridMenu.Add(menuItem);
						menuItem.AjaxEvents.Click.Event += delegate(object sender, AjaxEventArgs e) {
							if (Page.TreeGrid.SelectedNodes.Count < 1) {
								return;
							}
							AddAdminUnit(id, new Guid(Convert.ToString(Page.TreeGrid.SelectedNodes[0].Values["Id"])));
						};
					}
				}
			}
			
			var editMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem("AdminMenuItemEdit", EditOrganizationStructureMenuItemCaption);
			editMenuItem.AjaxEvents.Click.Event += delegate(object sender, AjaxEventArgs e) {
						if (Page.TreeGrid.SelectedNodes.Count < 1) {
							return;
						}
						EditAdminUnit(new Guid(Convert.ToString(Page.TreeGrid.SelectedNodes[0].Values["Id"])), new Guid(Convert.ToString(Page.TreeGrid.SelectedNodes[0].Values["SysAdminUnitTypeId"])));
					};
			treeGridMenu.Add(editMenuItem);
			var deleteMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem("AdminMenuItemDelete", DeleteOrganizationStructureMenuItemCaption);
			deleteMenuItem.Attributes["ValueId"] = "AdminMenuItemDelete";
			deleteMenuItem.Enabled = false;
			
			deleteMenuItem.AjaxEvents.Click.Event += delegate(object sender, AjaxEventArgs e) {
						if (Page.TreeGrid.SelectedNodes.Count < 1) {
							return;
						}
						Page.ThrowEvent("RemoveMenuItemClick");
					};
			treeGridMenu.Add(deleteMenuItem);
			
			var menuSeparator = new Terrasoft.UI.WebControls.Controls.MenuSeparator() {
				ID = "menuSeparator_AdministrationMenuLDAP"
			};
			treeGridMenu.Add(menuSeparator);
			var listMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem("MenuItem_OpenLDAPUsersList", OpenLDAPUsersListCaption);
			listMenuItem.Attributes["ValueId"] = "MenuItem_OpenLDAPUsersList";
			treeGridMenu.Add(listMenuItem);
			listMenuItem.AjaxEvents.Click.Event += delegate(object sender, AjaxEventArgs e) {
				var dataSource = Page.DataSource;
				if (dataSource.SelectedItemPrimaryColumnValues.Count < 1) {
					return;
				}
				OpenLDAPUsersList(dataSource.ActiveRow.GetTypedColumnValue<Guid>(dataSource.Schema.PrimaryColumn.Name));
			};
			this.Page.TreeGrid.GetRowConfigHandler =
			 delegate(Terrasoft.Core.Entities.Entity row) {
			   string primaryColumnName = row.Schema.PrimaryColumn.Name;
			   string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			   var config = new DataSourceRowConfig(primaryColumnValue);
			   var sysAdminUnitTypeId = row.GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
				var synchWithLdap = row.GetTypedColumnValue<bool>("SynchronizeWithLDAP");
				string imageName = synchWithLdap ? "organization-synchwithldap.png" : "organization.png";
				if (sysAdminUnitTypeId == new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6")) { // Team
					imageName = synchWithLdap ? "team-synchwithldap.png" : "team.png";
				} else if (sysAdminUnitTypeId == new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Chief
					imageName = synchWithLdap ? "chief-synchwithldap.png" : "chief.png";
				} else if (sysAdminUnitTypeId == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Department
					imageName = synchWithLdap ? "department-synchwithldap.png" : "department.png";
				}
			   config.AddConfig(new ImageConfigValue(imageName));
			   if (row.Schema.HierarchyColumn != null) {
			   		Guid parentId = row.GetTypedColumnValue<Guid>(row.Schema.HierarchyColumn.ColumnValueName);
			   		if (parentId.IsEmpty()) {
			   			config.AddConfig(new DataSourceRowExpandedConfigValue(true));
					}
				}
			   return config;
			};
			
			Page.DataSource.LoadRowsResponseRegistered += (sender, e) => {
				BaseLoadRowsResponseRegisteredHandler(sender, e);
			};
			Page.DataSource.AjaxEvents.ActiveRowChanged.Event  += (sender, e) => {
				BaseActiveRowChangedHandler();
			};
			this.Page.DataSource.Loaded += this.Page.TreeGrid.DataLoaded;
			return true;
		}

		public virtual bool ScriptDataSourceActiveRowChangedExecute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
				process.SetPropertyValue("ParentRoleId", Page.DataSource.ActiveRowPrimaryColumnValue);
				((PageControl)Page.TreeGrid).FindPageControlByName("EditMenuItem").Enabled = false;
				((PageControl)Page.TreeGrid).FindPageControlByName("RemoveMenuItem").Enabled = false;
				var dataSource = Page.DataSource;
				var schema = dataSource.Schema;
				var hierarchyColumn = schema.HierarchyColumn;
				var primaryColumn =  schema.PrimaryColumn;
				if (String.IsNullOrEmpty(ListenerPageProcessUId)) {
					return true;
				}
				process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
				if (Page.DataSource.ActiveRowPrimaryColumnValue != Guid.Empty) {
					var selectedValue = Page.DataSource.ActiveRowPrimaryColumnValue;
					CheckRights(selectedValue);
					Guid parentRoleId = dataSource.ActiveRow.GetTypedColumnValue<Guid>(hierarchyColumn.ColumnValueName);
					bool isRootFolder = parentRoleId == Guid.Empty || selectedValue == parentRoleId;
					process.SetPropertyValue("IsRootFolder", isRootFolder);
				}
				SetCurrentFolderConnectionType();
				process.ThrowEvent(process.InternalContext, "FolderActiveRowChanged");
			}
			return true;
		}

		public virtual bool ScriptInitializeChildExecute(ProcessExecutingContext context) {
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			var dataSource = Page.DataSource;
			dataSource.SchemaUId =  EntitySchemaUId;
			var currentStructure = dataSource.CurrentStructure;
			currentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.NotEqual, "SysAdminUnitType.Value", (int)Terrasoft.Core.DB.SysAdminUnitType.User));
			var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
			dataSource.LoadRows();
			SetCurrentFolderConnectionType();
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;//ListenerPage as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var pageInstance = listenerPage.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			pageInstance.Process.SetPropertyValue("DataSourceFilter", null);
			pageInstance.Process.SetPropertyValue("ListenerPageProcessUId", listenerPage.Process.InstanceUId);
			pageInstance.ThrowEvent("ApplyFolderFilter");
			var unitsPage = listenerPage.PageContainer.FindPageControl("Units") as PageContainer;
			var pageUnitsInstance = unitsPage.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			pageUnitsInstance.Process.SetPropertyValue("DataSourceFilter", null);
			pageUnitsInstance.Process.SetPropertyValue("ListenerPageProcessUId", listenerPage.Process.InstanceUId);
			pageUnitsInstance.ThrowEvent("ApplyFolderFilter");
			PrepareMenuItems();
			return true;
		}

		public virtual bool ScriptDataSourceBeforeLoadChildExecute(ProcessExecutingContext context) {
			this.Page.TreeGrid.GetRowConfigHandler =
			 delegate(Terrasoft.Core.Entities.Entity row) {
			   string primaryColumnName = row.Schema.PrimaryColumn.Name;
			   string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			   var config = new DataSourceRowConfig(primaryColumnValue);
			   var sysAdminUnitTypeId = row.GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
				var synchWithLdap = row.GetTypedColumnValue<bool>("SynchronizeWithLDAP");
				string imageName = synchWithLdap ? "organization-synchwithldap.png" : "organization.png";
				if (sysAdminUnitTypeId == new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6")) { // Team
					imageName = synchWithLdap ? "team-synchwithldap.png" : "team.png";
				} else if (sysAdminUnitTypeId == new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Chief
					imageName = synchWithLdap ? "cheif-synchwithldap.png" : "cheif.png";
				} else if (sysAdminUnitTypeId == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Department
					imageName = synchWithLdap ? "department-synchwithldap.png" : "department.png";
				}
			   config.AddConfig(new ImageConfigValue(imageName));
			   if (row.Schema.HierarchyColumn != null) {
			   		Guid parentId = row.GetTypedColumnValue<Guid>(row.Schema.HierarchyColumn.ColumnValueName);
			   		if (parentId.IsEmpty()) {
			   			config.AddConfig(new DataSourceRowExpandedConfigValue(true));
					}
				}
			   return config;
			};
			this.Page.DataSource.Loaded += this.Page.TreeGrid.DataLoaded;
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			Page.TreeGrid.HideHeaders = true;
			Page.TreeGrid.QuickViewMode = Terrasoft.UI.WebControls.Controls.TreeGridQuickViewMode.None;
			Page.TreeGrid.ShowAutoWidthMenu = false;
			Page.DataSource.EnableServerActiveRow = true;
			SetCurrentFolderConnectionType();
			return true;
		}

		public virtual bool ScriptTaskChildDeleteYesMessageExecute(ProcessExecutingContext context) {
			DeleteAdminUnit();
			return true;
		}

		public virtual bool ScriptExcludeSSPUserGroupExecute(ProcessExecutingContext context) {
			var currentStructure = Page.DataSource.CurrentStructure;
			var currentFiltersGroup = currentStructure.Filters.FindByName("Current");
			if (currentFiltersGroup != null){
				currentStructure.Filters.Remove(currentFiltersGroup);
			}
			var logicalOperation = LogicalOperationStrict.And;
			var currentPositionFiltersGroup = currentStructure.CreateFiltersGroup("Current", logicalOperation);
			var portalUsersSysAdminUnitTypeUId = new Guid("f4044c41-df2b-e111-851e-00155d04c01d");
			var currentPositionFilters = currentStructure.CreateFilterWithParameters(Page.DataSource.Schema, 
				FilterComparisonType.NotEqual, "SysAdminUnitType", portalUsersSysAdminUnitTypeUId);
			currentPositionFiltersGroup.Add(currentPositionFilters);
			currentPositionFiltersGroup.IsEnabled = true;
			currentStructure.Filters.Add(currentPositionFiltersGroup);
			return true;
		}

		public virtual bool DataSourceLoadedScriptTaskExecute(ProcessExecutingContext context) {
			BaseActiveRowChangedHandler();
			return true;
		}

		public virtual bool ScriptLDAPUsersGridClosedExecute(ProcessExecutingContext context) {
			//BaseActiveRowChangedHandler();
			Page.ThrowEvent("DataSourceActiveRowChanged");
			return true;
		}

		public virtual bool HasUnitChief(Guid UnitUId) {
			var selectCount = new Terrasoft.Core.DB.Select(Page.UserConnection)
					.Column(Terrasoft.Core.DB.Func.Count(Terrasoft.Core.DB.Column.Asterisk()))
				.From("SysAdminUnit")
				.Where("SysAdminUnitTypeValue").IsEqual(Terrasoft.Core.DB.Column.Parameter(2))
				.And("ParentRoleId").IsEqual(Terrasoft.Core.DB.Column.Parameter(UnitUId)) as Terrasoft.Core.DB.Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = selectCount.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						return UserConnection.DBTypeConverter.DBValueToInt(reader[0]) > 0;
					}
				}
			}
			return false;
		}

		public virtual void AddAdminUnit(Guid SysAdminUnitTypeId, Guid ParentRoleUId) {
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			if (SysAdminUnitTypeId == new Guid("df93dcb9-6bd7-df11-9b2a-001d60e938c6")) {
				//Organization
				EditPageUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			} else if (SysAdminUnitTypeId == new Guid("b659f1c0-6bd7-df11-9b2a-001d60e938c6")) {
				// Department
				EditPageUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			} else if (SysAdminUnitTypeId == new Guid("b759f1c0-6bd7-df11-9b2a-001d60e938c6")) {
				// Chief
				EditPageUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
			} else {
				// Team (462e97c7-6bd7-df11-9b2a-001d60e938c6)
				EditPageUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			}
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			var	DefValuesId = Guid.NewGuid();
			UserConnection.SessionData[DefValuesId.ToString()] = new Dictionary<string, object>();
			var defValues = UserConnection.SessionData[DefValuesId.ToString()] as Dictionary<string, object>;
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count > 0) {
				defValues["ParentRole"] = ParentRoleUId;
			}
			defValues["SysAdminUnitType"] = SysAdminUnitTypeId;
			defValues["UserPassword"] = null;
			UserConnection.SessionData[DefValuesId.ToString()] = defValues;
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;//ListenerPage as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var pageUnitsInstance = (listenerPage.PageContainer.FindPageControl("Units") as PageContainer).PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			UserTaskOpenPage.OpenerInstanceId = InstanceUId;
			UserTaskOpenPage.UseCurrentActivePage = true;
			UserTaskOpenPage.PageUId = EditPageUId; 
			UserTaskOpenPage.PageParameters = 
			      new Dictionary<string, string> {
			            { "entitySchemaUId", EntitySchemaUId.ToString() },
			            { "treeGridId", Page.TreeGrid.ClientID },
			            { "additionalTreeGrid", pageUnitsInstance.TreeGrid.ClientID }
			      };
			if(DefValuesId != null && !DefValuesId.IsEmpty()) {
				((Dictionary<string, string>)(UserTaskOpenPage.PageParameters)).Add("defValuesId", DefValuesId.ToString());
			}
			UserTaskOpenPage.Width = editPageSchema.Width;
			UserTaskOpenPage.Height = editPageSchema.Height;
			Page.ThrowEvent("OpenPageAfterAdminUnitAddingEditing");
		}

		public virtual void EditAdminUnit(Guid RecordId, Guid AdminUnitTypeId) {
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			if (AdminUnitTypeId == new Guid("df93dcb9-6bd7-df11-9b2a-001d60e938c6")) {
				//Organization
				EditPageUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			} else if (AdminUnitTypeId == new Guid("b659f1c0-6bd7-df11-9b2a-001d60e938c6")) {
				// Department
				EditPageUId = new Guid("921acc0b-bc2d-4d46-8422-3a3cd2c99b79");
			} else if (AdminUnitTypeId == new Guid("b759f1c0-6bd7-df11-9b2a-001d60e938c6")) {
				// Chief
				EditPageUId = new Guid("247e12ab-d374-4fb5-a4d7-2ab3b0ed750a");
			} else {
				// Team (462e97c7-6bd7-df11-9b2a-001d60e938c6)
				EditPageUId = new Guid("5cc6b39d-d152-4768-91d7-ed417fca9073");
			}
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			var	DefValuesId = Guid.NewGuid();
			UserConnection.SessionData[DefValuesId.ToString()] = new Dictionary<string, object>();
			var defValues = UserConnection.SessionData[DefValuesId.ToString()] as Dictionary<string, object>;
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			UserConnection.SessionData[DefValuesId.ToString()] = defValues;
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var pageUnitsInstance = (listenerPage.PageContainer.FindPageControl("Units") as PageContainer).PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			UserTaskOpenPage.OpenerInstanceId = InstanceUId;
			UserTaskOpenPage.UseCurrentActivePage = true;
			UserTaskOpenPage.PageUId = EditPageUId; 
			UserTaskOpenPage.PageParameters = 
			      new Dictionary<string, string> {
						{ "recordId", RecordId.ToString() },
			            { "entitySchemaUId", EntitySchemaUId.ToString() },
			            { "treeGridId", Page.TreeGrid.ClientID },
			            { "additionalTreeGrid", pageUnitsInstance.TreeGrid.ClientID }
			      };
			if(DefValuesId != null && !DefValuesId.IsEmpty()) {
				((Dictionary<string, string>)(UserTaskOpenPage.PageParameters)).Add("defValuesId", DefValuesId.ToString());
			}
			UserTaskOpenPage.Width = editPageSchema.Width;
			UserTaskOpenPage.Height = editPageSchema.Height;
			Page.ThrowEvent("OpenPageAfterAdminUnitAddingEditing");
		}

		public virtual void DeleteAdminUnit() {
			var primaryRecordValue = Page.DataSource.ActiveRow.PrimaryColumnValue;
			if (primaryRecordValue != Guid.Empty) {
				try { 
					Page.DataSource.Remove(primaryRecordValue);
				}
				catch (Exception ex) {
					MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
					if (messagePanel != null) {
						messagePanel.AddMessage("WarningMessageId", Warning, DependencyWarningMessage, MessageType.Warning);
					}
				}
				var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
				var pageUnitsInstance = (listenerPage.PageContainer.FindPageControl("Units") as PageContainer).PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
				pageUnitsInstance.TreeGrid.Clear();
				pageUnitsInstance.DataSource.LoadRows();
			}
		}

		public virtual void OpenLDAPUsersList(Guid recordId) {
			OpenLDAPUsersListUserTask.OpenerInstanceId = InstanceUId;
			OpenLDAPUsersListUserTask.PageUId= new Guid("{b8a43bd7-5d88-4089-a7cf-650647a33711}");
			var schema = UserConnection.EntitySchemaManager.FindInstanceByName("SysAdminUnit");
			var sysAdminUnit = schema.CreateEntity(UserConnection);
			if (sysAdminUnit.FetchFromDB(recordId)) {
				var p = new Dictionary<string, string>();
				p.Add("LDAPEntryId", sysAdminUnit.GetTypedColumnValue<string>("LDAPEntryId"));
				p.Add("LDAPEntry", sysAdminUnit.GetTypedColumnValue<string>("LDAPEntry"));
				p.Add("LDAPEntryDN", sysAdminUnit.GetTypedColumnValue<string>("LDAPEntryDN"));
				p.Add("GroupId", recordId.ToString());
				OpenLDAPUsersListUserTask.PageParameters = p;
				OpenLDAPUsersListUserTask.CloseMessage = "LDAPUsersGridClosed";
				Page.ThrowEvent("OpenLDAPUsersGrid");
			}
			return;
		}

		public virtual void ImportLDAPUsers(Guid recordId) {
			
		}

		public override void BaseActiveRowChangedHandler() {
			var dataSource = Page.DataSource;
			var activeRow = Page.DataSource.ActiveRow;
			bool hasUnitChief = false;
			Guid sysAdminUnitTypeId = Guid.Empty;
			Guid parentId = Guid.Empty;
			if (activeRow != null) {
				sysAdminUnitTypeId = activeRow.GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
				hasUnitChief = HasUnitChief(activeRow.PrimaryColumnValue);
				parentId = activeRow.GetTypedColumnValue<Guid>("ParentRoleId");
			}
			bool parentRoleIdEmpty = parentId == Guid.Empty;
			if (Page.DataSource.ActiveRowPrimaryColumnValue != Guid.Empty) {
				var selectedValue = Page.DataSource.ActiveRowPrimaryColumnValue;
				CheckRights(selectedValue);
				SetProfileData("LastSelectedFolder", dataSource.ActiveRowPrimaryColumnValue.ToString());
			}
			var rootFolderTypeUId = new Guid("9DC5F6E6-2A61-4DE8-A059-DE30F4E74F24");
			Guid rootEmailFolderTypeUId = new Guid("6E23FA26-5BEE-E011-A86B-00155D04C01D");
			Guid recentFolderTypeUId = new Guid("C01FFB44-7407-E011-A646-16D83CAB0980");
			var duplicateMenuItems = new List<string> {
				Page.ConfigureDuplicatesMenuItem.ClientID,
				Page.StartDuplicatesSearchMenuItem.ClientID,
				//Page.ConfigureDuplicatesRightsMenuItem.ClientID
			};
			var downloadEmailsClientId = Guid.Empty.ToString("N");
			var editMailBoxSettingsClientId = (new Guid("F568855E-5551-4124-ABB7-6802F8AF3698")).ToString("N");
			var emailAutoFillClientId = (new Guid("603305bd-df7f-4863-a127-412249bc5af0")).ToString("N");
			var changeProcessClientId = (new Guid("E6C5C556-1565-4A72-97FE-22A2E58D3B01")).ToString("N");
			var addEmailSubFolderClientId = (new Guid("03D5FCF2-1A82-4A62-9872-49B903D1FFC0")).ToString("N");
			
			var organizationMenuItemId = new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6");
			var unitMenuItemId = new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6");
			var chiefMenuItemId = new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6");
			var teamMenuItemId = new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6");
			//var adminMenuItemDeleteId = treeGridMenu.Find(item => item.Attributes["ValueId"] == "AdminMenuItemDelete");
			
			var isRoot = true;
			var isRootEmail = false;
			var isRecent = false;
			var isDuplicate = false;
			foreach (var menuItem in Page.TreeGrid.Menu) {
				bool visible = false;
				Guid valueId = Guid.Empty;
				Guid.TryParse(menuItem.Attributes["ValueId"], out valueId);
				if (duplicateMenuItems.Contains(menuItem.ClientID) ||
				menuItem.ClientID == Page.AddSubEmailFolderMenuItem.ClientID ||
				menuItem.ClientID.Contains(downloadEmailsClientId) || menuItem.ClientID.Contains(editMailBoxSettingsClientId) ||
				menuItem.ClientID == Page.AddGeneralFolderMenuItem.ClientID ||
				menuItem.ClientID == Page.AddSearchFolderMenuItem.ClientID ||
				menuItem.ClientID.Contains(changeProcessClientId) ||
				menuItem.ClientID == Page.AdminRightMenuItem.ClientID ||
				menuItem.ClientID.Contains(addEmailSubFolderClientId) ||
				menuItem.ClientID.Contains(emailAutoFillClientId) ||
				menuItem.ClientID == Page.RemoveMenuItem.ClientID ||
				menuItem.ClientID == Page.EditMenuItem.ClientID) {
					menuItem.Enabled = false;
					visible = false;
					
				} else if (valueId == organizationMenuItemId) {
					visible = true;
					menuItem.Enabled = sysAdminUnitTypeId == new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6");
				} else if (valueId == unitMenuItemId || valueId == teamMenuItemId ) {
					visible = true;
					menuItem.Enabled = sysAdminUnitTypeId == new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6") || 
						sysAdminUnitTypeId == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6");
				} else if (valueId == chiefMenuItemId) {
					visible = true;
					menuItem.Enabled = sysAdminUnitTypeId == new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6") ? false : !hasUnitChief;
				} else if (menuItem.Attributes["ValueId"] == "AdminMenuItemDelete" && valueId == organizationMenuItemId) {
					visible = true;
					menuItem.Enabled = !parentRoleIdEmpty;
				} else {
					visible = true;
					menuItem.Enabled = !isRecent && !isRootEmail && !isDuplicate;// && !isMailBox;
				}	
				
				
				if(menuItem.ClientID==Page.PreloadMenuItem.ClientID 
				 	|| menuItem.ClientID==Page.NoActiveMenuItem.ClientID){
					visible = false;
					menuItem.Enabled = false;
				}
			
				if((isRecent||isRoot||isDuplicate)
					&&(menuItem.ClientID==Page.EditMenuItem.ClientID 
						|| menuItem.ClientID==Page.RemoveMenuItem.ClientID
						|| menuItem.ClientID==Page.AdminRightMenuItem.ClientID)){
					menuItem.Enabled = false;
				}
				if((isRecent||isDuplicate)&&(menuItem.ClientID==Page.AddGeneralFolderMenuItem.ClientID
					||menuItem.ClientID==Page.AddSearchFolderMenuItem.ClientID)){
					menuItem.Enabled = false;
				}
			
				if (visible){
					Page.AddScript(string.Format(" {0}.setVisible(true); ", menuItem.ClientID)); 
				} else {
					Page.AddScript(string.Format(" {0}.setVisible(false); ", menuItem.ClientID));
				}
			}
			
			string parentMenuScript = string.Format(" if ({0}.parentMenu) {{ ", Page.PreloadMenuItem.ClientID);
			parentMenuScript += string.Format(" {0}.parentMenu.render(); ", Page.PreloadMenuItem.ClientID);
			parentMenuScript += string.Format(" {0}.parentMenu.restrictHeight(); ", Page.PreloadMenuItem.ClientID);
			parentMenuScript += string.Format(" {0}.parentMenu.restrictWidth(); }}", Page.PreloadMenuItem.ClientID);
			Page.AddScript(parentMenuScript);
			PrepareMenuItems();
		}

		public override void BaseLoadRowsResponseRegisteredHandler(object sender, DataSourceEventArgs e) {
			var dataSource = Page.DataSource;
			var dataSourceRowsCount = dataSource.Rows.Count;
			dataSource.SelectedItemPrimaryColumnValues.Clear();
			var activeRowUId = Guid.Empty;
			var lastFolderFromProfile = GetProfileData("LastSelectedFolder");
			if (lastFolderFromProfile == null) {
				if (DefaultFolderId != Guid.Empty) {
					activeRowUId = DefaultFolderId;
				}
			} else if (!Ext.IsAjaxRequest) {
				activeRowUId = new Guid(lastFolderFromProfile.ToString());
			} 
			if (e.Request.AlreadyContainsRows) {
				dataSource.SetClientActiveRow(dataSource.ActiveRowPrimaryColumnValue, true);
				dataSource.SelectedItemPrimaryColumnValues.Add(dataSource.ActiveRowPrimaryColumnValue);
			} else {
				if (dataSourceRowsCount > 0) {
					if (activeRowUId == Guid.Empty) {
						if (e != null && e.Row != null) {
							activeRowUId = e.Row.PrimaryColumnValue;
						} else {
							activeRowUId = dataSource.Rows[0].PrimaryColumnValue;
						}
					}
					dataSource.SetClientActiveRow(activeRowUId, true);
					dataSource.SelectedItemPrimaryColumnValues.Add(activeRowUId);
				} else {
					dataSource.SetClientActiveRow(activeRowUId, true);
				}
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
			process.SetPropertyValue("ParentRoleId", activeRowUId);
			var schema = dataSource.Schema;
			var hierarchyColumn = schema.HierarchyColumn;
			if (activeRowUId != Guid.Empty) {
				CheckRights(activeRowUId);
				Guid parentRoleId = dataSource.ActiveRow.GetTypedColumnValue<Guid>(hierarchyColumn.ColumnValueName);
				bool isRootFolder = parentRoleId == Guid.Empty || activeRowUId == parentRoleId;
				process.SetPropertyValue("IsRootFolder", isRootFolder);
			}
		}

		public override Guid GetDuplicatesFolderId() {
			return Guid.Empty;
		}

		public virtual bool PrepareMenuItems() {
			var activeRow = Page.DataSource.ActiveRow;
			Guid sysAdminUnitTypeId = Guid.Empty;
			bool hasUnitChief = false;
			Guid parentId = Guid.Empty;
			if (activeRow != null) {
				sysAdminUnitTypeId = activeRow.GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
				hasUnitChief = HasUnitChief(activeRow.PrimaryColumnValue);
				parentId = activeRow.GetTypedColumnValue<Guid>("ParentRoleId");
				var listMenuItem = Page.TreeGrid.Menu.Find(item => item.Attributes["ValueId"] == "MenuItem_OpenLDAPUsersList");
				if (listMenuItem != null) {
					listMenuItem.Enabled = activeRow.GetTypedColumnValue<bool>("SynchronizeWithLDAP");
				}
			}
			bool parentRoleIdEmpty = parentId == Guid.Empty;
			var treeGridMenu = Page.TreeGrid.Menu;
			var organizationMenuItem = treeGridMenu.Find(item => item.Attributes["ValueId"] == new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6").ToString());
			var unitMenuItem = treeGridMenu.Find(item => item.Attributes["ValueId"] == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6").ToString());
			var chiefMenuItem = treeGridMenu.Find(item => item.Attributes["ValueId"] == new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6").ToString());
			var teamMenuItem = treeGridMenu.Find(item => item.Attributes["ValueId"] == new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6").ToString());
			var adminMenuItemDelete = treeGridMenu.Find(item => item.Attributes["ValueId"] == "AdminMenuItemDelete");
			adminMenuItemDelete.Enabled = true;
			if (sysAdminUnitTypeId == new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6")) { // Организация
				organizationMenuItem.Enabled = true;
				unitMenuItem.Enabled = true;
				chiefMenuItem.Enabled = !hasUnitChief;
				teamMenuItem.Enabled = true;
				adminMenuItemDelete.Enabled = !parentRoleIdEmpty;
			} else if (sysAdminUnitTypeId == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Подразделение
				organizationMenuItem.Enabled = false;
				unitMenuItem.Enabled = true;
				chiefMenuItem.Enabled = !hasUnitChief;
				teamMenuItem.Enabled = true;
			} else if (sysAdminUnitTypeId == new Guid("B759F1C0-6BD7-DF11-9B2A-001D60E938C6")) { // Руководитель
				organizationMenuItem.Enabled = false;
				unitMenuItem.Enabled = false;
				chiefMenuItem.Enabled = false;
				teamMenuItem.Enabled = false;
			} else if (sysAdminUnitTypeId == new Guid("462E97C7-6BD7-DF11-9B2A-001D60E938C6")) { // Команда
				organizationMenuItem.Enabled = false;
				unitMenuItem.Enabled = false;
				chiefMenuItem.Enabled = !hasUnitChief;
				teamMenuItem.Enabled = false;
			}
			if (Ext.IsAjaxRequest) {
				Page.AddScript(string.Format(" {0}.setEnabled({1}); ", organizationMenuItem.ClientID, organizationMenuItem.Enabled.ToString().ToLower())); 
				Page.AddScript(string.Format(" {0}.setEnabled({1}); ", unitMenuItem.ClientID, unitMenuItem.Enabled.ToString().ToLower())); 
				Page.AddScript(string.Format(" {0}.setEnabled({1}); ", chiefMenuItem.ClientID, chiefMenuItem.Enabled.ToString().ToLower())); 
				Page.AddScript(string.Format(" {0}.setEnabled({1}); ", teamMenuItem.ClientID, teamMenuItem.Enabled.ToString().ToLower())); 
				Page.AddScript(string.Format(" {0}.setEnabled({1}); ", adminMenuItemDelete.ClientID, adminMenuItemDelete.Enabled.ToString().ToLower())); 
			}
			return true;
		}

		public virtual void SetCurrentFolderConnectionType() {
			var activeRow = Page.DataSource.ActiveRow;
			if (activeRow != null) {
				UserConnection.SessionData["CurrentFolderConnectionType"] = activeRow.GetTypedColumnValue<int>("ConnectionType");
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpenPageAfterAdminUnitAddingEditing":
							if (ActivatedEventElements.Contains("OpenPageAfterAdminUnitAddingEditingStartMessage")) {
							context.QueueTasks.Enqueue("OpenPageAfterAdminUnitAddingEditingStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitMessage")) {
							context.QueueTasks.Enqueue("InitMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceActiveRowChanged":
							if (ActivatedEventElements.Contains("DataSourceActiveRowChangedChild")) {
							context.QueueTasks.Enqueue("DataSourceActiveRowChangedChild");
						}
						break;
					case "Initialize":
							if (ActivatedEventElements.Contains("InitializeChild")) {
							context.QueueTasks.Enqueue("InitializeChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceBeforeLoad":
							if (ActivatedEventElements.Contains("DataSourceBeforeLoadChild")) {
							context.QueueTasks.Enqueue("DataSourceBeforeLoadChild");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("StartMessageChildDeleteYesMessage")) {
							context.QueueTasks.Enqueue("StartMessageChildDeleteYesMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadStartMessage");
						}
						break;
					case "DataSourceLoaded":
							if (ActivatedEventElements.Contains("DataSourceLoadedStartMessage")) {
							context.QueueTasks.Enqueue("DataSourceLoadedStartMessage");
						}
						break;
					case "OpenLDAPUsersGrid":
							if (ActivatedEventElements.Contains("OpenLDAPUsersGrid")) {
							context.QueueTasks.Enqueue("OpenLDAPUsersGrid");
						}
						break;
					case "LDAPUsersGridClosed":
							if (ActivatedEventElements.Contains("LDAPUsersGridClosed")) {
							context.QueueTasks.Enqueue("LDAPUsersGridClosed");
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

	#region Class: AdministrationOrganizationalStructureGridPageEventsProcess

	/// <exclude/>
	public class AdministrationOrganizationalStructureGridPageEventsProcess : AdministrationOrganizationalStructureGridPageEventsProcess<Terrasoft.WebApp.AdministrationOrganizationalStructureGridPageSchemaUserControl>
	{

		public AdministrationOrganizationalStructureGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrationOrganizationalStructureGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrationOrganizationalStructureGridPageSchemaUserControl : Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DataSource.AjaxEvents.ActiveRowChanged.Event += DataSourceActiveRowChanged;
			DataSource.Loaded += DataSourceLoaded;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DataSource.AjaxEvents.ActiveRowChanged.Event -= DataSourceActiveRowChanged;
			DataSource.Loaded -= DataSourceLoaded;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrationOrganizationalStructureGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrationOrganizationalStructureGridPageEventsProcess(UserConnection);
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

		public virtual void DataSourceActiveRowChanged(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceActiveRowChanged");
		}

		public virtual void DataSourceLoaded(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceLoaded");
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
			SchemaName = "AdministrationOrganizationalStructureGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationOrganizationalStructureGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrationOrganizationalStructureGridPageEventsProcessSchema : Terrasoft.WebApp.BaseModuleFoldersPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrationOrganizationalStructureGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrationOrganizationalStructureGridPageEventsProcessSchema(AdministrationOrganizationalStructureGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrationOrganizationalStructureGridPageEventsProcess";
			UId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeUserTaskOpenPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d5b566f6-b0ca-4f49-bfe3-b1c028e59d18"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("9e5ad9f5-44df-465d-827b-db8c12fe3d8e"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("2067970e-9703-430f-95af-f06e11cb81ba"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("8ad2c9da-ea75-46f2-b1bc-c4efa7565051"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("a217c012-239b-4393-b3f8-5786bef619d7"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("7479460b-cf56-476f-b740-5ffa0a36876f"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("c7e4c890-02b2-4920-b520-4d34e2f8c7fe"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("1d0eedcd-18a3-4087-a33c-6d19a150fc33"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("454c4210-2f02-49f1-b387-2ad207b729d8"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("3c894bc8-7871-4811-b2f5-966c9750c4eb"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("3b2697eb-e1ee-4f0c-97b9-908de3989e24"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("84920d3d-54ff-4023-830b-10d86673abda"),
				ContainerUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
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
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeOpenLDAPUsersListUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("429a1972-3dcb-4731-a80f-e7ba967d9c10"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("aa706867-96ab-43a1-9485-97152f32ae08"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("0de3cf36-6d36-46be-b8b2-5bf3f64593dd"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("0fa83a09-69fc-4673-952b-05e9691894b1"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("e91a215e-090b-4161-a678-efe8e250203c"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("a0e92378-f5ec-493c-8dcf-b81a2369acff"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("ba1c5910-1fb8-4be7-84ba-38e889440383"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("055e5ed1-62bd-4648-9806-4c05c81d89bb"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("0d36c1fb-1563-44fb-8e91-cd09af87ae38"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("a806fa57-f08d-4653-98a1-a8cf48a74cb0"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("3d023f37-3cf6-4a36-8184-21c76cba684f"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("4ce5c314-b92b-422b-b1d5-d1c18fe0d3f6"),
				ContainerUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
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
			ProcessSchemaLaneSet schemaLaneSet641 = CreateLaneSet641LaneSet();
			LaneSets.Add(schemaLaneSet641);
			ProcessSchemaLane schemaLane2292 = CreateLane2292Lane();
			schemaLaneSet641.Lanes.Add(schemaLane2292);
			ProcessSchemaEventSubProcess eventsubprocess104 = CreateEventSubProcess104EventSubProcess();
			FlowElements.Add(eventsubprocess104);
			ProcessSchemaEventSubProcess subprocess101 = CreateSubProcess101EventSubProcess();
			FlowElements.Add(subprocess101);
			ProcessSchemaEventSubProcess subprocess106 = CreateSubProcess106EventSubProcess();
			FlowElements.Add(subprocess106);
			ProcessSchemaEventSubProcess subprocess107 = CreateSubProcess107EventSubProcess();
			FlowElements.Add(subprocess107);
			ProcessSchemaEventSubProcess subprocess108 = CreateSubProcess108EventSubProcess();
			FlowElements.Add(subprocess108);
			ProcessSchemaEventSubProcess eventsubprocesschilddeleteyesmessage = CreateEventSubProcessChildDeleteYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschilddeleteyesmessage);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess openldapuserslisteventsubprocess = CreateOpenLDAPUsersListEventSubProcessEventSubProcess();
			FlowElements.Add(openldapuserslisteventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent openpageafteradminunitaddingeditingstartmessage = CreateOpenPageAfterAdminUnitAddingEditingStartMessageStartMessageEvent();
			eventsubprocess104.FlowElements.Add(openpageafteradminunitaddingeditingstartmessage);
			ProcessSchemaUserTask usertaskopenpage = CreateUserTaskOpenPageUserTask();
			eventsubprocess104.FlowElements.Add(usertaskopenpage);
			ProcessSchemaStartMessageEvent initmessage = CreateInitMessageStartMessageEvent();
			subprocess101.FlowElements.Add(initmessage);
			ProcessSchemaScriptTask scriptinit_os = CreateScriptInit_OSScriptTask();
			subprocess101.FlowElements.Add(scriptinit_os);
			ProcessSchemaStartMessageEvent datasourceactiverowchangedchild = CreateDataSourceActiveRowChangedChildStartMessageEvent();
			subprocess106.FlowElements.Add(datasourceactiverowchangedchild);
			ProcessSchemaScriptTask scriptdatasourceactiverowchanged = CreateScriptDataSourceActiveRowChangedScriptTask();
			subprocess106.FlowElements.Add(scriptdatasourceactiverowchanged);
			ProcessSchemaStartMessageEvent initializechild = CreateInitializeChildStartMessageEvent();
			subprocess106.FlowElements.Add(initializechild);
			ProcessSchemaScriptTask scriptinitializechild = CreateScriptInitializeChildScriptTask();
			subprocess106.FlowElements.Add(scriptinitializechild);
			ProcessSchemaStartMessageEvent datasourcebeforeloadchild = CreateDataSourceBeforeLoadChildStartMessageEvent();
			subprocess107.FlowElements.Add(datasourcebeforeloadchild);
			ProcessSchemaScriptTask scriptdatasourcebeforeloadchild = CreateScriptDataSourceBeforeLoadChildScriptTask();
			subprocess107.FlowElements.Add(scriptdatasourcebeforeloadchild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcompletechild = CreateThrowPageLoadCompleteChildIntermediateThrowMessageEvent();
			subprocess108.FlowElements.Add(throwpageloadcompletechild);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocess108.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			subprocess108.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaStartMessageEvent startmessagechilddeleteyesmessage = CreateStartMessageChildDeleteYesMessageStartMessageEvent();
			eventsubprocesschilddeleteyesmessage.FlowElements.Add(startmessagechilddeleteyesmessage);
			ProcessSchemaScriptTask scripttaskchilddeleteyesmessage = CreateScriptTaskChildDeleteYesMessageScriptTask();
			eventsubprocesschilddeleteyesmessage.FlowElements.Add(scripttaskchilddeleteyesmessage);
			ProcessSchemaStartMessageEvent pageloadstartmessage = CreatePageLoadStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloadstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadintermediatethrowmessageevent1 = CreatePageLoadIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloadintermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptexcludesspusergroup = CreateScriptExcludeSSPUserGroupScriptTask();
			eventsubprocess3.FlowElements.Add(scriptexcludesspusergroup);
			ProcessSchemaStartMessageEvent datasourceloadedstartmessage = CreateDataSourceLoadedStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(datasourceloadedstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowdatasourceloadedmessageevent = CreateIntermediateThrowDataSourceLoadedMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowdatasourceloadedmessageevent);
			ProcessSchemaScriptTask datasourceloadedscripttask = CreateDataSourceLoadedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(datasourceloadedscripttask);
			ProcessSchemaStartMessageEvent openldapusersgrid = CreateOpenLDAPUsersGridStartMessageEvent();
			openldapuserslisteventsubprocess.FlowElements.Add(openldapusersgrid);
			ProcessSchemaUserTask openldapuserslistusertask = CreateOpenLDAPUsersListUserTaskUserTask();
			openldapuserslisteventsubprocess.FlowElements.Add(openldapuserslistusertask);
			ProcessSchemaStartMessageEvent ldapusersgridclosed = CreateLDAPUsersGridClosedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(ldapusersgridclosed);
			ProcessSchemaScriptTask scriptldapusersgridclosed = CreateScriptLDAPUsersGridClosedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptldapusersgridclosed);
			FlowElements.Add(CreateSequenceFlow14151SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14167SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14168SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14169SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14172SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14173SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14174SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14183SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAddOrganizationStructureMenuSeparatorCaptionLocalizableString());
			LocalizableStrings.Add(CreateEditOrganizationStructureMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteOrganizationStructureMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateOpenLDAPUsersListCaptionLocalizableString());
			LocalizableStrings.Add(CreateImportLDAPUsersLSLocalizableString());
			LocalizableStrings.Add(CreateAddOrganizationLocalizableString());
			LocalizableStrings.Add(CreateAddDepartmentLocalizableString());
			LocalizableStrings.Add(CreateAddChiefLocalizableString());
			LocalizableStrings.Add(CreateAddTeamLocalizableString());
			LocalizableStrings.Add(CreateDependencyWarningMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAddOrganizationStructureMenuSeparatorCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("278492c6-f091-44e1-b7e2-a79d877aa54b"),
				Name = "AddOrganizationStructureMenuSeparatorCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditOrganizationStructureMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6bfc20a6-e953-4fce-9a17-13edf52e95f2"),
				Name = "EditOrganizationStructureMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteOrganizationStructureMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f728092f-c01b-4bbe-b4fb-f00f31c5f2a8"),
				Name = "DeleteOrganizationStructureMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOpenLDAPUsersListCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c481e7f0-d549-41f8-b5be-b6872d8deddc"),
				Name = "OpenLDAPUsersListCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportLDAPUsersLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ffdf822a-b7c0-4dc3-9a6c-034a4a537922"),
				Name = "ImportLDAPUsersLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddOrganizationLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3103d22d-bd00-4777-acdf-852cf71dad42"),
				Name = "AddOrganization",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddDepartmentLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("621655d0-d721-411e-a6d9-1b57819bc3e9"),
				Name = "AddDepartment",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddChiefLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3bc0c92e-2733-451b-b9bc-80df797112c8"),
				Name = "AddChief",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddTeamLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e6eb4c46-e5b4-43d7-aa47-18e4d0728b2a"),
				Name = "AddTeam",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDependencyWarningMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04342ba0-9342-441e-9254-a7a9038d2515"),
				Name = "DependencyWarningMessage",
				CreatedInPackageId = new Guid("c6dca304-a1bb-4543-b6b7-745cf618e36d"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14151SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14151",
				UId = new Guid("9385aa8b-890d-4693-9228-6af1ecb1a242"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(399, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("763034a1-5bbb-442c-a562-c70bed084b8d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a80f75a-9b0a-4ea0-89cf-396fee7b1a95"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14167SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14167",
				UId = new Guid("cc8dc1e6-9c55-4ff0-8df2-55df3d050936"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(656, 1436),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b9b5480-7461-47c2-acb1-45dda589c53d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff6bbdc1-cf91-468b-bf19-1f2fa7c0fbc2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14168SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14168",
				UId = new Guid("104269a4-4584-439e-8cab-b850e2b25813"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(178, 1594),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("345e3cbf-93d2-4470-a7a5-a22c399c1a43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bbc383e1-6a2e-476a-b120-b64a251f008a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14169SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14169",
				UId = new Guid("d36863bb-eca1-4990-a792-398756a436c2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(423, 1596),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d423344b-b362-44a8-b707-8d027436d6da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46aec364-13b1-4d73-bb65-17c39a083ab5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14172SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14172",
				UId = new Guid("a6f3cccf-9b55-4c3d-9143-04f047b37dea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(168, 1764),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("800c312b-26f8-4774-a5c3-d400b3aa1c82"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb807065-925b-442b-8ca6-d2f0a2954a9d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14173SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14173",
				UId = new Guid("33b97502-07d5-4709-92fe-0a20f87da382"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(158, 1764),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0856fc09-35fc-4cf3-931d-be675aff2a52"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("800c312b-26f8-4774-a5c3-d400b3aa1c82"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14174SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14174",
				UId = new Guid("e3daf67f-cc36-46ba-b58f-358e599ee2c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(178, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc3d0387-e5cb-4b48-88fd-bccbaf9f147d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14183SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14183",
				UId = new Guid("6317d9a3-0baa-4609-bb22-35f967b040c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(443, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff780bb1-a1e2-43d9-a072-1e30cc77731c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("18a651b4-bef0-4c7b-abe7-f9ecda695a18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(638, 788),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7288d7b8-a644-4d16-a7a0-c11a58b7878a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79c62626-7cf3-489f-9274-feb1d0b405ff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e140ee52-aede-428c-b91c-7c5408f2d185"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(699, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43e9646d-836f-4ccd-bade-c3e8bbdbdf26"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a1d6a36-cb0f-4507-b21d-12cfea3e7458"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("90d1311d-60f4-44ff-b8a1-ca3421c2fd4a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(579, 602),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2becc203-986f-4a4e-8483-2425852ffafa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f55599e-524b-4629-90bf-9454919b0cd7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("075a9a9f-0839-4aef-a716-2bf33ce4c56a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(295, 698),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f55599e-524b-4629-90bf-9454919b0cd7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("959eb46c-86ba-49d3-b264-ca5620a338f7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("ec954ab9-31f8-4665-9e4e-c9ef8699f388"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(490, 626),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3f1e99bd-c31f-45b0-b8d5-724e0ccbe2b1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("92818466-644f-4a09-8926-c90be294e4c0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("264853b1-4ff9-4ab3-a1f8-7601468f1b8b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CurveCenterPosition = new Point(590, 622),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("92818466-644f-4a09-8926-c90be294e4c0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e9769a42-4f05-4f32-add2-985e82522bfa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet641LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet641 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3306259c-2967-49b4-8527-4c5889444cef"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"LaneSet641",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1150, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet641;
		}

		protected virtual ProcessSchemaLane CreateLane2292Lane() {
			ProcessSchemaLane schemaLane2292 = new ProcessSchemaLane(this) {
				UId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3306259c-2967-49b4-8527-4c5889444cef"),
				CreatedInOwnerSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"Lane2292",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1121, 184),
				UseBackgroundMode = false
			};
			return schemaLane2292;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess104EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess104 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("581a6a41-2a37-4479-8351-c4c655dbcb24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"EventSubProcess104",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(254, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess104;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenPageAfterAdminUnitAddingEditingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cc3d0387-e5cb-4b48-88fd-bccbaf9f147d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("581a6a41-2a37-4479-8351-c4c655dbcb24"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenPageAfterAdminUnitAddingEditing",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"OpenPageAfterAdminUnitAddingEditingStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskOpenPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f5c757aa-8e00-4e91-a974-6ed91c99ee2d"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("581a6a41-2a37-4479-8351-c4c655dbcb24"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"UserTaskOpenPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 58),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskOpenPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess101EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess101 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("68ce32ea-bf91-4025-9433-2c031b27e6d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"SubProcess101",
				Position = new Point(36, 205),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess101;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("763034a1-5bbb-442c-a562-c70bed084b8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("68ce32ea-bf91-4025-9433-2c031b27e6d5"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"InitMessage",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInit_OSScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a80f75a-9b0a-4ea0-89cf-396fee7b1a95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("68ce32ea-bf91-4025-9433-2c031b27e6d5"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptInit_OS",
				Position = new Point(112, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,91,79,219,72,20,126,14,18,255,97,214,79,142,22,166,164,237,194,178,148,174,114,107,27,137,82,196,165,125,168,170,106,98,31,18,119,29,59,154,25,135,178,171,254,247,61,103,102,124,195,54,165,93,30,86,2,18,207,156,203,119,238,199,108,132,100,10,98,8,244,48,92,69,201,85,18,233,203,219,53,40,118,204,18,184,97,151,32,165,80,233,181,230,227,84,2,159,140,248,133,33,246,207,196,2,248,149,2,57,78,147,4,15,162,52,233,111,111,245,122,72,23,103,171,196,247,102,161,87,63,120,47,226,12,204,25,127,37,211,149,239,93,220,170,154,78,123,247,97,9,18,10,106,62,83,39,160,148,223,196,97,197,242,51,33,197,10,52,72,255,121,191,207,132,234,68,124,180,189,181,65,91,181,4,120,45,163,240,45,36,25,218,104,204,184,116,103,220,28,162,12,250,28,9,5,168,35,182,182,33,119,166,162,100,193,124,18,18,206,167,95,33,200,116,42,81,68,221,9,124,154,168,76,194,100,84,30,249,8,236,31,52,173,34,64,130,8,129,152,219,92,207,173,112,56,55,68,126,169,204,201,233,221,44,163,24,152,111,133,112,34,203,85,244,122,175,179,40,100,248,211,192,53,25,145,112,60,216,128,68,119,225,179,113,241,101,74,28,78,214,199,189,79,253,35,35,70,105,73,96,19,244,173,61,48,127,8,186,90,194,74,92,205,194,220,121,175,65,23,49,48,18,109,232,45,87,148,104,182,161,195,31,192,51,75,116,14,103,144,195,177,152,110,34,29,44,201,129,72,151,219,219,11,48,78,108,143,253,193,236,99,143,32,163,182,97,24,190,147,11,145,68,127,11,23,63,115,59,71,201,127,29,85,56,7,109,156,19,88,11,169,87,144,232,78,190,167,109,124,227,101,4,215,157,44,207,218,88,46,65,172,218,56,66,184,22,89,172,27,44,54,48,124,186,90,235,219,22,190,111,245,96,161,9,217,76,195,170,81,205,87,51,254,1,230,232,125,45,211,88,241,226,203,91,199,224,59,61,120,17,8,237,123,249,249,103,111,199,6,180,191,99,146,195,197,39,215,195,135,26,249,230,152,188,234,163,45,97,204,133,79,168,29,139,235,50,189,48,50,125,199,83,173,68,142,158,240,115,33,13,153,95,196,215,233,6,131,129,56,227,40,248,139,155,7,246,235,49,11,177,122,22,66,131,159,206,191,96,90,97,53,37,152,54,59,172,224,24,202,133,98,101,174,68,215,204,175,87,188,237,13,16,158,166,33,144,27,50,20,252,130,13,10,142,158,4,157,201,60,125,172,119,123,8,182,168,88,63,10,119,140,111,77,25,185,116,46,109,189,71,27,22,27,55,46,66,87,145,151,250,125,103,248,55,243,65,186,240,23,127,108,227,130,48,210,111,127,58,156,158,1,156,63,78,81,22,6,146,62,170,69,130,152,179,0,205,133,156,110,44,214,166,177,35,160,170,250,199,139,200,143,7,164,26,15,27,14,178,162,12,199,35,133,226,17,98,122,119,188,85,99,76,33,110,228,127,213,197,125,55,174,200,159,26,30,43,238,19,35,13,35,111,191,60,52,246,117,16,157,53,222,170,171,201,62,77,196,60,6,154,31,215,34,86,52,94,154,26,254,79,249,101,249,151,50,189,49,10,124,239,28,86,233,166,244,19,1,244,238,9,107,221,182,254,81,94,208,212,223,46,104,208,8,187,71,60,60,178,5,151,111,97,207,38,228,253,154,188,207,38,22,17,118,113,19,93,226,58,153,12,207,60,108,40,109,24,107,188,121,238,197,200,254,31,50,175,24,25,239,214,144,144,114,90,0,212,9,10,197,4,108,156,85,210,173,170,183,59,217,238,17,223,102,97,85,104,83,201,227,228,155,41,88,161,197,69,154,201,0,242,5,105,82,156,80,142,80,70,150,52,69,58,18,140,51,25,173,132,188,181,139,173,237,34,141,4,45,211,147,146,179,97,122,85,244,16,247,172,13,156,167,55,180,162,81,3,10,43,146,95,80,107,123,89,67,18,208,98,199,107,32,248,41,141,120,114,151,201,154,101,164,120,189,154,80,50,42,192,224,95,71,139,55,34,9,99,90,106,183,183,74,183,221,217,198,167,137,142,116,68,43,46,125,185,101,88,84,198,48,198,220,98,195,214,85,253,167,118,231,65,170,110,120,71,157,220,239,221,226,41,173,11,42,135,126,67,75,191,190,158,160,68,10,102,96,12,115,185,95,198,177,48,217,111,234,171,112,171,198,0,40,193,116,196,163,109,104,152,214,98,229,37,193,242,67,164,151,39,161,88,223,35,106,158,166,177,17,133,228,50,197,6,15,134,137,202,223,200,114,190,66,228,11,112,30,174,139,254,147,121,105,101,52,236,154,91,92,190,151,49,222,242,117,178,240,112,45,173,145,152,195,60,189,219,236,62,46,231,169,247,124,255,233,244,240,96,124,176,187,63,154,28,236,78,94,13,6,187,135,163,167,195,221,189,189,193,100,127,111,122,248,236,247,241,190,71,47,52,236,201,19,70,251,49,37,254,189,104,53,18,117,160,164,171,2,221,55,6,56,113,216,67,64,142,14,126,59,124,53,24,239,61,8,164,217,251,191,139,50,32,170,14,152,230,238,167,112,238,255,0,206,242,189,230,187,96,195,130,180,3,113,73,80,194,54,169,111,139,134,154,174,43,18,2,59,35,93,246,217,86,96,161,188,239,42,134,140,173,20,250,155,8,164,144,193,210,213,22,251,5,141,206,226,56,239,22,238,69,23,33,32,128,7,20,86,183,100,94,33,62,117,111,52,70,1,1,202,229,243,153,50,111,92,238,61,219,220,247,90,13,173,117,137,233,215,53,54,69,8,171,134,227,158,5,249,22,88,248,204,182,117,231,58,215,110,183,183,238,140,15,126,146,138,16,165,170,115,80,235,52,81,112,14,11,236,249,32,113,153,194,81,229,231,179,9,167,209,241,75,51,46,232,127,24,221,76,174,97,87,248,156,230,187,122,43,227,177,24,42,227,165,72,22,16,186,73,121,143,254,187,28,185,214,230,84,185,99,169,181,170,101,232,16,157,37,64,118,231,57,242,234,209,191,191,132,245,105,204,18,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess106EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess106 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2229b127-9bec-4361-ac4a-c7c0b9c19ff9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"SubProcess106",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 371),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 235),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess106;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceActiveRowChangedChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("345e3cbf-93d2-4470-a7a5-a22c399c1a43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2229b127-9bec-4361-ac4a-c7c0b9c19ff9"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"DataSourceActiveRowChangedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceActiveRowChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bbc383e1-6a2e-476a-b120-b64a251f008a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2229b127-9bec-4361-ac4a-c7c0b9c19ff9"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptDataSourceActiveRowChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,193,110,156,48,16,61,111,165,254,131,195,9,164,200,63,144,166,82,67,201,22,169,77,87,236,38,119,7,79,192,170,177,209,216,108,138,154,254,123,109,3,187,176,85,34,37,202,117,230,205,123,243,102,198,22,15,36,62,51,22,133,170,104,110,110,58,41,127,98,214,180,182,143,191,11,99,65,1,110,88,5,27,212,37,24,115,155,243,36,33,127,62,126,88,237,25,146,118,8,146,75,114,107,0,83,173,20,148,86,104,69,243,17,158,169,74,40,160,107,176,99,224,170,119,12,207,17,95,56,218,145,146,110,67,73,11,104,251,59,38,59,136,163,13,67,80,182,208,18,114,30,157,19,95,75,191,50,203,182,186,195,18,232,23,167,188,135,66,63,110,80,52,12,251,84,203,174,81,161,54,16,199,177,175,112,61,90,212,50,9,213,59,4,88,163,224,9,189,22,138,207,210,87,253,13,107,156,100,198,133,253,1,170,203,45,52,81,66,51,197,238,37,112,103,247,129,73,3,111,101,45,160,209,123,120,153,215,79,151,31,204,185,204,137,221,9,99,202,26,26,230,242,71,48,221,134,216,132,168,5,32,195,178,30,7,226,160,67,13,253,182,76,92,28,118,58,27,159,67,79,240,197,88,61,88,184,187,217,190,250,108,86,8,182,67,69,44,118,193,196,223,227,206,223,243,140,124,115,175,184,16,114,118,73,214,157,224,52,56,24,59,13,243,5,233,122,1,62,160,254,91,195,75,156,190,141,85,90,67,249,171,16,85,109,77,188,224,10,93,174,188,38,105,103,135,189,220,228,129,221,91,223,245,45,240,25,255,39,95,252,57,62,217,47,157,33,252,185,13,58,247,90,75,34,76,161,181,189,214,146,3,58,157,165,236,220,63,121,122,58,53,190,132,7,206,231,95,106,62,19,114,47,117,174,155,76,59,119,85,105,135,158,114,72,28,183,238,125,198,139,191,96,87,163,126,204,246,14,27,79,161,92,89,64,197,164,127,90,240,219,158,147,104,160,57,76,44,173,153,170,128,71,158,200,233,205,175,238,31,204,175,255,169,241,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitializeChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7b9b5480-7461-47c2-acb1-45dda589c53d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2229b127-9bec-4361-ac4a-c7c0b9c19ff9"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Initialize",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"InitializeChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitializeChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ff6bbdc1-cf91-468b-bf19-1f2fa7c0fbc2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2229b127-9bec-4361-ac4a-c7c0b9c19ff9"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptInitializeChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,111,155,64,16,189,87,234,127,64,156,64,138,54,63,192,202,193,118,236,8,41,137,80,177,155,243,150,157,218,43,193,46,157,29,18,241,239,59,11,139,13,78,170,90,105,47,72,204,188,121,243,241,30,228,242,0,98,135,0,15,168,149,200,106,126,125,212,142,162,187,40,222,1,162,116,246,39,137,23,248,177,108,154,120,241,245,203,171,196,72,73,146,133,109,177,4,70,229,190,254,254,20,97,200,57,45,138,242,8,181,220,103,138,129,209,198,144,166,238,20,10,100,101,139,8,134,10,194,182,164,22,61,229,132,96,125,145,229,162,203,2,177,213,21,1,58,177,84,42,153,150,34,72,130,33,249,162,233,152,75,148,53,120,100,50,4,215,182,110,36,106,103,205,174,107,64,60,91,218,252,106,101,117,19,197,69,231,150,170,214,102,111,52,245,185,239,178,106,33,190,137,18,109,40,61,159,101,109,185,253,253,74,188,195,239,29,96,154,134,13,27,180,37,56,199,139,249,240,218,26,3,37,105,107,68,150,15,153,141,57,104,3,226,1,40,4,86,29,223,39,241,50,128,1,244,23,14,9,14,167,243,11,63,90,169,190,217,55,151,248,120,1,20,14,182,181,149,154,246,242,83,37,227,64,213,132,152,167,74,122,9,253,131,241,36,121,20,228,55,207,34,158,37,111,117,56,133,35,233,162,25,46,237,203,50,227,72,26,118,3,167,47,61,35,86,210,193,147,85,109,5,30,26,212,31,238,64,104,171,197,237,237,116,207,79,81,132,51,79,39,185,155,45,41,122,111,95,53,170,71,254,169,203,180,131,8,138,136,162,87,173,1,164,174,119,73,18,159,63,134,193,103,236,27,211,86,85,122,61,195,199,202,51,207,108,169,177,126,36,12,230,152,245,216,29,209,190,109,94,89,203,36,230,21,171,110,48,70,24,108,52,68,203,190,117,193,13,243,22,51,83,108,181,81,99,132,47,146,196,222,239,46,78,223,217,98,162,72,15,153,200,114,106,245,127,228,152,209,127,94,147,107,105,254,89,152,121,163,191,171,147,35,240,63,10,158,192,180,25,65,61,124,230,8,252,223,51,17,255,0,97,241,27,253,22,166,215,191,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess107EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess107 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("245e6c36-605c-43b9-b502-7f50c6190d08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"SubProcess107",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 205),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(236, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess107;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeLoadChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d423344b-b362-44a8-b707-8d027436d6da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245e6c36-605c-43b9-b502-7f50c6190d08"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceBeforeLoad",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"DataSourceBeforeLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceBeforeLoadChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("46aec364-13b1-4d73-bb65-17c39a083ab5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("245e6c36-605c-43b9-b502-7f50c6190d08"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptDataSourceBeforeLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,148,81,143,210,64,16,199,159,107,226,119,24,251,212,198,176,7,167,130,136,104,160,229,56,146,139,33,130,250,188,178,67,187,73,187,219,108,183,135,104,238,187,187,219,22,40,225,184,67,31,154,180,157,153,255,252,254,147,157,213,49,207,201,156,70,72,150,10,113,170,56,35,83,212,95,229,38,144,98,205,163,91,42,88,130,10,134,47,95,0,195,4,35,170,209,91,162,82,52,151,107,77,2,169,144,76,132,230,154,99,94,189,108,65,201,141,15,127,76,1,64,174,21,23,17,100,138,167,84,109,3,153,20,169,248,66,83,132,161,205,34,139,85,140,41,37,243,102,152,216,248,224,108,245,119,154,20,187,114,3,218,248,233,157,116,241,201,82,46,74,13,207,175,20,239,169,130,85,105,204,72,8,220,64,72,53,93,200,66,173,112,111,217,59,237,215,168,206,183,249,136,165,92,124,19,92,47,183,25,206,216,1,198,126,179,70,217,199,105,193,217,39,207,93,156,212,184,86,209,169,244,196,42,254,193,117,124,199,104,246,132,212,79,41,147,82,202,164,43,41,248,111,44,139,194,209,188,210,170,103,101,200,35,172,39,124,44,253,25,92,169,34,106,42,169,230,82,180,202,232,198,68,19,19,37,153,136,92,248,112,156,82,254,180,218,124,13,222,99,190,171,17,90,147,158,251,182,123,61,233,247,130,94,171,59,14,123,173,240,166,211,105,245,199,215,163,86,187,221,9,187,237,73,255,205,251,160,235,250,230,92,192,213,21,44,145,166,70,215,121,146,86,155,164,51,148,54,180,167,123,0,76,114,132,75,32,199,189,119,253,155,78,208,190,8,50,136,57,174,159,165,52,39,152,175,207,96,150,177,255,226,236,254,3,103,136,25,85,58,69,161,159,133,101,251,212,51,196,135,132,3,118,121,244,171,165,33,35,198,234,37,177,176,51,219,171,250,174,54,112,223,220,175,55,198,154,109,44,250,45,71,69,213,42,174,119,11,94,25,211,69,146,236,110,11,199,177,246,193,32,24,128,11,22,235,188,50,105,36,151,60,131,186,129,5,218,233,147,89,62,73,51,189,245,252,3,128,243,168,209,163,91,98,242,43,51,151,34,178,166,113,173,138,202,179,99,231,85,207,76,161,46,148,168,71,103,98,15,230,209,251,235,246,160,73,238,36,53,122,240,122,8,250,244,54,182,121,85,130,41,175,37,109,187,193,95,188,100,211,124,186,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess108EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess108 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4ab40cd0-0ae9-4fae-bcee-befff4a08e13"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"SubProcess108",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(309, 373),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(291, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess108;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteChildIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("800c312b-26f8-4774-a5c3-d400b3aa1c82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ab40cd0-0ae9-4fae-bcee-befff4a08e13"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ThrowPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(98, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cb807065-925b-442b-8ca6-d2f0a2954a9d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ab40cd0-0ae9-4fae-bcee-befff4a08e13"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(182, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,59,14,194,48,16,68,123,36,238,144,18,26,95,0,81,68,252,139,32,192,1,106,39,158,16,139,200,139,214,107,34,110,143,37,4,8,209,77,241,222,238,204,206,92,160,74,6,86,236,172,90,59,139,53,140,5,135,108,154,9,71,76,134,131,221,15,178,143,174,190,158,28,250,130,44,18,84,130,217,4,106,68,29,55,234,140,106,70,94,152,186,160,62,225,173,254,152,106,75,254,255,184,110,169,207,163,208,217,89,105,11,248,152,30,52,166,11,31,114,110,196,104,138,92,67,45,188,169,58,104,240,29,156,215,226,238,56,80,255,109,173,33,179,200,12,47,75,234,210,160,84,199,35,97,228,203,199,13,163,113,66,24,18,217,191,132,39,111,131,16,209,8,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0856fc09-35fc-4cf3-931d-be675aff2a52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ab40cd0-0ae9-4fae-bcee-befff4a08e13"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildDeleteYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildDeleteYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0372dee4-1679-4feb-9573-e71ef367c502"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"EventSubProcessChildDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(512, 205),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(237, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildDeleteYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildDeleteYesMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("43e9646d-836f-4ccd-bade-c3e8bbdbdf26"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0372dee4-1679-4feb-9573-e71ef367c502"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"StartMessageChildDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskChildDeleteYesMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2a1d6a36-cb0f-4507-b21d-12cfea3e7458"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0372dee4-1679-4feb-9573-e71ef367c502"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptTaskChildDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,205,73,45,73,117,76,201,205,204,11,205,203,44,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,230,21,115,65,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1ea3f202-6d4f-4c80-8071-14175449706d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 616),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(320, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2becc203-986f-4a4e-8483-2425852ffafa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ea3f202-6d4f-4c80-8071-14175449706d"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"PageLoadStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2f55599e-524b-4629-90bf-9454919b0cd7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ea3f202-6d4f-4c80-8071-14175449706d"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"PageLoadIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptExcludeSSPUserGroupScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("959eb46c-86ba-49d3-b264-ca5620a338f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ea3f202-6d4f-4c80-8071-14175449706d"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptExcludeSSPUserGroup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,93,107,194,48,20,125,158,224,127,200,250,212,130,45,205,168,48,24,62,56,231,68,24,78,236,100,207,215,228,170,129,52,233,210,196,33,99,255,125,41,202,220,234,215,83,32,247,156,115,207,185,247,110,192,16,230,140,65,101,115,107,28,179,206,32,233,145,41,172,48,121,2,11,185,118,134,97,50,104,64,30,218,173,205,129,249,44,164,69,83,141,140,118,165,39,55,245,146,125,221,191,138,63,110,39,80,96,24,236,21,131,200,75,137,37,9,79,73,221,246,136,114,82,70,95,237,214,205,89,209,25,22,122,131,167,248,181,244,247,206,168,212,43,193,64,190,150,104,192,10,173,188,203,151,198,151,87,22,204,38,125,197,255,135,155,234,74,212,245,107,33,7,6,193,226,95,212,33,100,231,200,64,180,111,82,106,99,65,206,43,207,201,183,85,159,23,66,205,149,176,111,219,18,231,99,238,251,40,252,36,35,39,120,24,44,179,52,203,88,70,99,190,188,91,196,72,41,141,239,187,20,227,52,165,221,46,79,51,150,82,30,68,23,205,95,243,253,46,236,122,10,198,47,168,70,135,205,43,200,217,26,11,232,16,191,142,29,126,160,139,18,140,168,180,170,13,39,19,109,135,31,14,100,135,4,205,48,126,4,151,163,214,198,47,76,60,233,115,30,158,174,95,99,142,171,161,130,133,196,122,154,62,53,30,224,199,199,116,190,203,239,69,25,244,12,181,83,250,1,31,113,165,91,62,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a2af9340-0bb9-4a8e-bd8e-6e47b8bc5ded"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(364, 532),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(304, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3f1e99bd-c31f-45b0-b8d5-724e0ccbe2b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2af9340-0bb9-4a8e-bd8e-6e47b8bc5ded"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoaded",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"DataSourceLoadedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowDataSourceLoadedMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("92818466-644f-4a09-8926-c90be294e4c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2af9340-0bb9-4a8e-bd8e-6e47b8bc5ded"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceLoaded",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"IntermediateThrowDataSourceLoadedMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceLoadedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e9769a42-4f05-4f32-add2-985e82522bfa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2af9340-0bb9-4a8e-bd8e-6e47b8bc5ded"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"DataSourceLoadedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,74,44,78,117,76,46,201,44,75,13,202,47,119,206,72,204,75,79,77,241,72,204,75,201,73,45,210,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,1,66,124,56,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenLDAPUsersListEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenLDAPUsersListEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eb632d8f-bf82-4bdc-b317-5ba169766abc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"OpenLDAPUsersListEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 819),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 125),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenLDAPUsersListEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenLDAPUsersGridStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ff780bb1-a1e2-43d9-a072-1e30cc77731c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb632d8f-bf82-4bdc-b317-5ba169766abc"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenLDAPUsersGrid",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"OpenLDAPUsersGrid",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLDAPUsersListUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5d87aee6-6403-4676-8730-336dfa22181e"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb632d8f-bf82-4bdc-b317-5ba169766abc"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"OpenLDAPUsersListUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 25),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLDAPUsersListUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("68e58fd7-7ca7-477f-98f1-72633c3af1a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("779a0b89-6b93-49d5-b18c-3c2bc220c0d8"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(518, 819),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(203, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLDAPUsersGridClosedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7288d7b8-a644-4d16-a7a0-c11a58b7878a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("68e58fd7-7ca7-477f-98f1-72633c3af1a7"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LDAPUsersGridClosed",
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"LDAPUsersGridClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLDAPUsersGridClosedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("79c62626-7cf3-489f-9274-feb1d0b405ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("68e58fd7-7ca7-477f-98f1-72633c3af1a7"),
				CreatedInOwnerSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Name = @"ScriptLDAPUsersGridClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(91, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,119,74,44,78,117,76,46,201,44,75,13,202,47,119,206,72,204,75,79,77,241,72,204,75,201,73,45,210,208,180,230,229,10,72,76,79,213,11,201,40,202,47,119,45,75,205,43,209,80,114,73,44,73,12,206,47,45,74,198,208,166,4,82,95,148,90,82,90,148,167,80,82,84,154,106,13,0,15,190,141,247,94,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateHasUnitChiefMethod());
			Methods.Add(CreateAddAdminUnitMethod());
			Methods.Add(CreateEditAdminUnitMethod());
			Methods.Add(CreateDeleteAdminUnitMethod());
			Methods.Add(CreateOpenLDAPUsersListMethod());
			Methods.Add(CreateImportLDAPUsersMethod());
			Methods.Add(CreatePrepareMenuItemsMethod());
			Methods.Add(CreateSetCurrentFolderConnectionTypeMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7f31a6a4-bc1c-4fe7-a868-46f41a751cae"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("280266a9-7e7c-426f-889a-c55022bf8dad"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "TerrasoftWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e7d1a6da-33e5-422f-b521-99a7bd5db9e9"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d0f065b1-fb3f-4bde-97ea-4249e31725db"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateBaseActiveRowChangedHandlerMethod() {
			SchemaMethod method = base.CreateBaseActiveRowChangedHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,91,111,155,72,20,126,78,165,254,135,137,31,34,172,45,4,99,192,176,109,186,226,154,86,106,171,40,78,187,15,171,125,152,192,56,30,45,6,11,134,164,217,196,255,125,231,2,134,24,112,156,170,187,43,37,114,60,115,206,119,238,223,129,220,194,28,196,144,192,121,86,230,17,2,103,224,2,222,32,197,223,158,188,125,253,234,150,138,192,136,224,91,116,153,221,117,37,20,167,190,163,178,215,89,150,128,37,44,190,166,152,120,75,140,22,84,126,1,147,130,225,156,151,56,6,197,125,225,196,43,156,50,129,171,251,53,250,24,83,9,118,163,4,171,53,185,175,197,214,48,71,41,233,94,226,5,144,26,95,142,207,64,90,38,201,24,60,188,126,117,212,139,188,149,85,206,17,63,141,189,44,41,87,233,55,152,148,232,29,131,126,47,141,230,29,205,209,152,218,58,218,137,227,67,235,107,227,132,114,145,227,21,204,239,91,184,92,185,21,193,65,78,92,112,249,203,44,169,205,111,170,108,174,91,23,60,13,20,177,1,239,201,207,96,125,186,158,178,12,54,250,34,143,172,220,5,74,80,68,80,44,132,246,148,188,11,201,98,247,150,40,250,235,18,223,44,73,33,61,129,226,153,153,35,114,145,103,11,156,32,134,40,141,62,193,130,204,43,169,48,75,98,148,143,222,180,122,114,159,49,229,42,155,147,28,167,55,210,184,74,25,243,62,207,50,34,128,88,178,191,242,26,164,232,142,71,42,141,108,223,51,66,51,48,101,205,49,39,178,238,7,150,236,168,134,45,251,193,84,13,245,96,166,135,154,206,11,192,27,145,97,5,43,136,147,97,64,51,208,166,161,163,153,178,225,6,129,28,168,147,137,236,88,166,43,171,234,196,48,124,85,247,212,137,223,2,68,17,45,221,48,26,149,14,67,87,215,229,153,174,206,42,52,83,55,229,137,233,91,83,207,113,85,219,82,57,26,139,52,46,215,9,142,32,65,159,81,90,126,36,104,85,84,88,159,112,65,222,21,60,53,239,121,85,121,5,189,44,93,224,155,50,71,126,173,87,212,138,138,151,96,214,82,254,155,90,120,78,96,78,26,193,57,130,121,180,236,21,63,61,29,66,23,61,208,81,162,149,170,3,200,238,210,36,131,49,79,113,81,221,63,157,250,166,198,163,47,219,192,81,140,201,103,170,226,102,223,105,59,17,122,219,86,150,154,116,134,134,105,89,134,17,200,134,97,208,106,79,52,93,118,92,119,38,155,150,170,133,150,19,78,77,219,26,141,199,253,70,152,83,78,73,178,16,39,73,63,188,169,78,167,170,113,29,203,241,98,182,144,117,203,156,202,112,162,205,152,33,77,183,175,35,3,46,212,33,248,104,9,211,27,68,71,33,66,197,128,247,129,233,25,158,97,208,234,27,166,33,235,206,76,147,237,89,24,200,154,230,104,129,97,249,83,87,157,12,193,195,88,100,117,94,94,139,110,235,55,161,78,125,35,244,66,77,158,56,150,70,77,152,212,132,69,237,232,182,107,211,59,218,140,94,111,4,194,72,150,223,192,20,255,13,9,206,210,186,204,59,13,237,135,246,212,247,92,91,54,93,127,38,251,33,109,104,219,213,28,54,30,190,169,6,246,212,242,204,173,211,37,37,216,1,28,215,52,236,112,226,169,7,225,68,140,164,135,128,102,47,0,34,8,174,6,112,116,83,11,236,153,55,123,22,231,244,84,212,131,174,152,26,202,167,124,71,196,138,34,57,66,231,57,142,217,149,18,226,52,150,48,21,0,103,239,1,251,84,28,66,211,126,93,210,97,250,99,196,57,143,174,135,63,25,239,143,156,46,96,171,50,184,184,164,212,197,241,203,122,139,139,51,222,21,173,189,92,221,112,94,234,28,111,103,185,117,179,200,114,4,163,37,144,152,200,170,114,0,224,84,172,137,171,42,30,133,185,38,86,10,223,99,183,184,192,215,73,27,231,136,19,226,173,8,106,119,211,243,75,10,118,79,23,99,129,164,218,76,127,62,222,128,172,36,53,18,95,50,108,17,118,217,145,113,20,129,56,45,26,188,154,147,198,224,241,145,234,117,206,89,170,121,92,78,28,211,81,106,237,130,14,173,13,32,52,70,251,217,142,89,6,123,180,246,112,221,33,78,159,163,20,229,240,133,62,63,137,154,51,255,143,198,220,203,114,7,248,77,123,155,111,143,151,91,28,36,190,33,171,173,84,247,49,254,179,206,94,162,85,118,139,94,156,218,32,198,221,232,196,192,52,90,65,10,233,208,196,237,169,57,234,153,164,35,250,187,1,136,126,3,172,243,183,51,117,54,192,208,149,153,6,169,98,137,94,203,125,79,214,63,196,240,3,46,238,144,62,157,134,214,229,14,1,255,15,142,51,135,152,129,222,55,140,31,218,80,3,121,216,89,90,63,53,212,195,150,30,248,77,180,20,248,21,28,183,223,126,118,124,222,79,198,131,203,9,156,156,128,159,219,153,199,157,151,163,150,167,47,193,217,238,63,234,226,113,123,77,138,239,219,45,248,246,244,180,58,170,24,153,219,99,211,39,126,240,162,187,89,206,206,248,184,95,228,136,113,127,151,38,168,26,56,234,91,1,149,226,151,76,188,1,117,185,226,97,136,13,246,209,199,134,61,33,48,71,165,58,232,199,71,17,49,251,220,70,58,102,56,39,39,131,225,244,178,151,152,147,61,177,12,80,229,115,106,123,214,193,120,252,44,97,110,122,226,109,226,220,19,227,179,219,147,89,126,124,220,163,190,119,119,30,230,122,245,48,83,149,89,168,108,225,163,28,175,137,36,94,244,148,48,203,87,144,72,35,240,160,110,148,2,145,111,66,69,98,157,63,126,11,232,91,117,247,169,135,158,239,76,204,203,176,185,167,195,224,34,4,30,133,0,170,254,117,193,114,33,12,48,238,218,49,193,194,101,102,26,81,74,10,15,204,196,222,65,98,214,58,232,191,116,225,159,66,43,244,15,90,28,73,196,240,239,24,96,2,17,249,128,88,3,255,7,134,126,199,49,89,50,59,155,205,33,150,118,10,190,107,152,139,228,136,29,111,159,163,41,248,63,164,14,78,46,57,20,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBaseLoadRowsResponseRegisteredHandlerMethod() {
			SchemaMethod method = base.CreateBaseLoadRowsResponseRegisteredHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,193,110,26,49,16,61,179,95,225,112,136,22,41,178,114,167,137,68,9,73,87,138,42,4,73,47,85,15,206,238,0,110,189,54,181,189,36,168,225,223,59,182,23,240,238,134,168,233,129,3,227,231,247,222,188,241,236,134,105,82,48,203,230,170,210,57,144,43,50,101,75,160,55,135,202,48,217,52,16,51,245,108,198,170,146,22,161,199,42,117,101,234,235,195,36,42,207,65,64,110,161,200,44,148,83,205,75,166,183,99,37,170,82,126,99,162,2,188,33,128,233,116,16,68,88,110,249,198,9,60,102,5,178,223,85,188,160,147,114,109,183,225,88,48,99,111,149,40,64,223,106,133,108,106,193,133,51,124,7,182,254,227,92,167,253,123,196,237,117,3,190,143,2,124,65,210,19,12,87,68,86,66,12,200,159,164,231,80,55,176,96,149,168,129,232,228,44,182,226,81,189,150,211,214,141,97,210,219,37,59,2,194,0,113,132,103,147,23,75,51,51,250,201,94,102,240,27,219,182,158,165,69,34,225,217,235,188,237,146,62,168,185,213,92,46,211,1,54,179,35,190,31,140,61,240,209,145,208,192,10,204,86,90,198,165,113,211,240,26,141,81,216,177,224,32,237,104,175,155,70,167,135,98,119,74,23,196,234,10,80,181,247,129,193,142,138,226,31,233,125,59,62,171,58,255,183,222,218,53,185,12,201,59,64,51,184,238,116,60,8,220,220,220,92,201,249,57,241,239,115,95,168,65,237,252,61,134,118,253,13,29,248,232,176,123,177,181,5,223,47,127,156,100,73,194,239,253,169,196,244,199,236,63,26,126,204,226,238,71,29,252,143,60,62,104,191,132,107,173,114,48,6,219,126,52,160,241,189,73,116,194,149,164,217,52,156,76,228,146,75,160,97,41,93,225,243,22,137,210,123,110,44,72,208,238,235,82,31,4,99,53,161,115,130,245,53,104,187,245,93,164,253,41,211,104,108,166,4,100,69,255,130,180,26,114,102,76,190,130,146,53,71,48,247,181,112,190,226,160,153,206,87,117,58,8,12,55,232,151,230,65,248,58,52,198,218,93,250,241,10,242,95,51,190,92,89,211,9,215,65,201,58,242,219,244,116,8,215,197,242,176,93,67,17,141,235,147,187,124,157,182,188,210,8,241,149,149,126,6,79,74,9,194,113,185,85,253,125,64,149,166,104,108,154,188,190,146,246,166,196,104,36,60,157,125,22,169,96,246,177,168,219,215,191,238,30,174,32,53,6,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDuplicatesFolderIdMethod() {
			SchemaMethod method = base.CreateGetDuplicatesFolderIdMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,47,205,76,209,115,205,45,40,169,180,6,0,36,144,179,104,18,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHasUnitChiefMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0c010106-3eb9-411e-a40e-7eefcc2053fa"),
				Name = "HasUnitChief",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aa3fd8a2-18a2-46a3-806f-2fd1a538f7dd"),
				Name = "UnitUId",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,75,79,195,48,16,132,207,201,175,176,114,178,47,86,197,181,2,169,121,84,202,173,234,3,14,136,131,105,182,37,34,89,195,218,46,84,168,255,157,77,82,169,45,208,3,146,47,30,239,124,99,143,119,134,132,131,6,214,62,179,1,189,184,21,8,31,98,9,68,198,217,141,215,153,37,208,121,170,23,253,140,156,153,45,232,149,3,202,44,34,11,181,69,21,71,17,143,53,161,69,249,219,55,13,184,214,61,250,143,195,193,165,39,206,3,213,238,85,42,197,48,61,37,219,202,100,177,119,147,170,173,113,133,181,79,58,249,225,5,8,46,245,229,254,13,238,77,19,32,81,186,116,197,123,48,205,245,148,153,33,211,2,39,201,155,62,102,130,149,76,88,4,244,115,219,64,89,253,15,210,229,175,202,74,41,97,220,213,190,198,113,112,53,110,133,220,113,205,213,115,241,9,235,224,45,113,203,151,29,234,2,93,32,200,211,147,196,101,136,175,56,58,243,19,152,10,58,239,217,127,233,1,9,243,254,76,158,34,6,119,84,111,132,28,124,186,27,57,66,163,136,192,7,194,159,183,200,211,174,81,22,118,64,252,70,222,247,237,46,109,201,223,55,96,30,71,79,74,220,137,209,152,41,135,152,215,33,62,178,54,166,113,48,254,6,161,137,214,239,80,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddAdminUnitMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("caa0c64f-0d93-42f4-a697-4c77ffa1ebaa"),
				Name = "AddAdminUnit",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("603e41d2-d4ad-4e79-a8ec-ac8455ed4441"),
				Name = "SysAdminUnitTypeId",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("193bc7bd-24d1-4001-9ce4-d0cb34994c88"),
				Name = "ParentRoleUId",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,223,111,155,72,16,126,142,255,138,45,15,21,72,129,240,203,16,228,107,36,215,246,229,34,93,211,232,236,92,31,170,62,44,236,96,115,135,193,218,93,39,242,85,249,223,111,118,49,54,142,237,187,54,60,24,152,221,249,230,155,153,111,22,79,42,89,200,205,52,91,192,146,62,222,49,242,129,60,208,57,56,99,42,233,180,94,243,12,156,221,218,160,247,68,57,89,225,114,99,250,68,43,124,230,103,93,156,131,109,15,188,126,42,24,112,231,22,228,214,100,26,15,175,193,12,107,208,43,114,98,78,55,98,200,150,69,245,88,21,114,182,89,129,98,246,129,84,240,76,110,215,5,51,13,150,39,1,203,210,196,142,82,22,219,44,247,60,59,73,125,106,187,174,199,34,23,146,224,58,139,12,203,34,223,123,23,87,87,159,249,156,86,197,63,84,22,117,213,187,152,176,66,170,184,77,182,123,200,107,22,133,144,229,185,29,230,62,179,195,56,241,108,154,184,212,142,34,207,205,131,56,207,60,47,82,244,94,8,148,2,200,143,176,76,163,126,146,123,153,251,67,44,201,24,86,148,203,37,84,242,60,201,196,247,104,150,185,169,157,102,138,36,11,35,251,58,244,125,59,160,65,198,252,44,73,210,56,249,89,146,241,207,144,28,45,10,200,207,243,243,195,24,60,159,166,54,11,226,16,43,153,246,109,26,34,44,154,130,212,5,22,247,93,218,225,215,96,206,128,46,137,25,70,62,36,113,22,255,23,15,235,124,228,126,150,69,105,144,48,155,121,125,31,219,23,93,219,137,135,64,192,66,15,155,135,173,140,3,29,89,171,24,182,40,141,248,16,232,72,214,74,167,119,149,144,180,202,224,227,6,163,153,157,200,22,161,130,236,253,245,100,92,140,33,255,147,150,107,16,154,153,98,229,220,195,179,102,135,113,31,5,240,81,93,85,144,41,25,58,83,16,2,239,106,104,190,118,28,157,89,61,149,188,168,230,166,245,109,155,222,184,208,30,148,111,126,17,122,233,146,212,233,95,8,115,163,96,85,50,172,245,71,143,55,132,193,84,206,199,104,34,8,40,241,5,216,125,205,116,20,61,240,51,14,112,203,49,203,105,119,181,153,223,3,7,103,84,175,43,73,110,136,171,85,180,163,251,21,231,159,163,220,255,168,75,48,190,105,216,246,85,31,55,47,189,206,214,215,50,214,14,199,218,30,116,125,84,49,30,168,16,207,53,103,122,127,181,46,203,55,182,98,7,219,84,164,44,132,132,74,193,207,1,87,77,93,17,245,131,192,146,22,184,226,52,217,56,247,20,9,206,119,230,86,57,59,131,165,221,90,169,169,229,25,112,78,69,157,75,231,11,164,195,213,202,249,72,5,124,170,217,186,132,189,230,182,73,72,94,151,131,171,171,223,187,116,222,2,177,59,219,85,41,197,142,13,102,214,205,244,85,134,191,22,21,107,45,8,98,26,218,217,176,222,154,163,82,211,25,122,234,101,70,197,223,159,87,80,105,38,234,1,120,11,169,71,174,125,209,226,57,114,64,195,104,205,85,75,134,216,247,39,216,118,78,242,53,156,216,189,63,98,58,99,63,32,167,55,98,167,233,18,36,112,53,27,61,162,175,51,163,219,220,111,112,14,72,231,250,78,12,56,252,16,27,151,100,114,104,233,232,145,188,92,190,118,151,219,97,212,158,135,227,57,42,11,4,191,27,159,240,162,12,147,83,12,203,118,55,122,31,169,224,20,212,22,233,69,141,187,217,61,249,222,53,83,70,222,191,39,239,186,211,116,39,38,203,149,220,152,205,151,196,52,207,215,198,50,255,167,200,150,229,12,153,250,19,176,135,71,218,167,71,87,159,248,71,120,95,10,38,23,216,171,195,207,64,99,62,33,134,223,160,152,47,228,241,254,198,62,232,53,245,94,240,250,121,242,132,245,49,141,214,115,152,35,223,221,9,133,164,145,147,210,19,222,240,91,244,47,213,233,217,179,124,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEditAdminUnitMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ff0404f-5dae-4404-9916-17b9c7b225d7"),
				Name = "EditAdminUnit",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3c816bb3-67de-4b8c-9031-08127093fad7"),
				Name = "RecordId",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("255a538a-d336-4833-99a3-3155221b995a"),
				Name = "AdminUnitTypeId",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,77,147,218,56,16,61,195,175,80,56,164,236,170,177,227,47,236,113,205,38,85,100,96,103,57,100,50,181,48,155,195,214,30,100,169,13,218,53,54,37,139,153,98,83,243,223,183,37,27,48,1,146,205,112,192,118,75,239,245,107,245,135,38,165,18,106,59,99,75,88,209,199,41,39,239,201,3,93,128,59,166,138,206,170,141,100,224,238,215,110,250,79,84,146,53,46,55,166,79,180,196,119,121,17,226,30,109,123,144,213,147,224,32,221,59,80,173,201,26,60,124,75,54,176,111,250,34,39,214,136,175,68,249,88,10,53,223,174,65,203,122,79,74,120,38,119,27,193,173,1,207,211,144,179,44,117,226,140,39,14,207,125,223,73,179,128,58,158,231,243,216,131,52,188,102,241,192,182,201,215,126,239,221,187,207,114,65,75,241,47,85,162,42,251,189,9,23,74,59,109,66,61,80,94,243,56,2,150,231,78,148,7,220,137,146,212,119,104,234,81,39,142,125,47,15,147,156,249,126,172,181,189,16,40,106,32,63,148,152,197,195,52,247,153,247,191,36,146,49,172,169,84,43,40,213,101,133,105,224,83,198,188,204,201,152,86,200,163,216,185,142,130,192,9,105,200,120,192,210,52,75,210,159,82,152,252,140,194,219,165,128,252,178,184,32,74,192,15,104,230,240,48,137,240,12,179,161,67,35,164,69,83,152,121,192,147,161,71,59,226,26,206,57,208,21,177,162,56,128,52,97,201,247,116,216,151,61,15,25,139,179,48,229,14,247,135,1,38,46,190,118,82,31,137,128,71,62,166,13,147,152,132,198,179,41,94,104,89,154,154,67,162,147,106,214,229,57,45,107,69,75,6,31,183,232,205,234,120,182,9,173,201,1,111,26,162,55,134,252,15,90,108,160,54,202,180,42,247,30,158,141,58,244,251,88,131,188,173,202,18,152,46,64,119,6,117,141,79,221,43,127,118,128,238,188,154,41,41,202,133,101,255,213,134,55,22,6,65,229,246,151,218,44,93,145,42,251,27,105,62,104,90,29,12,223,225,17,241,10,55,24,202,101,31,141,135,26,10,252,0,126,95,113,227,197,244,249,92,2,220,73,140,114,214,93,125,101,164,251,24,26,135,133,168,21,148,56,44,208,17,174,90,198,161,254,67,98,69,5,174,224,151,196,62,113,239,41,214,246,98,111,222,37,102,111,176,13,108,151,73,189,60,7,41,105,93,229,202,253,2,217,104,189,118,63,210,26,62,85,124,83,192,33,165,109,16,74,86,197,97,220,233,22,170,247,84,40,171,43,243,27,121,191,138,146,239,44,72,98,13,12,120,96,191,86,160,62,233,11,242,244,199,156,214,255,124,94,67,105,148,232,23,144,59,74,83,142,187,15,51,190,79,0,104,184,221,72,125,158,35,76,218,19,180,199,174,228,6,206,236,62,180,95,167,37,110,200,249,141,152,38,186,2,5,82,215,77,159,152,223,133,178,110,158,31,244,84,232,245,190,146,129,4,86,73,62,229,131,43,242,123,251,218,169,26,242,114,213,210,53,63,4,192,241,29,134,184,201,177,229,251,112,213,22,180,65,30,151,248,109,33,144,124,58,62,131,162,28,15,65,71,82,236,118,35,250,164,90,206,81,181,76,47,250,166,179,186,211,227,13,118,254,166,40,200,219,183,228,77,183,101,166,245,100,181,86,91,171,153,198,150,117,249,12,109,235,7,201,176,109,119,196,245,21,122,160,71,217,231,251,211,76,205,19,190,47,130,171,37,230,244,120,148,54,230,51,69,243,27,136,197,82,157,238,111,236,55,253,230,188,151,178,122,158,60,225,249,88,131,29,114,148,163,222,253,13,134,162,81,147,174,59,124,224,60,255,15,0,36,141,196,183,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteAdminUnitMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a3ccf6ec-d913-4b49-8886-c63901694090"),
				Name = "DeleteAdminUnit",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,78,227,48,16,61,7,137,127,24,114,74,164,202,226,142,122,232,150,130,144,0,85,165,93,14,171,61,204,218,83,176,228,216,150,237,116,137,16,255,190,182,107,80,10,229,178,7,39,153,153,55,111,222,204,56,59,116,96,157,236,208,13,43,226,198,137,159,168,122,130,41,44,241,137,216,37,6,124,48,189,227,196,102,60,200,29,173,204,95,182,220,195,231,70,245,157,206,240,139,211,19,185,133,230,8,207,217,20,174,123,41,216,162,179,97,104,225,245,244,164,10,110,128,87,136,31,213,231,18,43,234,204,142,142,208,180,177,64,245,22,15,199,192,159,161,89,188,112,178,65,26,13,244,178,39,173,238,200,251,72,183,68,77,10,186,177,49,133,185,209,193,25,181,9,82,201,32,201,179,43,169,69,113,54,89,196,204,219,252,46,78,255,235,252,247,4,234,31,232,105,204,91,79,32,184,168,6,208,195,216,159,212,85,105,0,7,117,99,235,186,87,170,232,171,198,49,54,19,162,16,52,245,35,58,45,245,83,177,111,68,172,82,92,19,184,36,75,90,144,230,195,33,106,242,94,127,61,88,98,37,150,167,148,199,148,206,46,46,86,73,31,72,147,75,189,197,57,236,123,77,143,212,39,202,24,137,150,35,29,216,61,118,145,225,195,157,58,60,192,181,57,237,70,251,128,154,83,10,175,201,57,244,102,27,216,35,253,153,89,203,242,180,140,232,21,37,232,3,127,166,14,55,158,92,153,233,69,209,100,99,112,163,101,240,31,100,81,216,88,232,39,129,105,87,239,158,180,175,58,39,215,237,255,74,188,118,82,124,43,240,139,56,182,118,148,83,216,92,17,186,166,61,142,26,93,226,91,131,34,254,37,62,67,223,254,1,86,168,169,226,95,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOpenLDAPUsersListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("34aea5b7-138f-45aa-a744-78fc54c72d5b"),
				Name = "OpenLDAPUsersList",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9bd09632-a36d-42e2-a2b1-b969bbf71610"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,93,107,194,48,20,134,175,39,248,31,66,175,42,104,80,116,234,216,28,248,77,193,77,65,221,125,214,28,53,204,38,229,36,85,138,248,223,151,180,184,89,152,94,236,42,31,231,125,159,55,57,201,60,6,57,27,245,23,107,13,168,103,66,27,55,89,49,253,69,231,182,2,24,72,109,152,12,33,224,164,71,46,139,117,192,159,203,165,249,77,235,130,109,157,166,71,36,28,201,52,17,220,247,78,159,93,214,106,126,242,78,237,145,119,187,181,86,189,251,84,99,157,112,83,107,63,214,219,173,14,107,54,59,141,198,217,171,88,238,129,33,209,225,14,34,102,35,29,115,168,164,132,208,8,37,233,88,26,97,210,101,86,125,99,210,230,32,157,8,201,47,39,27,164,239,44,2,223,91,166,186,207,35,33,215,82,152,95,232,213,166,69,231,25,116,136,192,12,228,96,191,24,231,140,98,67,252,107,35,157,128,9,119,19,84,209,104,224,35,132,10,121,192,43,21,114,42,151,30,92,72,76,242,107,143,68,134,96,152,190,104,131,66,110,171,36,31,95,125,135,125,136,105,159,219,190,184,6,218,108,76,3,238,85,11,39,164,83,48,171,52,6,62,84,251,36,146,31,108,159,192,203,5,81,240,85,254,4,254,15,119,3,54,122,255,31,206,250,10,192,41,170,36,206,174,122,105,29,93,169,101,102,243,115,225,253,95,181,96,104,223,215,216,146,109,115,124,95,63,220,43,13,111,160,181,245,89,181,247,163,154,162,224,89,145,123,142,224,184,116,181,67,117,28,31,64,26,223,43,32,157,56,251,65,231,114,9,193,36,40,159,191,1,124,150,8,237,52,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateImportLDAPUsersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5f9b2d04-317c-48c9-bab6-6328d3f14eaa"),
				Name = "ImportLDAPUsers",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("816374b2-85df-4000-ab16-d605c047d511"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				ModifiedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,2,0,147,6,215,50,1,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareMenuItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("66dba8f1-1f70-49d6-9ffa-121b68ad0390"),
				Name = "PrepareMenuItems",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,93,111,18,65,20,125,102,127,197,116,159,150,68,182,80,21,36,72,147,133,133,218,164,70,82,90,125,48,198,76,217,219,50,102,153,197,217,217,182,216,144,24,77,124,50,241,221,7,245,39,16,109,99,227,215,111,88,254,145,51,11,235,46,178,180,208,162,15,164,208,59,115,207,185,231,222,123,230,16,51,132,91,156,28,194,182,115,132,202,168,129,15,64,55,49,199,77,199,99,45,208,141,48,86,82,54,60,98,33,183,231,26,86,135,208,93,74,248,78,175,11,155,150,184,36,35,122,173,211,229,189,146,178,231,56,54,106,99,87,30,168,182,9,236,139,248,62,182,93,24,39,232,98,6,148,79,93,35,251,72,139,120,172,148,17,245,108,59,141,78,148,84,34,226,159,163,250,6,4,255,181,170,142,237,117,232,67,108,123,112,87,38,94,215,212,230,212,77,53,93,82,82,127,145,187,23,251,25,81,208,27,140,116,48,235,197,210,202,187,49,246,115,81,104,4,231,183,29,59,4,63,20,122,219,196,229,247,129,122,155,28,58,161,228,59,12,96,131,9,61,100,64,175,19,106,105,36,8,175,35,249,87,55,56,103,100,207,227,224,62,86,3,4,145,239,9,42,151,145,26,102,122,250,160,11,116,203,52,26,187,46,48,119,75,96,4,128,82,216,9,192,184,182,169,120,68,175,81,188,103,195,229,181,201,22,7,242,210,86,155,57,148,188,128,71,132,183,37,116,128,216,87,250,163,41,232,198,138,15,218,44,50,71,2,78,246,95,234,194,199,26,72,66,137,186,140,142,57,236,0,11,80,204,137,67,99,50,198,111,47,34,32,133,163,128,137,166,154,245,226,77,179,90,41,102,242,21,179,144,49,235,185,92,166,88,89,51,50,217,108,206,204,103,107,197,155,119,170,121,53,173,239,56,77,145,138,30,104,233,244,136,144,39,198,103,169,68,42,249,219,197,122,174,154,93,148,72,75,206,240,114,153,20,174,198,132,3,238,44,149,200,173,252,90,173,88,168,22,22,37,130,165,1,132,76,76,176,129,195,53,248,168,198,116,58,57,243,9,40,177,109,226,204,131,145,195,37,121,217,226,19,40,86,23,173,174,34,255,195,240,165,255,197,31,248,63,253,115,255,171,63,24,190,241,207,135,239,148,84,210,126,76,177,73,197,135,118,58,58,49,73,177,240,74,220,60,197,185,120,159,167,179,92,44,203,202,148,63,148,148,62,2,241,84,160,121,180,154,111,73,66,173,62,250,191,252,83,161,215,64,40,117,234,159,249,223,197,71,234,118,118,169,94,227,199,235,127,8,182,72,245,115,45,102,88,253,167,225,107,255,155,80,224,179,84,65,76,201,43,169,192,240,237,117,107,15,195,179,138,15,227,51,138,30,135,23,168,122,62,23,8,171,126,47,170,253,17,236,199,169,63,248,215,181,206,217,232,176,230,192,14,106,199,92,223,116,141,103,248,120,27,158,123,224,242,224,81,14,222,61,195,178,154,45,70,186,92,115,3,67,211,235,14,235,96,174,169,232,36,219,215,93,224,227,148,218,73,174,159,46,33,245,70,226,179,168,87,109,34,159,91,115,70,120,156,36,102,155,226,235,150,115,4,76,24,168,72,123,101,50,19,34,70,36,146,180,93,62,248,100,139,34,244,196,214,45,31,126,162,243,17,122,210,64,44,31,60,201,114,35,14,23,24,242,108,42,125,133,1,247,24,29,153,212,111,146,118,158,155,49,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCurrentFolderConnectionTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("01667bc3-484f-48d1-8f2a-92208c861efd"),
				Name = "SetCurrentFolderConnectionType",
				CreatedInSchemaUId = new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"),
				CreatedInPackageId = new Guid("26f23beb-788c-46f9-ab3b-d312b7ceaa54"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,76,46,201,44,75,13,202,47,87,176,85,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,132,201,89,243,114,101,166,41,104,32,212,42,218,42,228,149,230,228,104,42,84,243,114,113,134,22,167,22,57,231,231,229,165,2,165,243,243,244,130,83,139,139,129,52,200,156,104,37,231,210,162,162,212,188,18,183,252,156,20,100,69,33,149,5,169,74,177,64,43,225,70,234,185,167,150,128,68,83,156,243,115,74,115,243,194,18,115,74,83,109,50,243,74,236,52,148,208,180,105,2,93,83,11,0,50,156,220,222,187,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrationOrganizationalStructureGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5119ef2d-0c14-49fd-af8b-4c6627104841"));
		}

		#endregion

	}

	#endregion

}

