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

	#region Class: ChangeLogGridPageSchema

	/// <exclude/>
	public class ChangeLogGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public ChangeLogGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ChangeLogGridPageSchema(ChangeLogGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Hidden = true;
			AddButton.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.Hidden = true;
			DeleteButton.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
			RealUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
			Name = "ChangeLogGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateChangeLogGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateChangeLogGridPageEventsProcessSchema() {
			var schema = new ChangeLogGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d");
			DataSource.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e4a775f7-ad26-43b8-b49e-3da4a73313d0");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("25684e6e-383d-4da3-b493-88b33e29f9d7");
			if (column != null) {
				column.UId = new Guid("b216def1-3744-4dc8-ad35-b06e1f958b7f");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("bb6298b5-9852-4a45-b2e1-c05bb483b0a1");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("4b19a94c-8d4f-431a-9a61-c56d8def8eea");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("12619a02-2031-4a2f-9166-6530f8603482");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("5f36e418-7c1f-45cd-a08d-eab91bd34156");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("472b5c93-9dcb-4b97-ac6b-514b59e831dd");
			if (column != null) {
				column.UId = new Guid("4a56cc6c-16f6-4683-88ae-0bd1f0c322b6");
				column.Name = @"Operation";
				column.CreatedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.ModifiedInSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ChangeLogGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new ChangeLogGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ChangeLogGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogGridPageEventsProcess

	/// <exclude/>
	public class ChangeLogGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ChangeLogGridPageSchemaUserControl
	{

		public ChangeLogGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeLogGridPageEventsProcess";
			SchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
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

		public virtual bool UpdateSchema {
			get;
			set;
		}

		public virtual Guid ObjectSchemaId {
			get;
			set;
		}

		public virtual Object PreviousRow {
			get;
			set;
		}

		private ProcessFlowElement _dataSourceEventSubProcess;
		public ProcessFlowElement DataSourceEventSubProcess {
			get {
				return _dataSourceEventSubProcess ?? (_dataSourceEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DataSourceEventSubProcess",
					SchemaElementUId = new Guid("2ea36d5b-4225-4020-84bb-44e6ca4cd9f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeLoadStartMessage1;
		public ProcessFlowElement DataSourceBeforeLoadStartMessage1 {
			get {
				return _dataSourceBeforeLoadStartMessage1 ?? (_dataSourceBeforeLoadStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeLoadStartMessage1",
					SchemaElementUId = new Guid("21df277e-f290-414b-a478-314b69f4bf37"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initializeDataSourceCurrentStructureScriptTask;
		public ProcessScriptTask InitializeDataSourceCurrentStructureScriptTask {
			get {
				return _initializeDataSourceCurrentStructureScriptTask ?? (_initializeDataSourceCurrentStructureScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitializeDataSourceCurrentStructureScriptTask",
					SchemaElementUId = new Guid("f81277d0-2eba-4b2e-98d4-43ab80a3a7b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitializeDataSourceCurrentStructureScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _dataSourceStructureLoaded1;
		public ProcessThrowMessageEvent DataSourceStructureLoaded1 {
			get {
				return _dataSourceStructureLoaded1 ?? (_dataSourceStructureLoaded1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DataSourceStructureLoaded1",
					SchemaElementUId = new Guid("7adc1a55-f2d9-43ad-afbe-296d883f56cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceStructureLoaded",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _startMessageDataSourceStructureLoaded;
		public ProcessFlowElement StartMessageDataSourceStructureLoaded {
			get {
				return _startMessageDataSourceStructureLoaded ?? (_startMessageDataSourceStructureLoaded = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDataSourceStructureLoaded",
					SchemaElementUId = new Guid("e715849b-a8c0-4729-a519-061a7a9b5625"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("e89798ca-8092-4ed3-b177-11cf33a96bdc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _objectChangedStartMessage;
		public ProcessFlowElement ObjectChangedStartMessage {
			get {
				return _objectChangedStartMessage ?? (_objectChangedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ObjectChangedStartMessage",
					SchemaElementUId = new Guid("8836a87e-30ee-414e-aead-fee78caa96a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _objectChangedScriptTask;
		public ProcessScriptTask ObjectChangedScriptTask {
			get {
				return _objectChangedScriptTask ?? (_objectChangedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ObjectChangedScriptTask",
					SchemaElementUId = new Guid("e7bc8c4a-e252-479a-98bb-650caf4c0650"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectChangedScriptTaskExecute,
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
					SchemaElementUId = new Guid("8f700e68-18ff-418f-baba-5fc485005a4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _filterChangedScriptTask;
		public ProcessScriptTask FilterChangedScriptTask {
			get {
				return _filterChangedScriptTask ?? (_filterChangedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FilterChangedScriptTask",
					SchemaElementUId = new Guid("1aed32af-1d50-4e30-868a-2df619538df7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FilterChangedScriptTaskExecute,
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
					SchemaElementUId = new Guid("f28f729a-5208-4524-8700-ecc2fbdbd8e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("04981fcb-edfb-4488-9550-10772a0cccef"),
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
					SchemaElementUId = new Guid("1ca23f61-ee14-40d2-b08e-b36ca8fa4a24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("0c5a5b3d-dc85-490f-a41e-660abdeb5fe7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
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
					SchemaElementUId = new Guid("da73edde-2eea-4a35-8eb9-53e86b2e02f5"),
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
			FlowElements[DataSourceEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceEventSubProcess };
			FlowElements[DataSourceBeforeLoadStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeLoadStartMessage1 };
			FlowElements[InitializeDataSourceCurrentStructureScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitializeDataSourceCurrentStructureScriptTask };
			FlowElements[DataSourceStructureLoaded1.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceStructureLoaded1 };
			FlowElements[StartMessageDataSourceStructureLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDataSourceStructureLoaded };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ObjectChangedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectChangedStartMessage };
			FlowElements[ObjectChangedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectChangedScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[FilterChangedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FilterChangedScriptTask };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "DataSourceEventSubProcess":
						break;
					case "DataSourceBeforeLoadStartMessage1":
						e.Context.QueueTasks.Enqueue("InitializeDataSourceCurrentStructureScriptTask");
						break;
					case "InitializeDataSourceCurrentStructureScriptTask":
						break;
					case "DataSourceStructureLoaded1":
						e.Context.QueueTasks.Enqueue("InitializeDataSourceCurrentStructureScriptTask");
						break;
					case "StartMessageDataSourceStructureLoaded":
						e.Context.QueueTasks.Enqueue("DataSourceStructureLoaded1");
						break;
					case "EventSubProcess1":
						break;
					case "ObjectChangedStartMessage":
						e.Context.QueueTasks.Enqueue("ObjectChangedScriptTask");
						break;
					case "ObjectChangedScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "FilterChangedScriptTask":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("FilterChangedScriptTask");
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DataSourceBeforeLoadStartMessage1");
			ActivatedEventElements.Add("StartMessageDataSourceStructureLoaded");
			ActivatedEventElements.Add("ObjectChangedStartMessage");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "DataSourceEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeLoadStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeLoadStartMessage1";
					result = DataSourceBeforeLoadStartMessage1.Execute(context);
					break;
				case "InitializeDataSourceCurrentStructureScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitializeDataSourceCurrentStructureScriptTask";
					result = InitializeDataSourceCurrentStructureScriptTask.Execute(context, InitializeDataSourceCurrentStructureScriptTaskExecute);
					break;
				case "DataSourceStructureLoaded1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceStructureLoaded");
					result = DataSourceStructureLoaded1.Execute(context);
					break;
				case "StartMessageDataSourceStructureLoaded":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDataSourceStructureLoaded";
					result = StartMessageDataSourceStructureLoaded.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ObjectChangedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectChangedStartMessage";
					result = ObjectChangedStartMessage.Execute(context);
					break;
				case "ObjectChangedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectChangedScriptTask";
					result = ObjectChangedScriptTask.Execute(context, ObjectChangedScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "FilterChangedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FilterChangedScriptTask";
					result = FilterChangedScriptTask.Execute(context, FilterChangedScriptTaskExecute);
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
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
				case "PreviousRow":
					PreviousRow = reader.GetSerializableObjectValue();
				break;
				case "ObjectSchemaId":
					ObjectSchemaId = reader.GetValue<System.Guid>();
				break;
				case "UpdateSchema":
					UpdateSchema = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool InitializeDataSourceCurrentStructureScriptTaskExecute(ProcessExecutingContext context) {
			InitializeDataSourceCurrentStructure();
			return true;
		}

		public virtual bool ObjectChangedScriptTaskExecute(ProcessExecutingContext context) {
			var page = Page.AspPage as UI.WebControls.Page;
			var dataSource = Page.DataSource;	
			Page.TreeGrid.Clear();
			dataSource.CurrentStructure.Columns.Clear();
			if (ObjectSchemaId == Guid.Empty) {
				dataSource.LoadRows();
				return true;
			}
			EntitySchema logSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ObjectSchemaId).GetTrackChangesInDBSchema();
			Guid logSchemaUId = logSchema.UId;
			dataSource.Schema = logSchema;
			InitializeDataSourceCurrentStructure();
			if (page.UseProfile) {
				var args = new ProfileKeyEventArgs();
				args.Key = ObjectSchemaId + "_LOG";
				page.InitializeProfile(args, true);
				dataSource.IsProfileReaded = false;
				dataSource.InitializeProfile();
			}
			if (Ext.IsAjaxRequest) {
				dataSource.LoadRows();
			}
			return true;
		}

		public virtual bool FilterChangedScriptTaskExecute(ProcessExecutingContext context) {
			Page.TreeGrid.Clear();
			Guid schemaUId = Page.DataSource.SchemaUId;
			Page.DataSource.Schema = null;
			Page.DataSource.SchemaKind = EntitySchemaKind.TrackChangesInDB;
			Page.DataSource.SchemaUId = schemaUId;
			Page.DataSource.LoadRows();
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			var engineType = Page.UserConnection.DBEngine.DBEngineType;
			bool needRefreshMVwSysSchemaExtending = (engineType == DBEngineType.Oracle || engineType == DBEngineType.PostgreSql);
			if (needRefreshMVwSysSchemaExtending) {
				using (DBExecutor dbExecutor = Page.UserConnection.EnsureDBConnection()) {
					dbExecutor.RefreshMaterializedView("MVwSysSchemaExtending");
				}
			}
			//Page.DataSource.PrepareFilters += delegate(object sender, DataSourceEventArgs e) {	
			//	Guid schemaUId = Page.DataSource.SchemaUId;
			//	if (schemaUId != new Guid("62DB7A92-030F-4FD5-8402-911554830F9D")) {
			//		Page.DataSource.Schema = null;
			Page.DataSource.SchemaKind = EntitySchemaKind.TrackChangesInDB;
			//		Page.DataSource.SchemaUId = schemaUId;
			//	}
			//};
			if (UpdateSchema) {
				UpdateSchema = false;
				var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
				if (!page.IsPostBack && page.UseProfile) {	
					var args = new ProfileKeyEventArgs();
					args.Key = ObjectSchemaId + "PageProfile";
					page.InitializeProfile(args);
				}
			}
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual void InitializeDataSourceCurrentStructure() {
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			if (schema.PrimaryColumn == null) {
				throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
					"EntitySchema.Exception.Unspecified.PrimaryColumn"), schema.Name);
			}
			DataSourceStructure currentStructure = dataSource.CurrentStructure;
			Guid schemaPrimaryColumnUId = (schema.PrimaryColumn != null) ? schema.PrimaryColumn.UId : Guid.Empty;
			if (schemaPrimaryColumnUId != Guid.Empty &&
					currentStructure.Columns.FindByMetaPath(schemaPrimaryColumnUId.ToString()) == null) {
				var schemaPrimaryColumn = currentStructure.AddColumnByMetaPath(schemaPrimaryColumnUId.ToString());
				schemaPrimaryColumn.IsVisible = false;
				schemaPrimaryColumn.IsAlwaysSelect = true;
			}
			Guid schemaPrimaryDisplayColumnUId = (schema.PrimaryDisplayColumn != null) ? schema.PrimaryDisplayColumn.UId : Guid.Empty;
			if (schemaPrimaryDisplayColumnUId != Guid.Empty &&
					currentStructure.Columns.FindByMetaPath(schemaPrimaryDisplayColumnUId.ToString()) == null) {
				var schemaPrimaryDisplayColumn = currentStructure.AddColumnByMetaPath(schemaPrimaryDisplayColumnUId.ToString());
				schemaPrimaryDisplayColumn.IsVisible = true;
				schemaPrimaryDisplayColumn.IsAlwaysSelect = true;
			}
			EntitySchemaColumn modifiedByColumn = schema.FindSchemaColumnByPath("ChangeTrackedBy");
			EntitySchemaColumn modifiedOnColumn = schema.FindSchemaColumnByPath("ChangeTrackedOn");
			EntitySchemaColumn changeTypeColumn = schema.FindSchemaColumnByPath("ChangeType");
			if (modifiedByColumn != null && currentStructure.Columns.FindByMetaPath(modifiedByColumn.UId.ToString()) == null) {
				var modifiedBy = currentStructure.AddColumnByMetaPath(modifiedByColumn.UId.ToString());
				modifiedBy.IsAlwaysSelect = true;
			}
			if (modifiedOnColumn != null && currentStructure.Columns.FindByMetaPath(modifiedOnColumn.UId.ToString()) == null) {
				var modifiedOn = currentStructure.AddColumnByMetaPath(modifiedOnColumn.UId.ToString());
				modifiedOn.IsAlwaysSelect = true;
			}
			if (changeTypeColumn != null && currentStructure.Columns.FindByMetaPath(changeTypeColumn.UId.ToString()) == null) {
				var changeType = currentStructure.AddColumnByMetaPath(changeTypeColumn.UId.ToString());
				changeType.IsAlwaysSelect = true;
			}
		}

		public virtual DataSourceRowConfig GetRowConfig(Entity row) {
			string primaryColumnName = row.Schema.PrimaryColumn.Name;
			string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
			var config = new DataSourceRowConfig(primaryColumnValue);
			Guid changeType = row.GetTypedColumnValue<Guid>("ChangeTypeId");
			string backgroundColor;
			if (changeType == new Guid("A852C33F-0BDD-E011-92C3-00155D04C01D")) {
				backgroundColor = "Green";
			} else if (changeType == new Guid("AA52C33F-0BDD-E011-92C3-00155D04C01D")) {	
				backgroundColor = "Red";
			} else {
				backgroundColor = "Blue";
			}
			config.AddConfig(new DataSourceRowColorConfigValue(backgroundColor));
			return config;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override void CreateContextMenu() {
			return;
		}

		public override void ModifyModuleProcessParameters(Process process) {
			var processSchema = process.Schema as ProcessSchema;
			if (processSchema.Parameters.ExistsByName("CurrentSchemaUId")) {
				Guid currentSchemaUId = ObjectSchemaId;
				if (currentSchemaUId.IsEmpty() && Page.DataSource.Schema != null) {
					currentSchemaUId = Page.DataSource.Schema.UId;
				}
				process.SetPropertyValue("CurrentSchemaUId", currentSchemaUId);
			}
			if (processSchema.Parameters.ExistsByName("GridProcessUId")) {
				process.SetPropertyValue("GridProcessUId", InstanceUId);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DataSourceBeforeLoad":
							if (ActivatedEventElements.Contains("DataSourceBeforeLoadStartMessage1")) {
							context.QueueTasks.Enqueue("DataSourceBeforeLoadStartMessage1");
						}
						break;
					case "DataSourceStructureLoaded":
							if (ActivatedEventElements.Contains("StartMessageDataSourceStructureLoaded")) {
							context.QueueTasks.Enqueue("StartMessageDataSourceStructureLoaded");
						}
						break;
					case "ObjectChanged":
							if (ActivatedEventElements.Contains("ObjectChangedStartMessage")) {
							context.QueueTasks.Enqueue("ObjectChangedStartMessage");
						}
						break;
					case "FilterChanged":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "Init":
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
			if (PreviousRow != null) {
				if (PreviousRow.GetType().IsSerializable ||
					PreviousRow.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PreviousRow", PreviousRow, null);
				}
			}
			if (!HasMapping("ObjectSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ObjectSchemaId", ObjectSchemaId, Guid.Empty);
			}
			if (!HasMapping("UpdateSchema") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UpdateSchema", UpdateSchema, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogGridPageEventsProcess

	/// <exclude/>
	public class ChangeLogGridPageEventsProcess : ChangeLogGridPageEventsProcess<Terrasoft.WebApp.ChangeLogGridPageSchemaUserControl>
	{

		public ChangeLogGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeLogGridPageSchemaUserControl

	/// <exclude/>
	public partial class ChangeLogGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DataSource.BeforeLoad += DataSourceBeforeLoad;
			DataSource.AjaxEvents.StructureLoaded.Event += DataSourceStructureLoaded;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DataSource.BeforeLoad -= DataSourceBeforeLoad;
			DataSource.AjaxEvents.StructureLoaded.Event -= DataSourceStructureLoaded;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ChangeLogGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ChangeLogGridPageEventsProcess(UserConnection);
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

		public virtual void DataSourceStructureLoaded(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceStructureLoaded");
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
			SchemaName = "ChangeLogGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogGridPageEventsProcessSchema

	/// <exclude/>
	public class ChangeLogGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public ChangeLogGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ChangeLogGridPageEventsProcessSchema(ChangeLogGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChangeLogGridPageEventsProcess";
			UId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015");
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

		protected virtual ProcessSchemaParameter CreateUpdateSchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("64920387-6855-4e32-ae22-752740604bd4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"UpdateSchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateObjectSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("12836c01-f8c9-4176-bfe1-c62dd5552f4f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"ObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePreviousRowParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("24ee7b9a-63ec-43ab-bc87-dbac35dea36e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"PreviousRow",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateUpdateSchemaParameter());
			Parameters.Add(CreateObjectSchemaIdParameter());
			Parameters.Add(CreatePreviousRowParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet619 = CreateLaneSet619LaneSet();
			LaneSets.Add(schemaLaneSet619);
			ProcessSchemaLane schemaDataSourceLane = CreateDataSourceLaneLane();
			schemaLaneSet619.Lanes.Add(schemaDataSourceLane);
			ProcessSchemaEventSubProcess datasourceeventsubprocess = CreateDataSourceEventSubProcessEventSubProcess();
			FlowElements.Add(datasourceeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaStartMessageEvent datasourcebeforeloadstartmessage1 = CreateDataSourceBeforeLoadStartMessage1StartMessageEvent();
			datasourceeventsubprocess.FlowElements.Add(datasourcebeforeloadstartmessage1);
			ProcessSchemaScriptTask initializedatasourcecurrentstructurescripttask = CreateInitializeDataSourceCurrentStructureScriptTaskScriptTask();
			datasourceeventsubprocess.FlowElements.Add(initializedatasourcecurrentstructurescripttask);
			ProcessSchemaIntermediateThrowMessageEvent datasourcestructureloaded1 = CreateDataSourceStructureLoaded1IntermediateThrowMessageEvent();
			datasourceeventsubprocess.FlowElements.Add(datasourcestructureloaded1);
			ProcessSchemaStartMessageEvent startmessagedatasourcestructureloaded = CreateStartMessageDataSourceStructureLoadedStartMessageEvent();
			datasourceeventsubprocess.FlowElements.Add(startmessagedatasourcestructureloaded);
			ProcessSchemaStartMessageEvent objectchangedstartmessage = CreateObjectChangedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(objectchangedstartmessage);
			ProcessSchemaScriptTask objectchangedscripttask = CreateObjectChangedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(objectchangedscripttask);
			ProcessSchemaScriptTask filterchangedscripttask = CreateFilterChangedScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(filterchangedscripttask);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage2);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(initscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent1);
			FlowElements.Add(CreateSequenceFlow13999SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14000SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14001SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14002SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13999SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13999",
				UId = new Guid("e3ae7593-e865-4b8d-ac88-6a09bb2cb71a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CurveCenterPosition = new Point(256, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8836a87e-30ee-414e-aead-fee78caa96a3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e7bc8c4a-e252-479a-98bb-650caf4c0650"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14000SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14000",
				UId = new Guid("a552f1b9-c3c6-428d-b8b4-e5ec5bc4d244"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CurveCenterPosition = new Point(258, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f28f729a-5208-4524-8700-ecc2fbdbd8e3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1aed32af-1d50-4e30-868a-2df619538df7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14001SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14001",
				UId = new Guid("6fb1a7a6-1fd2-4892-b840-ff8f3adc4b5b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CurveCenterPosition = new Point(214, 445),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ca23f61-ee14-40d2-b08e-b36ca8fa4a24"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c5a5b3d-dc85-490f-a41e-660abdeb5fe7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14002SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14002",
				UId = new Guid("f9affa57-1e9f-434e-a23e-4a18dd3d3d12"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CurveCenterPosition = new Point(410, 449),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c5a5b3d-dc85-490f-a41e-660abdeb5fe7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da73edde-2eea-4a35-8eb9-53e86b2e02f5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d98604a0-7f73-4ca9-a9b3-c80eca779e32"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7adc1a55-f2d9-43ad-afbe-296d883f56cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f81277d0-2eba-4b2e-98d4-43ab80a3a7b9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("17751496-ec74-41e4-804d-f973517962c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CurveCenterPosition = new Point(159, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e715849b-a8c0-4729-a519-061a7a9b5625"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7adc1a55-f2d9-43ad-afbe-296d883f56cc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f7fa4926-4f38-4cc6-93b1-a76d82e9a1b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CurveCenterPosition = new Point(372, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21df277e-f290-414b-a478-314b69f4bf37"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f81277d0-2eba-4b2e-98d4-43ab80a3a7b9"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet619LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet619 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("908f054b-1e73-418d-8687-0f5af1442e75"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"LaneSet619",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1164, 159),
				UseBackgroundMode = false
			};
			return schemaLaneSet619;
		}

		protected virtual ProcessSchemaLane CreateDataSourceLaneLane() {
			ProcessSchemaLane schemaDataSourceLane = new ProcessSchemaLane(this) {
				UId = new Guid("00d73062-e77c-4dfc-961e-f07c44ba9597"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("908f054b-1e73-418d-8687-0f5af1442e75"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"DataSourceLane",
				Position = new Point(29, 0),
				Size = new Size(1135, 159),
				UseBackgroundMode = false
			};
			return schemaDataSourceLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDataSourceEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDataSourceEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2ea36d5b-4225-4020-84bb-44e6ca4cd9f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00d73062-e77c-4dfc-961e-f07c44ba9597"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"DataSourceEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(430, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDataSourceEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeLoadStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("21df277e-f290-414b-a478-314b69f4bf37"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ea36d5b-4225-4020-84bb-44e6ca4cd9f1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeLoad",
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"DataSourceBeforeLoadStartMessage1",
				Position = new Point(344, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitializeDataSourceCurrentStructureScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f81277d0-2eba-4b2e-98d4-43ab80a3a7b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ea36d5b-4225-4020-84bb-44e6ca4cd9f1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"InitializeDataSourceCurrentStructureScriptTask",
				Position = new Point(204, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,201,76,204,201,172,74,117,73,44,73,12,206,47,45,74,78,117,46,45,42,74,205,43,9,46,41,42,77,46,41,45,74,213,208,180,230,229,42,74,5,50,243,20,128,98,169,214,0,148,109,33,63,53,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDataSourceStructureLoaded1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7adc1a55-f2d9-43ad-afbe-296d883f56cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ea36d5b-4225-4020-84bb-44e6ca4cd9f1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceStructureLoaded",
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"DataSourceStructureLoaded1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDataSourceStructureLoadedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e715849b-a8c0-4729-a519-061a7a9b5625"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ea36d5b-4225-4020-84bb-44e6ca4cd9f1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceStructureLoaded",
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"StartMessageDataSourceStructureLoaded",
				Position = new Point(29, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e89798ca-8092-4ed3-b177-11cf33a96bdc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00d73062-e77c-4dfc-961e-f07c44ba9597"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 171),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(511, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectChangedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8836a87e-30ee-414e-aead-fee78caa96a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e89798ca-8092-4ed3-b177-11cf33a96bdc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ObjectChanged",
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"ObjectChangedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectChangedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e7bc8c4a-e252-479a-98bb-650caf4c0650"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e89798ca-8092-4ed3-b177-11cf33a96bdc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"ObjectChangedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,219,110,194,48,12,125,6,137,127,136,120,162,218,148,31,64,60,176,130,170,106,76,32,46,218,227,100,90,3,97,37,97,78,202,101,211,254,125,78,139,218,142,73,123,74,98,159,115,108,31,231,4,36,142,176,69,49,16,51,62,228,208,30,253,41,192,138,85,44,95,113,29,26,237,200,100,86,250,112,191,211,62,49,33,5,7,11,147,83,82,209,70,85,164,223,234,180,139,208,146,16,35,82,169,12,51,4,234,5,204,173,121,50,204,137,80,187,133,163,60,113,57,113,192,100,249,65,219,6,90,109,68,111,186,222,99,226,22,201,14,15,16,167,98,48,16,81,206,146,227,195,209,93,3,241,213,105,183,26,154,19,3,233,220,156,109,193,110,17,178,174,22,92,192,183,253,221,105,143,181,83,238,90,106,137,204,108,111,183,129,88,89,36,30,83,115,37,101,180,108,226,94,64,243,44,36,35,116,177,182,14,116,130,79,215,85,156,222,53,22,120,192,146,32,121,15,119,160,183,104,99,61,122,42,147,69,51,190,233,186,228,202,79,82,63,37,191,127,155,83,117,86,97,56,31,107,229,20,100,234,19,107,179,239,93,172,124,243,43,149,60,215,140,204,70,101,88,90,229,87,7,180,181,44,172,241,44,110,185,103,188,142,79,44,50,228,76,233,156,199,72,14,51,238,206,255,7,209,125,155,76,163,174,71,21,37,234,166,110,106,61,79,126,44,92,47,180,26,83,197,246,134,153,35,164,232,45,216,64,102,241,30,245,71,49,40,215,231,199,26,95,28,203,12,247,112,153,227,71,142,214,253,255,7,152,213,252,5,63,85,125,40,63,236,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8f700e68-18ff-418f-baba-5fc485005a4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00d73062-e77c-4dfc-961e-f07c44ba9597"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 339),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(511, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaScriptTask CreateFilterChangedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1aed32af-1d50-4e30-868a-2df619538df7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f700e68-18ff-418f-baba-5fc485005a4b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"FilterChangedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,41,74,77,117,47,202,76,209,115,206,73,77,44,210,208,180,230,114,47,205,76,81,40,78,206,72,205,77,12,245,76,81,176,85,8,0,169,115,73,44,73,12,206,47,45,74,78,213,11,134,201,89,115,97,151,2,234,201,43,205,201,193,37,237,157,153,7,50,214,53,175,36,179,164,18,33,4,116,74,98,114,182,115,70,98,94,122,106,177,103,158,139,19,46,253,16,87,21,227,118,133,79,126,98,74,80,126,121,49,200,55,69,169,37,165,69,121,10,37,69,165,169,214,0,59,44,87,118,241,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f28f729a-5208-4524-8700-ecc2fbdbd8e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f700e68-18ff-418f-baba-5fc485005a4b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FilterChanged",
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("04981fcb-edfb-4488-9550-10772a0cccef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00d73062-e77c-4dfc-961e-f07c44ba9597"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 542),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(511, 178),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1ca23f61-ee14-40d2-b08e-b36ca8fa4a24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04981fcb-edfb-4488-9550-10772a0cccef"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0c5a5b3d-dc85-490f-a41e-660abdeb5fe7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04981fcb-edfb-4488-9550-10772a0cccef"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,219,110,218,64,16,125,54,18,255,48,241,67,100,148,226,16,10,109,16,226,1,98,136,80,20,5,21,72,159,23,123,108,182,221,238,210,221,53,132,54,249,247,204,218,220,42,161,84,178,100,107,230,204,57,115,57,94,51,13,40,51,46,113,182,93,33,244,96,194,50,12,231,6,245,157,146,18,99,203,149,12,163,193,176,128,28,62,28,182,91,173,44,148,18,32,17,147,111,152,106,52,203,199,231,205,116,107,166,241,18,127,177,225,139,69,153,112,153,17,103,112,170,208,131,83,150,240,73,179,88,32,188,190,194,7,160,137,50,54,211,56,253,45,106,36,203,83,8,254,167,90,131,191,213,138,151,27,215,64,64,92,47,24,231,86,105,72,22,135,207,243,179,14,165,201,53,70,131,99,40,168,149,100,222,177,54,220,75,51,139,154,51,193,255,96,242,204,113,19,248,103,155,241,93,215,222,91,181,66,207,245,117,161,26,49,203,166,42,215,49,13,167,113,197,52,142,184,32,50,3,87,61,72,80,96,70,212,129,90,252,160,30,192,16,13,234,79,112,44,26,174,81,218,190,206,12,32,53,231,57,90,239,62,231,9,152,66,121,62,78,246,227,157,8,77,247,185,110,129,119,107,60,194,47,122,116,201,13,56,146,192,255,210,140,6,95,251,157,102,189,241,185,49,170,183,70,81,187,126,219,106,52,235,157,155,155,118,187,117,75,193,78,228,151,107,33,34,239,188,16,117,32,115,33,72,236,124,254,129,75,215,229,80,90,110,183,199,80,56,35,71,252,188,91,50,153,161,25,203,104,208,253,72,164,156,212,252,59,89,177,230,183,157,83,230,171,132,86,89,162,203,67,158,70,168,56,101,194,56,55,123,107,250,23,86,164,178,95,93,223,172,220,27,152,129,25,106,205,140,74,109,56,31,135,223,113,65,238,176,90,9,19,58,128,171,117,74,23,174,56,28,27,231,214,1,205,0,151,151,5,159,179,216,68,171,148,139,221,177,188,66,138,185,243,149,91,223,101,31,112,123,56,108,80,120,198,115,160,144,226,4,124,42,204,80,182,77,83,95,129,239,196,119,165,126,129,46,27,144,220,150,158,220,229,2,71,114,98,65,141,54,215,18,172,206,177,251,14,231,14,80,81,0,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("da73edde-2eea-4a35-8eb9-53e86b2e02f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04981fcb-edfb-4488-9550-10772a0cccef"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 79),
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
			Methods.Add(CreateInitializeDataSourceCurrentStructureMethod());
			Methods.Add(CreateGetRowConfigMethod());
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

		protected override SchemaMethod CreateCreateContextMenuMethod() {
			SchemaMethod method = base.CreateCreateContextMenuMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyModuleProcessParametersMethod() {
			SchemaMethod method = base.CreateModifyModuleProcessParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,203,10,194,64,12,69,215,21,252,135,232,66,90,40,243,3,226,198,7,210,141,22,68,247,113,26,181,210,23,153,25,177,136,255,238,72,91,209,90,23,46,178,152,59,55,57,201,189,32,67,193,185,36,165,54,242,68,41,194,164,121,139,90,64,5,225,187,99,220,239,197,7,112,63,186,68,136,140,41,105,98,37,22,215,88,105,53,45,87,86,112,135,51,195,76,153,174,108,219,32,26,122,30,220,250,61,103,105,226,8,100,235,211,194,215,251,51,201,90,9,34,203,114,158,176,182,81,4,106,145,22,186,116,61,24,141,32,196,35,137,57,106,220,228,134,37,53,139,15,38,144,153,36,169,120,78,7,171,187,79,108,43,238,221,214,43,10,210,54,131,130,88,151,59,76,76,215,93,254,215,53,158,157,114,255,43,172,37,199,81,157,245,91,84,191,151,104,249,125,8,50,165,49,147,212,208,31,194,176,216,169,223,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeDataSourceCurrentStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0354d5c2-c010-45b1-a0b5-693e0374a723"),
				Name = "InitializeDataSourceCurrentStructure",
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,219,142,218,48,20,124,6,137,127,112,243,176,34,210,202,31,208,10,85,11,75,171,149,218,13,18,108,223,93,231,0,86,29,39,178,157,165,105,213,127,175,157,100,113,46,228,2,237,171,61,103,198,115,102,146,87,34,81,72,52,217,198,169,164,128,22,104,67,14,128,31,207,39,31,102,211,87,3,81,244,8,17,49,215,14,139,183,249,153,1,176,61,154,23,0,188,145,44,34,50,91,197,60,141,4,90,44,144,72,57,247,209,239,217,116,162,143,50,62,33,1,39,244,108,206,2,185,142,18,157,173,127,82,72,52,139,197,220,94,124,137,41,225,236,23,249,206,97,171,37,19,135,185,183,3,41,137,138,247,26,175,98,9,222,189,33,154,120,107,161,153,206,10,125,124,166,192,47,66,37,64,217,158,65,88,127,136,231,223,151,14,240,51,137,192,55,111,254,51,155,58,147,70,44,165,58,149,128,104,42,37,8,237,14,106,142,87,141,91,195,243,57,101,97,201,93,147,124,121,10,205,236,229,181,188,123,91,203,71,116,233,30,219,217,247,200,50,227,124,73,181,21,183,84,12,155,131,162,187,59,187,161,166,13,92,192,21,254,196,68,184,204,190,130,38,27,162,143,29,148,120,23,151,235,247,253,122,134,174,10,141,160,91,139,195,15,97,88,92,94,37,103,172,78,46,160,240,147,250,198,20,51,189,48,82,123,194,21,116,3,31,248,137,100,106,11,28,168,54,104,243,32,40,242,110,71,245,200,84,194,73,95,98,53,68,119,112,53,216,168,252,90,210,255,45,198,38,243,21,105,214,221,222,18,106,159,120,43,178,250,214,170,17,151,161,245,195,59,131,174,254,30,74,47,81,28,230,255,133,165,51,87,38,104,87,89,133,46,179,220,149,183,58,18,113,128,157,36,244,135,29,243,236,243,123,136,3,113,19,113,32,186,136,105,1,203,18,184,146,216,76,228,156,182,114,45,219,101,131,77,191,218,225,118,148,171,201,129,7,59,229,38,198,118,104,72,195,118,193,97,250,178,175,186,62,103,242,15,174,223,56,198,187,14,70,127,57,67,26,85,215,65,111,227,173,235,86,97,110,112,221,228,24,118,237,38,198,186,30,210,176,174,29,166,219,245,95,47,102,37,151,186,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRowConfigMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8165204f-27de-4e9a-9610-4ccac5ad8e3d"),
				Name = "GetRowConfig",
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceRowConfig"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d74115fb-67d0-4bc3-89e9-b49f1a8c706a"),
				Name = "row",
				CreatedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				ModifiedInSchemaUId = new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,77,79,131,48,24,62,143,132,255,208,244,212,30,32,197,73,162,153,154,48,80,226,197,152,177,120,175,180,99,68,104,151,2,146,197,248,223,109,97,206,102,67,227,177,239,243,245,246,125,154,86,149,162,0,59,85,214,84,237,99,89,117,181,120,162,53,7,183,64,201,222,207,242,45,175,169,255,108,195,190,193,23,174,211,76,72,95,104,213,125,107,83,222,90,67,116,22,129,253,181,204,6,15,132,181,221,59,85,32,151,98,83,22,90,47,120,15,18,218,210,76,118,42,231,43,217,199,3,130,206,195,140,52,237,74,6,242,45,21,5,95,239,119,86,190,121,49,139,124,99,152,119,8,198,71,238,35,131,248,231,47,175,52,127,43,148,236,132,17,73,165,129,114,3,144,237,60,174,102,108,16,140,174,194,139,120,62,127,240,200,50,73,188,123,18,4,222,181,30,120,132,4,97,152,144,203,152,4,9,196,24,124,184,206,236,196,89,175,8,83,197,185,128,58,227,19,240,170,225,224,207,168,232,159,81,179,233,172,21,103,86,210,47,11,45,245,133,6,150,235,140,69,248,17,99,135,195,79,20,162,85,35,56,246,123,98,136,205,89,21,111,59,37,14,181,46,190,0,182,234,183,52,108,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeLogGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3fb9ae1e-ef6d-4c6d-a90f-b318c9434015"));
		}

		#endregion

	}

	#endregion

}

