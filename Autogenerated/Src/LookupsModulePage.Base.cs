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

	#region Class: LookupsModulePageSchema

	/// <exclude/>
	public class LookupsModulePageSchema : Terrasoft.WebApp.BaseModulePageSchema
	{

		#region Constructors: Public

		public LookupsModulePageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LookupsModulePageSchema(LookupsModulePageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		private void UpdateGrid() {
			Grid.PageSchemaUId = new Guid("1553e6ff-2c67-4d09-84c5-7b1b6ce20179");
			Grid.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
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
			RightControlLayout.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
			RealUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
			Name = "LookupsModulePage";
			ParentSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLookupsModulePageEventsProcessSchema();
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
			RightControlLayout.MoveItem(1, DetailsTabPanel);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateLookupsModulePageEventsProcessSchema() {
			var schema = new LookupsModulePageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new LookupsModulePageSchemaUserControl();
		}

		public override object Clone() {
			return new LookupsModulePageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LookupsModulePageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LookupsModulePageEventsProcess

	/// <exclude/>
	public class LookupsModulePageEventsProcess<TPage> : Terrasoft.WebApp.BaseModulePageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LookupsModulePageSchemaUserControl
	{

		public LookupsModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LookupsModulePageEventsProcess";
			SchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607");
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

		private ProcessFlowElement _subProcess13;
		public ProcessFlowElement SubProcess13 {
			get {
				return _subProcess13 ?? (_subProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess13",
					SchemaElementUId = new Guid("0bc0f73c-bfc1-44a7-b76d-046525bfc458"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _prepareFilters;
		public ProcessFlowElement PrepareFilters {
			get {
				return _prepareFilters ?? (_prepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PrepareFilters",
					SchemaElementUId = new Guid("d775d4bc-e513-4eca-985a-5b7674e216d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPrepareFilters;
		public ProcessScriptTask ScriptPrepareFilters {
			get {
				return _scriptPrepareFilters ?? (_scriptPrepareFilters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepareFilters",
					SchemaElementUId = new Guid("9ee8a4e9-81f3-4644-b04b-196f4475d20d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrepareFiltersExecute,
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
					SchemaElementUId = new Guid("d2282c9d-237f-4b69-bc61-c38261f69e58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BasePrepareFilters",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessChildInit;
		public ProcessFlowElement SubProcessChildInit {
			get {
				return _subProcessChildInit ?? (_subProcessChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildInit",
					SchemaElementUId = new Guid("79875ead-42ba-402c-b2ea-0bd3371538cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildInit;
		public ProcessFlowElement StartMessageChildInit {
			get {
				return _startMessageChildInit ?? (_startMessageChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildInit",
					SchemaElementUId = new Guid("5cf4b387-b5a3-425c-9af4-932bba62c6ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildInit;
		public ProcessScriptTask ScriptChildInit {
			get {
				return _scriptChildInit ?? (_scriptChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildInit",
					SchemaElementUId = new Guid("ae238c6a-1784-4dd9-b00f-291b4bca8d6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBaseInit;
		public ProcessThrowMessageEvent IntermediateThrowBaseInit {
			get {
				return _intermediateThrowBaseInit ?? (_intermediateThrowBaseInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBaseInit",
					SchemaElementUId = new Guid("f78796d2-1e93-4b5b-80ae-663b06275f39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("a3f58ae3-ce37-4aa2-a398-281f53c214a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildPageLoadComplete;
		public ProcessFlowElement StartMessageChildPageLoadComplete {
			get {
				return _startMessageChildPageLoadComplete ?? (_startMessageChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildPageLoadComplete",
					SchemaElementUId = new Guid("95315613-4fdf-43fe-8dbe-be32061bb43f"),
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
					SchemaElementUId = new Guid("1bb17dda-5364-457f-b928-6914efe466a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
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
					SchemaElementUId = new Guid("a511b31e-183b-4598-8779-cb3b9b29d3bd"),
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
			FlowElements[SubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess13 };
			FlowElements[PrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareFilters };
			FlowElements[ScriptPrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareFilters };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[SubProcessChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildInit };
			FlowElements[StartMessageChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[IntermediateThrowBaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseInit };
			FlowElements[SubProcessChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildPageLoadComplete };
			FlowElements[StartMessageChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildPageLoadComplete };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess13":
						break;
					case "PrepareFilters":
						e.Context.QueueTasks.Enqueue("ScriptPrepareFilters");
						break;
					case "ScriptPrepareFilters":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "SubProcessChildInit":
						break;
					case "StartMessageChildInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseInit");
						break;
					case "IntermediateThrowBaseInit":
						break;
					case "SubProcessChildPageLoadComplete":
						break;
					case "StartMessageChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "ScriptChildPageLoadComplete":
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
			ActivatedEventElements.Add("PrepareFilters");
			ActivatedEventElements.Add("StartMessageChildInit");
			ActivatedEventElements.Add("StartMessageChildPageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "PrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareFilters";
					result = PrepareFilters.Execute(context);
					break;
				case "ScriptPrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrepareFilters";
					result = ScriptPrepareFilters.Execute(context, ScriptPrepareFiltersExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BasePrepareFilters");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "SubProcessChildInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildInit";
					result = StartMessageChildInit.Execute(context);
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "IntermediateThrowBaseInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowBaseInit.Execute(context);
					break;
				case "SubProcessChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildPageLoadComplete";
					result = StartMessageChildPageLoadComplete.Execute(context);
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
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

		public virtual bool ScriptPrepareFiltersExecute(ProcessExecutingContext context) {
			DataSource dataSource = GetActiveDataSource();
			Page.FilterEdit.DataSourceId = dataSource.ClientID;
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			IsRootFolder = true;
			var grid = Page.Grid;
			var gridInstance = grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var gridProcess = gridInstance.Process;
			var baseFolder = Page.BaseFolder;
			var baseFolderProcess = baseFolder.PageInstance.Process;	
			baseFolderProcess.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			baseFolderProcess.SetPropertyValue("ListenerPage", Page);
			baseFolderProcess.SetPropertyValue("EntitySchemaUId", FolderEntitySchemaUId);
			gridProcess.SetPropertyValue("ListenerPage", Page);
			gridProcess.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			return true;
		}

		public override void BaseApplyModuleFilters() {
			var pageInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			if (!IsRootFolder && FolderId != Guid.Empty) {
				var folderInfo = GetFolderInfo();
				Guid dynamicFolderTypeId = new Guid("65CA0946-0084-4874-B117-C13199AF3B95");
				if (folderInfo == null || DBNull.Value.Equals(folderInfo[0]) || !folderInfo.Length.Equals(2) || !(new Guid(folderInfo[0].ToString())).Equals(dynamicFolderTypeId)) {
					var dataSource = pageInstance.DataSource;
					var folderEntitySchema = dataSource.Schema;       
					var folderColumn = folderEntitySchema.Columns.GetByName("SysFolder");
					SetDetailFilter.FilterName = "FolderFilter";
					SetDetailFilter.FilterLeftExpressions = new  string[] 
			                       {string.Concat(new string[] { "SysFolder." + folderColumn.ReferenceSchema.GetPrimaryColumnName() } )};
			
					SetDetailFilter.FilterRightValue = FolderId;
					var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
					if (oldDataSourceFolderFilter != null) {
						dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
					}
					var filter = SetDetailFilter.CreateFilter(dataSource, 
						//Код, который компилируется только в Workspace CR172721
						Page.UserConnection.Workspace.Id, 
						null);
					dataSource.CurrentStructure.Filters.Add(filter);
					pageInstance.Process.SetPropertyValue("SelectedFolderId", FolderId);
				}
			}
			if (IsRootFolder) {
				var dataSource = pageInstance.DataSource;
				var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
			}
			pageInstance.Process.SetPropertyValue("IsSelectedFolderRoot", IsRootFolder);
		}

		public override DataSourceRowConfig GetModuleRowConfig(Entity module) {
			var config = base.GetModuleRowConfig(module);
			string[] dragTags = new string[] { "SysLookup" }; 
			config.AddConfig(new DataSourceRowDragTagsConfigValue(dragTags));
			return config;
		}

		public override bool OnPageLoadComlete() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLookups");
			return base.OnPageLoadComlete();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("PrepareFilters")) {
							context.QueueTasks.Enqueue("PrepareFilters");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageChildInit")) {
							context.QueueTasks.Enqueue("StartMessageChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageChildPageLoadComplete");
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

	#region Class: LookupsModulePageEventsProcess

	/// <exclude/>
	public class LookupsModulePageEventsProcess : LookupsModulePageEventsProcess<Terrasoft.WebApp.LookupsModulePageSchemaUserControl>
	{

		public LookupsModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LookupsModulePageSchemaUserControl

	/// <exclude/>
	public partial class LookupsModulePageSchemaUserControl : Terrasoft.WebApp.BaseModulePageSchemaUserControl
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
			var process = (LookupsModulePageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LookupsModulePageEventsProcess(UserConnection);
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
			SchemaName = "LookupsModulePage";
		}

		#endregion

	}

	#endregion

	#region Class: LookupsModulePageEventsProcessSchema

	/// <exclude/>
	public class LookupsModulePageEventsProcessSchema : Terrasoft.WebApp.BaseModulePageEventsProcessSchema
	{

		#region Constructors: Public

		public LookupsModulePageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LookupsModulePageEventsProcessSchema(LookupsModulePageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LookupsModulePageEventsProcess";
			UId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet313 = CreateLaneSet313LaneSet();
			LaneSets.Add(schemaLaneSet313);
			ProcessSchemaLane schemaLane992 = CreateLane992Lane();
			schemaLaneSet313.Lanes.Add(schemaLane992);
			ProcessSchemaLane schemaLane993 = CreateLane993Lane();
			schemaLaneSet313.Lanes.Add(schemaLane993);
			ProcessSchemaLane schemaLane994 = CreateLane994Lane();
			schemaLaneSet313.Lanes.Add(schemaLane994);
			ProcessSchemaEventSubProcess subprocess13 = CreateSubProcess13EventSubProcess();
			FlowElements.Add(subprocess13);
			ProcessSchemaEventSubProcess subprocesschildinit = CreateSubProcessChildInitEventSubProcess();
			FlowElements.Add(subprocesschildinit);
			ProcessSchemaEventSubProcess subprocesschildpageloadcomplete = CreateSubProcessChildPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocesschildpageloadcomplete);
			ProcessSchemaStartMessageEvent preparefilters = CreatePrepareFiltersStartMessageEvent();
			subprocess13.FlowElements.Add(preparefilters);
			ProcessSchemaScriptTask scriptpreparefilters = CreateScriptPrepareFiltersScriptTask();
			subprocess13.FlowElements.Add(scriptpreparefilters);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			subprocess13.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessagechildinit = CreateStartMessageChildInitStartMessageEvent();
			subprocesschildinit.FlowElements.Add(startmessagechildinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			subprocesschildinit.FlowElements.Add(scriptchildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbaseinit = CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent();
			subprocesschildinit.FlowElements.Add(intermediatethrowbaseinit);
			ProcessSchemaStartMessageEvent startmessagechildpageloadcomplete = CreateStartMessageChildPageLoadCompleteStartMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(startmessagechildpageloadcomplete);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			subprocesschildpageloadcomplete.FlowElements.Add(scriptchildpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(intermediatethrowmessageevent2);
			FlowElements.Add(CreateSequenceFlow6121SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6122SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6123SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6124SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6125SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6140SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6121SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6121",
				UId = new Guid("496117dd-9235-4715-9232-3fab3912be9f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				CurveCenterPosition = new Point(136, 2450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d775d4bc-e513-4eca-985a-5b7674e216d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ee8a4e9-81f3-4644-b04b-196f4475d20d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6122SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6122",
				UId = new Guid("8ec0fbef-69d8-44f2-8fce-7c7126683f64"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				CurveCenterPosition = new Point(276, 2450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ee8a4e9-81f3-4644-b04b-196f4475d20d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2282c9d-237f-4b69-bc61-c38261f69e58"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6123SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6123",
				UId = new Guid("d106f163-454a-4d48-8dc1-ef6c89831617"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				CurveCenterPosition = new Point(168, 2447),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5cf4b387-b5a3-425c-9af4-932bba62c6ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ae238c6a-1784-4dd9-b00f-291b4bca8d6d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6124SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6124",
				UId = new Guid("135fbf73-c8d9-4986-8c4b-e29de77946e8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				CurveCenterPosition = new Point(309, 2446),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ae238c6a-1784-4dd9-b00f-291b4bca8d6d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f78796d2-1e93-4b5b-80ae-663b06275f39"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6125SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6125",
				UId = new Guid("abb37d44-1fbf-4af2-8c31-3efcc76e46b8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				CurveCenterPosition = new Point(169, 2435),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95315613-4fdf-43fe-8dbe-be32061bb43f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1bb17dda-5364-457f-b928-6914efe466a8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6140SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6140",
				UId = new Guid("861603b8-1bcf-4ff7-93c3-5751d236311e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				CurveCenterPosition = new Point(310, 448),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1bb17dda-5364-457f-b928-6914efe466a8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a511b31e-183b-4598-8779-cb3b9b29d3bd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet313LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet313 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("652d0b1b-270f-420a-a146-f748433a2add"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"LaneSet313",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(529, 537),
				UseBackgroundMode = false
			};
			return schemaLaneSet313;
		}

		protected virtual ProcessSchemaLane CreateLane992Lane() {
			ProcessSchemaLane schemaLane992 = new ProcessSchemaLane(this) {
				UId = new Guid("851e5cfb-0220-4c72-94f5-9fddcfec3b4a"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("652d0b1b-270f-420a-a146-f748433a2add"),
				CreatedInOwnerSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"Lane992",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 182),
				Size = new Size(500, 175),
				UseBackgroundMode = false
			};
			return schemaLane992;
		}

		protected virtual ProcessSchemaLane CreateLane993Lane() {
			ProcessSchemaLane schemaLane993 = new ProcessSchemaLane(this) {
				UId = new Guid("0352ee76-32db-4f97-bee1-a989c5013035"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("652d0b1b-270f-420a-a146-f748433a2add"),
				CreatedInOwnerSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"Lane993",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 362),
				Size = new Size(500, 175),
				UseBackgroundMode = false
			};
			return schemaLane993;
		}

		protected virtual ProcessSchemaLane CreateLane994Lane() {
			ProcessSchemaLane schemaLane994 = new ProcessSchemaLane(this) {
				UId = new Guid("3f6d9ca4-f250-4493-8002-1bade90a9a79"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("652d0b1b-270f-420a-a146-f748433a2add"),
				CreatedInOwnerSchemaUId = new Guid("fd6ce2ca-2b5f-41c2-83f0-296e53606607"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"Lane994",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(500, 177),
				UseBackgroundMode = false
			};
			return schemaLane994;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0bc0f73c-bfc1-44a7-b76d-046525bfc458"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("851e5cfb-0220-4c72-94f5-9fddcfec3b4a"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"SubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePrepareFiltersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d775d4bc-e513-4eca-985a-5b7674e216d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0bc0f73c-bfc1-44a7-b76d-046525bfc458"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"PrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareFiltersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9ee8a4e9-81f3-4644-b04b-196f4475d20d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0bc0f73c-bfc1-44a7-b76d-046525bfc458"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"ScriptPrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,44,73,12,206,47,45,74,78,85,72,65,48,109,21,220,83,75,28,147,75,50,203,82,93,224,162,26,154,214,92,1,137,233,169,122,110,153,57,37,169,69,174,41,153,37,122,8,89,207,20,160,46,132,17,122,206,57,153,169,121,37,158,46,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,126,145,48,131,111,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d2282c9d-237f-4b69-bc61-c38261f69e58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0bc0f73c-bfc1-44a7-b76d-046525bfc458"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("79875ead-42ba-402c-b2ea-0bd3371538cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0352ee76-32db-4f97-bee1-a989c5013035"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"SubProcessChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(316, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5cf4b387-b5a3-425c-9af4-932bba62c6ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79875ead-42ba-402c-b2ea-0bd3371538cc"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"StartMessageChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ae238c6a-1784-4dd9-b00f-291b4bca8d6d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79875ead-42ba-402c-b2ea-0bd3371538cc"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f78796d2-1e93-4b5b-80ae-663b06275f39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79875ead-42ba-402c-b2ea-0bd3371538cc"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"IntermediateThrowBaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a3f58ae3-ce37-4aa2-a398-281f53c214a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f6d9ca4-f250-4493-8002-1bade90a9a79"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"SubProcessChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(313, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("95315613-4fdf-43fe-8dbe-be32061bb43f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3f58ae3-ce37-4aa2-a398-281f53c214a8"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"StartMessageChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1bb17dda-5364-457f-b928-6914efe466a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3f58ae3-ce37-4aa2-a398-281f53c214a8"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,79,11,130,64,16,197,207,245,41,164,83,65,236,23,136,14,25,21,66,135,232,239,121,213,169,4,219,149,153,49,232,219,55,234,170,101,23,187,205,190,121,239,199,99,216,128,246,214,242,218,166,49,160,55,247,24,115,152,13,159,26,189,27,38,177,8,59,125,3,181,145,185,85,3,67,172,77,4,178,45,158,170,176,52,154,38,239,8,136,154,236,149,213,5,194,69,150,41,95,19,20,136,194,120,136,238,240,208,39,2,92,90,195,104,211,150,187,67,27,1,145,195,214,68,229,228,202,23,10,170,41,91,118,243,27,165,235,104,121,173,246,85,182,65,15,134,63,41,117,0,150,49,3,228,215,89,167,57,140,71,219,132,24,140,56,4,225,92,167,32,30,77,171,30,117,174,134,203,106,50,251,155,235,104,61,147,43,195,9,191,220,73,203,42,85,162,163,11,237,227,190,189,27,244,207,244,189,6,2,231,104,170,79,246,6,188,117,237,144,121,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a511b31e-183b-4598-8779-cb3b9b29d3bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3f58ae3-ce37-4aa2-a398-281f53c214a8"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(245, 56),
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

		protected override SchemaMethod CreateBaseApplyModuleFiltersMethod() {
			SchemaMethod method = base.CreateBaseApplyModuleFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,209,110,211,48,20,125,238,164,253,131,219,7,212,136,213,107,183,110,93,85,237,161,237,186,169,210,52,85,237,96,15,211,30,76,115,219,69,164,113,176,157,65,180,85,130,241,8,18,239,124,6,2,105,48,52,126,33,253,35,110,236,54,109,96,67,69,130,72,81,98,251,248,222,115,207,61,246,5,19,196,103,67,104,123,82,49,175,15,100,151,116,112,72,15,132,99,211,206,226,2,147,228,24,132,96,146,15,20,61,129,103,117,223,167,13,38,33,70,198,192,94,255,28,70,236,137,4,209,228,158,18,220,173,173,174,56,3,146,207,182,101,151,115,181,207,93,27,4,121,244,136,152,191,182,77,178,187,228,32,192,52,173,145,175,66,139,92,174,174,100,46,144,206,192,172,123,3,142,100,14,96,186,51,30,231,45,140,153,137,247,16,59,244,216,200,233,155,181,227,208,7,140,183,75,60,120,169,67,230,115,219,91,205,122,177,90,222,46,20,139,59,229,66,121,167,82,46,52,74,165,74,161,89,218,44,85,171,245,253,205,70,117,43,167,195,197,28,23,83,98,148,192,117,201,213,21,217,107,28,225,31,125,202,220,0,104,235,69,192,92,185,128,60,45,158,89,49,42,59,159,162,135,224,13,213,249,12,187,97,214,243,9,171,212,102,122,204,123,74,56,222,48,111,89,214,108,203,61,101,89,70,25,45,141,205,20,235,241,64,232,62,45,182,141,238,37,43,181,25,216,100,107,121,202,81,161,105,14,110,154,71,160,102,174,70,204,147,222,213,228,110,48,242,16,255,123,16,106,214,36,197,214,52,194,35,54,130,124,174,23,74,67,217,72,154,233,129,218,3,197,28,119,223,113,21,8,106,62,49,22,67,230,12,212,204,229,254,128,63,132,129,106,189,242,5,72,233,112,79,78,251,75,164,86,237,244,12,41,147,251,159,75,3,65,166,94,159,41,173,127,178,233,146,204,217,210,28,121,156,42,152,118,97,0,2,80,208,105,173,88,99,71,56,35,38,66,3,208,229,90,100,76,172,49,18,127,152,122,215,25,158,43,109,28,100,61,51,124,210,25,28,207,251,181,168,70,186,65,205,64,32,23,133,46,9,250,42,16,48,141,45,241,235,217,51,233,83,98,26,245,99,71,63,156,34,107,12,62,117,85,102,153,124,93,24,241,11,120,56,166,73,59,78,44,52,171,229,87,109,154,2,152,2,51,200,207,19,175,105,243,101,214,215,163,143,209,93,244,121,141,68,223,162,187,201,53,190,175,39,239,162,175,122,24,125,143,126,68,55,209,109,116,131,147,111,163,47,147,235,201,155,201,7,18,163,162,219,201,251,24,66,162,79,228,132,139,231,210,103,120,62,154,221,82,101,163,178,81,210,161,245,149,54,189,154,60,232,43,180,19,77,160,180,109,79,25,104,93,116,45,203,168,82,183,241,68,47,212,159,58,143,29,193,251,232,91,218,139,13,196,125,16,42,212,118,192,179,2,46,50,0,123,230,138,220,90,98,16,29,7,101,28,155,155,115,241,226,156,95,143,203,222,1,255,223,104,127,227,179,127,102,51,35,207,146,90,183,101,90,237,88,79,212,59,37,108,237,39,154,137,233,211,3,7,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetModuleRowConfigMethod() {
			SchemaMethod method = base.CreateGetModuleRowConfigMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,206,207,75,203,76,87,176,85,72,74,44,78,213,115,79,45,241,205,79,41,205,73,13,202,47,119,6,203,104,228,130,249,154,214,92,197,37,69,153,121,233,209,177,10,41,69,137,233,33,137,233,197,64,77,121,169,229,10,112,241,106,5,165,224,202,98,159,252,252,236,210,2,37,133,90,107,5,46,136,225,122,142,41,41,80,195,64,234,93,18,75,18,131,243,75,139,146,65,150,184,64,205,130,200,135,37,230,148,166,106,192,204,215,4,90,90,148,90,82,90,148,7,117,165,53,0,98,2,219,173,177,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnPageLoadComleteMethod() {
			SchemaMethod method = base.CreateOnPageLoadComleteMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,202,49,14,194,48,16,68,209,158,83,160,84,73,227,11,164,195,164,3,5,41,226,0,139,25,5,43,48,27,173,215,18,220,158,64,251,254,191,22,88,84,18,201,179,50,28,15,19,82,181,236,159,129,115,38,66,124,32,45,81,56,188,55,119,140,43,76,126,103,219,108,120,22,202,140,147,234,82,215,210,116,253,206,224,213,184,191,73,65,24,121,249,71,185,71,125,61,225,104,187,254,11,172,245,19,71,110,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LookupsModulePageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80fb313e-2d80-4fe8-959d-5d6d16343b42"));
		}

		#endregion

	}

	#endregion

}

