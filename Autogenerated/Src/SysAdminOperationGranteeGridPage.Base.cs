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

	#region Class: SysAdminOperationGranteeGridPageSchema

	/// <exclude/>
	public class SysAdminOperationGranteeGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public SysAdminOperationGranteeGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysAdminOperationGranteeGridPageSchema(SysAdminOperationGranteeGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Hidden = true;
			AddButton.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.Hidden = true;
			DeleteButton.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Enabled = false;
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.FooterVisible = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
			RealUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
			Name = "SysAdminOperationGranteeGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminOperationGranteeGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateSysAdminOperationGranteeGridPageEventsProcessSchema() {
			var schema = new SysAdminOperationGranteeGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a");
			DataSource.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("712012a7-c931-4b7c-a9ac-9f2e954e2566");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
				column.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a64eb826-4dc1-45fb-a5ac-d768275eb719");
			if (column != null) {
				column.UId = new Guid("38bd2c89-2f3f-41c3-a16c-a739d2a3ae5b");
				column.Name = @"SysAdminOperation";
				column.CreatedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
				column.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e1f978af-3b07-4c9f-a422-c6170cd1b1a4");
			if (column != null) {
				column.UId = new Guid("9962d25f-0e21-4364-b28d-9ae1ad687cb7");
				column.Name = @"CanExecute";
				column.CreatedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
				column.ModifiedInSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
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
			return new SysAdminOperationGranteeGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysAdminOperationGranteeGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysAdminOperationGranteeGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminOperationGranteeGridPageEventsProcess

	/// <exclude/>
	public class SysAdminOperationGranteeGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysAdminOperationGranteeGridPageSchemaUserControl
	{

		public SysAdminOperationGranteeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminOperationGranteeGridPageEventsProcess";
			SchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b");
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

		private ProcessFlowElement _eventSubProcessChildInit;
		public ProcessFlowElement EventSubProcessChildInit {
			get {
				return _eventSubProcessChildInit ?? (_eventSubProcessChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildInit",
					SchemaElementUId = new Guid("1aad9b7d-9bb7-4fac-8b55-8c78ba790d77"),
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
					SchemaElementUId = new Guid("de5f1f87-bf87-4133-8530-90de8897b265"),
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
					SchemaElementUId = new Guid("54afe525-a3c4-42da-ab2d-f918cdea1f5e"),
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
					SchemaElementUId = new Guid("2b19283a-f57b-4243-891a-66f4f7d22a57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildBasePrepareFilters;
		public ProcessFlowElement EventSubProcessChildBasePrepareFilters {
			get {
				return _eventSubProcessChildBasePrepareFilters ?? (_eventSubProcessChildBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildBasePrepareFilters",
					SchemaElementUId = new Guid("fd56a882-9342-43b5-a7f5-01421aa52e98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startChildBasePrepareFilters;
		public ProcessFlowElement StartChildBasePrepareFilters {
			get {
				return _startChildBasePrepareFilters ?? (_startChildBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartChildBasePrepareFilters",
					SchemaElementUId = new Guid("81761bb5-f36f-4442-9387-a77ea4c85af4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildBasePrepareFilters;
		public ProcessScriptTask ScriptChildBasePrepareFilters {
			get {
				return _scriptChildBasePrepareFilters ?? (_scriptChildBasePrepareFilters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildBasePrepareFilters",
					SchemaElementUId = new Guid("ea8b6eb4-f2d2-4b93-a591-b91d1012c73b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildBasePrepareFiltersExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildInit };
			FlowElements[StartMessageChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[IntermediateThrowBaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseInit };
			FlowElements[EventSubProcessChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildBasePrepareFilters };
			FlowElements[StartChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { StartChildBasePrepareFilters };
			FlowElements[ScriptChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildBasePrepareFilters };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessChildInit":
						break;
					case "StartMessageChildInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseInit");
						break;
					case "IntermediateThrowBaseInit":
						break;
					case "EventSubProcessChildBasePrepareFilters":
						break;
					case "StartChildBasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ScriptChildBasePrepareFilters");
						break;
					case "ScriptChildBasePrepareFilters":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageChildInit");
			ActivatedEventElements.Add("StartChildBasePrepareFilters");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessChildInit":
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
				case "EventSubProcessChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					break;
				case "StartChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartChildBasePrepareFilters";
					result = StartChildBasePrepareFilters.Execute(context);
					break;
				case "ScriptChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildBasePrepareFilters";
					result = ScriptChildBasePrepareFilters.Execute(context, ScriptChildBasePrepareFiltersExecute);
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

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			Page.DataSource.Loaded += Page.TreeGrid.DataLoaded;
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			Page.TreeGrid.GetRowConfigHandler =	delegate(Terrasoft.Core.Entities.Entity row) {			
				string primaryColumnName = row.Schema.PrimaryColumn.Name;		
				Guid primaryColumnValue =	row.GetTypedColumnValue<Guid>(primaryColumnName);
				var config = new DataSourceRowConfig(primaryColumnValue.ToString());
				bool canExecute = row.GetTypedColumnValue<bool>("CanExecute");
				var icons = new Dictionary<string, ImageConfigValue>();
				string columnIconImageName = canExecute ? "Allow.png" : "Deny.png";
				var imageConfig = new ImageConfigValue(columnIconImageName);
				imageConfig.DisplayImageOnly = true;
				imageConfig.ImagePosition = ImagePosition.Center;
				icons.Add("CanExecute", imageConfig);
				var iconConfig = new DataSourceRowColumnIconsConfigValue(icons);
				config.AddConfig(iconConfig);
				return config;
			};
			return true;
		}

		public virtual bool ScriptChildBasePrepareFiltersExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			string filterCode = string.Empty;
			var viewFilterGroup = dataSource.FindFiltersGroupByName("ViewFilters");
			if (viewFilterGroup != null) {
				foreach (var filter in viewFilterGroup) {
					if (filter.IsEnabled) {
						filterCode = filter.Name;
						break;
					}
				}
				foreach (var filter in dataSource.CurrentStructure.Filters) {
					filter.IsEnabled = filterCode != "All";
				}
				if (filterCode == "All") {
					LoadViewFilters(true);
				}
			}
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void LoadViewFilters(bool enabledFilters) {
			var dataSource = Page.DataSource;
			var structure = Page.DataSource.CurrentStructure;
			var filters = dataSource.FindFiltersGroupByName("ViewFilters");
			if (filters != null) {
				structure.Filters.Remove(filters);
			}
			filters = structure.CreateFiltersGroup("ViewFilters", LogicalOperationStrict.And);
			var filterValuesObj = Page.UserConnection.DBSecurityEngine.GetUserAdminUnitCollection(SelectedNodePrimaryColumnValue);
			object[] filterValueArray = new object[filterValuesObj.Count()];
			for (int i=0;i<filterValueArray.Length;i++) {
				filterValueArray[i] = filterValuesObj[i];
			}
			DataSourceFilterExpression leftExpression = structure.CreateDataSourceFilterExpression("SysAdminUnit");
			DataSourceFilterExpression rightExpression = structure.CreateDataSourceFilterExpression(filterValueArray);
			var filterItem = new DataSourceFilter(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.Equal,
				leftExpression, rightExpression);
			filterItem.Name = "All";
			filterItem.IsEnabled = enabledFilters;
			filters.Add(filterItem);
			structure.Filters.Add(filters);
		}

		public override string GetRegisterTreeGridDblClickScript(string defaultScript) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageChildInit")) {
							context.QueueTasks.Enqueue("StartMessageChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("StartChildBasePrepareFilters")) {
							context.QueueTasks.Enqueue("StartChildBasePrepareFilters");
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

	#region Class: SysAdminOperationGranteeGridPageEventsProcess

	/// <exclude/>
	public class SysAdminOperationGranteeGridPageEventsProcess : SysAdminOperationGranteeGridPageEventsProcess<Terrasoft.WebApp.SysAdminOperationGranteeGridPageSchemaUserControl>
	{

		public SysAdminOperationGranteeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminOperationGranteeGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysAdminOperationGranteeGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
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
			var process = (SysAdminOperationGranteeGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysAdminOperationGranteeGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysAdminOperationGranteeGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminOperationGranteeGridPageEventsProcessSchema

	/// <exclude/>
	public class SysAdminOperationGranteeGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminOperationGranteeGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminOperationGranteeGridPageEventsProcessSchema(SysAdminOperationGranteeGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminOperationGranteeGridPageEventsProcess";
			UId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19");
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
			ProcessSchemaLaneSet schemaLaneSet422 = CreateLaneSet422LaneSet();
			LaneSets.Add(schemaLaneSet422);
			ProcessSchemaLane schemaLane1268 = CreateLane1268Lane();
			schemaLaneSet422.Lanes.Add(schemaLane1268);
			ProcessSchemaEventSubProcess eventsubprocesschildinit = CreateEventSubProcessChildInitEventSubProcess();
			FlowElements.Add(eventsubprocesschildinit);
			ProcessSchemaEventSubProcess eventsubprocesschildbasepreparefilters = CreateEventSubProcessChildBasePrepareFiltersEventSubProcess();
			FlowElements.Add(eventsubprocesschildbasepreparefilters);
			ProcessSchemaStartMessageEvent startmessagechildinit = CreateStartMessageChildInitStartMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(startmessagechildinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			eventsubprocesschildinit.FlowElements.Add(scriptchildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbaseinit = CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(intermediatethrowbaseinit);
			ProcessSchemaStartMessageEvent startchildbasepreparefilters = CreateStartChildBasePrepareFiltersStartMessageEvent();
			eventsubprocesschildbasepreparefilters.FlowElements.Add(startchildbasepreparefilters);
			ProcessSchemaScriptTask scriptchildbasepreparefilters = CreateScriptChildBasePrepareFiltersScriptTask();
			eventsubprocesschildbasepreparefilters.FlowElements.Add(scriptchildbasepreparefilters);
			FlowElements.Add(CreateSequenceFlow7176SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7177SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7178SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7176SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7176",
				UId = new Guid("844a2271-72e5-41e0-8f11-6c48fbc88d74"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				CurveCenterPosition = new Point(175, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de5f1f87-bf87-4133-8530-90de8897b265"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54afe525-a3c4-42da-ab2d-f918cdea1f5e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7177SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7177",
				UId = new Guid("f8dee0da-046a-46e1-83d2-ebd764e20807"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				CurveCenterPosition = new Point(316, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54afe525-a3c4-42da-ab2d-f918cdea1f5e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b19283a-f57b-4243-891a-66f4f7d22a57"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7178SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7178",
				UId = new Guid("43c850a0-8bf6-4744-b236-6b2167b0cad3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				CurveCenterPosition = new Point(540, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81761bb5-f36f-4442-9387-a77ea4c85af4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ea8b6eb4-f2d2-4b93-a591-b91d1012c73b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet422LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet422 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5c8306e5-0aa0-43e3-a023-7f4763129e24"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"LaneSet422",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1129, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet422;
		}

		protected virtual ProcessSchemaLane CreateLane1268Lane() {
			ProcessSchemaLane schemaLane1268 = new ProcessSchemaLane(this) {
				UId = new Guid("0ad7dd50-c01f-41cc-8afc-92a6c597ff4e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5c8306e5-0aa0-43e3-a023-7f4763129e24"),
				CreatedInOwnerSchemaUId = new Guid("75ad2211-d459-47ad-bd14-b83f3b4ce10b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"Lane1268",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1100, 177),
				UseBackgroundMode = false
			};
			return schemaLane1268;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1aad9b7d-9bb7-4fac-8b55-8c78ba790d77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ad7dd50-c01f-41cc-8afc-92a6c597ff4e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"EventSubProcessChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(336, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("de5f1f87-bf87-4133-8530-90de8897b265"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1aad9b7d-9bb7-4fac-8b55-8c78ba790d77"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"StartMessageChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("54afe525-a3c4-42da-ab2d-f918cdea1f5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1aad9b7d-9bb7-4fac-8b55-8c78ba790d77"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,221,110,130,48,20,190,134,167,104,184,194,204,244,1,134,186,24,52,206,196,108,100,154,237,186,210,35,107,82,90,82,202,28,89,246,238,107,11,8,168,217,157,245,251,61,231,144,144,12,240,138,104,178,151,149,74,1,239,36,161,64,209,195,28,37,22,57,40,128,141,98,212,81,26,44,242,199,200,54,55,207,29,43,53,154,163,224,0,74,145,82,158,52,254,128,227,178,40,130,107,246,6,244,155,60,199,82,156,88,246,76,4,229,160,208,220,163,192,33,35,26,194,94,31,75,5,120,45,52,211,12,202,230,71,141,148,60,79,208,143,231,121,190,87,106,197,68,134,10,197,114,162,234,88,242,42,23,47,36,7,211,194,176,240,62,253,132,156,224,100,8,99,139,71,86,188,169,24,29,75,223,9,175,140,214,179,90,211,241,80,23,64,7,200,204,42,22,225,77,218,36,242,189,47,162,80,234,6,50,217,2,206,168,95,231,101,212,240,54,12,31,228,222,205,16,78,172,203,81,74,142,82,34,214,223,144,86,186,27,227,94,21,203,92,132,65,124,225,6,93,11,102,106,148,93,9,150,106,38,133,201,156,53,171,154,34,119,169,166,143,115,90,132,86,216,46,50,117,9,91,227,224,104,237,42,7,133,158,80,176,228,220,116,42,68,22,160,71,20,172,64,212,238,209,165,247,246,109,135,235,192,240,78,136,173,48,80,226,21,43,11,78,106,135,191,10,94,27,43,173,42,184,98,57,56,145,37,179,51,26,202,232,141,99,16,26,148,149,216,133,224,37,165,163,117,77,135,85,135,187,139,255,185,98,87,188,28,206,227,252,173,67,115,127,155,212,222,187,183,179,176,2,93,41,209,126,37,145,255,27,249,237,63,110,180,63,181,125,174,217,132,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2b19283a-f57b-4243-891a-66f4f7d22a57"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1aad9b7d-9bb7-4fac-8b55-8c78ba790d77"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"IntermediateThrowBaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildBasePrepareFiltersEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildBasePrepareFilters = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fd56a882-9342-43b5-a7f5-01421aa52e98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ad7dd50-c01f-41cc-8afc-92a6c597ff4e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"EventSubProcessChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(392, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(258, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildBasePrepareFilters;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartChildBasePrepareFiltersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("81761bb5-f36f-4442-9387-a77ea4c85af4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd56a882-9342-43b5-a7f5-01421aa52e98"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"StartChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildBasePrepareFiltersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ea8b6eb4-f2d2-4b93-a591-b91d1012c73b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd56a882-9342-43b5-a7f5-01421aa52e98"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"),
				Name = @"ScriptChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,203,106,195,48,16,60,59,144,127,216,250,100,95,252,3,38,135,54,77,74,161,148,66,160,119,197,90,39,162,138,20,214,146,75,40,249,247,174,30,56,169,161,32,132,216,153,157,135,70,65,32,133,19,59,235,169,67,88,193,135,56,96,243,60,77,218,229,98,112,164,204,1,122,165,29,210,218,202,192,74,179,102,115,58,187,11,83,70,86,25,21,126,111,35,231,133,172,63,51,233,166,219,108,149,145,9,28,34,250,116,121,23,39,172,202,207,105,105,40,107,22,82,61,84,115,161,135,21,24,175,117,13,63,203,69,209,91,66,209,29,153,197,150,41,18,40,51,55,79,220,34,168,37,78,243,58,108,140,216,107,148,25,42,254,212,201,164,144,169,141,232,158,93,190,226,243,202,215,245,127,227,187,142,107,79,132,198,237,28,249,206,121,10,165,99,177,236,56,15,50,217,198,12,92,178,124,212,186,108,179,221,45,122,138,152,225,172,245,102,133,188,251,186,138,45,177,206,171,124,8,217,223,64,152,182,191,218,27,219,85,225,1,0,0 }
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

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateLoadViewFiltersMethod() {
			SchemaMethod method = base.CreateLoadViewFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,110,219,48,12,61,215,95,161,249,228,160,129,176,187,151,67,234,166,69,129,162,45,230,182,151,34,7,197,166,29,22,178,228,81,82,58,99,216,191,79,174,237,216,113,187,29,118,147,244,30,249,200,71,234,32,136,229,194,138,84,59,202,128,173,216,131,40,129,95,30,95,226,224,224,25,198,146,203,172,163,79,8,60,113,68,160,108,58,80,186,136,2,165,5,50,158,63,102,231,87,168,242,171,14,184,38,237,234,139,230,78,84,16,133,207,8,111,253,123,184,136,3,44,88,52,196,127,89,49,229,164,92,176,95,193,217,177,10,222,147,249,119,168,244,1,6,178,15,253,29,140,194,35,61,33,16,22,166,202,167,154,75,118,171,75,204,132,188,175,129,132,69,173,124,55,152,89,190,86,249,98,218,207,179,144,14,204,253,238,117,240,225,201,0,37,90,41,200,218,40,126,121,145,66,230,8,109,179,81,37,42,224,215,96,91,202,58,175,80,61,41,180,137,150,178,227,70,41,180,39,200,239,116,14,15,132,149,160,198,163,174,82,239,34,94,86,239,94,61,225,101,59,213,94,19,137,198,139,43,120,99,61,62,171,140,39,218,41,27,45,182,113,80,104,98,17,42,203,112,245,53,198,111,243,52,252,22,84,105,247,49,158,159,191,219,59,199,95,112,235,149,102,233,253,99,235,242,56,255,206,195,205,207,154,192,24,223,23,147,80,216,201,245,227,28,254,30,27,133,105,99,142,94,181,171,240,15,29,194,114,255,223,66,243,94,79,166,124,99,161,234,61,158,167,136,38,219,156,102,123,168,196,146,61,130,207,96,116,97,189,245,94,123,163,44,90,4,211,47,105,162,171,90,16,26,173,30,155,218,163,63,156,144,203,224,236,212,165,229,188,27,95,207,88,11,111,127,137,47,40,92,75,25,158,0,55,102,163,196,78,66,238,81,232,78,253,78,15,52,195,215,121,30,141,33,62,241,199,111,52,82,252,31,250,3,249,109,153,149,18,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterTreeGridDblClickScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterTreeGridDblClickScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminOperationGranteeGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69bc6378-c84a-41a4-bdf6-0d38bd4eba19"));
		}

		#endregion

	}

	#endregion

}

