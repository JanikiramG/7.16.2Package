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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: SysSettingsGridPageSchema

	/// <exclude/>
	public class SysSettingsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public SysSettingsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysSettingsGridPageSchema(SysSettingsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
			RealUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
			Name = "SysSettingsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "269";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSettingsGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateSysSettingsGridPageEventsProcessSchema() {
			var schema = new SysSettingsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("27aeadd6-d508-4572-8061-5b55b667c902");
			DataSource.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ece07afb-f244-40c4-8082-78babd8e40e7");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("53e645cc-acb9-40b1-9c2a-573b163592e7");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("723b0e0e-6559-41b3-a428-89d4ade0d436");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f7960a8a-1fd4-41d2-997a-fd78ea60075f");
			if (column != null) {
				column.UId = new Guid("94caac6a-46a6-4b1d-8a66-d7fa144a7b2b");
				column.Name = @"ValueTypeName";
				column.CreatedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.ModifiedInSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
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
			return new SysSettingsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysSettingsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysSettingsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsGridPageEventsProcess

	/// <exclude/>
	public class SysSettingsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysSettingsGridPageSchemaUserControl
	{

		public SysSettingsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSettingsGridPageEventsProcess";
			SchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d");
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

		private ProcessFlowElement _eventSubProcess1ChildInit;
		public ProcessFlowElement EventSubProcess1ChildInit {
			get {
				return _eventSubProcess1ChildInit ?? (_eventSubProcess1ChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1ChildInit",
					SchemaElementUId = new Guid("6e3f0e2c-601a-4a9e-b448-3eb431fc3880"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _parentInit;
		public ProcessThrowMessageEvent ParentInit {
			get {
				return _parentInit ?? (_parentInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ParentInit",
					SchemaElementUId = new Guid("45281952-5db7-459a-a8fb-c321853ccb5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childInitScript;
		public ProcessScriptTask ChildInitScript {
			get {
				return _childInitScript ?? (_childInitScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildInitScript",
					SchemaElementUId = new Guid("c2868ac6-649c-415c-b35c-1b979e4bb2fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildInitScriptExecute,
				});
			}
		}

		private ProcessFlowElement _childInit;
		public ProcessFlowElement ChildInit {
			get {
				return _childInit ?? (_childInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInit",
					SchemaElementUId = new Guid("a67cb3c2-e22b-4d29-b9ac-cbafcbd8f627"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8DBFL;
		public ProcessFlowElement EventSubProcess8DBFL {
			get {
				return _eventSubProcess8DBFL ?? (_eventSubProcess8DBFL = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8DBFL",
					SchemaElementUId = new Guid("f3bac84b-a11c-451b-b1b6-dad659ba2c58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeLoad;
		public ProcessFlowElement DataSourceBeforeLoad {
			get {
				return _dataSourceBeforeLoad ?? (_dataSourceBeforeLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeLoad",
					SchemaElementUId = new Guid("c3f6d46e-c478-4f85-911a-e45be7053add"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dataSourceBeforeLoadScript;
		public ProcessScriptTask DataSourceBeforeLoadScript {
			get {
				return _dataSourceBeforeLoadScript ?? (_dataSourceBeforeLoadScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceBeforeLoadScript",
					SchemaElementUId = new Guid("ac754928-cc4e-4970-bd1f-87199d070bb3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceBeforeLoadScriptExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1ChildInit };
			FlowElements[ParentInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ParentInit };
			FlowElements[ChildInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitScript };
			FlowElements[ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInit };
			FlowElements[EventSubProcess8DBFL.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8DBFL };
			FlowElements[DataSourceBeforeLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeLoad };
			FlowElements[DataSourceBeforeLoadScript.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeLoadScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1ChildInit":
						break;
					case "ParentInit":
						break;
					case "ChildInitScript":
						e.Context.QueueTasks.Enqueue("ParentInit");
						break;
					case "ChildInit":
						e.Context.QueueTasks.Enqueue("ChildInitScript");
						break;
					case "EventSubProcess8DBFL":
						break;
					case "DataSourceBeforeLoad":
						e.Context.QueueTasks.Enqueue("DataSourceBeforeLoadScript");
						break;
					case "DataSourceBeforeLoadScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildInit");
			ActivatedEventElements.Add("DataSourceBeforeLoad");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1ChildInit":
					context.QueueTasks.Dequeue();
					break;
				case "ParentInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ParentInit.Execute(context);
					break;
				case "ChildInitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitScript";
					result = ChildInitScript.Execute(context, ChildInitScriptExecute);
					break;
				case "ChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInit";
					result = ChildInit.Execute(context);
					break;
				case "EventSubProcess8DBFL":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeLoad";
					result = DataSourceBeforeLoad.Execute(context);
					break;
				case "DataSourceBeforeLoadScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeLoadScript";
					result = DataSourceBeforeLoadScript.Execute(context, DataSourceBeforeLoadScriptExecute);
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

		public virtual bool ChildInitScriptExecute(ProcessExecutingContext context) {
			Page.DataSource.BeforeLoad +=
			 delegate(object sender, DataSourceEventArgs e) {
				Page.ThrowEvent("DataSourceBeforeLoad");
			};
			EditPageUId = new Guid("2b9eeb27-9ec7-4f90-9f42-ab854862f02b");
			//ToDo: CR 100178
			var dataSource = Page.DataSource;
			var primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
			var structure = dataSource.CurrentStructure;
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = null;
			string codeName = "HelpContextFilter";
			var enableContextHelpSysSettingUId = new Guid("D4DF3F32-F46B-1410-D696-485B39C17F9B");
			var buildTypeSysSettingUId = new Guid("DC1317E4-D9E7-4483-B03F-2F5734F12BF8");
			var oldFilters = structure.Filters.FindByName(codeName);
			if (oldFilters != null) {
				structure.Filters.Remove(oldFilters);
			}
			filters = structure.CreateFiltersGroup(codeName, LogicalOperationStrict.And);
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.NotEqual,
				primaryColumnName, enableContextHelpSysSettingUId));
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.NotEqual,
				primaryColumnName, buildTypeSysSettingUId));
			structure.Filters.Add(filters);
			return true;
		}

		public virtual bool DataSourceBeforeLoadScriptExecute(ProcessExecutingContext context) {
			/*Page.TreeGrid.ImageList = "Terrasoft.WebApp";  
			Page.TreeGrid.GetRowConfigHandler =
				delegate(Terrasoft.Core.Entities.Entity row) {
					string primaryColumnName = row.Schema.PrimaryColumn.Name;
					string primaryColumnValue =	row.GetColumnValue(primaryColumnName).ToString();
					var valueTypeName = row.GetTypedColumnValue<string>("ValueTypeName");
					var imageName = string.Empty;
					var icons = new Dictionary<string, ImageConfigValue>();
					var config = new DataSourceRowConfig(primaryColumnValue);
					imageName = string.Format("{0}column.png", valueTypeName.ToLower()); 
					icons.Add("valueTypeIcon", new ImageConfigValue(imageName));
					config.AddConfig(new DataSourceRowFirstColumnIconsConfigValue(icons));
					return config;
			};
			Page.DataSource.Loaded += Page.TreeGrid.DataLoaded;*/
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ChildInit")) {
							context.QueueTasks.Enqueue("ChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceBeforeLoad":
							if (ActivatedEventElements.Contains("DataSourceBeforeLoad")) {
							context.QueueTasks.Enqueue("DataSourceBeforeLoad");
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

	#region Class: SysSettingsGridPageEventsProcess

	/// <exclude/>
	public class SysSettingsGridPageEventsProcess : SysSettingsGridPageEventsProcess<Terrasoft.WebApp.SysSettingsGridPageSchemaUserControl>
	{

		public SysSettingsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSettingsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysSettingsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
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
			var process = (SysSettingsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysSettingsGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysSettingsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysSettingsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysSettingsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSettingsGridPageEventsProcessSchema(SysSettingsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSettingsGridPageEventsProcess";
			UId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9");
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
			ProcessSchemaLaneSet schemaLaneSet527 = CreateLaneSet527LaneSet();
			LaneSets.Add(schemaLaneSet527);
			ProcessSchemaLane schemaLane1786 = CreateLane1786Lane();
			schemaLaneSet527.Lanes.Add(schemaLane1786);
			ProcessSchemaEventSubProcess eventsubprocess1childinit = CreateEventSubProcess1ChildInitEventSubProcess();
			FlowElements.Add(eventsubprocess1childinit);
			ProcessSchemaEventSubProcess eventsubprocess8dbfl = CreateEventSubProcess8DBFLEventSubProcess();
			FlowElements.Add(eventsubprocess8dbfl);
			ProcessSchemaIntermediateThrowMessageEvent parentinit = CreateParentInitIntermediateThrowMessageEvent();
			eventsubprocess1childinit.FlowElements.Add(parentinit);
			ProcessSchemaScriptTask childinitscript = CreateChildInitScriptScriptTask();
			eventsubprocess1childinit.FlowElements.Add(childinitscript);
			ProcessSchemaStartMessageEvent childinit = CreateChildInitStartMessageEvent();
			eventsubprocess1childinit.FlowElements.Add(childinit);
			ProcessSchemaStartMessageEvent datasourcebeforeload = CreateDataSourceBeforeLoadStartMessageEvent();
			eventsubprocess8dbfl.FlowElements.Add(datasourcebeforeload);
			ProcessSchemaScriptTask datasourcebeforeloadscript = CreateDataSourceBeforeLoadScriptScriptTask();
			eventsubprocess8dbfl.FlowElements.Add(datasourcebeforeloadscript);
			FlowElements.Add(CreateSequenceFlow10828SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10829SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10830SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10828SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10828",
				UId = new Guid("c8afea35-0967-4e58-a9d2-abea4cc9d3cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				CurveCenterPosition = new Point(154, 1700),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3f6d46e-c478-4f85-911a-e45be7053add"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac754928-cc4e-4970-bd1f-87199d070bb3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10829SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10829",
				UId = new Guid("bb6d3889-612e-408d-a9cb-9ec544c693d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				CurveCenterPosition = new Point(368, 1700),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a67cb3c2-e22b-4d29-b9ac-cbafcbd8f627"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c2868ac6-649c-415c-b35c-1b979e4bb2fe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10830SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10830",
				UId = new Guid("b679433e-cc0f-4152-aa4f-39469559d0bb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				CurveCenterPosition = new Point(467, 1690),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c2868ac6-649c-415c-b35c-1b979e4bb2fe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45281952-5db7-459a-a8fb-c321853ccb5c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet527LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet527 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("83f35ae8-2cf8-47b8-a90d-e6a62a23c230"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"LaneSet527",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(717, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet527;
		}

		protected virtual ProcessSchemaLane CreateLane1786Lane() {
			ProcessSchemaLane schemaLane1786 = new ProcessSchemaLane(this) {
				UId = new Guid("94134aa7-40b5-4a7d-b3b3-29c9ccb5e817"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("83f35ae8-2cf8-47b8-a90d-e6a62a23c230"),
				CreatedInOwnerSchemaUId = new Guid("94db4b8b-1e23-4464-acc2-bdfd5baccc1d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"Lane1786",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(688, 184),
				UseBackgroundMode = false
			};
			return schemaLane1786;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1ChildInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1ChildInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6e3f0e2c-601a-4a9e-b448-3eb431fc3880"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("94134aa7-40b5-4a7d-b3b3-29c9ccb5e817"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"EventSubProcess1ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(337, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(284, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1ChildInit;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateParentInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("45281952-5db7-459a-a8fb-c321853ccb5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e3f0e2c-601a-4a9e-b448-3eb431fc3880"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"ParentInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c2868ac6-649c-415c-b35c-1b979e4bb2fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e3f0e2c-601a-4a9e-b448-3eb431fc3880"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"ChildInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,93,111,218,48,20,125,30,18,255,193,227,41,213,136,75,62,10,100,168,15,77,32,93,165,170,67,133,170,207,78,124,3,158,140,205,28,167,29,154,246,223,103,135,148,176,130,182,215,61,68,142,124,207,57,247,235,120,78,86,128,167,68,147,133,172,84,14,56,134,66,42,184,151,132,162,79,215,221,14,162,192,97,69,52,56,50,251,6,185,70,37,8,10,170,143,90,202,236,5,132,190,81,171,18,193,5,250,217,237,124,152,91,201,229,90,201,215,58,228,244,90,108,171,222,187,152,116,59,191,204,55,163,76,91,198,211,29,69,215,72,192,43,186,173,24,117,122,126,22,1,100,254,200,141,32,31,185,97,17,13,220,168,8,125,151,100,227,171,112,60,244,139,129,159,213,34,151,151,75,57,149,159,81,242,136,188,193,192,27,141,187,157,23,162,16,61,36,53,178,243,63,187,156,236,33,91,197,54,68,237,18,201,171,141,120,32,27,139,108,105,120,145,175,97,67,240,252,24,133,45,172,161,151,90,85,185,174,212,59,90,82,41,101,218,94,188,69,13,122,9,74,145,82,22,26,63,221,225,103,200,18,41,180,146,188,196,135,159,182,182,148,113,13,202,100,227,102,220,76,10,84,212,23,165,29,78,197,185,81,51,121,153,88,161,92,82,104,138,238,125,1,190,181,90,240,67,239,249,189,166,70,16,36,227,208,132,44,106,177,43,23,160,181,17,120,63,240,105,56,77,131,52,240,221,52,28,198,174,23,122,3,119,58,140,134,110,56,190,138,131,40,241,70,105,20,215,3,183,186,89,197,56,93,238,182,240,23,189,196,11,188,209,44,116,167,209,204,44,48,28,7,110,60,8,82,215,79,175,70,65,152,122,126,156,142,15,122,146,211,244,208,231,97,176,184,185,51,167,160,241,206,118,235,188,181,109,153,172,64,206,17,243,227,126,68,123,23,158,138,60,194,70,190,192,17,161,182,96,183,83,156,73,156,40,48,166,111,112,183,74,86,219,67,226,62,186,151,43,150,19,254,117,11,138,216,21,153,85,179,92,227,27,65,173,98,35,135,111,40,117,206,11,62,51,189,158,19,101,180,44,208,57,177,92,31,181,134,73,204,123,193,51,161,153,102,80,226,55,115,108,182,68,177,82,10,187,1,252,32,245,236,123,69,120,223,116,125,98,233,254,63,44,112,241,63,150,124,222,93,117,169,167,107,181,69,23,237,66,21,152,168,64,6,6,147,223,146,182,54,127,221,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a67cb3c2-e22b-4d29-b9ac-cbafcbd8f627"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e3f0e2c-601a-4a9e-b448-3eb431fc3880"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8DBFLEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8DBFL = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f3bac84b-a11c-451b-b1b6-dad659ba2c58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("94134aa7-40b5-4a7d-b3b3-29c9ccb5e817"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"EventSubProcess8DBFL",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(274, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8DBFL;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c3f6d46e-c478-4f85-911a-e45be7053add"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3bac84b-a11c-451b-b1b6-dad659ba2c58"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceBeforeLoad",
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"DataSourceBeforeLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceBeforeLoadScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ac754928-cc4e-4970-bd1f-87199d070bb3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3bac84b-a11c-451b-b1b6-dad659ba2c58"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"),
				Name = @"DataSourceBeforeLoadScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,81,111,130,48,20,133,159,229,87,52,60,149,205,212,189,51,77,140,83,103,98,22,51,141,123,238,232,149,53,129,150,92,138,198,24,255,251,90,202,16,230,246,6,247,222,243,221,211,211,142,30,54,60,5,182,67,128,37,74,193,86,185,253,93,203,210,144,49,9,119,128,200,75,125,48,236,3,62,167,69,17,198,132,4,253,249,37,152,119,125,154,105,117,144,233,43,87,34,3,36,227,96,32,32,131,148,27,160,55,196,76,35,176,185,50,210,72,40,253,199,153,160,62,69,228,18,12,6,165,65,169,82,82,160,204,57,158,103,58,171,114,245,198,115,176,54,236,12,219,38,95,144,115,182,233,182,153,235,199,255,104,247,60,171,172,120,224,196,214,99,167,72,239,118,68,108,167,183,53,131,70,142,119,228,72,142,110,116,119,46,160,99,194,114,92,69,116,96,207,126,247,132,134,251,174,32,108,57,210,229,217,48,252,44,155,231,133,57,183,253,68,171,210,246,20,156,200,139,76,140,212,202,122,107,176,67,82,95,135,79,183,94,48,185,57,76,234,234,143,148,27,190,213,21,38,208,222,6,189,207,163,214,254,225,104,161,49,231,134,134,151,167,107,226,163,45,84,26,14,251,33,216,144,214,250,4,72,163,40,38,142,227,156,179,169,16,52,108,231,86,182,102,117,206,209,111,231,180,221,27,213,54,188,125,167,111,236,222,29,99,33,177,108,46,206,113,203,30,204,21,60,8,193,84,168,154,56,226,224,26,251,23,122,67,177,181,230,2,4,121,28,147,254,219,117,35,190,23,63,140,130,134,99,176,130,248,27,4,38,228,146,22,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
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
			return new SysSettingsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78b2fbb3-c561-4e2f-ab0f-7eea20ae2de9"));
		}

		#endregion

	}

	#endregion

}

