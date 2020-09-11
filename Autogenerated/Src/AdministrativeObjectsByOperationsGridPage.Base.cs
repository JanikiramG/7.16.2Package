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
	using System.Security;
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
	using Terrasoft.Core.Packages;
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

	#region Class: AdministrativeObjectsByOperationsGridPageSchema

	/// <exclude/>
	public class AdministrativeObjectsByOperationsGridPageSchema : Terrasoft.WebApp.AdministrativeByOperationsGridPageSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsByOperationsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectsByOperationsGridPageSchema(AdministrativeObjectsByOperationsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Hidden = false;
			AddButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.Hidden = false;
			DeleteButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateUpButton() {
			UpButton.AjaxEvents.Click.IsProcessEventHandler = true;
			UpButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			UpButton.Hidden = false;
			UpButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateDownButton() {
			DownButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			DownButton.Hidden = false;
			DownButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateShowRelatedRightsCheckBox() {
			ShowRelatedRightsCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateCheckBoxControlLayout() {
			CheckBoxControlLayout.Image = new ControlImage {};
			CheckBoxControlLayout.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateOwnMenuItem() {
			OwnMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			OwnMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			OwnMenuItem.Image = new ControlImage {};
			OwnMenuItem.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateAllMenuItem() {
			AllMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			AllMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			AllMenuItem.Image = new ControlImage {};
			AllMenuItem.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateShowRelatedRightsButton() {
			ShowRelatedRightsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				ImageHash = @"57f7aae3209afa943cac8813eca36f32"
			};
			ShowRelatedRightsButton.Hidden = true;
			ShowRelatedRightsButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
			RealUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
			Name = "AdministrativeObjectsByOperationsGridPage";
			ParentSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectsByOperationsGridPageEventsProcessSchema();
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
			UpdateShowRelatedRightsButton();
			UpdateAllMenuItem();
			UpdateOwnMenuItem();
			UpdatePrintButton();
			UpdateCheckBoxControlLayout();
			UpdateShowRelatedRightsCheckBox();
			UpdateDownButton();
			UpdateUpButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, UpButton);
			ButtonsControlLayout.MoveItem(5, DownButton);
			ButtonsControlLayout.MoveItem(6, CheckBoxControlLayout);
			CheckBoxControlLayout.MoveItem(0, ShowRelatedRightsCheckBox);
			ButtonsControlLayout.MoveItem(7, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.MoveItem(9, ShowRelatedRightsButton);
			ShowRelatedRightsButton.MoveItem(0, OwnMenuItem);
			ShowRelatedRightsButton.MoveItem(1, AllMenuItem);
			ButtonsControlLayout.MoveItem(10, ContextHelpButton);
			ButtonsControlLayout.MoveItem(11, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectsByOperationsGridPageEventsProcessSchema() {
			var schema = new AdministrativeObjectsByOperationsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsVisible = false;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("d27e9964-a7a6-46dd-9f9a-7cb470c33b98");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectsByOperationsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectsByOperationsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e327907-418e-4f94-ada1-246b9ff75a45"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectsByOperationsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByOperationsGridPageEventsProcess<TPage> : Terrasoft.WebApp.AdministrativeByOperationsGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskChildFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskChildFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskChildFlowElement(UserConnection userConnection, AdministrativeObjectsByOperationsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTaskChild";
				IsLogging = false;
				SchemaElementUId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AdministrativeObjectsByOperationsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectsByOperationsGridPageEventsProcess";
			SchemaUId = new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2e327907-418e-4f94-ada1-246b9ff75a45");
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

		public virtual bool IsOperationAdministrated {
			get;
			set;
		}

		public virtual Object IconColumnNames {
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
					SchemaElementUId = new Guid("10921545-eb72-4c7c-9057-eda2d81f3c4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startTreeGridSelectionChange;
		public ProcessFlowElement StartTreeGridSelectionChange {
			get {
				return _startTreeGridSelectionChange ?? (_startTreeGridSelectionChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartTreeGridSelectionChange",
					SchemaElementUId = new Guid("03adef71-d7ac-456b-8e6a-4c11035e1556"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTreeGridSelectionChange;
		public ProcessScriptTask ScriptTreeGridSelectionChange {
			get {
				return _scriptTreeGridSelectionChange ?? (_scriptTreeGridSelectionChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTreeGridSelectionChange",
					SchemaElementUId = new Guid("c6769a3f-1fa9-421c-8dbe-4b0a8f83baed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTreeGridSelectionChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess134534;
		public ProcessFlowElement EventSubProcess134534 {
			get {
				return _eventSubProcess134534 ?? (_eventSubProcess134534 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess134534",
					SchemaElementUId = new Guid("3217d55b-13ba-4501-9e63-ddddfb6ae1da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childStartMessageSelectSchemaForAddRights;
		public ProcessFlowElement ChildStartMessageSelectSchemaForAddRights {
			get {
				return _childStartMessageSelectSchemaForAddRights ?? (_childStartMessageSelectSchemaForAddRights = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildStartMessageSelectSchemaForAddRights",
					SchemaElementUId = new Guid("6c7f5a32-1b76-4ae6-9941-e1fad6cb7397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwMessageSelectSchemaForAddRights;
		public ProcessThrowMessageEvent ThrowMessageSelectSchemaForAddRights {
			get {
				return _throwMessageSelectSchemaForAddRights ?? (_throwMessageSelectSchemaForAddRights = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowMessageSelectSchemaForAddRights",
					SchemaElementUId = new Guid("e55b0790-82a9-4738-ab92-0ddbf497eec2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SelectSchemaForAddRights",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childSelectSchemaForAddRightsScriptTask;
		public ProcessScriptTask ChildSelectSchemaForAddRightsScriptTask {
			get {
				return _childSelectSchemaForAddRightsScriptTask ?? (_childSelectSchemaForAddRightsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildSelectSchemaForAddRightsScriptTask",
					SchemaElementUId = new Guid("7bbc11b0-10d5-4226-a713-a88b4dd0d755"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildSelectSchemaForAddRightsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess12;
		public ProcessFlowElement SubProcess12 {
			get {
				return _subProcess12 ?? (_subProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess12",
					SchemaElementUId = new Guid("c723a602-cec3-456b-a10a-257f1216d2d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initChildChild;
		public ProcessFlowElement InitChildChild {
			get {
				return _initChildChild ?? (_initChildChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitChildChild",
					SchemaElementUId = new Guid("786d06ab-937d-4bc6-8d0b-02bf9b8d1da5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInitChildChild;
		public ProcessScriptTask ScriptInitChildChild {
			get {
				return _scriptInitChildChild ?? (_scriptInitChildChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInitChildChild",
					SchemaElementUId = new Guid("86513901-ebc5-4558-ac88-996ee463206c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitChildChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwInitChildParent;
		public ProcessThrowMessageEvent ThrowInitChildParent {
			get {
				return _throwInitChildParent ?? (_throwInitChildParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowInitChildParent",
					SchemaElementUId = new Guid("c3ef0722-3edd-40c2-af75-ca2674bd5890"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptBindTreeGridEvents;
		public ProcessScriptTask ScriptBindTreeGridEvents {
			get {
				return _scriptBindTreeGridEvents ?? (_scriptBindTreeGridEvents = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptBindTreeGridEvents",
					SchemaElementUId = new Guid("969193e8-87ce-4bd0-8f7c-60c196e6751b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptBindTreeGridEventsExecute,
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
					SchemaElementUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
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
					SchemaElementUId = new Guid("260c63c6-8e63-476e-9096-bd6a56b2a537"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initOpenLookupUserTaskChildScript;
		public ProcessScriptTask InitOpenLookupUserTaskChildScript {
			get {
				return _initOpenLookupUserTaskChildScript ?? (_initOpenLookupUserTaskChildScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitOpenLookupUserTaskChildScript",
					SchemaElementUId = new Guid("c9be5cf9-cdd3-4e93-abd6-d1744a714007"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitOpenLookupUserTaskChildScriptExecute,
				});
			}
		}

		private OpenLookupUserTaskChildFlowElement _openLookupUserTaskChild;
		public OpenLookupUserTaskChildFlowElement OpenLookupUserTaskChild {
			get {
				return _openLookupUserTaskChild ?? (_openLookupUserTaskChild = new OpenLookupUserTaskChildFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _initializeChild;
		public ProcessIntermediateCatchMessageEvent InitializeChild {
			get {
				return _initializeChild ?? (_initializeChild = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "InitializeChild",
					SchemaElementUId = new Guid("45cfec37-ed84-4f4b-b5df-78342afd3479"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Initialize",
				});
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
					SchemaElementUId = new Guid("633bc9ea-a1a4-4cf4-a058-8d848040a587"),
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
					SchemaElementUId = new Guid("52943689-06a1-461e-a2ae-7eef6d947208"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ApplyDataScriptChildExecute,
				});
			}
		}

		private ProcessExclusiveEventBasedGateway _eventBasedGateway3;
		public ProcessExclusiveEventBasedGateway EventBasedGateway3 {
			get {
				return _eventBasedGateway3 ?? (_eventBasedGateway3 = new ProcessExclusiveEventBasedGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventBasedGateway",
					Name = "EventBasedGateway3",
					SchemaElementUId = new Guid("1be2adcb-2e89-4bbf-8c21-5f1130097311"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Events = new Collection<string> { "InitializeChild", "LookupGridPageClosedChild", },
				});
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
					SchemaElementUId = new Guid("bf16a3d6-b06c-43f1-a758-981e8748766b"),
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
					SchemaElementUId = new Guid("44de8433-698a-43c2-88e1-113ef5400685"),
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
					SchemaElementUId = new Guid("d651b62a-e3ff-45f0-a377-17565443b26d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteButtonClickChildExecute,
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
					SchemaElementUId = new Guid("e213a9ff-4bd1-4a01-b764-63798b78709f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _gridPageRefreshRowChild;
		public ProcessFlowElement GridPageRefreshRowChild {
			get {
				return _gridPageRefreshRowChild ?? (_gridPageRefreshRowChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridPageRefreshRowChild",
					SchemaElementUId = new Guid("e086a05a-ed48-437d-9881-81b7e77261db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGridPageRefreshRowChild;
		public ProcessScriptTask ScriptGridPageRefreshRowChild {
			get {
				return _scriptGridPageRefreshRowChild ?? (_scriptGridPageRefreshRowChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGridPageRefreshRowChild",
					SchemaElementUId = new Guid("bd9b866a-cc6e-4804-8d72-824fa052b920"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridPageRefreshRowChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwGridPageRefreshRowParent;
		public ProcessThrowMessageEvent ThrowGridPageRefreshRowParent {
			get {
				return _throwGridPageRefreshRowParent ?? (_throwGridPageRefreshRowParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowGridPageRefreshRowParent",
					SchemaElementUId = new Guid("229508be-1adb-4ca0-9d6b-81dc9045a498"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptSetIsAdministratedByOperations;
		public ProcessScriptTask ScriptSetIsAdministratedByOperations {
			get {
				return _scriptSetIsAdministratedByOperations ?? (_scriptSetIsAdministratedByOperations = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSetIsAdministratedByOperations",
					SchemaElementUId = new Guid("0fe704fa-30d0-4e39-b7d3-81889b183ca2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSetIsAdministratedByOperationsExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartTreeGridSelectionChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartTreeGridSelectionChange };
			FlowElements[ScriptTreeGridSelectionChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTreeGridSelectionChange };
			FlowElements[EventSubProcess134534.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess134534 };
			FlowElements[ChildStartMessageSelectSchemaForAddRights.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildStartMessageSelectSchemaForAddRights };
			FlowElements[ThrowMessageSelectSchemaForAddRights.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowMessageSelectSchemaForAddRights };
			FlowElements[ChildSelectSchemaForAddRightsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildSelectSchemaForAddRightsScriptTask };
			FlowElements[SubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess12 };
			FlowElements[InitChildChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitChildChild };
			FlowElements[ScriptInitChildChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitChildChild };
			FlowElements[ThrowInitChildParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowInitChildParent };
			FlowElements[ScriptBindTreeGridEvents.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptBindTreeGridEvents };
			FlowElements[SubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess13 };
			FlowElements[OpenVwSysSchemaInSolutionChild.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenVwSysSchemaInSolutionChild };
			FlowElements[InitOpenLookupUserTaskChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitOpenLookupUserTaskChildScript };
			FlowElements[OpenLookupUserTaskChild.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTaskChild };
			FlowElements[InitializeChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitializeChild };
			FlowElements[LookupGridPageClosedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosedChild };
			FlowElements[ApplyDataScriptChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyDataScriptChild };
			FlowElements[EventBasedGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventBasedGateway3 };
			FlowElements[SubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess14 };
			FlowElements[DeleteButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickChild };
			FlowElements[ScriptDeleteButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteButtonClickChild };
			FlowElements[SubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess15 };
			FlowElements[GridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { GridPageRefreshRowChild };
			FlowElements[ScriptGridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridPageRefreshRowChild };
			FlowElements[ThrowGridPageRefreshRowParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowGridPageRefreshRowParent };
			FlowElements[ScriptSetIsAdministratedByOperations.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSetIsAdministratedByOperations };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess8":
						break;
					case "StartTreeGridSelectionChange":
						e.Context.QueueTasks.Enqueue("ScriptTreeGridSelectionChange");
						break;
					case "ScriptTreeGridSelectionChange":
						break;
					case "EventSubProcess134534":
						break;
					case "ChildStartMessageSelectSchemaForAddRights":
						e.Context.QueueTasks.Enqueue("ThrowMessageSelectSchemaForAddRights");
						break;
					case "ThrowMessageSelectSchemaForAddRights":
						e.Context.QueueTasks.Enqueue("ChildSelectSchemaForAddRightsScriptTask");
						break;
					case "ChildSelectSchemaForAddRightsScriptTask":
						break;
					case "SubProcess12":
						break;
					case "InitChildChild":
						e.Context.QueueTasks.Enqueue("ScriptInitChildChild");
						break;
					case "ScriptInitChildChild":
						e.Context.QueueTasks.Enqueue("ThrowInitChildParent");
						break;
					case "ThrowInitChildParent":
						e.Context.QueueTasks.Enqueue("ScriptBindTreeGridEvents");
						break;
					case "ScriptBindTreeGridEvents":
						break;
					case "SubProcess13":
						break;
					case "OpenVwSysSchemaInSolutionChild":
						e.Context.QueueTasks.Enqueue("InitOpenLookupUserTaskChildScript");
						break;
					case "InitOpenLookupUserTaskChildScript":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTaskChild");
						break;
					case "OpenLookupUserTaskChild":
							e.Context.QueueTasks.Enqueue("EventBasedGateway3");
						break;
					case "InitializeChild":
						break;
					case "LookupGridPageClosedChild":
						e.Context.QueueTasks.Enqueue("ApplyDataScriptChild");
						break;
					case "ApplyDataScriptChild":
						break;
					case "EventBasedGateway3":
						ActivatedEventElements.Add("InitializeChild");
						ActivatedEventElements.Add("LookupGridPageClosedChild");
						break;
					case "SubProcess14":
						break;
					case "DeleteButtonClickChild":
						e.Context.QueueTasks.Enqueue("ScriptDeleteButtonClickChild");
						break;
					case "ScriptDeleteButtonClickChild":
						break;
					case "SubProcess15":
						break;
					case "GridPageRefreshRowChild":
						e.Context.QueueTasks.Enqueue("ScriptSetIsAdministratedByOperations");
						break;
					case "ScriptGridPageRefreshRowChild":
						break;
					case "ThrowGridPageRefreshRowParent":
						e.Context.QueueTasks.Enqueue("ScriptGridPageRefreshRowChild");
						break;
					case "ScriptSetIsAdministratedByOperations":
						e.Context.QueueTasks.Enqueue("ThrowGridPageRefreshRowParent");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartTreeGridSelectionChange");
			ActivatedEventElements.Add("ChildStartMessageSelectSchemaForAddRights");
			ActivatedEventElements.Add("InitChildChild");
			ActivatedEventElements.Add("OpenVwSysSchemaInSolutionChild");
			ActivatedEventElements.Add("DeleteButtonClickChild");
			ActivatedEventElements.Add("GridPageRefreshRowChild");
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
				case "StartTreeGridSelectionChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartTreeGridSelectionChange";
					result = StartTreeGridSelectionChange.Execute(context);
					break;
				case "ScriptTreeGridSelectionChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTreeGridSelectionChange";
					result = ScriptTreeGridSelectionChange.Execute(context, ScriptTreeGridSelectionChangeExecute);
					break;
				case "EventSubProcess134534":
					context.QueueTasks.Dequeue();
					break;
				case "ChildStartMessageSelectSchemaForAddRights":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildStartMessageSelectSchemaForAddRights";
					result = ChildStartMessageSelectSchemaForAddRights.Execute(context);
					break;
				case "ThrowMessageSelectSchemaForAddRights":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SelectSchemaForAddRights");
					result = ThrowMessageSelectSchemaForAddRights.Execute(context);
					break;
				case "ChildSelectSchemaForAddRightsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildSelectSchemaForAddRightsScriptTask";
					result = ChildSelectSchemaForAddRightsScriptTask.Execute(context, ChildSelectSchemaForAddRightsScriptTaskExecute);
					break;
				case "SubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "InitChildChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitChildChild";
					result = InitChildChild.Execute(context);
					break;
				case "ScriptInitChildChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitChildChild";
					result = ScriptInitChildChild.Execute(context, ScriptInitChildChildExecute);
					break;
				case "ThrowInitChildParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ThrowInitChildParent.Execute(context);
					break;
				case "ScriptBindTreeGridEvents":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptBindTreeGridEvents";
					result = ScriptBindTreeGridEvents.Execute(context, ScriptBindTreeGridEventsExecute);
					break;
				case "SubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "OpenVwSysSchemaInSolutionChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenVwSysSchemaInSolutionChild";
					result = OpenVwSysSchemaInSolutionChild.Execute(context);
					break;
				case "InitOpenLookupUserTaskChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitOpenLookupUserTaskChildScript";
					result = InitOpenLookupUserTaskChildScript.Execute(context, InitOpenLookupUserTaskChildScriptExecute);
					break;
				case "OpenLookupUserTaskChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTaskChild";
					result = OpenLookupUserTaskChild.Execute(context);
					break;
				case "InitializeChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitializeChild";
					result = InitializeChild.Execute(context);
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
				case "EventBasedGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "EventBasedGateway3";
					result = EventBasedGateway3.Execute(context);
					break;
				case "SubProcess14":
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
				case "SubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "GridPageRefreshRowChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridPageRefreshRowChild";
					result = GridPageRefreshRowChild.Execute(context);
					break;
				case "ScriptGridPageRefreshRowChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridPageRefreshRowChild";
					result = ScriptGridPageRefreshRowChild.Execute(context, ScriptGridPageRefreshRowChildExecute);
					break;
				case "ThrowGridPageRefreshRowParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "GridPageRefreshRow");
					result = ThrowGridPageRefreshRowParent.Execute(context);
					break;
				case "ScriptSetIsAdministratedByOperations":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSetIsAdministratedByOperations";
					result = ScriptSetIsAdministratedByOperations.Execute(context, ScriptSetIsAdministratedByOperationsExecute);
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
				case "IconColumnNames":
					IconColumnNames = reader.GetSerializableObjectValue();
				break;
				case "IsOperationAdministrated":
					IsOperationAdministrated = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTreeGridSelectionChangeExecute(ProcessExecutingContext context) {
			Page.DeleteButton.Enabled = Page.AddButton.Enabled && Page.TreeGrid.SelectedNodes.Count > 0;
			Page.DownButton.Enabled = Page.AddButton.Enabled  && Page.TreeGrid.SelectedNodes.Count > 0 && RowsCount > 1;
			Page.UpButton.Enabled = Page.AddButton.Enabled  && Page.TreeGrid.SelectedNodes.Count > 0 && RowsCount > 1;
			return true;
		}

		public virtual bool ChildSelectSchemaForAddRightsScriptTaskExecute(ProcessExecutingContext context) {
			RowsCount++;
			return true;
		}

		public virtual bool ScriptInitChildChildExecute(ProcessExecutingContext context) {
			ShowRightsBySubject = true;
			return true;
		}

		public virtual bool ScriptBindTreeGridEventsExecute(ProcessExecutingContext context) {
			Page.TreeGrid.AjaxEvents.CellIconClick.Event += CellIconClick;
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(new Terrasoft.UI.WebControls.Controls.Parameter("nodeId", "nodeId", Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(new Terrasoft.UI.WebControls.Controls.Parameter("iconId", "iconId", Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			Page.TreeGrid.GetRowConfigHandler =	delegate(Terrasoft.Core.Entities.Entity row) {
				string primaryColumnName = "Id";
				var primaryColumnNameValue = row.GetColumnValue(primaryColumnName);
				if (primaryColumnNameValue == null) {
					return null;
				}
				string primaryColumnValue =	primaryColumnNameValue.ToString();
				var config = new DataSourceRowConfig(primaryColumnValue);
				var iconColumnNames = IconColumnNames as List<string>;
				var icons = new Dictionary<string, ImageConfigValue>();
				foreach(var item in iconColumnNames) {
					bool columnValue = row.GetTypedColumnValue<bool>(item);	
					string columnIconImageName = columnValue ? "Allow.png" : "Deny.png";
					var imageConfig = new ImageConfigValue(columnIconImageName);
					imageConfig.DisplayImageOnly = true;
					imageConfig.ImagePosition = ImagePosition.Center;
					icons.Add(item + "Display", imageConfig);
				}
				var iconConfig = new DataSourceRowColumnIconsConfigValue(icons);
				config.AddConfig(iconConfig);
				return config;
			};
			var virtualDataSource = GetVirtualDataSource();
			virtualDataSource.LoadingRow += delegate(object sender, DataSourceEventArgs e) {
				OnDataSourceLoadingRow(e.Request);
			};
			virtualDataSource.Loaded += Page.TreeGrid.DataLoaded;
			return true;
		}

		public virtual bool InitOpenLookupUserTaskChildScriptExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTaskChild.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			//#/if IS_WORKSPACE
			//Код, который компилируется только в Workspace CR172126
			//string schemaUId = ShowRightsBySubject ? "d5d01fcd-6d8c-4b29-9e58-cca3ffe62364" : "4FE60977-C711-48B2-8499-1CEBBECF7868";
			//#/endif
			OpenLookupUserTaskChild.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenLookupUserTaskChild.PageParameters;
			pageParameters.Add("schemaUId", GetLookupUserTaskSchemaUId());
			pageParameters.Add("hideButtons", true);
			if (!ShowRightsBySubject) {
				Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			//#/if IS_WORKSPACE
			//Код, который компилируется только в Workspace CR172126
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
			//#/endif
			}
			return true;
		}

		public virtual bool ApplyDataScriptChildExecute(ProcessExecutingContext context) {
			var values = (Dictionary <string, object>)OpenLookupUserTaskChild.GetSelectedValues(UserConnection);
			Guid selectedId = Guid.Empty;
			foreach (var valueItem in values) {
				selectedId = new Guid(valueItem.Key);
				break;
			}
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			string key = instanceId + Page.PageContainer.UniqueID;
			if (selectedId.IsEmpty()) {
				return true;
			}
			SelectedSchemaUIdForAddRights = selectedId;
			ThrowEvent(context, "SelectSchemaForAddRights");
			return true;
		}

		public virtual bool ScriptDeleteButtonClickChildExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			var virtualDataSource = GetVirtualDataSource();
			string primaryColumnName = Page.DataSource.Schema.PrimaryColumn.Name;
			string primaryRecordValue;
			if (selectedNodes.Count > 0) {
				foreach (var node in selectedNodes) {
					primaryRecordValue = node.Values[primaryColumnName].ToString();
					virtualDataSource.Remove(new Guid(primaryRecordValue));
					DeleteOperationsRightLevel(new Guid(primaryRecordValue));
					Page.UserConnection.DBSecurityEngine.ClearOperationRightsCache();
					RowsCount--;
				}
				var sel = GetSelectForVirtualDataSource(null);
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = sel.ExecuteReader(dbExecutor)) {
						if (reader.Read()) {
							if (reader.Read()) {
								EnableButtons(2);
							} else {
								EnableButtons(1);
							}
						} else {
							EnableButtons(0);
						}
					}
				}
			}
			return true;
		}

		public virtual bool ScriptGridPageRefreshRowChildExecute(ProcessExecutingContext context) {
			if (!IsOperationAdministrated) {
				Page.AddButton.Enabled = IsOperationAdministrated;	
			}
			var virtualDataSource = GetVirtualDataSource();
			RowsCount = virtualDataSource.Rows.Count;
			if (RowsCount == 0) {
				Page.DeleteButton.Enabled = false;
				Page.UpButton.Enabled = false;
				Page.DownButton.Enabled = false;
			} else if (RowsCount == 1) {
					Page.UpButton.Enabled = false;
					Page.DownButton.Enabled = false;
			}
			Page.DeleteButton.Enabled = Page.DeleteButton.Enabled && Page.TreeGrid.SelectedNodes.Count > 0;
			Page.DownButton.Enabled = Page.DownButton.Enabled && Page.TreeGrid.SelectedNodes.Count > 0;
			Page.UpButton.Enabled = Page.UpButton.Enabled && Page.TreeGrid.SelectedNodes.Count > 0;
			return true;
		}

		public virtual bool ScriptSetIsAdministratedByOperationsExecute(ProcessExecutingContext context) {
			SetIsAdministratedByOperations();
			return true;
		}

		public override void CreateVirtualDataSourceStructure(DataValueTypeManager dataValueTypeManager, DataSourceStructure defStructure) {
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
					Name = "SysSchema",
					ValueColumnName = "SysSchemaId",
					DisplayColumnName = "SysSchemaCaption",
					DataValueType = dataValueTypeManager.GetInstanceByName("Lookup"),
					ReferenceSchemaUId = entitySchemaManager.GetInstanceByName("VwSysSchemaInWorkspace").UId,
					ReferenceSchemaName = "VwSysSchemaInWorkspace",
					ReferenceSchemaPrimaryColumnName = "Id",
					Caption = schema.Columns.GetByName("SubjectSchemaUId").Caption,
					IsVisible = !ShowRightsBySubject,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "SysAdminUnit",
					ValueColumnName = "SysAdminUnitId",
					DisplayColumnName = "SysAdminUnitName",
					DataValueType = dataValueTypeManager.GetInstanceByName("Lookup"),
					ReferenceSchemaUId = entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId,
					ReferenceSchemaName = "VwSysAdminUnit",
					ReferenceSchemaPrimaryColumnName = "Id",
					ReferenceSchemaPrimaryDisplayColumnName = "Name",
					Caption = schema.Columns.GetByName("SysAdminUnit").Caption,
					IsVisible = true,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				List<string> iconColumnNames = new List<string>() {
					"CanRead",
					"CanAppend",
					"CanEdit",
					"CanDelete"
				};
				IconColumnNames = iconColumnNames;
				foreach (string columnName in iconColumnNames) {
					column = new DataSourceStructureColumn {
						Name = columnName,
						ValueColumnName = columnName,
						DisplayColumnName = columnName,
						DataValueType = dataValueTypeManager.GetInstanceByName("Boolean"),
						Caption = schema.Columns.GetByName(columnName).Caption,
						IsVisible = false,
						IsSortable = false
					};
					defStructure.AddColumn(column);
					column = new DataSourceStructureColumn {
						Name = columnName + "Display",
						ValueColumnName = columnName + "Display",
						DisplayColumnName = columnName + "Display",
						DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
						Caption = schema.Columns.GetByName(columnName).Caption,
						IsVisible = true,
						IsSortable = false
					};
					defStructure.AddColumn(column);
				}
				column = new DataSourceStructureColumn {
					Name = "Position",
					ValueColumnName = "Position",
					DisplayColumnName = "Position",
					DataValueType = dataValueTypeManager.GetInstanceByName("Integer"),
					Caption = schema.Columns.GetByName("Position").Caption,
					IsVisible = false,
					IsSortable = false
				};
				defStructure.AddColumn(column);
		}

		public override void ChangeRightItemPosition(Guid primaryColumnValue, int position, bool increasePosition, string subjectSchema) {
			base.ChangeRightItemPosition(primaryColumnValue, position, increasePosition, subjectSchema);
			OperationLogger.Instance.LogEntitySchemaOperationRightEdit(UserConnection, primaryColumnValue);
		}

		public override Select GetSelectForVirtualDataSource(params object[] objectParameters) {
			if (objectParameters == null) {
				Collection<Guid> adminUnitCollection = new Collection<Guid>();
				Guid filterColumnValue = SelectedNodePrimaryColumnValue;
				if (Page.AllMenuItem.Checked) {
					if(!filterColumnValue.IsEmpty()) {
						adminUnitCollection = Page.UserConnection.DBSecurityEngine.GetUserAdminUnitCollection(filterColumnValue);
					}
				} else {
					adminUnitCollection.Add(filterColumnValue);
				}
				objectParameters = new object[adminUnitCollection.Count];
				for (int i = 0; i < adminUnitCollection.Count; i++) {
					objectParameters[i] = adminUnitCollection[i];
				}
			}
			Guid schemaId = (Guid)objectParameters[0];
			Guid schemaUId = new Guid();
			if (schemaId != Guid.Empty) {
				schemaUId = WorkspaceUtilities.GetSchemaUIdById(schemaId, UserConnection);
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var rightsSchema = entitySchemaManager.GetInstanceByName(GetOperationRightSchemaName());
			var select = new Select(Page.UserConnection)
					.Column(rightsSchema.Name, "Id")
					.Column(rightsSchema.Name, "SubjectSchemaUId").As("SysSchemaId")
					.Column("VwSysSchemaInWorkspace", "Caption").As("SysSchemaCaption")
					.Column(rightsSchema.Name, "SysAdminUnitId")
					.Column("SysAdminUnit", "Name").As("SysAdminUnitName")
					.Column(rightsSchema.Name,"CanRead")
					.Column(rightsSchema.Name,"CanAppend")
					.Column(rightsSchema.Name,"CanEdit")
					.Column(rightsSchema.Name, "CanDelete")
					.Column(rightsSchema.Name, "Position")
					.Column("VwSysSchemaInWorkspace", "UId")
				.From(rightsSchema.Name)
				.InnerJoin("SysAdminUnit").On("SysAdminUnit", "Id").IsEqual(rightsSchema.Name, "SysAdminUnitId")
				.OrderByAsc(rightsSchema.Name, "SubjectSchemaUId")
				.OrderByAsc(rightsSchema.Name, "Position") as Select;
			//#/if IS_WORKSPACE
			//Код, который компилируется только в Workspace CR172126
			if (ShowRightsBySubject) {
				select.InnerJoin("VwSysSchemaInWorkspace").On("VwSysSchemaInWorkspace", "UId").IsEqual(rightsSchema.Name, "SubjectSchemaUId");
				select.Where("VwSysSchemaInWorkspace", "UId").IsEqual(Column.Parameter(schemaUId));
			} else {
				select.Where(rightsSchema.Name, "SysAdminUnitId").In(Column.Parameters(objectParameters));
			}
			select.And("VwSysSchemaInWorkspace", "SysWorkspaceId").IsEqual(Column.Parameter(UserConnection.Workspace.Id));
			if (!IsOperationAdministrated) {
				select.And("VwSysSchemaInWorkspace", "UId").IsEqual(Column.Parameter(Guid.Empty));
			}
			//#/endif
			return select;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual void CellIconClick(object sender, AjaxEventArgs e) {
			var nodeId = e.ExtraParameters["nodeId"];
			var iconId = e.ExtraParameters["iconId"];
			Guid newColumnValue = Guid.Empty;
			if ((nodeId != null) && (iconId != null)) {
				Guid recordId = new Guid (nodeId.Replace("\"", string.Empty));
				var column = iconId.Replace("\"", "").TrimEnd("Display".ToCharArray());
				RedactedSelectedUser(recordId, column);
			}
		}

		public virtual void RedactedSelectedUser(Guid recordId, string redactedColumnName) {
			VirtualDataSource virtualDataSource = GetVirtualDataSource();
			EntitySchema schema = Page.DataSource.Schema;
			Entity entity = schema.CreateEntity(Page.UserConnection);
			if (entity.FetchFromDB(recordId)) {
				DBSecurityEngine securityEngine = UserConnection.DBSecurityEngine;
				Guid subjectSchemaId = entity.GetTypedColumnValue<Guid>("SubjectSchemaUId");
				string entitySchemaName = UserConnection.EntitySchemaManager.GetItemByUId(subjectSchemaId).Name;
				Guid adminUnitId = entity.GetTypedColumnValue<Guid>("SysAdminUnitId");
				bool isAllowed = !entity.GetTypedColumnValue<bool>(redactedColumnName);
				SchemaOperationRightLevels rightLevel = SchemaOperationRightLevels.None;
				try {
					switch (redactedColumnName) {
						case "CanRead":
							securityEngine.SetEntitySchemaReadingAllowed(adminUnitId, entitySchemaName, isAllowed);
							break;
						case "CanAppend":
							securityEngine.SetEntitySchemaAppendingAllowed(adminUnitId, entitySchemaName, isAllowed);
							break;
						case "CanEdit":
							securityEngine.SetEntitySchemaEditingAllowed(adminUnitId, entitySchemaName, isAllowed);
							break;
						case "CanDelete":
							securityEngine.SetEntitySchemaDeletingAllowed(adminUnitId, entitySchemaName, isAllowed);
							break;
					}
				} catch (SecurityException securityException) {
					MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
					if (messagePanel != null) {
						messagePanel.Clear();
						messagePanel.AddMessage(Warning, securityException.Message, MessageType.Warning);
					}
				}
				securityEngine.ClearOperationRightsCache();
			}
			virtualDataSource.LoadRow(recordId, null);
		}

		public virtual Entity GetEntity(Guid recordId) {
			var select = GetSelectForVirtualDataSource(null);
			select.And(GetOperationRightSchemaName(), "Id").IsEqual(Column.Parameter(recordId));
			Collection<string> columnValueNames = new Collection<string>() {
				"Id","SysSchemaId","SysSchemaCaption", "SysAdminUnitId", "SysAdminUnitName", "CanRead", "CanAppend", "CanEdit", "CanDelete", "Position"
			};
			var virtualDataSource = GetVirtualDataSource();
			var row = virtualDataSource.CreateRow();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						int ordinal = -1;
						foreach (var columnValueName in columnValueNames) {
							ordinal = reader.GetOrdinal(columnValueName);
							if (!reader.IsDBNull(ordinal)) {
								if (columnValueName.StartsWith("Can")) {
									row.SetColumnValue(columnValueName, UserConnection.DBTypeConverter.DBValueToBool(reader.GetValue(ordinal)));
								} else {
									row.SetColumnValue(columnValueName, reader.GetValue(ordinal));
								}
							}
						}
						/*
						var columnName = "SysSchemaId";
						ordinal = reader.GetOrdinal(columnName);
						if (!reader.IsDBNull(ordinal)) {
							Guid schemaId = UserConnection.DBTypeConverter.DBValueToGuid(reader[ordinal]);
			//#/if IS_WORKSPACE
			//Код, который компилируется только в Workspace CR172126
							var conditions = new Dictionary<string, object> {
								{ "UId", schemaId },
								{ "SysWorkspace", Page.UserConnection.Workspace.Id }
							};
							var sysSchemaView = new Terrasoft.Core.Configuration.VwSysSchemaInWorkspace(Page.UserConnection);
							sysSchemaView.FetchFromDB(conditions);
							row.SetColumnValue("SysSchemaId", sysSchemaView.UId);//?SysSchemaId:UId
							row.SetColumnValue("SysSchemaCaption", sysSchemaView.Caption);
			//#/endif
						}*/
					}
				}
			}
			return row;
		}

		public virtual void OnDataSourceLoadingRow(DataSourceRequest dataSourceRequest) {
			Guid recordId =  dataSourceRequest == null ? Guid.Empty : dataSourceRequest.PrimaryColumnValue;
			GetVirtualDataSource().Rows.Add(GetEntity(recordId));
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public virtual Guid SetOperationsRightLevel(Guid adminUnitId, Guid schemaUId, SchemaOperationRightLevels rightLevel) {
			return UserConnection.DBSecurityEngine.SetEntitySchemaOperationsRightLevel(adminUnitId, schemaUId, rightLevel);
		}

		public virtual string GetOperationRightSchemaName() {
			return "SysEntitySchemaOperationRight";
		}

		public virtual void DeleteOperationsRightLevel(Guid recordId) {
			UserConnection.DBSecurityEngine.DeleteEntitySchemaOperationRightLevel(recordId);
		}

		public virtual void SetIsAdministratedByOperations() {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "VwWorkspaceObjects");
			
			var administratedByOperations = query.AddColumn("AdministratedByOperations");
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", SelectedNodePrimaryColumnValue));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", Page.UserConnection.Workspace.Id));
			var entities = query.GetEntityCollection(UserConnection);
			IsOperationAdministrated = entities.Count > 0 ? entities[0].GetTypedColumnValue<bool>(administratedByOperations.Name) : false;
		}

		public virtual Guid GetLookupUserTaskSchemaUId() {
			return ShowRightsBySubject ? new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364") : new Guid("4FE60977-C711-48B2-8499-1CEBBECF7868");
		}

		public virtual Guid SetEntitySchemaOperationAllowed(Guid adminUnitId, Guid schemaUId, SchemaOperationRightLevels rightLevel, bool isAllowed) {
			return UserConnection.DBSecurityEngine.SetEntitySchemaOperationAllowed(adminUnitId, schemaUId, rightLevel, isAllowed);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "TreeGridSelectionChange":
							if (ActivatedEventElements.Contains("StartTreeGridSelectionChange")) {
							context.QueueTasks.Enqueue("StartTreeGridSelectionChange");
						}
						break;
					case "SelectSchemaForAddRights":
							if (ActivatedEventElements.Contains("ChildStartMessageSelectSchemaForAddRights")) {
							context.QueueTasks.Enqueue("ChildStartMessageSelectSchemaForAddRights");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitChildChild")) {
							context.QueueTasks.Enqueue("InitChildChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpenVwSysSchemaInSolution":
							if (ActivatedEventElements.Contains("OpenVwSysSchemaInSolutionChild")) {
							context.QueueTasks.Enqueue("OpenVwSysSchemaInSolutionChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "Initialize":
					if (ActivatedEventElements.Remove("InitializeChild")) {
						EventBasedGateway3.CancelNonexecutedEvents("InitializeChild");
						context.QueueTasks.Enqueue("InitializeChild");
					}
					break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosedChild")) {
						EventBasedGateway3.CancelNonexecutedEvents("LookupGridPageClosedChild");
						context.QueueTasks.Enqueue("LookupGridPageClosedChild");
					}
					break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteButtonClickChild")) {
							context.QueueTasks.Enqueue("DeleteButtonClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("GridPageRefreshRowChild")) {
							context.QueueTasks.Enqueue("GridPageRefreshRowChild");
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
			if (IconColumnNames != null) {
				if (IconColumnNames.GetType().IsSerializable ||
					IconColumnNames.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("IconColumnNames", IconColumnNames, null);
				}
			}
			if (!HasMapping("IsOperationAdministrated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsOperationAdministrated", IsOperationAdministrated, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByOperationsGridPageEventsProcess : AdministrativeObjectsByOperationsGridPageEventsProcess<Terrasoft.WebApp.AdministrativeObjectsByOperationsGridPageSchemaUserControl>
	{

		public AdministrativeObjectsByOperationsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectsByOperationsGridPageSchemaUserControl : Terrasoft.WebApp.AdministrativeByOperationsGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			TreeGrid.AjaxEvents.SelectionChange.Event += TreeGridSelectionChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			TreeGrid.AjaxEvents.SelectionChange.Event -= TreeGridSelectionChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeObjectsByOperationsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectsByOperationsGridPageEventsProcess(UserConnection);
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

		public virtual void TreeGridSelectionChange(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridSelectionChange");
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
			SchemaName = "AdministrativeObjectsByOperationsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByOperationsGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectsByOperationsGridPageEventsProcessSchema : Terrasoft.WebApp.AdministrativeByOperationsGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsByOperationsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectsByOperationsGridPageEventsProcessSchema(AdministrativeObjectsByOperationsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectsByOperationsGridPageEventsProcess";
			UId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateIsOperationAdministratedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eea2c06e-30d9-4b1b-bf83-f82e77597fe9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"IsOperationAdministrated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIconColumnNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bacd35dc-f1cd-457b-88f6-ea2dd54c6ac0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"IconColumnNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsOperationAdministratedParameter());
			Parameters.Add(CreateIconColumnNamesParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskChildParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fa7bf6a0-27cd-4b3a-8d8b-2851880e1104"),
				ContainerUId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840"),
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
				UId = new Guid("62440dee-7e50-4ec1-9260-b0efec1cff77"),
				ContainerUId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840"),
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
				UId = new Guid("4267fd30-6290-4e5c-a82f-9e22e4c4be8e"),
				ContainerUId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840"),
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
				UId = new Guid("53bd35a4-de8c-44f8-8f22-418b21bc3f75"),
				ContainerUId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840"),
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
			ProcessSchemaLaneSet schemaLaneSet1214 = CreateLaneSet1214LaneSet();
			LaneSets.Add(schemaLaneSet1214);
			ProcessSchemaLane schemaLane4076 = CreateLane4076Lane();
			schemaLaneSet1214.Lanes.Add(schemaLane4076);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess134534 = CreateEventSubProcess134534EventSubProcess();
			FlowElements.Add(eventsubprocess134534);
			ProcessSchemaEventSubProcess subprocess12 = CreateSubProcess12EventSubProcess();
			FlowElements.Add(subprocess12);
			ProcessSchemaEventSubProcess subprocess13 = CreateSubProcess13EventSubProcess();
			FlowElements.Add(subprocess13);
			ProcessSchemaEventSubProcess subprocess14 = CreateSubProcess14EventSubProcess();
			FlowElements.Add(subprocess14);
			ProcessSchemaEventSubProcess subprocess15 = CreateSubProcess15EventSubProcess();
			FlowElements.Add(subprocess15);
			ProcessSchemaStartMessageEvent starttreegridselectionchange = CreateStartTreeGridSelectionChangeStartMessageEvent();
			eventsubprocess8.FlowElements.Add(starttreegridselectionchange);
			ProcessSchemaScriptTask scripttreegridselectionchange = CreateScriptTreeGridSelectionChangeScriptTask();
			eventsubprocess8.FlowElements.Add(scripttreegridselectionchange);
			ProcessSchemaStartMessageEvent childstartmessageselectschemaforaddrights = CreateChildStartMessageSelectSchemaForAddRightsStartMessageEvent();
			eventsubprocess134534.FlowElements.Add(childstartmessageselectschemaforaddrights);
			ProcessSchemaIntermediateThrowMessageEvent throwmessageselectschemaforaddrights = CreateThrowMessageSelectSchemaForAddRightsIntermediateThrowMessageEvent();
			eventsubprocess134534.FlowElements.Add(throwmessageselectschemaforaddrights);
			ProcessSchemaScriptTask childselectschemaforaddrightsscripttask = CreateChildSelectSchemaForAddRightsScriptTaskScriptTask();
			eventsubprocess134534.FlowElements.Add(childselectschemaforaddrightsscripttask);
			ProcessSchemaStartMessageEvent initchildchild = CreateInitChildChildStartMessageEvent();
			subprocess12.FlowElements.Add(initchildchild);
			ProcessSchemaScriptTask scriptinitchildchild = CreateScriptInitChildChildScriptTask();
			subprocess12.FlowElements.Add(scriptinitchildchild);
			ProcessSchemaIntermediateThrowMessageEvent throwinitchildparent = CreateThrowInitChildParentIntermediateThrowMessageEvent();
			subprocess12.FlowElements.Add(throwinitchildparent);
			ProcessSchemaScriptTask scriptbindtreegridevents = CreateScriptBindTreeGridEventsScriptTask();
			subprocess12.FlowElements.Add(scriptbindtreegridevents);
			ProcessSchemaStartMessageEvent openvwsysschemainsolutionchild = CreateOpenVwSysSchemaInSolutionChildStartMessageEvent();
			subprocess13.FlowElements.Add(openvwsysschemainsolutionchild);
			ProcessSchemaScriptTask initopenlookupusertaskchildscript = CreateInitOpenLookupUserTaskChildScriptScriptTask();
			subprocess13.FlowElements.Add(initopenlookupusertaskchildscript);
			ProcessSchemaUserTask openlookupusertaskchild = CreateOpenLookupUserTaskChildUserTask();
			subprocess13.FlowElements.Add(openlookupusertaskchild);
			ProcessSchemaIntermediateCatchMessageEvent initializechild = CreateInitializeChildIntermediateCatchMessageEvent();
			subprocess13.FlowElements.Add(initializechild);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosedchild = CreateLookupGridPageClosedChildIntermediateCatchMessageEvent();
			subprocess13.FlowElements.Add(lookupgridpageclosedchild);
			ProcessSchemaScriptTask applydatascriptchild = CreateApplyDataScriptChildScriptTask();
			subprocess13.FlowElements.Add(applydatascriptchild);
			ProcessSchemaEventBasedGateway eventbasedgateway3 = CreateEventBasedGateway3EventBasedGateway();
			subprocess13.FlowElements.Add(eventbasedgateway3);
			ProcessSchemaStartMessageEvent deletebuttonclickchild = CreateDeleteButtonClickChildStartMessageEvent();
			subprocess14.FlowElements.Add(deletebuttonclickchild);
			ProcessSchemaScriptTask scriptdeletebuttonclickchild = CreateScriptDeleteButtonClickChildScriptTask();
			subprocess14.FlowElements.Add(scriptdeletebuttonclickchild);
			ProcessSchemaStartMessageEvent gridpagerefreshrowchild = CreateGridPageRefreshRowChildStartMessageEvent();
			subprocess15.FlowElements.Add(gridpagerefreshrowchild);
			ProcessSchemaScriptTask scriptgridpagerefreshrowchild = CreateScriptGridPageRefreshRowChildScriptTask();
			subprocess15.FlowElements.Add(scriptgridpagerefreshrowchild);
			ProcessSchemaIntermediateThrowMessageEvent throwgridpagerefreshrowparent = CreateThrowGridPageRefreshRowParentIntermediateThrowMessageEvent();
			subprocess15.FlowElements.Add(throwgridpagerefreshrowparent);
			ProcessSchemaScriptTask scriptsetisadministratedbyoperations = CreateScriptSetIsAdministratedByOperationsScriptTask();
			subprocess15.FlowElements.Add(scriptsetisadministratedbyoperations);
			FlowElements.Add(CreateSequenceFlow23042SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23043SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23044SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23045SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23046SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23047SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23048SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23049SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23050SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23051SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23052SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23059SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23060SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23064SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1987509740430343453SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2342342342342355SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23042SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23042",
				UId = new Guid("5ccb8ca3-d6e0-4588-9c2a-518dbbbe02e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(150, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("786d06ab-937d-4bc6-8d0b-02bf9b8d1da5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("86513901-ebc5-4558-ac88-996ee463206c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23043SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23043",
				UId = new Guid("f625874b-fe35-4cca-aab5-a74a9a3a7ae5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(254, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("86513901-ebc5-4558-ac88-996ee463206c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3ef0722-3edd-40c2-af75-ca2674bd5890"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23044SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23044",
				UId = new Guid("af3ded6d-25d4-4928-848e-a793c5c189e2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(146, 251),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("260c63c6-8e63-476e-9096-bd6a56b2a537"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9be5cf9-cdd3-4e93-abd6-d1744a714007"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23045SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23045",
				UId = new Guid("61020920-7920-4a0a-83cb-ee0a0ed17447"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(258, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c9be5cf9-cdd3-4e93-abd6-d1744a714007"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23046SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23046",
				UId = new Guid("9f814aaa-322c-4c35-b2cb-253ae4f4a4df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(358, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1be2adcb-2e89-4bbf-8c21-5f1130097311"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23047SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23047",
				UId = new Guid("fddfd4c9-8b1f-4b0e-96b8-9fe3ba5a7d08"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(413, 304),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1be2adcb-2e89-4bbf-8c21-5f1130097311"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45cfec37-ed84-4f4b-b5df-78342afd3479"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23048SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23048",
				UId = new Guid("a072eff6-52a4-4df7-9526-d7a5e79dbaec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(465, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1be2adcb-2e89-4bbf-8c21-5f1130097311"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("633bc9ea-a1a4-4cf4-a058-8d848040a587"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23049SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23049",
				UId = new Guid("bb5bb5a9-63db-4721-b34b-a4804f84b987"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(540, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("633bc9ea-a1a4-4cf4-a058-8d848040a587"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52943689-06a1-461e-a2ae-7eef6d947208"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23050SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23050",
				UId = new Guid("6be2dde9-0423-40c8-b23b-d6ecdebf00d7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(151, 451),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("44de8433-698a-43c2-88e1-113ef5400685"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d651b62a-e3ff-45f0-a377-17565443b26d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23051SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23051",
				UId = new Guid("58349e10-c50b-4751-90fb-1945c3772ffc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(362, 450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0fe704fa-30d0-4e39-b7d3-81889b183ca2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("229508be-1adb-4ca0-9d6b-81dc9045a498"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23052SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23052",
				UId = new Guid("14a3ecbb-f8b9-4e1e-96ca-f921de08d229"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(456, 452),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("229508be-1adb-4ca0-9d6b-81dc9045a498"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd9b866a-cc6e-4804-8d72-824fa052b920"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23059SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23059",
				UId = new Guid("b3ddc679-2cd4-4b34-b307-b2c0df3b7620"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(362, 450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e086a05a-ed48-437d-9881-81b7e77261db"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0fe704fa-30d0-4e39-b7d3-81889b183ca2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23060SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23060",
				UId = new Guid("3f4b1dcf-d737-4de3-9743-62c12fe3c2f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(164, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03adef71-d7ac-456b-8e6a-4c11035e1556"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6769a3f-1fa9-421c-8dbe-4b0a8f83baed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23064SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23064",
				UId = new Guid("66f34bc8-0954-4a9d-aca5-4b345a7324c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(336, 228),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3ef0722-3edd-40c2-af75-ca2674bd5890"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("969193e8-87ce-4bd0-8f7c-60c196e6751b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1987509740430343453SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1987509740430343453",
				UId = new Guid("291ee13b-13d3-4ccc-b982-b72836db287a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(424, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6c7f5a32-1b76-4ae6-9941-e1fad6cb7397"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e55b0790-82a9-4738-ab92-0ddbf497eec2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2342342342342355SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2342342342342355",
				UId = new Guid("78cfc2c1-9201-4b28-ade7-c5585c9c7589"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CurveCenterPosition = new Point(514, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e55b0790-82a9-4738-ab92-0ddbf497eec2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7bbc11b0-10d5-4226-a713-a88b4dd0d755"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1214LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1214 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("482d4c11-20ca-4d28-86cd-38a842f89170"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"LaneSet1214",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1085, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1214;
		}

		protected virtual ProcessSchemaLane CreateLane4076Lane() {
			ProcessSchemaLane schemaLane4076 = new ProcessSchemaLane(this) {
				UId = new Guid("60a6c3b1-0bb5-4e9d-93cd-2945dd1cdb1b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("482d4c11-20ca-4d28-86cd-38a842f89170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"Lane4076",
				Position = new Point(29, 0),
				Size = new Size(1056, 177),
				UseBackgroundMode = false
			};
			return schemaLane4076;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("10921545-eb72-4c7c-9057-eda2d81f3c4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a6c3b1-0bb5-4e9d-93cd-2945dd1cdb1b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"EventSubProcess8",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartTreeGridSelectionChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("03adef71-d7ac-456b-8e6a-4c11035e1556"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10921545-eb72-4c7c-9057-eda2d81f3c4b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"StartTreeGridSelectionChange",
				Position = new Point(22, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTreeGridSelectionChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c6769a3f-1fa9-421c-8dbe-4b0a8f83baed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10921545-eb72-4c7c-9057-eda2d81f3c4b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ScriptTreeGridSelectionChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,205,73,45,73,117,42,45,41,201,207,211,115,205,75,76,202,73,77,81,176,85,8,0,201,57,166,164,160,73,168,169,65,100,66,138,82,83,221,139,50,83,244,130,129,218,147,75,82,83,252,242,83,82,139,245,156,243,75,243,74,20,236,20,12,172,185,192,202,92,242,203,243,136,53,154,104,179,65,10,131,242,203,139,97,2,134,80,203,66,11,232,97,85,81,106,73,105,81,158,66,73,81,105,170,53,0,240,238,31,82,65,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess134534EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess134534 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3217d55b-13ba-4501-9e63-ddddfb6ae1da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a6c3b1-0bb5-4e9d-93cd-2945dd1cdb1b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"EventSubProcess134534",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(306, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess134534;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildStartMessageSelectSchemaForAddRightsStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6c7f5a32-1b76-4ae6-9941-e1fad6cb7397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3217d55b-13ba-4501-9e63-ddddfb6ae1da"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SelectSchemaForAddRights",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ChildStartMessageSelectSchemaForAddRights",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowMessageSelectSchemaForAddRightsIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e55b0790-82a9-4738-ab92-0ddbf497eec2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3217d55b-13ba-4501-9e63-ddddfb6ae1da"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SelectSchemaForAddRights",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ThrowMessageSelectSchemaForAddRights",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildSelectSchemaForAddRightsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7bbc11b0-10d5-4226-a713-a88b4dd0d755"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3217d55b-13ba-4501-9e63-ddddfb6ae1da"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ChildSelectSchemaForAddRightsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,202,47,47,118,206,47,205,43,209,214,182,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,62,15,20,63,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c723a602-cec3-456b-a10a-257f1216d2d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a6c3b1-0bb5-4e9d-93cd-2945dd1cdb1b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"SubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(414, 134),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitChildChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("786d06ab-937d-4bc6-8d0b-02bf9b8d1da5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c723a602-cec3-456b-a10a-257f1216d2d7"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"InitChildChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitChildChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("86513901-ebc5-4558-ac88-996ee463206c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c723a602-cec3-456b-a10a-257f1216d2d7"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ScriptInitChildChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,206,200,47,15,202,76,207,40,41,118,170,12,46,77,202,74,77,46,81,176,85,40,41,42,77,181,230,42,74,45,41,45,202,131,112,0,73,255,37,119,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowInitChildParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c3ef0722-3edd-40c2-af75-ca2674bd5890"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c723a602-cec3-456b-a10a-257f1216d2d7"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ThrowInitChildParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptBindTreeGridEventsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("969193e8-87ce-4bd0-8f7c-60c196e6751b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c723a602-cec3-456b-a10a-257f1216d2d7"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ScriptBindTreeGridEvents",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,221,110,219,32,20,190,118,165,190,3,242,149,173,70,60,192,218,100,138,146,170,139,212,173,81,155,117,215,196,62,241,232,8,120,128,147,90,83,223,125,7,176,99,55,78,165,85,170,118,97,9,195,249,254,56,192,146,21,64,87,26,224,70,243,156,78,159,216,243,245,14,164,53,116,6,66,44,50,37,103,130,103,191,168,159,36,23,99,242,106,250,242,252,108,249,143,248,103,171,217,146,105,182,5,11,218,208,105,158,39,18,246,100,5,90,51,163,54,150,126,95,208,31,176,158,41,105,181,18,8,111,7,7,80,18,75,149,195,34,143,71,164,27,189,3,255,21,49,244,158,237,211,244,63,219,230,72,23,108,31,70,31,99,123,177,197,223,91,110,44,25,147,184,163,68,190,105,89,198,131,242,27,176,247,106,143,10,27,94,124,97,50,23,160,201,56,202,65,64,193,44,36,29,193,76,105,160,215,210,114,203,193,132,65,77,180,218,167,228,207,249,89,100,172,230,178,32,165,230,91,166,235,153,18,213,86,126,67,175,206,4,134,67,217,104,199,244,112,253,145,137,202,21,33,145,179,18,22,252,100,50,168,117,89,35,190,33,195,149,134,101,76,100,37,68,48,20,105,176,149,150,126,198,225,94,222,48,217,64,163,211,156,116,165,30,60,40,73,219,8,153,223,42,180,236,90,62,103,150,61,168,74,103,112,216,196,100,72,127,192,186,86,119,10,6,73,22,71,51,204,16,215,187,171,96,117,210,7,154,86,147,103,150,43,137,18,77,213,136,248,158,7,121,47,56,9,118,55,216,50,150,253,76,60,131,133,45,225,242,216,66,179,89,107,165,4,38,235,109,72,219,145,85,93,66,222,203,114,229,74,39,137,163,75,47,35,135,109,118,53,160,93,30,239,166,105,126,159,243,51,137,167,66,32,109,41,139,152,124,34,241,28,100,237,127,156,217,144,179,11,210,164,61,142,150,156,208,241,97,163,30,150,206,185,41,5,171,125,197,157,20,53,146,89,93,193,160,206,23,44,149,225,110,71,93,59,250,255,120,237,37,222,181,0,114,13,240,55,221,111,228,5,154,15,18,120,111,123,132,105,123,212,186,110,191,125,90,218,28,166,31,207,11,121,154,112,208,156,102,115,176,58,62,191,222,28,240,80,134,19,47,248,57,217,29,215,182,98,162,19,67,117,108,228,227,241,180,63,35,131,98,122,171,88,142,253,68,135,238,101,63,60,4,106,253,4,153,37,6,100,14,122,212,139,226,159,200,169,46,12,129,112,152,238,100,183,216,145,37,248,94,193,239,10,140,77,91,175,39,165,33,119,178,175,223,40,87,18,214,16,214,196,246,237,252,11,225,40,225,203,168,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a6c3b1-0bb5-4e9d-93cd-2945dd1cdb1b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"SubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 350),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(591, 218),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenVwSysSchemaInSolutionChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("260c63c6-8e63-476e-9096-bd6a56b2a537"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenVwSysSchemaInSolution",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"OpenVwSysSchemaInSolutionChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitOpenLookupUserTaskChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c9be5cf9-cdd3-4e93-abd6-d1744a714007"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"InitOpenLookupUserTaskChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,93,111,211,48,20,125,222,164,253,7,19,94,18,209,100,107,215,245,131,141,161,53,203,80,53,96,213,210,178,7,132,144,151,56,171,105,106,103,182,195,136,170,74,48,30,65,226,157,159,129,64,26,12,141,191,224,254,35,236,180,235,214,105,76,123,1,241,16,75,118,238,57,247,220,115,125,205,5,195,228,0,96,194,5,36,1,106,134,224,1,48,205,54,98,12,114,26,9,167,211,116,246,208,190,75,137,96,52,230,78,11,30,32,75,47,206,6,79,242,141,211,156,66,157,54,245,115,58,211,90,93,152,223,73,16,121,76,105,47,77,58,28,177,54,228,61,183,139,227,208,105,49,26,32,206,183,81,166,82,93,202,123,15,228,188,122,209,233,32,38,136,57,29,130,15,83,212,220,84,124,139,139,119,23,113,4,154,254,203,189,157,221,109,191,181,225,122,250,80,126,150,103,242,107,1,200,31,242,108,116,172,190,183,163,15,242,123,190,149,63,229,47,121,34,79,229,137,58,124,47,191,141,142,71,239,70,159,128,142,146,167,163,143,58,4,200,47,96,143,178,30,79,96,128,128,187,91,172,150,138,165,138,230,229,99,99,120,208,69,125,216,201,125,241,187,244,104,23,31,116,5,111,100,126,186,255,10,5,2,60,4,70,184,18,46,21,163,32,180,43,97,45,176,203,251,165,186,93,71,43,53,59,8,224,114,20,161,74,105,185,82,54,192,125,96,148,183,188,202,82,189,90,181,221,106,177,104,151,107,141,146,93,43,215,235,118,209,245,26,13,207,221,170,214,42,53,99,82,41,34,33,142,110,48,81,185,212,130,12,246,145,64,140,43,109,4,29,129,77,28,8,76,9,100,25,88,27,203,47,0,154,203,92,207,59,242,26,50,144,92,5,154,55,160,172,219,165,87,212,179,180,206,70,24,154,198,212,58,163,0,30,33,49,203,227,159,255,52,45,235,15,248,46,14,81,35,21,130,18,174,24,4,75,145,142,84,87,192,188,115,77,39,44,48,88,152,159,115,105,28,163,188,158,181,139,186,174,150,181,14,34,28,95,242,237,118,160,220,194,127,122,9,231,38,50,115,59,102,27,124,85,29,24,0,21,63,7,6,70,64,251,9,100,152,83,210,206,18,164,140,219,202,73,220,153,99,199,59,76,97,60,44,76,48,49,138,132,247,38,97,106,44,21,189,178,35,237,147,22,20,93,133,54,252,140,79,181,25,83,68,202,209,38,230,73,12,179,103,48,78,117,154,8,198,28,129,97,225,92,7,211,237,185,32,157,54,55,143,215,13,213,5,141,213,63,127,1,6,249,236,235,203,161,102,159,140,155,225,76,243,58,205,112,56,28,106,255,255,11,75,158,64,162,212,178,167,170,160,191,232,136,225,17,129,69,54,30,148,73,74,227,220,134,235,230,101,60,96,227,218,52,221,196,42,107,246,69,25,46,204,51,36,82,70,242,137,90,253,13,242,182,113,248,0,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskChildUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a3decdc4-9226-4860-bb2c-ad8460c96840"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
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

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateInitializeChildIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("45cfec37-ed84-4f4b-b5df-78342afd3479"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"Initialize",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"InitializeChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(414, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedChildIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("633bc9ea-a1a4-4cf4-a058-8d848040a587"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"LookupGridPageClosedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(414, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateApplyDataScriptChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52943689-06a1-461e-a2ae-7eef6d947208"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ApplyDataScriptChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(477, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,145,203,78,195,48,16,69,215,173,212,127,24,117,229,136,202,63,192,67,170,218,82,69,32,129,104,2,107,55,153,52,38,169,29,236,73,74,132,248,119,108,167,47,54,150,31,115,207,189,51,238,132,129,78,212,45,90,184,7,182,148,25,73,173,132,233,225,206,146,145,106,55,3,189,253,196,140,30,162,151,6,213,179,214,85,219,164,22,77,34,108,181,40,101,157,243,53,210,6,107,87,130,249,123,0,49,255,190,208,74,97,128,69,183,147,241,186,149,57,216,99,85,156,59,43,127,195,87,251,134,122,247,92,104,131,34,43,129,117,167,52,49,225,30,164,58,70,139,224,103,50,30,253,211,43,60,4,6,59,151,243,39,236,189,215,104,235,96,149,219,252,78,198,158,39,149,37,161,50,12,50,198,18,52,70,88,93,16,79,99,254,129,91,23,148,140,174,45,127,21,59,140,252,194,231,182,9,7,30,159,165,60,209,155,48,15,230,45,134,209,64,133,189,67,94,241,111,32,232,253,226,177,66,42,52,60,85,242,203,37,92,58,157,44,128,93,186,224,177,13,3,96,209,208,159,65,106,141,2,50,45,14,233,79,99,221,100,37,238,69,26,231,143,218,204,243,252,77,238,74,242,223,117,65,185,250,164,52,250,176,234,80,17,203,156,55,126,211,12,166,3,97,208,95,139,167,190,139,107,191,63,119,113,51,234,7,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventBasedGateway CreateEventBasedGateway3EventBasedGateway() {
			ProcessSchemaEventBasedGateway gateway = new ProcessSchemaEventBasedGateway(this) {
				UId = new Guid("1be2adcb-2e89-4bbf-8c21-5f1130097311"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("490b4619-70c6-42e1-a227-2b4fac5698a0"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"EventBasedGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bf16a3d6-b06c-43f1-a758-981e8748766b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a6c3b1-0bb5-4e9d-93cd-2945dd1cdb1b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"SubProcess14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 546),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(204, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("44de8433-698a-43c2-88e1-113ef5400685"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf16a3d6-b06c-43f1-a758-981e8748766b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"DeleteButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteButtonClickChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d651b62a-e3ff-45f0-a377-17565443b26d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf16a3d6-b06c-43f1-a758-981e8748766b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ScriptDeleteButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,78,195,48,16,60,7,137,127,240,49,61,212,42,92,17,28,154,150,94,16,160,164,244,130,56,152,100,219,90,114,108,180,182,3,8,245,223,89,219,125,18,129,144,98,69,182,103,198,179,179,219,9,100,22,20,212,14,154,123,211,128,101,215,236,81,172,128,207,17,96,134,178,225,213,241,237,213,249,89,71,140,78,162,243,66,77,132,19,149,241,88,3,177,102,224,22,63,143,243,1,17,172,67,169,87,236,13,101,43,240,179,48,202,183,250,94,180,176,123,233,0,231,85,189,134,86,240,199,99,40,15,216,158,76,9,181,193,102,33,148,15,119,114,201,242,147,42,120,97,188,118,236,134,141,6,236,235,252,44,91,26,4,81,175,89,30,220,107,66,48,169,79,235,78,184,172,47,79,54,3,129,199,141,125,238,149,241,194,231,166,138,222,98,181,89,214,11,135,151,208,154,14,114,13,239,108,230,101,147,247,31,25,36,234,132,28,57,120,120,3,20,78,26,109,75,185,90,187,59,232,64,253,131,28,195,124,178,128,133,209,154,10,35,1,62,25,87,80,123,148,238,115,170,87,82,3,47,20,8,220,63,16,245,109,65,201,192,214,124,105,222,109,204,110,56,12,251,13,173,46,141,72,106,113,154,134,91,131,253,94,107,175,84,20,241,54,52,42,70,221,188,78,63,200,128,51,72,244,31,222,166,218,122,132,201,248,112,148,15,182,93,56,82,160,190,53,16,216,100,129,39,49,40,227,89,126,16,223,241,178,48,8,137,193,3,104,47,248,215,77,54,213,226,85,193,216,59,71,145,231,151,41,136,44,219,48,80,22,126,65,93,236,81,241,119,138,61,133,142,182,208,136,220,164,80,233,67,112,30,53,115,72,19,252,13,238,182,40,194,134,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e213a9ff-4bd1-4a01-b764-63798b78709f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a6c3b1-0bb5-4e9d-93cd-2945dd1cdb1b"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"SubProcess15",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 567),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(362, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridPageRefreshRowChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e086a05a-ed48-437d-9881-81b7e77261db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e213a9ff-4bd1-4a01-b764-63798b78709f"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"GridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridPageRefreshRowChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bd9b866a-cc6e-4804-8d72-824fa052b920"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e213a9ff-4bd1-4a01-b764-63798b78709f"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ScriptGridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,65,107,2,49,16,133,207,230,87,140,151,69,47,65,207,65,193,118,203,210,75,45,106,123,79,205,108,9,196,68,102,39,235,161,248,223,141,86,176,116,141,181,167,144,249,222,155,121,147,216,26,6,253,231,102,190,69,210,108,131,159,153,141,245,182,225,116,67,51,132,47,209,123,213,159,40,103,198,60,68,230,224,229,147,215,31,14,13,76,32,231,82,61,177,23,173,38,104,45,113,212,174,212,172,151,33,210,26,147,169,66,126,255,93,30,12,149,88,132,93,243,24,162,231,164,233,248,228,145,202,19,86,194,166,196,63,212,19,24,93,98,150,232,144,177,147,180,214,174,65,117,214,188,109,111,243,50,236,124,78,177,7,76,39,116,34,140,79,17,254,236,127,199,0,113,107,143,60,43,138,111,184,34,196,138,172,145,203,164,90,167,207,120,9,6,207,79,7,83,24,41,145,143,144,35,255,236,125,101,255,235,245,251,251,18,114,36,15,76,17,213,1,136,44,182,69,177,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowGridPageRefreshRowParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("229508be-1adb-4ca0-9d6b-81dc9045a498"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e213a9ff-4bd1-4a01-b764-63798b78709f"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ThrowGridPageRefreshRowParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSetIsAdministratedByOperationsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0fe704fa-30d0-4e39-b7d3-81889b183ca2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e213a9ff-4bd1-4a01-b764-63798b78709f"),
				CreatedInOwnerSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Name = @"ScriptSetIsAdministratedByOperations",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,44,118,76,201,205,204,203,44,46,41,74,44,73,77,113,170,244,47,72,5,178,50,243,243,138,53,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,77,197,73,117,47,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCellIconClickMethod());
			Methods.Add(CreateRedactedSelectedUserMethod());
			Methods.Add(CreateGetEntityMethod());
			Methods.Add(CreateOnDataSourceLoadingRowMethod());
			Methods.Add(CreateSetOperationsRightLevelMethod());
			Methods.Add(CreateGetOperationRightSchemaNameMethod());
			Methods.Add(CreateDeleteOperationsRightLevelMethod());
			Methods.Add(CreateSetIsAdministratedByOperationsMethod());
			Methods.Add(CreateGetLookupUserTaskSchemaUIdMethod());
			Methods.Add(CreateSetEntitySchemaOperationAllowedMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("57e43cd6-21b8-4cf0-8269-102825ad68c4"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4cb6d400-f8bb-48de-a251-d01086f4fa90"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f6d0c1c0-59dd-466d-9521-afefd098b9ec"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateCreateVirtualDataSourceStructureMethod() {
			SchemaMethod method = base.CreateCreateVirtualDataSourceStructureMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,93,111,155,48,20,125,78,165,254,7,198,83,162,77,252,129,125,72,73,90,85,72,221,20,133,38,123,118,225,38,241,10,54,178,77,51,52,245,191,207,198,6,39,96,218,148,84,106,31,125,125,124,125,238,185,231,98,30,17,243,18,36,80,68,11,22,131,247,221,91,160,45,4,87,77,228,235,229,197,163,132,240,120,7,25,146,219,22,27,68,85,204,0,128,8,44,74,29,250,137,136,76,194,234,100,43,14,108,78,9,129,88,96,74,130,235,46,210,228,136,105,90,100,68,30,35,176,247,44,133,72,176,34,22,5,131,185,222,255,119,121,49,26,253,66,153,98,235,135,137,255,69,173,215,40,45,12,160,189,165,50,85,219,119,101,14,166,132,102,109,24,4,55,32,66,194,5,34,49,204,74,149,97,236,223,20,56,241,39,85,138,57,202,21,247,195,172,33,95,99,142,239,83,149,113,131,82,14,38,26,81,38,208,65,88,70,159,100,125,163,4,54,77,33,193,52,73,52,215,177,174,121,162,16,67,202,143,74,174,149,236,85,161,65,52,114,96,158,167,168,236,65,153,74,207,83,238,150,210,135,34,55,218,45,97,3,12,228,174,190,96,21,38,50,147,195,46,174,68,235,189,165,79,126,83,246,192,115,20,131,63,9,100,22,87,242,186,156,158,115,174,35,11,134,51,196,74,183,117,108,223,245,0,4,26,198,21,215,154,99,84,220,255,145,214,110,170,147,236,204,177,142,79,62,69,59,186,95,226,237,78,240,89,105,206,189,151,109,166,73,134,201,138,96,241,156,115,26,208,75,230,105,128,42,246,145,204,99,203,60,205,52,45,89,94,99,22,55,214,169,152,85,233,36,135,29,151,209,231,46,217,240,243,63,66,183,152,139,111,92,48,76,182,63,60,28,83,98,137,115,227,177,67,200,120,162,141,229,207,17,89,2,50,74,168,213,52,207,129,28,172,175,147,90,83,181,186,130,20,4,248,53,175,176,115,81,235,106,5,218,80,6,40,222,121,99,125,183,121,46,42,73,49,105,31,48,188,94,51,28,245,116,216,188,21,93,199,104,180,17,174,30,119,48,3,199,97,70,105,10,136,152,121,56,197,47,246,230,99,175,244,60,89,110,187,232,190,156,96,152,51,37,246,62,123,190,145,207,127,89,238,46,250,121,233,29,248,129,109,184,131,191,226,173,123,208,12,236,153,45,120,26,248,10,44,40,199,246,177,119,188,0,199,0,231,151,172,5,25,168,110,72,4,200,173,206,223,86,255,55,177,185,183,255,123,248,6,127,101,255,1,141,198,214,84,30,11,0,0 };
			return method;
		}

		protected override SchemaMethod CreateChangeRightItemPositionMethod() {
			SchemaMethod method = base.CreateChangeRightItemPositionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,177,10,195,48,16,67,247,126,69,198,4,130,127,32,163,201,16,40,52,180,180,251,197,61,236,43,241,217,216,231,33,127,95,55,45,89,58,74,122,18,90,32,163,210,14,216,226,149,172,147,73,208,207,33,147,80,224,54,38,242,144,54,29,214,226,249,1,107,193,190,137,191,176,111,136,77,194,90,159,15,39,151,229,133,70,110,198,161,135,110,56,93,34,38,248,68,231,96,45,38,53,113,22,96,131,170,234,145,133,100,251,162,7,183,95,24,159,36,237,61,99,210,129,185,206,237,211,255,87,186,225,13,168,121,63,220,188,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetSelectForVirtualDataSourceMethod() {
			SchemaMethod method = base.CreateGetSelectForVirtualDataSourceMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,205,78,219,64,16,62,131,196,59,44,233,197,22,200,252,28,218,67,160,146,19,82,228,86,144,40,86,224,128,80,181,141,23,178,197,89,167,187,235,34,171,66,106,233,177,149,122,239,99,84,173,68,75,69,95,193,121,163,206,238,26,199,196,38,137,20,18,60,243,125,223,204,206,204,78,66,207,144,21,189,121,75,250,178,131,57,30,18,73,184,64,187,187,136,197,97,104,163,15,43,203,75,205,40,12,193,77,35,182,179,31,211,224,57,194,193,144,178,30,163,114,226,65,64,32,151,104,26,106,217,117,16,80,255,162,51,26,130,52,0,226,33,59,194,97,76,128,226,19,133,38,193,97,20,144,14,167,67,204,147,2,64,81,41,100,215,193,231,196,113,195,240,128,176,216,147,100,232,52,7,164,127,65,2,147,29,64,172,213,146,184,227,137,214,112,36,19,203,206,80,75,213,73,107,237,158,80,92,198,140,213,217,107,248,164,31,115,42,147,22,59,167,140,56,251,68,42,136,91,86,176,74,129,245,129,151,174,224,237,10,145,80,16,19,189,34,184,227,6,193,35,116,197,46,183,68,23,216,152,79,170,244,154,81,204,228,169,226,159,69,28,89,148,73,68,129,181,89,135,143,157,170,158,25,6,184,215,214,178,34,77,7,61,161,167,160,80,65,5,71,150,40,188,116,123,69,127,64,134,216,11,0,111,41,131,93,210,218,84,148,2,182,167,193,234,80,202,168,39,69,117,59,23,90,221,213,14,71,247,209,36,88,36,30,71,252,66,140,112,159,244,36,13,169,164,68,168,62,249,247,136,70,226,5,185,214,58,122,216,98,21,11,18,127,143,57,34,76,66,163,13,237,0,51,24,7,14,226,83,19,209,42,131,234,134,206,233,249,64,10,227,1,94,133,154,202,202,99,66,98,214,39,141,228,16,170,97,129,165,61,34,28,43,237,174,18,48,4,237,179,237,76,89,232,187,145,85,200,92,20,171,98,90,109,213,55,199,76,144,85,204,198,81,114,235,168,230,5,181,185,24,63,214,205,202,139,87,179,29,87,88,53,63,201,112,211,26,181,163,203,137,143,229,157,168,129,84,19,143,84,90,211,10,185,121,110,42,137,200,239,89,41,108,209,169,130,41,206,36,82,238,50,230,217,145,32,81,214,37,120,110,113,20,206,29,141,8,91,8,217,10,32,177,185,103,4,224,30,52,84,206,77,18,213,58,145,160,229,194,205,168,127,47,43,154,243,130,71,195,178,164,118,121,48,60,252,101,68,167,43,106,59,237,138,34,235,113,128,117,250,46,198,225,162,45,115,218,60,32,188,145,184,162,191,224,192,45,64,154,212,2,97,145,93,9,184,44,27,27,79,54,96,113,120,254,235,227,118,247,149,223,113,155,45,101,76,191,167,119,233,207,117,148,254,73,239,198,215,240,247,113,252,37,253,173,31,211,191,233,191,244,38,189,77,111,192,248,57,253,53,190,30,127,26,127,67,10,149,222,142,191,42,8,74,127,76,54,12,106,118,183,158,109,111,109,63,53,27,202,31,68,151,250,218,138,70,146,29,36,91,79,58,165,98,121,31,233,147,41,244,156,38,206,174,121,169,128,245,73,2,199,3,194,201,226,250,102,168,156,124,85,91,249,154,213,203,168,240,61,246,64,127,145,81,128,90,148,228,69,233,231,134,157,237,227,76,222,101,193,172,228,193,158,63,207,62,199,212,22,207,89,78,118,50,213,204,85,79,228,187,88,167,78,133,132,167,251,95,23,139,165,52,167,158,133,175,177,236,164,106,102,97,165,208,179,149,101,78,100,204,89,182,238,235,255,1,144,194,129,141,142,9,0,0 };
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

		protected override SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterCopyPageScriptMethod();
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

		protected virtual SchemaMethod CreateCellIconClickMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("71cddcf3-1838-41b8-8cb2-62c6d8956947"),
				Name = "CellIconClick",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("59579bb7-6397-4840-9696-713fb25b8201"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("363e0cce-7279-4419-9727-eec96fa37527"),
				Name = "e",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,207,74,3,49,16,198,207,45,244,29,198,28,74,2,37,47,80,122,144,118,17,111,82,171,23,245,48,36,211,26,200,38,101,54,91,93,196,119,111,54,217,94,4,79,3,243,253,249,125,23,100,8,209,210,163,133,13,144,110,190,19,227,19,50,182,148,136,187,55,81,53,241,177,94,204,47,217,234,76,12,255,89,171,86,172,15,189,179,16,232,107,27,125,223,134,87,244,61,229,204,248,213,77,123,78,67,182,184,35,72,57,145,239,54,16,122,239,21,44,151,32,39,196,237,167,224,103,49,159,149,66,38,19,217,22,124,238,46,117,48,85,232,61,157,61,26,146,226,93,136,21,116,137,93,56,85,150,82,153,54,27,199,155,178,38,167,43,226,79,70,8,165,15,236,218,38,88,41,118,174,203,218,32,244,33,110,63,145,239,153,113,144,181,105,79,22,77,34,251,76,158,198,251,210,17,203,219,180,213,4,25,157,191,87,141,217,49,238,92,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRedactedSelectedUserMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("05cde36d-bd06-4dfa-8af1-39d2a0985a74"),
				Name = "RedactedSelectedUser",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("20ba97e0-fedf-4448-93e4-187acb2f70b4"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9ae8e855-c04c-4993-86af-1a1a2f96aae3"),
				Name = "redactedColumnName",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,77,143,218,48,16,61,103,165,253,15,222,156,130,20,89,61,151,102,37,8,176,66,218,221,174,160,208,67,213,131,137,167,224,214,177,35,219,89,138,170,253,239,181,99,3,9,108,43,14,112,32,100,230,205,188,55,31,54,75,166,76,77,248,136,24,50,151,181,42,0,189,158,89,50,244,0,102,121,106,78,122,253,219,155,177,48,204,236,230,197,6,74,130,180,127,100,232,133,172,1,31,145,216,251,15,112,4,254,145,133,8,156,43,32,6,188,51,105,130,23,26,84,46,133,128,194,48,41,28,19,251,129,18,31,135,39,96,138,205,68,201,114,52,76,20,20,82,209,41,237,245,208,159,219,155,104,52,156,67,81,43,139,26,139,53,19,128,116,247,53,67,221,204,248,52,192,50,69,15,53,163,72,215,171,159,22,227,165,79,169,141,12,236,182,23,95,118,21,208,92,242,186,20,75,194,107,248,228,34,238,147,120,222,142,89,76,105,236,132,71,218,40,38,214,33,220,251,158,73,249,142,150,118,51,159,136,176,125,80,142,109,106,160,28,238,108,186,228,68,83,15,187,60,7,197,132,150,76,44,4,51,151,170,221,233,193,49,196,107,93,73,201,17,211,3,206,229,22,92,154,187,255,228,113,224,123,59,1,74,10,179,247,56,69,77,38,47,242,115,5,138,184,226,102,108,189,49,143,240,10,92,35,117,248,109,9,254,141,195,207,210,207,195,168,93,51,220,72,111,153,157,60,122,143,210,3,162,130,104,64,113,78,196,12,8,141,63,54,182,168,187,3,120,14,166,221,105,135,180,243,9,37,39,173,46,166,103,51,75,143,189,105,138,180,159,149,221,221,95,253,46,249,160,170,64,92,72,239,177,87,22,48,166,204,92,70,239,144,87,38,31,1,7,3,151,209,55,216,171,240,191,217,175,55,84,144,102,65,14,103,250,119,1,149,91,171,227,61,176,183,132,141,121,2,173,237,65,123,33,194,110,99,217,126,201,144,61,154,70,73,190,48,140,219,38,129,198,19,38,104,48,250,107,106,160,171,230,25,140,250,219,135,239,41,138,135,182,19,237,188,113,138,140,170,237,142,18,141,218,246,70,183,187,215,58,188,119,25,18,53,231,251,141,110,251,112,206,129,168,36,20,223,241,12,40,13,169,147,175,68,9,219,210,244,188,102,28,32,233,94,134,59,210,56,224,123,199,54,186,75,171,59,182,134,184,123,72,117,78,236,100,26,49,54,224,236,95,3,63,74,66,103,114,123,184,161,83,95,86,255,47,138,227,144,188,114,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("618a0921-a2a3-4665-bb71-9cd191de7c5a"),
				Name = "GetEntity",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("51c3a14f-70ed-4d4a-994c-877e6875b2e1"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,93,111,211,48,20,125,206,164,253,7,83,94,156,169,164,218,30,64,162,108,168,77,59,84,33,109,85,179,117,15,8,33,47,113,87,67,106,23,199,105,153,166,73,48,30,65,226,157,159,129,64,26,12,141,191,144,254,35,174,227,124,244,99,19,67,106,234,228,250,156,115,175,207,181,61,33,18,69,52,164,190,66,219,232,25,85,94,250,190,43,100,159,73,21,147,176,69,20,241,68,44,125,138,121,28,134,118,125,125,205,192,157,6,15,48,16,246,199,84,18,197,4,239,177,147,161,242,252,33,29,145,61,50,162,216,174,162,74,39,168,216,78,39,106,191,5,37,236,138,48,30,113,167,75,36,76,43,42,177,164,190,144,65,39,176,181,42,204,106,89,16,122,18,41,201,248,201,14,242,83,66,159,132,49,213,138,17,84,200,233,20,173,34,177,141,206,214,215,44,157,174,90,241,78,35,83,197,226,151,75,198,154,82,129,170,32,214,8,70,140,31,114,166,52,104,49,162,83,233,152,75,120,143,146,32,123,109,140,199,148,231,31,237,128,169,236,181,5,102,168,20,223,21,17,75,51,172,175,157,195,122,38,96,236,100,217,67,227,241,170,181,118,70,144,98,10,144,21,154,227,74,74,20,237,137,105,138,140,35,88,52,194,154,16,28,183,223,81,63,86,66,2,239,48,162,210,21,156,27,115,156,54,143,98,73,91,205,50,132,109,99,212,156,0,8,7,84,147,179,174,26,57,218,75,195,184,148,207,152,214,116,200,66,138,176,161,57,26,150,139,90,22,227,10,65,67,25,39,33,8,62,216,172,167,209,129,0,176,63,52,233,150,90,138,24,95,233,114,174,102,149,82,89,54,189,219,76,12,47,145,108,147,202,98,3,132,239,101,232,78,212,106,238,193,150,197,153,78,81,166,129,45,41,56,158,34,82,69,71,76,13,177,238,107,101,14,110,65,91,28,143,42,183,164,44,211,171,203,230,183,154,7,167,99,10,129,9,149,176,215,225,59,197,30,136,166,16,33,46,23,100,212,138,18,243,133,88,231,136,134,17,253,191,18,110,85,45,68,205,104,6,243,95,219,72,135,178,55,105,91,182,209,194,49,50,252,127,247,99,174,21,119,235,196,179,152,5,40,202,210,172,238,224,91,77,212,188,204,196,23,153,232,75,157,184,86,187,95,131,204,29,239,213,209,126,239,185,215,109,184,109,29,76,190,38,215,201,247,42,74,126,37,215,179,11,120,222,207,62,37,63,211,207,228,119,242,39,185,76,174,146,75,8,126,76,126,204,46,102,31,102,95,144,70,37,87,179,207,26,130,146,111,232,72,200,55,209,152,192,9,118,123,155,143,182,54,183,30,154,5,24,223,120,144,158,252,252,130,106,177,180,124,34,79,179,11,170,138,196,241,107,88,211,78,209,207,51,84,57,76,175,158,98,241,231,213,114,10,188,47,18,2,166,75,78,168,179,100,77,49,239,104,110,214,215,122,89,84,148,183,175,207,232,52,171,235,128,74,73,34,49,80,142,11,103,18,254,248,128,157,196,230,246,118,250,211,178,227,188,80,199,55,228,206,183,211,66,10,103,151,42,127,184,43,197,168,213,196,165,35,57,246,134,237,187,120,81,47,22,236,128,57,118,189,86,123,58,135,121,12,177,59,136,149,247,252,162,98,22,207,119,9,92,230,108,96,206,193,70,77,143,218,67,120,224,39,169,138,37,215,119,113,253,47,43,33,36,235,30,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnDataSourceLoadingRowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9ab721f3-9eec-4673-a597-b342dd251e46"),
				Name = "OnDataSourceLoadingRow",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0ecd1d4a-61f5-4565-9103-b060dbd23ffc"),
				Name = "dataSourceRequest",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceRequest",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,206,191,10,194,48,16,128,241,221,167,184,49,89,242,0,150,80,68,75,112,147,10,221,67,239,134,64,254,232,245,14,201,219,219,197,46,206,223,111,248,130,38,4,166,181,49,222,17,60,0,70,137,207,166,188,210,76,111,165,77,192,123,168,154,51,140,16,118,236,166,242,146,14,231,127,232,30,156,74,228,126,109,89,75,93,98,86,26,78,129,100,73,44,26,243,237,240,198,186,185,125,54,119,65,52,123,159,170,36,233,230,55,97,237,240,5,162,100,41,76,149,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetOperationsRightLevelMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f5af585-1a10-40ca-ae22-875e1fc9285f"),
				Name = "SetOperationsRightLevel",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3d77ca10-385a-4c33-ae05-b273cbaf9a07"),
				Name = "adminUnitId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6eb232fb-d6fb-4988-9c5b-de481cf00ce3"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d41decef-5179-4275-895e-f554d63d6faf"),
				Name = "rightLevel",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SchemaOperationRightLevels",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,11,78,45,113,205,43,1,242,131,147,51,82,115,19,253,11,82,139,18,65,42,139,131,50,211,51,74,124,82,203,82,115,52,18,83,114,51,243,66,243,50,75,60,83,116,20,138,193,234,66,65,204,34,184,18,77,107,0,252,31,86,96,111,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetOperationRightSchemaNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("875a8559-3faa-45f5-bbfb-80336f06ecef"),
				Name = "GetOperationRightSchemaName",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,10,174,44,118,205,43,201,44,169,12,78,206,72,205,77,244,47,72,45,74,44,201,204,207,11,202,76,207,40,81,178,6,0,74,92,203,4,39,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteOperationsRightLevelMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("77b59b26-fac8-4e39-af85-e42242acec32"),
				Name = "DeleteOperationsRightLevel",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e53ef7fe-ddbd-4af0-a25b-6f89dbbc941c"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,73,205,73,45,73,117,205,43,1,10,5,39,103,164,230,38,250,23,164,22,37,130,20,7,101,166,103,148,248,164,150,165,230,104,20,165,38,231,23,165,120,166,104,90,3,0,64,51,242,1,80,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetIsAdministratedByOperationsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6639a19d-d6d7-4963-a53f-f4dc4023e8ed"),
				Name = "SetIsAdministratedByOperations",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,81,77,79,2,49,16,189,155,248,31,154,61,45,9,105,56,139,98,112,131,134,131,128,89,133,131,241,48,208,81,170,221,118,105,187,75,250,239,157,165,97,1,149,163,183,230,245,125,229,77,13,150,161,246,210,135,124,181,198,2,30,65,195,7,90,118,195,94,28,218,204,104,141,43,47,141,230,163,223,164,254,229,69,77,242,77,133,54,144,64,227,150,29,179,158,26,60,253,195,188,203,146,249,118,97,236,151,43,97,133,211,229,39,69,184,164,67,118,209,16,68,33,181,116,222,130,71,113,23,166,37,210,139,58,56,10,217,133,241,161,16,153,81,85,161,211,100,120,142,188,51,140,244,123,169,60,90,215,200,210,136,100,22,137,31,241,133,244,235,25,88,40,176,33,165,17,204,76,81,130,149,206,232,231,80,34,31,109,42,80,212,123,44,146,46,203,81,81,99,20,19,35,112,102,101,1,54,196,54,115,80,21,118,254,35,55,15,174,29,140,26,204,104,70,254,227,64,237,63,31,139,93,135,122,127,90,137,135,229,30,208,199,27,81,99,21,149,233,169,81,35,29,187,118,199,147,125,201,102,239,200,51,83,105,207,6,172,199,110,91,240,181,247,214,36,52,213,197,209,36,215,75,99,212,32,61,123,87,62,161,17,58,236,138,189,131,114,216,255,6,107,93,72,132,148,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLookupUserTaskSchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("28836b51-9777-4ed5-80fa-f5138da559c3"),
				Name = "GetLookupUserTaskSchemaUId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,203,187,14,131,32,20,0,208,95,33,76,117,184,137,32,194,189,237,96,2,193,238,245,11,42,143,106,7,77,44,196,244,239,187,246,236,231,72,165,30,27,155,150,253,124,172,175,165,124,236,119,170,243,59,133,194,6,182,165,147,221,235,26,47,60,246,177,21,57,68,208,17,3,168,89,18,80,234,17,66,120,118,57,39,45,59,173,120,195,174,127,69,141,94,183,100,12,56,35,4,40,180,18,80,17,129,112,222,90,239,70,131,26,121,115,251,1,21,114,69,76,129,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntitySchemaOperationAllowedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("452c18cf-e6b8-48a5-84c0-c5d548455102"),
				Name = "SetEntitySchemaOperationAllowed",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2bbccaa0-d245-4901-a43e-7bae5bc1af96"),
				Name = "adminUnitId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f75cc75e-c5c6-4d78-a0c4-85e889da077b"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5ecedd08-e7e0-4acf-8820-7f3898b7a1dc"),
				Name = "rightLevel",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SchemaOperationRightLevels",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("55d10bae-dcb5-46fc-8ce2-7e03abb699f4"),
				Name = "isAllowed",
				CreatedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				ModifiedInSchemaUId = new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,202,77,10,194,48,20,69,225,173,100,168,80,186,1,71,254,116,32,8,14,66,22,16,146,75,251,32,189,145,151,87,197,221,219,22,103,231,192,167,176,69,233,66,131,94,43,137,100,82,217,223,46,30,105,81,177,239,192,81,136,222,195,6,218,250,62,77,152,227,243,5,141,155,60,151,82,63,200,135,152,103,97,160,216,61,119,174,237,38,108,169,50,78,246,192,27,165,115,210,254,250,120,250,1,190,52,184,1,118,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectsByOperationsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0377612c-70b3-44db-b7b4-cd6e2b680c06"));
		}

		#endregion

	}

	#endregion

}

