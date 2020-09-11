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

	#region Class: AdministrationUsersGridPageSchema

	/// <exclude/>
	public class AdministrationUsersGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ImageList _userLoggedImageList;
		public Terrasoft.UI.WebControls.Controls.ImageList UserLoggedImageList {
			get {
				return _userLoggedImageList;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrationUsersGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrationUsersGridPageSchema(AdministrationUsersGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
			RealUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
			Name = "AdministrationUsersGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "267";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrationUsersGridPageEventsProcessSchema();
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
			Controls.AddAt(2, CreateUserLoggedImageList());
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrationUsersGridPageEventsProcessSchema() {
			var schema = new AdministrationUsersGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageList CreateUserLoggedImageList() {
			_userLoggedImageList = new Terrasoft.UI.WebControls.Controls.ImageList();
			_userLoggedImageList.UId = new Guid("c81ba8d2-f986-43a2-b821-18576a275d9b");
			_userLoggedImageList.Name = "UserLoggedImageList";
			_userLoggedImageList.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
			_userLoggedImageList.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
			_userLoggedImageList.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_userLoggedImageList.Tag = "";
			_userLoggedImageList.InsertItem(0, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("994e2516-4d54-4cd9-aa7a-0d04359d7b96"),
					ID = @"c994e25164d544cd9aa7a0d04359d7b96",
					Name = "UserActiveImageListItem",
					CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0"),
					ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0")
				});
			_userLoggedImageList.InsertItem(1, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("ebfc8003-5412-4aee-99ed-7b93d1113691"),
					ID = @"cebfc800354124aee99ed7b93d1113691",
					Name = "UserInactiveImageListItem",
					CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0"),
					ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0")
				});
			return _userLoggedImageList;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			DataSource.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ac51fbbd-de3f-491c-b5f8-a949c6e66bf2");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("328f73e7-ebde-432f-9052-a0365b3105e8");
			if (column != null) {
				column.UId = new Guid("1d05e5c3-8151-4b62-9191-e9297093726a");
				column.Name = @"Contact";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1");
			if (column != null) {
				column.UId = new Guid("3c45df9c-104f-492d-b928-df75d4741fa0");
				column.Name = @"SysAdminUnitType";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a986b074-459c-40b1-b4b6-0e286b3ef123");
			if (column != null) {
				column.UId = new Guid("f9032003-2ed5-40f3-9d17-da56d5b80040");
				column.Name = @"Active";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Width = 50;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("328f73e7-ebde-432f-9052-a0365b3105e8.344436e4-9d6b-4a30-936f-f8ea45f2adb4.736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("226bae8f-de80-4343-a230-a2e26e97c2dc");
				column.Name = @"Contact_Job_Name";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			column.Caption.SetResourceInfo("03512113977d446fb73e579eef4a0eb0", "Controls.DataSource.DefStructure.Columns.Contact_Job_Name.Caption");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("328f73e7-ebde-432f-9052-a0365b3105e8.84c5808a-7859-4198-ba6a-243c95a3300b");
			if (column != null) {
				column.UId = new Guid("7f7a180c-3ddb-481c-9a3e-314a5c8ab7b1");
				column.Name = @"Contact_Phone";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			column.Caption.SetResourceInfo("03512113977d446fb73e579eef4a0eb0", "Controls.DataSource.DefStructure.Columns.Contact_Phone.Caption");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("937f2044-f446-4975-9caf-de9e7c972fb9");
			if (column != null) {
				column.UId = new Guid("47826450-7214-45cb-86cb-7bd805023148");
				column.Name = @"LoggedIn";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Width = 50;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("80f4c454-e035-4b56-8542-930ff972cbe8");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			column.Caption.SetResourceInfo("03512113977d446fb73e579eef4a0eb0", "Controls.DataSource.DefStructure.Columns.Name.Caption");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4acc2d13-7573-41ec-9a30-e20696bf0314");
			if (column != null) {
				column.UId = new Guid("b56df088-e124-4f78-8e34-69cfa9b3c4f1");
				column.Name = @"ConnectionType";
				column.CreatedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
				column.ModifiedInSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
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
			return new AdministrationUsersGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrationUsersGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03512113-977d-446f-b73e-579eef4a0eb0"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrationUsersGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationUsersGridPageEventsProcess

	/// <exclude/>
	public class AdministrationUsersGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrationUsersGridPageSchemaUserControl
	{

		public AdministrationUsersGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrationUsersGridPageEventsProcess";
			SchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
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

		public virtual Guid CreatedUserContextUId {
			get;
			set;
		}

		public virtual Guid HierarchyColumnUId {
			get;
			set;
		}

		public virtual string LDAPMessageText {
			get;
			set;
		}

		public virtual int LDAPMessageType {
			get;
			set;
		}

		public virtual bool LDAPAddLink {
			get;
			set;
		}

		private Guid _showLDAPMessageId = new Guid("{83A1E9EA-651D-4600-B027-886C6EFA6524}");
		public Guid ShowLDAPMessageId {
			get {
				return _showLDAPMessageId;
			}
			set {
				_showLDAPMessageId = value;
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
					SchemaElementUId = new Guid("b2667992-73d7-4448-aed5-7b94218b6a2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadChild;
		public ProcessFlowElement PageLoadChild {
			get {
				return _pageLoadChild ?? (_pageLoadChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadChild",
					SchemaElementUId = new Guid("e7c1106b-93ec-418c-972f-b45a6c757a00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadChild;
		public ProcessScriptTask ScriptPageLoadChild {
			get {
				return _scriptPageLoadChild ?? (_scriptPageLoadChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadChild",
					SchemaElementUId = new Guid("511717fb-14fd-4ca8-b8f8-eff912dd7761"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadParent;
		public ProcessThrowMessageEvent ThrowPageLoadParent {
			get {
				return _throwPageLoadParent ?? (_throwPageLoadParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadParent",
					SchemaElementUId = new Guid("6e73ce58-7331-4aa1-8078-ce1afb1a8842"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("d0b0132a-40a9-44af-a761-43bba47b0503"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadingChild;
		public ProcessFlowElement DataSourceLoadingChild {
			get {
				return _dataSourceLoadingChild ?? (_dataSourceLoadingChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadingChild",
					SchemaElementUId = new Guid("70783f2e-8877-4415-b35b-84843efb3095"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceLoadingChild;
		public ProcessScriptTask ScriptDataSourceLoadingChild {
			get {
				return _scriptDataSourceLoadingChild ?? (_scriptDataSourceLoadingChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceLoadingChild",
					SchemaElementUId = new Guid("69a462f2-3d5d-4b98-85db-c462a5a5ed14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceLoadingChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwDataSourceLoadingParent;
		public ProcessThrowMessageEvent ThrowDataSourceLoadingParent {
			get {
				return _throwDataSourceLoadingParent ?? (_throwDataSourceLoadingParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowDataSourceLoadingParent",
					SchemaElementUId = new Guid("8e339030-ee0d-4896-ae02-7f784d94762d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceLoading",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess_UserEditPageClosed;
		public ProcessFlowElement SubProcess_UserEditPageClosed {
			get {
				return _subProcess_UserEditPageClosed ?? (_subProcess_UserEditPageClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess_UserEditPageClosed",
					SchemaElementUId = new Guid("8335d78f-1eba-4207-a2e2-8316ca2f10f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _userEditPageClosedMessage;
		public ProcessFlowElement UserEditPageClosedMessage {
			get {
				return _userEditPageClosedMessage ?? (_userEditPageClosedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UserEditPageClosedMessage",
					SchemaElementUId = new Guid("42e13b65-763d-429f-8a01-3d4325dbef40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptUserEditPageClosed;
		public ProcessScriptTask ScriptUserEditPageClosed {
			get {
				return _scriptUserEditPageClosed ?? (_scriptUserEditPageClosed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUserEditPageClosed",
					SchemaElementUId = new Guid("7a59638c-5f0d-4466-9a0d-6eee622ba269"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUserEditPageClosedExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessApplyFolderFilter;
		public ProcessFlowElement SubProcessApplyFolderFilter {
			get {
				return _subProcessApplyFolderFilter ?? (_subProcessApplyFolderFilter = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessApplyFolderFilter",
					SchemaElementUId = new Guid("7bc0f5ed-77ca-4887-a7a3-eda773587552"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _applyFolderFilterChild;
		public ProcessFlowElement ApplyFolderFilterChild {
			get {
				return _applyFolderFilterChild ?? (_applyFolderFilterChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ApplyFolderFilterChild",
					SchemaElementUId = new Guid("af461be1-6a28-4efe-9e61-9839d9e8713f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptApplyFolderFilterChild;
		public ProcessScriptTask ScriptApplyFolderFilterChild {
			get {
				return _scriptApplyFolderFilterChild ?? (_scriptApplyFolderFilterChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptApplyFolderFilterChild",
					SchemaElementUId = new Guid("b1713162-a60b-4f77-93a3-c229ded83b6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptApplyFolderFilterChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess9;
		public ProcessFlowElement SubProcess9 {
			get {
				return _subProcess9 ?? (_subProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9",
					SchemaElementUId = new Guid("e2a9578c-2453-4dea-ba48-c5ff71f56274"),
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
					SchemaElementUId = new Guid("2ce6e91e-d53f-4b23-9641-fb4f06385f3d"),
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
					SchemaElementUId = new Guid("3360bb02-99bb-4963-a06a-5e406635a46c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadCompleteParent;
		public ProcessThrowMessageEvent ThrowPageLoadCompleteParent {
			get {
				return _throwPageLoadCompleteParent ?? (_throwPageLoadCompleteParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadCompleteParent",
					SchemaElementUId = new Guid("f2f732d4-23d8-4e8a-ac48-c7d9b3840fe0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
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
					SchemaElementUId = new Guid("58fc9a17-fe5a-4c97-9c74-5ece8b81b24f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _showLDAPCustomMessage;
		public ProcessFlowElement ShowLDAPCustomMessage {
			get {
				return _showLDAPCustomMessage ?? (_showLDAPCustomMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShowLDAPCustomMessage",
					SchemaElementUId = new Guid("8712facb-b50d-47a9-b3d6-31830a42bd3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptShowLDAPCustomMessage;
		public ProcessScriptTask ScriptShowLDAPCustomMessage {
			get {
				return _scriptShowLDAPCustomMessage ?? (_scriptShowLDAPCustomMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptShowLDAPCustomMessage",
					SchemaElementUId = new Guid("b0d991a8-dc35-40c9-9a4f-5f14393a0a8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptShowLDAPCustomMessageExecute,
				});
			}
		}

		private LocalizableString _openLDAPUsersListLS;
		public LocalizableString OpenLDAPUsersListLS {
			get {
				return _openLDAPUsersListLS ?? (_openLDAPUsersListLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenLDAPUsersListLS.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[PageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadChild };
			FlowElements[ScriptPageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadChild };
			FlowElements[ThrowPageLoadParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadParent };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DataSourceLoadingChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadingChild };
			FlowElements[ScriptDataSourceLoadingChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceLoadingChild };
			FlowElements[ThrowDataSourceLoadingParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowDataSourceLoadingParent };
			FlowElements[SubProcess_UserEditPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess_UserEditPageClosed };
			FlowElements[UserEditPageClosedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserEditPageClosedMessage };
			FlowElements[ScriptUserEditPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUserEditPageClosed };
			FlowElements[SubProcessApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessApplyFolderFilter };
			FlowElements[ApplyFolderFilterChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyFolderFilterChild };
			FlowElements[ScriptApplyFolderFilterChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptApplyFolderFilterChild };
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[ThrowPageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadCompleteParent };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ShowLDAPCustomMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowLDAPCustomMessage };
			FlowElements[ScriptShowLDAPCustomMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptShowLDAPCustomMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess10":
						break;
					case "PageLoadChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadParent");
						break;
					case "ScriptPageLoadChild":
						break;
					case "ThrowPageLoadParent":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadChild");
						break;
					case "EventSubProcess11":
						break;
					case "DataSourceLoadingChild":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceLoadingChild");
						break;
					case "ScriptDataSourceLoadingChild":
						e.Context.QueueTasks.Enqueue("ThrowDataSourceLoadingParent");
						break;
					case "ThrowDataSourceLoadingParent":
						break;
					case "SubProcess_UserEditPageClosed":
						break;
					case "UserEditPageClosedMessage":
						e.Context.QueueTasks.Enqueue("ScriptUserEditPageClosed");
						break;
					case "ScriptUserEditPageClosed":
						break;
					case "SubProcessApplyFolderFilter":
						break;
					case "ApplyFolderFilterChild":
						e.Context.QueueTasks.Enqueue("ScriptApplyFolderFilterChild");
						break;
					case "ScriptApplyFolderFilterChild":
						break;
					case "SubProcess9":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadCompleteParent");
						break;
					case "ThrowPageLoadCompleteParent":
						break;
					case "EventSubProcess1":
						break;
					case "ShowLDAPCustomMessage":
						e.Context.QueueTasks.Enqueue("ScriptShowLDAPCustomMessage");
						break;
					case "ScriptShowLDAPCustomMessage":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadChild");
			ActivatedEventElements.Add("DataSourceLoadingChild");
			ActivatedEventElements.Add("UserEditPageClosedMessage");
			ActivatedEventElements.Add("ApplyFolderFilterChild");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("ShowLDAPCustomMessage");
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
				case "PageLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadChild";
					result = PageLoadChild.Execute(context);
					break;
				case "ScriptPageLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadChild";
					result = ScriptPageLoadChild.Execute(context, ScriptPageLoadChildExecute);
					break;
				case "ThrowPageLoadParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = ThrowPageLoadParent.Execute(context);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadingChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadingChild";
					result = DataSourceLoadingChild.Execute(context);
					break;
				case "ScriptDataSourceLoadingChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceLoadingChild";
					result = ScriptDataSourceLoadingChild.Execute(context, ScriptDataSourceLoadingChildExecute);
					break;
				case "ThrowDataSourceLoadingParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceLoading");
					result = ThrowDataSourceLoadingParent.Execute(context);
					break;
				case "SubProcess_UserEditPageClosed":
					context.QueueTasks.Dequeue();
					break;
				case "UserEditPageClosedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserEditPageClosedMessage";
					result = UserEditPageClosedMessage.Execute(context);
					break;
				case "ScriptUserEditPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUserEditPageClosed";
					result = ScriptUserEditPageClosed.Execute(context, ScriptUserEditPageClosedExecute);
					break;
				case "SubProcessApplyFolderFilter":
					context.QueueTasks.Dequeue();
					break;
				case "ApplyFolderFilterChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyFolderFilterChild";
					result = ApplyFolderFilterChild.Execute(context);
					break;
				case "ScriptApplyFolderFilterChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptApplyFolderFilterChild";
					result = ScriptApplyFolderFilterChild.Execute(context, ScriptApplyFolderFilterChildExecute);
					break;
				case "SubProcess9":
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
				case "ThrowPageLoadCompleteParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ThrowPageLoadCompleteParent.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ShowLDAPCustomMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowLDAPCustomMessage";
					result = ShowLDAPCustomMessage.Execute(context);
					break;
				case "ScriptShowLDAPCustomMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptShowLDAPCustomMessage";
					result = ScriptShowLDAPCustomMessage.Execute(context, ScriptShowLDAPCustomMessageExecute);
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
				case "ShowLDAPMessageId":
					ShowLDAPMessageId = reader.GetValue<System.Guid>();
				break;
				case "LDAPAddLink":
					LDAPAddLink = reader.GetValue<System.Boolean>();
				break;
				case "LDAPMessageType":
					LDAPMessageType = reader.GetValue<System.Int32>();
				break;
				case "LDAPMessageText":
					LDAPMessageText = reader.GetValue<System.String>();
				break;
				case "HierarchyColumnUId":
					HierarchyColumnUId = reader.GetValue<System.Guid>();
				break;
				case "CreatedUserContextUId":
					CreatedUserContextUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptPageLoadChildExecute(ProcessExecutingContext context) {
			Page.TreeGrid.GetRowConfigHandler = delegate(Terrasoft.Core.Entities.Entity row) {
			   string primaryColumnName = row.Schema.PrimaryColumn.Name;
			   string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			   var config = new DataSourceRowConfig(primaryColumnValue);
			   config.AddConfig(new DataSourceRowIsExpandableConfigValue(false));
				bool logged = row.GetTypedColumnValue<bool>("LoggedIn");
				ImageListItem icon = logged ? Page.UserLoggedImageList.Items[0] : Page.UserLoggedImageList.Items[1];
				var icons = new Dictionary<string, ImageConfigValue>();
				var controlImage = new ControlImage();
				controlImage.Source = ControlImageSource.ImageList;
				controlImage.ImageListUId = Page.UserLoggedImageList.UId;
				controlImage.ImageUId = icon.UId;
				controlImage.SchemaUId = Page.Schema.UId;
				icons.Add("icon", new ImageConfigValue(controlImage));
				config.AddConfig(new DataSourceRowFirstColumnIconsConfigValue(icons));
				return config;
			};
			return true;
		}

		public virtual bool ScriptDataSourceLoadingChildExecute(ProcessExecutingContext context) {
			//Page.TreeGrid.Clear();
			//Page.DataSource.Schema.HierarchyColumn = (EntitySchemaColumn)hierarchyColumn;
			return true;
		}

		public virtual bool ScriptUserEditPageClosedExecute(ProcessExecutingContext context) {
			var isNew = (bool)(context.ThrowEventArgs as List<object>)[1];
			if (!isNew) {
				return true;
			}
			Dictionary<string, object> conditions = new Dictionary<string, object>();
			var userId = (context.ThrowEventArgs as List<object>)[0].ToString();
			var allEmployeeRoleId = new Guid("A29A3BA5-4B0D-DE11-9A51-005056C00008");
			var selectedRoleId = Guid.Empty;
			var contactId = Guid.Empty;
			if (!string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
				selectedRoleId = new Guid(process.GetPropertyValue("ParentRoleId").ToString());
			}
			
			var entity = UserConnection.EntitySchemaManager.GetInstanceByName("SysAdminUnit").CreateEntity(UserConnection);
			if (entity.FetchFromDB(new Guid(userId))) {
				contactId = entity.GetTypedColumnValue<Guid>("ContactId");
				var dbSecurityEngine = UserConnection.DBSecurityEngine;
				dbSecurityEngine.SetEntitySchemaRecordOperationRightLevel(new Guid(userId), "Contact", contactId, EntitySchemaRecordRightOperation.Read,
				EntitySchemaRecordRightLevel.Allow);
			}
			
			if (selectedRoleId.Equals(Guid.Empty) || selectedRoleId.Equals(allEmployeeRoleId)) {
				return true;
			}
			conditions["SysUser"] = contactId;
			conditions["SysRole"] = selectedRoleId;
			var sysUserInRoleSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysUserInRole");
			var sysUserInRole = sysUserInRoleSchema.CreateEntity(Page.UserConnection);
			if (sysUserInRole.FetchFromDB(conditions)) {
				return true;
			}
			sysUserInRole.SetColumnValue("Id", Guid.NewGuid());
			sysUserInRole.SetColumnValue("CreatedOn", DateTime.Now);
			sysUserInRole.SetColumnValue("CreatedById", UserConnection.CurrentUser.Id);
			sysUserInRole.SetColumnValue("ModifiedOn", DateTime.Now);
			sysUserInRole.SetColumnValue("ModifiedById", UserConnection.CurrentUser.Id);
			sysUserInRole.SetColumnValue("SysUserId", userId);
			sysUserInRole.SetColumnValue("SysRoleId", selectedRoleId);
			sysUserInRole.Save();
			return true;
		}

		public virtual bool ScriptApplyFolderFilterChildExecute(ProcessExecutingContext context) {
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;//ListenerPage as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			var dataSourceFilter = (Terrasoft.UI.WebControls.Controls.IDataSourceFilterItem) DataSourceFilter;
			if(!object.ReferenceEquals(DataSourceFilter, null)) {
				for(int i = 0; i < currentStructure.Filters.Count; i++) {
					if(currentStructure.Filters[i].Name.Equals(dataSourceFilter.Name)) {
						currentStructure.Filters[i] = dataSourceFilter;
					}
				}
				if(!currentStructure.Filters.Contains(dataSourceFilter)) {
					currentStructure.Filters.Add(dataSourceFilter);
				}
				foreach (var filter in currentStructure.Filters) {
					if(!filter.Name.Equals("SearchFilter")) {	
						filter.IsEnabled = !IsSearch;
					}
				}
			} else {
				if(currentStructure.Filters.Count > 0) {
					var filters = new List<IDataSourceFilterItem>();
					foreach (var filter in currentStructure.Filters) {
						if(!filter.Name.Equals("SearchFilter")) {					
							filter.IsEnabled = !IsSearch;
						}
						if(filter.Name.Equals("FolderFilter")) {					
							filters.Add(filter);
						}			
					}
					foreach (var filter in filters) {
						currentStructure.Filters.Remove(filter);
					}
				}
			}
			currentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnitType.Value", (int)Terrasoft.Core.DB.SysAdminUnitType.User));
			
			Page.TreeGrid.Clear();
			//var hierarchyColumn = dataSource.Schema.HierarchyColumn.Clone();
			try {
				//dataSource.Schema.HierarchyColumn = null;
				dataSource.LoadRows();
			} finally {
				//dataSource.Schema.HierarchyColumn = hierarchyColumn as EntitySchemaColumn;
			}
			
			var detailsTabPanel = listenerPage.DetailsTabPanel;
			
			if(detailsTabPanel.Tabs.Count == 0) {
				return true;
			}
			
			var activeTab = detailsTabPanel.Tabs[detailsTabPanel.ActiveTabIndex];
			if (activeTab.Items.Count == 0) {
				return true;
			}
			var detailPageContainer = activeTab.Items[0] as PageControl;
			var detailDataSource = (detailPageContainer.FindPageControlByName("DataSource")) as DataSource;
			Guid filterColumnValue = Guid.Empty;
			if(dataSource.Rows.Count != 0) {
				filterColumnValue = dataSource.Rows[0].PrimaryColumnValue;
			}
			ListenerProcessSetProperty(ListenerPageProcessUId, "FilterColumnValue", filterColumnValue);
			ListenerThrowEvent(ListenerPageProcessUId, "RefreshDetails");
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			EditPageUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			CreatedUserContextUId = Guid.NewGuid();
			Page.DataSource.CurrentStructure.IsHierarchical = false;
			return true;
		}

		public virtual bool ScriptShowLDAPCustomMessageExecute(ProcessExecutingContext context) {
			MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				if (LDAPAddLink) {
					/*var newLink = new LinkConfig();
					newLink.Caption = OpenLDAPUsersListLS;
					newLink.Url = "";
					newLink.LinkId = ShowLDAPMessageId.ToString();
					messagePanel.Links.Add(newLink);*/
					var workspProcess = UserConnection.IProcessEngine.FindProcessByUId(ListenerPageProcessUId);
					var mainprocessuid = workspProcess.GetPropertyValue("MainPageProcessUId");
					if (mainprocessuid != null) {
						var p = UserConnection.IProcessEngine.FindProcessByUId(mainprocessuid.ToString());
						p.ThrowEvent(p.InternalContext, "DoShowLDAPMessage");
					}
				} else {
					messagePanel.Remove("LDAPMessage");
					messagePanel.AddMessage("LDAPMessage", String.Empty, LDAPMessageText, (MessageType)LDAPMessageType);
				}
			}
			return true;
		}

		public override Dictionary<string, string> GetEditPages() {
			return new Dictionary <string, string>();
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			var listenerPage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var pageInstance = listenerPage.BaseFolder.PageInstance as Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl;
			queryStringParameters["additionalTreeGrid"] = Json.Serialize(pageInstance.TreeGrid.ClientID);
			queryStringParameters["createdUserContextUId"] = Json.Serialize(CreatedUserContextUId);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadChild")) {
							context.QueueTasks.Enqueue("PageLoadChild");
						}
						break;
					case "DataSourceLoading":
							if (ActivatedEventElements.Contains("DataSourceLoadingChild")) {
							context.QueueTasks.Enqueue("DataSourceLoadingChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "UserEditPageClosed":
							if (ActivatedEventElements.Contains("UserEditPageClosedMessage")) {
							context.QueueTasks.Enqueue("UserEditPageClosedMessage");
						}
						break;
					case "ApplyFolderFilter":
							if (ActivatedEventElements.Contains("ApplyFolderFilterChild")) {
							context.QueueTasks.Enqueue("ApplyFolderFilterChild");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "ShowLDAPCustomMessage":
							if (ActivatedEventElements.Contains("ShowLDAPCustomMessage")) {
							context.QueueTasks.Enqueue("ShowLDAPCustomMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ShowLDAPMessageId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ShowLDAPMessageId", ShowLDAPMessageId, Guid.Empty);
			}
			if (!HasMapping("LDAPAddLink") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LDAPAddLink", LDAPAddLink, false);
			}
			if (!HasMapping("LDAPMessageType") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LDAPMessageType", LDAPMessageType, 0);
			}
			if (!HasMapping("LDAPMessageText") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LDAPMessageText", LDAPMessageText, null);
			}
			if (!HasMapping("HierarchyColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HierarchyColumnUId", HierarchyColumnUId, Guid.Empty);
			}
			if (!HasMapping("CreatedUserContextUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CreatedUserContextUId", CreatedUserContextUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationUsersGridPageEventsProcess

	/// <exclude/>
	public class AdministrationUsersGridPageEventsProcess : AdministrationUsersGridPageEventsProcess<Terrasoft.WebApp.AdministrationUsersGridPageSchemaUserControl>
	{

		public AdministrationUsersGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrationUsersGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrationUsersGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ImageList UserLoggedImageList {
			get {
				return (Terrasoft.UI.WebControls.Controls.ImageList)PageContainer.FindPageControl("UserLoggedImageList", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DataSource.BeforeLoad += DataSourceBeforeLoad;
			DataSource.Loaded += DataSourceLoaded;
			DataSource.AjaxEvents.StructureUpdated.Event += DataSourceStructureUpdated;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DataSource.BeforeLoad -= DataSourceBeforeLoad;
			DataSource.Loaded -= DataSourceLoaded;
			DataSource.AjaxEvents.StructureUpdated.Event -= DataSourceStructureUpdated;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrationUsersGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrationUsersGridPageEventsProcess(UserConnection);
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

		public virtual void DataSourceBeforeLoad(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeLoad");
		}

		public virtual void DataSourceLoaded(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceLoaded");
		}

		public virtual void DataSourceStructureUpdated(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceStructureUpdated");
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
			SchemaName = "AdministrationUsersGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationUsersGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrationUsersGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrationUsersGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrationUsersGridPageEventsProcessSchema(AdministrationUsersGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrationUsersGridPageEventsProcess";
			UId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a");
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

		protected virtual ProcessSchemaParameter CreateCreatedUserContextUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6636d2ec-5cf1-4e7c-be21-c8d1e8caa9f6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"CreatedUserContextUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHierarchyColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dc97abe7-0497-4303-8b87-5cd634d9efcd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"HierarchyColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLDAPMessageTextParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c3210c6a-7ec3-4d3c-97af-e233f6962a73"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"LDAPMessageText",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLDAPMessageTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6ddf597c-bfec-4d74-9541-892ea19c6bee"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"LDAPMessageType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLDAPAddLinkParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f51bc804-6966-4920-8d01-475681200ef0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"LDAPAddLink",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateShowLDAPMessageIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3f17a66c-8dd1-4b38-a728-2e645bd629e5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ShowLDAPMessageId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{83A1E9EA-651D-4600-B027-886C6EFA6524}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCreatedUserContextUIdParameter());
			Parameters.Add(CreateHierarchyColumnUIdParameter());
			Parameters.Add(CreateLDAPMessageTextParameter());
			Parameters.Add(CreateLDAPMessageTypeParameter());
			Parameters.Add(CreateLDAPAddLinkParameter());
			Parameters.Add(CreateShowLDAPMessageIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet448 = CreateLaneSet448LaneSet();
			LaneSets.Add(schemaLaneSet448);
			ProcessSchemaLane schemaLane1398 = CreateLane1398Lane();
			schemaLaneSet448.Lanes.Add(schemaLane1398);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess subprocess_usereditpageclosed = CreateSubProcess_UserEditPageClosedEventSubProcess();
			FlowElements.Add(subprocess_usereditpageclosed);
			ProcessSchemaEventSubProcess subprocessapplyfolderfilter = CreateSubProcessApplyFolderFilterEventSubProcess();
			FlowElements.Add(subprocessapplyfolderfilter);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent pageloadchild = CreatePageLoadChildStartMessageEvent();
			eventsubprocess10.FlowElements.Add(pageloadchild);
			ProcessSchemaScriptTask scriptpageloadchild = CreateScriptPageLoadChildScriptTask();
			eventsubprocess10.FlowElements.Add(scriptpageloadchild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadparent = CreateThrowPageLoadParentIntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(throwpageloadparent);
			ProcessSchemaStartMessageEvent datasourceloadingchild = CreateDataSourceLoadingChildStartMessageEvent();
			eventsubprocess11.FlowElements.Add(datasourceloadingchild);
			ProcessSchemaScriptTask scriptdatasourceloadingchild = CreateScriptDataSourceLoadingChildScriptTask();
			eventsubprocess11.FlowElements.Add(scriptdatasourceloadingchild);
			ProcessSchemaIntermediateThrowMessageEvent throwdatasourceloadingparent = CreateThrowDataSourceLoadingParentIntermediateThrowMessageEvent();
			eventsubprocess11.FlowElements.Add(throwdatasourceloadingparent);
			ProcessSchemaStartMessageEvent usereditpageclosedmessage = CreateUserEditPageClosedMessageStartMessageEvent();
			subprocess_usereditpageclosed.FlowElements.Add(usereditpageclosedmessage);
			ProcessSchemaScriptTask scriptusereditpageclosed = CreateScriptUserEditPageClosedScriptTask();
			subprocess_usereditpageclosed.FlowElements.Add(scriptusereditpageclosed);
			ProcessSchemaStartMessageEvent applyfolderfilterchild = CreateApplyFolderFilterChildStartMessageEvent();
			subprocessapplyfolderfilter.FlowElements.Add(applyfolderfilterchild);
			ProcessSchemaScriptTask scriptapplyfolderfilterchild = CreateScriptApplyFolderFilterChildScriptTask();
			subprocessapplyfolderfilter.FlowElements.Add(scriptapplyfolderfilterchild);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			subprocess9.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocess9.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcompleteparent = CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent();
			subprocess9.FlowElements.Add(throwpageloadcompleteparent);
			ProcessSchemaStartMessageEvent showldapcustommessage = CreateShowLDAPCustomMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(showldapcustommessage);
			ProcessSchemaScriptTask scriptshowldapcustommessage = CreateScriptShowLDAPCustomMessageScriptTask();
			eventsubprocess1.FlowElements.Add(scriptshowldapcustommessage);
			FlowElements.Add(CreateSequenceFlow8044SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8074SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8075SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8076SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8079SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8080SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8081SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8082SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOpenLDAPUsersListLSLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOpenLDAPUsersListLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("09f6ad16-7533-40f2-80f5-eec5fa7a6efb"),
				Name = "OpenLDAPUsersListLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8044SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8044",
				UId = new Guid("0466ae26-6184-42a0-946a-03b5916a48f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(140, 596),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42e13b65-763d-429f-8a01-3d4325dbef40"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a59638c-5f0d-4466-9a0d-6eee622ba269"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8074SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8074",
				UId = new Guid("96a3a005-1fab-4d10-8e92-07784b072ad4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(169, 1704),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("af461be1-6a28-4efe-9e61-9839d9e8713f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b1713162-a60b-4f77-93a3-c229ded83b6c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8075SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8075",
				UId = new Guid("3abb79c2-eb96-4a14-875b-61c06014cea6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(168, 1700),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2ce6e91e-d53f-4b23-9641-fb4f06385f3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3360bb02-99bb-4963-a06a-5e406635a46c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8076SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8076",
				UId = new Guid("3ecdbbe0-685c-416b-8950-0048256b2276"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(264, 1703),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3360bb02-99bb-4963-a06a-5e406635a46c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f2f732d4-23d8-4e8a-ac48-c7d9b3840fe0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8079SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8079",
				UId = new Guid("a9acafe5-0136-4bec-b0d4-c89a5ca47158"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6e73ce58-7331-4aa1-8078-ce1afb1a8842"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("511717fb-14fd-4ca8-b8f8-eff912dd7761"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8080SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8080",
				UId = new Guid("6e25d14d-edaa-48d1-b9d1-8fb13e4362ab"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e7c1106b-93ec-418c-972f-b45a6c757a00"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e73ce58-7331-4aa1-8078-ce1afb1a8842"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8081SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8081",
				UId = new Guid("f3f8a7bb-2352-4654-b065-b6900c4cdda9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(432, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70783f2e-8877-4415-b35b-84843efb3095"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69a462f2-3d5d-4b98-85db-c462a5a5ed14"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8082SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8082",
				UId = new Guid("acc2a1df-6d80-4a5f-93f7-bddf471cf8ec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(543, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69a462f2-3d5d-4b98-85db-c462a5a5ed14"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8e339030-ee0d-4896-ae02-7f784d94762d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("3ac9f6d6-8091-48a8-954b-f758e376e436"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				CurveCenterPosition = new Point(154, 456),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8712facb-b50d-47a9-b3d6-31830a42bd3a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0d991a8-dc35-40c9-9a4f-5f14393a0a8c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet448LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet448 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("38176511-dedb-4a1f-8ab2-4a635a84f5d4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"LaneSet448",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(895, 170),
				UseBackgroundMode = false
			};
			return schemaLaneSet448;
		}

		protected virtual ProcessSchemaLane CreateLane1398Lane() {
			ProcessSchemaLane schemaLane1398 = new ProcessSchemaLane(this) {
				UId = new Guid("ba0ab14e-dace-43bc-865c-86b630290ab1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("38176511-dedb-4a1f-8ab2-4a635a84f5d4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"Lane1398",
				Position = new Point(29, 0),
				Size = new Size(866, 170),
				UseBackgroundMode = false
			};
			return schemaLane1398;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b2667992-73d7-4448-aed5-7b94218b6a2a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba0ab14e-dace-43bc-865c-86b630290ab1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"EventSubProcess10",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(267, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e7c1106b-93ec-418c-972f-b45a6c757a00"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2667992-73d7-4448-aed5-7b94218b6a2a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"PageLoadChild",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("511717fb-14fd-4ca8-b8f8-eff912dd7761"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2667992-73d7-4448-aed5-7b94218b6a2a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ScriptPageLoadChild",
				Position = new Point(169, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,77,107,2,49,16,61,91,232,127,8,158,118,65,66,123,173,214,82,172,181,11,82,164,106,47,197,67,116,199,109,32,155,200,36,91,43,165,255,189,249,210,134,90,241,176,176,204,188,247,102,222,203,76,88,5,116,134,0,35,228,37,29,129,121,81,219,129,146,107,94,61,49,89,10,64,114,75,74,16,80,49,3,217,12,16,153,86,107,67,7,10,129,14,165,225,134,131,14,63,59,130,106,155,147,175,203,11,66,136,54,200,101,69,54,200,107,134,187,129,18,77,45,159,89,13,86,205,162,232,116,245,14,53,163,147,180,77,93,191,123,146,253,202,68,179,167,219,53,147,98,118,52,37,167,51,53,245,26,89,30,20,63,24,146,149,183,101,37,36,108,201,3,51,108,170,26,92,193,193,112,118,60,47,178,3,147,222,151,101,68,30,41,20,122,248,185,177,129,177,165,128,128,9,171,173,153,208,144,59,153,214,82,41,65,132,170,42,40,127,109,204,118,27,40,147,129,61,135,234,103,237,177,199,21,178,237,169,69,109,95,105,204,181,41,12,212,132,219,117,172,66,148,186,35,19,247,132,115,13,24,73,123,48,117,104,253,118,181,32,55,231,48,215,11,55,198,133,228,196,245,62,35,190,50,92,73,27,73,47,188,72,135,120,98,98,176,239,3,110,197,120,13,42,225,17,81,96,144,148,2,48,5,209,144,158,197,166,184,80,164,135,13,143,88,135,206,188,112,65,158,116,102,219,255,115,3,207,25,253,23,19,110,51,17,143,199,26,177,62,32,119,10,89,219,253,182,59,222,233,223,92,178,84,50,223,91,63,115,68,143,28,117,60,236,194,77,73,245,252,216,32,132,96,26,148,241,40,109,225,219,126,177,102,176,129,238,15,102,198,167,84,211,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6e73ce58-7331-4aa1-8078-ce1afb1a8842"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2667992-73d7-4448-aed5-7b94218b6a2a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ThrowPageLoadParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d0b0132a-40a9-44af-a761-43bba47b0503"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba0ab14e-dace-43bc-865c-86b630290ab1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadingChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("70783f2e-8877-4415-b35b-84843efb3095"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0b0132a-40a9-44af-a761-43bba47b0503"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoading",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"DataSourceLoadingChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceLoadingChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("69a462f2-3d5d-4b98-85db-c462a5a5ed14"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0b0132a-40a9-44af-a761-43bba47b0503"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ScriptDataSourceLoadingChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,202,49,10,128,48,16,68,209,222,83,164,212,38,57,64,176,82,209,82,208,11,44,113,48,1,141,48,108,10,111,111,145,202,246,191,239,220,42,39,236,78,96,102,58,236,112,65,216,118,190,113,21,70,81,217,158,194,0,187,133,136,91,236,146,64,97,136,239,240,92,229,206,166,55,237,148,53,233,91,189,214,46,254,47,223,16,90,152,141,178,192,127,114,12,137,60,117,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowDataSourceLoadingParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8e339030-ee0d-4896-ae02-7f784d94762d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0b0132a-40a9-44af-a761-43bba47b0503"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceLoading",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ThrowDataSourceLoadingParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess_UserEditPageClosedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess_UserEditPageClosed = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8335d78f-1eba-4207-a2e2-8316ca2f10f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba0ab14e-dace-43bc-865c-86b630290ab1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"SubProcess_UserEditPageClosed",
				Position = new Point(50, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(237, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess_UserEditPageClosed;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUserEditPageClosedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("42e13b65-763d-429f-8a01-3d4325dbef40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8335d78f-1eba-4207-a2e2-8316ca2f10f7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UserEditPageClosed",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"UserEditPageClosedMessage",
				Position = new Point(21, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptUserEditPageClosedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a59638c-5f0d-4466-9a0d-6eee622ba269"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8335d78f-1eba-4207-a2e2-8316ca2f10f7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ScriptUserEditPageClosed",
				Position = new Point(126, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,93,79,219,48,20,125,6,137,255,144,229,41,145,82,171,221,214,105,8,134,148,180,101,170,4,5,181,101,47,136,7,147,92,90,79,142,221,217,78,89,52,246,223,231,143,52,109,8,69,104,27,79,200,185,231,220,115,143,143,111,215,88,120,68,78,224,209,251,226,5,247,156,211,48,72,57,83,240,83,161,249,82,240,199,209,26,152,138,197,66,122,88,122,23,68,170,83,126,255,29,82,117,22,222,246,238,78,142,14,201,131,23,188,179,4,161,247,235,232,240,64,128,42,4,243,148,40,64,127,253,125,116,56,36,169,34,156,97,81,158,74,37,8,91,68,94,197,224,233,70,25,49,31,165,110,206,180,132,253,181,65,168,217,214,90,107,33,65,140,51,35,246,173,50,187,119,104,206,103,150,174,102,193,148,142,242,21,229,37,192,148,83,176,132,70,192,215,130,100,129,31,191,63,142,63,36,113,191,243,49,233,14,59,195,81,175,215,57,142,251,189,78,183,219,239,246,63,13,186,250,239,179,191,161,146,64,117,31,200,106,30,195,129,52,187,42,171,10,35,20,167,170,253,209,122,231,6,69,99,57,41,40,189,18,246,91,96,38,0,6,226,26,47,224,90,240,20,164,188,25,103,161,179,216,112,174,220,161,102,188,209,134,12,56,99,96,173,67,227,170,124,196,22,132,1,250,10,170,58,72,74,205,176,143,88,139,57,104,13,82,27,82,53,171,200,86,32,84,249,13,211,2,2,255,26,11,237,187,67,248,225,142,207,161,187,124,103,128,46,33,170,108,107,29,217,243,89,186,132,28,95,98,166,37,9,211,99,204,164,194,44,133,164,156,224,92,55,153,149,50,206,114,194,110,24,81,186,201,64,0,86,224,176,65,147,49,172,76,117,13,209,57,168,116,121,46,120,62,76,130,122,24,23,160,176,242,114,247,110,42,148,86,48,47,87,144,13,56,45,114,102,7,61,53,200,179,192,31,108,170,237,237,219,139,200,238,103,144,22,66,3,157,227,237,41,135,73,179,194,32,159,163,208,12,212,174,27,83,72,185,200,174,180,213,216,112,76,201,98,169,46,96,13,180,53,71,228,109,84,249,209,54,105,145,215,102,179,36,53,37,154,2,206,34,45,101,79,161,237,134,98,74,249,99,125,151,198,218,102,74,208,232,71,129,169,12,182,177,14,189,167,39,239,229,162,214,163,11,247,172,140,237,94,184,53,151,111,252,244,239,180,177,245,120,39,173,26,67,104,107,154,173,55,111,212,145,140,153,57,117,163,254,75,26,183,92,219,45,176,123,106,100,180,59,54,131,107,30,32,122,57,189,13,108,35,196,219,161,247,89,215,196,234,84,237,164,56,240,117,112,35,183,130,244,190,182,41,178,15,245,117,144,147,157,93,49,141,29,234,255,230,36,7,52,113,177,120,19,50,41,109,223,103,118,15,10,97,118,135,57,69,110,3,189,78,118,201,51,242,64,254,74,199,6,250,127,132,108,2,96,168,170,71,248,22,76,181,36,163,103,9,125,1,139,215,96,127,168,118,47,247,15,254,217,240,192,167,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessApplyFolderFilterEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessApplyFolderFilter = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7bc0f5ed-77ca-4887-a7a3-eda773587552"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba0ab14e-dace-43bc-865c-86b630290ab1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"SubProcessApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(239, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessApplyFolderFilter;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateApplyFolderFilterChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("af461be1-6a28-4efe-9e61-9839d9e8713f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7bc0f5ed-77ca-4887-a7a3-eda773587552"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ApplyFolderFilter",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ApplyFolderFilterChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptApplyFolderFilterChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b1713162-a60b-4f77-93a3-c229ded83b6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7bc0f5ed-77ca-4887-a7a3-eda773587552"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ScriptApplyFolderFilterChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(98, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,75,79,34,65,16,62,99,226,127,104,57,13,209,52,222,93,77,20,208,37,113,55,70,112,61,24,15,237,76,33,189,105,186,217,238,30,220,201,134,255,190,85,61,3,243,224,225,131,4,24,186,171,190,170,175,158,44,132,101,74,58,15,26,236,157,120,5,118,206,34,250,230,244,209,51,218,11,137,55,248,203,130,246,252,167,152,73,253,186,62,102,194,177,154,92,39,168,13,181,243,66,199,64,215,99,176,86,56,51,241,252,17,94,46,231,115,126,37,28,252,48,73,170,128,68,71,241,20,102,226,193,129,37,12,107,212,89,183,123,91,117,231,43,16,135,7,11,100,149,8,47,70,38,181,49,113,10,148,250,235,147,66,36,78,45,209,26,121,155,198,62,181,36,88,106,241,94,227,118,3,247,90,42,143,65,192,136,149,46,62,12,201,203,194,19,199,215,15,195,126,67,109,232,97,214,97,205,83,180,33,39,209,145,121,249,13,177,231,247,48,1,116,33,134,193,159,84,40,23,53,165,79,152,78,149,234,116,216,191,195,131,214,196,216,72,106,207,36,58,116,122,134,95,223,54,248,241,92,141,220,74,181,71,153,227,227,92,183,133,70,119,9,63,201,103,202,59,240,194,137,38,255,112,89,248,208,106,237,65,169,69,119,77,183,213,90,226,7,189,137,248,30,143,67,137,109,154,95,89,222,169,121,153,36,155,74,103,133,77,12,26,136,120,202,34,202,236,36,207,167,212,59,3,87,70,235,104,82,146,95,69,166,61,2,97,227,105,46,219,38,199,90,33,38,133,232,208,13,180,120,81,144,96,32,142,134,46,23,174,70,96,201,64,57,8,38,246,228,35,79,30,187,96,167,133,55,165,235,14,145,53,188,49,234,160,111,91,43,238,34,10,212,191,200,251,19,196,233,21,84,222,103,31,232,7,236,109,208,215,70,37,96,247,65,231,41,158,148,137,69,196,66,100,185,135,235,164,78,109,103,184,239,97,102,22,80,195,95,229,235,240,224,131,85,199,123,232,130,47,242,240,40,253,20,231,41,146,36,201,40,63,236,153,217,92,88,233,140,30,103,243,130,253,9,107,143,50,119,153,224,204,125,208,210,135,139,95,66,165,208,62,97,212,234,157,114,236,244,144,35,239,95,241,13,121,154,139,29,242,250,240,32,204,192,177,5,184,177,50,225,61,133,25,8,213,208,237,82,96,166,18,44,165,36,235,25,149,206,116,125,20,230,51,150,127,175,203,32,134,209,16,48,188,205,66,28,187,221,119,181,168,70,113,106,81,32,43,178,183,70,36,247,230,205,5,180,37,38,71,11,165,62,131,217,244,31,23,199,64,123,233,179,92,35,63,61,11,73,43,230,56,224,64,81,110,44,94,238,132,6,133,16,213,61,200,251,245,235,16,65,44,209,134,22,199,135,85,71,158,159,175,90,210,2,214,130,102,88,20,80,181,40,98,47,23,128,26,20,220,45,56,79,205,195,203,149,194,80,39,240,247,57,44,7,22,173,97,56,117,244,7,172,151,108,107,203,26,189,104,64,61,157,62,87,87,122,101,151,6,237,126,117,163,70,91,16,177,250,117,82,209,190,202,168,149,163,118,169,72,29,140,22,106,155,248,38,149,73,209,141,121,150,66,141,163,9,186,224,131,217,220,103,249,90,172,148,1,149,74,65,252,104,77,124,27,70,67,7,25,242,59,43,103,194,102,21,185,60,76,235,255,29,214,196,224,112,66,121,124,154,131,245,89,84,253,75,82,92,63,12,19,236,207,235,166,73,108,205,13,55,168,164,87,8,227,169,53,111,131,5,206,140,221,160,184,246,45,184,105,81,129,109,82,175,230,244,63,55,148,48,84,179,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e2a9578c-2453-4dea-ba48-c5ff71f56274"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba0ab14e-dace-43bc-865c-86b630290ab1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(547, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(257, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2ce6e91e-d53f-4b23-9641-fb4f06385f3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2a9578c-2453-4dea-ba48-c5ff71f56274"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3360bb02-99bb-4963-a06a-5e406635a46c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2a9578c-2453-4dea-ba48-c5ff71f56274"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,205,203,10,194,48,16,133,225,125,159,34,116,165,139,4,122,209,86,138,171,42,218,141,8,165,15,48,73,166,26,40,41,76,39,212,199,55,213,245,249,249,206,213,58,126,194,11,135,206,138,179,240,184,138,91,112,118,151,86,99,85,103,112,44,101,174,139,92,150,181,41,228,169,6,35,181,46,108,121,64,52,58,207,210,125,147,180,132,192,104,135,5,169,157,61,227,135,255,210,166,168,7,174,63,45,118,219,135,186,0,67,63,7,50,168,218,64,132,158,123,166,96,56,16,170,110,185,59,36,32,243,118,6,166,40,140,48,45,216,36,132,113,246,34,118,216,124,1,35,155,239,77,173,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f2f732d4-23d8-4e8a-ac48-c7d9b3840fe0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2a9578c-2453-4dea-ba48-c5ff71f56274"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ThrowPageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("58fc9a17-fe5a-4c97-9c74-5ece8b81b24f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba0ab14e-dace-43bc-865c-86b630290ab1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 373),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(195, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShowLDAPCustomMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8712facb-b50d-47a9-b3d6-31830a42bd3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58fc9a17-fe5a-4c97-9c74-5ece8b81b24f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ShowLDAPCustomMessage",
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ShowLDAPCustomMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(7, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptShowLDAPCustomMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b0d991a8-dc35-40c9-9a4f-5f14393a0a8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58fc9a17-fe5a-4c97-9c74-5ece8b81b24f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6599239f-e496-4ee2-80f2-042a9056225a"),
				Name = @"ScriptShowLDAPCustomMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,193,78,195,48,12,134,207,67,226,29,66,79,45,154,2,247,137,195,24,3,85,218,196,196,54,46,136,67,68,189,17,209,57,81,146,110,76,136,119,199,110,51,169,129,19,210,212,37,191,237,223,95,226,118,14,222,171,45,44,20,66,45,118,253,205,141,152,24,12,206,212,235,160,107,29,52,120,121,175,177,138,98,126,126,54,88,80,174,28,123,219,254,71,221,191,92,191,14,69,118,171,60,204,123,110,217,80,4,215,64,33,148,23,125,125,116,126,166,55,34,79,26,95,220,8,108,234,186,16,95,212,131,163,179,187,241,98,92,85,51,141,31,157,56,184,186,220,43,39,16,14,172,17,41,173,4,47,9,98,163,183,121,49,226,164,24,150,19,101,131,54,72,105,143,22,144,205,214,30,156,159,105,31,102,203,36,115,237,248,216,89,150,136,252,40,43,210,151,239,230,192,213,145,191,172,228,202,44,131,211,120,106,216,63,69,91,230,37,97,231,209,168,24,93,94,113,22,147,31,140,251,160,123,115,230,141,74,200,154,129,136,29,225,141,73,101,25,35,83,220,106,132,246,218,163,114,123,92,151,85,206,232,128,224,248,226,99,128,228,14,130,237,119,74,163,237,244,70,51,122,210,79,62,64,160,165,5,23,142,207,170,110,32,207,230,84,144,154,101,157,91,59,156,212,45,25,79,215,207,254,255,8,169,105,239,38,187,190,3,43,87,239,206,28,166,123,192,144,91,89,98,0,135,170,230,183,12,62,3,189,97,119,230,215,60,34,241,55,61,190,5,212,30,58,192,100,40,79,176,51,123,58,239,223,178,36,141,166,22,163,105,234,80,116,148,114,186,179,225,56,20,189,216,170,165,202,79,187,163,133,162,31,229,61,247,33,58,250,57,8,141,195,246,139,24,253,0,106,3,33,169,129,3,0,0 }
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

		protected override SchemaMethod CreateGetEditPagesMethod() {
			SchemaMethod method = base.CreateGetEditPagesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,84,176,41,46,41,202,204,75,215,81,128,208,118,26,154,214,0,115,244,126,77,41,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = base.CreateModifyAddPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,65,75,3,49,16,133,239,254,138,208,83,247,146,63,80,122,208,21,101,133,22,97,91,122,16,15,227,230,89,7,178,201,58,153,22,237,175,55,89,169,180,208,130,151,132,204,188,121,239,155,236,73,140,231,164,8,144,103,218,194,204,205,180,220,182,28,117,12,74,156,59,249,37,8,106,151,212,115,216,254,149,13,37,115,166,171,198,177,38,36,165,208,161,180,87,16,161,20,223,213,110,240,118,59,12,246,142,18,22,209,237,60,138,180,237,62,208,211,58,65,138,135,68,63,187,217,103,162,225,212,101,126,6,56,26,60,68,239,70,170,127,135,253,78,164,43,153,159,59,200,119,171,146,151,203,155,82,15,205,218,151,9,57,199,202,49,144,95,9,240,40,236,38,175,25,231,41,197,96,91,8,147,231,3,166,167,176,246,40,180,181,231,252,99,205,125,117,213,189,19,144,194,29,65,240,165,235,230,98,64,125,73,88,205,126,0,146,213,85,140,187,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrationUsersGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6599239f-e496-4ee2-80f2-042a9056225a"));
		}

		#endregion

	}

	#endregion

}

