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

	#region Class: SysSettingsModulePageSchema

	/// <exclude/>
	public class SysSettingsModulePageSchema : Terrasoft.WebApp.BaseModulePageSchema
	{

		#region Constructors: Public

		public SysSettingsModulePageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysSettingsModulePageSchema(SysSettingsModulePageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		private void UpdateGrid() {
			Grid.PageSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
			Grid.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
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
			RightControlLayout.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
			RealUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
			Name = "SysSettingsModulePage";
			ParentSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSettingsModulePageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateSysSettingsModulePageEventsProcessSchema() {
			var schema = new SysSettingsModulePageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new SysSettingsModulePageSchemaUserControl();
		}

		public override object Clone() {
			return new SysSettingsModulePageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysSettingsModulePageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsModulePageEventsProcess

	/// <exclude/>
	public class SysSettingsModulePageEventsProcess<TPage> : Terrasoft.WebApp.BaseModulePageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysSettingsModulePageSchemaUserControl
	{

		public SysSettingsModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSettingsModulePageEventsProcess";
			SchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2");
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

		private ProcessFlowElement _pageLoadCompleteSubProcess;
		public ProcessFlowElement PageLoadCompleteSubProcess {
			get {
				return _pageLoadCompleteSubProcess ?? (_pageLoadCompleteSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteSubProcess",
					SchemaElementUId = new Guid("2ac4e48c-b1ed-4873-a464-59c651fcfba4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childPageLoadComplete;
		public ProcessFlowElement ChildPageLoadComplete {
			get {
				return _childPageLoadComplete ?? (_childPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildPageLoadComplete",
					SchemaElementUId = new Guid("30b1bf34-48a4-4c25-b74d-d609f10896b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _childPageLoadCompleteScript;
		public ProcessScriptTask ChildPageLoadCompleteScript {
			get {
				return _childPageLoadCompleteScript ?? (_childPageLoadCompleteScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildPageLoadCompleteScript",
					SchemaElementUId = new Guid("82466b7c-846f-4ef8-9490-b823a9fd4f79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildPageLoadCompleteScriptExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _parentPageLoadComplete;
		public ProcessThrowMessageEvent ParentPageLoadComplete {
			get {
				return _parentPageLoadComplete ?? (_parentPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ParentPageLoadComplete",
					SchemaElementUId = new Guid("3886ff92-8912-4b9e-8398-8f57aa9b2ff8"),
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
			FlowElements[PageLoadCompleteSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteSubProcess };
			FlowElements[ChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadComplete };
			FlowElements[ChildPageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadCompleteScript };
			FlowElements[ParentPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ParentPageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadCompleteSubProcess":
						break;
					case "ChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ChildPageLoadCompleteScript");
						break;
					case "ChildPageLoadCompleteScript":
						e.Context.QueueTasks.Enqueue("ParentPageLoadComplete");
						break;
					case "ParentPageLoadComplete":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildPageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PageLoadCompleteSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadComplete";
					result = ChildPageLoadComplete.Execute(context);
					break;
				case "ChildPageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadCompleteScript";
					result = ChildPageLoadCompleteScript.Execute(context, ChildPageLoadCompleteScriptExecute);
					break;
				case "ParentPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ParentPageLoadComplete.Execute(context);
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

		public virtual bool ChildPageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			FolderEntitySchemaUId = new Guid("81996156-45E6-40DE-931E-6DDC6F75CD7E");
			return true;
		}

		public override void BaseApplyModuleFilters() {
			var pageInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var dataSource = pageInstance.DataSource;
			if (!IsRootFolder && FolderId != Guid.Empty) {
				var folderInfo = GetFolderInfo();
				Guid dynamicFolderTypeId = new Guid("65CA0946-0084-4874-B117-C13199AF3B95");
				if (folderInfo == null || DBNull.Value.Equals(folderInfo[0]) || !folderInfo.Length.Equals(2) || !(new Guid(folderInfo[0].ToString())).Equals(dynamicFolderTypeId)) {				
					var folderEntitySchema = dataSource.Schema;
					SetDetailFilter.FilterName = "FolderFilter";
					SetDetailFilter.FilterLeftExpressions = new  string[] {"SysFolder"};			
					SetDetailFilter.FilterRightValue = FolderId;
					var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
					if (oldDataSourceFolderFilter != null) {
						dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
					}
					var filter = SetDetailFilter.CreateFilter(dataSource, Guid.Empty, null);
					dataSource.CurrentStructure.Filters.Add(filter);		
				}
			}
			if (IsRootFolder) {
				var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
			}
			pageInstance.Process.SetPropertyValue("SelectedFolderId", FolderId);
			var primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
			var structure = dataSource.CurrentStructure;
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = null;
			string codeName = "CustomSettingsFilter";
			var enableContextHelpSysSettingUId = new Guid("D4DF3F32-F46B-1410-D696-485B39C17F9B");
			var oldFilters = structure.Filters.FindByName(codeName);
			if (oldFilters != null) {
				structure.Filters.Remove(oldFilters);
			}
			filters = structure.CreateFiltersGroup(codeName, LogicalOperationStrict.And);
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.NotEqual,
				primaryColumnName, enableContextHelpSysSettingUId));
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.Equal,
				"IsPersonal", new object[] {false}));
			structure.Filters.Add(filters);
		}

		public override DataSourceRowConfig GetModuleRowConfig(Entity module) {
			var treeGrid = Page.Grid.FindPageControlByName("TreeGrid") as TreeGrid;
			treeGrid.ImageList = "Terrasoft.WebApp";
			string primaryColumnName = module.Schema.PrimaryColumn.Name;
			string primaryColumnValue = module.GetColumnValue(primaryColumnName).ToString();
			var valueTypeName = module.GetTypedColumnValue<string>("ValueTypeName");
			var icons = new Dictionary<string, ImageConfigValue>();
			var config = new DataSourceRowConfig(primaryColumnValue);
			var imageName = string.Format("{0}column.png", valueTypeName.ToLower()); 
			icons.Add("valueTypeIcon", new ImageConfigValue(imageName));
			config.AddConfig(new DataSourceRowFirstColumnIconsConfigValue(icons));
			var dataSource = Page.Grid.FindPageControlByName("DataSource") as DataSource;
			var schemaName = dataSource.Schema.Name;
			string[] dragTags = new string[] {schemaName}; 
			config.AddConfig(new DataSourceRowDragTagsConfigValue(dragTags));
			return config;
			
			
			/*var valueTypeName = row.GetTypedColumnValue<string>("ValueTypeName");
			var imageName = string.Empty;
			var icons = new Dictionary<string, ImageConfigValue>();
			var config = new DataSourceRowConfig(primaryColumnValue);
			imageName = string.Format("{0}column.png", valueTypeName.ToLower()); 
			icons.Add("valueTypeIcon", new ImageConfigValue(imageName));
			config.AddConfig(new DataSourceRowFirstColumnIconsConfigValue(icons));*/
		}

		public override bool OnPageLoadComlete() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return base.OnPageLoadComlete();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("ChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("ChildPageLoadComplete");
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

	#region Class: SysSettingsModulePageEventsProcess

	/// <exclude/>
	public class SysSettingsModulePageEventsProcess : SysSettingsModulePageEventsProcess<Terrasoft.WebApp.SysSettingsModulePageSchemaUserControl>
	{

		public SysSettingsModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSettingsModulePageSchemaUserControl

	/// <exclude/>
	public partial class SysSettingsModulePageSchemaUserControl : Terrasoft.WebApp.BaseModulePageSchemaUserControl
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
			var process = (SysSettingsModulePageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysSettingsModulePageEventsProcess(UserConnection);
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
			SchemaName = "SysSettingsModulePage";
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsModulePageEventsProcessSchema

	/// <exclude/>
	public class SysSettingsModulePageEventsProcessSchema : Terrasoft.WebApp.BaseModulePageEventsProcessSchema
	{

		#region Constructors: Public

		public SysSettingsModulePageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSettingsModulePageEventsProcessSchema(SysSettingsModulePageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSettingsModulePageEventsProcess";
			UId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0");
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
			ProcessSchemaLaneSet schemaLaneSet292 = CreateLaneSet292LaneSet();
			LaneSets.Add(schemaLaneSet292);
			ProcessSchemaLane schemaLane878 = CreateLane878Lane();
			schemaLaneSet292.Lanes.Add(schemaLane878);
			ProcessSchemaEventSubProcess pageloadcompletesubprocess = CreatePageLoadCompleteSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletesubprocess);
			ProcessSchemaStartMessageEvent childpageloadcomplete = CreateChildPageLoadCompleteStartMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(childpageloadcomplete);
			ProcessSchemaScriptTask childpageloadcompletescript = CreateChildPageLoadCompleteScriptScriptTask();
			pageloadcompletesubprocess.FlowElements.Add(childpageloadcompletescript);
			ProcessSchemaIntermediateThrowMessageEvent parentpageloadcomplete = CreateParentPageLoadCompleteIntermediateThrowMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(parentpageloadcomplete);
			FlowElements.Add(CreateSequenceFlow5261SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5262SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5261SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5261",
				UId = new Guid("e9b19657-a95e-4d84-9f89-6fc61e78e1fc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				CurveCenterPosition = new Point(158, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("30b1bf34-48a4-4c25-b74d-d609f10896b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("82466b7c-846f-4ef8-9490-b823a9fd4f79"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5262SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5262",
				UId = new Guid("8aa147a9-a1bd-4a57-af1e-1a92d0552e19"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				CurveCenterPosition = new Point(276, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("82466b7c-846f-4ef8-9490-b823a9fd4f79"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3886ff92-8912-4b9e-8398-8f57aa9b2ff8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet292LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet292 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0437b498-1d3c-46e8-871d-70654f021128"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				Name = @"LaneSet292",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(881, 170),
				UseBackgroundMode = false
			};
			return schemaLaneSet292;
		}

		protected virtual ProcessSchemaLane CreateLane878Lane() {
			ProcessSchemaLane schemaLane878 = new ProcessSchemaLane(this) {
				UId = new Guid("e0fca235-e5ca-4fc7-8072-258c86027723"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0437b498-1d3c-46e8-871d-70654f021128"),
				CreatedInOwnerSchemaUId = new Guid("23b58396-1953-4eea-8b00-53b36eebb8f2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				Name = @"Lane878",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(852, 170),
				UseBackgroundMode = false
			};
			return schemaLane878;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2ac4e48c-b1ed-4873-a464-59c651fcfba4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0fca235-e5ca-4fc7-8072-258c86027723"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				Name = @"PageLoadCompleteSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(292, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("30b1bf34-48a4-4c25-b74d-d609f10896b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ac4e48c-b1ed-4873-a464-59c651fcfba4"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				Name = @"ChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildPageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("82466b7c-846f-4ef8-9490-b823a9fd4f79"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ac4e48c-b1ed-4873-a464-59c651fcfba4"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				Name = @"ChildPageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,207,73,73,45,114,205,43,201,44,169,12,78,206,72,205,77,12,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,178,48,180,180,52,51,52,53,211,53,49,117,5,18,6,46,174,186,150,198,134,174,186,102,46,46,206,102,110,230,166,206,46,230,174,74,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,207,51,235,160,86,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateParentPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3886ff92-8912-4b9e-8398-8f57aa9b2ff8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ac4e48c-b1ed-4873-a464-59c651fcfba4"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"),
				Name = @"ParentPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 58),
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
				UId = new Guid("f33b9e5a-e3d9-48f8-9873-d06b99ebb2bf"),
				Name = "System.Data",
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
				UId = new Guid("4f4e87f2-cbea-46f5-9638-47e9d7e0a0c0"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,85,81,111,218,48,16,126,102,210,254,131,201,195,148,72,96,193,160,180,168,234,3,132,210,33,85,29,42,237,250,80,237,193,77,14,200,148,216,153,237,116,67,107,255,251,206,113,66,66,105,187,77,218,52,94,136,237,243,119,223,221,125,119,190,103,146,164,108,5,51,174,52,227,1,144,19,50,199,37,61,147,81,72,231,245,3,166,200,21,72,201,148,88,106,122,3,119,163,52,165,99,166,192,88,26,195,69,176,134,132,93,43,144,190,224,90,138,248,248,237,155,123,68,15,153,102,11,145,201,28,187,238,138,78,182,39,104,26,45,137,219,156,169,75,33,244,84,196,33,72,242,238,29,177,95,179,144,52,79,200,89,134,140,78,147,84,111,60,242,227,237,155,134,193,94,218,115,190,20,136,125,6,197,77,179,118,61,196,108,152,59,36,220,112,150,68,129,61,187,218,164,128,120,39,132,195,183,28,210,117,6,7,254,168,51,236,15,218,157,206,81,191,221,63,58,236,183,199,221,238,97,219,239,246,186,195,225,104,218,27,15,15,156,28,206,112,172,187,68,148,44,142,201,195,3,153,140,47,240,139,126,98,113,6,244,244,107,198,98,85,179,188,237,124,246,140,85,179,218,162,231,192,87,122,93,218,190,183,231,238,150,213,206,101,122,37,22,90,70,124,229,122,158,87,94,121,38,44,15,51,211,192,31,82,173,165,231,148,235,72,111,108,121,48,240,170,30,212,238,153,200,26,11,208,19,208,44,138,167,81,172,65,82,251,119,193,18,83,53,199,58,177,123,206,43,246,231,176,212,167,223,83,9,74,69,130,171,34,205,68,229,228,111,63,147,31,206,98,163,44,152,243,120,92,48,125,30,234,50,90,173,117,158,79,68,41,117,112,92,70,134,235,74,61,117,118,187,1,250,153,148,192,53,38,47,11,116,38,161,192,86,248,207,195,241,198,132,231,238,6,151,215,57,47,244,203,46,154,182,238,86,134,141,198,239,248,187,132,68,220,195,203,152,214,237,227,182,112,101,44,79,115,227,75,96,26,236,194,173,28,183,106,221,209,178,228,114,192,223,161,54,10,81,109,5,137,188,32,200,226,209,246,99,189,29,171,166,251,183,185,255,147,212,255,181,204,219,144,119,134,211,92,138,0,101,76,177,2,248,153,130,212,155,92,141,174,179,128,24,2,13,97,41,74,167,181,213,167,87,204,188,84,70,9,147,27,95,196,89,194,139,38,218,235,59,116,81,179,162,198,172,184,174,202,40,94,207,40,90,87,19,249,122,102,134,114,49,122,21,221,126,212,162,206,227,69,111,134,62,182,103,161,178,188,75,49,167,136,102,251,148,4,34,132,178,243,253,76,105,145,96,18,52,158,168,106,2,24,154,192,217,93,12,198,19,124,215,31,32,78,177,185,11,203,235,39,51,118,210,159,76,123,211,222,251,246,180,63,24,183,187,253,110,167,61,25,12,7,56,109,15,198,189,161,223,61,156,14,199,78,153,61,76,230,116,75,77,189,166,159,146,169,87,60,32,181,155,59,74,217,7,169,100,81,236,24,8,212,192,242,25,199,245,166,83,103,82,100,233,214,113,139,156,139,85,20,176,248,35,42,132,153,172,154,65,29,104,58,226,185,24,150,181,38,123,30,240,38,210,235,57,147,136,101,12,221,61,149,180,106,175,174,47,240,114,62,206,35,80,180,172,103,146,50,25,41,193,205,27,64,47,132,206,223,135,22,70,189,167,194,214,47,74,230,253,23,202,91,190,206,76,205,17,80,112,22,99,79,25,241,136,187,47,168,85,243,112,44,241,201,131,199,156,224,126,49,171,17,134,101,252,9,67,66,30,204,210,8,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetModuleRowConfigMethod() {
			SchemaMethod method = base.CreateGetModuleRowConfigMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,146,193,107,194,48,20,198,239,253,43,66,78,169,72,220,189,155,176,233,20,65,134,204,226,14,99,135,172,141,93,192,38,229,53,181,20,241,127,95,210,166,182,78,97,99,151,193,110,237,227,125,191,247,189,151,111,207,0,105,224,124,14,34,70,119,104,197,18,78,237,55,157,9,25,219,191,137,146,26,212,238,161,122,98,41,39,56,116,189,216,71,44,71,237,95,224,181,12,186,72,141,104,41,114,109,104,56,228,0,44,87,91,77,95,248,251,125,150,225,192,203,53,8,153,160,12,68,202,160,154,168,93,145,74,139,54,237,169,138,139,29,167,235,232,131,167,140,174,250,29,212,182,92,23,111,216,174,232,169,231,92,247,234,228,98,142,79,67,181,174,49,196,15,188,189,89,127,111,27,195,42,227,231,54,12,200,22,227,30,237,182,153,63,38,120,211,215,96,7,18,145,146,185,1,72,94,162,169,136,180,80,210,140,118,162,33,170,47,99,206,185,21,73,45,31,183,6,162,186,214,10,153,102,107,85,64,196,159,85,217,116,147,203,125,219,137,22,233,108,55,99,232,76,65,202,52,193,135,155,99,212,156,46,147,9,30,158,111,105,110,176,84,37,7,226,251,1,242,106,223,244,62,142,9,62,117,45,76,205,168,172,163,175,190,201,105,170,81,123,141,121,171,118,102,47,150,152,9,200,221,155,88,106,126,134,178,5,223,109,19,159,84,63,73,98,55,163,201,98,247,223,208,242,58,70,238,56,29,186,141,87,63,80,175,111,40,6,150,132,44,105,159,239,84,63,116,152,163,57,213,247,219,78,29,168,191,101,11,183,139,2,215,5,72,247,230,129,231,121,163,193,181,16,130,42,127,147,192,203,60,60,166,153,174,254,34,159,255,38,155,131,209,39,63,190,184,124,37,5,0,0 };
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
			return new SysSettingsModulePageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5c7be10-5a52-4278-b5dc-fff0fd95f6a0"));
		}

		#endregion

	}

	#endregion

}

