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

	#region Class: SysEntitySchemaInPackageLookupGridPageSchema

	/// <exclude/>
	public class SysEntitySchemaInPackageLookupGridPageSchema : Terrasoft.WebApp.LookupGridPageSchema
	{

		#region Constructors: Public

		public SysEntitySchemaInPackageLookupGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysEntitySchemaInPackageLookupGridPageSchema(SysEntitySchemaInPackageLookupGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateSchemaListEdit() {
			SchemaListEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SchemaListEdit.Image = new ControlImage {};
			SchemaListEdit.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSearchComboBoxEdit() {
			SearchComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SearchComboBoxEdit.Image = new ControlImage {};
			SearchComboBoxEdit.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateToolButtonClearSearch() {
			ToolButtonClearSearch.AjaxEvents.Click.IsProcessEventHandler = true;
			ToolButtonClearSearch.Image = new ControlImage {
				Source = ControlImageSource.ResourceManager,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ResourceManagerName = @"Terrasoft.UI.WebControls",
				ResourceItemName = @"toolbutton-close.gif",
				ImageHash = @"6936621ac4b4c164b51744b8634fe7a0"
			};
			ToolButtonClearSearch.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSearchEdit() {
			SearchEdit.Image = new ControlImage {};
			SearchEdit.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSearchButton() {
			SearchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SearchButton.Image = new ControlImage {};
			SearchButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSearchControlLayout() {
			SearchControlLayout.Image = new ControlImage {};
			SearchControlLayout.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.ShowLoadMask = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
		}

		private void UpdateAddSelectedRecordButton() {
			AddSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"f5fb6c4a8d5abab00bede0e49a38a6ff"
			};
			AddSelectedRecordButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateRemoveSelectedRecordButton() {
			RemoveSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			RemoveSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"012f06e2ee1dc8d32d3959105560eacd"
			};
			RemoveSelectedRecordButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSelectedRecordButtonsControlLayout() {
			SelectedRecordButtonsControlLayout.Image = new ControlImage {};
			SelectedRecordButtonsControlLayout.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSelectedRecordsGridContolLayout() {
			SelectedRecordsGridContolLayout.Image = new ControlImage {};
			SelectedRecordsGridContolLayout.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateSelectedRowsControlLayout() {
			SelectedRowsControlLayout.Image = new ControlImage {};
			SelectedRowsControlLayout.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateCommonControlLayout() {
			CommonControlLayout.Image = new ControlImage {};
			CommonControlLayout.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		private void UpdateActionButtonsControlLayout() {
			ActionButtonsControlLayout.Image = new ControlImage {};
			ActionButtonsControlLayout.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
			RealUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
			Name = "SysEntitySchemaInPackageLookupGridPage";
			ParentSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntitySchemaInPackageLookupGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateActionButtonsControlLayout();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateCommonControlLayout();
			UpdateSelectedRowsControlLayout();
			UpdateSelectedRecordsGridContolLayout();
			UpdateSelectedRecordButtonsControlLayout();
			UpdateRemoveSelectedRecordButton();
			UpdateAddSelectedRecordButton();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			UpdateSearchControlLayout();
			UpdateSearchButton();
			UpdateSearchEdit();
			UpdateToolButtonClearSearch();
			UpdateSearchComboBoxEdit();
			UpdateSchemaListEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, SearchControlLayout);
			SearchControlLayout.MoveItem(0, SchemaListEdit);
			SearchControlLayout.MoveItem(1, SearchComboBoxEdit);
			SearchControlLayout.MoveItem(2, SearchEdit);
			SearchEdit.MoveItem(0, ToolButtonClearSearch);
			SearchControlLayout.MoveItem(3, SearchButton);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerDeleteButton);
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			ButtonsControlLayout.MoveItem(8, ActionButton);
			TopLevelControl.MoveItem(3, CommonControlLayout);
			CommonControlLayout.MoveItem(0, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, CallMenuItem);
			TreeGrid.MoveItem(2, ShowChangelogMenuItem);
			CommonControlLayout.MoveItem(1, SelectedRowsControlLayout);
			SelectedRowsControlLayout.MoveItem(0, SelectedRecordButtonsControlLayout);
			SelectedRecordButtonsControlLayout.MoveItem(0, Spacer1);
			SelectedRecordButtonsControlLayout.MoveItem(1, AddSelectedRecordButton);
			SelectedRecordButtonsControlLayout.MoveItem(2, RemoveSelectedRecordButton);
			SelectedRecordButtonsControlLayout.MoveItem(3, Spacer2);
			SelectedRowsControlLayout.MoveItem(1, SelectedRecordsGridContolLayout);
			SelectedRecordsGridContolLayout.MoveItem(0, SelectedRecordsGrid);
			TopLevelControl.MoveItem(4, ActionButtonsControlLayout);
			ActionButtonsControlLayout.MoveItem(0, SpacerOKButton);
			ActionButtonsControlLayout.MoveItem(1, OKButton);
			ActionButtonsControlLayout.MoveItem(2, CancelButton);
			TopLevelControl.MoveItem(5, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysEntitySchemaInPackageLookupGridPageEventsProcessSchema() {
			var schema = new SysEntitySchemaInPackageLookupGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			DataSource.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("40cbdc3d-3d91-419a-a921-8e0643185d8a");
			if (column != null) {
				column.UId = new Guid("928e121d-1b0c-4067-8a26-292b0aafa3e4");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
				column.ModifiedInSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
				column.CreatedInPackageId = Guid.Empty;
				column.IsHideable = false;
				column.OrderDirection = OrderDirection.Ascending;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysEntitySchemaInPackageLookupGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysEntitySchemaInPackageLookupGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysEntitySchemaInPackageLookupGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaInPackageLookupGridPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaInPackageLookupGridPageEventsProcess<TPage> : Terrasoft.WebApp.LookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysEntitySchemaInPackageLookupGridPageSchemaUserControl
	{

		public SysEntitySchemaInPackageLookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaInPackageLookupGridPageEventsProcess";
			SchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57");
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
					SchemaElementUId = new Guid("8bea3e14-0bd0-43cd-9a4b-2c17e5fa25bd"),
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
					SchemaElementUId = new Guid("7de23db9-e21d-41dc-bb24-381ecef356f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("99f60d1f-5b5d-4441-8ffa-a410f08f3da2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("c04d3111-786d-4439-9e60-a9e6c633a7d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Page.DataSource.DefStructure.Columns.Clear();
			Page.DataSource.Loading += delegate(object sender, DataSourceEventArgs e) {
				e.SelectQuery.Distinct();
			};
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaInPackageLookupGridPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaInPackageLookupGridPageEventsProcess : SysEntitySchemaInPackageLookupGridPageEventsProcess<Terrasoft.WebApp.SysEntitySchemaInPackageLookupGridPageSchemaUserControl>
	{

		public SysEntitySchemaInPackageLookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaInPackageLookupGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysEntitySchemaInPackageLookupGridPageSchemaUserControl : Terrasoft.WebApp.LookupGridPageSchemaUserControl
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
			var process = (SysEntitySchemaInPackageLookupGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysEntitySchemaInPackageLookupGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysEntitySchemaInPackageLookupGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaInPackageLookupGridPageEventsProcessSchema

	/// <exclude/>
	public class SysEntitySchemaInPackageLookupGridPageEventsProcessSchema : Terrasoft.WebApp.LookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntitySchemaInPackageLookupGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntitySchemaInPackageLookupGridPageEventsProcessSchema(SysEntitySchemaInPackageLookupGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntitySchemaInPackageLookupGridPageEventsProcess";
			UId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca");
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f");
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
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent2);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("92a4cc90-8bb3-4cf9-9f43-2ee742084086"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				CurveCenterPosition = new Point(186, 124),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7de23db9-e21d-41dc-bb24-381ecef356f7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("99f60d1f-5b5d-4441-8ffa-a410f08f3da2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("f3dc96ec-a613-4b7c-89de-64ffa91bc335"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				CurveCenterPosition = new Point(294, 124),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("99f60d1f-5b5d-4441-8ffa-a410f08f3da2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c04d3111-786d-4439-9e60-a9e6c633a7d5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("81c8c1c4-391e-40a6-addc-dd61f523d853"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(992, 227),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("88753a39-256f-4ddb-9397-6dbec0494e39"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("81c8c1c4-391e-40a6-addc-dd61f523d853"),
				CreatedInOwnerSchemaUId = new Guid("74ae0914-89f6-439b-a141-ad92fb2e0e57"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(963, 227),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8bea3e14-0bd0-43cd-9a4b-2c17e5fa25bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88753a39-256f-4ddb-9397-6dbec0494e39"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(63, 35),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7de23db9-e21d-41dc-bb24-381ecef356f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8bea3e14-0bd0-43cd-9a4b-2c17e5fa25bd"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("99f60d1f-5b5d-4441-8ffa-a410f08f3da2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8bea3e14-0bd0-43cd-9a4b-2c17e5fa25bd"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,49,10,2,49,20,68,107,23,246,14,191,220,69,201,5,22,11,217,181,179,88,201,9,98,50,134,72,76,224,231,71,16,241,238,6,27,193,98,96,138,55,204,91,141,135,90,140,24,157,43,219,86,113,213,194,213,74,101,168,57,199,122,79,69,205,17,134,135,113,234,187,245,15,63,101,227,66,242,180,221,147,67,132,55,130,33,95,110,176,66,5,201,129,119,244,163,143,15,36,57,176,47,132,145,94,125,183,129,210,109,100,229,92,193,79,181,132,34,33,89,249,30,189,91,24,205,34,81,211,193,244,1,86,191,237,74,168,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c04d3111-786d-4439-9e60-a9e6c633a7d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8bea3e14-0bd0-43cd-9a4b-2c17e5fa25bd"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("34728360-cad5-4c8c-8131-3092980e44ca"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 65),
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
				UId = new Guid("041f8571-1e0d-4d76-9587-98645fd79cea"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dc00bb50-26d4-4608-809c-73585d9eebd9"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaInPackageLookupGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34728360-cad5-4c8c-8131-3092980e44ca"));
		}

		#endregion

	}

	#endregion

}

