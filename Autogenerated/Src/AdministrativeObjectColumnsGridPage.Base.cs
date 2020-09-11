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
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
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

	#region Class: AdministrativeObjectColumnsGridPageSchema

	/// <exclude/>
	public class AdministrativeObjectColumnsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public AdministrativeObjectColumnsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectColumnsGridPageSchema(AdministrativeObjectColumnsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.IsProcessEventHandler = true;
			TreeGrid.ToolbarVisible = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
			RealUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
			Name = "AdministrativeObjectColumnsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectColumnsGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectColumnsGridPageEventsProcessSchema() {
			var schema = new AdministrativeObjectColumnsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555");
			DataSource.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("24fa041b-c6ae-4f33-9c1f-9385b3fea5f3");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4e633c16-e807-4873-9c46-375d376d0a2a");
			if (column != null) {
				column.UId = new Guid("dea919d7-489c-4780-bad9-5842a5d75a66");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4d7ac7e2-9285-462a-b942-b8ae69d229ea");
			if (column != null) {
				column.UId = new Guid("0f3dd992-c8a2-4f5a-84fd-0f18dc0f2009");
				column.Name = @"RightLevel";
				column.CreatedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6bae586e-5d9c-4484-b8d0-5c9a59f3bfb9");
			if (column != null) {
				column.UId = new Guid("378ff288-f124-4580-8a29-72a713b7f653");
				column.Name = @"SubjectColumnUId";
				column.CreatedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c55f4107-514d-4fe3-8ed6-f56e272c31a7");
			if (column != null) {
				column.UId = new Guid("79064189-3faa-48ff-bd38-a64224f94a77");
				column.Name = @"SubjectSchemaUId";
				column.CreatedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.ModifiedInSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectColumnsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectColumnsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectColumnsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectColumnsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectColumnsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeObjectColumnsGridPageSchemaUserControl
	{

		public AdministrativeObjectColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectColumnsGridPageEventsProcess";
			SchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
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

		public virtual string ViewCode {
			get;
			set;
		}

		private ProcessFlowElement _subProcess9;
		public ProcessFlowElement SubProcess9 {
			get {
				return _subProcess9 ?? (_subProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9",
					SchemaElementUId = new Guid("b14fb18b-e28a-4f0a-9b3a-14a8a4be3db4"),
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
					SchemaElementUId = new Guid("51c370b5-8b41-4c98-a261-629ac7b437ee"),
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
					SchemaElementUId = new Guid("833f37f5-37f6-4bec-8c0f-9d3c13f64b1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridPageRefreshRowChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess10;
		public ProcessFlowElement SubProcess10 {
			get {
				return _subProcess10 ?? (_subProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess10",
					SchemaElementUId = new Guid("efcda772-05af-4f3b-bcb1-923f6efbd6e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridSelectionChangeChild;
		public ProcessFlowElement TreeGridSelectionChangeChild {
			get {
				return _treeGridSelectionChangeChild ?? (_treeGridSelectionChangeChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridSelectionChangeChild",
					SchemaElementUId = new Guid("cd6a9b3e-33c4-4509-8cb8-37d7c7de8010"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTreeGridSelectionChangeChild;
		public ProcessScriptTask ScriptTreeGridSelectionChangeChild {
			get {
				return _scriptTreeGridSelectionChangeChild ?? (_scriptTreeGridSelectionChangeChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTreeGridSelectionChangeChild",
					SchemaElementUId = new Guid("0c3e36b1-270a-42c3-a8b6-7792e8bac6f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTreeGridSelectionChangeChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess11;
		public ProcessFlowElement SubProcess11 {
			get {
				return _subProcess11 ?? (_subProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess11",
					SchemaElementUId = new Guid("444fb595-27a5-4a1e-9e87-ef504a092f1e"),
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
					SchemaElementUId = new Guid("32a0216a-03c0-4079-b585-2d8af1ebd7d8"),
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
					SchemaElementUId = new Guid("ead78585-6ca2-4d70-bd5e-e5cb84baaf62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadChildExecute,
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
					SchemaElementUId = new Guid("fa563a3e-ca82-4063-9bc8-7c2b0397995f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startChildInit;
		public ProcessFlowElement StartChildInit {
			get {
				return _startChildInit ?? (_startChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartChildInit",
					SchemaElementUId = new Guid("147f314d-0fa8-4222-974f-daaee7009757"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowInit;
		public ProcessThrowMessageEvent IntermediateThrowInit {
			get {
				return _intermediateThrowInit ?? (_intermediateThrowInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowInit",
					SchemaElementUId = new Guid("03fe8906-ce46-4b7a-a6dd-ac7d4745e6c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("2029fa6a-f16e-4d57-847e-fdc37c4624d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private LocalizableString _lCaption;
		public LocalizableString lCaption {
			get {
				return _lCaption ?? (_lCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.lCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[GridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { GridPageRefreshRowChild };
			FlowElements[ScriptGridPageRefreshRowChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridPageRefreshRowChild };
			FlowElements[SubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess10 };
			FlowElements[TreeGridSelectionChangeChild.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridSelectionChangeChild };
			FlowElements[ScriptTreeGridSelectionChangeChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTreeGridSelectionChangeChild };
			FlowElements[SubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess11 };
			FlowElements[PageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadChild };
			FlowElements[ScriptPageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadChild };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartChildInit };
			FlowElements[IntermediateThrowInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowInit };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess9":
						break;
					case "GridPageRefreshRowChild":
						e.Context.QueueTasks.Enqueue("ScriptGridPageRefreshRowChild");
						break;
					case "ScriptGridPageRefreshRowChild":
						break;
					case "SubProcess10":
						break;
					case "TreeGridSelectionChangeChild":
						e.Context.QueueTasks.Enqueue("ScriptTreeGridSelectionChangeChild");
						break;
					case "ScriptTreeGridSelectionChangeChild":
						break;
					case "SubProcess11":
						break;
					case "PageLoadChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadChild");
						break;
					case "ScriptPageLoadChild":
						break;
					case "EventSubProcess8":
						break;
					case "StartChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowInit");
						break;
					case "IntermediateThrowInit":
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
			ActivatedEventElements.Add("GridPageRefreshRowChild");
			ActivatedEventElements.Add("TreeGridSelectionChangeChild");
			ActivatedEventElements.Add("PageLoadChild");
			ActivatedEventElements.Add("StartChildInit");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess9":
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
				case "SubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "TreeGridSelectionChangeChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridSelectionChangeChild";
					result = TreeGridSelectionChangeChild.Execute(context);
					break;
				case "ScriptTreeGridSelectionChangeChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTreeGridSelectionChangeChild";
					result = ScriptTreeGridSelectionChangeChild.Execute(context, ScriptTreeGridSelectionChangeChildExecute);
					break;
				case "SubProcess11":
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
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartChildInit";
					result = StartChildInit.Execute(context);
					break;
				case "IntermediateThrowInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowInit.Execute(context);
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
				case "ViewCode":
					ViewCode = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptGridPageRefreshRowChildExecute(ProcessExecutingContext context) {
			Page.TreeGrid.Clear();
			GetVirtualDataSourceData(GetVirtualDataSource(), null);
			return true;
		}

		public virtual bool ScriptTreeGridSelectionChangeChildExecute(ProcessExecutingContext context) {
			if(IsDetailGrid) {
				return true;
			}
			if (ListenerPageProcessUId == String.Empty) {
				return true;
			}
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			Guid subjectColumnUId = Guid.Empty;
			if (selectedNodes.Count > 0) {
				subjectColumnUId = new Guid(selectedNodes[0].Values["SubjectColumnUId"].ToString());
			}
			var listenerPageProcess = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId); 
			listenerPageProcess.SetPropertyValue("SubjectColumnUId", subjectColumnUId);
			ListenerThrowEvent(ListenerPageProcessUId, "GridActiveRowChanged");
			return true;
		}

		public virtual bool ScriptPageLoadChildExecute(ProcessExecutingContext context) {
			/*Page.DataSource.Loaded +=
			 delegate(object sender, DataSourceEventArgs e) {
				Page.ThrowEvent("DataSourceLoadRows");
			};
			Page.DataSource.Loading += delegate(object sender, DataSourceEventArgs e) {
				DataSourceLoadingEventArgs = e;
				Page.ThrowEvent("DataSourceLoading");
			};
			LoadPrintReportButtonMenuProcess.SetPropertyValue("SysModuleId",GetSysModuleId());
			LoadPrintReportButtonMenuProcess.SetPropertyValue("Menu", Page.PrintButton.Menu);*/
			var virtualDataSource = new VirtualDataSource() {
				ID = "VirtualDataSource"
			};
			Page.PageContainer.Controls.Add(virtualDataSource);
			//if (Page.TreeGrid.DataSourceId == Page.DataSource.ID || string.IsNullOrEmpty(Page.TreeGrid.DataSourceId)) {
				DataSourceStructure defStructure = virtualDataSource.DefStructure;
				if (defStructure.Columns.Count == 0) {
					var dataSource = Page.DataSource;
					//var schema = dataSource.Schema;
					defStructure.Columns.Clear();
					//defStructure.PrimaryColumnName = schema.PrimaryColumn.Name;
					//if (schema.PrimaryDisplayColumn != null) {
					//	defStructure.PrimaryDisplayColumnName = schema.PrimaryDisplayColumn.Name;
					//}
					var dataValueTypeManager = (DataValueTypeManager)
					Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
					CreateVirtualDataSourceStructure(dataValueTypeManager, defStructure);
				}
			//}
			Page.TreeGrid.DataSourceId = GetVirtualDataSource().ID;
			GetVirtualDataSource().Loaded += Page.TreeGrid.DataLoaded;
			virtualDataSource.LoadingRow += DataSource_LoadingRows;
			virtualDataSource.DataRequest += DataSource_DataRequest;
			Page.TreeGrid.GetRowConfigHandler =
				delegate(Terrasoft.Core.Entities.Entity row) {			
					string primaryColumnName = row.Schema.PrimaryColumn.Name;		
					string primaryColumnValue =	row.GetColumnValue(primaryColumnName).ToString();
					var config = new DataSourceRowConfig(primaryColumnValue);		
					return config;
				};
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var virtualDataSource = new VirtualDataSource() {
				ID = "VirtualDataSource"
			};
			Page.PageContainer.Controls.Add(virtualDataSource);
			DataSourceStructure defStructure = virtualDataSource.DefStructure;
			if (defStructure.Columns.Count == 0) {
				defStructure.Columns.Clear();
				var dataValueTypeManager = (DataValueTypeManager)
					Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
				CreateVirtualDataSourceStructure(dataValueTypeManager, defStructure);
			}
			virtualDataSource.LoadingRow += DataSource_LoadingRows;
			virtualDataSource.DataRequest += DataSource_DataRequest;
			Page.TreeGrid.GetRowConfigHandler = delegate(Terrasoft.Core.Entities.Entity row) {			
				string primaryColumnName = row.Schema.PrimaryColumn.Name;		
				string primaryColumnValue =	row.GetColumnValue(primaryColumnName).ToString();
				var config = new DataSourceRowConfig(primaryColumnValue);		
				return config;
			};
			Page.TreeGrid.DataSourceId = GetVirtualDataSource().ID;
			GetVirtualDataSource().Loaded += Page.TreeGrid.DataLoaded;
			return true;
		}

		public virtual VirtualDataSource GetVirtualDataSource() {
			return Page.PageContainer.FindPageControl("VirtualDataSource") as VirtualDataSource;
		}

		public virtual void CreateVirtualDataSourceStructure(DataValueTypeManager dataValueTypeManager, DataSourceStructure defStructure) {
			var schema = Page.DataSource.Schema;
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
			defStructure.PrimaryColumnName = column.Name;
			column = new DataSourceStructureColumn {
				Name = "SubjectColumnUId",
				ValueColumnName = "SubjectColumnUId",
				DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
				Caption = "SubjectColumnUId",
				IsVisible = false,
				IsSortable = false
			};
			defStructure.AddColumn(column);
			column = new DataSourceStructureColumn {
				Name = "SubjectColumnCaption",
				ValueColumnName = "SubjectColumnCaption",
				DisplayColumnName = "SubjectColumnCaption",
				DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
				Caption = lCaption,
				IsVisible = true,
				IsSortable = false
			};
			defStructure.AddColumn(column);
			defStructure.PrimaryDisplayColumnName = column.Name;
		}

		public virtual void DataSource_LoadingRows(object sender, DataSourceEventArgs e) {
			GetVirtualDataSourceData(sender as VirtualDataSource, null);
		}

		public virtual void DataSource_DataRequest(object sender, DataSourceEventArgs e) {
			GetVirtualDataSourceData(sender as VirtualDataSource, e.Request);
		}

		public virtual void GetVirtualDataSourceData(VirtualDataSource virtualDataSource, DataSourceRequest request) {
			Guid filterColumnValue = GetFilterColumnValue();
			virtualDataSource.Clear();
			
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "VwWorkspaceObjects");
			var administratedByColumn = query.AddColumn("AdministratedByColumns");
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", filterColumnValue));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", Page.UserConnection.Workspace.Id));
			var schemaUId = Guid.Empty;
			if (filterColumnValue != Guid.Empty) {
				schemaUId = WorkspaceUtilities.GetSchemaUIdById(filterColumnValue, UserConnection);
			}
			var entities = query.GetEntityCollection(UserConnection);
			var isColumnAdministrated = entities.Count > 0 ? entities[0].GetTypedColumnValue<bool>(administratedByColumn.Name) : false;
			if (filterColumnValue != Guid.Empty && isColumnAdministrated) {
				var filedSchemaName = Page.DataSource.Schema.Name;
				
				var select = new Terrasoft.Core.DB.Select(Page.UserConnection).Distinct()
						.Column("outer", "SubjectColumnUId")
					.From(filedSchemaName).As("outer")
					.Where("outer", "SubjectSchemaUId").IsEqual(Terrasoft.Core.DB.Column.Parameter(schemaUId))
						as Terrasoft.Core.DB.Select;
				
				Entity row;
				if (ViewCode == "Administrated") {
					AddExtraSelectConditions(select, schemaUId);
				} else {
					virtualDataSource.Loaded += (sender, e) => {
						var schema = entitySchemaManager.GetInstanceByUId(schemaUId);
						schema.InitializeLocalizableValues();
						var schemaColumns = new EntitySchemaColumnCollection(schema.Columns);
						foreach (var dbRow in virtualDataSource.Rows) {
							var columnUId = dbRow.GetTypedColumnValue<Guid>("SubjectColumnUId");
							schemaColumns.RemoveByUId(columnUId);
						}
						foreach (var column in schemaColumns) {
							row = virtualDataSource.CreateRow();
							row.SetColumnValue("Id", Guid.NewGuid());
							row.SetColumnValue("SubjectColumnUId", column.UId);
							row.SetColumnValue("SubjectColumnCaption", column.Caption);
							virtualDataSource.Add(row);
						}
					};
				}
				var entitySchema = entitySchemaManager.GetInstanceByUId(schemaUId);
				entitySchema.InitializeLocalizableValues();
				var columns = entitySchema.Columns;
				int ordinal;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = select.ExecuteReader(dbExecutor)) {
						while (reader.Read()) {
							row = virtualDataSource.CreateRow();
							ordinal = reader.GetOrdinal("SubjectColumnUId");
							if (!reader.IsDBNull(ordinal)) {
								var column = columns.FindByUId(UserConnection.DBTypeConverter.DBValueToGuid(reader[ordinal]));
								if (column == null) {
									continue;
								}
								row.SetColumnValue("SubjectColumnUId", reader.GetValue(ordinal));
								row.SetColumnValue("SubjectColumnCaption", column.Caption);
							}
							row.SetColumnValue("Id", Guid.NewGuid());
							virtualDataSource.Add(row);
						}
					}
				}
			}
			
			if (request != null) {
				virtualDataSource.LoadRows(request);
			} else {
				virtualDataSource.LoadRows();
			}
			if (virtualDataSource.Rows.Count > 0) {
				Page.TreeGrid.SelectNode(virtualDataSource.Rows[0].GetTypedColumnValue<String>(virtualDataSource.Schema.PrimaryColumn.Name));
			} else {
				Page.TreeGrid.SelectedNodes.Clear();
				Page.ThrowEvent("TreeGridSelectionChange");
			}
		}

		public virtual void AddExtraSelectConditions(Select select, Guid subjectSchemaUId) {
			Guid rootAdminUnitId = Terrasoft.Configuration.AdminUtilities.GetRootAdminUnitId(UserConnection);
			Select existsSelect = new Select(UserConnection)
				.From("VwSysEntitySchemaColumnRight").As("inner")
				.Column(Column.Const(1))
				.Where("inner","SubjectSchemaUId").IsEqual(Column.Parameter(subjectSchemaUId))
				.And("inner","SubjectColumnUId").IsEqual("outer", "SubjectColumnUId")
				.And()
				.OpenBlock("inner","SysAdminUnitId")
					.IsNotEqual(Column.Parameter(rootAdminUnitId))
					.Or("inner","RightLevelId")
					.IsNotEqual(Column.Parameter(Terrasoft.Configuration.AdminUtilities.DefColumnRightLevelId))
				.CloseBlock() as Terrasoft.Core.DB.Select;	
			select = select.And().Exists(existsSelect) as Terrasoft.Core.DB.Select;
		}

		public virtual Guid GetFilterColumnValue() {
			Dictionary<string, object> conditions = null;  
			Guid filterColumnValue;
			 conditions = new Dictionary<string, object> {
				{ "UId",  SelectedNodePrimaryColumnValue},
				{ "SysWorkspace", Page.UserConnection.Workspace.Id }
			};
			 Terrasoft.Core.Configuration.VwSysSchemaInWorkspace sysSchemaView = new VwSysSchemaInWorkspace(Page.UserConnection);
			
			if (sysSchemaView.FetchFromDB(conditions)) {
				return filterColumnValue = sysSchemaView.UId;
			} else {
				return filterColumnValue = SelectedNodePrimaryColumnValue;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("GridPageRefreshRowChild")) {
							context.QueueTasks.Enqueue("GridPageRefreshRowChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "TreeGridSelectionChange":
							if (ActivatedEventElements.Contains("TreeGridSelectionChangeChild")) {
							context.QueueTasks.Enqueue("TreeGridSelectionChangeChild");
						}
						break;
					case "PageLoad1":
							if (ActivatedEventElements.Contains("PageLoadChild")) {
							context.QueueTasks.Enqueue("PageLoadChild");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartChildInit")) {
							context.QueueTasks.Enqueue("StartChildInit");
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
			if (!HasMapping("ViewCode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ViewCode", ViewCode, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectColumnsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectColumnsGridPageEventsProcess : AdministrativeObjectColumnsGridPageEventsProcess<Terrasoft.WebApp.AdministrativeObjectColumnsGridPageSchemaUserControl>
	{

		public AdministrativeObjectColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectColumnsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectColumnsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
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
			var process = (AdministrativeObjectColumnsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectColumnsGridPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrativeObjectColumnsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectColumnsGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectColumnsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectColumnsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectColumnsGridPageEventsProcessSchema(AdministrativeObjectColumnsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectColumnsGridPageEventsProcess";
			UId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972");
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

		protected virtual ProcessSchemaParameter CreateViewCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3cbf89f4-d264-459a-96d6-b4a115c5e9d0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"ViewCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateViewCodeParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet487 = CreateLaneSet487LaneSet();
			LaneSets.Add(schemaLaneSet487);
			ProcessSchemaLane schemaLane1594 = CreateLane1594Lane();
			schemaLaneSet487.Lanes.Add(schemaLane1594);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess subprocess10 = CreateSubProcess10EventSubProcess();
			FlowElements.Add(subprocess10);
			ProcessSchemaEventSubProcess subprocess11 = CreateSubProcess11EventSubProcess();
			FlowElements.Add(subprocess11);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaStartMessageEvent gridpagerefreshrowchild = CreateGridPageRefreshRowChildStartMessageEvent();
			subprocess9.FlowElements.Add(gridpagerefreshrowchild);
			ProcessSchemaScriptTask scriptgridpagerefreshrowchild = CreateScriptGridPageRefreshRowChildScriptTask();
			subprocess9.FlowElements.Add(scriptgridpagerefreshrowchild);
			ProcessSchemaStartMessageEvent treegridselectionchangechild = CreateTreeGridSelectionChangeChildStartMessageEvent();
			subprocess10.FlowElements.Add(treegridselectionchangechild);
			ProcessSchemaScriptTask scripttreegridselectionchangechild = CreateScriptTreeGridSelectionChangeChildScriptTask();
			subprocess10.FlowElements.Add(scripttreegridselectionchangechild);
			ProcessSchemaStartMessageEvent pageloadchild = CreatePageLoadChildStartMessageEvent();
			subprocess11.FlowElements.Add(pageloadchild);
			ProcessSchemaScriptTask scriptpageloadchild = CreateScriptPageLoadChildScriptTask();
			subprocess11.FlowElements.Add(scriptpageloadchild);
			ProcessSchemaStartMessageEvent startchildinit = CreateStartChildInitStartMessageEvent();
			eventsubprocess8.FlowElements.Add(startchildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowinit = CreateIntermediateThrowInitIntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowinit);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow9415SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9416SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9417SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9424SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9425SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatelCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreatelCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dda2e56d-9d5c-4667-877d-0171dc1406ea"),
				Name = "lCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9415SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9415",
				UId = new Guid("8fc12f3e-00ee-46a2-b618-d0a034b1305e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CurveCenterPosition = new Point(165, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51c370b5-8b41-4c98-a261-629ac7b437ee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("833f37f5-37f6-4bec-8c0f-9d3c13f64b1e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9416SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9416",
				UId = new Guid("bd2bee3a-8200-4ba2-b872-8856246f2c4d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CurveCenterPosition = new Point(404, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd6a9b3e-33c4-4509-8cb8-37d7c7de8010"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c3e36b1-270a-42c3-a8b6-7792e8bac6f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9417SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9417",
				UId = new Guid("c417b738-db59-473e-b6a3-3d995a9e1b71"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CurveCenterPosition = new Point(632, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("32a0216a-03c0-4079-b585-2d8af1ebd7d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ead78585-6ca2-4d70-bd5e-e5cb84baaf62"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9424SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9424",
				UId = new Guid("936b7c94-e75c-4dcb-a7fe-8f9c5ccdc4d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CurveCenterPosition = new Point(150, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("147f314d-0fa8-4222-974f-daaee7009757"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03fe8906-ce46-4b7a-a6dd-ac7d4745e6c7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9425SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9425",
				UId = new Guid("17f20221-4222-4747-9412-1ac552f06836"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CurveCenterPosition = new Point(253, 271),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03fe8906-ce46-4b7a-a6dd-ac7d4745e6c7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2029fa6a-f16e-4d57-847e-fdc37c4624d2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet487LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet487 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("12dfc4c1-be87-4ba2-b2c3-c5f7149c061b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"LaneSet487",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(726, 494),
				UseBackgroundMode = false
			};
			return schemaLaneSet487;
		}

		protected virtual ProcessSchemaLane CreateLane1594Lane() {
			ProcessSchemaLane schemaLane1594 = new ProcessSchemaLane(this) {
				UId = new Guid("00feaebf-8b18-495e-8255-d7ccfa3b8069"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("12dfc4c1-be87-4ba2-b2c3-c5f7149c061b"),
				CreatedInOwnerSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"Lane1594",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(697, 494),
				UseBackgroundMode = false
			};
			return schemaLane1594;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b14fb18b-e28a-4f0a-9b3a-14a8a4be3db4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00feaebf-8b18-495e-8255-d7ccfa3b8069"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(264, 116),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridPageRefreshRowChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("51c370b5-8b41-4c98-a261-629ac7b437ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b14fb18b-e28a-4f0a-9b3a-14a8a4be3db4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"GridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridPageRefreshRowChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("833f37f5-37f6-4bec-8c0f-9d3c13f64b1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b14fb18b-e28a-4f0a-9b3a-14a8a4be3db4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"ScriptGridPageRefreshRowChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,41,74,77,117,47,202,76,209,115,206,73,77,44,210,208,180,230,114,79,45,9,203,44,42,41,77,204,113,73,44,73,12,206,47,45,74,78,5,177,52,176,73,104,104,234,40,228,149,230,228,0,245,21,165,150,148,22,229,41,148,20,149,166,90,3,0,9,117,130,96,91,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("efcda772-05af-4f3b-bcb1-923f6efbd6e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00feaebf-8b18-495e-8255-d7ccfa3b8069"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"SubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 366),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 114),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridSelectionChangeChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cd6a9b3e-33c4-4509-8cb8-37d7c7de8010"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efcda772-05af-4f3b-bcb1-923f6efbd6e0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"TreeGridSelectionChangeChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTreeGridSelectionChangeChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0c3e36b1-270a-42c3-a8b6-7792e8bac6f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efcda772-05af-4f3b-bcb1-923f6efbd6e0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"ScriptTreeGridSelectionChangeChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,79,107,131,64,16,197,207,245,83,12,158,20,194,146,187,88,104,173,136,80,74,168,166,151,146,131,205,78,204,22,51,27,246,143,34,165,223,189,171,73,32,169,230,182,204,242,126,239,205,27,177,11,114,253,130,166,18,77,166,4,15,225,199,123,80,104,172,34,48,202,98,228,253,122,98,7,193,171,208,6,9,213,170,170,113,165,228,22,181,94,231,28,226,24,10,163,4,213,44,61,28,77,63,167,110,43,5,26,27,220,26,228,111,146,163,134,24,6,10,43,21,226,96,201,138,235,223,200,203,172,224,160,237,215,183,27,38,178,177,7,26,157,96,152,159,108,162,49,210,13,148,37,210,146,129,71,88,142,25,102,228,132,221,136,184,213,125,46,55,236,163,106,172,123,249,197,63,145,191,97,165,60,173,23,132,225,101,151,102,218,132,163,175,53,170,68,18,57,189,144,196,242,243,79,74,181,32,100,25,154,243,224,185,119,224,59,109,134,17,120,51,116,215,207,160,62,162,50,253,24,53,152,38,93,76,10,115,121,47,46,229,94,201,46,109,145,204,29,227,5,248,195,33,158,92,246,22,223,101,151,236,43,170,145,251,142,113,125,204,63,61,116,58,242,43,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("444fb595-27a5-4a1e-9e87-ef504a092f1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00feaebf-8b18-495e-8255-d7ccfa3b8069"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"SubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 252),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(203, 107),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("32a0216a-03c0-4079-b585-2d8af1ebd7d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("444fb595-27a5-4a1e-9e87-ef504a092f1e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad1",
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"PageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ead78585-6ca2-4d70-bd5e-e5cb84baaf62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("444fb595-27a5-4a1e-9e87-ef504a092f1e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"ScriptPageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,75,111,218,64,16,62,219,191,98,235,147,157,34,187,119,139,3,13,40,69,42,41,10,36,215,106,139,7,226,202,236,186,179,107,16,106,242,223,59,187,107,225,103,82,41,23,88,207,124,243,254,102,146,155,53,63,64,60,231,154,111,100,133,59,136,191,75,158,65,198,62,79,125,150,65,1,7,174,33,148,191,126,195,78,51,5,34,3,156,176,6,189,56,129,208,51,60,40,6,17,251,235,123,214,217,246,25,229,217,106,194,160,129,26,191,15,242,172,130,40,245,95,83,127,44,108,46,14,20,247,3,97,187,81,200,77,3,152,50,72,255,155,23,89,212,105,153,175,53,230,66,63,64,41,81,127,173,180,150,98,5,162,90,163,220,129,82,241,6,52,61,75,64,125,121,226,69,5,97,176,185,168,149,204,170,2,150,89,48,185,3,221,250,14,163,232,67,46,141,54,152,48,155,181,53,117,70,177,145,71,233,77,226,159,56,178,83,142,186,226,69,83,9,213,42,224,204,158,250,242,208,246,104,57,39,125,48,80,6,215,97,152,159,91,41,52,207,5,96,108,94,40,11,21,207,178,44,28,132,162,178,146,36,223,179,208,53,22,1,238,48,207,90,243,92,102,108,58,101,253,33,83,14,47,47,76,105,42,233,16,47,213,125,85,20,63,112,113,44,245,229,29,71,81,111,196,27,141,213,78,87,8,68,148,125,243,49,29,54,36,158,183,0,196,2,147,112,219,134,138,44,170,163,80,244,95,9,109,18,254,98,99,121,166,189,89,187,175,189,66,200,151,151,36,6,165,118,207,112,228,132,104,224,241,198,202,12,102,60,88,1,28,195,200,249,232,32,104,212,71,142,23,7,188,231,71,19,217,5,232,170,98,163,115,246,166,164,46,100,158,171,178,224,53,146,125,34,78,80,151,93,89,73,226,141,197,235,88,140,134,237,32,90,209,95,91,189,178,212,221,94,74,88,113,65,221,66,114,18,206,71,228,17,217,216,118,62,42,64,98,153,160,21,207,137,219,179,178,172,17,180,12,167,156,54,62,166,101,170,69,110,97,251,174,2,219,196,91,4,58,22,3,98,95,203,12,199,178,155,116,200,99,252,188,250,166,158,247,248,204,40,159,145,229,34,86,167,254,27,170,235,49,101,67,199,78,151,250,67,218,214,39,137,174,165,177,108,20,63,27,133,26,179,51,207,7,248,83,129,210,61,195,150,38,237,213,72,153,147,63,26,196,62,63,124,227,34,43,204,232,124,239,122,132,183,128,200,149,220,107,34,48,113,102,33,116,174,115,80,238,113,97,116,82,137,92,158,231,209,36,220,98,179,114,132,198,4,171,247,98,140,202,111,90,219,177,177,169,103,204,41,209,150,48,28,68,137,226,173,220,88,31,110,185,12,49,119,182,172,250,48,54,253,184,22,28,14,163,69,46,27,4,34,134,168,29,24,122,164,126,45,34,210,64,250,15,185,252,25,125,56,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fa563a3e-ca82-4063-9bc8-7c2b0397995f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00feaebf-8b18-495e-8255-d7ccfa3b8069"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 135),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 109),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("147f314d-0fa8-4222-974f-daaee7009757"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fa563a3e-ca82-4063-9bc8-7c2b0397995f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"StartChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("03fe8906-ce46-4b7a-a6dd-ac7d4745e6c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fa563a3e-ca82-4063-9bc8-7c2b0397995f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"IntermediateThrowInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2029fa6a-f16e-4d57-847e-fdc37c4624d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fa563a3e-ca82-4063-9bc8-7c2b0397995f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,193,110,194,48,12,61,23,137,127,136,56,165,218,20,237,94,245,128,232,196,144,182,9,1,227,58,69,141,203,34,149,132,185,41,8,77,252,251,156,182,163,29,45,151,54,177,253,236,231,103,231,40,145,29,53,186,82,230,137,116,114,109,75,76,129,197,204,192,137,109,111,237,60,100,63,227,81,176,72,40,96,210,243,78,198,163,75,52,30,45,229,14,132,255,204,172,113,82,27,64,225,79,104,243,66,76,149,226,189,106,33,129,218,219,218,97,153,186,18,129,41,200,218,75,220,103,41,146,78,0,229,208,25,227,93,12,149,205,203,189,41,232,95,26,199,226,152,61,213,252,135,131,114,144,200,61,151,224,72,154,40,42,179,149,121,9,155,243,1,222,164,161,126,144,72,240,100,192,30,18,38,168,218,254,40,0,169,89,3,169,211,214,136,233,225,208,132,44,209,30,181,34,41,230,224,26,19,159,12,229,154,84,12,102,8,210,65,79,225,43,107,62,68,239,241,159,98,62,207,101,60,234,171,246,106,165,210,102,183,178,39,246,16,179,214,241,217,58,138,104,8,232,143,43,248,46,161,112,55,200,142,231,111,1,54,8,48,71,173,124,195,148,145,68,201,244,238,69,26,149,87,58,42,200,97,71,45,242,13,32,202,194,102,142,6,65,211,120,54,78,59,13,69,125,56,51,180,39,154,89,16,4,36,74,225,144,232,177,3,234,189,196,115,61,183,119,185,247,187,65,97,98,157,126,193,94,138,101,215,45,188,63,186,139,174,20,100,113,224,225,196,179,99,228,189,42,161,216,216,117,149,163,93,146,180,234,170,121,45,173,30,215,126,121,191,90,88,179,65,160,25,153,38,65,212,121,56,87,221,218,116,11,69,21,136,222,192,115,20,139,132,128,119,124,126,158,160,252,168,250,153,107,31,97,27,34,180,53,16,253,2,184,229,16,145,12,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetVirtualDataSourceMethod());
			Methods.Add(CreateCreateVirtualDataSourceStructureMethod());
			Methods.Add(CreateDataSource_LoadingRowsMethod());
			Methods.Add(CreateDataSource_DataRequestMethod());
			Methods.Add(CreateGetVirtualDataSourceDataMethod());
			Methods.Add(CreateAddExtraSelectConditionsMethod());
			Methods.Add(CreateGetFilterColumnValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0a82ac7d-bb7e-467a-ae67-4f9b36b35ac0"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
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
				UId = new Guid("cfd141df-b313-43b2-8fd0-08127698ad49"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f9d9156-b91b-48de-b697-26de91bb79dd"),
				Name = "GetVirtualDataSource",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,3,17,206,249,121,37,137,153,121,169,69,122,110,153,121,41,48,145,162,252,28,13,165,176,204,162,146,210,196,28,151,196,146,196,224,252,210,162,228,84,37,77,133,196,98,5,12,97,107,0,217,88,186,124,84,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateVirtualDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3bc31f52-1bcf-48a4-911e-51c3aab9a9fa"),
				Name = "CreateVirtualDataSourceStructure",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3b8f272f-d385-46c9-b5af-c7b0f402ccf9"),
				Name = "dataValueTypeManager",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataValueTypeManager",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("57f3412e-267d-446f-91a3-840f4887bcdc"),
				Name = "defStructure",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceStructure",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,77,78,195,48,16,133,215,205,41,162,172,90,9,249,2,17,11,72,81,149,5,168,82,218,238,167,246,20,140,28,39,242,79,33,66,220,29,59,14,52,13,65,42,144,157,61,239,205,243,204,39,31,65,197,154,62,97,9,241,117,188,134,71,36,75,48,80,84,86,81,36,69,43,164,209,209,153,80,26,110,154,80,185,7,233,156,234,179,99,171,81,101,149,148,72,13,175,36,185,251,238,12,17,180,18,182,148,174,75,226,75,124,122,166,48,202,82,99,21,102,65,127,139,102,15,80,162,243,37,57,75,174,162,217,14,132,237,196,115,193,103,180,226,166,169,125,153,245,239,221,211,100,133,38,151,218,128,164,120,219,248,254,121,178,178,156,37,11,23,144,65,237,71,62,37,230,122,199,53,223,11,159,118,0,161,177,173,21,149,50,208,43,70,239,105,196,240,240,53,56,185,97,44,204,55,15,59,46,6,250,90,241,18,84,115,182,67,112,18,127,75,163,223,163,41,236,254,217,1,15,194,246,71,80,99,182,41,177,141,229,79,7,241,159,88,186,57,47,65,211,179,46,185,174,5,52,23,154,255,200,114,131,175,102,192,82,116,199,1,65,183,235,180,191,112,108,191,254,103,252,0,247,52,213,214,19,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSource_LoadingRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e9bc6d45-7c06-4aee-9e56-7d37e0e31658"),
				Name = "DataSource_LoadingRows",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2f934787-354a-4538-b312-9d67db718b39"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a9eb4d30-3a61-4a59-aaed-6254ffbc097c"),
				Name = "e",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,45,9,203,44,42,41,77,204,113,73,44,73,12,206,47,45,74,78,5,177,52,138,83,243,82,82,139,20,18,139,21,48,228,117,20,242,74,115,114,52,173,1,126,98,10,116,60,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSource_DataRequestMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6808c129-5398-4864-9abc-9af1d7f027a2"),
				Name = "DataSource_DataRequest",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d1ee1ebf-afa1-4dc6-bafc-d4f67476cea0"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7b67398c-fe0a-4fb7-959a-94a7f8aa8e0d"),
				Name = "e",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,45,9,203,44,42,41,77,204,113,73,44,73,12,206,47,45,74,78,5,177,52,138,83,243,82,82,139,20,18,139,21,48,228,117,20,82,245,130,82,11,75,83,139,75,52,173,1,79,216,199,103,65,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("00bc1d13-5323-437b-aafb-afbda271a612"),
				Name = "GetVirtualDataSourceData",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8d12226f-ecaa-4af4-9105-37bfba501447"),
				Name = "virtualDataSource",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2460b824-d40c-48bd-896c-4c637dbeb7d9"),
				Name = "request",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceRequest",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,75,111,27,55,16,62,111,128,252,7,70,135,128,139,10,68,206,117,173,194,122,196,16,144,58,174,229,199,33,200,129,94,82,22,219,21,169,144,187,86,148,66,255,189,67,14,247,33,237,250,209,0,61,9,30,206,124,51,252,230,155,89,250,188,84,130,44,85,94,72,59,49,121,185,214,183,60,47,37,57,37,231,178,248,120,108,166,233,201,219,55,143,202,22,37,207,167,188,224,11,83,218,76,178,73,46,185,13,103,112,202,45,145,186,80,197,110,145,173,228,154,255,193,53,127,144,22,0,111,156,199,210,90,102,133,50,154,205,186,78,39,24,254,173,148,118,7,1,90,110,73,219,235,79,111,167,61,224,67,50,184,221,222,25,251,183,219,240,76,126,190,255,11,82,184,65,26,225,184,88,43,173,92,97,121,33,197,120,135,215,1,248,144,134,157,9,129,22,58,56,235,115,68,28,244,69,62,156,143,161,104,153,88,9,206,104,191,83,197,234,146,91,190,150,222,137,86,228,173,55,220,42,103,244,245,110,35,217,236,27,48,7,229,206,197,96,216,101,61,253,63,82,45,118,174,166,6,146,94,2,97,236,168,21,245,57,155,139,180,162,205,5,134,111,230,194,107,1,68,194,102,235,77,177,131,67,181,36,180,43,152,119,109,175,148,252,243,246,77,210,70,168,83,220,20,42,87,133,146,142,129,192,22,149,199,120,55,23,93,208,225,145,102,124,105,251,150,196,0,165,238,35,160,161,86,32,62,71,119,218,141,246,161,202,97,138,131,118,3,78,5,201,38,166,212,5,25,145,15,228,247,218,248,229,195,87,159,194,51,43,90,21,254,118,111,76,62,162,189,18,99,23,208,159,148,252,74,150,60,119,242,117,196,145,247,239,251,235,67,70,125,249,128,32,5,18,231,19,64,225,161,165,173,113,196,195,144,30,178,38,49,206,73,79,75,28,171,107,105,45,119,102,89,192,101,45,4,143,217,34,28,211,30,121,164,108,10,85,40,13,167,41,96,37,9,171,6,198,148,112,151,129,215,88,25,102,14,237,208,206,65,112,100,31,173,89,211,163,122,83,118,230,170,72,244,186,91,73,43,187,96,181,54,6,41,155,187,160,102,218,45,59,82,93,15,3,173,69,151,98,177,220,61,121,217,72,14,202,134,88,179,245,6,223,164,91,37,183,19,35,128,219,83,114,184,21,6,216,135,4,198,114,246,29,76,8,4,92,9,229,169,114,20,89,30,54,211,227,85,151,236,137,4,9,96,104,119,125,126,50,92,128,2,127,57,37,16,174,133,223,103,160,155,211,17,250,39,205,48,86,34,61,220,126,94,151,115,237,10,174,51,57,222,65,74,122,152,60,137,131,200,230,26,138,228,185,250,33,63,153,204,255,242,251,92,6,17,58,26,61,155,92,113,251,245,172,97,60,105,141,89,132,143,17,17,105,9,84,243,108,69,168,135,20,247,87,102,75,148,38,221,203,195,129,139,164,98,250,172,18,17,164,14,113,189,115,231,71,102,68,123,132,135,217,147,131,75,176,43,185,54,143,145,156,26,63,186,238,187,229,162,139,175,247,0,166,46,19,164,2,197,245,124,7,195,138,134,146,43,58,189,39,136,173,104,127,66,113,247,135,145,191,144,91,255,75,211,231,220,59,87,28,198,250,88,115,135,151,3,39,124,227,123,213,4,71,67,5,208,189,140,255,242,0,108,155,165,125,208,114,220,39,109,37,254,156,48,219,33,47,139,179,105,140,59,74,87,41,47,140,47,108,110,99,133,210,60,247,127,150,78,233,135,74,131,179,239,50,43,11,211,251,22,113,165,149,211,113,99,130,158,96,183,91,8,208,93,17,94,50,56,228,12,241,228,85,48,211,6,191,10,77,182,43,216,125,132,98,28,243,126,53,236,127,17,81,188,15,120,71,36,224,245,51,218,158,153,0,191,200,222,197,128,185,155,142,47,202,60,167,17,170,169,162,69,43,224,71,126,225,245,161,5,118,236,136,168,233,216,79,34,24,30,165,133,109,11,127,135,22,93,155,160,99,204,246,37,38,249,90,203,58,212,82,37,129,133,2,149,52,5,36,153,129,94,234,82,86,206,251,248,251,202,97,104,56,65,159,250,138,39,175,197,121,105,54,246,63,53,203,175,155,40,28,168,189,127,57,123,146,172,132,215,140,43,252,163,160,97,169,255,139,225,23,103,229,31,30,70,205,55,230,153,128,248,132,242,185,250,119,113,243,250,193,228,225,65,112,109,165,60,183,112,75,252,222,93,192,183,241,137,240,167,222,73,139,194,194,28,141,122,162,226,12,95,90,181,230,246,224,233,116,116,171,190,74,164,240,181,184,214,127,32,209,109,5,68,207,30,97,75,208,65,21,130,17,208,215,201,138,235,7,25,6,101,255,47,97,224,89,188,255,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddExtraSelectConditionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0535f6b8-aef9-4e40-b435-a682dd13e815"),
				Name = "AddExtraSelectConditions",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("02e0d8c9-db1a-4576-9530-c37297884649"),
				Name = "select",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Select",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5433205b-6be9-4bb7-9896-b0535d7133f3"),
				Name = "subjectSchemaUId",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				ModifiedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,203,78,195,48,16,69,215,141,212,127,176,178,114,36,100,137,117,213,69,95,84,149,16,69,13,133,181,105,38,173,193,177,193,51,161,244,239,73,51,141,72,202,67,93,217,163,185,247,216,30,223,121,105,50,17,188,167,81,86,24,183,118,134,22,153,24,138,7,8,65,163,207,73,77,188,203,205,182,12,154,140,119,138,85,100,172,33,3,168,230,64,171,174,87,174,17,66,229,113,176,57,26,146,65,63,74,193,86,133,128,79,131,132,167,98,40,28,236,5,23,231,150,126,212,83,55,193,23,50,126,220,167,7,156,57,50,116,72,55,59,40,244,196,219,178,112,43,179,221,81,156,168,17,202,216,84,182,16,215,30,110,74,94,142,247,70,146,215,73,221,122,218,65,128,70,124,21,167,229,243,75,117,24,51,215,139,172,98,45,112,246,94,106,219,184,239,117,208,5,16,4,137,103,90,6,142,92,246,3,199,214,46,46,246,37,29,53,226,23,81,195,169,55,203,55,112,99,235,55,175,45,236,1,91,131,173,245,189,10,124,231,233,143,171,158,125,99,194,142,101,248,70,214,147,187,133,15,176,23,1,47,76,193,20,242,214,199,156,240,60,167,137,245,8,252,174,68,104,236,228,42,128,154,142,21,103,96,208,235,71,216,68,131,55,60,27,53,171,99,35,219,233,249,159,244,5,78,69,37,135,210,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFilterColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e581b9cb-429b-48a0-9744-91692862a424"),
				Name = "GetFilterColumnValue",
				CreatedInSchemaUId = new Guid("38c0778e-9641-42d5-b391-f78d498f9972"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,193,78,195,48,12,134,207,228,41,172,157,90,169,202,11,20,56,176,106,168,23,52,169,172,156,67,226,118,129,52,65,78,162,105,154,250,238,164,69,12,6,99,92,124,176,255,255,179,253,87,90,6,237,172,160,253,181,15,164,109,95,128,123,126,65,25,110,65,58,171,244,52,244,112,3,54,26,83,2,176,251,168,21,116,218,4,164,165,51,113,176,173,48,17,75,246,67,141,59,168,254,38,31,216,213,1,22,155,90,45,10,128,6,77,106,162,122,112,10,215,164,135,100,248,70,30,139,89,219,236,253,147,163,87,255,38,36,38,211,90,244,200,55,126,186,193,90,156,247,240,227,156,215,10,70,54,166,155,30,145,72,120,215,5,190,116,132,169,216,78,247,145,196,172,111,119,9,218,200,45,14,162,182,71,51,248,207,102,171,211,19,31,175,156,151,102,103,174,200,75,198,116,7,217,9,133,175,48,200,237,138,220,80,221,101,95,57,229,249,20,4,97,136,100,127,71,154,86,159,66,82,92,37,27,1,141,199,127,124,151,19,77,144,119,240,185,59,30,245,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectColumnsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38c0778e-9641-42d5-b391-f78d498f9972"));
		}

		#endregion

	}

	#endregion

}

