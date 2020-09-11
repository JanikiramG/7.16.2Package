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
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: AdministrativeObjectsByColumnsGridPageSchema

	/// <exclude/>
	public class AdministrativeObjectsByColumnsGridPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _fieldPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer FieldPageContainer {
			get {
				return _fieldPageContainer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _accessPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer AccessPageContainer {
			get {
				return _accessPageContainer;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrativeObjectsByColumnsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeObjectsByColumnsGridPageSchema(AdministrativeObjectsByColumnsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			RealUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			Name = "AdministrativeObjectsByColumnsGridPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "264";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeObjectsByColumnsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateFieldPageContainer());
			MainControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateAccessPageContainer());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAdministrativeObjectsByColumnsGridPageEventsProcessSchema() {
			var schema = new AdministrativeObjectsByColumnsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateFieldPageContainer() {
			_fieldPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_fieldPageContainer.UId = new Guid("08e7f313-e2d5-4b03-a287-ad209aad9027");
			_fieldPageContainer.Name = "FieldPageContainer";
			_fieldPageContainer.CreatedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_fieldPageContainer.ModifiedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_fieldPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_fieldPageContainer.Tag = "";
			_fieldPageContainer.PageSchemaUId = new Guid("6802faa2-b69c-42f2-9f53-80104eb6c941");
			_fieldPageContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_fieldPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_fieldPageContainer.StartNewAlignGroup = false;
			_fieldPageContainer.Edges = "";
			return _fieldPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("47cc5031-c3f9-409a-9af3-f8db8c76871c");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_controlLayout1.ModifiedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "0 1 0 0";
			_controlLayout1.HasSplitter = true;
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateAccessPageContainer() {
			_accessPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_accessPageContainer.UId = new Guid("17a25764-a715-4e8f-ae6c-b7d726db5c65");
			_accessPageContainer.Name = "AccessPageContainer";
			_accessPageContainer.CreatedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_accessPageContainer.ModifiedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_accessPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_accessPageContainer.Tag = "";
			_accessPageContainer.PageSchemaUId = new Guid("eaf671fb-265d-4462-b32c-e06a663c16c3");
			_accessPageContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_accessPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_accessPageContainer.StartNewAlignGroup = false;
			_accessPageContainer.Edges = "";
			return _accessPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("c04871c4-9bc0-4aa3-846d-7ee89f66ed9e");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_controlLayout2.ModifiedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "0 0 0 1";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("94e701a2-1194-44bd-a919-e6d18a3bcbfb");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeObjectsByColumnsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeObjectsByColumnsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("500ed75f-7764-4c0e-8940-d51578307c6f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeObjectsByColumnsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByColumnsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByColumnsGridPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.AdministrativeObjectsByColumnsGridPageSchemaUserControl
	{

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public AdministrativeObjectsByColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeObjectsByColumnsGridPageEventsProcess";
			SchemaUId = new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("500ed75f-7764-4c0e-8940-d51578307c6f");
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

		public virtual Object FilterLeftExpression {
			get;
			set;
		}

		public virtual Guid SysModuleDetailId {
			get;
			set;
		}

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		public virtual bool IsDetailGrid {
			get;
			set;
		}

		public virtual Object ListenerPage {
			get;
			set;
		}

		public virtual Guid SelectedNodePrimaryColumnValue {
			get;
			set;
		}

		public virtual string CurrentGridSchemaName {
			get;
			set;
		}

		public virtual Object DataSourceFilter {
			get;
			set;
		}

		public virtual string ParentColumnMetaPath {
			get;
			set;
		}

		public virtual Guid SubjectColumnUId {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual bool AddToMenuItemMoveTo {
			get;
			set;
		}

		public virtual bool LocatedInEditPage {
			get;
			set;
		}

		public virtual bool UseModuleDetails {
			get;
			set;
		}

		private ProcessFlowElement _subProcessGridPageRefreshRow;
		public ProcessFlowElement SubProcessGridPageRefreshRow {
			get {
				return _subProcessGridPageRefreshRow ?? (_subProcessGridPageRefreshRow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessGridPageRefreshRow",
					SchemaElementUId = new Guid("7656d297-5452-4aa8-9c6c-b0792c89ee3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _gridPageRefreshRow;
		public ProcessFlowElement GridPageRefreshRow {
			get {
				return _gridPageRefreshRow ?? (_gridPageRefreshRow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridPageRefreshRow",
					SchemaElementUId = new Guid("c51715dd-d2b7-4769-816d-1e5d33c73ee5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGridPageRefreshRow;
		public ProcessScriptTask ScriptGridPageRefreshRow {
			get {
				return _scriptGridPageRefreshRow ?? (_scriptGridPageRefreshRow = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGridPageRefreshRow",
					SchemaElementUId = new Guid("9e0863e6-99c3-491d-bef2-2ba406daceb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridPageRefreshRowExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessGridActiveRowChanged;
		public ProcessFlowElement SubProcessGridActiveRowChanged {
			get {
				return _subProcessGridActiveRowChanged ?? (_subProcessGridActiveRowChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessGridActiveRowChanged",
					SchemaElementUId = new Guid("8dc89185-d2f0-49f4-8a45-c232db7900c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _gridActiveRowChanged;
		public ProcessFlowElement GridActiveRowChanged {
			get {
				return _gridActiveRowChanged ?? (_gridActiveRowChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridActiveRowChanged",
					SchemaElementUId = new Guid("70c5cff7-87f6-48ae-a86d-aa69217e047a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGridActiveRowChanged;
		public ProcessScriptTask ScriptGridActiveRowChanged {
			get {
				return _scriptGridActiveRowChanged ?? (_scriptGridActiveRowChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGridActiveRowChanged",
					SchemaElementUId = new Guid("5f2c9c1d-cdda-416f-8115-f52b7f0a412d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridActiveRowChangedExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessGridPageRefreshRow };
			FlowElements[GridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { GridPageRefreshRow };
			FlowElements[ScriptGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridPageRefreshRow };
			FlowElements[SubProcessGridActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessGridActiveRowChanged };
			FlowElements[GridActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { GridActiveRowChanged };
			FlowElements[ScriptGridActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridActiveRowChanged };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessGridPageRefreshRow":
						break;
					case "GridPageRefreshRow":
						e.Context.QueueTasks.Enqueue("ScriptGridPageRefreshRow");
						break;
					case "ScriptGridPageRefreshRow":
						break;
					case "SubProcessGridActiveRowChanged":
						break;
					case "GridActiveRowChanged":
						e.Context.QueueTasks.Enqueue("ScriptGridActiveRowChanged");
						break;
					case "ScriptGridActiveRowChanged":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("GridPageRefreshRow");
			ActivatedEventElements.Add("GridActiveRowChanged");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					break;
				case "GridPageRefreshRow":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridPageRefreshRow";
					result = GridPageRefreshRow.Execute(context);
					break;
				case "ScriptGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridPageRefreshRow";
					result = ScriptGridPageRefreshRow.Execute(context, ScriptGridPageRefreshRowExecute);
					break;
				case "SubProcessGridActiveRowChanged":
					context.QueueTasks.Dequeue();
					break;
				case "GridActiveRowChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridActiveRowChanged";
					result = GridActiveRowChanged.Execute(context);
					break;
				case "ScriptGridActiveRowChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridActiveRowChanged";
					result = ScriptGridActiveRowChanged.Execute(context, ScriptGridActiveRowChangedExecute);
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
				case "UseModuleDetails":
					UseModuleDetails = reader.GetValue<System.Boolean>();
				break;
				case "LocatedInEditPage":
					LocatedInEditPage = reader.GetValue<System.Boolean>();
				break;
				case "AddToMenuItemMoveTo":
					AddToMenuItemMoveTo = reader.GetValue<System.Boolean>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
				case "SubjectColumnUId":
					SubjectColumnUId = reader.GetValue<System.Guid>();
				break;
				case "ParentColumnMetaPath":
					ParentColumnMetaPath = reader.GetValue<System.String>();
				break;
				case "CurrentGridSchemaName":
					CurrentGridSchemaName = reader.GetValue<System.String>();
				break;
				case "SelectedNodePrimaryColumnValue":
					SelectedNodePrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "IsDetailGrid":
					IsDetailGrid = reader.GetValue<System.Boolean>();
				break;
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "SysModuleDetailId":
					SysModuleDetailId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptGridPageRefreshRowExecute(ProcessExecutingContext context) {
			var firstLevelDetailProcess = Page.FieldPageContainer.PageInstance.Process;
			firstLevelDetailProcess.SetPropertyValue("DataSourceFilter", DataSourceFilter);
			firstLevelDetailProcess.SetPropertyValue("SelectedNodePrimaryColumnValue", SelectedNodePrimaryColumnValue);
			firstLevelDetailProcess.SetPropertyValue("ParentColumnMetaPath", ParentColumnMetaPath);
			Page.FieldPageContainer.PageInstance.Process.SetPropertyValue("ListenerPage", Page);
			Page.AccessPageContainer.PageInstance.Process.SetPropertyValue("ListenerPage", Page);
			
			string viewCode = GetViewCode();
			Page.FieldPageContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			Page.FieldPageContainer.PageInstance.Process.SetPropertyValue("ViewCode", viewCode);
			Page.AccessPageContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			Page.AccessPageContainer.PageInstance.Process.SetPropertyValue("SubjectColumnUId", Guid.Empty);
			Page.AccessPageContainer.PageInstance.Process.SetPropertyValue("IsDetailGrid", true);
			Page.FieldPageContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
			
			return true;
		}

		public virtual bool ScriptGridActiveRowChangedExecute(ProcessExecutingContext context) {
			Guid filterColumnValue = GetFilterColumnValue();
			var pageInstance = Page.AccessPageContainer.PageInstance;
			var detailDataSource = Page.AccessPageContainer.FindPageControlByName("DataSource") as DataSource;
			var detailSchema = detailDataSource.Schema;
			Terrasoft.UI.WebControls.Utilities.EntityDataSourceUtilities.InitializeAutoDefStructure(detailDataSource as Terrasoft.UI.WebControls.Controls.EntityDataSource);
			Terrasoft.UI.WebControls.Controls.DataSourceStructure structure = detailDataSource.CurrentStructure;
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = structure.CreateFiltersGroup("DetailFilter", LogicalOperationStrict.And);
			filters.Add(
				structure.CreateFilterWithParameters(detailSchema, 
					Terrasoft.Core.Entities.FilterComparisonType.Equal,
					"SubjectColumnUId", SubjectColumnUId));
			filters.Add(
				structure.CreateFilterWithParameters(detailSchema, 
					Terrasoft.Core.Entities.FilterComparisonType.Equal,
					"SubjectSchemaUId", filterColumnValue));
			pageInstance.Process.SetPropertyValue("DataSourceFilter", filters);
			pageInstance.Process.SetPropertyValue("SubjectSchemaUId", filterColumnValue);
			pageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", filterColumnValue);
			pageInstance.Process.SetPropertyValue("SubjectColumnUId", SubjectColumnUId);
			pageInstance.Process.SetPropertyValue("IsDetailGrid", true);
			pageInstance.ThrowEvent("GridPageRefreshRow");
			return true;
		}

		public virtual string GetViewCode() {
			string code = string.Empty;
			var parentTab = Page.PageContainer.Parent as Tab;
			if (parentTab != null) {
				foreach (var item in parentTab.Menu) {
					var checkMenuItem = item as CheckMenuItem;
					if (checkMenuItem != null && checkMenuItem.Checked) {
						code = checkMenuItem.Tag;
						break;
					}
				}
			}
			return code;
		}

		public virtual Guid GetFilterColumnValue() {
			Dictionary<string, object> conditions = null;  
			Guid filterColumnValue;
			conditions = new Dictionary<string, object> {
				{ "Id",  SelectedNodePrimaryColumnValue},
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
							if (ActivatedEventElements.Contains("GridPageRefreshRow")) {
							context.QueueTasks.Enqueue("GridPageRefreshRow");
						}
						break;
					case "GridActiveRowChanged":
							if (ActivatedEventElements.Contains("GridActiveRowChanged")) {
							context.QueueTasks.Enqueue("GridActiveRowChanged");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("UseModuleDetails") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UseModuleDetails", UseModuleDetails, false);
			}
			if (!HasMapping("LocatedInEditPage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LocatedInEditPage", LocatedInEditPage, false);
			}
			if (!HasMapping("AddToMenuItemMoveTo") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AddToMenuItemMoveTo", AddToMenuItemMoveTo, false);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
			if (!HasMapping("SubjectColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SubjectColumnUId", SubjectColumnUId, Guid.Empty);
			}
			if (!HasMapping("ParentColumnMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentColumnMetaPath", ParentColumnMetaPath, null);
			}
			if (!HasMapping("CurrentGridSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentGridSchemaName", CurrentGridSchemaName, null);
			}
			if (!HasMapping("SelectedNodePrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedNodePrimaryColumnValue", SelectedNodePrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("IsDetailGrid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDetailGrid", IsDetailGrid, false);
			}
			if (!HasMapping("SysEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("SysModuleDetailId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleDetailId", SysModuleDetailId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByColumnsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeObjectsByColumnsGridPageEventsProcess : AdministrativeObjectsByColumnsGridPageEventsProcess<Terrasoft.WebApp.AdministrativeObjectsByColumnsGridPageSchemaUserControl>
	{

		public AdministrativeObjectsByColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeObjectsByColumnsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeObjectsByColumnsGridPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer FieldPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("FieldPageContainer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer AccessPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("AccessPageContainer", true);
			}
		}

		private Terrasoft.UI.WebControls.Controls.ScriptManager _scriptManager;
		public Terrasoft.UI.WebControls.Controls.ScriptManager ScriptManager {
			get {
				if (this._scriptManager != null) {
					return this._scriptManager;
				}
				if (!this.DesignMode && this.Page != null) {
					this._scriptManager = ScriptManager.GetCurrent(this.Page);
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
				}
				if (this.Page != null) {
					this._scriptManager = ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManagerProxy") as ScriptManager;
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
					this._scriptManager = (ScriptManager)ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManager");
					if (this.DesignMode && this._scriptManager == null) {
						this._scriptManager = new ScriptManager();
						this.Page.Controls.Add(this._scriptManager);
					}
				}
				if (this._scriptManager == null) {
					throw new InvalidOperationException("The Terrasoft Script Manager Control " +
						"is missing from this Page." +
						Environment.NewLine + Environment.NewLine +
						"Please add the following Script Manager tag inside the <body> or " +
						"<form> of this Page." +
						Environment.NewLine + Environment.NewLine + "Example" +
						Environment.NewLine + Environment.NewLine +
						" <ext:Script Manager runat=\"server\" />");
				}
				return this._scriptManager;
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PageLoadComplete(object sender, EventArgs e) {
			if (!((PageContainer)PageContainer).IsPageLoadCompleted) {
				((PageContainer)PageContainer).IsPageLoadCompleted = true;
				ThrowEvent("PageLoadComplete");
			}
		}

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AdministrativeObjectsByColumnsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeObjectsByColumnsGridPageEventsProcess(UserConnection);
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

		public virtual void ThrowClientEvent(string message, params object[] parameters) {
			string key = CopyParameters(parameters);
			ScriptManager.AddScript("if (window.opener) { if (window.key) {window.opener.Terrasoft.AjaxMethods.ThrowClientEvent(window.key, '" + message + "', '" + key + "')}}");
		}

		public virtual void AjaxRefresh() {
			ScriptManager.AddScript("window.Terrasoft.AjaxMethods.ThrowClientEvent(null, null);");
		}

		public virtual void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public virtual void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public virtual void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "AdministrativeObjectsByColumnsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeObjectsByColumnsGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeObjectsByColumnsGridPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public AdministrativeObjectsByColumnsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeObjectsByColumnsGridPageEventsProcessSchema(AdministrativeObjectsByColumnsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeObjectsByColumnsGridPageEventsProcess";
			UId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateFilterLeftExpressionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c40a9b6c-e442-46e3-b77e-fe9b77833ff9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"FilterLeftExpression",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleDetailIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("db673154-dfd7-4de3-8ab2-bfd69e8cd40f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"SysModuleDetailId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cc169a3c-42a9-4d0e-b4fc-e72df3a38a1d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"SysEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDetailGridParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b28fb770-d3db-4cd4-b813-29fe4d1080ab"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"IsDetailGrid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bbfec27b-a36b-4b27-86a5-999a2470f234"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"ListenerPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedNodePrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("422cb512-68d9-495a-a0cd-1227b6c5a499"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"SelectedNodePrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentGridSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c87d7fbd-1fee-4f19-8499-5746bec14a1f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"CurrentGridSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFilterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("402df1df-af1c-4149-8ccd-eb3d13a0f490"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"DataSourceFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentColumnMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c26e1369-afae-4729-b70c-ed86a3273f79"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"ParentColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ef5e0d6a-cd58-45cf-9740-d939a6a7a43d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"SubjectColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a281ca22-30f3-442d-81fa-380685465f1f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddToMenuItemMoveToParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2be4dbae-66b5-4335-b20a-fd147488d430"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"AddToMenuItemMoveTo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLocatedInEditPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c01d279d-db6f-4fa8-90d9-78cfde696a6f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"LocatedInEditPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUseModuleDetailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9d73b39-bdb5-49a5-bb77-545d1ad910e6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"UseModuleDetails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFilterLeftExpressionParameter());
			Parameters.Add(CreateSysModuleDetailIdParameter());
			Parameters.Add(CreateSysEntitySchemaIdParameter());
			Parameters.Add(CreateIsDetailGridParameter());
			Parameters.Add(CreateListenerPageParameter());
			Parameters.Add(CreateSelectedNodePrimaryColumnValueParameter());
			Parameters.Add(CreateCurrentGridSchemaNameParameter());
			Parameters.Add(CreateDataSourceFilterParameter());
			Parameters.Add(CreateParentColumnMetaPathParameter());
			Parameters.Add(CreateSubjectColumnUIdParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateAddToMenuItemMoveToParameter());
			Parameters.Add(CreateLocatedInEditPageParameter());
			Parameters.Add(CreateUseModuleDetailsParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet81 = CreateLaneSet81LaneSet();
			LaneSets.Add(schemaLaneSet81);
			ProcessSchemaLane schemaLane201 = CreateLane201Lane();
			schemaLaneSet81.Lanes.Add(schemaLane201);
			ProcessSchemaEventSubProcess subprocessgridpagerefreshrow = CreateSubProcessGridPageRefreshRowEventSubProcess();
			FlowElements.Add(subprocessgridpagerefreshrow);
			ProcessSchemaEventSubProcess subprocessgridactiverowchanged = CreateSubProcessGridActiveRowChangedEventSubProcess();
			FlowElements.Add(subprocessgridactiverowchanged);
			ProcessSchemaStartMessageEvent gridpagerefreshrow = CreateGridPageRefreshRowStartMessageEvent();
			subprocessgridpagerefreshrow.FlowElements.Add(gridpagerefreshrow);
			ProcessSchemaScriptTask scriptgridpagerefreshrow = CreateScriptGridPageRefreshRowScriptTask();
			subprocessgridpagerefreshrow.FlowElements.Add(scriptgridpagerefreshrow);
			ProcessSchemaStartMessageEvent gridactiverowchanged = CreateGridActiveRowChangedStartMessageEvent();
			subprocessgridactiverowchanged.FlowElements.Add(gridactiverowchanged);
			ProcessSchemaScriptTask scriptgridactiverowchanged = CreateScriptGridActiveRowChangedScriptTask();
			subprocessgridactiverowchanged.FlowElements.Add(scriptgridactiverowchanged);
			FlowElements.Add(CreateSequenceFlow616SequenceFlow());
			FlowElements.Add(CreateSequenceFlow617SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow616SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow616",
				UId = new Guid("f2d142af-4211-4af7-9c11-871eb293b83c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				CurveCenterPosition = new Point(152, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c51715dd-d2b7-4769-816d-1e5d33c73ee5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e0863e6-99c3-491d-bef2-2ba406daceb8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow617SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow617",
				UId = new Guid("ba7970ca-2a09-4153-a267-fa78ce2d4a42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				CurveCenterPosition = new Point(195, 246),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70c5cff7-87f6-48ae-a86d-aa69217e047a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5f2c9c1d-cdda-416f-8115-f52b7f0a412d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet81LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet81 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("64df468d-5999-477e-92c9-375f01983300"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"LaneSet81",
				Position = new Point(5, 5),
				Size = new Size(694, 366),
				UseBackgroundMode = false
			};
			return schemaLaneSet81;
		}

		protected virtual ProcessSchemaLane CreateLane201Lane() {
			ProcessSchemaLane schemaLane201 = new ProcessSchemaLane(this) {
				UId = new Guid("603af40b-aefa-4111-8688-74830f4a37ee"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("64df468d-5999-477e-92c9-375f01983300"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"Lane201",
				Position = new Point(29, 0),
				Size = new Size(665, 366),
				UseBackgroundMode = false
			};
			return schemaLane201;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessGridPageRefreshRowEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessGridPageRefreshRow = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7656d297-5452-4aa8-9c6c-b0792c89ee3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("603af40b-aefa-4111-8688-74830f4a37ee"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"SubProcessGridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(250, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessGridPageRefreshRow;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridPageRefreshRowStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c51715dd-d2b7-4769-816d-1e5d33c73ee5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7656d297-5452-4aa8-9c6c-b0792c89ee3a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"GridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridPageRefreshRowScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9e0863e6-99c3-491d-bef2-2ba406daceb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7656d297-5452-4aa8-9c6c-b0792c89ee3a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"ScriptGridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,207,110,194,48,12,198,239,60,69,213,19,147,166,190,0,218,97,226,159,144,216,84,209,141,123,214,126,64,166,144,32,199,41,226,237,231,208,118,135,137,77,171,232,45,137,63,255,62,219,113,173,40,217,105,242,188,70,13,51,3,43,109,114,114,37,188,79,158,146,92,237,145,45,52,76,21,79,83,103,37,108,65,89,188,173,172,103,101,75,100,173,124,50,250,133,147,21,96,57,158,64,124,217,42,19,48,78,103,138,85,225,2,149,88,104,195,160,244,49,249,249,244,208,135,87,192,160,100,84,175,174,66,78,250,168,232,50,117,38,28,237,53,46,244,191,5,189,188,114,69,176,220,100,191,136,54,87,124,16,135,91,207,194,237,51,193,27,102,107,237,25,162,143,242,171,201,30,29,244,185,140,57,3,82,71,158,73,219,125,82,107,156,167,50,39,249,255,37,120,219,222,198,195,54,211,170,222,87,85,91,192,119,94,7,146,208,253,150,93,245,98,210,181,53,240,252,122,53,114,135,103,17,62,62,101,133,155,5,107,220,150,65,87,217,252,120,226,203,0,252,149,111,22,127,73,58,178,153,2,254,59,254,183,3,185,243,188,150,245,31,167,49,61,6,55,216,17,252,97,227,206,105,92,45,2,7,178,87,234,228,11,103,225,177,189,115,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessGridActiveRowChangedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessGridActiveRowChanged = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8dc89185-d2f0-49f4-8a45-c232db7900c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("603af40b-aefa-4111-8688-74830f4a37ee"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"SubProcessGridActiveRowChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessGridActiveRowChanged;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridActiveRowChangedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("70c5cff7-87f6-48ae-a86d-aa69217e047a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8dc89185-d2f0-49f4-8a45-c232db7900c5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridActiveRowChanged",
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"GridActiveRowChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridActiveRowChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5f2c9c1d-cdda-416f-8115-f52b7f0a412d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8dc89185-d2f0-49f4-8a45-c232db7900c5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				Name = @"ScriptGridActiveRowChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,193,78,227,48,16,61,131,196,63,68,57,165,82,229,31,64,123,232,6,168,34,173,216,136,180,203,217,36,83,234,149,99,103,199,99,80,248,122,198,77,72,74,10,168,21,151,61,101,98,191,121,239,77,102,38,75,175,170,104,163,52,1,166,86,251,218,252,145,218,67,244,35,90,2,221,76,143,147,217,229,197,249,147,196,168,145,143,144,25,71,210,148,1,155,243,171,88,148,37,56,23,194,212,26,146,202,0,138,124,15,215,167,86,192,119,250,74,146,44,172,199,175,211,111,148,169,222,78,208,234,159,237,173,172,33,137,199,228,120,22,73,23,141,239,239,52,138,114,11,181,100,254,169,164,232,110,24,188,2,68,233,236,134,196,58,19,247,240,208,11,57,177,38,165,21,41,112,226,218,144,162,118,76,30,111,50,195,79,169,213,11,44,60,217,43,216,20,132,190,36,143,144,28,20,201,46,63,213,26,130,169,212,236,43,135,67,48,226,7,253,200,13,209,7,213,167,30,17,12,13,232,19,85,134,169,208,80,146,178,166,159,30,199,82,131,172,72,17,36,245,80,183,68,235,27,110,219,206,72,119,22,207,163,95,246,81,149,82,255,110,0,101,224,97,63,170,36,177,48,85,168,187,39,21,139,170,74,46,206,207,62,102,190,87,180,205,37,242,80,4,108,178,223,246,121,196,89,103,99,93,169,229,220,221,7,14,173,123,171,161,110,36,42,103,205,170,109,248,246,159,151,122,30,210,226,194,63,252,229,234,186,209,95,103,21,219,157,30,205,254,27,151,29,85,231,242,96,147,119,54,247,215,85,228,104,195,166,137,2,136,67,254,250,212,118,203,29,79,123,60,240,185,19,72,142,50,117,2,29,132,49,131,234,214,86,144,163,170,37,182,123,68,223,37,63,162,205,199,179,101,174,155,240,37,170,192,196,179,112,232,101,181,69,251,124,253,196,235,151,196,1,23,254,110,119,176,65,112,219,59,251,28,7,60,2,79,144,217,165,95,190,2,48,46,60,11,158,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetViewCodeMethod());
			Methods.Add(CreateGetFilterColumnValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("258be828-2e6d-4b0b-96f2-48307cb053be"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetViewCodeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b343dec3-0bef-48b5-9ac4-1409a61876f2"),
				Name = "GetViewCode",
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,65,10,131,48,16,69,215,230,20,211,141,216,77,46,16,92,73,23,93,20,186,240,2,49,142,26,212,177,196,88,40,197,187,55,19,5,43,132,144,153,255,230,255,36,179,119,150,90,48,83,141,144,195,28,43,121,27,95,254,163,196,91,59,120,105,135,228,75,93,5,245,169,91,148,188,21,19,121,109,9,93,168,88,6,61,67,64,148,176,13,100,199,196,37,7,90,134,225,10,95,145,52,147,67,109,58,200,216,212,122,28,193,210,97,46,31,72,75,228,18,214,77,135,166,231,214,157,193,124,227,67,70,241,223,87,1,230,188,51,188,103,66,154,158,93,100,156,197,122,11,73,246,247,158,145,82,183,108,154,84,225,170,61,159,86,17,214,42,28,250,197,81,252,35,245,3,116,246,151,142,48,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFilterColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cbd233a9-1358-4d49-b225-8c2791a1875e"),
				Name = "GetFilterColumnValue",
				CreatedInSchemaUId = new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,193,78,195,48,12,134,207,228,41,172,157,90,169,202,11,20,56,176,106,168,23,52,169,172,156,67,226,118,129,52,65,78,162,105,154,250,238,164,69,12,42,6,92,124,176,255,255,179,253,87,90,6,237,172,160,227,181,15,164,109,95,128,123,126,65,25,110,65,58,171,244,52,244,112,3,54,26,83,2,176,251,168,21,116,218,4,164,181,51,113,176,173,48,17,75,182,20,227,1,170,223,193,39,118,117,130,85,173,86,5,64,131,38,245,80,61,56,133,91,210,67,210,127,227,142,197,44,109,142,254,201,209,171,127,19,18,147,105,43,122,228,59,63,93,96,45,206,107,248,121,206,107,5,35,27,75,6,143,72,36,188,235,2,95,59,194,84,108,167,251,72,98,214,183,135,4,109,228,30,7,81,219,179,25,252,103,179,213,233,135,143,79,46,75,179,11,87,228,37,99,186,131,108,65,225,27,12,114,191,33,55,84,119,217,87,76,121,62,229,64,24,34,217,159,129,166,213,75,200,174,86,37,27,1,141,199,127,124,127,39,154,32,239,92,115,108,186,243,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeObjectsByColumnsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd6659a4-555b-4341-b7c6-aba67fe0d1b8"));
		}

		#endregion

	}

	#endregion

}

