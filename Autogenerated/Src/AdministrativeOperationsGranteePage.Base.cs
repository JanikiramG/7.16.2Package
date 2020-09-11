namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
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
	using Terrasoft.Core.OperationLog;
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

	#region Class: AdministrativeOperationsGranteePageSchema

	/// <exclude/>
	public class AdministrativeOperationsGranteePageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _upButton;
		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return _upButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downButton;
		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return _downButton;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrativeOperationsGranteePageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeOperationsGranteePageSchema(AdministrativeOperationsGranteePageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			RealUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			Name = "AdministrativeOperationsGranteePage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "253";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeOperationsGranteePageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.InsertItem(4, CreateUpButton());
			ButtonsControlLayout.InsertItem(5, CreateDownButton());
			ButtonsControlLayout.MoveItem(6, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			ButtonsControlLayout.MoveItem(9, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeOperationsGranteePageEventsProcessSchema() {
			var schema = new AdministrativeOperationsGranteePageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("0537f209-c9f6-42a6-957c-537a43066582");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			_upButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			_upButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("8046254f-aafd-4438-9ab7-d9bd5817dbe3");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			_downButton.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			_downButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			return _downButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a");
			DataSource.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("23ce128a-7f75-4728-826b-facd328562e1");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("423b165f-9759-437b-b532-95ef1b78063b");
			if (column != null) {
				column.UId = new Guid("14184637-c39e-486d-be16-0da9ec88dd10");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
				column.OrderPosition = -1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e1f978af-3b07-4c9f-a422-c6170cd1b1a4");
			if (column != null) {
				column.UId = new Guid("4cb57e5b-c74e-4727-9772-728dcfc6cc74");
				column.Name = @"CanExecute";
				column.CreatedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9d032101-3db5-4bba-ab16-294104cd15ad");
			if (column != null) {
				column.UId = new Guid("d6c4f7ec-2224-4125-90da-bccc4a7af6bc");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.ModifiedInSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.IsSortable = false;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeOperationsGranteePageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeOperationsGranteePageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeOperationsGranteePageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeOperationsGranteePageEventsProcess

	/// <exclude/>
	public class AdministrativeOperationsGranteePageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeOperationsGranteePageSchemaUserControl
	{

		#region Class: OpenSysAdminUnitsLookupTaskFlowElement

		/// <exclude/>
		public class OpenSysAdminUnitsLookupTaskFlowElement : OpenLookupUserTask
		{

			public OpenSysAdminUnitsLookupTaskFlowElement(UserConnection userConnection, AdministrativeOperationsGranteePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenSysAdminUnitsLookupTask";
				IsLogging = false;
				SchemaElementUId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AdministrativeOperationsGranteePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeOperationsGranteePageEventsProcess";
			SchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2");
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

		public virtual bool PositionSwapped {
			get;
			set;
		}

		public virtual Guid SwappedGranteeId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("3ae0b59d-4b9e-48c6-9a00-b6f55247b543"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("be886b45-76fc-4861-8586-c5701c2ef493"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _child_AddButtonClickScriptTask;
		public ProcessScriptTask Child_AddButtonClickScriptTask {
			get {
				return _child_AddButtonClickScriptTask ?? (_child_AddButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_AddButtonClickScriptTask",
					SchemaElementUId = new Guid("03cf0e12-ea14-4439-8f04-239fc312838b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_AddButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenSysAdminUnitsLookupTaskFlowElement _openSysAdminUnitsLookupTask;
		public OpenSysAdminUnitsLookupTaskFlowElement OpenSysAdminUnitsLookupTask {
			get {
				return _openSysAdminUnitsLookupTask ?? (_openSysAdminUnitsLookupTask = new OpenSysAdminUnitsLookupTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("513000a2-8111-469f-9f28-2206603110fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _child_AddButtonClickScriptTask2;
		public ProcessScriptTask Child_AddButtonClickScriptTask2 {
			get {
				return _child_AddButtonClickScriptTask2 ?? (_child_AddButtonClickScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_AddButtonClickScriptTask2",
					SchemaElementUId = new Guid("6962844b-e4ca-4125-95db-f8d18b9f10b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_AddButtonClickScriptTask2Execute,
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
					SchemaElementUId = new Guid("5d4c62e3-1167-4119-ad82-38d2296e5cd7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("b3a4a473-b3ed-4c6b-a79f-bc5c52aafabd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("83ea4044-3639-469b-b88f-4c02f1df6f14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _child_InitScriptTask;
		public ProcessScriptTask Child_InitScriptTask {
			get {
				return _child_InitScriptTask ?? (_child_InitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_InitScriptTask",
					SchemaElementUId = new Guid("b37a4ab8-25d2-4b0d-bc70-7449320fa68a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_InitScriptTaskExecute,
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
					SchemaElementUId = new Guid("5303e93c-0179-420c-9bc0-2118f6891f50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("4dcb184d-f792-46b2-bfa3-3e1c7727f680"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("e490caad-9663-4c7d-8eb7-7d74a0e371fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteYesMessage",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _child_DeleteYesMessageScriptTask;
		public ProcessScriptTask Child_DeleteYesMessageScriptTask {
			get {
				return _child_DeleteYesMessageScriptTask ?? (_child_DeleteYesMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_DeleteYesMessageScriptTask",
					SchemaElementUId = new Guid("d455ebdd-7742-4448-9885-7fdcfe6ca90f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_DeleteYesMessageScriptTaskExecute,
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
					SchemaElementUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("f6f086b1-d81b-4677-9cd2-13aa5e432fcc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _upButtonClickScriptTask;
		public ProcessScriptTask UpButtonClickScriptTask {
			get {
				return _upButtonClickScriptTask ?? (_upButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpButtonClickScriptTask",
					SchemaElementUId = new Guid("3efa8ffc-68de-445d-9bf4-3276b0822758"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _startMessage6;
		public ProcessFlowElement StartMessage6 {
			get {
				return _startMessage6 ?? (_startMessage6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6",
					SchemaElementUId = new Guid("b7f33856-f183-4b50-b63b-5fd8cf95df69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _downButtonClickScriptTask;
		public ProcessScriptTask DownButtonClickScriptTask {
			get {
				return _downButtonClickScriptTask ?? (_downButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DownButtonClickScriptTask",
					SchemaElementUId = new Guid("7b70f049-57bf-4001-8650-605bd41a38e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DownButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("e87d7acc-ab81-402a-b070-24ed8d2d55ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4;
		public ProcessExclusiveGateway ExclusiveGateway4 {
			get {
				return _exclusiveGateway4 ?? (_exclusiveGateway4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4",
					SchemaElementUId = new Guid("0a6b48ab-5d12-4170-be0f-54462cbc4a83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("67b85305-c400-4ec9-b661-5512e2b4e41c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _upDownButtonsClickScriptTask;
		public ProcessScriptTask UpDownButtonsClickScriptTask {
			get {
				return _upDownButtonsClickScriptTask ?? (_upDownButtonsClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpDownButtonsClickScriptTask",
					SchemaElementUId = new Guid("f0bb7ab3-82a2-4476-834c-072f3754931d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpDownButtonsClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("d1ff4477-c5cb-478b-984b-55baf28951a4"),
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
					SchemaElementUId = new Guid("2a1bb5b7-672b-4ac7-8bd1-02779fbea6e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[Child_AddButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_AddButtonClickScriptTask };
			FlowElements[OpenSysAdminUnitsLookupTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSysAdminUnitsLookupTask };
			FlowElements[IntermediateCatchMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent1 };
			FlowElements[Child_AddButtonClickScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_AddButtonClickScriptTask2 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[Child_InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_InitScriptTask };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[Child_DeleteYesMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_DeleteYesMessageScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[UpButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpButtonClickScriptTask };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[DownButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DownButtonClickScriptTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ExclusiveGateway4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[UpDownButtonsClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpDownButtonsClickScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess8":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("Child_AddButtonClickScriptTask");
						break;
					case "Child_AddButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenSysAdminUnitsLookupTask");
						break;
					case "OpenSysAdminUnitsLookupTask":
						ActivatedEventElements.Add("IntermediateCatchMessageEvent1");
						break;
					case "IntermediateCatchMessageEvent1":
						e.Context.QueueTasks.Enqueue("Child_AddButtonClickScriptTask2");
						break;
					case "Child_AddButtonClickScriptTask2":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("Child_InitScriptTask");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "Child_InitScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("Child_DeleteYesMessageScriptTask");
						break;
					case "Child_DeleteYesMessageScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("UpButtonClickScriptTask");
						break;
					case "UpButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("DownButtonClickScriptTask");
						break;
					case "DownButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway4");
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("UpDownButtonsClickScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "ExclusiveGateway4":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("UpDownButtonsClickScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "End1":
						break;
					case "UpDownButtonsClickScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(PositionSwapped);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(PositionSwapped);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage6");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "Child_AddButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_AddButtonClickScriptTask";
					result = Child_AddButtonClickScriptTask.Execute(context, Child_AddButtonClickScriptTaskExecute);
					break;
				case "OpenSysAdminUnitsLookupTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSysAdminUnitsLookupTask";
					result = OpenSysAdminUnitsLookupTask.Execute(context);
					break;
				case "IntermediateCatchMessageEvent1":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent1";
					result = IntermediateCatchMessageEvent1.Execute(context);
					break;
				case "Child_AddButtonClickScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_AddButtonClickScriptTask2";
					result = Child_AddButtonClickScriptTask2.Execute(context, Child_AddButtonClickScriptTask2Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "Child_InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_InitScriptTask";
					result = Child_InitScriptTask.Execute(context, Child_InitScriptTaskExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteYesMessage");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "Child_DeleteYesMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_DeleteYesMessageScriptTask";
					result = Child_DeleteYesMessageScriptTask.Execute(context, Child_DeleteYesMessageScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "UpButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpButtonClickScriptTask";
					result = UpButtonClickScriptTask.Execute(context, UpButtonClickScriptTaskExecute);
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "DownButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownButtonClickScriptTask";
					result = DownButtonClickScriptTask.Execute(context, DownButtonClickScriptTaskExecute);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ExclusiveGateway4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway4";
					result = ExclusiveGateway4.Execute(context);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "UpDownButtonsClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpDownButtonsClickScriptTask";
					result = UpDownButtonsClickScriptTask.Execute(context, UpDownButtonsClickScriptTaskExecute);
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
				case "SwappedGranteeId":
					SwappedGranteeId = reader.GetValue<System.Guid>();
				break;
				case "PositionSwapped":
					PositionSwapped = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool Child_AddButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			string schemaUId = "84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c";
			OpenSysAdminUnitsLookupTask.ProcessKey = context.Process.InstanceUId;
			OpenSysAdminUnitsLookupTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenSysAdminUnitsLookupTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("editMode", false);
			var filters = new Collection<Dictionary<string, object>>();
			
			var sysAdminOperationId = SelectedNodePrimaryColumnValue;
			var sysAdminOperationGranteeSchemaQuery = new EntitySchemaQuery(Page.DataSource.Schema);
			sysAdminOperationGranteeSchemaQuery.AddColumn("SysAdminUnit");		
			var sysAdminOperationIdFilter = sysAdminOperationGranteeSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminOperation", sysAdminOperationId);
			sysAdminOperationGranteeSchemaQuery.Filters.Add(sysAdminOperationIdFilter);	
			var sysAdminOperationGrantees = sysAdminOperationGranteeSchemaQuery.GetEntityCollection(UserConnection);
			var sysAdminUnitObjsList = new ArrayList();
			foreach (var sysAdminOperationGrantee in sysAdminOperationGrantees) {
				sysAdminUnitObjsList.Add(sysAdminOperationGrantee.GetColumnValue("SysAdminUnitId"));
			}
			
			filters.Add(new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.NotEqual},
				{"leftExpressionColumnPath", "Id"},
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", sysAdminUnitObjsList.ToArray()}});	
			pageParameters.Add("LookupFilters", filters);
			return true;
		}

		public virtual bool Child_AddButtonClickScriptTask2Execute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var selectedSysAdminUnits = (Dictionary<string, object>)(OpenSysAdminUnitsLookupTask.GetSelectedValues(UserConnection));
			var sysAdminOperationId = SelectedNodePrimaryColumnValue;
			var n = 0;
			var prevId = GetFirstGranteeId(sysAdminOperationId);
			var currentId = Guid.NewGuid();
			
			var operationsToShift = GetRecordsToShift(sysAdminOperationId, 0);
			
			foreach (var sysAdminUnitIdStr in selectedSysAdminUnits.Keys) {
				var sysAdminUnitId = new Guid(sysAdminUnitIdStr);
				var sysAdminOperationGrantee = Page.DataSource.Schema.CreateEntity(UserConnection);
				sysAdminOperationGrantee.SetDefColumnValues();
				sysAdminOperationGrantee.SetColumnValue("Id", currentId);
				sysAdminOperationGrantee.SetColumnValue("SysAdminOperationId", sysAdminOperationId);
				sysAdminOperationGrantee.SetColumnValue("SysAdminUnitId", sysAdminUnitId);
				sysAdminOperationGrantee.SetColumnValue("CanExecute", true);
				sysAdminOperationGrantee.SetColumnValue("Position", n++);
				sysAdminOperationGrantee.Save();
				
				dataSource.LoadRow(currentId);
				if (prevId != Guid.Empty) {
					dataSource.Move(currentId, prevId, ItemMovePosition.Above);
				}
				
				prevId = currentId;
				currentId = Guid.NewGuid();
			}
			
			if (n > 0) {
				ShiftPositions(operationsToShift, n);
			}
			return true;
		}

		public virtual bool Child_InitScriptTaskExecute(ProcessExecutingContext context) {
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			Page.TreeGrid.GetRowConfigHandler += delegate(Entity row) {			
				string primaryColumnName = "Id";		
				string primaryColumnValue =	row.GetColumnValue(primaryColumnName).ToString();
				var config = new DataSourceRowConfig(primaryColumnValue);		
				bool columnValue = row.GetTypedColumnValue<bool>("CanExecute");	
				var icons = new Dictionary<string, ImageConfigValue>();		
				string columnIconImageName = columnValue ? "Allow.png" : "Deny.png";		
				var imageConfigValue = new ImageConfigValue(columnIconImageName);
				imageConfigValue.DisplayImageOnly = true;
				imageConfigValue.ImagePosition = ImagePosition.Center;		
				icons.Add("CanExecute", imageConfigValue);
				var iconConfig = new DataSourceRowColumnIconsConfigValue(icons);		
				config.AddConfig(iconConfig);
				var displayOnlyIcons = new Dictionary<string, bool>();
				displayOnlyIcons.Add("CanExecute", true);
				var displayOnlyIconsConfig = new DataSourceRowColumnDisplayOnlyIconsConfigValue(displayOnlyIcons);
				config.AddConfig(displayOnlyIconsConfig);
				return config;
			};
			Page.DataSource.Loaded += Page.TreeGrid.DataLoaded;
			
			Page.TreeGrid.AjaxEvents.CellIconClick.Event += CellIconClickHandler;
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(new Terrasoft.UI.WebControls.Controls.Parameter("nodeId", "nodeId", ParameterMode.Raw));
			
			return true;
		}

		public virtual bool Child_DeleteYesMessageScriptTaskExecute(ProcessExecutingContext context) {
			NormalizeGranteePositions(SelectedNodePrimaryColumnValue);
			return true;
		}

		public virtual bool UpButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			SwappedGranteeId = Page.DataSource.ActiveRowPrimaryColumnValue;
			PositionSwapped = SwapPositions(SwappedGranteeId, 1);
			return true;
		}

		public virtual bool DownButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			SwappedGranteeId = Page.DataSource.ActiveRowPrimaryColumnValue;
			PositionSwapped = SwapPositions(SwappedGranteeId, -1);
			return true;
		}

		public virtual bool UpDownButtonsClickScriptTaskExecute(ProcessExecutingContext context) {
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
			Page.DataSource.SelectedItemPrimaryColumnValues.Clear();
			Page.DataSource.SelectedItemPrimaryColumnValues.Add(SwappedGranteeId);
			Page.DataSource.SetClientActiveRow(SwappedGranteeId);
			return true;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			Page.UpButton.Enabled = Page.DeleteButton.Enabled;
			Page.DownButton.Enabled = Page.DeleteButton.Enabled;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public virtual void ShiftPositions(EntityCollection recordsToShift, int shiftValue) {
			foreach(var operationGrantee in recordsToShift) 
			{
				operationGrantee.SetColumnValue("Position", operationGrantee.GetTypedColumnValue<int>("Position") + shiftValue);
				operationGrantee.Save();
			}
		}

		public virtual Guid GetFirstGranteeId(Guid sysAdminOperationId) {
			var result = Guid.Empty;
			var select = new Select(UserConnection).Top(1).Column("Id").From("SysAdminOperationGrantee").Where("SysAdminOperationId").IsEqual(Column.Parameter(sysAdminOperationId)).OrderByAsc("Position") as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var dataReader = select.ExecuteReader(dbExecutor)) {
					if (dataReader.Read()) {
						result = UserConnection.DBTypeConverter.DBValueToGuid(dataReader[0]);
					}
				}
			}
			return result;
		}

		public virtual void NormalizeGranteePositions(Guid sysAdminOperationId) {
			//TODO: refactor if possible
			var sysAdminOperationGranteeSchemaQuery = new EntitySchemaQuery(Page.DataSource.Schema);
			sysAdminOperationGranteeSchemaQuery.AddColumn("Id");
			sysAdminOperationGranteeSchemaQuery.AddColumn("Position").OrderByAsc();
			var sysAdminOperationIdFilter = sysAdminOperationGranteeSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminOperation", sysAdminOperationId);
			sysAdminOperationGranteeSchemaQuery.Filters.Add(sysAdminOperationIdFilter);
			var sysAdminOperationGrantees = sysAdminOperationGranteeSchemaQuery.GetEntityCollection(UserConnection);
			
			var positionParam = new QueryParameter("P1", 0);
			var granteeIdParam = new QueryParameter("P2", Guid.Empty);
			var update = new Update(UserConnection, "SysAdminOperationGrantee")
				.Set("Position", positionParam)
				.Where("Id").IsEqual(granteeIdParam) as Update; 	
			
			for (var i = 0; i < sysAdminOperationGrantees.Count; i++) {
				if (sysAdminOperationGrantees[i].GetTypedColumnValue<int>("Position") != i) {
					var recordId = sysAdminOperationGrantees[i].GetTypedColumnValue<Guid>("Id1");
					granteeIdParam.Value = recordId;
					positionParam.Value = i;
					update.Execute();
					OperationLogger.Instance.LogAdminOperationRightChange(UserConnection, recordId, true);
				}
			}
		}

		public virtual void CellIconClickHandler(object sender, AjaxEventArgs e) {
			var nodeId = e.ExtraParameters["nodeId"];
			if (nodeId != null) {
				var recordId = (Guid)Json.Deserialize(nodeId, typeof(Guid));
				var sysAdminOperationGrantee = Page.DataSource.Schema.CreateEntity(UserConnection);
				if (sysAdminOperationGrantee.FetchFromDB(recordId)) {
					var canExecute = sysAdminOperationGrantee.GetTypedColumnValue<bool>("CanExecute");
					sysAdminOperationGrantee.SetColumnValue("CanExecute", !canExecute);
					sysAdminOperationGrantee.Save();
					Page.DataSource.LoadRow(recordId);
				}
			}
		}

		public virtual bool SwapPositions(Guid sysAdminOperationGranteeId, int shiftValue) {
			bool result = false;
			var sysAdminOperationGrantee = Page.DataSource.Schema.CreateEntity(UserConnection);
			if (sysAdminOperationGrantee.FetchFromDB(sysAdminOperationGranteeId)) {
				var oldPosition = sysAdminOperationGrantee.GetTypedColumnValue<int>("Position");
				var newPosition = oldPosition - shiftValue;
				if (newPosition >= 0) {
					var sysAdminOperationId = sysAdminOperationGrantee.GetTypedColumnValue<Guid>("SysAdminOperationId");
					var maxPosition = GetSysAdminOperationGranteeMaxPosition(sysAdminOperationId);
					if (newPosition <= maxPosition) {
						var swappedSysAdminOperationGranteeId = GetGranteeIdByPosition(sysAdminOperationId, newPosition);			
						var positionParam = new QueryParameter("P1", newPosition);
						var granteeIdParam = new QueryParameter("P2", sysAdminOperationGranteeId);
						var update = new Update(UserConnection, "SysAdminOperationGrantee").Set("Position", positionParam).Where("Id").IsEqual(granteeIdParam) as Update; 	
						using(DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
							dbExecutor.StartTransaction();
							update.Execute();
							OperationLogger.Instance.LogAdminOperationRightChange(UserConnection, sysAdminOperationGranteeId, true);
							positionParam.Value = oldPosition;
							granteeIdParam.Value = swappedSysAdminOperationGranteeId;
							update.Execute();
							OperationLogger.Instance.LogAdminOperationRightChange(UserConnection, swappedSysAdminOperationGranteeId, true);
							dbExecutor.CommitTransaction();
							result = true;
						}
					}
				}
			}
			return result;
		}

		public virtual int GetSysAdminOperationGranteeMaxPosition(Guid sysAdminOperationId) {
			var result = -1;
			var select = new Select(UserConnection).Top(1).Column("Position").From("SysAdminOperationGrantee").Where("SysAdminOperationId").IsEqual(Column.Parameter(sysAdminOperationId)).OrderByDesc("Position") as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var dataReader = select.ExecuteReader(dbExecutor)) {
					if (dataReader.Read()) {
						result = UserConnection.DBTypeConverter.DBValueToInt(dataReader[0]);
					}
				}
			}
			return result;
		}

		public virtual Guid GetGranteeIdByPosition(Guid sysAdminOperationId, int position) {
			var result = Guid.Empty;
			var select = new Select(UserConnection)
					.Column("Id")
				.From("SysAdminOperationGrantee")
				.Where("SysAdminOperationId").IsEqual(Column.Parameter(sysAdminOperationId))
				.And("Position").IsEqual(Column.Parameter(position)) as Select;
			return select.ExecuteScalar<Guid>();
		}

		public virtual EntityCollection GetRecordsToShift(Guid sysAdminOperationId, int startPosition) {
			var saogESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager.GetInstanceByName("SysAdminOperationGrantee")); 
			saogESQ.AddAllSchemaColumns();  
			saogESQ.Filters.Add(saogESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminOperation", sysAdminOperationId));
			saogESQ.Filters.Add(saogESQ.CreateFilterWithParameters(FilterComparisonType.GreaterOrEqual, "Position", startPosition));
			return saogESQ.GetEntityCollection(UserConnection);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent1")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent1");
					}
					break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
							ProcessQueue(context);
							return;
						}
						break;
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
						}
						break;
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SwappedGranteeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SwappedGranteeId", SwappedGranteeId, Guid.Empty);
			}
			if (!HasMapping("PositionSwapped") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PositionSwapped", PositionSwapped, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeOperationsGranteePageEventsProcess

	/// <exclude/>
	public class AdministrativeOperationsGranteePageEventsProcess : AdministrativeOperationsGranteePageEventsProcess<Terrasoft.WebApp.AdministrativeOperationsGranteePageSchemaUserControl>
	{

		public AdministrativeOperationsGranteePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeOperationsGranteePageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeOperationsGranteePageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			UpButton.AjaxEvents.Click.Event += UpButtonClick;
			DownButton.AjaxEvents.Click.Event += DownButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			UpButton.AjaxEvents.Click.Event -= UpButtonClick;
			DownButton.AjaxEvents.Click.Event -= DownButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeOperationsGranteePageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeOperationsGranteePageEventsProcess(UserConnection);
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

		public virtual void UpButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpButtonClick");
		}

		public virtual void DownButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownButtonClick");
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
			SchemaName = "AdministrativeOperationsGranteePage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeOperationsGranteePageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeOperationsGranteePageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeOperationsGranteePageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeOperationsGranteePageEventsProcessSchema(AdministrativeOperationsGranteePageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeOperationsGranteePageEventsProcess";
			UId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c");
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

		protected virtual ProcessSchemaParameter CreatePositionSwappedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2021fec9-73e1-41ed-8017-40a1c2518db5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"PositionSwapped",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSwappedGranteeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("99b87b57-325c-4941-b1e4-8249a264bbbb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"SwappedGranteeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePositionSwappedParameter());
			Parameters.Add(CreateSwappedGranteeIdParameter());
		}

		protected virtual void InitializeOpenSysAdminUnitsLookupTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d22d977a-06d7-424f-9c83-4a437a82d9a9"),
				ContainerUId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf"),
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
				UId = new Guid("bee0efe0-114b-4642-8ada-aad7d15b5de7"),
				ContainerUId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf"),
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
				UId = new Guid("9102ae89-a14b-4f73-bac1-3bf0d8bb0d42"),
				ContainerUId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf"),
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
				UId = new Guid("da07c5ed-9ceb-4f21-882e-7b502f2a499c"),
				ContainerUId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask child_addbuttonclickscripttask = CreateChild_AddButtonClickScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(child_addbuttonclickscripttask);
			ProcessSchemaUserTask opensysadminunitslookuptask = CreateOpenSysAdminUnitsLookupTaskUserTask();
			eventsubprocess8.FlowElements.Add(opensysadminunitslookuptask);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent1 = CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatecatchmessageevent1);
			ProcessSchemaScriptTask child_addbuttonclickscripttask2 = CreateChild_AddButtonClickScriptTask2ScriptTask();
			eventsubprocess8.FlowElements.Add(child_addbuttonclickscripttask2);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask child_initscripttask = CreateChild_InitScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(child_initscripttask);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage4);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask child_deleteyesmessagescripttask = CreateChild_DeleteYesMessageScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(child_deleteyesmessagescripttask);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask upbuttonclickscripttask = CreateUpButtonClickScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(upbuttonclickscripttask);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask downbuttonclickscripttask = CreateDownButtonClickScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(downbuttonclickscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess10.FlowElements.Add(exclusivegateway3);
			ProcessSchemaExclusiveGateway exclusivegateway4 = CreateExclusiveGateway4ExclusiveGateway();
			eventsubprocess10.FlowElements.Add(exclusivegateway4);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			eventsubprocess10.FlowElements.Add(end1);
			ProcessSchemaScriptTask updownbuttonsclickscripttask = CreateUpDownButtonsClickScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(updownbuttonsclickscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("757d79fe-674b-4d45-8c59-1bf188a3d75e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(213, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b37a4ab8-25d2-4b0d-bc70-7449320fa68a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83ea4044-3639-469b-b88f-4c02f1df6f14"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("026c0b8f-c534-4f43-b497-6c86ffedc6f9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(213, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3a4a473-b3ed-4c6b-a79f-bc5c52aafabd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b37a4ab8-25d2-4b0d-bc70-7449320fa68a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("fd9c5d69-fea4-48c5-9979-b024fd661b2b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("be886b45-76fc-4861-8586-c5701c2ef493"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03cf0e12-ea14-4439-8f04-239fc312838b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("5e8f55da-d512-4070-9a57-8f727fe2cf88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(310, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03cf0e12-ea14-4439-8f04-239fc312838b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5b7fee6b-5bb3-44af-b287-de9a915ff60f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(445, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("513000a2-8111-469f-9f28-2206603110fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("2984ce3f-eeef-47d3-ad46-71cc20d1a6c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(556, 278),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("513000a2-8111-469f-9f28-2206603110fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6962844b-e4ca-4125-95db-f8d18b9f10b4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("752c1033-e78d-4ea1-bb7f-8fe4a8fe747a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(179, 330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dcb184d-f792-46b2-bfa3-3e1c7727f680"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e490caad-9663-4c7d-8eb7-7d74a0e371fb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("2c7eeba1-189f-4537-8001-dc23033a848a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(282, 332),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e490caad-9663-4c7d-8eb7-7d74a0e371fb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d455ebdd-7742-4448-9885-7fdcfe6ca90f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("2cdd2a77-49b7-46f8-a19a-cee046909ea1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f6f086b1-d81b-4677-9cd2-13aa5e432fcc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3efa8ffc-68de-445d-9bf4-3276b0822758"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("a5c884d7-2de8-43ff-b3cf-6cd724d6de1e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(158, 197),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b7f33856-f183-4b50-b63b-5fd8cf95df69"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b70f049-57bf-4001-8650-605bd41a38e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("6114f49a-16ff-44d3-a726-f59db33f8fd7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(295, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3efa8ffc-68de-445d-9bf4-3276b0822758"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e87d7acc-ab81-402a-b070-24ed8d2d55ef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("15ef114e-779b-4c1d-9bcb-f7e27a29bebc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(302, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b70f049-57bf-4001-8650-605bd41a38e4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0a6b48ab-5d12-4170-be0f-54462cbc4a83"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow12",
				UId = new Guid("d49a5979-c9b4-4566-8255-7db0519fbe77"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(352, 136),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e87d7acc-ab81-402a-b070-24ed8d2d55ef"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("67b85305-c400-4ec9-b661-5512e2b4e41c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow14",
				UId = new Guid("533bbdd4-fb15-4d01-ba27-0542ad625ccb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(350, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0a6b48ab-5d12-4170-be0f-54462cbc4a83"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("67b85305-c400-4ec9-b661-5512e2b4e41c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("d1ff4477-c5cb-478b-984b-55baf28951a4"),
				ConditionExpression = @"PositionSwapped",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(411, 225),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0a6b48ab-5d12-4170-be0f-54462cbc4a83"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0bb7ab3-82a2-4476-834c-072f3754931d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("2a1bb5b7-672b-4ac7-8bd1-02779fbea6e3"),
				ConditionExpression = @"PositionSwapped",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CurveCenterPosition = new Point(412, 116),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e87d7acc-ab81-402a-b070-24ed8d2d55ef"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0bb7ab3-82a2-4476-834c-072f3754931d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b547785e-fae9-402a-ad5f-9bd0a8d95f26"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(784, 961),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("5cb42a0c-9bb7-49d5-8529-fc744fd99407"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("b547785e-fae9-402a-ad5f-9bd0a8d95f26"),
				CreatedInOwnerSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 331),
				Size = new Size(755, 434),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("9a569c51-0124-4a11-9774-24aac81a8ff1"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("b547785e-fae9-402a-ad5f-9bd0a8d95f26"),
				CreatedInOwnerSchemaUId = new Guid("f85ee21c-cb2f-4342-89f7-f424eb6f11d2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 770),
				Size = new Size(755, 191),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("fc94150f-39b2-4d4a-949e-4f3d2578fd65"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b547785e-fae9-402a-ad5f-9bd0a8d95f26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(755, 326),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3ae0b59d-4b9e-48c6-9a00-b6f55247b543"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cb42a0c-9bb7-49d5-8529-fc744fd99407"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(661, 191),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("be886b45-76fc-4861-8586-c5701c2ef493"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ae0b59d-4b9e-48c6-9a00-b6f55247b543"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"StartMessage3",
				Position = new Point(29, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_AddButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03cf0e12-ea14-4439-8f04-239fc312838b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ae0b59d-4b9e-48c6-9a00-b6f55247b543"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"Child_AddButtonClickScriptTask",
				Position = new Point(120, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,218,48,20,125,110,126,133,149,167,68,130,104,221,120,104,69,55,9,1,171,170,117,45,19,176,61,27,231,6,220,38,118,102,59,91,163,138,255,222,235,56,133,132,5,198,75,148,56,190,231,158,143,107,107,163,184,88,19,205,54,144,209,229,93,76,62,19,255,106,144,12,6,171,107,218,31,172,216,167,254,128,173,146,62,189,164,87,125,6,236,195,71,118,137,143,107,230,15,189,199,28,196,188,212,163,56,227,98,41,184,209,247,82,62,23,249,130,234,231,104,166,36,3,173,191,65,137,128,76,10,3,47,230,125,49,186,19,218,80,193,0,219,253,7,133,174,97,70,21,205,192,128,210,136,36,224,47,153,112,102,184,20,84,149,228,70,87,236,123,68,174,158,128,153,47,65,56,244,254,80,69,242,195,186,224,68,81,120,62,131,161,215,70,142,70,113,28,248,59,239,252,222,222,199,176,123,47,196,220,124,151,49,224,214,132,166,26,106,194,9,79,27,10,199,50,77,161,226,123,179,231,125,72,187,18,91,21,235,154,59,234,80,212,238,174,82,156,131,197,128,248,1,187,205,20,207,16,2,113,139,76,252,164,105,1,195,238,202,91,69,49,42,152,87,42,126,20,160,202,154,210,84,24,110,202,198,122,96,157,137,38,212,208,185,44,20,131,200,253,67,78,103,128,90,47,28,153,192,111,58,239,135,195,139,139,99,154,190,86,30,33,159,115,26,140,21,80,3,174,228,23,55,155,125,14,129,91,28,203,44,167,138,107,41,22,101,14,209,244,119,65,211,30,217,177,217,97,219,76,255,229,114,166,76,215,202,69,127,84,17,106,62,25,134,62,83,242,45,24,151,210,126,124,130,165,182,74,133,112,159,97,59,117,235,248,227,234,73,223,115,109,234,152,71,74,209,210,126,219,225,74,36,154,200,54,36,56,197,142,112,113,156,121,72,94,189,139,174,118,221,142,212,101,86,73,99,84,219,35,130,167,44,68,110,91,207,75,26,230,182,239,133,195,163,98,89,188,250,172,149,56,230,218,57,8,15,210,84,179,176,237,217,154,20,18,51,125,201,21,222,90,8,237,72,205,168,217,96,181,143,76,220,166,66,195,132,235,60,165,101,197,247,253,104,111,123,196,254,85,124,189,105,96,236,6,177,218,171,27,227,213,242,103,33,171,40,130,112,187,181,243,209,117,149,184,91,170,30,49,219,212,189,161,57,10,76,161,4,49,10,207,249,27,76,202,247,24,224,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenSysAdminUnitsLookupTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c3eafc34-80cf-431a-94ba-780c41eddfbf"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ae0b59d-4b9e-48c6-9a00-b6f55247b543"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"OpenSysAdminUnitsLookupTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 58),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenSysAdminUnitsLookupTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("513000a2-8111-469f-9f28-2206603110fc"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ae0b59d-4b9e-48c6-9a00-b6f55247b543"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"IntermediateCatchMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(393, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_AddButtonClickScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6962844b-e4ca-4125-95db-f8d18b9f10b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ae0b59d-4b9e-48c6-9a00-b6f55247b543"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"Child_AddButtonClickScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(491, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,93,79,227,48,16,124,6,137,255,224,227,201,21,145,197,59,119,72,168,237,161,136,175,138,192,189,155,120,75,125,52,118,101,175,91,162,19,255,253,214,137,83,194,165,28,170,20,41,137,119,103,102,51,155,89,75,199,148,68,89,216,224,74,96,63,216,76,62,131,152,108,79,206,142,14,215,212,226,97,9,37,130,42,106,127,161,42,109,30,141,70,79,221,124,162,75,212,214,72,87,127,247,232,180,121,206,152,125,250,77,189,231,35,126,183,2,243,1,112,109,237,75,88,61,72,255,34,46,1,139,196,249,75,46,3,120,254,232,193,141,173,49,208,16,142,70,157,114,34,32,50,39,99,37,87,164,219,97,111,173,130,153,211,21,233,143,237,50,84,166,33,75,80,67,141,167,233,121,229,96,221,32,73,248,167,118,30,47,157,52,8,144,43,190,67,161,19,47,131,115,96,176,5,6,173,196,45,108,226,157,199,134,182,197,118,40,255,96,139,133,158,99,171,113,15,165,117,170,59,219,165,145,177,211,150,101,110,29,200,114,193,120,255,115,163,95,185,42,208,49,109,118,187,47,174,160,246,35,246,231,232,240,96,8,164,33,12,108,154,153,249,128,50,202,30,236,244,54,153,50,252,13,68,81,46,160,146,98,76,163,34,76,13,106,172,255,221,88,100,253,140,81,20,128,19,152,247,118,228,249,151,128,94,55,63,206,213,113,246,190,143,253,176,197,208,125,34,251,100,239,251,211,182,198,246,24,219,131,253,200,198,210,76,95,161,12,8,68,132,46,192,126,240,153,245,58,214,9,108,78,78,190,192,202,53,180,238,211,245,30,126,113,109,165,186,183,27,254,209,101,61,103,60,165,231,91,74,193,180,90,97,221,254,122,125,252,141,37,222,45,56,75,153,203,88,142,80,197,90,55,163,184,120,162,183,134,252,173,29,98,155,206,45,58,22,255,155,190,183,24,157,56,155,97,231,148,164,102,152,38,107,157,138,231,131,104,146,55,9,234,0,131,51,141,207,103,127,1,40,44,160,134,3,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5d4c62e3-1167-4119-ad82-38d2296e5cd7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a569c51-0124-4a11-9774-24aac81a8ff1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(64, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3a4a473-b3ed-4c6b-a79f-bc5c52aafabd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d4c62e3-1167-4119-ad82-38d2296e5cd7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(7, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("83ea4044-3639-469b-b88f-4c02f1df6f14"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d4c62e3-1167-4119-ad82-38d2296e5cd7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_InitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b37a4ab8-25d2-4b0d-bc70-7449320fa68a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d4c62e3-1167-4119-ad82-38d2296e5cd7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"Child_InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,209,110,155,48,20,125,134,175,176,120,2,45,226,3,70,219,41,34,81,139,212,109,81,155,109,207,46,190,69,94,29,27,25,211,4,77,251,247,93,219,36,1,66,186,55,108,142,207,57,247,92,251,110,104,5,233,86,3,220,107,206,210,98,135,203,71,222,24,114,75,162,45,104,77,27,245,106,210,95,240,178,172,235,40,11,55,35,244,61,152,39,181,207,149,124,229,213,3,149,76,128,38,159,110,9,3,1,21,53,16,175,165,225,166,35,90,237,19,242,39,8,130,48,104,140,230,178,34,181,230,59,170,187,92,137,118,39,191,209,29,88,185,130,69,217,53,204,79,42,90,4,5,72,101,85,7,155,241,5,87,146,110,213,179,227,136,147,44,12,222,169,38,165,179,136,34,18,246,100,69,13,125,86,173,46,225,100,62,190,20,75,156,151,23,165,4,158,30,88,32,189,133,109,87,3,27,224,111,44,244,46,142,114,42,215,7,40,91,3,17,82,120,121,142,250,205,81,157,151,134,43,137,98,55,190,208,5,113,161,123,35,142,234,46,78,134,65,120,249,2,57,28,176,143,107,104,234,11,137,150,66,160,175,90,86,17,249,76,162,21,200,206,45,28,143,179,48,209,232,221,76,165,227,25,49,27,226,244,120,186,226,77,45,104,231,64,223,165,232,144,207,232,22,230,160,14,179,81,13,183,117,35,110,180,78,115,144,6,180,243,233,98,74,151,140,141,82,92,92,120,63,118,213,226,243,15,58,123,172,164,25,22,232,68,124,190,254,86,88,193,254,22,156,9,143,18,204,151,105,43,44,62,110,162,111,191,61,55,61,51,83,145,141,234,154,196,255,42,90,205,226,125,113,83,46,171,113,81,229,188,160,133,106,48,173,150,253,107,201,194,191,253,123,63,155,72,31,21,101,192,236,35,31,79,2,11,241,255,178,112,50,36,150,191,233,97,253,142,93,110,176,215,66,88,201,92,240,242,45,117,155,150,106,180,221,207,145,233,168,185,206,114,48,154,110,168,198,139,138,247,200,135,109,147,59,15,175,31,133,157,95,88,165,209,74,224,241,227,199,233,80,28,73,197,0,199,207,130,156,191,78,127,191,226,78,250,68,247,9,38,20,246,9,185,171,254,15,233,187,210,13,58,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5303e93c-0179-420c-9bc0-2118f6891f50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cb42a0c-9bb7-49d5-8529-fc744fd99407"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 224),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(336, 196),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4dcb184d-f792-46b2-bfa3-3e1c7727f680"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5303e93c-0179-420c-9bc0-2118f6891f50"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"StartMessage4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e490caad-9663-4c7d-8eb7-7d74a0e371fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5303e93c-0179-420c-9bc0-2118f6891f50"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_DeleteYesMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d455ebdd-7742-4448-9885-7fdcfe6ca90f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5303e93c-0179-420c-9bc0-2118f6891f50"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"Child_DeleteYesMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,49,10,128,48,12,5,208,221,83,56,234,25,58,58,184,149,130,224,30,236,31,2,105,2,105,50,232,233,125,175,154,15,18,254,112,58,105,0,205,38,7,155,206,237,130,224,9,244,106,29,205,121,144,191,135,73,14,189,73,18,123,89,28,145,174,107,120,162,252,143,94,224,26,71,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc94150f-39b2-4d4a-949e-4f3d2578fd65"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"EventSubProcess10",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(437, 303),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f6f086b1-d81b-4677-9cd2-13aa5e432fcc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"StartMessage5",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3efa8ffc-68de-445d-9bf4-3276b0822758"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"UpButtonClickScriptTask",
				Position = new Point(112, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,79,44,40,72,77,113,47,74,204,43,73,77,245,76,81,176,85,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,76,46,201,44,75,13,202,47,15,40,202,204,77,44,170,116,206,207,41,205,205,11,75,204,41,77,181,230,10,200,47,206,44,201,204,207,11,134,152,3,212,14,98,193,68,139,53,130,209,204,215,81,48,212,180,230,42,74,45,41,45,202,83,40,41,2,26,1,0,137,211,90,18,130,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b7f33856-f183-4b50-b63b-5fd8cf95df69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"StartMessage6",
				Position = new Point(35, 231),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDownButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b70f049-57bf-4001-8650-605bd41a38e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"DownButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 217),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,79,44,40,72,77,113,47,74,204,43,73,77,245,76,81,176,85,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,76,46,201,44,75,13,202,47,15,40,202,204,77,44,170,116,206,207,41,205,205,11,75,204,41,77,181,230,10,200,47,206,44,201,204,207,11,134,152,3,212,14,98,193,68,139,53,130,209,204,215,81,208,53,212,180,230,42,74,45,41,45,202,83,40,41,2,154,1,0,107,116,37,196,131,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("e87d7acc-ab81-402a-b070-24ed8d2d55ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("0a6b48ab-5d12-4170-be0f-54462cbc4a83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"ExclusiveGateway4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 217),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("67b85305-c400-4ec9-b661-5512e2b4e41c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"End1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(266, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpDownButtonsClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f0bb7ab3-82a2-4476-834c-072f3754931d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8358acfb-8f46-4b3b-b3d5-125d100e6959"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Name = @"UpDownButtonsClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(336, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,187,10,2,49,16,69,123,191,194,114,109,242,3,91,45,17,150,5,139,96,196,126,200,92,36,144,199,50,59,113,241,239,213,62,98,123,15,231,112,29,61,96,110,2,204,18,217,216,4,146,225,52,30,220,119,62,147,146,175,77,2,204,165,18,95,235,190,245,152,71,66,80,240,162,200,78,98,38,121,217,154,90,46,119,74,13,219,239,232,63,113,98,30,252,78,235,10,158,133,138,2,11,119,51,106,83,68,209,41,104,124,226,115,179,103,9,180,73,57,170,52,140,111,128,219,192,121,245,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateShiftPositionsMethod());
			Methods.Add(CreateGetFirstGranteeIdMethod());
			Methods.Add(CreateNormalizeGranteePositionsMethod());
			Methods.Add(CreateCellIconClickHandlerMethod());
			Methods.Add(CreateSwapPositionsMethod());
			Methods.Add(CreateGetSysAdminOperationGranteeMaxPositionMethod());
			Methods.Add(CreateGetGranteeIdByPositionMethod());
			Methods.Add(CreateGetRecordsToShiftMethod());
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
				UId = new Guid("c59e253d-6539-4393-97c3-1283456a4b7e"),
				Name = "System.Collections",
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("84cc163e-3f08-46a1-98d4-5a2269855f7c"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
			});
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,76,46,201,44,75,44,73,117,42,45,41,201,207,43,214,72,132,242,53,173,121,185,2,18,211,83,245,66,11,32,82,122,174,121,137,73,57,169,41,10,182,10,96,113,151,212,156,84,152,54,152,28,76,143,75,126,121,30,9,186,0,32,25,58,160,137,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
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

		protected virtual SchemaMethod CreateShiftPositionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5eafbec6-3300-4d2a-bc04-bb810309aaf8"),
				Name = "ShiftPositions",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f253b4c1-5446-40f4-9e37-66d17d6b64c9"),
				Name = "recordsToShift",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1cedf8f-c3ef-49f6-92ca-4366e40da5e2"),
				Name = "shiftValue",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,203,47,74,77,76,206,208,40,75,44,82,200,47,72,45,74,44,201,204,207,115,47,74,204,43,73,77,85,200,204,83,40,74,77,206,47,74,41,14,201,15,206,200,76,43,209,84,224,229,170,230,229,226,68,87,169,23,156,90,226,156,159,83,154,155,23,150,152,83,154,170,161,20,144,95,156,9,146,87,210,193,48,85,207,61,181,36,164,178,32,53,5,73,131,77,102,94,137,29,146,46,77,5,109,133,98,144,133,96,89,77,107,172,86,38,150,165,106,128,164,106,1,119,83,39,11,196,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFirstGranteeIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0c64d66e-01a8-40fe-93fd-90a8076380a1"),
				Name = "GetFirstGranteeId",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4db96f25-f033-4466-a3a6-7813e912f7d2"),
				Name = "sysAdminOperationId",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,201,78,195,48,16,61,167,82,255,193,202,201,190,88,112,142,122,104,154,80,245,212,138,6,56,32,14,110,60,128,165,196,14,99,59,16,33,254,29,187,9,45,155,228,101,150,55,111,182,94,32,65,176,190,113,100,65,214,94,73,94,182,157,27,178,249,172,15,30,11,13,212,209,163,225,149,236,143,10,189,177,128,43,163,117,144,149,209,140,87,166,163,151,140,175,76,227,91,77,211,141,76,25,191,66,211,210,116,63,216,165,108,149,222,118,128,34,130,215,40,180,3,8,128,187,103,64,248,7,113,140,222,216,242,197,139,134,142,148,124,39,80,180,224,0,169,253,11,103,140,111,81,2,230,195,210,214,52,221,25,171,162,35,101,68,216,169,226,208,139,183,74,63,17,90,228,229,27,212,222,25,36,242,112,18,23,228,103,75,188,212,214,35,20,249,217,68,25,35,239,243,89,50,241,196,209,72,225,196,53,136,144,58,16,140,115,226,35,37,140,102,122,78,49,69,39,234,145,208,115,28,143,223,23,115,146,156,182,240,171,154,34,175,134,14,130,161,7,12,67,8,250,173,104,60,84,38,110,235,27,221,253,197,3,203,34,211,71,120,194,13,7,193,121,212,211,126,179,79,224,208,140,224,235,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNormalizeGranteePositionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc317529-140e-4c79-9641-ee972e80e401"),
				Name = "NormalizeGranteePositions",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("06ea3941-b0dc-4365-8650-31dd0bacd666"),
				Name = "sysAdminOperationId",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,75,107,219,64,16,62,219,224,255,176,213,73,34,102,147,244,88,39,1,87,113,141,160,96,183,206,227,16,122,216,106,199,210,130,180,171,238,163,173,8,249,239,221,135,100,172,196,14,166,39,177,210,204,55,223,99,86,231,231,119,171,219,213,39,36,97,75,114,45,36,98,91,212,8,165,216,207,10,38,227,223,68,34,213,170,57,173,25,95,53,32,137,102,130,47,37,225,26,96,147,151,80,147,111,6,100,139,174,17,135,63,104,193,53,211,237,222,251,120,77,10,192,183,68,147,141,48,50,7,28,190,37,179,201,248,4,84,60,167,52,21,149,169,121,28,101,52,250,143,174,181,80,204,85,69,9,94,73,10,242,115,59,87,121,236,128,14,10,203,232,23,86,105,144,86,206,41,131,82,9,68,67,104,121,100,186,92,19,73,106,176,7,21,135,151,169,168,27,34,153,18,252,174,109,0,47,126,25,82,77,81,180,121,141,29,77,15,113,57,85,111,152,165,156,238,248,168,164,163,154,59,64,117,162,230,37,232,144,178,181,184,130,220,85,197,247,202,73,229,60,28,221,164,48,171,233,220,247,190,116,43,226,81,118,70,217,132,46,173,248,139,158,93,17,6,102,244,221,150,143,182,101,105,24,197,139,186,209,109,223,107,26,106,211,232,122,238,253,225,21,179,67,214,119,18,163,100,50,30,225,13,232,189,157,153,14,5,248,138,199,18,36,132,109,196,153,242,129,198,67,210,9,34,170,27,63,67,35,103,197,214,94,170,216,49,100,150,220,197,204,62,174,142,199,128,83,97,184,182,69,103,103,9,122,182,35,237,117,124,155,106,95,253,196,126,184,68,220,118,117,59,255,64,42,3,87,140,235,155,253,237,71,31,174,17,11,120,35,199,68,66,46,36,205,232,59,161,31,197,118,206,223,56,11,46,253,141,28,141,134,250,177,175,178,192,253,12,95,51,112,114,87,194,252,183,16,28,94,252,133,220,216,204,2,232,142,206,87,81,20,32,113,198,149,38,220,254,65,236,121,200,247,59,43,74,157,150,132,23,111,243,238,57,76,145,150,6,60,242,203,100,252,242,15,179,32,225,98,244,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCellIconClickHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c19e02f7-e52b-49d9-8d70-5df801df459e"),
				Name = "CellIconClickHandler",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6cc5f9a2-8799-4cf6-bed8-62e46cc91dab"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eefd1fb8-caf6-41ad-a85b-2ccfc783eb2d"),
				Name = "e",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,203,78,195,48,16,69,215,205,87,184,89,57,82,149,31,40,69,130,36,141,64,72,84,20,216,32,22,131,61,165,150,18,79,229,140,67,3,234,191,147,71,161,128,20,177,246,61,103,238,117,13,78,88,210,120,165,197,66,96,156,237,217,193,10,28,148,200,232,170,167,112,120,11,159,231,129,217,8,121,76,78,23,194,250,162,136,196,71,48,169,91,129,67,69,78,247,10,153,123,163,163,235,138,108,156,98,133,206,64,97,222,241,8,206,4,55,59,164,205,16,138,230,3,93,53,213,133,46,141,189,221,161,3,54,100,115,7,150,17,91,219,10,94,49,78,129,97,77,222,41,140,215,106,139,37,196,137,67,96,204,44,27,110,228,67,123,37,33,107,81,117,108,39,237,154,142,73,227,37,178,218,46,29,149,233,165,252,234,29,245,75,250,50,10,108,182,71,229,185,59,63,42,201,145,239,219,37,58,161,194,151,246,17,10,143,103,47,68,197,185,12,147,111,65,216,117,153,140,58,214,200,63,240,95,224,76,76,79,61,254,177,64,141,178,143,252,253,171,27,2,125,71,111,167,145,109,232,16,28,62,1,103,236,202,57,241,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSwapPositionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("28873e7b-eb8e-4bdc-9267-1e5f85072fea"),
				Name = "SwapPositions",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1189f917-96d5-487a-bf1d-7b6ae2e3e5a3"),
				Name = "sysAdminOperationGranteeId",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d0bcb78f-3666-4f74-ae3f-b566aa39e551"),
				Name = "shiftValue",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,209,110,155,48,20,125,78,165,254,131,197,19,72,153,181,237,53,77,165,133,164,81,164,77,203,70,219,61,187,112,3,150,192,102,246,245,90,52,237,223,103,3,33,16,74,170,189,76,74,80,236,156,123,206,185,231,26,63,73,153,19,5,218,228,72,150,228,192,114,13,139,235,171,95,76,17,93,233,79,73,193,197,215,18,20,67,46,197,86,49,129,0,22,182,103,41,208,53,67,22,73,163,98,160,81,156,65,193,104,168,128,33,108,4,114,172,252,7,13,42,148,66,64,236,106,3,75,202,15,196,159,34,165,119,128,113,118,167,100,177,94,77,130,118,73,16,144,223,215,87,51,103,79,230,201,94,106,238,254,182,142,38,121,183,128,247,85,9,73,40,115,83,136,71,150,27,184,225,2,111,125,239,88,237,57,111,53,165,128,231,30,101,95,224,29,209,25,63,96,93,238,208,174,149,62,250,118,73,222,55,214,102,175,70,183,75,254,213,227,214,240,196,154,140,198,76,141,223,90,167,96,47,61,195,150,102,4,111,37,190,156,128,227,116,109,172,53,227,121,83,55,203,190,64,219,94,211,223,51,43,173,223,41,181,186,91,235,166,91,174,170,75,234,243,126,240,193,194,106,116,66,101,187,187,103,138,21,150,212,2,201,55,3,170,170,55,0,65,217,57,126,240,206,24,186,242,244,104,224,98,253,71,91,127,225,200,157,232,76,153,216,243,221,210,60,212,139,179,99,62,39,227,137,181,76,94,64,35,192,222,177,155,15,187,11,232,143,12,20,248,158,155,48,221,233,205,79,195,114,127,216,65,64,152,110,133,23,164,73,201,104,46,82,127,189,218,188,64,108,80,42,146,60,117,63,151,100,232,142,110,132,54,10,214,171,211,150,31,28,231,58,59,21,210,8,153,194,123,43,173,89,139,106,66,152,53,9,208,6,8,221,118,215,235,103,153,166,160,232,78,104,100,194,94,12,118,61,12,227,59,79,51,12,51,38,210,113,116,211,51,152,19,84,6,142,106,131,216,104,253,186,12,95,215,22,55,204,174,3,190,121,120,255,75,175,111,153,24,182,220,155,77,40,139,130,191,58,156,238,22,119,149,205,222,31,247,116,15,251,181,31,5,104,148,104,175,251,197,95,89,249,177,212,251,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysAdminOperationGranteeMaxPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("09026029-7a34-4f27-a78b-95f1e24fa20d"),
				Name = "GetSysAdminOperationGranteeMaxPosition",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("10b0e782-c0a1-46e6-8763-4ab2a2e1a7dd"),
				Name = "sysAdminOperationId",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,75,79,195,48,12,62,119,210,254,67,212,83,114,32,98,231,106,7,186,22,212,211,38,86,224,128,56,132,214,64,165,54,41,78,82,168,16,255,29,151,150,117,3,164,60,236,207,246,231,87,167,144,33,88,95,59,182,102,103,171,104,185,232,8,177,80,67,49,32,26,222,216,254,91,225,55,22,112,99,180,38,185,50,90,200,220,180,124,37,228,198,212,190,209,60,220,25,91,13,134,80,200,75,52,13,15,247,189,189,40,155,74,111,91,64,53,88,174,80,105,7,64,14,119,47,128,240,143,71,86,146,49,179,233,171,87,53,31,137,229,78,161,106,192,1,114,251,215,93,8,185,197,18,48,238,19,176,197,113,17,76,217,169,112,106,201,219,74,63,51,158,196,233,59,20,222,25,100,229,227,65,92,179,211,206,100,170,173,71,72,226,25,226,66,176,143,229,34,152,120,134,9,149,202,169,107,80,148,155,8,198,113,201,145,18,70,152,207,41,166,232,160,122,98,124,142,147,195,247,195,28,4,135,37,252,170,38,137,243,190,5,2,58,64,154,2,233,183,170,246,144,155,76,187,35,182,251,243,7,17,13,68,159,244,208,165,131,224,60,234,105,187,209,23,161,159,60,216,233,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetGranteeIdByPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("be9b9ee1-cb4b-4fad-a362-5ff68b83a7f2"),
				Name = "GetGranteeIdByPosition",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ad86d8c3-413d-48a9-80dc-d893eea3dacc"),
				Name = "sysAdminOperationId",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d5024ddf-07da-4168-88ad-8e2cd0ba6c5b"),
				Name = "position",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,203,10,194,48,16,69,215,21,250,15,161,171,100,147,31,240,1,165,84,113,165,80,196,245,208,14,88,72,38,117,146,248,248,123,155,182,59,197,221,204,220,195,129,59,15,96,193,232,163,9,98,43,14,177,239,116,109,135,240,94,231,171,199,152,120,52,216,166,132,240,41,154,105,145,23,143,92,57,162,113,238,29,169,124,149,101,186,114,38,90,146,197,177,43,210,65,239,217,89,89,52,111,95,118,182,167,211,128,12,9,62,48,80,64,156,153,235,13,25,127,64,201,161,143,190,190,71,48,114,22,235,51,48,88,12,200,210,127,227,106,210,149,212,201,226,236,124,159,142,255,12,195,194,40,37,192,47,165,198,186,140,33,50,45,141,117,253,194,54,6,108,90,48,192,155,244,151,157,84,35,245,1,206,65,184,238,47,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRecordsToShiftMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d31dc169-e9b1-4cbc-8488-85391bb6ac97"),
				Name = "GetRecordsToShift",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				ResultValueTypeName = "EntityCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e33952b3-d031-42b0-aefa-821cc9d95eb5"),
				Name = "sysAdminOperationId",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a7f7751d-a28c-4601-b142-356d3cc94779"),
				Name = "startPosition",
				CreatedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				ModifiedInSchemaUId = new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,145,193,106,195,48,16,68,239,133,254,131,240,73,134,224,31,8,61,184,198,53,57,164,73,112,75,207,139,189,36,2,105,229,174,214,45,250,251,218,81,5,33,189,246,168,209,147,102,152,249,2,86,1,252,185,237,79,234,73,17,126,171,150,196,72,236,135,11,58,56,205,200,81,191,7,228,198,19,225,32,198,83,117,11,236,129,224,140,92,117,40,59,10,2,52,224,115,124,5,135,186,232,99,168,71,103,232,48,33,195,250,176,99,32,65,44,202,114,171,30,31,126,77,171,122,28,107,107,211,111,141,183,179,163,160,23,224,134,120,49,86,144,195,74,234,172,53,140,32,152,110,62,140,92,142,192,139,233,138,233,36,54,222,77,192,38,120,122,139,19,86,237,231,12,118,163,254,134,42,54,42,220,107,187,113,137,248,191,254,221,149,231,3,231,32,71,31,76,246,23,96,201,231,171,51,163,204,76,121,151,181,220,212,249,210,143,77,35,220,109,82,110,127,0,34,169,139,89,200,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeOperationsGranteePageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2cb9fa7-3327-4c26-b12f-3d320431c52c"));
		}

		#endregion

	}

	#endregion

}

