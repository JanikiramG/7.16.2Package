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

	#region Class: SysModuleReportTableGridPageSchema

	/// <exclude/>
	public class SysModuleReportTableGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public SysModuleReportTableGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportTableGridPageSchema(SysModuleReportTableGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
			RealUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
			Name = "SysModuleReportTableGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportTableGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateSysModuleReportTableGridPageEventsProcessSchema() {
			var schema = new SysModuleReportTableGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("fa05df4e-0361-4496-8198-5aa5b2dbe677");
			DataSource.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("3453850b-2dec-4200-ab82-39a220df1ae9");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("da0f8f38-8974-431b-a560-7df785249036");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2f560358-9c67-4ddb-8ae8-e9507c0faab9");
			if (column != null) {
				column.UId = new Guid("2a6ab316-6422-4b90-8255-93003b319d1c");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("06887b30-8b11-4aa4-bc52-7db64e1ae018");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("177edb45-83ac-45b0-9845-276dc3e62188");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("6a10a5b1-24a9-4d82-9be9-cd3a5923c246");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("11d339af-619d-4619-8891-4d455543288f");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7859f576-8fbb-4a09-84c9-e52fc2a24181");
			if (column != null) {
				column.UId = new Guid("958dbcd1-102f-4a48-8bcd-de730d8ecb8f");
				column.Name = @"Object";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("dcbcf570-397b-4c65-bc5c-ffc91e6cc60a");
			if (column != null) {
				column.UId = new Guid("d5301298-f165-4fcd-bc22-7fb465d6bba4");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
			column.Caption.SetResourceInfo("6eac44c556844f4d92f918bab315b954", "Controls.DataSource.DefStructure.Columns.Name.Caption");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8501dbf4-1603-4e8b-b875-e1d9c8de5e8c");
			if (column != null) {
				column.UId = new Guid("c6fd47f9-f70d-4f7e-bd45-2f175bd56579");
				column.Name = @"SysModuleReport";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("79a3fa68-aef2-4ed5-86d2-5fb4dc4a7ae3");
			if (column != null) {
				column.UId = new Guid("2fa5086a-78e8-4ecc-bdf6-602855db623c");
				column.Name = @"ReferenceColumn";
				column.CreatedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
				column.ModifiedInSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
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
			return new SysModuleReportTableGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportTableGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportTableGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportTableGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportTableGridPageSchemaUserControl
	{

		public SysModuleReportTableGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportTableGridPageEventsProcess";
			SchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
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
					SchemaElementUId = new Guid("d0a5e37e-be44-4f7d-8b51-0307ce6e1f67"),
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
					SchemaElementUId = new Guid("3e28d79e-646b-4d70-8c8a-f294ede9d247"),
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
					SchemaElementUId = new Guid("ae8a2ca5-9576-412f-b754-9581923b0b2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent1 {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent1 ?? (_pageLoadCompleteIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("c5a7d518-380b-4cff-8ff8-3aea3bf5d949"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("3dcbe044-53a8-4353-98b1-a2f060a19a3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2BasePrepareFilters;
		public ProcessFlowElement StartMessage2BasePrepareFilters {
			get {
				return _startMessage2BasePrepareFilters ?? (_startMessage2BasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2BasePrepareFilters",
					SchemaElementUId = new Guid("a6fbb451-2b2b-4b13-a2f7-b758efacddf4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("72b5012b-3b89-401b-960a-69a7cc89a673"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage2BasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2BasePrepareFilters };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent1");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage2BasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
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
			ActivatedEventElements.Add("StartMessage2BasePrepareFilters");
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
				case "PageLoadCompleteIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2BasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2BasePrepareFilters";
					result = StartMessage2BasePrepareFilters.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
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
			EditPageUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			IsDetailGrid = true;
			
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var filterName = "DetailFilter";
			var dataSource = Page.DataSource;
			var structure = dataSource.CurrentStructure;
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = null;
			filters = dataSource.FindFiltersGroupByName(filterName);
			if (filters != null) {
				structure.Filters.Remove(filters);
			}
			filters = structure.CreateFiltersGroup(filterName, LogicalOperationStrict.And);
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, 
				Terrasoft.Core.Entities.FilterComparisonType.Equal, "SysModuleReport", 
				SelectedNodePrimaryColumnValue));
			structure.Filters.Add(filters);
			return true;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			Page.AddButton.Enabled = true;
		}

		public override void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			base.ModifyEditPageParameters(openPageParameters, queryStringParameters);
			queryStringParameters["ParentEntitySchemaId"] = SysEntitySchemaId.ToString("N");
		}

		public override void ModifyCopyPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			base.ModifyCopyPageParameters(openPageParameters, queryStringParameters);
			queryStringParameters["ParentEntitySchemaId"] = SysEntitySchemaId.ToString("N");
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("StartMessage2BasePrepareFilters")) {
							context.QueueTasks.Enqueue("StartMessage2BasePrepareFilters");
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

	#region Class: SysModuleReportTableGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportTableGridPageEventsProcess : SysModuleReportTableGridPageEventsProcess<Terrasoft.WebApp.SysModuleReportTableGridPageSchemaUserControl>
	{

		public SysModuleReportTableGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportTableGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportTableGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
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
			var process = (SysModuleReportTableGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportTableGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysModuleReportTableGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportTableGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportTableGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportTableGridPageEventsProcessSchema(SysModuleReportTableGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportTableGridPageEventsProcess";
			UId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2");
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
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent1 = CreatePageLoadCompleteIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessage2basepreparefilters = CreateStartMessage2BasePrepareFiltersStartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage2basepreparefilters);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("fde12922-94ce-48c2-ab6b-832b36fc473f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				CurveCenterPosition = new Point(209, 273),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a6fbb451-2b2b-4b13-a2f7-b758efacddf4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("72b5012b-3b89-401b-960a-69a7cc89a673"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("74b99afa-e5e0-43c8-ba8b-97b96dd4b430"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				CurveCenterPosition = new Point(227, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e28d79e-646b-4d70-8c8a-f294ede9d247"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ae8a2ca5-9576-412f-b754-9581923b0b2b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("929998bc-b814-4c07-aa5c-cd94454c8a81"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				CurveCenterPosition = new Point(366, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ae8a2ca5-9576-412f-b754-9581923b0b2b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c5a7d518-380b-4cff-8ff8-3aea3bf5d949"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3b53645f-093e-41a7-841a-c577b6cd7843"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(550, 367),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("aef62c84-04a2-4f56-90f3-61e4c6ba5e80"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3b53645f-093e-41a7-841a-c577b6cd7843"),
				CreatedInOwnerSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(521, 367),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d0a5e37e-be44-4f7d-8b51-0307ce6e1f67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aef62c84-04a2-4f56-90f3-61e4c6ba5e80"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(431, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3e28d79e-646b-4d70-8c8a-f294ede9d247"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0a5e37e-be44-4f7d-8b51-0307ce6e1f67"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(64, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ae8a2ca5-9576-412f-b754-9581923b0b2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0a5e37e-be44-4f7d-8b51-0307ce6e1f67"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,77,201,44,9,72,76,79,13,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,74,73,76,49,77,50,76,76,214,77,51,51,49,211,53,73,77,75,211,77,52,53,76,210,53,53,3,10,24,153,27,165,26,166,90,42,105,90,243,114,121,22,187,164,150,36,102,230,184,23,101,130,76,40,41,42,77,5,138,242,114,21,165,150,148,22,229,65,248,0,63,239,49,226,101,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c5a7d518-380b-4cff-8ff8-3aea3bf5d949"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0a5e37e-be44-4f7d-8b51-0307ce6e1f67"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3dcbe044-53a8-4353-98b1-a2f060a19a3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aef62c84-04a2-4f56-90f3-61e4c6ba5e80"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(336, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2BasePrepareFiltersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a6fbb451-2b2b-4b13-a2f7-b758efacddf4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3dcbe044-53a8-4353-98b1-a2f060a19a3b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"StartMessage2BasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("72b5012b-3b89-401b-960a-69a7cc89a673"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3dcbe044-53a8-4353-98b1-a2f060a19a3b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,209,78,2,49,16,124,150,132,127,168,60,221,37,164,63,64,124,192,67,140,137,34,225,80,159,215,235,2,77,122,237,185,221,146,92,140,255,110,11,28,119,137,190,53,187,51,179,51,211,35,144,216,105,195,72,43,168,81,220,137,201,2,25,180,89,158,102,147,217,120,116,140,8,5,12,165,11,84,37,196,26,246,40,23,215,201,5,226,153,66,197,129,18,162,135,203,34,16,161,229,178,219,70,244,22,137,192,187,29,203,183,39,249,129,159,133,179,76,206,120,121,125,244,226,103,27,133,51,6,43,214,206,94,188,250,120,196,6,99,162,90,63,24,92,93,106,171,206,84,255,72,46,52,247,109,74,151,245,65,243,200,212,59,145,117,236,219,179,94,46,190,199,163,155,107,20,121,209,144,27,172,221,177,227,251,68,254,25,94,238,9,5,33,48,14,79,15,142,78,197,179,219,235,10,204,107,131,4,41,78,172,69,87,44,231,86,229,125,20,57,87,42,251,95,242,67,243,97,13,20,181,18,48,27,36,46,171,3,214,48,21,209,126,223,111,225,34,255,193,178,102,141,94,118,93,214,13,144,246,206,110,219,38,110,191,2,152,169,152,148,173,127,113,42,24,220,96,227,136,39,39,165,18,83,237,168,86,78,225,154,116,13,212,198,175,8,181,125,7,19,48,79,158,255,118,149,220,15,138,34,140,91,43,34,12,103,191,105,176,144,230,109,2,0,0 }
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

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,76,46,201,44,75,44,73,117,42,45,41,201,207,43,214,72,132,242,53,173,185,2,18,211,129,242,41,41,16,41,61,215,188,196,164,156,212,20,5,91,133,146,162,210,84,107,0,241,137,125,217,62,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = base.CreateModifyEditPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,205,79,201,76,171,116,77,201,44,9,72,76,79,13,72,44,74,204,77,45,73,45,42,214,200,47,72,205,67,21,210,81,40,44,77,45,170,12,46,41,202,204,75,71,8,107,90,243,114,97,149,136,86,2,178,83,243,74,92,243,74,50,75,42,131,147,51,82,115,19,61,83,148,98,21,108,21,130,43,139,81,69,245,66,242,33,218,53,148,252,148,52,173,1,11,30,66,99,155,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyCopyPageParametersMethod() {
			SchemaMethod method = base.CreateModifyCopyPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,205,79,201,76,171,116,206,47,168,12,72,76,79,13,72,44,74,204,77,45,73,45,42,214,200,47,72,205,67,21,210,81,40,44,77,45,170,12,46,41,202,204,75,71,8,107,90,243,114,97,149,136,86,2,178,83,243,74,92,243,74,50,75,42,131,147,51,82,115,19,61,83,148,98,21,108,21,130,43,139,81,69,245,66,242,33,218,53,148,252,148,52,173,1,14,246,248,28,155,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportTableGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b7667c6-6fe8-41d8-bc7d-23de8b33dff2"));
		}

		#endregion

	}

	#endregion

}

