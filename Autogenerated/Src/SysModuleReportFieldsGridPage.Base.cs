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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysModuleReportFieldsGridPageSchema

	/// <exclude/>
	public class SysModuleReportFieldsGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomButtonsControlLayout {
			get {
				return _bottomButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _setupMacrosesButton;
		public Terrasoft.UI.WebControls.Controls.Button SetupMacrosesButton {
			get {
				return _setupMacrosesButton;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleReportFieldsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportFieldsGridPageSchema(SysModuleReportFieldsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			RealUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			Name = "SysModuleReportFieldsGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportFieldsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, Spacer);
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			Controls.AddAt(2, CreateBottomButtonsControlLayout());
			BottomButtonsControlLayout.InsertItem(0, CreateSetupMacrosesButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleReportFieldsGridPageEventsProcessSchema() {
			var schema = new SysModuleReportFieldsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSetupMacrosesButton() {
			_setupMacrosesButton = new Terrasoft.UI.WebControls.Controls.Button();
			_setupMacrosesButton.UId = new Guid("715fb9cd-b951-482c-bc60-8e0172b747dd");
			_setupMacrosesButton.Name = "SetupMacrosesButton";
			_setupMacrosesButton.CreatedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			_setupMacrosesButton.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			_setupMacrosesButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setupMacrosesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_setupMacrosesButton.Tag = "";
			_setupMacrosesButton.Image = new ControlImage {};
			return _setupMacrosesButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomButtonsControlLayout() {
			_bottomButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomButtonsControlLayout.UId = new Guid("83f439c7-851b-43f5-b1d4-688491b79423");
			_bottomButtonsControlLayout.Name = "BottomButtonsControlLayout";
			_bottomButtonsControlLayout.CreatedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			_bottomButtonsControlLayout.ModifiedInSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			_bottomButtonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomButtonsControlLayout.Tag = "";
			_bottomButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_bottomButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_bottomButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomButtonsControlLayout.StartNewAlignGroup = false;
			_bottomButtonsControlLayout.Image = new ControlImage {};
			_bottomButtonsControlLayout.Edges = "1 0 0 0";
			return _bottomButtonsControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysModuleReportFieldsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportFieldsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportFieldsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportFieldsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportFieldsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportFieldsGridPageSchemaUserControl
	{

		public SysModuleReportFieldsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportFieldsGridPageEventsProcess";
			SchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
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

		public virtual Guid SysModuleReportId {
			get;
			set;
		}

		public virtual string MacrosList {
			get;
			set;
		}

		public virtual Guid ParentEntitySchemaId {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerRegistered {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("7ca8998b-e861-4b00-a349-c4409a967583"),
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
					SchemaElementUId = new Guid("69fabedf-2071-4745-8d18-7a77a1fe01be"),
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
					SchemaElementUId = new Guid("82fdce89-0d6a-4a94-8dd9-3fe71445eef5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("8a9ea914-1677-49be-8c29-8a3a90523b00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("bc81407f-3810-4f2a-99ce-fb621d59b3ac"),
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
					SchemaElementUId = new Guid("90892be9-402f-41d3-b03b-0da7f690ab6f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("b662d251-b195-4af2-8384-78d00e99979f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("f9551488-360f-4577-9e76-70675d3ada15"),
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
					SchemaElementUId = new Guid("38a57148-d8e8-484a-a946-bde38bf69a64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("a2e69e00-30bc-48f4-b260-fe355dc81ac0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private LocalizableString _fieldCaption;
		public LocalizableString FieldCaption {
			get {
				return _fieldCaption ?? (_fieldCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FieldCaption.Value"));
			}
		}

		private LocalizableString _notFoundColumnTitle;
		public LocalizableString NotFoundColumnTitle {
			get {
				return _notFoundColumnTitle ?? (_notFoundColumnTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NotFoundColumnTitle.Value"));
			}
		}

		private LocalizableString _notFoundColumnTextTemplate;
		public LocalizableString NotFoundColumnTextTemplate {
			get {
				return _notFoundColumnTextTemplate ?? (_notFoundColumnTextTemplate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NotFoundColumnTextTemplate.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
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
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
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
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
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
				case "ColumnStructureExplorerRegistered":
					ColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "ColumnStructureExplorerCreated":
					ColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "ParentEntitySchemaId":
					ParentEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "MacrosList":
					MacrosList = reader.GetValue<System.String>();
				break;
				case "SysModuleReportId":
					SysModuleReportId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			var parentEntitySchema = aspPage.CustomData["SysModule_parentEntitySchema"];
			if (aspPage.CustomData["SysModule_parentEntitySchema"] != null && 
				!string.IsNullOrEmpty(aspPage.CustomData["SysModule_parentEntitySchema"].ToString())) {
				ParentEntitySchemaId = new Guid(aspPage.CustomData["SysModule_parentEntitySchema"].ToString());
			}
			if (ParentEntitySchemaId != Guid.Empty) {
				ShowColumnStructureExplorer(ParentEntitySchemaId);
			}
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			if (ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			FillData(null);
			
			return true;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			var structure = new List<Dictionary<string, object>>();
			var column = new Dictionary<string, object> {
				{"Name", "Id"},
				{"ValueColumnName", "Id"},
				{"DisplayColumnName", "Id"},
				{"DataValueType", "Guid"},
				{"Caption", "Id"},
				{"IsVisible", false},
				{"IsSortable", false},
				{"IsPrimaryColumn", true}
			};
			structure.Add(column);
			
			column = new Dictionary<string, object> {
				{"Name", "Field"},
				{"ValueColumnName", "Field"},
				{"DisplayColumnName", "Field"},
				{"DataValueType", "Text"},
				{"Caption", FieldCaption},
				{"IsVisible", true},
				{"IsSortable", false},
				{"IsPrimaryDisplayColumn", true}
			};
			structure.Add(column);
			
			return structure;
		}

		public override void FillData(DataSourceRequest dataSourceRequest) {
			Page.TreeGrid.Clear();
			var dataSource = GetDataSource();
			dataSource.SuspendAjaxEvents();
			dataSource.Clear();
			dataSource.ResumeAjaxEvents();
				  
			if (SysModuleReportId != Guid.Empty) {
				if (!string.IsNullOrEmpty(MacrosList)) {
					var macrosList = Json.Deserialize(MacrosList) as JArray;
					foreach (var macros in macrosList) {
						var row = dataSource.CreateRow();
						row.SetColumnValue("Id", Guid.NewGuid());
						row.SetColumnValue("Field", macros.Value<string>("caption"));
						dataSource.Add(row);
					}
				}
				dataSource.LoadRows(dataSourceRequest);
			}
		}

		public virtual void ShowColumnStructureExplorer(Guid entitySchemaUId) {
			if (!ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			var sructureExplorer = (StructureExplorer) ColumnStructureExplorer;
			if (sructureExplorer == null) {
				return;
			}
			
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
			sructureExplorer.ManagerName = entitySchemaManager.Name;
			if (!string.IsNullOrEmpty(MacrosList)) {
				var dataSourceStructureColumnCollection = new DataSourceStructureColumnCollection();
				var macrosList = Json.Deserialize(MacrosList) as JArray;
				var notFoundColumns = new List<string>();
				for (int i = 0; i < macrosList.Count; i++) {
					var dataSourceStructureColumn = new DataSourceStructureColumn();
					dataSourceStructureColumn.UId = Guid.NewGuid();
					dataSourceStructureColumn.MetaPath = macrosList[i].Value<string>("metaPath");
					var column = schema.FindSchemaColumnByMetaPath(dataSourceStructureColumn.MetaPath);
					if (column != null) {
						dataSourceStructureColumn.Name =  schema.GetSchemaColumnPathByMetaPath(dataSourceStructureColumn.MetaPath);
						dataSourceStructureColumn.DataValueType = column.DataValueType;
					} else {
						notFoundColumns.Add(macrosList[i].Value<string>("caption"));
						dataSourceStructureColumn.Name = Guid.NewGuid().ToString();
						dataSourceStructureColumn.DataValueType = UserConnection.DataValueTypeManager.GetInstanceByName("Text");
					}
					dataSourceStructureColumn.Caption = macrosList[i].Value<string>("caption");
					dataSourceStructureColumn.MetaPathCaption = macrosList[i].Value<string>("metaPathCaption");
			
					if (!string.IsNullOrEmpty(macrosList[i].Value<string>("aggregationType"))
						&& string.Compare(macrosList[i].Value<string>("aggregationType"), "None", true) != 0) {
						
						dataSourceStructureColumn.AggregationType = (AggregationType)Enum.Parse(typeof(AggregationType),
							macrosList[i].Value<string>("aggregationType"));
						if (dataSourceStructureColumn.AggregationType == AggregationType.Count) {
							DataValueTypeManager dataValueTypeManager = dataSourceStructureColumn.DataValueType.DataValueTypeManager;
							dataSourceStructureColumn.DataValueType = dataValueTypeManager.GetInstanceByName("Integer");
						}	
						
						if (!string.IsNullOrEmpty(macrosList[i].Value<string>("subFilters"))) {
							dataSourceStructureColumn.SubFilters =  macrosList[i].Value<string>("subFilters");
						}
					}
					dataSourceStructureColumnCollection.Add(dataSourceStructureColumn);
				}
				if (notFoundColumns.Count > 0) {
					ShowNotFoundColumns(notFoundColumns.ToArray());
				}
				sructureExplorer.Columns = dataSourceStructureColumnCollection;
			}
			sructureExplorer.ShowEditWindow(schema, null);
		}

		public virtual void CreateColumnStructureExplorer() {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);
			var structureExplorer = new StructureExplorer(Page.SetupMacrosesButton, "columns", true, false, string.Empty);
			structureExplorer.ExcludeDataValueTypes = new string[] { "File", "Color" };
			structureExplorer.IsShowSystemColumns = true;
			structureExplorer.IsShowOppositeReference = true;
			structureExplorer.IsColumnDuplicationAllowed = true;
			
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += new AjaxEventHandler(SetMetaPathInfo);
			editComplete.ExtraParameters.Add(param);
			
			
			
			structureExplorer.Columns = new DataSourceStructureColumnCollection();
			
			ColumnStructureExplorerCreated = true;
			if (!ColumnStructureExplorerRegistered) {
				structureExplorer.Register();
				ColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorer = structureExplorer;
		}

		public virtual void SetMetaPathInfo(object sender, AjaxEventArgs e) {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			EntitySchema schema = entitySchemaManager.GetInstanceByUId(ParentEntitySchemaId);
			var columns = Json.Deserialize(e.ExtraParameters["itemsInfo"]) as JArray;
			var notFoundColumns = new List<string>();
			foreach (JObject column in columns) {
				EntitySchemaColumn entitySchemaColumn = schema.FindSchemaColumnByMetaPath(column.Value<string>("metaPath"));
				if (entitySchemaColumn != null) {
					column.Add(new JProperty("dataValueType", new JValue(entitySchemaColumn.DataValueType.Name)));
				} else {
					column.Add(new JProperty("dataValueType", new JValue("Text")));
					notFoundColumns.Add(column.Value<string>("caption"));
				}
			}
			var itemsInfo = Json.Serialize(columns);
			var macroses = itemsInfo !="[]" ? new StringBuilder(itemsInfo) : new StringBuilder();
			MacrosList = macroses.ToString();
			FillData(null);
			if (notFoundColumns.Count > 0) {
				ShowNotFoundColumns(notFoundColumns.ToArray());
			}
		}

		public virtual void ShowNotFoundColumns(string[] notFoundColumns) {
			string errorMessageColumns = string.Join(", ", notFoundColumns);
			string messageText = string.Format(NotFoundColumnTextTemplate, errorMessageColumns);
			var messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			messagePanel.AddMessage("RemovedCollumnMessageId", NotFoundColumnTitle, messageText, MessageType.Error);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SetupMacrosesButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "FillData":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerRegistered", ColumnStructureExplorerRegistered, false);
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (!HasMapping("ColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerCreated", ColumnStructureExplorerCreated, false);
			}
			if (!HasMapping("ParentEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentEntitySchemaId", ParentEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("MacrosList") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MacrosList", MacrosList, null);
			}
			if (!HasMapping("SysModuleReportId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleReportId", SysModuleReportId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportFieldsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportFieldsGridPageEventsProcess : SysModuleReportFieldsGridPageEventsProcess<Terrasoft.WebApp.SysModuleReportFieldsGridPageSchemaUserControl>
	{

		public SysModuleReportFieldsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportFieldsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportFieldsGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SetupMacrosesButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SetupMacrosesButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SetupMacrosesButton.AjaxEvents.Click.Event += SetupMacrosesButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SetupMacrosesButton.AjaxEvents.Click.Event -= SetupMacrosesButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleReportFieldsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportFieldsGridPageEventsProcess(UserConnection);
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

		public virtual void SetupMacrosesButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SetupMacrosesButtonClick");
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
			SchemaName = "SysModuleReportFieldsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportFieldsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportFieldsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportFieldsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportFieldsGridPageEventsProcessSchema(SysModuleReportFieldsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportFieldsGridPageEventsProcess";
			UId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateSysModuleReportIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d842a6e9-748e-47a9-8ab2-dc684ef3f680"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"SysModuleReportId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMacrosListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fbfb01b0-8c79-4cd4-aa2e-db5123362600"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"MacrosList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("568cdd50-8b98-4ce1-b8ea-523bc9cca8b8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"ParentEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b7825d22-0ba3-4bf1-ad32-5859f0729840"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"ColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("aa9cf91a-7867-42d2-b247-97b55c06dc31"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9b01bc24-ea38-4a4a-bd17-9050ed92da31"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"ColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSysModuleReportIdParameter());
			Parameters.Add(CreateMacrosListParameter());
			Parameters.Add(CreateParentEntitySchemaIdParameter());
			Parameters.Add(CreateColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateColumnStructureExplorerRegisteredParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSysModuleReportFieldsGridPageLaneSet1 = CreateSysModuleReportFieldsGridPageLaneSet1LaneSet();
			LaneSets.Add(schemaSysModuleReportFieldsGridPageLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaSysModuleReportFieldsGridPageLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask3);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFieldCaptionLocalizableString());
			LocalizableStrings.Add(CreateNotFoundColumnTitleLocalizableString());
			LocalizableStrings.Add(CreateNotFoundColumnTextTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFieldCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c07cee43-3b87-481e-9ed9-b502f6e26e77"),
				Name = "FieldCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotFoundColumnTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c8c65a5d-e707-43ea-9651-bc73faf1fca0"),
				Name = "NotFoundColumnTitle",
				CreatedInPackageId = new Guid("3e5bd282-4d8c-413e-b456-f52e075a6aaa"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotFoundColumnTextTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4ea27588-14bd-4cb8-bffb-d3dbdfbf47e4"),
				Name = "NotFoundColumnTextTemplate",
				CreatedInPackageId = new Guid("3e5bd282-4d8c-413e-b456-f52e075a6aaa"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b18c4310-8b44-44aa-aecb-6a1a2b0f0f4d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69fabedf-2071-4745-8d18-7a77a1fe01be"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("82fdce89-0d6a-4a94-8dd9-3fe71445eef5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("99ab185a-5a32-484a-9be5-a3202cc1c764"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CurveCenterPosition = new Point(200, 435),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc81407f-3810-4f2a-99ce-fb621d59b3ac"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("90892be9-402f-41d3-b03b-0da7f690ab6f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("c7efcdb4-fea0-43d2-aa34-5a4edefcd92f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CurveCenterPosition = new Point(350, 430),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90892be9-402f-41d3-b03b-0da7f690ab6f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b662d251-b195-4af2-8384-78d00e99979f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("22ccdaa7-bb48-429c-aa6e-a7f7eb16d9c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CurveCenterPosition = new Point(234, 612),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("38a57148-d8e8-484a-a946-bde38bf69a64"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a2e69e00-30bc-48f4-b260-fe355dc81ac0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSysModuleReportFieldsGridPageLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaSysModuleReportFieldsGridPageLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("43b01cf3-38d8-4b6b-9d15-3984db4f48a4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"SysModuleReportFieldsGridPageLaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(743, 159),
				UseBackgroundMode = false
			};
			return schemaSysModuleReportFieldsGridPageLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("bbd2d5bf-f5ae-42b8-bffa-8500bc0bc353"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("43b01cf3-38d8-4b6b-9d15-3984db4f48a4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(714, 159),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7ca8998b-e861-4b00-a349-c4409a967583"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bbd2d5bf-f5ae-42b8-bffa-8500bc0bc353"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(332, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("69fabedf-2071-4745-8d18-7a77a1fe01be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ca8998b-e861-4b00-a349-c4409a967583"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SetupMacrosesButtonClick",
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"StartMessage1",
				Position = new Point(78, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("82fdce89-0d6a-4a94-8dd9-3fe71445eef5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ca8998b-e861-4b00-a349-c4409a967583"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"ScriptTask1",
				Position = new Point(213, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,65,107,194,64,16,133,207,21,252,15,163,7,49,151,253,3,226,65,210,80,114,104,43,196,226,161,72,153,154,81,3,155,221,48,59,171,13,197,255,222,137,230,166,151,182,167,97,135,247,190,55,111,143,200,128,161,89,226,158,96,14,221,48,139,254,137,1,86,196,140,193,239,196,188,229,102,77,159,169,119,194,222,6,211,9,102,195,193,81,221,13,50,57,201,156,84,210,22,219,3,213,168,160,30,105,210,24,196,215,143,40,248,62,46,218,240,236,203,104,233,227,214,50,222,40,173,218,193,244,247,70,24,205,193,69,107,97,50,129,225,224,97,20,132,43,183,55,121,120,209,229,43,103,117,35,237,31,176,102,229,139,11,105,154,36,9,124,43,121,121,163,202,75,173,234,232,4,79,177,42,255,153,161,253,207,215,47,184,155,163,37,187,16,115,169,115,189,167,56,248,83,234,109,172,157,66,226,86,34,83,246,213,88,207,196,119,25,125,4,147,42,29,168,133,102,63,114,155,199,22,254,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8a9ea914-1677-49be-8c29-8a3a90523b00"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bbd2d5bf-f5ae-42b8-bffa-8500bc0bc353"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(364, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bc81407f-3810-4f2a-99ce-fb621d59b3ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a9ea914-1677-49be-8c29-8a3a90523b00"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("90892be9-402f-41d3-b03b-0da7f690ab6f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a9ea914-1677-49be-8c29-8a3a90523b00"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,206,207,41,205,205,11,46,41,42,77,46,41,45,74,117,173,40,200,201,47,74,45,114,46,74,77,44,73,77,209,84,168,230,229,226,132,112,112,168,212,208,180,230,229,170,229,229,226,229,42,74,5,138,231,41,0,21,164,90,3,0,68,183,36,197,91,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b662d251-b195-4af2-8384-78d00e99979f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a9ea914-1677-49be-8c29-8a3a90523b00"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f9551488-360f-4577-9e76-70675d3ada15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bbd2d5bf-f5ae-42b8-bffa-8500bc0bc353"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 380),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("38a57148-d8e8-484a-a946-bde38bf69a64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9551488-360f-4577-9e76-70675d3ada15"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FillData",
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a2e69e00-30bc-48f4-b260-fe355dc81ac0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9551488-360f-4577-9e76-70675d3ada15"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,201,113,73,44,73,212,200,43,205,201,209,180,230,229,226,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,36,94,243,17,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateShowColumnStructureExplorerMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateSetMetaPathInfoMethod());
			Methods.Add(CreateShowNotFoundColumnsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e0c6ae3c-b3a0-4e06-b747-2bf038a88cc7"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("917cbfdc-72d8-4e11-9182-d5a8af1cdec3"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9c1bc255-2fee-462f-bbc2-ac404082e1f1"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("71df11d8-5543-4198-929a-6a80e3ed540a"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("75dfcea9-cb8b-47b8-b91d-978432db7164"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("3e5bd282-4d8c-413e-b456-f52e075a6aaa")
			});
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,221,106,131,48,20,199,175,155,167,8,94,181,32,123,1,59,161,88,54,10,165,12,86,188,63,213,179,113,70,140,146,143,110,82,124,247,197,88,183,57,219,34,189,204,255,35,57,231,71,142,160,184,54,202,102,198,42,228,143,92,226,39,223,146,54,203,53,101,134,74,9,170,94,58,159,228,123,200,203,195,7,102,38,142,231,139,136,29,93,47,43,133,45,228,185,116,61,207,79,108,118,10,118,80,96,16,242,96,147,7,77,216,10,41,8,139,137,191,98,228,173,73,87,2,234,107,46,24,240,237,125,93,121,231,217,82,239,37,80,181,99,12,242,27,157,146,166,131,104,179,111,32,52,246,242,107,169,12,92,208,95,20,21,110,145,238,121,103,58,62,216,176,38,98,63,164,30,86,121,62,239,246,119,48,216,93,36,158,8,197,13,24,127,237,139,60,6,129,255,72,246,248,101,70,72,124,227,124,28,163,241,91,78,35,51,152,103,10,32,133,78,148,191,63,45,250,6,188,105,63,154,120,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateFillDataMethod() {
			SchemaMethod method = base.CreateFillDataMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,203,78,195,48,16,60,167,18,255,224,230,228,72,200,63,192,67,170,218,82,181,106,11,74,16,247,85,188,45,70,142,29,214,118,75,65,252,59,78,2,77,212,3,7,219,242,236,204,120,198,79,176,71,241,76,136,11,82,82,76,53,2,241,236,230,106,116,0,98,18,60,20,54,80,137,236,142,45,208,207,206,247,150,210,143,69,17,92,141,70,78,222,224,99,126,64,227,221,37,161,55,30,128,57,186,80,225,133,40,97,236,106,164,118,140,23,39,183,177,50,104,204,177,182,228,151,146,141,99,138,16,83,206,171,218,159,50,246,21,201,13,113,236,60,41,179,23,75,183,13,90,63,82,59,230,27,40,201,186,181,114,62,235,168,73,83,169,58,163,177,210,202,89,35,102,232,144,20,104,245,137,67,13,3,199,86,19,34,56,53,153,146,157,37,132,242,149,241,222,132,41,51,176,251,125,163,125,132,236,49,186,15,219,71,177,199,220,30,187,134,73,18,25,162,64,63,181,58,84,230,5,116,64,158,46,101,122,221,245,219,226,177,57,121,246,15,251,65,161,110,4,93,2,209,162,183,221,71,220,243,180,132,218,43,107,210,63,135,65,150,137,148,60,26,118,131,239,184,53,107,48,95,91,144,49,169,227,61,150,227,123,192,88,49,74,34,249,7,208,155,252,44,50,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a4912a50-19af-4c4f-b72c-c7add50b54d7"),
				Name = "ShowColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("70943b1e-79a5-4b4f-b2c2-fe72e1e5f152"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,77,111,226,48,16,61,83,169,255,193,205,161,74,84,100,245,78,169,68,41,173,168,182,44,18,116,247,176,218,131,55,25,168,165,196,70,182,83,202,174,248,239,235,143,36,16,146,16,232,37,81,236,153,55,111,102,158,61,161,11,228,95,13,121,156,38,108,166,68,26,170,84,192,232,115,21,115,1,98,40,128,40,136,2,244,239,242,162,227,62,26,44,253,160,119,121,177,189,188,248,32,2,201,131,61,212,71,126,197,33,64,13,72,26,135,106,74,85,144,62,98,105,28,59,46,2,244,30,115,33,93,80,96,138,170,205,44,124,135,132,188,18,70,150,54,238,84,191,177,91,196,165,189,169,224,31,52,2,129,159,65,101,75,190,55,170,98,120,1,34,18,205,65,8,34,249,66,225,161,230,130,173,29,5,137,107,28,122,89,13,236,154,102,80,195,203,196,28,51,169,8,11,225,97,243,54,142,252,125,35,253,109,106,121,152,63,206,156,39,36,129,6,88,179,149,85,239,74,42,65,217,18,143,229,68,215,236,187,24,37,43,181,241,95,73,40,184,252,70,165,10,92,25,13,211,136,40,50,227,169,8,161,104,133,235,140,126,198,16,42,202,153,142,199,96,141,30,219,45,173,12,44,108,82,196,210,222,47,146,51,252,8,18,4,37,49,253,11,251,76,76,125,95,6,186,190,155,220,149,113,245,196,83,22,57,112,153,69,55,198,119,46,173,123,23,102,193,5,242,41,83,136,106,147,219,158,126,221,237,133,213,173,74,153,210,171,55,55,46,217,227,217,182,229,232,66,118,26,253,177,238,155,198,120,78,105,132,39,176,54,239,86,151,87,80,100,74,212,187,246,219,241,254,69,127,227,31,36,78,161,72,214,75,50,59,207,1,154,60,194,156,180,19,26,126,162,44,114,106,112,216,15,155,28,220,111,143,239,96,141,110,50,216,171,253,179,118,44,131,76,141,57,11,45,236,125,18,6,251,11,68,142,196,51,237,177,197,153,111,86,38,112,88,179,108,49,182,8,98,9,25,255,3,65,225,65,20,249,71,11,30,146,149,81,179,23,180,18,202,10,80,110,59,158,243,153,133,242,207,78,232,77,159,145,33,103,204,29,167,242,118,237,245,97,8,248,222,28,62,85,166,142,237,113,205,13,93,106,109,146,43,42,112,162,132,79,132,77,202,230,22,62,215,94,253,157,117,20,142,44,151,2,150,196,64,153,2,233,126,217,114,95,95,163,12,107,200,147,21,17,112,38,74,23,121,19,206,192,235,34,157,45,4,230,56,220,230,103,161,165,159,131,50,150,25,125,7,75,193,136,165,9,158,18,33,193,87,250,155,47,42,22,93,27,164,115,102,234,78,106,166,146,103,208,235,163,131,37,119,109,230,217,118,234,4,104,47,209,202,98,191,249,110,45,203,184,86,212,142,252,25,7,165,142,67,221,201,24,51,5,118,142,187,8,219,206,174,139,95,20,157,76,255,60,209,88,129,144,186,232,69,161,154,153,207,10,123,115,83,158,12,157,241,109,63,210,187,233,107,47,182,70,59,139,104,160,76,222,135,87,162,237,58,186,47,116,62,123,231,235,73,217,166,226,51,231,118,108,251,65,129,92,249,105,217,141,240,19,232,187,223,185,10,134,161,50,138,168,250,169,71,28,95,251,110,212,116,221,128,234,253,7,122,52,116,159,190,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3536a26a-bc83-4bb6-a00f-35260f8e397c"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,75,79,227,48,16,62,83,169,255,193,244,148,104,145,255,0,226,80,66,208,246,80,81,53,236,238,1,113,152,77,38,37,200,177,45,123,220,135,16,255,125,199,77,73,203,134,135,34,37,206,232,123,140,231,155,53,56,97,193,65,43,174,132,198,141,184,71,231,192,155,154,228,175,153,252,131,127,51,163,201,25,229,101,127,88,68,52,18,186,100,210,16,182,126,166,107,51,185,16,239,126,122,204,220,84,40,151,176,73,47,199,163,53,91,121,114,161,164,224,48,223,90,101,28,186,131,109,241,127,61,89,192,10,101,129,20,236,28,74,103,60,250,235,64,100,52,59,149,70,133,86,123,246,97,22,94,136,26,148,231,15,107,55,122,37,243,214,210,46,250,13,188,100,190,45,85,168,240,6,8,126,131,10,120,191,179,232,15,29,116,236,135,71,241,34,38,183,141,194,120,165,204,48,111,34,94,63,20,155,249,226,201,108,138,157,231,123,103,93,71,44,21,59,250,2,126,103,173,241,60,169,37,214,232,80,151,248,53,165,211,189,9,86,53,37,80,99,244,84,41,179,193,234,200,26,143,50,211,90,163,81,211,244,25,182,249,154,15,2,171,134,98,89,113,4,12,29,42,247,80,47,243,19,44,235,157,82,101,167,246,163,27,80,207,249,9,186,82,156,16,135,51,71,130,5,208,83,140,61,29,176,183,228,160,223,4,47,167,85,149,236,87,45,221,247,29,159,97,103,199,73,70,207,152,84,97,130,43,177,95,144,14,192,111,133,101,156,72,146,30,166,16,203,131,53,202,28,2,157,206,171,169,69,114,254,9,120,137,171,134,211,116,88,165,226,101,60,58,27,118,247,134,216,155,158,125,43,115,180,125,253,180,195,143,242,185,252,7,137,192,104,14,150,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetMetaPathInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d4e2b236-fddc-4e1b-9838-a1a5028da7c8"),
				Name = "SetMetaPathInfo",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("047adac7-2776-4cb6-8d78-8dc21fad737f"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f4bbac55-2d93-4325-955c-740d6d0d1209"),
				Name = "e",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,193,111,219,32,20,198,207,241,95,65,57,97,105,66,59,47,75,167,38,109,166,88,75,23,41,222,46,85,15,212,126,105,152,48,68,240,156,214,155,242,191,15,131,227,57,173,79,59,33,63,30,63,190,239,125,248,40,44,1,141,18,155,109,177,135,74,172,133,22,207,96,201,140,108,252,202,99,145,95,236,109,172,57,202,18,44,255,10,216,149,24,189,123,207,160,41,17,142,228,96,173,112,102,135,124,97,44,240,208,39,193,241,145,3,211,100,88,36,46,46,179,49,125,237,221,43,237,80,232,2,230,205,143,85,201,54,194,250,190,33,96,85,166,211,228,232,253,21,70,213,149,118,158,148,57,163,249,45,56,176,82,40,249,27,152,23,244,138,86,248,195,162,2,4,235,30,168,68,168,220,74,239,12,125,12,6,178,27,111,160,137,36,109,112,105,106,93,46,122,162,134,23,242,77,58,252,236,208,74,253,124,205,252,157,59,111,84,20,123,194,178,239,79,191,160,192,78,0,145,250,44,37,37,127,146,201,80,107,4,94,56,237,74,179,110,14,124,41,117,57,220,153,55,107,64,175,28,247,44,82,249,79,161,106,232,133,208,170,219,166,169,215,52,145,59,194,70,240,87,222,66,173,84,16,52,233,56,55,101,201,90,95,153,79,250,0,22,27,70,75,129,34,224,243,230,0,244,67,176,157,133,194,8,148,223,14,187,249,189,31,109,26,52,156,8,40,7,255,127,21,205,225,21,105,100,77,222,100,17,80,227,131,40,196,1,165,209,113,14,167,228,20,162,236,99,62,63,139,109,255,40,206,33,197,204,43,81,88,227,160,13,251,223,153,171,25,125,120,164,228,75,80,183,13,23,205,107,169,252,95,193,250,166,148,124,26,217,246,212,117,32,182,175,198,51,207,120,158,155,216,216,118,44,165,82,237,16,89,200,102,154,180,225,189,245,187,240,31,72,174,201,199,144,221,118,111,94,238,47,59,222,157,200,77,120,202,172,157,195,233,47,46,196,85,254,249,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowNotFoundColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1eb419b4-6bff-4ede-9d9e-d2feecf1ada7"),
				Name = "ShowNotFoundColumns",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				CreatedInPackageId = new Guid("3e5bd282-4d8c-413e-b456-f52e075a6aaa"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("34a44623-e161-491e-b3ab-5234645341a2"),
				Name = "notFoundColumns",
				CreatedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				ModifiedInSchemaUId = new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string[]",
				CreatedInPackageId = new Guid("3e5bd282-4d8c-413e-b456-f52e075a6aaa")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,77,11,194,48,12,189,11,254,135,226,105,131,81,188,139,135,41,14,20,20,145,121,18,15,133,5,41,180,205,104,50,209,127,111,59,59,156,34,20,10,47,239,35,47,196,94,187,155,0,239,209,239,129,72,221,96,141,166,179,142,196,82,80,63,148,59,212,46,155,21,34,60,135,92,97,231,154,196,201,23,211,201,155,36,236,91,92,195,131,63,202,10,189,85,156,29,190,84,145,82,131,109,141,98,40,254,37,71,215,187,242,131,229,81,57,48,193,115,141,142,61,154,51,107,163,89,3,201,74,71,203,30,204,142,129,40,75,106,251,63,129,116,153,95,195,214,43,69,176,31,89,133,26,236,59,200,133,34,49,198,67,234,56,81,150,77,147,198,217,236,4,22,239,16,11,196,13,19,188,109,130,213,79,55,205,38,148,26,29,163,24,50,234,103,11,114,19,219,230,139,23,115,249,43,48,118,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportFieldsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7e85306-6175-4c5c-b682-f77eccda9597"));
		}

		#endregion

	}

	#endregion

}

