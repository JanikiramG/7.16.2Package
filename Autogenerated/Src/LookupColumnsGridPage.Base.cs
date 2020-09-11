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

	#region Class: LookupColumnsGridPageSchema

	/// <exclude/>
	public class LookupColumnsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public LookupColumnsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LookupColumnsGridPageSchema(LookupColumnsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @"9332ded81fb6fd89ce8c95fb6800043c"
			};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"9332ded81fb6fd89ce8c95fb6800043c"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
			RealUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
			Name = "LookupColumnsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLookupColumnsGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateLookupColumnsGridPageEventsProcessSchema() {
			var schema = new LookupColumnsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e");
			DataSource.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("46f1452a-e310-4789-8eee-6fddc18db94c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
				column.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b72ca89d-b132-4b40-a26e-9d6d34d0ddaf");
			if (column != null) {
				column.UId = new Guid("60f62afd-a8b2-4b56-953b-a19ad7890257");
				column.Name = @"MetaCaption";
				column.CreatedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
				column.ModifiedInSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
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
			return new LookupColumnsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new LookupColumnsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LookupColumnsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LookupColumnsGridPageEventsProcess

	/// <exclude/>
	public class LookupColumnsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LookupColumnsGridPageSchemaUserControl
	{

		public LookupColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LookupColumnsGridPageEventsProcess";
			SchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3");
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

		public virtual Guid FilterReightValue {
			get;
			set;
		}

		public virtual bool ColumnsExplorerRegistered {
			get;
			set;
		}

		public virtual bool ColumnsExplorerCreated {
			get;
			set;
		}

		public virtual Object LookupStructureExplorer {
			get;
			set;
		}

		public virtual Guid LookupEntitySchemaUId {
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
					SchemaElementUId = new Guid("8408bd00-c680-4b83-9feb-76eff6710df0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _init;
		public ProcessFlowElement Init {
			get {
				return _init ?? (_init = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Init",
					SchemaElementUId = new Guid("91c45a30-fb19-4d0b-85c7-959ad5304015"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInit;
		public ProcessScriptTask ScriptInit {
			get {
				return _scriptInit ?? (_scriptInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInit",
					SchemaElementUId = new Guid("04efae73-1db5-48f5-8922-712607d342e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitExecute,
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
					SchemaElementUId = new Guid("34dbbe73-6843-4118-9ef8-67afcf748445"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessChildApplyFolderFilter;
		public ProcessFlowElement SubProcessChildApplyFolderFilter {
			get {
				return _subProcessChildApplyFolderFilter ?? (_subProcessChildApplyFolderFilter = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildApplyFolderFilter",
					SchemaElementUId = new Guid("763defd9-97df-4a32-a18d-f2ed93a85403"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildApplyFolderFilter;
		public ProcessFlowElement StartMessageChildApplyFolderFilter {
			get {
				return _startMessageChildApplyFolderFilter ?? (_startMessageChildApplyFolderFilter = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildApplyFolderFilter",
					SchemaElementUId = new Guid("e8eaf9a9-69ef-4999-b7e4-4c973abf567b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildApplyFolderFilter;
		public ProcessScriptTask ScriptChildApplyFolderFilter {
			get {
				return _scriptChildApplyFolderFilter ?? (_scriptChildApplyFolderFilter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildApplyFolderFilter",
					SchemaElementUId = new Guid("63fa9fdc-acba-4f33-936f-a3e2a065973b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildApplyFolderFilterExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessChildPageLoadComplete;
		public ProcessFlowElement SubProcessChildPageLoadComplete {
			get {
				return _subProcessChildPageLoadComplete ?? (_subProcessChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildPageLoadComplete",
					SchemaElementUId = new Guid("0692cf67-8780-4c5f-8792-b6bf610aa18d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChild;
		public ProcessFlowElement StartMessageChild {
			get {
				return _startMessageChild ?? (_startMessageChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChild",
					SchemaElementUId = new Guid("4dd0d9cb-83b7-4d57-899c-13a77932417c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildPageLoadComplete;
		public ProcessScriptTask ScriptChildPageLoadComplete {
			get {
				return _scriptChildPageLoadComplete ?? (_scriptChildPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildPageLoadComplete",
					SchemaElementUId = new Guid("447613aa-8b4b-4a86-98c0-2300b9ad7778"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoadComplete {
			get {
				return _intermediateThrowBasePageLoadComplete ?? (_intermediateThrowBasePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoadComplete",
					SchemaElementUId = new Guid("3a426b75-586a-4f35-ac61-062473044e7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _addColumnsSubProcess;
		public ProcessFlowElement AddColumnsSubProcess {
			get {
				return _addColumnsSubProcess ?? (_addColumnsSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddColumnsSubProcess",
					SchemaElementUId = new Guid("a490ad74-6d7f-47e5-956c-c65173cbbe0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClickNew;
		public ProcessFlowElement AddButtonClickNew {
			get {
				return _addButtonClickNew ?? (_addButtonClickNew = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClickNew",
					SchemaElementUId = new Guid("b39a1baa-bf1d-49d3-b4b7-ed699763ca84"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAddColumns;
		public ProcessScriptTask ScriptAddColumns {
			get {
				return _scriptAddColumns ?? (_scriptAddColumns = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAddColumns",
					SchemaElementUId = new Guid("cbaf8a50-aac2-4f0c-bcab-9b5d818ec4f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddColumnsExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[ScriptInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[SubProcessChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildApplyFolderFilter };
			FlowElements[StartMessageChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildApplyFolderFilter };
			FlowElements[ScriptChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildApplyFolderFilter };
			FlowElements[SubProcessChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildPageLoadComplete };
			FlowElements[StartMessageChild.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChild };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
			FlowElements[IntermediateThrowBasePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoadComplete };
			FlowElements[AddColumnsSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddColumnsSubProcess };
			FlowElements[AddButtonClickNew.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickNew };
			FlowElements[ScriptAddColumns.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddColumns };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess9":
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("ScriptInit");
						break;
					case "ScriptInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "SubProcessChildApplyFolderFilter":
						break;
					case "StartMessageChildApplyFolderFilter":
						e.Context.QueueTasks.Enqueue("ScriptChildApplyFolderFilter");
						break;
					case "ScriptChildApplyFolderFilter":
						break;
					case "SubProcessChildPageLoadComplete":
						break;
					case "StartMessageChild":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "ScriptChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoadComplete");
						break;
					case "IntermediateThrowBasePageLoadComplete":
						break;
					case "AddColumnsSubProcess":
						break;
					case "AddButtonClickNew":
						e.Context.QueueTasks.Enqueue("ScriptAddColumns");
						break;
					case "ScriptAddColumns":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("Init");
			ActivatedEventElements.Add("StartMessageChildApplyFolderFilter");
			ActivatedEventElements.Add("StartMessageChild");
			ActivatedEventElements.Add("AddButtonClickNew");
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
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context);
					break;
				case "ScriptInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit";
					result = ScriptInit.Execute(context, ScriptInitExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "SubProcessChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildApplyFolderFilter";
					result = StartMessageChildApplyFolderFilter.Execute(context);
					break;
				case "ScriptChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildApplyFolderFilter";
					result = ScriptChildApplyFolderFilter.Execute(context, ScriptChildApplyFolderFilterExecute);
					break;
				case "SubProcessChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChild";
					result = StartMessageChild.Execute(context);
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
					break;
				case "IntermediateThrowBasePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowBasePageLoadComplete.Execute(context);
					break;
				case "AddColumnsSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClickNew":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickNew";
					result = AddButtonClickNew.Execute(context);
					break;
				case "ScriptAddColumns":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddColumns";
					result = ScriptAddColumns.Execute(context, ScriptAddColumnsExecute);
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
				case "LookupEntitySchemaUId":
					LookupEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ColumnsExplorerCreated":
					ColumnsExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "ColumnsExplorerRegistered":
					ColumnsExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "FilterReightValue":
					FilterReightValue = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptInitExecute(ProcessExecutingContext context) {
			Page.AddButton.Enabled = true;
			if (ColumnsExplorerCreated){
				CreateColumnsExplorerControl();
			}
			return true;
		}

		public virtual bool ScriptChildApplyFolderFilterExecute(ProcessExecutingContext context) {
			//var listenerPage = ListenerPage as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			currentStructure.Filters.Clear();
			if(!object.ReferenceEquals(DataSourceFilter, null)) {
				currentStructure.Filters.Add((Terrasoft.UI.WebControls.Controls.IDataSourceFilterItem) DataSourceFilter);
			}
			Page.TreeGrid.Clear();
			dataSource.LoadRows();
			/*
			var detailsTabPanel = listenerPage.DetailsTabPanel;
			if(detailsTabPanel.Tabs.Count == 0) {
				return true;
			}
			var activeTab = detailsTabPanel.Tabs[detailsTabPanel.ActiveTabIndex];
			var detailPageContainer = activeTab.Items[0] as PageControl;
			var detailDataSource = (detailPageContainer.FindPageControlByName("DataSource")) as DataSource;
			*/
			Guid filterColumnValue = Guid.Empty;
			if(dataSource.Rows.Count != 0) {
				var primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
				filterColumnValue = new Guid(dataSource.Rows[0].GetColumnValue(primaryColumnName)/*ActiveRowPrimaryColumnValue*/.ToString());
			}
			Page.TreeGrid.SelectNode(filterColumnValue.ToString());
			//ListenerProcessSetProperty(ListenerPageProcessUId, "FilterColumnValue", filterColumnValue);
			//ListenerThrowEvent(ListenerPageProcessUId, "RefreshDetails");
			//listenerPage.Process.SetPropertyValue("FilterColumnValue", filterColumnValue);
			//listenerPage.ThrowEvent("RefreshDetails");
			return true;
		}

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			if (EditPageUId == Guid.Empty || EditPageUId == null) {
				EditPageUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			}
			return true;
		}

		public virtual bool ScriptAddColumnsExecute(ProcessExecutingContext context) {
			if (SelectedNodePrimaryColumnValue != null && SelectedNodePrimaryColumnValue != Guid.Empty ) {
				var lookupSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysLookup");
				var entitySchemaColumn = lookupSchema.Columns.FindByName("SysEntitySchemaUId");
				var selectedLookup = lookupSchema.CreateEntity(UserConnection);
				if (selectedLookup.FetchFromDB(SelectedNodePrimaryColumnValue)) {
					LookupEntitySchemaUId = selectedLookup.GetTypedColumnValue<Guid>(entitySchemaColumn.ColumnValueName);
					ShowColumnExplorer();
				}
			}
			return true;
		}

		public override Guid SetDefValues() {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as 
				Terrasoft.Core.Entities.EntitySchemaManager;
			Terrasoft.Core.Entities.EntitySchema moduleDetailSchema = entitySchemaManager.GetInstanceByName("SysModuleDetailParentAssc");
			var detailEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleDetailParentAssc");
			var parentColumnMetaPathColumn = detailEntitySchemaQuery.AddColumn("ParentColumnMetaPath");
			var columnMetaPathColumn = detailEntitySchemaQuery.AddColumn("ColumnMetaPath");
			detailEntitySchemaQuery.Filters.Add(detailEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysModuleDetail", SysModuleDetailId));
			detailEntitySchemaQuery.Filters.Add(detailEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysParentAssociationType", new Guid("4913d205-92ba-46b3-82e2-7bf0afb24909")));
			var defValuesCollection = detailEntitySchemaQuery.GetEntityCollection(UserConnection);
			var defValues = new Dictionary <
				string, object>();
			string columnMetaPath = string.Empty;
			string parentColumnMetaPath = string.Empty;
			var parentSchema = entitySchemaManager.GetInstanceByUId(SysEntitySchemaId);
			Terrasoft.Core.Entities.EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(parentSchema);			
			var entityCollectionColumns = new Dictionary<string, string>();
			foreach(var defValue in defValuesCollection) {
				columnMetaPath = defValue.GetTypedColumnValue<string>(columnMetaPathColumn.Name);
				if (!string.IsNullOrEmpty(columnMetaPath)) {
					if (Page.DataSource.Schema.FindSchemaColumnByPath(columnMetaPath) == null) {
						columnMetaPath = Page.DataSource.Schema.GetSchemaColumnPathByMetaPath(columnMetaPath);
					}
				}
				parentColumnMetaPath = defValue.GetTypedColumnValue<string>(parentColumnMetaPathColumn.Name);
				string parentColumnPath = parentColumnMetaPath;
				if (!string.IsNullOrEmpty(parentColumnPath)) {
					if (parentSchema.FindSchemaColumnByPath(parentColumnPath) == null) {
						parentColumnPath = parentSchema.GetSchemaColumnPathByMetaPath(parentColumnMetaPath);
					}
				}
				EntitySchemaQueryColumn parentColumn = entitySchemaQuery.AddColumn(parentColumnPath);
				entityCollectionColumns.Add(columnMetaPath, parentColumn.Name);
			}
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				parentSchema.PrimaryColumn.Name, SelectedNodePrimaryColumnValue));
			EntityCollection entityCollection =	entitySchemaQuery.GetEntityCollection(Page.UserConnection);
			foreach (var column in entityCollectionColumns) {
				defValues.Add(column.Key, entityCollection[0].GetColumnValue(column.Value));
			}
			var newGuid = Guid.NewGuid();
			Page.UserConnection.SessionData[newGuid.ToString()] = defValues;
			return newGuid;
		}

		public virtual void RebuildColumnsList(object sender, AjaxEventArgs e) {
			var EntitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var column = Json.Deserialize(e.ExtraParameters["itemsInfo"]) as JObject;
			string metaPath = column.Value<string>("metaPath");
			string caption = column.Value<string>("caption");
			EntitySchema lookupColumnSchema = EntitySchemaManager.GetInstanceByName("SysLookupColumn");
			Entity lookupColumn = lookupColumnSchema.CreateEntity(Page.UserConnection);
			var lookupUId = Page.UserConnection.SessionData["LookupUid"];
			var condition = new Dictionary<string, object>() {
				{"MetaPath", metaPath},
				{"SysLookup", lookupUId}
			};
			if (!lookupColumn.ExistInDB(condition)) {
				lookupColumn.SetDefColumnValues();
				var lookupId = Guid.NewGuid();
				lookupColumn.SetColumnValue("Id", lookupId);
				lookupColumn.SetColumnValue("MetaPath", metaPath);
				lookupColumn.SetColumnValue("MetaCaption", caption);
				lookupColumn.SetColumnValue("SysLookupId", lookupUId);
				lookupColumn.SetColumnValue("Width", 100);
				lookupColumn.SetColumnValue("SysOrderDirectionId", "7c155038-77d2-4ea1-bcae-82d64698119d");
				lookupColumn.Save();
				Page.DataSource.LoadRow(lookupId);
			}
		}

		public virtual void CreateColumnsExplorerControl() {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);	
			var structureExplorer = new StructureExplorer(Page.AddButton, "columns", false, false, GetIsContextHelpEnabled() ? "274" : string.Empty);
			structureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			structureExplorer.IsShowSystemColumns = true;
			LookupStructureExplorer = structureExplorer;
			
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += new AjaxEventHandler(RebuildColumnsList);
			editComplete.ExtraParameters.Add(param);
			
			ColumnsExplorerCreated = true;
			if (!ColumnsExplorerRegistered) {
				structureExplorer.Register();
				ColumnsExplorerRegistered = true;
			}
		}

		public virtual void ShowColumnExplorer() {
			if (!ColumnsExplorerCreated) {
				CreateColumnsExplorerControl();
			}
			var sructureExplorer = (StructureExplorer)LookupStructureExplorer;
			string managerName = "EntitySchemaManager";
			sructureExplorer.ManagerName = managerName;
			sructureExplorer.ShowEditWindow(LookupEntitySchemaUId, null);
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			queryStringParameters.Remove("SysModuleEditId");
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("Init")) {
							context.QueueTasks.Enqueue("Init");
							ProcessQueue(context);
							return;
						}
						break;
					case "ApplyFolderFilter":
							if (ActivatedEventElements.Contains("StartMessageChildApplyFolderFilter")) {
							context.QueueTasks.Enqueue("StartMessageChildApplyFolderFilter");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageChild")) {
							context.QueueTasks.Enqueue("StartMessageChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClickNew")) {
							context.QueueTasks.Enqueue("AddButtonClickNew");
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
			if (!HasMapping("LookupEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LookupEntitySchemaUId", LookupEntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("ColumnsExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnsExplorerCreated", ColumnsExplorerCreated, false);
			}
			if (!HasMapping("ColumnsExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnsExplorerRegistered", ColumnsExplorerRegistered, false);
			}
			if (!HasMapping("FilterReightValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterReightValue", FilterReightValue, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: LookupColumnsGridPageEventsProcess

	/// <exclude/>
	public class LookupColumnsGridPageEventsProcess : LookupColumnsGridPageEventsProcess<Terrasoft.WebApp.LookupColumnsGridPageSchemaUserControl>
	{

		public LookupColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LookupColumnsGridPageSchemaUserControl

	/// <exclude/>
	public partial class LookupColumnsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (LookupColumnsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LookupColumnsGridPageEventsProcess(UserConnection);
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
			SchemaName = "LookupColumnsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: LookupColumnsGridPageEventsProcessSchema

	/// <exclude/>
	public class LookupColumnsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public LookupColumnsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LookupColumnsGridPageEventsProcessSchema(LookupColumnsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LookupColumnsGridPageEventsProcess";
			UId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e");
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

		protected virtual ProcessSchemaParameter CreateFilterReightValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6a040e7d-debf-467f-a7bf-dbd6e7b2e8a9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"FilterReightValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnsExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1b4ba510-fe04-4800-8a7c-c92ae8bc3721"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"ColumnsExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnsExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1828b995-ee1d-4de9-a2ed-771727ef4c2e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"ColumnsExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ddba09fc-5825-47e5-bfe2-13d6653d9d79"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"LookupStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b86d156a-74ba-4e41-9254-090d42ce1a86"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"LookupEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFilterReightValueParameter());
			Parameters.Add(CreateColumnsExplorerRegisteredParameter());
			Parameters.Add(CreateColumnsExplorerCreatedParameter());
			Parameters.Add(CreateLookupStructureExplorerParameter());
			Parameters.Add(CreateLookupEntitySchemaUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet570 = CreateLaneSet570LaneSet();
			LaneSets.Add(schemaLaneSet570);
			ProcessSchemaLane schemaLane1997 = CreateLane1997Lane();
			schemaLaneSet570.Lanes.Add(schemaLane1997);
			ProcessSchemaLane schemaLane1998 = CreateLane1998Lane();
			schemaLaneSet570.Lanes.Add(schemaLane1998);
			ProcessSchemaLane schemaLane1999 = CreateLane1999Lane();
			schemaLaneSet570.Lanes.Add(schemaLane1999);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet570.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess subprocesschildapplyfolderfilter = CreateSubProcessChildApplyFolderFilterEventSubProcess();
			FlowElements.Add(subprocesschildapplyfolderfilter);
			ProcessSchemaEventSubProcess subprocesschildpageloadcomplete = CreateSubProcessChildPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocesschildpageloadcomplete);
			ProcessSchemaEventSubProcess addcolumnssubprocess = CreateAddColumnsSubProcessEventSubProcess();
			FlowElements.Add(addcolumnssubprocess);
			ProcessSchemaStartMessageEvent init = CreateInitStartMessageEvent();
			subprocess9.FlowElements.Add(init);
			ProcessSchemaScriptTask scriptinit = CreateScriptInitScriptTask();
			subprocess9.FlowElements.Add(scriptinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			subprocess9.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessagechildapplyfolderfilter = CreateStartMessageChildApplyFolderFilterStartMessageEvent();
			subprocesschildapplyfolderfilter.FlowElements.Add(startmessagechildapplyfolderfilter);
			ProcessSchemaScriptTask scriptchildapplyfolderfilter = CreateScriptChildApplyFolderFilterScriptTask();
			subprocesschildapplyfolderfilter.FlowElements.Add(scriptchildapplyfolderfilter);
			ProcessSchemaStartMessageEvent startmessagechild = CreateStartMessageChildStartMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(startmessagechild);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			subprocesschildpageloadcomplete.FlowElements.Add(scriptchildpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageloadcomplete = CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(intermediatethrowbasepageloadcomplete);
			ProcessSchemaStartMessageEvent addbuttonclicknew = CreateAddButtonClickNewStartMessageEvent();
			addcolumnssubprocess.FlowElements.Add(addbuttonclicknew);
			ProcessSchemaScriptTask scriptaddcolumns = CreateScriptAddColumnsScriptTask();
			addcolumnssubprocess.FlowElements.Add(scriptaddcolumns);
			FlowElements.Add(CreateSequenceFlow12312SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12313SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12314SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12315SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12316SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12317SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12312SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12312",
				UId = new Guid("f636e34b-636d-4dd4-8058-0c1221a9d782"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CurveCenterPosition = new Point(148, 1644),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b39a1baa-bf1d-49d3-b4b7-ed699763ca84"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cbaf8a50-aac2-4f0c-bcab-9b5d818ec4f1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12313SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12313",
				UId = new Guid("cd305758-b34e-4512-86b4-a209c49de9fd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CurveCenterPosition = new Point(392, 1645),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("91c45a30-fb19-4d0b-85c7-959ad5304015"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04efae73-1db5-48f5-8922-712607d342e3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12314SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12314",
				UId = new Guid("c9b18882-bec5-4ad6-af08-39f9cb91710e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CurveCenterPosition = new Point(184, 1663),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8eaf9a9-69ef-4999-b7e4-4c973abf567b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63fa9fdc-acba-4f33-936f-a3e2a065973b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12315SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12315",
				UId = new Guid("6d3c63c6-3c40-4930-b861-2c5f90dfbd21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CurveCenterPosition = new Point(288, 1668),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("447613aa-8b4b-4a86-98c0-2300b9ad7778"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3a426b75-586a-4f35-ac61-062473044e7e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12316SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12316",
				UId = new Guid("b0afd868-b209-41bf-820a-d9fd3ffe6f6f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CurveCenterPosition = new Point(149, 1670),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dd0d9cb-83b7-4d57-899c-13a77932417c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("447613aa-8b4b-4a86-98c0-2300b9ad7778"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12317SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12317",
				UId = new Guid("ae2a8892-472d-492c-9075-3c132af37ef9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CurveCenterPosition = new Point(534, 454),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("04efae73-1db5-48f5-8922-712607d342e3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34dbbe73-6843-4118-9ef8-67afcf748445"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet570LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet570 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2e9e8172-9248-45fe-a6be-bfb50247452f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"LaneSet570",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(846, 726),
				UseBackgroundMode = false
			};
			return schemaLaneSet570;
		}

		protected virtual ProcessSchemaLane CreateLane1997Lane() {
			ProcessSchemaLane schemaLane1997 = new ProcessSchemaLane(this) {
				UId = new Guid("82637bfb-5391-483f-89b4-1a48882beffc"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("2e9e8172-9248-45fe-a6be-bfb50247452f"),
				CreatedInOwnerSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"Lane1997",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 544),
				Size = new Size(817, 182),
				UseBackgroundMode = false
			};
			return schemaLane1997;
		}

		protected virtual ProcessSchemaLane CreateLane1998Lane() {
			ProcessSchemaLane schemaLane1998 = new ProcessSchemaLane(this) {
				UId = new Guid("581d2100-f859-4329-b57c-cc1590f1cee9"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("2e9e8172-9248-45fe-a6be-bfb50247452f"),
				CreatedInOwnerSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"Lane1998",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 361),
				Size = new Size(817, 178),
				UseBackgroundMode = false
			};
			return schemaLane1998;
		}

		protected virtual ProcessSchemaLane CreateLane1999Lane() {
			ProcessSchemaLane schemaLane1999 = new ProcessSchemaLane(this) {
				UId = new Guid("cdc33a9b-9b54-470b-b183-11757bd41d3a"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("2e9e8172-9248-45fe-a6be-bfb50247452f"),
				CreatedInOwnerSchemaUId = new Guid("459d87da-3035-4cee-8f0d-34eab39e6ed3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"Lane1999",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 178),
				Size = new Size(817, 178),
				UseBackgroundMode = false
			};
			return schemaLane1999;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("2501e190-c3df-4b95-b0b8-6112fbf044c6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2e9e8172-9248-45fe-a6be-bfb50247452f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(817, 173),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8408bd00-c680-4b83-9feb-76eff6710df0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82637bfb-5391-483f-89b4-1a48882beffc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 12),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("91c45a30-fb19-4d0b-85c7-959ad5304015"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8408bd00-c680-4b83-9feb-76eff6710df0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"Init",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("04efae73-1db5-48f5-8922-712607d342e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8408bd00-c680-4b83-9feb-76eff6710df0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"ScriptInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,76,73,113,42,45,41,201,207,211,115,205,75,76,202,73,77,81,176,85,40,41,42,77,181,230,202,76,83,208,112,206,207,41,205,205,43,118,173,40,200,201,47,74,45,114,46,74,77,44,73,77,209,172,230,226,132,48,209,229,243,243,74,138,242,115,52,52,173,185,106,185,138,82,75,74,139,242,32,134,1,0,190,84,238,44,107,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("34dbbe73-6843-4118-9ef8-67afcf748445"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8408bd00-c680-4b83-9feb-76eff6710df0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildApplyFolderFilterEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildApplyFolderFilter = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("763defd9-97df-4a32-a18d-f2ed93a85403"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("581d2100-f859-4329-b57c-cc1590f1cee9"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"SubProcessChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(258, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildApplyFolderFilter;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildApplyFolderFilterStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e8eaf9a9-69ef-4999-b7e4-4c973abf567b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("763defd9-97df-4a32-a18d-f2ed93a85403"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ApplyFolderFilter",
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"StartMessageChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildApplyFolderFilterScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("63fa9fdc-acba-4f33-936f-a3e2a065973b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("763defd9-97df-4a32-a18d-f2ed93a85403"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"ScriptChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,193,110,226,48,16,61,55,95,225,114,114,16,114,122,71,28,40,80,132,212,86,168,192,238,161,234,193,36,67,73,229,216,236,216,134,69,171,253,247,181,19,32,78,160,135,189,57,246,155,55,111,222,204,36,73,246,28,137,200,181,1,9,56,231,159,64,6,228,57,252,228,154,44,1,145,107,181,49,236,39,172,135,187,29,123,228,26,94,84,102,5,120,200,34,221,66,193,87,26,112,164,164,65,37,250,145,39,205,184,225,11,101,49,245,148,30,199,198,151,155,10,145,90,68,144,102,97,208,166,198,162,199,213,65,108,212,122,237,71,109,60,123,202,133,1,212,108,36,128,35,141,251,81,190,161,247,106,253,5,169,97,111,176,1,135,78,97,242,203,114,161,105,157,188,138,234,17,105,133,136,99,242,39,186,251,150,120,152,101,148,214,229,175,102,222,129,83,149,46,237,249,48,107,147,207,12,20,49,105,223,58,129,127,163,210,137,37,2,76,49,207,106,229,65,225,207,138,103,111,234,160,253,117,210,173,188,4,195,115,161,151,124,61,231,18,132,51,42,108,25,27,55,159,75,31,90,33,204,29,188,98,43,13,25,12,200,67,89,55,130,171,86,18,87,54,120,105,62,19,79,77,190,7,7,246,205,184,65,241,222,190,28,158,3,102,50,131,223,31,253,64,175,215,230,61,226,185,19,234,248,46,220,204,251,163,223,31,62,252,116,157,81,245,224,148,193,227,112,124,232,13,66,215,36,153,5,193,143,199,87,94,0,237,212,129,29,215,93,151,32,28,187,110,18,77,109,158,145,77,217,144,145,18,182,144,63,184,176,62,137,127,96,147,98,103,142,149,129,117,71,124,55,78,222,221,159,189,243,74,119,152,23,28,143,21,141,207,222,156,224,106,49,216,60,68,49,15,235,71,119,183,4,72,56,148,34,218,169,157,81,108,10,38,0,211,171,204,113,210,173,58,225,2,26,9,75,124,55,97,75,229,198,59,151,159,52,190,49,134,11,16,110,103,94,85,6,244,74,88,51,50,73,46,127,7,84,41,104,189,0,227,78,59,64,115,164,225,143,227,244,188,154,101,61,210,121,106,147,118,122,215,45,104,176,47,183,168,14,147,189,219,202,239,89,221,138,35,232,237,105,250,59,101,124,99,47,78,104,22,104,172,236,251,15,65,13,194,64,213,141,236,225,58,253,3,203,100,13,56,89,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0692cf67-8780-4c5f-8792-b6bf610aa18d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cdc33a9b-9b54-470b-b183-11757bd41d3a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"SubProcessChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4dd0d9cb-83b7-4d57-899c-13a77932417c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0692cf67-8780-4c5f-8792-b6bf610aa18d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"StartMessageChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("447613aa-8b4b-4a86-98c0-2300b9ad7778"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0692cf67-8780-4c5f-8792-b6bf610aa18d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,77,201,44,9,72,76,79,13,245,76,81,176,181,85,112,47,205,76,209,115,205,45,40,169,84,168,169,81,64,147,204,43,205,201,209,84,168,230,226,68,17,87,200,75,45,7,235,211,80,50,50,73,54,180,52,75,51,213,77,76,51,73,211,53,49,51,180,212,181,48,52,52,211,53,53,79,77,75,76,50,76,49,75,178,180,84,210,180,230,170,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,193,101,229,235,135,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3a426b75-586a-4f35-ac61-062473044e7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0692cf67-8780-4c5f-8792-b6bf610aa18d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"IntermediateThrowBasePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddColumnsSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddColumnsSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a490ad74-6d7f-47e5-956c-c65173cbbe0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2501e190-c3df-4b95-b0b8-6112fbf044c6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"AddColumnsSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddColumnsSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickNewStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b39a1baa-bf1d-49d3-b4b7-ed699763ca84"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a490ad74-6d7f-47e5-956c-c65173cbbe0e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"AddButtonClickNew",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddColumnsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cbaf8a50-aac2-4f0c-bcab-9b5d818ec4f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a490ad74-6d7f-47e5-956c-c65173cbbe0e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Name = @"ScriptAddColumns",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,207,78,2,49,16,135,207,75,194,59,84,14,164,123,233,11,32,30,192,93,66,162,196,100,197,123,179,29,220,198,254,217,204,182,106,99,124,119,203,150,196,2,7,146,158,58,51,223,252,230,147,7,66,27,80,208,58,16,59,43,224,5,165,230,24,214,86,121,109,222,184,242,64,238,150,196,120,165,200,124,78,110,119,110,188,20,172,210,189,11,164,36,63,211,73,241,201,145,40,107,63,124,223,180,29,104,78,150,100,63,0,174,173,49,17,37,173,97,149,113,210,133,84,125,230,134,191,3,178,13,184,173,25,28,55,45,172,194,142,107,160,179,38,12,79,35,103,86,46,78,92,200,38,83,142,72,207,151,177,244,59,176,90,26,145,129,242,149,251,173,248,39,14,167,3,211,166,43,26,2,119,144,134,233,249,21,35,65,70,153,231,4,86,131,107,187,26,173,126,92,221,240,92,38,95,69,26,188,72,24,147,92,128,163,161,215,208,131,200,8,247,71,249,15,244,218,10,203,154,142,14,198,176,69,211,217,175,84,168,190,123,101,17,144,142,133,223,233,36,62,4,231,209,16,135,30,22,127,195,99,39,78,37,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateRebuildColumnsListMethod());
			Methods.Add(CreateCreateColumnsExplorerControlMethod());
			Methods.Add(CreateShowColumnExplorerMethod());
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

		protected override SchemaMethod CreateSetDefValuesMethod() {
			SchemaMethod method = base.CreateSetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,85,91,79,219,48,20,126,78,126,133,151,167,68,106,163,174,176,75,85,58,9,10,76,213,68,215,169,176,61,32,30,220,196,165,158,114,97,182,195,20,77,252,247,29,219,73,112,227,132,85,188,76,170,228,230,248,92,191,115,206,231,71,204,16,201,4,21,229,58,218,145,20,95,225,12,223,19,134,102,104,5,103,168,133,225,222,221,138,229,143,52,38,44,252,76,68,37,242,189,11,219,135,23,32,204,145,235,92,19,198,48,207,183,34,156,231,140,132,74,147,18,30,118,152,76,221,67,148,81,154,199,69,66,206,137,192,52,169,68,179,174,42,100,134,139,140,11,156,69,228,172,92,226,148,248,222,186,228,87,134,249,10,51,48,60,229,60,242,130,169,251,8,104,196,74,110,198,251,86,16,86,66,132,140,252,70,150,220,239,136,59,64,255,14,243,160,36,243,60,41,210,236,10,116,86,88,236,244,23,68,234,201,33,60,141,99,173,227,123,171,14,251,218,119,244,106,175,182,191,62,163,75,154,8,194,184,52,246,251,116,230,140,96,65,180,230,15,42,118,144,51,244,64,154,249,90,56,207,83,192,129,242,60,187,46,31,160,219,191,10,156,12,96,100,218,240,121,3,212,146,44,226,224,127,38,215,244,51,143,40,22,84,171,64,150,114,68,62,23,52,246,189,227,201,219,163,120,60,122,55,156,140,55,120,120,252,126,115,52,252,56,38,227,225,135,205,118,132,183,155,241,241,100,52,241,130,160,25,186,237,119,156,20,132,67,3,18,18,73,143,47,52,12,198,90,11,159,181,253,27,46,51,206,50,253,217,118,91,77,239,57,85,183,24,198,249,196,117,184,96,52,187,31,160,124,243,19,172,62,249,96,164,69,173,1,2,99,45,15,47,210,7,81,54,90,93,35,108,233,62,207,250,225,155,122,179,136,125,0,217,44,28,250,125,24,57,232,101,37,7,175,175,153,91,48,117,28,71,101,76,90,240,234,34,109,24,79,106,12,245,169,48,220,66,110,56,218,249,102,3,16,205,186,122,28,160,63,174,99,129,93,43,74,80,228,92,85,219,169,100,39,117,160,174,29,15,37,197,65,6,14,221,34,255,77,213,135,5,95,22,73,242,149,169,126,180,204,2,149,128,82,87,116,127,142,5,94,231,5,139,26,230,191,164,89,172,255,234,16,103,165,180,107,187,65,51,0,6,162,104,119,118,69,61,206,161,62,211,183,84,62,43,107,179,118,12,40,203,121,114,229,175,103,238,14,130,173,159,118,27,240,58,166,187,138,208,101,252,34,218,109,31,6,222,230,220,245,161,108,153,183,112,238,77,241,32,124,187,170,49,80,182,86,165,122,71,76,179,214,50,183,159,19,43,127,240,222,179,89,138,170,247,59,62,216,11,85,183,231,201,181,35,154,116,111,223,190,154,232,247,176,92,49,154,226,26,4,149,12,188,73,68,22,65,226,101,30,147,189,123,53,115,146,219,219,52,109,17,11,154,57,118,198,93,252,174,86,200,34,249,138,107,144,255,252,236,75,170,233,1,89,141,77,67,67,6,228,225,23,82,14,44,171,219,209,157,76,197,40,169,86,111,234,123,82,108,9,156,40,31,61,152,6,121,132,75,253,41,185,176,35,235,112,77,56,135,83,210,193,109,101,25,94,231,107,181,63,126,112,103,108,50,159,186,140,136,130,101,117,132,233,95,226,19,29,209,175,10,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = base.CreateModifyEditPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,44,77,45,170,12,46,41,202,204,75,15,72,44,74,204,77,45,73,45,42,214,11,74,205,205,47,75,213,80,10,174,44,246,205,79,41,205,73,117,77,201,44,241,76,81,210,180,6,0,51,222,222,182,48,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRebuildColumnsListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4dd0141e-0844-4e41-86e6-16f24195d70c"),
				Name = "RebuildColumnsList",
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1c149280-aa32-45ab-b6bd-11c9f0201817"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7343c35e-9b2d-49ec-8dc1-0592414e6212"),
				Name = "e",
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				ModifiedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,79,219,64,16,61,19,41,255,97,187,167,181,148,88,49,5,18,212,194,129,24,33,35,190,84,43,237,1,113,24,188,19,216,54,89,163,221,117,66,138,242,223,187,222,117,140,211,186,34,167,149,61,243,222,155,247,102,22,160,200,185,52,194,172,210,236,25,231,112,13,18,158,80,145,19,50,209,168,198,185,148,152,25,145,203,240,2,205,86,7,163,45,48,26,16,208,109,124,95,186,157,133,85,202,242,89,49,151,150,252,82,91,202,24,173,132,128,153,248,141,12,195,243,87,163,224,14,20,204,209,160,210,247,84,24,156,235,68,78,115,250,224,104,47,111,31,127,218,97,44,149,54,74,200,39,98,27,45,192,60,91,62,79,28,126,135,89,129,95,125,249,148,209,77,3,13,222,65,25,188,148,126,254,139,169,234,14,210,52,66,102,121,254,171,120,25,59,80,245,235,164,205,106,153,84,34,181,1,153,225,217,234,198,218,97,52,93,233,171,6,188,65,190,69,107,9,255,85,9,199,10,193,160,111,103,119,86,34,220,94,77,80,133,235,161,147,132,91,154,150,182,48,69,173,237,27,131,129,123,234,199,153,8,78,31,234,221,72,46,170,104,36,46,73,44,28,12,212,170,10,167,71,114,183,128,83,22,144,183,110,103,239,141,94,111,242,237,213,187,88,247,92,165,54,108,75,245,92,235,110,103,109,197,196,148,176,79,77,159,118,245,66,219,204,226,51,86,15,17,120,141,173,182,20,77,140,83,255,225,182,166,89,233,125,239,221,188,243,126,81,8,30,222,224,178,124,125,195,223,44,13,10,70,19,94,207,152,240,143,219,91,60,239,6,26,87,135,213,219,156,224,199,176,58,197,198,140,147,93,134,252,33,184,155,48,26,12,118,82,185,85,28,85,44,148,191,20,167,70,135,89,116,120,56,248,60,234,15,135,124,191,127,128,16,245,31,51,192,254,104,159,31,29,28,29,143,162,232,152,211,22,118,88,160,79,221,221,96,121,109,105,94,168,12,195,171,28,248,183,124,201,154,89,175,255,0,57,36,91,248,128,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnsExplorerControlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c7b4d523-f9d5-4f54-9894-002d9f4ad152"),
				Name = "CreateColumnsExplorerControl",
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,79,79,194,48,20,63,179,79,81,119,218,162,233,193,152,152,184,24,3,115,202,18,76,8,160,30,140,135,66,223,112,218,181,75,251,6,91,8,223,221,142,193,130,12,79,125,107,127,255,222,123,91,49,77,114,166,89,70,238,137,132,53,153,129,214,204,168,4,233,107,76,223,97,30,42,137,90,9,67,219,98,92,163,1,65,123,110,138,144,153,88,38,202,189,34,127,62,90,204,139,226,64,39,108,237,7,61,103,101,173,12,234,98,129,133,134,168,204,133,210,160,247,182,211,211,123,111,204,150,64,251,156,15,10,68,37,173,254,66,137,34,147,198,170,39,76,24,104,143,103,192,216,212,233,160,196,33,136,60,146,108,46,128,123,62,121,32,238,245,237,141,75,238,106,219,84,46,105,148,229,88,249,129,211,73,65,163,114,33,10,14,143,12,217,27,19,5,204,170,28,204,62,91,67,254,248,36,27,226,14,82,201,116,85,183,251,148,10,168,207,56,179,65,235,34,84,86,202,37,219,115,242,177,153,126,169,245,180,50,118,70,97,211,135,21,183,48,8,156,145,82,63,69,222,25,128,125,239,232,4,142,19,170,44,87,18,36,246,191,89,25,173,108,65,128,167,88,95,11,59,240,115,44,218,66,13,141,142,176,129,115,204,164,141,216,101,211,115,75,25,50,201,133,93,199,4,230,69,42,248,62,252,40,53,232,159,242,75,212,172,93,188,169,119,231,237,254,44,127,23,123,199,59,68,10,53,48,4,222,206,32,77,136,119,113,130,153,192,210,186,128,6,238,147,141,211,235,182,117,0,120,214,160,247,47,185,245,216,254,2,28,67,171,163,235,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ac40c79b-5037-426a-8bf9-bc384eb6fc2b"),
				Name = "ShowColumnExplorer",
				CreatedInSchemaUId = new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,193,10,194,48,16,68,207,230,43,98,79,9,136,63,80,60,149,30,4,235,165,136,231,208,196,54,152,100,203,102,99,21,241,223,45,20,161,86,111,195,204,155,217,181,23,46,214,5,184,228,67,44,239,189,3,52,88,160,81,100,180,228,79,182,154,244,18,128,64,8,78,200,156,189,216,77,33,143,152,26,74,104,62,0,223,113,81,211,194,148,7,128,107,234,127,252,156,69,66,27,90,238,85,80,173,193,163,242,102,28,200,202,64,150,30,117,211,25,175,170,41,202,70,118,209,222,86,95,173,217,198,31,182,238,96,40,181,165,179,13,26,6,49,61,52,191,115,218,235,13,15,201,57,153,191,1,24,105,14,250,26,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LookupColumnsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac982f4d-afdc-492a-b08c-f40c2e3a9c3e"));
		}

		#endregion

	}

	#endregion

}

