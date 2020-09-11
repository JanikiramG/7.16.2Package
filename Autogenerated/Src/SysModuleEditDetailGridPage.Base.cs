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
	using TSWebControls = Terrasoft.UI.WebControls;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: SysModuleEditDetailGridPageSchema

	/// <exclude/>
	public class SysModuleEditDetailGridPageSchema : Terrasoft.WebApp.BaseSortByPositionGridPageSchema
	{

		#region Constructors: Public

		public SysModuleEditDetailGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleEditDetailGridPageSchema(SysModuleEditDetailGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateUpPositionButton() {
			UpPositionButton.AjaxEvents.Click.IsProcessEventHandler = true;
			UpPositionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"),
				ImageHash = @"28e5147b7e6173c2fb14e6bacd7517ab"
			};
			UpPositionButton.Hidden = true;
			UpPositionButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateDownPositionButton() {
			DownPositionButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownPositionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"),
				ImageHash = @"2b3c485798ac9920a70b8fe868d08161"
			};
			DownPositionButton.Enabled = false;
			DownPositionButton.Hidden = true;
			DownPositionButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
			RealUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
			Name = "SysModuleEditDetailGridPage";
			ParentSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEditDetailGridPageEventsProcessSchema();
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
			UpdateDownPositionButton();
			UpdateUpPositionButton();
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
			ButtonsControlLayout.MoveItem(5, UpPositionButton);
			ButtonsControlLayout.MoveItem(6, DownPositionButton);
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

		protected virtual EmbeddedProcessSchema CreateSysModuleEditDetailGridPageEventsProcessSchema() {
			var schema = new SysModuleEditDetailGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("86442450-82a2-4f99-8f51-670bcffd214d");
			DataSource.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ddde023e-3da1-4c7f-a8f7-28b2d8ae7a10");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("4e73b773-9a52-4ec3-8994-1fb61d9c3dea");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("c52bc4b3-3487-4be2-a1fd-efebedd7aeb8");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e8b57ade-eed6-497f-9ee2-9ad81cfb8cdf");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("b8daacbb-3a79-436a-bceb-d2ce9b5972b8");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1e0bc741-7c86-4512-955d-6948f9273acc");
			if (column != null) {
				column.UId = new Guid("9f749c96-c999-4a98-a7d3-ddfa1d70473e");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("62ca3788-1388-4db8-976c-91ba8930672a");
			if (column != null) {
				column.UId = new Guid("2ecf89db-64d6-48dc-a36c-04f166a83b0a");
				column.Name = @"SysModuleEdit";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1af37555-5e0e-4a99-99e0-472a65641527");
			if (column != null) {
				column.UId = new Guid("1682e0d9-9cd9-4dbf-beb1-b867b650e125");
				column.Name = @"SysModuleGrid";
				column.CreatedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
				column.ModifiedInSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
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
			return new SysModuleEditDetailGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleEditDetailGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleEditDetailGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditDetailGridPageEventsProcess

	/// <exclude/>
	public class SysModuleEditDetailGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseSortByPositionGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleEditDetailGridPageSchemaUserControl
	{

		public SysModuleEditDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEditDetailGridPageEventsProcess";
			SchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
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

		public virtual Guid SelectedSysModuleEntityId {
			get;
			set;
		}

		public virtual Guid SelectedSysModuleEditId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("ab9f58e9-fd6f-4b9f-ac29-bedd87525546"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startPageLoadComplete;
		public ProcessFlowElement StartPageLoadComplete {
			get {
				return _startPageLoadComplete ?? (_startPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartPageLoadComplete",
					SchemaElementUId = new Guid("427fc1e8-1c34-46c6-86df-11edae6449f6"),
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
					SchemaElementUId = new Guid("5d770e5f-8010-4c75-bb26-3a95ff63debf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildScriptPageLoadComplete;
		public ProcessScriptTask ScriptChildScriptPageLoadComplete {
			get {
				return _scriptChildScriptPageLoadComplete ?? (_scriptChildScriptPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildScriptPageLoadComplete",
					SchemaElementUId = new Guid("f8b4e6d0-3330-4650-a86c-1eb68c48de43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildScriptPageLoadCompleteExecute,
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
					SchemaElementUId = new Guid("fe5b0bc5-0338-49bc-9bdb-9088daa3fb8e"),
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
					SchemaElementUId = new Guid("f08ae47b-8727-4cc5-a23a-23c47e9b8bea"),
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
					SchemaElementUId = new Guid("03d4d1c1-1ef6-4378-b0a9-3915a19cece8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartPageLoadComplete };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptChildScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildScriptPageLoadComplete };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess9":
						break;
					case "StartPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptChildScriptPageLoadComplete");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "ScriptChildScriptPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage3":
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
			ActivatedEventElements.Add("StartPageLoadComplete");
			ActivatedEventElements.Add("StartMessage3");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartPageLoadComplete";
					result = StartPageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptChildScriptPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildScriptPageLoadComplete";
					result = ScriptChildScriptPageLoadComplete.Execute(context, ScriptChildScriptPageLoadCompleteExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SelectedSysModuleEditId":
					SelectedSysModuleEditId = reader.GetValue<System.Guid>();
				break;
				case "SelectedSysModuleEntityId":
					SelectedSysModuleEntityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptChildScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			EditPageUId = new Guid("77031dfa-656c-45e6-b9f9-f9c4c51ce579");
			IsDetailGrid = true;
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var filterName = "ModuleEditFilter";
			var dataSource = Page.DataSource;
			var structure = dataSource.CurrentStructure;
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = null;
			filters = dataSource.FindFiltersGroupByName(filterName);
			if (filters != null) {
				structure.Filters.Remove(filters);
			}
			filters = structure.CreateFiltersGroup(filterName, LogicalOperationStrict.And);
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, 
				Terrasoft.Core.Entities.FilterComparisonType.Equal, "SysModuleEdit.Id", 
				SelectedSysModuleEditId));
			structure.Filters.Add(filters);
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = base.GetButtons();
			buttons.Add(Page.UpPositionButton.Name);
			buttons.Add(Page.DownPositionButton.Name);
			return buttons;
		}

		public override void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			string dataSourceClientId = "window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']]";
				queryStringParameters["ParentEntityId"] = dataSourceClientId + ".activeRow.getPrimaryColumnValue()";
		}

		public override void ModifyCopyPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			string dataSourceClientId = "window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']]";
				queryStringParameters["ParentEntityId"] = dataSourceClientId + ".activeRow.getPrimaryColumnValue()";
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartPageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
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
			if (!HasMapping("SelectedSysModuleEditId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedSysModuleEditId", SelectedSysModuleEditId, Guid.Empty);
			}
			if (!HasMapping("SelectedSysModuleEntityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedSysModuleEntityId", SelectedSysModuleEntityId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditDetailGridPageEventsProcess

	/// <exclude/>
	public class SysModuleEditDetailGridPageEventsProcess : SysModuleEditDetailGridPageEventsProcess<Terrasoft.WebApp.SysModuleEditDetailGridPageSchemaUserControl>
	{

		public SysModuleEditDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEditDetailGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleEditDetailGridPageSchemaUserControl : Terrasoft.WebApp.BaseSortByPositionGridPageSchemaUserControl
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
			var process = (SysModuleEditDetailGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleEditDetailGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysModuleEditDetailGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditDetailGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleEditDetailGridPageEventsProcessSchema : Terrasoft.WebApp.BaseSortByPositionGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEditDetailGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEditDetailGridPageEventsProcessSchema(SysModuleEditDetailGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEditDetailGridPageEventsProcess";
			UId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateSelectedSysModuleEntityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("89d97ba7-342e-4a95-a39a-a63fabb75412"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"SelectedSysModuleEntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedSysModuleEditIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4869aa63-c66c-4836-9ea6-6920c35402b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"SelectedSysModuleEditId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSelectedSysModuleEntityIdParameter());
			Parameters.Add(CreateSelectedSysModuleEditIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet880 = CreateLaneSet880LaneSet();
			LaneSets.Add(schemaLaneSet880);
			ProcessSchemaLane schemaLane3223 = CreateLane3223Lane();
			schemaLaneSet880.Lanes.Add(schemaLane3223);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent startpageloadcomplete = CreateStartPageLoadCompleteStartMessageEvent();
			eventsubprocess9.FlowElements.Add(startpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptchildscriptpageloadcomplete = CreateScriptChildScriptPageLoadCompleteScriptTask();
			eventsubprocess9.FlowElements.Add(scriptchildscriptpageloadcomplete);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow19367SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19367SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19367",
				UId = new Guid("5730cac2-d825-4150-8240-b4ebbae34443"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				CurveCenterPosition = new Point(526, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f08ae47b-8727-4cc5-a23a-23c47e9b8bea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03d4d1c1-1ef6-4378-b0a9-3915a19cece8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ad584391-e1cd-45aa-abfe-71c18d280d30"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				CurveCenterPosition = new Point(161, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("427fc1e8-1c34-46c6-86df-11edae6449f6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f8b4e6d0-3330-4650-a86c-1eb68c48de43"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6f9dc91b-b916-4ffa-8ec6-da563022d589"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				CurveCenterPosition = new Point(294, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f8b4e6d0-3330-4650-a86c-1eb68c48de43"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d770e5f-8010-4c75-bb26-3a95ff63debf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet880LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet880 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b96ba519-195c-4a41-a253-18c6eff69065"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"LaneSet880",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(681, 221),
				UseBackgroundMode = false
			};
			return schemaLaneSet880;
		}

		protected virtual ProcessSchemaLane CreateLane3223Lane() {
			ProcessSchemaLane schemaLane3223 = new ProcessSchemaLane(this) {
				UId = new Guid("dac85b1b-7c2f-4794-92aa-564bba216de4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b96ba519-195c-4a41-a253-18c6eff69065"),
				CreatedInOwnerSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"Lane3223",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(652, 221),
				UseBackgroundMode = false
			};
			return schemaLane3223;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ab9f58e9-fd6f-4b9f-ac29-bedd87525546"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dac85b1b-7c2f-4794-92aa-564bba216de4"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 37),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("427fc1e8-1c34-46c6-86df-11edae6449f6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab9f58e9-fd6f-4b9f-ac29-bedd87525546"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"StartPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("5d770e5f-8010-4c75-bb26-3a95ff63debf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab9f58e9-fd6f-4b9f-ac29-bedd87525546"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f8b4e6d0-3330-4650-a86c-1eb68c48de43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab9f58e9-fd6f-4b9f-ac29-bedd87525546"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"ScriptChildScriptPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,77,201,44,9,72,76,79,13,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,50,55,55,48,54,76,73,75,212,53,51,53,75,214,53,49,77,53,211,77,178,76,179,212,77,179,76,54,73,54,53,76,78,53,53,183,84,210,180,230,242,44,118,73,45,73,204,204,113,47,202,4,25,80,82,84,154,106,205,85,148,90,82,90,148,7,225,0,0,84,182,167,150,97,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fe5b0bc5-0338-49bc-9bdb-9088daa3fb8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dac85b1b-7c2f-4794-92aa-564bba216de4"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 37),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f08ae47b-8727-4cc5-a23a-23c47e9b8bea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe5b0bc5-0338-49bc-9bdb-9088daa3fb8e"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03d4d1c1-1ef6-4378-b0a9-3915a19cece8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe5b0bc5-0338-49bc-9bdb-9088daa3fb8e"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,203,110,195,32,16,60,199,95,65,125,114,164,136,31,176,122,72,221,164,138,212,71,84,167,202,153,154,77,130,132,193,93,150,72,81,213,127,47,212,177,113,213,222,128,157,199,206,112,22,200,14,74,19,224,179,104,129,221,178,252,201,74,175,97,37,21,173,127,222,243,50,59,7,144,20,36,106,235,177,137,160,173,56,2,191,31,95,122,132,35,244,13,121,140,128,132,230,149,71,4,67,245,48,45,179,29,32,10,103,15,196,223,54,124,15,239,149,53,132,86,59,62,30,146,116,191,67,101,181,134,134,148,53,215,101,93,240,48,94,235,50,75,247,137,231,90,25,217,51,221,3,90,223,221,93,98,186,34,5,157,151,153,58,176,98,32,223,244,106,115,246,153,205,198,24,252,170,192,95,161,181,231,129,237,2,245,107,226,154,224,21,130,32,152,218,78,12,23,236,209,30,85,35,244,75,7,40,98,146,80,136,106,136,47,141,156,143,41,248,82,202,226,127,197,189,162,211,86,96,144,138,192,98,18,182,110,78,208,138,5,203,102,169,216,202,6,250,202,144,34,5,142,15,37,182,157,64,229,172,217,93,186,48,253,240,66,47,88,94,95,92,250,114,190,145,121,84,170,33,246,13,242,215,112,35,231,97,213,191,253,196,165,83,57,8,97,104,88,64,65,249,13,18,84,33,4,94,2,0,0 }
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
				UId = new Guid("f759fd7f-c235-4aad-9f86-46ed65d3d366"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
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

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,72,74,44,78,213,115,79,45,113,130,136,104,104,90,115,65,37,245,28,83,82,52,2,18,211,83,245,66,11,2,242,139,51,75,50,243,243,32,170,244,252,18,115,83,177,41,116,201,47,207,195,174,180,40,181,164,180,40,15,102,175,53,0,196,172,62,171,132,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = base.CreateModifyEditPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,189,10,131,48,20,70,231,246,41,36,139,74,33,47,32,157,212,130,67,65,42,116,17,41,33,247,34,129,252,208,228,70,155,183,175,182,208,169,219,89,190,239,156,64,94,217,57,3,65,98,112,209,75,172,181,66,75,29,100,231,140,173,202,130,91,199,246,69,28,80,58,192,98,199,25,169,200,101,12,228,76,179,205,46,10,53,228,37,7,103,248,34,116,196,114,204,135,20,174,14,162,198,135,144,164,22,108,126,247,249,52,177,234,120,120,70,244,105,248,184,123,225,133,65,66,31,70,182,241,38,111,45,41,74,29,176,105,139,248,83,118,202,24,255,254,222,220,186,231,244,94,25,225,83,237,116,52,246,190,55,20,37,171,222,141,218,16,158,219,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyCopyPageParametersMethod() {
			SchemaMethod method = base.CreateModifyCopyPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,189,10,131,48,20,70,231,246,41,36,139,74,33,47,32,157,212,130,67,65,42,116,17,41,33,247,34,129,252,208,228,70,155,183,175,182,208,169,219,89,190,239,156,64,94,217,57,3,65,98,112,209,75,172,181,66,75,29,100,231,140,173,202,130,91,199,246,69,28,80,58,192,98,199,25,169,200,101,12,228,76,179,205,46,10,53,228,37,7,103,248,34,116,196,114,204,135,20,174,14,162,198,135,144,164,22,108,126,247,249,52,177,234,120,120,70,244,105,248,184,123,225,133,65,66,31,70,182,241,38,111,45,41,74,29,176,105,139,248,83,118,202,24,255,254,222,220,186,231,244,94,25,225,83,237,116,52,246,190,55,20,37,171,222,141,218,16,158,219,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEditDetailGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72bf41f5-1852-4397-b415-2a29f96d36ef"));
		}

		#endregion

	}

	#endregion

}

