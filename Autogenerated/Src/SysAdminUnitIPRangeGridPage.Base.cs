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

	#region Class: SysAdminUnitIPRangeGridPageSchema

	/// <exclude/>
	public class SysAdminUnitIPRangeGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public SysAdminUnitIPRangeGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysAdminUnitIPRangeGridPageSchema(SysAdminUnitIPRangeGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
			RealUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
			Name = "SysAdminUnitIPRangeGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			HelpContextId = "794";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitIPRangeGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateSysAdminUnitIPRangeGridPageEventsProcessSchema() {
			var schema = new SysAdminUnitIPRangeGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			DataSource.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ddb2e119-90df-485a-9720-90dc841298ca");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("764b4e50-5b5e-4f26-970e-8b5b2ae02672");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("87a2a900-ac85-4bdf-acae-2e2b9f22e32c");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("2403f195-6d0c-4071-b94c-872292d63c3c");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("a707de28-70fa-4849-86a6-976e68fc0417");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("886837f0-6749-4e27-93b9-29b3689a8953");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("80562de5-dd61-480f-af1f-84ceefea423f");
			if (column != null) {
				column.UId = new Guid("612c015b-3f02-4667-bcc2-dfd534a85229");
				column.Name = @"BeginIP";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3df16c98-3a83-4b7b-94b0-c138ba6ded0d");
			if (column != null) {
				column.UId = new Guid("a9d3ff1c-277a-4e1b-bdc8-51572d387075");
				column.Name = @"EndIP";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1e3c68d3-97a9-45a6-ae30-951580afc7c5");
			if (column != null) {
				column.UId = new Guid("24b50dab-3b93-4ace-8c14-4708d1b3245b");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.ModifiedInSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysAdminUnitIPRangeGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysAdminUnitIPRangeGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysAdminUnitIPRangeGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRangeGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitIPRangeGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysAdminUnitIPRangeGridPageSchemaUserControl
	{

		public SysAdminUnitIPRangeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitIPRangeGridPageEventsProcess";
			SchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75");
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
					SchemaElementUId = new Guid("1d127e96-6557-4a48-8432-eeb35c431c27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage;
		public ProcessFlowElement PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage {
			get {
				return _pageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage ?? (_pageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage",
					SchemaElementUId = new Guid("6c9cca01-ca4c-413f-a3e0-893d0e4ca6e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processPageLoadComplete_ScriptTask;
		public ProcessScriptTask ProcessPageLoadComplete_ScriptTask {
			get {
				return _processPageLoadComplete_ScriptTask ?? (_processPageLoadComplete_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessPageLoadComplete_ScriptTask",
					SchemaElementUId = new Guid("21345cc7-8272-4077-8206-de1cb34da98b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessPageLoadComplete_ScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent {
			get {
				return _sysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent ?? (_sysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("a98eb40d-d0f7-4711-a681-d3253fb8c6ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage };
			FlowElements[ProcessPageLoadComplete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessPageLoadComplete_ScriptTask };
			FlowElements[SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessPageLoadComplete_ScriptTask");
						break;
					case "ProcessPageLoadComplete_ScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent");
						break;
					case "SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage");
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
				case "PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage";
					result = PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage.Execute(context);
					break;
				case "ProcessPageLoadComplete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessPageLoadComplete_ScriptTask";
					result = ProcessPageLoadComplete_ScriptTask.Execute(context, ProcessPageLoadComplete_ScriptTaskExecute);
					break;
				case "SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool ProcessPageLoadComplete_ScriptTaskExecute(ProcessExecutingContext context) {
			SynchronizeDataSourceStructure = true;
			EditPageUId = new Guid("A626E5C1-4B99-4232-A29F-D505A21C69CF");
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage")) {
							context.QueueTasks.Enqueue("PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage");
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

	#region Class: SysAdminUnitIPRangeGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitIPRangeGridPageEventsProcess : SysAdminUnitIPRangeGridPageEventsProcess<Terrasoft.WebApp.SysAdminUnitIPRangeGridPageSchemaUserControl>
	{

		public SysAdminUnitIPRangeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitIPRangeGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysAdminUnitIPRangeGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

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
			var process = (SysAdminUnitIPRangeGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysAdminUnitIPRangeGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysAdminUnitIPRangeGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRangeGridPageEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitIPRangeGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitIPRangeGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitIPRangeGridPageEventsProcessSchema(SysAdminUnitIPRangeGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitIPRangeGridPageEventsProcess";
			UId = new Guid("759454ed-1243-4180-b361-f8b027ec4797");
			CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
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
			ProcessSchemaStartMessageEvent pageloadcomplete_sysadminunitiprangegridpage_startmessage = CreatePageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcomplete_sysadminunitiprangegridpage_startmessage);
			ProcessSchemaScriptTask processpageloadcomplete_scripttask = CreateProcessPageLoadComplete_ScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(processpageloadcomplete_scripttask);
			ProcessSchemaIntermediateThrowMessageEvent sysadminunitiprangegridpage_intermediatethrowmessageevent = CreateSysAdminUnitIPRangeGridPage_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminunitiprangegridpage_intermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2529a2a6-e81f-421d-bf0e-c7eff35463fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				CurveCenterPosition = new Point(200, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6c9cca01-ca4c-413f-a3e0-893d0e4ca6e1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("21345cc7-8272-4077-8206-de1cb34da98b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("7ade5697-8d2a-4844-a37a-4a13c6d485fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				CurveCenterPosition = new Point(355, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21345cc7-8272-4077-8206-de1cb34da98b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a98eb40d-d0f7-4711-a681-d3253fb8c6ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ee52fb42-2aa2-4bdb-aa8e-e0a3c6f29756"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1179, 206),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("54c6dbae-303b-4531-87cb-e8a4f686af40"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ee52fb42-2aa2-4bdb-aa8e-e0a3c6f29756"),
				CreatedInOwnerSchemaUId = new Guid("f3e33bfc-6493-4934-a014-8b22fdd45d75"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1150, 206),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1d127e96-6557-4a48-8432-eeb35c431c27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("54c6dbae-303b-4531-87cb-e8a4f686af40"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(399, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6c9cca01-ca4c-413f-a3e0-893d0e4ca6e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d127e96-6557-4a48-8432-eeb35c431c27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				Name = @"PageLoadComplete_SysAdminUnitIPRangeGridPage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessPageLoadComplete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("21345cc7-8272-4077-8206-de1cb34da98b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d127e96-6557-4a48-8432-eeb35c431c27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				Name = @"ProcessPageLoadComplete_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,73,44,73,12,206,47,45,74,78,13,46,41,42,77,46,41,45,74,85,176,85,0,50,83,173,121,185,92,83,50,75,2,18,211,83,67,61,83,128,130,121,169,229,10,238,165,153,41,26,74,142,102,70,102,174,166,206,134,186,38,78,150,150,186,38,70,198,70,186,142,70,150,110,186,46,166,6,166,142,70,134,206,102,150,206,110,74,154,64,3,138,82,129,6,230,65,140,3,0,226,63,3,113,117,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminUnitIPRangeGridPage_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a98eb40d-d0f7-4711-a681-d3253fb8c6ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d127e96-6557-4a48-8432-eeb35c431c27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("759454ed-1243-4180-b361-f8b027ec4797"),
				Name = @"SysAdminUnitIPRangeGridPage_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(316, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
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
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitIPRangeGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("759454ed-1243-4180-b361-f8b027ec4797"));
		}

		#endregion

	}

	#endregion

}

