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
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: AdministrativeUsersAndRolesPageSchema

	/// <exclude/>
	public class AdministrativeUsersAndRolesPageSchema : Terrasoft.WebApp.BaseModulePageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Tab _unitsTab;
		public Terrasoft.UI.WebControls.Controls.Tab UnitsTab {
			get {
				return _unitsTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _units;
		public Terrasoft.UI.WebControls.Controls.PageContainer Units {
			get {
				return _units;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrativeUsersAndRolesPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeUsersAndRolesPageSchema(AdministrativeUsersAndRolesPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateBaseFolder() {
			BaseFolder.PageSchemaUId = new Guid("18160053-0792-4f79-a7d8-f1bac6b6e4b2");
			BaseFolder.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateGrid() {
			Grid.PageSchemaUId = new Guid("03512113-977d-446f-b73e-579eef4a0eb0");
			Grid.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
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
			RightControlLayout.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
			RealUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
			Name = "AdministrativeUsersAndRolesPage";
			ParentSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeUsersAndRolesPageEventsProcessSchema();
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
			UpdateBaseFolder();
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
			GridTabPanel.InsertItem(1, CreateUnitsTab());
			UnitsTab.InsertItem(0, CreateUnits());
			RightControlLayout.MoveItem(1, DetailsTabPanel);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeUsersAndRolesPageEventsProcessSchema() {
			var schema = new AdministrativeUsersAndRolesPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateUnits() {
			_units = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_units.UId = new Guid("b50d1d72-8ecd-4557-803b-8b7cc23df6a9");
			_units.Name = "Units";
			_units.CreatedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
			_units.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
			_units.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_units.Tag = "";
			_units.PageSchemaUId = new Guid("52e61f9e-f7d9-47f1-a48a-5241248f1d90");
			_units.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_units.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_units.StartNewAlignGroup = false;
			_units.Edges = "";
			return _units;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateUnitsTab() {
			_unitsTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_unitsTab.UId = new Guid("4e29dfd8-6878-4e83-82fa-3b91687f407f");
			_unitsTab.Name = "UnitsTab";
			_unitsTab.CreatedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
			_unitsTab.ModifiedInSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
			_unitsTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_unitsTab.HelpContextId = "257";
			_unitsTab.Tag = "";
			_unitsTab.Image = new ControlImage {};
			return _unitsTab;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeUsersAndRolesPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeUsersAndRolesPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeUsersAndRolesPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeUsersAndRolesPageEventsProcess

	/// <exclude/>
	public class AdministrativeUsersAndRolesPageEventsProcess<TPage> : Terrasoft.WebApp.BaseModulePageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeUsersAndRolesPageSchemaUserControl
	{

		public AdministrativeUsersAndRolesPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeUsersAndRolesPageEventsProcess";
			SchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5");
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

		public virtual Guid ParentRoleId {
			get;
			set;
		}

		private ProcessFlowElement _subProcessGridTabPanelTabChange;
		public ProcessFlowElement SubProcessGridTabPanelTabChange {
			get {
				return _subProcessGridTabPanelTabChange ?? (_subProcessGridTabPanelTabChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessGridTabPanelTabChange",
					SchemaElementUId = new Guid("f7c10665-bb6c-42fa-8eee-4aa5804d7015"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _gridTabPanelTabChangeMessage;
		public ProcessFlowElement GridTabPanelTabChangeMessage {
			get {
				return _gridTabPanelTabChangeMessage ?? (_gridTabPanelTabChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridTabPanelTabChangeMessage",
					SchemaElementUId = new Guid("9e0d1340-c32d-4117-82be-673e2d0c643b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _gridThrowGridActiveRowChanged;
		public ProcessThrowMessageEvent GridThrowGridActiveRowChanged {
			get {
				return _gridThrowGridActiveRowChanged ?? (_gridThrowGridActiveRowChanged = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "GridThrowGridActiveRowChanged",
					SchemaElementUId = new Guid("bb29ef80-5336-40a0-89c3-ab6b612f02bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "FolderActiveRowChanged",
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
					SchemaElementUId = new Guid("92607963-7427-4276-b09d-9375be0091f2"),
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
					SchemaElementUId = new Guid("2856e913-9b4d-43da-b860-aa91efb05813"),
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
					SchemaElementUId = new Guid("2cb76491-3155-438a-87ee-923f502282d0"),
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
					SchemaElementUId = new Guid("ff8ce80e-2b08-44c2-bf6d-6991b1c4d510"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_1;
		public ProcessFlowElement EventSubProcess3_1 {
			get {
				return _eventSubProcess3_1 ?? (_eventSubProcess3_1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_1",
					SchemaElementUId = new Guid("b54a2998-18c3-4976-bc53-491f6131cc60"),
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
					SchemaElementUId = new Guid("325fc627-29ca-4e42-ab95-064abdae7039"),
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
					SchemaElementUId = new Guid("e4212b2b-d9f7-471a-b93b-365295c51c22"),
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
					SchemaElementUId = new Guid("fae96e3f-c220-4c92-aad7-dc4469f257cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessGridActiveRowChangedChild;
		public ProcessFlowElement EventSubProcessGridActiveRowChangedChild {
			get {
				return _eventSubProcessGridActiveRowChangedChild ?? (_eventSubProcessGridActiveRowChangedChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessGridActiveRowChangedChild",
					SchemaElementUId = new Guid("382a3a3f-dd53-411e-aca4-b9236b916943"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _gridActiveRowChangedChild;
		public ProcessFlowElement GridActiveRowChangedChild {
			get {
				return _gridActiveRowChangedChild ?? (_gridActiveRowChangedChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridActiveRowChangedChild",
					SchemaElementUId = new Guid("32356a62-0cb5-454b-b692-c275c79056ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGridActiveRowChangedChild;
		public ProcessScriptTask ScriptGridActiveRowChangedChild {
			get {
				return _scriptGridActiveRowChangedChild ?? (_scriptGridActiveRowChangedChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGridActiveRowChangedChild",
					SchemaElementUId = new Guid("764c2ca7-7992-4fa0-9aaf-46ba06063e6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridActiveRowChangedChildExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessGridTabPanelTabChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessGridTabPanelTabChange };
			FlowElements[GridTabPanelTabChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { GridTabPanelTabChangeMessage };
			FlowElements[GridThrowGridActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { GridThrowGridActiveRowChanged };
			FlowElements[SubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess13 };
			FlowElements[InitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitChild };
			FlowElements[ScriptInitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitChild };
			FlowElements[ThrowInitParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowInitParent };
			FlowElements[EventSubProcess3_1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_1 };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[ThrowPageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadCompleteParent };
			FlowElements[EventSubProcessGridActiveRowChangedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessGridActiveRowChangedChild };
			FlowElements[GridActiveRowChangedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { GridActiveRowChangedChild };
			FlowElements[ScriptGridActiveRowChangedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridActiveRowChangedChild };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessGridTabPanelTabChange":
						break;
					case "GridTabPanelTabChangeMessage":
						e.Context.QueueTasks.Enqueue("GridThrowGridActiveRowChanged");
						break;
					case "GridThrowGridActiveRowChanged":
						break;
					case "SubProcess13":
						break;
					case "InitChild":
						e.Context.QueueTasks.Enqueue("ScriptInitChild");
						break;
					case "ScriptInitChild":
						e.Context.QueueTasks.Enqueue("ThrowInitParent");
						break;
					case "ThrowInitParent":
						break;
					case "EventSubProcess3_1":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadCompleteParent");
						break;
					case "ScriptPageLoadCompleteChild":
						break;
					case "ThrowPageLoadCompleteParent":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "EventSubProcessGridActiveRowChangedChild":
						break;
					case "GridActiveRowChangedChild":
						e.Context.QueueTasks.Enqueue("ScriptGridActiveRowChangedChild");
						break;
					case "ScriptGridActiveRowChangedChild":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("GridTabPanelTabChangeMessage");
			ActivatedEventElements.Add("InitChild");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("GridActiveRowChangedChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessGridTabPanelTabChange":
					context.QueueTasks.Dequeue();
					break;
				case "GridTabPanelTabChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridTabPanelTabChangeMessage";
					result = GridTabPanelTabChangeMessage.Execute(context);
					break;
				case "GridThrowGridActiveRowChanged":
					context.QueueTasks.Dequeue();
					result = GridThrowGridActiveRowChanged.Execute(context);
					break;
				case "SubProcess13":
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
				case "EventSubProcess3_1":
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
				case "EventSubProcessGridActiveRowChangedChild":
					context.QueueTasks.Dequeue();
					break;
				case "GridActiveRowChangedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridActiveRowChangedChild";
					result = GridActiveRowChangedChild.Execute(context);
					break;
				case "ScriptGridActiveRowChangedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridActiveRowChangedChild";
					result = ScriptGridActiveRowChangedChild.Execute(context, ScriptGridActiveRowChangedChildExecute);
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
				case "ParentRoleId":
					ParentRoleId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptInitChildExecute(ProcessExecutingContext context) {
			SysModuleId = new Guid("67F54130-F46B-1410-0581-485B39B2EDCC");
			FolderEntitySchemaUId = new Guid("D5D01FCD-6D8C-4B29-9E58-CCA3FFE62364");
			FolderEntryEntitySchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			var gridInstance = Page.Units.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			gridInstance.Process.SetPropertyValue("ListenerPage", Page);
			gridInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			return true;
		}

		public virtual bool ScriptGridActiveRowChangedChildExecute(ProcessExecutingContext context) {
			PageContainer gridPageContainer = null;
			var activeGridTab = Page.GridTabPanel.Tabs[Page.GridTabPanel.ActiveTabIndex];
			foreach (var item in activeGridTab.Items) {
			         gridPageContainer = item as PageContainer;
			         if (gridPageContainer != null) {
			                   break;
			         }
			}
			if (gridPageContainer == null) {
			         return true;
			}
			var dataSource = (gridPageContainer.FindPageControlByName("DataSource")) as DataSource;
			if (dataSource == null) {
				return true;
			}
			if (HasAnalytics) {
				var selectedRows = new Dictionary<string, object>();
				selectedRows.Add("Item1", dataSource.Schema.Name);
				selectedRows.Add("Item2", dataSource.Schema.GetPrimaryColumnName());
				selectedRows.Add("Item3", GetSelectedActiveRows());
				var analyticsGridPageContainer = (Page as PageSchemaUserControl).PageContainer.FindPageControlByName("analyticsGridPageContainer") 
													as PageContainer;
				if (analyticsGridPageContainer != null) {
				         analyticsGridPageContainer.PageInstance.Process.SetPropertyValue("SelectedActiveRows", selectedRows);
				}
			}
			var detailsTabPanel = Page.DetailsTabPanel;
			if(detailsTabPanel.Tabs.Count == 0) {
			         return true;
			}
			PageContainer detailPageContainer = null; 
			var activeTab = detailsTabPanel.Tabs[detailsTabPanel.ActiveTabIndex];
			foreach (var item in activeTab.Items) {
			         detailPageContainer = item as PageContainer;
			         if (detailPageContainer != null) {
			                   break;
			         }
			}
			if (detailPageContainer == null) {
			         return true;
			}
			var parentColumnMetaPath = detailPageContainer.PageInstance.Process.GetPropertyValue("ParentColumnMetaPath");
			Guid filterColumnValue = Guid.Empty;
			if (dataSource != null && dataSource.Schema != null) {
					string filterColumnName = dataSource.Schema.PrimaryColumn.Name;
					if (parentColumnMetaPath != null && !parentColumnMetaPath.ToString().Equals(String.Empty)) {
						filterColumnName = parentColumnMetaPath.ToString();
					}
			        var gridPage = gridPageContainer.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
					if(gridPage == null) {
						return true;
					}
			         var selectedNodes = gridPage.TreeGrid.SelectedNodes;
			         if(selectedNodes.Count > 0) {
			                   filterColumnValue = new Guid(selectedNodes[0].Values[filterColumnName].ToString());
			         } else {
			                   if(dataSource.Rows.Count.Equals(0)) {
									filterColumnValue = Guid.Empty;
			                   } else {
			                        filterColumnValue = new Guid(dataSource.Rows[0].GetColumnValue(filterColumnName).ToString());
			                   }
			         }
			}
			detailPageContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", filterColumnValue);
			string schemaName = dataSource.Schema.Name;
			//detailPageContainer.PageInstance.Process.SetPropertyValue("CurrentGridSchemaName", schemaName);
			FilterColumnValue = filterColumnValue;
			Page.ThrowEvent("RefreshDetails");
			return true;
		}

		public override DataSource GetActiveDataSource() {
			var tabPanel = Page.GridTabPanel;
			if (tabPanel.Tabs.Count == 0) {
				return null;
			}
			var activeTab = tabPanel.Tabs[tabPanel.ActiveTabIndex];
			if (activeTab.Items.Count == 0) {
				return null;
			}
			PageControl control = activeTab.Items[0].FindPageControlByName("DataSource");
			return control as DataSource;
		}

		public override void ApplyFilters() {
			var tabPanel = Page.GridTabPanel;
			if (tabPanel.Tabs.Count == 0) {
				return;
			}
			var activeTab = tabPanel.Tabs[tabPanel.ActiveTabIndex];
			if (activeTab.Items.Count == 0) {
				return;
			}
			var treeGrid = activeTab.Items[0].FindPageControlByName("TreeGrid") as TreeGrid;
			treeGrid.RefreshData();
		}

		public override void BaseApplyModuleFilters() {
			var pageInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var dataSource = pageInstance.DataSource;
			var pageUnitsInstance = Page.Units.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var unitsDataSource = pageUnitsInstance.DataSource;
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_selectedParentRoleId"] = ParentRoleId.ToString();
			var oldDataSourceConnectionTypeFilter = dataSource.CurrentStructure.Filters.FindByName("ConnectionTypeFilter");
			if (oldDataSourceConnectionTypeFilter != null) {
				dataSource.CurrentStructure.Filters.Remove(oldDataSourceConnectionTypeFilter);
			}
			if (!IsRootFolder && ParentRoleId != Guid.Empty) {
				ISchemaManagerItem folderEntryEntitySchema =  Page.UserConnection.GetSchemaManager("EntitySchemaManager").
					GetItemByUId(FolderEntryEntitySchemaUId) as ISchemaManagerItem;
				var folderPageInstance = Page.BaseFolder.PageInstance as Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl;
				var folderDataSource = folderPageInstance.DataSource;
				var folderEntitySchema = folderDataSource.Schema;
				SetDetailFilter.FilterName = "FolderFilter";
				SetDetailFilter.FilterLeftExpressions = new  string[] 
					{string.Concat(new string[] { "[", folderEntryEntitySchema.Name, ":SysUser].SysRole.", 
					folderEntitySchema.PrimaryColumn.Name})};
				Select adminUnitSelect =
						new Terrasoft.Core.DB.Select(Page.UserConnection)
							.Column("Id").As("Id")
							.Column("Name").As("Name")
							.Column("ParentRoleId").As("ParentRoleId")
						.From("SysAdminUnit")
						.Where("SysAdminUnitTypeValue")
							.IsLess(Column.Parameter(4, "AdminUnitType", Common.ParameterDirection.Input)) as Select;
					HierarchicalSelectOptions options = new HierarchicalSelectOptions() {
						PrimaryColumnName = "Id",
						ParentColumnName = "ParentRoleId",
						SelectType = HierarchicalSelectType.Children
					};
					QueryCondition startingCondition = options.StartingPrimaryColumnCondition;
					startingCondition.LeftExpression = new QueryColumnExpression("ParentRoleId");
					startingCondition.IsEqual(Column.Parameter(ParentRoleId, "FolderId", Common.ParameterDirection.Input));
					adminUnitSelect.HierarchicalOptions = options;
					var list = new System.Collections.ObjectModel.Collection<object>();
					using (var dbExecutor = UserConnection.EnsureDBConnection()) {
						using (var reader = adminUnitSelect.ExecuteReader(dbExecutor)) {
							while (reader.Read()) {
								var id = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]);
								list.Add(id);
							}
						}
					}
				var objectParams = new object[list.Count + 1];
				objectParams[0] = ParentRoleId;
				for (int i = 0; i < list.Count; i++) {
					objectParams[i + 1] = list[i];
				}
				SetDetailFilter.FilterRightValue = objectParams;
				var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
				Guid workspaceId;
			//#/if IS_WORKSPACE
			//Код, который компилируется только в Workspace CR172136
				workspaceId = Page.UserConnection.Workspace.Id;
			//#/endif
			
				var filter = SetDetailFilter.CreateFilter(dataSource, workspaceId, UserConnection);
				filter.Name = "FolderFilter";//String.Empty;
				dataSource.CurrentStructure.Filters.Add(filter);
			
				/*SetDetailFilter.FilterLeftExpressions = new  string[] {"Id"};
				SetDetailFilter.FilterRightValue = ParentRoleId;*/
				oldDataSourceFolderFilter = unitsDataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					unitsDataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
				filter = SetDetailFilter.CreateFilter(unitsDataSource, workspaceId, UserConnection);
				filter.Name = "FolderFilter";
				filter.Add(unitsDataSource.CurrentStructure.CreateFilterWithParameters(unitsDataSource.Schema,
					Terrasoft.Core.Entities.FilterComparisonType.Equal, "ParentRole", ParentRoleId));
				unitsDataSource.CurrentStructure.Filters.Add(filter);
			}
			if (IsRootFolder) {
				var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
				oldDataSourceFolderFilter = unitsDataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					unitsDataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
				var sysAdminUnit = dataSource.Schema.CreateEntity(UserConnection);
				var folderPageInstance = Page.BaseFolder.PageInstance as Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl;
				var folderDataSource = folderPageInstance.DataSource;
				var folderId = folderDataSource.ActiveRow.GetTypedColumnValue<Guid>("Id");
				if (sysAdminUnit.FetchFromDB(folderId)) {
					DataSourceFilter dataSourceConnectionTypeFilter = dataSource.CreateFilterWithParameters(
						FilterComparisonType.Equal, "ConnectionType", sysAdminUnit.GetColumnValue("ConnectionType"));
					dataSourceConnectionTypeFilter.Name = "ConnectionTypeFilter";
					dataSource.CurrentStructure.Filters.Add(dataSourceConnectionTypeFilter);
				}
			}
		}

		public override Guid GetGridSelectedValue() {
			PageContainer gridPageContainer = null;
			var activeGridTab = Page.GridTabPanel.Tabs[Page.GridTabPanel.ActiveTabIndex];
			foreach (var item in activeGridTab.Items) {
				 gridPageContainer = item as PageContainer;
				 if (gridPageContainer != null) {
				           break;
				 }
			}
			if (gridPageContainer == null) {
			         return Guid.Empty;
			}
			var process = gridPageContainer.PageInstance.Process;
			var selectedValue = process.GetPropertyValue("SelectedNodePrimaryColumnValue") == null ? Guid.Empty : 
				(Guid)process.GetPropertyValue("SelectedNodePrimaryColumnValue");
			return selectedValue;
		}

		public override bool OnPageLoadComlete() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return base.OnPageLoadComlete();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "GridTabPanelTabChange":
							if (ActivatedEventElements.Contains("GridTabPanelTabChangeMessage")) {
							context.QueueTasks.Enqueue("GridTabPanelTabChangeMessage");
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
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "GridActiveRowChanged":
							if (ActivatedEventElements.Contains("GridActiveRowChangedChild")) {
							context.QueueTasks.Enqueue("GridActiveRowChangedChild");
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
			if (!HasMapping("ParentRoleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentRoleId", ParentRoleId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeUsersAndRolesPageEventsProcess

	/// <exclude/>
	public class AdministrativeUsersAndRolesPageEventsProcess : AdministrativeUsersAndRolesPageEventsProcess<Terrasoft.WebApp.AdministrativeUsersAndRolesPageSchemaUserControl>
	{

		public AdministrativeUsersAndRolesPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeUsersAndRolesPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeUsersAndRolesPageSchemaUserControl : Terrasoft.WebApp.BaseModulePageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Tab UnitsTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("UnitsTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer Units {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("Units", true);
			}
		}

		#endregion

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
			var process = (AdministrativeUsersAndRolesPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeUsersAndRolesPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrativeUsersAndRolesPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeUsersAndRolesPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeUsersAndRolesPageEventsProcessSchema : Terrasoft.WebApp.BaseModulePageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeUsersAndRolesPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeUsersAndRolesPageEventsProcessSchema(AdministrativeUsersAndRolesPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeUsersAndRolesPageEventsProcess";
			UId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9");
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

		protected virtual ProcessSchemaParameter CreateParentRoleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("db02352a-8195-449f-94bf-337a02cf3c25"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"ParentRoleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateParentRoleIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet316 = CreateLaneSet316LaneSet();
			LaneSets.Add(schemaLaneSet316);
			ProcessSchemaLane schemaLane1009 = CreateLane1009Lane();
			schemaLaneSet316.Lanes.Add(schemaLane1009);
			ProcessSchemaEventSubProcess subprocessgridtabpaneltabchange = CreateSubProcessGridTabPanelTabChangeEventSubProcess();
			FlowElements.Add(subprocessgridtabpaneltabchange);
			ProcessSchemaEventSubProcess subprocess13 = CreateSubProcess13EventSubProcess();
			FlowElements.Add(subprocess13);
			ProcessSchemaEventSubProcess eventsubprocess3_1 = CreateEventSubProcess3_1EventSubProcess();
			FlowElements.Add(eventsubprocess3_1);
			ProcessSchemaEventSubProcess eventsubprocessgridactiverowchangedchild = CreateEventSubProcessGridActiveRowChangedChildEventSubProcess();
			FlowElements.Add(eventsubprocessgridactiverowchangedchild);
			ProcessSchemaStartMessageEvent gridtabpaneltabchangemessage = CreateGridTabPanelTabChangeMessageStartMessageEvent();
			subprocessgridtabpaneltabchange.FlowElements.Add(gridtabpaneltabchangemessage);
			ProcessSchemaIntermediateThrowMessageEvent gridthrowgridactiverowchanged = CreateGridThrowGridActiveRowChangedIntermediateThrowMessageEvent();
			subprocessgridtabpaneltabchange.FlowElements.Add(gridthrowgridactiverowchanged);
			ProcessSchemaStartMessageEvent initchild = CreateInitChildStartMessageEvent();
			subprocess13.FlowElements.Add(initchild);
			ProcessSchemaScriptTask scriptinitchild = CreateScriptInitChildScriptTask();
			subprocess13.FlowElements.Add(scriptinitchild);
			ProcessSchemaIntermediateThrowMessageEvent throwinitparent = CreateThrowInitParentIntermediateThrowMessageEvent();
			subprocess13.FlowElements.Add(throwinitparent);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			eventsubprocess3_1.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			eventsubprocess3_1.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcompleteparent = CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent();
			eventsubprocess3_1.FlowElements.Add(throwpageloadcompleteparent);
			ProcessSchemaStartMessageEvent gridactiverowchangedchild = CreateGridActiveRowChangedChildStartMessageEvent();
			eventsubprocessgridactiverowchangedchild.FlowElements.Add(gridactiverowchangedchild);
			ProcessSchemaScriptTask scriptgridactiverowchangedchild = CreateScriptGridActiveRowChangedChildScriptTask();
			eventsubprocessgridactiverowchangedchild.FlowElements.Add(scriptgridactiverowchangedchild);
			FlowElements.Add(CreateSequenceFlow6230SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6242SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6243SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6249SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6250SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6256SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6230SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6230",
				UId = new Guid("2ef4b51e-f9a8-417e-af14-42625bb69b57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				CurveCenterPosition = new Point(551, 861),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e0d1340-c32d-4117-82be-673e2d0c643b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb29ef80-5336-40a0-89c3-ab6b612f02bf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6242SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6242",
				UId = new Guid("73c27c4c-18ee-4ce5-a5fa-2288cee8a13e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				CurveCenterPosition = new Point(326, 2444),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2856e913-9b4d-43da-b860-aa91efb05813"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2cb76491-3155-438a-87ee-923f502282d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6243SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6243",
				UId = new Guid("75b9e308-1038-462f-a9c4-4a81157d7f7b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				CurveCenterPosition = new Point(434, 2444),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2cb76491-3155-438a-87ee-923f502282d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff8ce80e-2b08-44c2-bf6d-6991b1c4d510"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6249SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6249",
				UId = new Guid("d1285a87-9739-439c-afa5-bb7d731d9374"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				CurveCenterPosition = new Point(152, 255),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("325fc627-29ca-4e42-ab95-064abdae7039"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fae96e3f-c220-4c92-aad7-dc4469f257cf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6250SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6250",
				UId = new Guid("b39da24f-0dba-47f2-80ac-8d192e9bf668"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				CurveCenterPosition = new Point(240, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fae96e3f-c220-4c92-aad7-dc4469f257cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e4212b2b-d9f7-471a-b93b-365295c51c22"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6256SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6256",
				UId = new Guid("0236c2ce-675a-4384-b9a1-949e62cbfc07"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				CurveCenterPosition = new Point(494, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("32356a62-0cb5-454b-b692-c275c79056ed"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("764c2ca7-7992-4fa0-9aaf-46ba06063e6b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet316LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet316 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8d28042b-23da-455e-8273-705f5532781a"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"LaneSet316",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(594, 338),
				UseBackgroundMode = false
			};
			return schemaLaneSet316;
		}

		protected virtual ProcessSchemaLane CreateLane1009Lane() {
			ProcessSchemaLane schemaLane1009 = new ProcessSchemaLane(this) {
				UId = new Guid("60bea863-d5cb-484b-b5c0-dfaeae8cf964"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8d28042b-23da-455e-8273-705f5532781a"),
				CreatedInOwnerSchemaUId = new Guid("eae89c7f-9cdb-46e5-8916-e64ea16979b5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"Lane1009",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(565, 338),
				UseBackgroundMode = false
			};
			return schemaLane1009;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessGridTabPanelTabChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessGridTabPanelTabChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f7c10665-bb6c-42fa-8eee-4aa5804d7015"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60bea863-d5cb-484b-b5c0-dfaeae8cf964"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"SubProcessGridTabPanelTabChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(167, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessGridTabPanelTabChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridTabPanelTabChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9e0d1340-c32d-4117-82be-673e2d0c643b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7c10665-bb6c-42fa-8eee-4aa5804d7015"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"GridTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"GridTabPanelTabChangeMessage",
				Position = new Point(14, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateGridThrowGridActiveRowChangedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("bb29ef80-5336-40a0-89c3-ab6b612f02bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7c10665-bb6c-42fa-8eee-4aa5804d7015"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"FolderActiveRowChanged",
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"GridThrowGridActiveRowChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(98, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("92607963-7427-4276-b09d-9375be0091f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60bea863-d5cb-484b-b5c0-dfaeae8cf964"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"SubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(284, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2856e913-9b4d-43da-b860-aa91efb05813"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92607963-7427-4276-b09d-9375be0091f2"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"InitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(7, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2cb76491-3155-438a-87ee-923f502282d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92607963-7427-4276-b09d-9375be0091f2"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"ScriptInitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,204,61,10,194,48,24,0,208,93,240,14,165,147,14,31,228,231,75,218,80,28,108,210,136,131,83,241,0,181,73,177,80,91,136,9,210,219,11,110,58,248,14,240,218,245,121,89,92,154,252,217,101,135,108,246,175,236,148,70,183,203,101,97,5,82,78,192,162,172,129,34,37,64,68,73,1,75,81,115,85,179,198,104,157,239,171,237,198,46,147,243,161,153,227,24,215,182,191,251,71,119,253,169,140,48,132,90,109,64,154,82,3,214,76,129,106,68,9,90,31,185,181,141,100,92,226,119,21,214,127,31,222,88,49,8,194,160,103,74,2,22,253,0,221,32,28,112,170,10,39,208,19,199,186,207,23,124,76,97,206,98,72,190,122,3,238,215,240,141,232,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowInitParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ff8ce80e-2b08-44c2-bf6d-6991b1c4d510"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92607963-7427-4276-b09d-9375be0091f2"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"ThrowInitParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b54a2998-18c3-4976-bc53-491f6131cc60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60bea863-d5cb-484b-b5c0-dfaeae8cf964"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"EventSubProcess3_1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(278, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("325fc627-29ca-4e42-ab95-064abdae7039"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b54a2998-18c3-4976-bc53-491f6131cc60"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e4212b2b-d9f7-471a-b93b-365295c51c22"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b54a2998-18c3-4976-bc53-491f6131cc60"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,142,177,10,194,64,16,68,123,191,226,72,165,32,247,3,193,66,45,36,96,17,136,209,122,77,198,24,136,119,97,119,79,240,239,189,147,24,172,237,6,102,222,99,158,196,166,227,190,45,156,40,185,6,102,99,74,234,96,107,215,171,216,20,231,134,196,156,192,76,226,111,106,47,184,110,199,209,238,72,112,136,120,26,86,205,29,15,170,5,188,247,78,217,15,249,226,215,108,75,246,13,68,108,5,141,113,4,235,235,76,67,192,50,59,246,162,112,224,100,201,214,159,3,171,191,224,105,85,23,237,164,153,185,175,40,86,81,205,208,192,206,40,7,228,111,125,217,195,108,2,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("fae96e3f-c220-4c92-aad7-dc4469f257cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b54a2998-18c3-4976-bc53-491f6131cc60"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"ThrowPageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessGridActiveRowChangedChildEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessGridActiveRowChangedChild = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("382a3a3f-dd53-411e-aca4-b9236b916943"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60bea863-d5cb-484b-b5c0-dfaeae8cf964"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"EventSubProcessGridActiveRowChangedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(329, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(222, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessGridActiveRowChangedChild;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridActiveRowChangedChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("32356a62-0cb5-454b-b692-c275c79056ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("382a3a3f-dd53-411e-aca4-b9236b916943"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridActiveRowChanged",
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"GridActiveRowChangedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridActiveRowChangedChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("764c2ca7-7992-4fa0-9aaf-46ba06063e6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("382a3a3f-dd53-411e-aca4-b9236b916943"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"),
				Name = @"ScriptGridActiveRowChangedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,193,114,218,48,16,61,219,95,161,112,200,216,51,25,37,109,143,52,153,33,36,161,57,52,195,4,218,30,24,14,2,47,193,173,145,169,36,39,101,58,252,123,181,50,54,146,45,18,218,250,100,203,187,171,183,187,111,223,14,217,19,244,115,174,88,202,65,144,39,145,38,67,231,228,146,240,34,203,186,225,51,19,132,205,85,250,12,3,109,51,102,51,253,7,45,233,238,115,200,56,100,84,191,200,73,251,184,103,28,245,231,61,79,224,215,180,27,46,114,1,108,190,36,17,134,77,21,172,72,202,221,240,244,94,159,202,152,252,14,73,245,248,192,25,95,38,137,115,222,221,251,164,11,18,181,253,78,202,172,156,232,251,103,166,177,253,176,98,108,195,109,232,143,115,233,137,35,64,21,130,19,37,10,232,106,71,76,48,97,138,141,242,66,204,65,35,110,135,161,119,41,175,79,68,158,93,111,30,216,10,162,206,77,237,214,137,99,76,114,127,208,53,128,236,184,123,36,65,3,1,90,126,98,178,199,89,182,81,233,220,212,52,64,88,18,50,152,43,72,30,243,23,137,125,134,23,114,147,234,30,228,156,137,205,71,169,68,202,159,206,72,62,251,174,173,174,162,184,27,6,182,7,237,37,73,212,193,46,189,235,156,89,41,210,209,124,9,43,70,49,135,195,62,239,189,62,3,80,67,145,174,244,245,253,60,43,86,220,212,33,62,28,229,131,142,162,125,70,187,159,37,205,208,164,116,50,156,173,210,30,120,216,19,225,65,69,159,18,195,23,9,98,215,135,152,30,213,166,195,55,116,98,18,6,245,211,102,105,128,173,121,5,160,69,211,160,230,215,97,123,3,247,158,75,197,184,46,233,80,228,115,144,146,142,176,166,249,26,132,218,124,101,89,161,1,183,203,165,203,104,23,24,107,183,173,184,11,58,120,38,171,81,174,166,254,198,61,70,62,70,13,83,35,6,180,159,23,92,33,61,47,94,155,18,55,239,50,144,87,135,136,37,68,165,8,249,110,157,52,15,255,70,128,252,226,227,199,116,140,252,248,60,255,77,128,188,24,142,147,160,53,19,192,85,57,85,159,117,152,33,83,203,186,120,71,176,104,208,98,209,208,19,177,163,153,51,40,210,132,44,210,76,225,28,225,79,99,175,239,194,31,244,118,181,86,155,150,122,237,202,65,78,79,219,162,224,76,65,80,170,146,19,31,167,16,83,105,169,137,35,37,70,143,52,175,205,204,121,171,97,129,56,241,25,208,113,62,50,183,71,49,189,253,89,176,76,70,229,119,153,84,92,2,12,60,208,222,136,134,168,182,117,247,176,91,213,138,208,190,237,109,97,247,7,185,55,6,33,152,204,23,138,126,131,89,111,189,166,215,76,66,37,14,45,81,43,75,16,237,111,176,171,235,174,14,27,21,177,23,198,67,158,128,180,176,209,177,0,115,35,29,217,22,206,28,68,142,243,78,22,174,26,170,176,127,124,4,194,5,133,36,114,67,77,46,166,212,88,200,73,179,244,83,171,200,177,61,79,4,50,9,254,139,81,199,246,76,50,235,198,96,173,90,126,81,245,185,209,106,31,203,61,225,95,187,250,237,196,27,200,48,117,61,152,150,113,212,44,65,124,160,4,22,34,87,103,142,86,132,195,123,5,219,226,204,158,249,175,119,76,43,55,141,104,55,208,210,240,244,224,40,151,195,123,126,254,31,232,250,133,192,41,68,154,142,234,203,112,241,213,31,26,205,157,167,250,45,212,221,176,36,253,82,228,47,183,207,58,102,212,121,132,133,0,185,220,109,69,148,65,103,146,254,0,63,184,130,42,101,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a8d2abf8-07ab-4e55-8690-1a75dfa0f6da"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d6630e4d-7a19-48f1-9051-b7afb4319d94"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9eaf8c85-25b4-4106-b135-2ce7c11e0517"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80e9a624-774f-4aa9-bdc1-372108d985e1"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("66c04ada-c3e9-49ab-83a7-051f50d29d99"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1f380c2-17a6-4748-871a-be4cb513b6b0"),
				Name = "Terrasoft.Common.Json",
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

		protected override SchemaMethod CreateGetActiveDataSourceMethod() {
			SchemaMethod method = base.CreateGetActiveDataSourceMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,61,11,131,48,16,134,231,10,254,135,195,73,151,224,46,25,90,75,139,75,17,218,77,28,174,122,45,1,77,32,38,210,82,250,223,27,33,218,143,169,211,113,47,207,251,220,141,168,193,224,185,68,73,29,112,40,241,74,108,175,69,123,242,89,22,6,226,2,241,140,48,151,15,44,87,86,26,224,28,210,4,30,97,176,210,100,172,150,32,109,55,241,207,48,24,157,21,27,35,70,114,188,211,126,213,171,101,91,207,72,33,91,186,213,254,214,82,100,133,161,254,143,107,211,211,185,146,70,171,14,26,63,57,252,104,170,180,102,59,33,219,15,120,115,63,96,79,113,180,69,131,71,101,117,67,81,226,140,222,63,155,112,128,55,144,189,0,105,128,177,189,48,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateApplyFiltersMethod() {
			SchemaMethod method = base.CreateApplyFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,11,130,64,16,133,207,237,175,24,60,233,101,241,190,120,40,163,240,18,18,222,196,195,148,83,45,232,10,235,40,69,244,223,91,201,21,234,210,241,61,222,247,222,204,136,22,24,79,57,26,106,32,129,28,175,36,247,86,215,197,236,41,161,47,16,250,132,116,118,47,211,110,48,12,73,2,113,4,79,177,178,196,131,53,74,188,196,232,202,240,204,122,36,151,115,109,95,88,185,168,181,143,100,166,166,123,245,153,88,56,153,49,181,127,70,216,18,77,87,186,141,31,174,140,43,185,211,166,158,30,73,59,195,182,107,54,143,3,182,20,6,197,12,5,17,96,15,94,41,225,203,228,145,46,150,250,219,22,25,195,72,189,1,254,125,136,11,26,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBaseApplyModuleFiltersMethod() {
			SchemaMethod method = base.CreateBaseApplyModuleFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,95,111,27,69,16,127,62,127,138,173,145,170,115,107,173,91,64,32,145,166,82,252,39,197,162,37,193,78,200,67,20,85,87,223,186,94,56,223,153,221,189,164,86,100,9,202,35,72,188,243,49,16,72,133,162,242,21,46,223,136,153,221,181,189,123,182,19,171,192,3,141,20,251,110,231,239,206,252,102,118,214,231,145,32,147,232,57,235,166,82,69,233,128,145,93,114,8,175,244,145,224,49,61,116,9,145,36,71,76,136,72,102,67,69,79,216,179,189,201,132,54,35,201,144,19,25,251,131,17,27,71,199,146,137,86,150,42,145,37,59,149,115,80,30,71,42,234,103,185,208,170,93,75,180,189,160,24,78,36,30,167,92,201,178,47,122,241,95,113,38,71,77,237,178,71,158,209,21,183,34,57,65,141,115,103,246,236,171,231,193,113,23,157,176,166,140,171,59,21,43,72,91,185,84,217,24,213,158,86,251,83,249,36,139,243,132,61,149,44,97,3,197,192,91,193,82,213,203,18,214,141,171,103,218,202,114,129,30,101,125,37,120,250,60,172,25,103,178,36,94,250,7,246,82,208,193,179,244,104,58,97,251,60,81,76,128,130,101,196,193,180,64,101,160,35,31,168,92,48,106,152,36,124,167,113,115,250,121,52,102,97,117,157,154,42,216,227,67,18,222,108,239,214,46,73,243,36,169,145,203,74,176,141,229,30,27,103,231,236,102,197,224,192,76,187,112,171,43,123,89,166,246,65,2,204,221,190,237,5,8,205,63,202,1,170,157,241,68,77,181,19,93,147,251,39,81,10,193,23,93,197,198,100,168,101,59,144,157,41,124,112,53,53,44,16,43,11,48,131,19,235,3,125,196,148,167,35,172,186,82,118,177,90,163,149,32,0,86,180,208,156,30,119,227,112,127,189,25,32,213,16,46,171,142,237,84,2,76,170,113,239,112,77,21,34,164,141,214,237,224,111,176,101,36,228,134,58,112,76,122,149,176,234,133,87,10,142,88,41,134,101,93,212,80,64,164,207,84,155,169,136,39,38,165,22,3,136,58,16,171,26,55,45,222,54,114,63,102,67,213,121,49,17,76,74,200,141,4,193,148,93,16,34,117,89,156,158,17,72,194,165,121,161,176,197,65,164,66,164,47,200,151,164,122,90,173,111,66,0,69,95,234,164,250,9,212,37,6,233,140,194,3,34,139,130,12,104,94,221,47,61,20,124,28,137,105,43,75,242,113,170,229,103,181,153,246,30,235,153,68,241,152,167,216,80,236,251,46,104,9,208,163,101,190,90,25,148,67,187,73,13,71,184,6,129,53,20,10,168,177,17,86,161,49,212,160,239,152,7,159,132,246,45,209,60,250,100,175,185,24,54,127,9,217,233,190,200,198,33,182,166,189,185,243,150,112,50,98,130,249,20,44,208,47,163,36,95,152,234,202,199,144,154,208,198,3,180,131,27,144,182,240,67,8,171,39,5,17,109,101,227,113,230,48,181,185,176,37,215,77,39,185,170,233,50,49,97,129,136,6,159,114,38,34,49,24,241,65,148,152,213,131,137,210,32,200,236,183,1,195,70,190,80,55,132,32,240,114,54,135,31,108,191,174,137,58,32,62,205,11,146,230,50,122,113,31,64,95,53,136,4,218,26,241,36,6,65,224,71,68,4,95,228,12,141,166,49,71,111,0,147,145,80,128,202,229,202,238,124,35,180,111,105,158,167,11,70,84,182,34,77,253,202,176,177,176,54,81,124,73,43,103,125,189,190,174,236,124,147,71,201,106,42,93,225,250,188,110,49,48,55,39,20,45,149,74,130,186,209,59,88,36,210,70,2,5,176,211,36,92,42,187,37,128,31,244,74,196,116,98,148,75,122,240,236,43,120,132,110,199,18,103,253,65,166,151,31,134,218,108,46,97,119,36,212,51,200,179,206,11,54,200,85,134,199,99,169,217,119,82,9,199,83,187,185,92,10,107,22,54,142,6,193,162,88,31,174,229,205,24,197,172,167,233,225,210,208,92,71,112,1,160,96,36,52,10,40,242,45,244,155,157,242,120,213,169,118,19,1,5,11,231,76,96,43,108,55,117,205,29,101,120,214,89,93,167,247,206,244,62,225,15,131,69,247,226,56,228,177,93,154,85,236,199,204,52,110,19,25,157,167,121,213,152,165,83,45,219,202,242,84,145,187,228,254,25,136,187,188,96,164,52,146,0,195,16,226,24,114,16,224,64,187,183,3,95,15,200,82,13,188,223,189,107,118,232,105,226,90,63,72,32,235,41,71,75,179,77,77,191,199,159,143,148,222,50,34,195,209,98,207,33,111,122,112,207,145,183,24,127,188,99,8,195,183,50,247,120,6,220,121,231,173,7,30,87,99,205,4,2,51,75,46,50,241,181,156,68,3,29,231,70,227,189,6,248,210,237,63,61,57,232,125,214,63,220,107,117,96,173,248,185,120,83,252,90,39,197,31,197,155,171,151,240,255,237,213,15,197,239,250,181,248,179,248,171,120,85,188,46,94,193,226,247,197,111,87,47,175,190,187,250,137,32,87,241,250,234,71,100,33,197,47,228,100,110,132,180,122,247,63,126,255,254,7,31,85,2,199,240,98,234,246,33,185,144,162,115,223,24,52,142,97,197,14,6,243,232,151,243,217,2,176,42,59,210,133,203,112,213,221,173,214,75,240,199,136,24,133,116,253,172,208,104,152,169,216,76,125,59,219,13,158,88,31,195,121,196,43,65,227,206,219,205,27,151,120,112,204,54,142,43,30,114,189,186,185,211,128,210,186,6,183,165,187,201,127,15,222,173,13,110,137,224,237,48,80,178,250,207,128,176,32,99,114,111,220,143,235,199,9,87,163,197,177,37,87,100,205,176,135,39,127,105,110,211,179,32,103,210,6,7,14,192,73,36,184,52,55,23,170,15,208,186,59,63,192,33,233,162,64,159,136,91,7,222,131,172,185,13,185,151,33,157,198,119,180,29,190,211,149,130,57,147,206,80,237,167,201,94,52,12,90,205,221,35,92,173,139,255,227,197,81,31,46,43,215,197,61,216,211,57,235,101,23,120,241,198,50,138,205,4,170,187,232,3,60,23,31,154,171,143,77,154,27,57,186,207,212,96,132,23,152,118,51,156,27,177,243,149,147,2,147,211,101,140,183,248,229,100,115,175,192,209,234,218,234,247,181,67,7,240,60,134,77,58,251,43,255,252,82,53,51,243,245,174,46,186,225,218,159,110,118,182,172,68,236,46,215,219,49,112,157,253,13,232,181,82,12,36,20,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetGridSelectedValueMethod() {
			SchemaMethod method = base.CreateGetGridSelectedValueMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,193,106,195,48,16,68,207,209,87,108,114,178,47,250,128,138,80,74,40,198,151,98,72,233,165,244,176,177,55,169,168,44,27,73,14,53,37,255,222,149,237,54,53,206,169,62,121,103,231,13,179,42,240,68,187,198,6,212,150,28,156,156,174,138,153,178,5,219,25,163,196,25,29,96,25,244,153,50,246,60,227,129,55,209,41,167,177,64,75,70,242,143,127,93,202,15,3,200,99,110,43,250,124,83,226,216,56,194,242,29,146,24,171,3,213,160,237,60,94,230,172,250,20,190,196,234,102,171,1,66,15,51,93,177,89,31,33,89,2,235,241,142,49,239,250,29,184,198,71,164,46,226,34,110,147,219,43,249,139,57,10,157,179,144,117,186,146,143,117,27,122,197,120,60,165,117,77,73,222,115,191,69,144,140,83,110,125,64,91,146,44,70,227,248,174,158,12,149,129,170,23,52,29,49,59,165,200,140,2,251,90,114,161,31,86,201,102,63,57,159,154,138,10,167,107,116,253,174,49,93,109,135,253,38,253,105,11,247,127,202,193,29,136,85,18,231,244,255,201,74,76,71,207,202,170,111,42,134,135,248,63,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnPageLoadComleteMethod() {
			SchemaMethod method = base.CreateOnPageLoadComleteMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,202,49,14,194,48,16,68,209,158,83,160,84,73,227,11,164,2,147,14,20,36,196,1,22,103,20,86,144,49,90,111,36,184,61,70,180,239,255,107,129,197,76,34,185,102,134,195,254,130,180,154,250,103,224,172,68,136,119,164,71,20,14,239,234,142,241,5,147,223,217,54,21,79,66,153,177,155,22,165,22,255,135,166,235,55,6,95,141,219,155,20,132,145,231,250,28,179,76,49,47,79,56,218,174,255,2,198,184,183,226,117,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeUsersAndRolesPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be9dd52b-48a0-4f39-b156-368a25c9f6a9"));
		}

		#endregion

	}

	#endregion

}

