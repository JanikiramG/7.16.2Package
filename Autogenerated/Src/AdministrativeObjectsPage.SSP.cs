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

	#region Class: AdministrativeObjectsPageSchema

	/// <exclude/>
	public class AdministrativeObjectsPageSchema : Terrasoft.WebApp.AdministrativeObjectsPage_Base_TerrasoftSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _checkMenuItemIsInSSPEntitySchemaAccessList;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemIsInSSPEntitySchemaAccessList {
			get {
				return _checkMenuItemIsInSSPEntitySchemaAccessList;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrativeObjectsPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectsPageSchema(AdministrativeObjectsPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateCheckMenuItemAll() {
			CheckMenuItemAll.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			CheckMenuItemAll.Image = new ControlImage {};
			CheckMenuItemAll.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateCheckMenuItemModule() {
			CheckMenuItemModule.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			CheckMenuItemModule.Image = new ControlImage {};
			CheckMenuItemModule.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateMenuSeparator() {
			MenuSeparator.Image = new ControlImage {};
			MenuSeparator.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateCheckMenuItemLookup() {
			CheckMenuItemLookup.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			CheckMenuItemLookup.Image = new ControlImage {};
			CheckMenuItemLookup.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateCheckMenuItemAdministratedByRecords() {
			CheckMenuItemAdministratedByRecords.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			CheckMenuItemAdministratedByRecords.Image = new ControlImage {};
			CheckMenuItemAdministratedByRecords.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateCheckMenuItemAdministratedByColumns() {
			CheckMenuItemAdministratedByColumns.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			CheckMenuItemAdministratedByColumns.Image = new ControlImage {};
			CheckMenuItemAdministratedByColumns.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateCheckMenuItemAdministratedByOperations() {
			CheckMenuItemAdministratedByOperations.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			CheckMenuItemAdministratedByOperations.Image = new ControlImage {};
			CheckMenuItemAdministratedByOperations.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
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
			RightControlLayout.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
			Name = "AdministrativeObjectsPage";
			ParentSchemaUId = new Guid("8d79ecc8-67d5-47b1-86fe-9b0177e7eb86");
			CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectsPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateRightControlLayout();
			UpdateDetailsTabPanel();
			UpdateGridTabPanel();
			UpdateGridTab();
			UpdateCheckMenuItemAdministratedByOperations();
			UpdateCheckMenuItemAdministratedByColumns();
			UpdateCheckMenuItemAdministratedByRecords();
			UpdateCheckMenuItemLookup();
			UpdateMenuSeparator();
			UpdateCheckMenuItemModule();
			UpdateCheckMenuItemAll();
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
			GridTab.MoveItem(0, CheckMenuItemAll);
			GridTab.MoveItem(1, CheckMenuItemModule);
			GridTab.MoveItem(2, MenuSeparator);
			GridTab.MoveItem(3, CheckMenuItemLookup);
			GridTab.MoveItem(4, CheckMenuItemAdministratedByRecords);
			GridTab.MoveItem(5, CheckMenuItemAdministratedByColumns);
			GridTab.MoveItem(6, CheckMenuItemAdministratedByOperations);
			GridTab.InsertItem(7, CreateCheckMenuItemIsInSSPEntitySchemaAccessList());
			RightControlLayout.MoveItem(1, DetailsTabPanel);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectsPageEventsProcessSchema() {
			var schema = new AdministrativeObjectsPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateCheckMenuItemIsInSSPEntitySchemaAccessList() {
			_checkMenuItemIsInSSPEntitySchemaAccessList = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_checkMenuItemIsInSSPEntitySchemaAccessList.UId = new Guid("6e5fa28b-ae0d-497e-b2a4-665ea2087b76");
			_checkMenuItemIsInSSPEntitySchemaAccessList.Name = "CheckMenuItemIsInSSPEntitySchemaAccessList";
			_checkMenuItemIsInSSPEntitySchemaAccessList.CreatedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
			_checkMenuItemIsInSSPEntitySchemaAccessList.ModifiedInSchemaUId = new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
			_checkMenuItemIsInSSPEntitySchemaAccessList.CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081");
			_checkMenuItemIsInSSPEntitySchemaAccessList.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_checkMenuItemIsInSSPEntitySchemaAccessList.Group = "AdministratedObjects";
			_checkMenuItemIsInSSPEntitySchemaAccessList.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkMenuItemIsInSSPEntitySchemaAccessList.Image = new ControlImage {};
			_checkMenuItemIsInSSPEntitySchemaAccessList.Tag = "IsInSSPEntitySchemaAccessList";
			return _checkMenuItemIsInSSPEntitySchemaAccessList;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectsPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectsPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectsPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsPageEventsProcess<TPage> : Terrasoft.WebApp.AdministrativeObjectsPage_Base_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeObjectsPageSchemaUserControl
	{

		public AdministrativeObjectsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectsPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("52717a57-c571-4efc-b2b7-0d6dff7d1b41");
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

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("1146398a-b63f-4411-94df-743b196f4dc9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _checkMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage;
		public ProcessFlowElement CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage {
			get {
				return _checkMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage ?? (_checkMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage",
					SchemaElementUId = new Guid("0c79d5d6-fdd9-4384-be9c-13ce25d3fd4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkMenuItemIsInSSPEntitySchemaAccessListCheckChange;
		public ProcessScriptTask CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange {
			get {
				return _checkMenuItemIsInSSPEntitySchemaAccessListCheckChange ?? (_checkMenuItemIsInSSPEntitySchemaAccessListCheckChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange",
					SchemaElementUId = new Guid("331f6608-78e1-47e0-9c96-d5e1805a301b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage };
			FlowElements[CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage":
						e.Context.QueueTasks.Enqueue("CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange");
						break;
					case "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage";
					result = CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage.Execute(context);
					break;
				case "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange";
					result = CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange.Execute(context, CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeExecute);
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

		public virtual bool CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeExecute(ProcessExecutingContext context) {
			MenuItemClick("IsInSSPEntitySchemaAccessList");
			return true;
		}

		public override void MenuItemClick(string tag) {
			if(tag == "IsInSSPEntitySchemaAccessList") {
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
				
				var adminIsInSSPEntitySchemaAccessListFilter = filters.FindByName("AdminObjectsIsInSSPEntitySchemaAccessList");
				if (adminIsInSSPEntitySchemaAccessListFilter == null) {
					adminIsInSSPEntitySchemaAccessListFilter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "IsInSSPEntitySchemaAccessList", true);
					adminIsInSSPEntitySchemaAccessListFilter.Name = "AdminObjectsIsInSSPEntitySchemaAccessList";
					currentStructure.Filters.Add(adminIsInSSPEntitySchemaAccessListFilter);
				}
				adminIsInSSPEntitySchemaAccessListFilter.IsEnabled = true;
				
				gridPage.TreeGrid.Clear();
				gridPage.TreeGrid.RefreshData();
			} else {
				base.MenuItemClick(tag);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange":
							if (ActivatedEventElements.Contains("CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage")) {
							context.QueueTasks.Enqueue("CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage");
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

	#region Class: AdministrativeObjectsPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsPageEventsProcess : AdministrativeObjectsPageEventsProcess<Terrasoft.WebApp.AdministrativeObjectsPageSchemaUserControl>
	{

		public AdministrativeObjectsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectsPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectsPageSchemaUserControl : Terrasoft.WebApp.AdministrativeObjectsPage_Base_TerrasoftSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem CheckMenuItemIsInSSPEntitySchemaAccessList {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("CheckMenuItemIsInSSPEntitySchemaAccessList", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			CheckMenuItemIsInSSPEntitySchemaAccessList.AjaxEvents.CheckChange.Event += CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			CheckMenuItemIsInSSPEntitySchemaAccessList.AjaxEvents.CheckChange.Event -= CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeObjectsPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectsPageEventsProcess(UserConnection);
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

		public virtual void CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange");
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
			SchemaName = "AdministrativeObjectsPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectsPageEventsProcessSchema : Terrasoft.WebApp.AdministrativeObjectsPage_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectsPageEventsProcessSchema(AdministrativeObjectsPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectsPageEventsProcess";
			UId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3");
			CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900");
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
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent checkmenuitemisinsspentityschemaaccesslistcheckchangestartmessage = CreateCheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(checkmenuitemisinsspentityschemaaccesslistcheckchangestartmessage);
			ProcessSchemaScriptTask checkmenuitemisinsspentityschemaaccesslistcheckchange = CreateCheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeScriptTask();
			eventsubprocess3.FlowElements.Add(checkmenuitemisinsspentityschemaaccesslistcheckchange);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fbca015e-fdef-43f3-a665-c3654e33894d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081"),
				CreatedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c79d5d6-fdd9-4384-be9c-13ce25d3fd4c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("331f6608-78e1-47e0-9c96-d5e1805a301b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d8c696af-12d0-4fac-a4e7-2779861d7be6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081"),
				CreatedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(770, 171),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e22f257e-4209-4baa-bce1-3e88089f2b15"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d8c696af-12d0-4fac-a4e7-2779861d7be6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081"),
				CreatedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(741, 171),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1146398a-b63f-4411-94df-743b196f4dc9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e22f257e-4209-4baa-bce1-3e88089f2b15"),
				CreatedInOwnerSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081"),
				CreatedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				Name = @"EventSubProcess3",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(220, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0c79d5d6-fdd9-4384-be9c-13ce25d3fd4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1146398a-b63f-4411-94df-743b196f4dc9"),
				CreatedInOwnerSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081"),
				CreatedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange",
				ModifiedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				Name = @"CheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeStartMessage",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckMenuItemIsInSSPEntitySchemaAccessListCheckChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("331f6608-78e1-47e0-9c96-d5e1805a301b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1146398a-b63f-4411-94df-743b196f4dc9"),
				CreatedInOwnerSchemaUId = new Guid("1f57f612-25ad-4044-abb3-39b430df3900"),
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081"),
				CreatedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"),
				Name = @"CheckMenuItemIsInSSPEntitySchemaAccessListCheckChange",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,205,43,245,44,73,205,117,206,201,76,206,214,80,242,44,246,204,11,14,14,112,205,43,201,44,169,12,78,206,72,205,77,116,76,78,78,45,46,246,201,44,46,81,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,0,246,33,210,61,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c732b9ff-923d-459f-8aed-c923e5d34b12"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cafacd03-d1a2-43da-8fb1-db3dc13351a7"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("73f3d5bd-cd68-4d27-aa1a-e5db86afbb5c"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8a52f61f-eae7-4d4d-8095-62319ae446eb"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f54c9c05-732e-45af-939f-13fc737c792b"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdc1f75a-bdaa-4bb9-913e-3e80b88105af"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7e624e1a-9617-4102-957b-d7222d4aa9d1"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("1c03816c-49e5-4f4c-98a1-3d44c06c9081")
			});
		}

		protected override SchemaMethod CreateMenuItemClickMethod() {
			SchemaMethod method = base.CreateMenuItemClickMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,143,155,48,16,61,167,82,255,131,197,137,72,145,255,64,149,67,150,166,43,164,126,68,37,85,206,19,51,36,238,130,161,51,166,82,84,229,191,215,54,132,205,238,178,89,42,245,66,136,231,205,188,231,121,195,232,34,182,112,16,203,165,136,82,78,77,150,109,214,198,106,123,202,212,17,43,88,41,133,204,159,53,219,104,46,254,188,127,55,251,13,36,14,164,243,13,28,80,44,133,255,145,247,238,191,244,111,169,97,11,70,161,0,22,91,36,2,174,11,43,119,184,95,53,141,188,3,198,251,62,179,43,254,131,145,146,218,88,170,203,15,125,233,28,44,100,117,75,202,23,191,240,200,143,195,233,5,167,90,34,52,54,179,212,42,219,146,71,63,166,202,228,89,244,146,85,232,210,34,177,3,63,207,151,159,186,144,71,22,53,33,168,163,136,31,83,132,54,151,228,174,13,51,93,136,184,59,145,95,161,66,153,89,32,203,59,109,143,113,180,202,43,109,190,237,127,162,178,28,205,251,132,89,143,78,121,109,96,95,98,238,84,20,80,114,16,55,59,187,199,185,87,201,39,222,213,244,192,13,40,236,100,121,104,199,238,116,154,252,238,228,41,227,40,123,1,140,230,190,154,215,54,86,100,41,76,91,150,189,158,81,150,235,30,186,38,216,62,226,175,181,1,114,164,94,67,220,29,38,117,213,0,105,174,205,246,212,160,92,255,106,161,92,136,39,162,162,69,55,32,189,209,198,53,68,215,70,14,113,153,230,65,240,136,152,208,85,167,104,236,146,33,229,53,7,229,42,207,71,110,31,120,124,135,71,168,174,45,113,229,130,35,189,23,224,173,188,249,93,220,116,232,122,18,222,248,186,46,198,77,103,124,98,231,63,8,253,15,38,223,190,203,34,116,177,115,118,170,174,193,239,233,45,123,123,12,166,146,15,195,49,89,237,43,35,51,108,172,45,97,88,118,50,41,17,40,14,4,47,131,223,177,32,228,163,95,111,1,114,22,232,22,66,48,116,239,182,165,252,130,166,77,45,86,73,169,213,131,95,211,1,244,23,180,194,234,55,178,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectsPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a789028a-2a02-49be-8f86-e54fee4260f3"));
		}

		#endregion

	}

	#endregion

}

