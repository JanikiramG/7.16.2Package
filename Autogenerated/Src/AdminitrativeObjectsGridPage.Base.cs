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

	#region Class: AdminitrativeObjectsGridPageSchema

	/// <exclude/>
	public class AdminitrativeObjectsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public AdminitrativeObjectsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdminitrativeObjectsGridPageSchema(AdminitrativeObjectsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
			RealUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
			Name = "AdminitrativeObjectsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "250";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdminitrativeObjectsGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateAdminitrativeObjectsGridPageEventsProcessSchema() {
			var schema = new AdminitrativeObjectsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e");
			DataSource.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("81e96749-761b-4ca4-a3bd-9c06edb11723");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("a57ef752-8796-4bea-9f03-d7e41d860cc6");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5d031a2d-53b8-4768-bead-6347cf929ec0");
			if (column != null) {
				column.UId = new Guid("58846cb7-4ba1-46ea-a0e2-dfd5241da49b");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c7227eee-1b80-4db9-9f3a-cfdaa562ae3d");
			if (column != null) {
				column.UId = new Guid("7d11465f-b209-4c92-b481-a26a8477c0b0");
				column.Name = @"IsModule";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("356fed4d-7b90-41aa-9d61-2cfe1df9e9fc");
			if (column != null) {
				column.UId = new Guid("c6045f6a-ffd4-48ae-9ac2-10926453fee7");
				column.Name = @"IsLookup";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("278b1727-05db-41b5-a80c-72fc962430ee");
			if (column != null) {
				column.UId = new Guid("ae7244e6-31a1-46fe-aaf8-5393319b475e");
				column.Name = @"AdministratedByRecords";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c449bd15-1392-4a02-b1d3-f3852c194ebf");
			if (column != null) {
				column.UId = new Guid("779eab42-b74a-4d0f-a93d-41796bb307a2");
				column.Name = @"AdministratedByColumns";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b12eda60-9b6a-4295-a281-8bd1fd1c2d33");
			if (column != null) {
				column.UId = new Guid("49c986c1-e4c7-414c-91b8-e3260876c4bc");
				column.Name = @"AdministratedByOperations";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b7a4479c-74c2-4491-bca8-a03c0c093458");
			if (column != null) {
				column.UId = new Guid("4228d739-b8b4-4275-9fb0-baec19735b50");
				column.Name = @"SysWorkspace";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b076dce7-a486-4584-a06e-567972ab10c8");
			if (column != null) {
				column.UId = new Guid("ccae13f6-e46a-4592-8ff7-b07489adeba4");
				column.Name = @"IsTrackChangesInDB";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cae6a1ac-60f5-4170-9ef3-51435ebaec1a");
			if (column != null) {
				column.UId = new Guid("45bac8ec-e1c5-4a06-90ed-751f9fde43ae");
				column.Name = @"UId";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("117b0843-3caf-41b7-9f04-59ef867d640d");
			if (column != null) {
				column.UId = new Guid("85dcd52c-2647-4e40-93ff-43dd67d8fc7f");
				column.Name = @"IsInSSPEntitySchemaAccessList";
				column.CreatedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
				column.ModifiedInSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
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
			return new AdminitrativeObjectsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdminitrativeObjectsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdminitrativeObjectsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdminitrativeObjectsGridPageEventsProcess

	/// <exclude/>
	public class AdminitrativeObjectsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdminitrativeObjectsGridPageSchemaUserControl
	{

		public AdminitrativeObjectsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdminitrativeObjectsGridPageEventsProcess";
			SchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4");
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

		private ProcessFlowElement _subProcessInit;
		public ProcessFlowElement SubProcessInit {
			get {
				return _subProcessInit ?? (_subProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessInit",
					SchemaElementUId = new Guid("dea76f41-9b83-45d1-a371-b7041a9119a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageInit;
		public ProcessFlowElement StartMessageInit {
			get {
				return _startMessageInit ?? (_startMessageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInit",
					SchemaElementUId = new Guid("837113e2-ddee-4437-92a2-a71f382affda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAdminObjectsInit;
		public ProcessScriptTask ScriptAdminObjectsInit {
			get {
				return _scriptAdminObjectsInit ?? (_scriptAdminObjectsInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdminObjectsInit",
					SchemaElementUId = new Guid("58b13f90-fcc8-4685-bc80-6c7db85315ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdminObjectsInitExecute,
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
					SchemaElementUId = new Guid("dc97d57e-b312-4e08-b9c1-e89d270dbf4f"),
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
					SchemaElementUId = new Guid("0e380421-2e98-4e4b-850e-cb9b0ae4a752"),
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
					SchemaElementUId = new Guid("cb86240c-a8e6-495d-898f-dea6abc09576"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadParent;
		public ProcessThrowMessageEvent ThrowPageLoadParent {
			get {
				return _throwPageLoadParent ?? (_throwPageLoadParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadParent",
					SchemaElementUId = new Guid("cdf69d29-797e-426f-be4f-873a6f45aabf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[ScriptAdminObjectsInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdminObjectsInit };
			FlowElements[SubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess11 };
			FlowElements[PageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadChild };
			FlowElements[ScriptPageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadChild };
			FlowElements[ThrowPageLoadParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadParent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessInit":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("ScriptAdminObjectsInit");
						break;
					case "ScriptAdminObjectsInit":
						break;
					case "SubProcess11":
						break;
					case "PageLoadChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadChild");
						break;
					case "ScriptPageLoadChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadParent");
						break;
					case "ThrowPageLoadParent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageInit");
			ActivatedEventElements.Add("PageLoadChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInit";
					result = StartMessageInit.Execute(context);
					break;
				case "ScriptAdminObjectsInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdminObjectsInit";
					result = ScriptAdminObjectsInit.Execute(context, ScriptAdminObjectsInitExecute);
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
				case "ThrowPageLoadParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = ThrowPageLoadParent.Execute(context);
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

		public virtual bool ScriptAdminObjectsInitExecute(ProcessExecutingContext context) {
			var engineType = Page.UserConnection.DBEngine.DBEngineType;
			bool needRefreshMVwSysSchemaExtending = (engineType == DBEngineType.Oracle || engineType == DBEngineType.PostgreSql);
			if (needRefreshMVwSysSchemaExtending) {
				using (DBExecutor dbExecutor = Page.UserConnection.EnsureDBConnection()) {
					dbExecutor.RefreshMaterializedView("MVwSysSchemaExtending");
				}
			}
			Page.TreeGrid.AjaxEvents.CellIconClick.Event += CellIconClickHandler;
			Page.TreeGrid.AjaxEvents.CellIconClick.Timeout = 900000000; //NOTE: For ability to compile workspace
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(
				new Terrasoft.UI.WebControls.Controls.Parameter("nodeId", "nodeId", 
				Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(
				new Terrasoft.UI.WebControls.Controls.Parameter("iconId", "iconId", 
				Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			Page.DataSource.Loaded += Page.TreeGrid.DataLoaded;
			Page.TreeGrid.AjaxEvents.CellIconClick.ShowLoadMask = true;
			Page.TreeGrid.AjaxEvents.CellIconClick.ShowOpaqueMask = true;
			Page.DataSource.PrepareFilters += delegate (object sender, DataSourceEventArgs e)
			{
				var dataSource = Page.DataSource;
				var currentStructure = dataSource.CurrentStructure;
			
				var sysWorkspaceFilter = currentStructure.Filters.FindByName("SysWorkspaceFilter");
				if(sysWorkspaceFilter == null) {
					sysWorkspaceFilter = currentStructure.CreateFilterWithParameters(dataSource.Schema, 
									FilterComparisonType.Equal, "SysWorkspace", Page.UserConnection.Workspace.Id);
					
					sysWorkspaceFilter.Name = "SysWorkspaceFilter";
					currentStructure.Filters.Add(sysWorkspaceFilter);
				}
			};
			Page.DataSource.SaveError +=
			delegate(object sender, DataSourceEventArgs e) {
				Guid redactedId = e.Request == null ? Guid.Empty : e.Request.PrimaryColumnValue;
				if (redactedId != Guid.Empty) {
					Page.DataSource.LoadRow(redactedId);
				}
				ShowErrorMessage(e.Exception.Message);
				e.IsHandled = true;
			};
			Page.DataSource.LoadRowsResponseRegistered += delegate(object sender, DataSourceEventArgs e) {
				context.ThrowEventArgs = e;
				ThrowEvent(context, "DataSourceLoadRowsResponseRegistered");
			};
			return true;
		}

		public virtual bool ScriptPageLoadChildExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			
			var sysWorkspaceFilter = currentStructure.Filters.FindByName("SysWorkspaceFilter");
			if(sysWorkspaceFilter == null) {
				sysWorkspaceFilter = currentStructure.CreateFilterWithParameters(dataSource.Schema,
									FilterComparisonType.Equal, "SysWorkspace", Page.UserConnection.Workspace.Id);
				sysWorkspaceFilter.Name = "SysWorkspaceFilter";
				currentStructure.Filters.Add(sysWorkspaceFilter);
			}
			return true;
		}

		public virtual DataSourceStructure CreateStructure(string name, bool isModule, bool isLookup, bool administratedByOperations, bool administratedByColumns, bool administratedByRecords) {
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			var structure = new EntityDataSourceStructure(Page.UserConnection) {
				Name = name
			};
			dataSource.Structures.Add(structure);
			
			var column = schema.Columns.FindByName("Id");
			var structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//var qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = false;
			//qvStructureColumn.IsVisible = false;
			
			column = schema.Columns.FindByName("UId");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//var qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = false;
			//qvStructureColumn.IsVisible = false;
			
			column = schema.Columns.FindByName("Name");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = false;
			//qvStructureColumn.IsVisible = true;
			
			column = schema.Columns.FindByName("Caption");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = true;
			//qvStructureColumn.IsVisible = true;
			
			column = schema.Columns.FindByName("IsModule");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = !isModule;
			//qvStructureColumn.IsVisible = !isModule;
			
			column = schema.Columns.FindByName("IsLookup");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = !isLookup;
			//qvStructureColumn.IsVisible = !isLookup;
			
			column = schema.Columns.FindByName("AdministratedByOperations");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = !administratedByOperations;
			//qvStructureColumn.IsVisible = !administratedByOperations;
			
			column = schema.Columns.FindByName("AdministratedByColumns");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = !administratedByColumns;
			//qvStructureColumn.IsVisible = !administratedByColumns;
			
			column = schema.Columns.FindByName("AdministratedByRecords");
			structureColumn = structure.AddColumnByMetaPath(column.UId.ToString());
			//qvStructureColumn = structure.AddQuickViewColumnByMetaPath(column.UId.ToString());
			structureColumn.IsVisible = !administratedByRecords;
			//qvStructureColumn.IsVisible = !administratedByRecords;
			
			DataSourceFilter filter;
			if (isModule) {
				filter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "IsModule", true);
				filter.Name = "IsModuleFilter";
				structure.Filters.Add(filter);
			} else if (isLookup) {
				filter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "IsLookup", true);
				filter.Name = "IsLookupFilter";
				structure.Filters.Add(filter);
			} else if (administratedByOperations) {
				filter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "AdministratedByOperations", true);
				filter.Name = "AdministratedByOperationsFilter";
				structure.Filters.Add(filter);
			} else if (administratedByColumns) {
				filter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "AdministratedByColumns", true);
				filter.Name = "AdministratedByColumnsFilter";
				structure.Filters.Add(filter);
			} else if (administratedByRecords) {
				filter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "AdministratedByRecords", true);
				filter.Name = "AdministratedByRecordsFilter";
				structure.Filters.Add(filter);
			}
			//Код, который компилируется только в Workspace CR172137,CR172507
			filter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", Page.UserConnection.Workspace.Id);
			filter.Name = "SysWorkspaceFilter";
			structure.Filters.Add(filter);
			return structure;
		}

		public virtual DataSourceStructure CreateModuleStructure() {
			return CreateStructure("ModuleStructure", true, false, false, false, false);
		}

		public virtual DataSourceStructure CreateLookupStructure() {
			return CreateStructure("LookupStructure", false, true, false, false, false);
		}

		public virtual DataSourceStructure CreateAdministratedByOperationsStructure() {
			return CreateStructure("AdministratedByOperations", false, false, true, false, false);
		}

		public virtual DataSourceStructure CreateAdministratedByColumnsStructure() {
			return CreateStructure("AdministratedByColumns", false, false, false, true, false);
		}

		public virtual DataSourceStructure CreateAdministratedByRecordsStructure() {
			return CreateStructure("AdministratedByRecords", false, false, false, false, true);
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual void ShowErrorMessage(string errorMessage) {
			MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.Clear();
				messagePanel.AddMessage(Warning, errorMessage, MessageType.Warning);
			}
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public virtual void CellIconClickHandler(object sender, AjaxEventArgs e) {
			var nodeId = e.ExtraParameters["nodeId"];
			var iconId = e.ExtraParameters["iconId"];
			Guid newColumnValue = Guid.Empty;
			if ((nodeId != null) && (iconId != null)) {
				Guid recordId = (Guid)Json.Deserialize(nodeId, typeof(Guid));
				var columnName = (string)Json.Deserialize(iconId, typeof(String));
				var entity = Page.DataSource.Schema.CreateEntity(UserConnection);
				var param = new Dictionary<string, object>();
				//Код, который компилируется только в Workspace CR172137,CR172507
				param.Add("SysWorkspace", UserConnection.Workspace.Id);
				param.Add("Id", recordId);
				if (entity.FetchFromDB(param)) {
					string typedColumnValue = entity.GetTypedColumnValue<string>("Name");
					bool value = false;
					switch (columnName){
						case "AdministratedByOperations":
							value = UserConnection.DBSecurityEngine.GetIsEntitySchemaAdministratedByOperations(typedColumnValue);
							break;
						case "AdministratedByRecords":
							var dbSecurityEngine = UserConnection.DBSecurityEngine;
							value = GlobalAppSettings.UseMasterRecordRights
								? dbSecurityEngine.GetSchemaUseOwnRecordRights(typedColumnValue)
								: dbSecurityEngine.GetIsEntitySchemaAdministratedByRecords(typedColumnValue);
							break;
						case "AdministratedByColumns":
							value = UserConnection.DBSecurityEngine.GetIsEntitySchemaAdministratedByColumns(typedColumnValue);
							break;
					}
					entity.SetColumnValue(columnName, !value);
					try {
						entity.Save();
						MessagePanel messagePanel = ControlUtilities.FindControl(
						Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
						if (messagePanel != null) {
							messagePanel.Clear();
						}
					} catch (Exception exception) {
						ShowErrorMessage(exception.Message);
					}
				}
				var dataSource = Page.DataSource;
				var currentStructure = dataSource.CurrentStructure;
				var oneRecordFilter = currentStructure.Filters.FindByName("OneRecordFilter");
				if(oneRecordFilter != null) {
					currentStructure.Filters.Remove(oneRecordFilter);
				}
				oneRecordFilter = currentStructure.CreateFilterWithParameters(dataSource.Schema, 
					FilterComparisonType.Equal, "Id", recordId);
				oneRecordFilter.Name = "OneRecordFilter";
				var request = new DataSourceRequest();
				//Код, который компилируется только в Workspace CR172137,CR172507
				request.Filters.Add(Page.DataSource.CreateFilterWithParameters(FilterComparisonType.Equal,
							"SysWorkspace", UserConnection.Workspace.Id));
				request.PrimaryColumnValue = recordId;
				dataSource.LoadRow(recordId, request);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageInit")) {
							context.QueueTasks.Enqueue("StartMessageInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadChild")) {
							context.QueueTasks.Enqueue("PageLoadChild");
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

	#region Class: AdminitrativeObjectsGridPageEventsProcess

	/// <exclude/>
	public class AdminitrativeObjectsGridPageEventsProcess : AdminitrativeObjectsGridPageEventsProcess<Terrasoft.WebApp.AdminitrativeObjectsGridPageSchemaUserControl>
	{

		public AdminitrativeObjectsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdminitrativeObjectsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdminitrativeObjectsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
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
			var process = (AdminitrativeObjectsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdminitrativeObjectsGridPageEventsProcess(UserConnection);
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
			SchemaName = "AdminitrativeObjectsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdminitrativeObjectsGridPageEventsProcessSchema

	/// <exclude/>
	public class AdminitrativeObjectsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdminitrativeObjectsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdminitrativeObjectsGridPageEventsProcessSchema(AdminitrativeObjectsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdminitrativeObjectsGridPageEventsProcess";
			UId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748");
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
			ProcessSchemaLaneSet schemaLaneSet505 = CreateLaneSet505LaneSet();
			LaneSets.Add(schemaLaneSet505);
			ProcessSchemaLane schemaLane1680 = CreateLane1680Lane();
			schemaLaneSet505.Lanes.Add(schemaLane1680);
			ProcessSchemaEventSubProcess subprocessinit = CreateSubProcessInitEventSubProcess();
			FlowElements.Add(subprocessinit);
			ProcessSchemaEventSubProcess subprocess11 = CreateSubProcess11EventSubProcess();
			FlowElements.Add(subprocess11);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			subprocessinit.FlowElements.Add(startmessageinit);
			ProcessSchemaScriptTask scriptadminobjectsinit = CreateScriptAdminObjectsInitScriptTask();
			subprocessinit.FlowElements.Add(scriptadminobjectsinit);
			ProcessSchemaStartMessageEvent pageloadchild = CreatePageLoadChildStartMessageEvent();
			subprocess11.FlowElements.Add(pageloadchild);
			ProcessSchemaScriptTask scriptpageloadchild = CreateScriptPageLoadChildScriptTask();
			subprocess11.FlowElements.Add(scriptpageloadchild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadparent = CreateThrowPageLoadParentIntermediateThrowMessageEvent();
			subprocess11.FlowElements.Add(throwpageloadparent);
			FlowElements.Add(CreateSequenceFlow10003SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10034SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10035SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10003SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10003",
				UId = new Guid("a73b9ed1-9fc8-4429-b0cd-62cf54c12b14"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CurveCenterPosition = new Point(151, 728),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("837113e2-ddee-4437-92a2-a71f382affda"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58b13f90-fcc8-4685-bc80-6c7db85315ff"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10034SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10034",
				UId = new Guid("741e8c95-c1ed-47d8-b384-3a72d1d023af"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CurveCenterPosition = new Point(148, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e380421-2e98-4e4b-850e-cb9b0ae4a752"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb86240c-a8e6-495d-898f-dea6abc09576"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10035SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10035",
				UId = new Guid("f861baac-a7c5-413f-9eef-e1733ea05473"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CurveCenterPosition = new Point(239, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cb86240c-a8e6-495d-898f-dea6abc09576"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cdf69d29-797e-426f-be4f-873a6f45aabf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet505LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet505 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4bbe2478-d586-4705-abf9-95ce6fe37fab"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"LaneSet505",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(393, 366),
				UseBackgroundMode = false
			};
			return schemaLaneSet505;
		}

		protected virtual ProcessSchemaLane CreateLane1680Lane() {
			ProcessSchemaLane schemaLane1680 = new ProcessSchemaLane(this) {
				UId = new Guid("1e2b6732-ac27-4ebc-944d-11d61ba7c223"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4bbe2478-d586-4705-abf9-95ce6fe37fab"),
				CreatedInOwnerSchemaUId = new Guid("8c30fd20-309e-4de1-b82f-b81581656ed4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"Lane1680",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(364, 366),
				UseBackgroundMode = false
			};
			return schemaLane1680;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dea76f41-9b83-45d1-a371-b7041a9119a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1e2b6732-ac27-4ebc-944d-11d61ba7c223"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"SubProcessInit",
				Position = new Point(29, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(199, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("837113e2-ddee-4437-92a2-a71f382affda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dea76f41-9b83-45d1-a371-b7041a9119a3"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"StartMessageInit",
				Position = new Point(21, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdminObjectsInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("58b13f90-fcc8-4685-bc80-6c7db85315ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dea76f41-9b83-45d1-a371-b7041a9119a3"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"ScriptAdminObjectsInit",
				Position = new Point(98, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,93,79,34,49,20,125,134,132,255,208,229,105,136,166,238,235,106,200,6,17,93,18,191,2,168,207,101,122,129,106,105,199,219,142,192,174,251,223,247,118,102,96,80,199,93,220,72,76,44,237,61,231,158,251,201,147,64,6,102,170,12,140,86,9,176,54,187,22,83,224,55,14,176,107,141,129,216,43,107,248,201,113,47,51,217,28,130,237,81,163,62,182,86,51,3,32,7,48,65,112,179,139,219,197,112,229,134,241,12,230,162,183,244,96,164,50,83,226,140,182,61,180,217,54,11,191,66,17,107,96,207,207,236,47,70,215,214,249,41,194,240,81,183,200,173,154,176,232,95,94,91,236,87,163,94,75,93,16,16,17,215,18,226,212,91,100,114,188,57,86,199,218,51,46,69,56,57,46,175,162,86,78,86,43,177,124,237,90,120,64,37,180,250,9,242,86,193,34,106,86,138,105,6,213,181,223,141,58,253,101,62,71,8,112,134,74,242,206,189,88,246,158,192,120,199,187,160,117,63,182,166,171,85,252,192,179,75,182,215,102,47,174,127,8,35,53,224,209,206,52,35,53,7,155,122,138,245,219,215,226,115,196,14,14,46,175,70,189,67,118,74,73,16,99,165,149,95,49,111,89,108,231,137,162,82,44,44,62,184,68,196,176,187,216,165,71,113,45,80,204,129,242,225,120,71,202,136,2,54,176,96,35,64,20,206,78,60,191,233,243,59,24,83,90,61,90,77,12,235,195,6,23,53,141,149,208,151,205,125,86,158,136,230,3,20,23,4,227,3,177,104,181,118,79,209,103,137,87,196,152,139,223,156,62,77,124,127,78,95,207,149,11,133,108,150,148,196,215,73,146,230,218,252,68,120,49,180,41,198,192,207,173,144,32,67,255,188,36,10,38,249,219,238,9,26,206,236,34,96,46,132,123,32,255,30,83,248,24,248,42,17,143,41,84,192,183,4,95,35,36,2,225,84,233,80,132,32,92,130,134,41,205,23,139,236,248,158,38,145,57,26,38,192,125,86,162,50,143,29,156,58,6,173,70,61,204,232,19,173,51,185,121,95,143,120,137,56,42,108,226,20,145,176,67,82,19,123,154,119,178,44,97,188,251,234,149,80,5,206,173,220,221,122,60,114,173,132,124,77,198,139,40,232,191,145,199,171,75,42,111,212,28,190,65,230,91,65,77,162,42,210,54,51,169,214,197,226,217,205,107,23,129,210,149,191,223,41,63,43,123,58,218,138,45,95,77,89,111,102,159,220,190,75,179,47,80,57,107,178,125,219,123,76,133,166,78,222,22,77,253,92,181,47,55,239,188,47,179,128,106,213,138,121,72,67,104,223,138,68,100,176,119,179,24,6,242,45,223,102,165,86,52,211,80,60,65,15,145,214,219,94,187,81,95,55,210,110,125,148,101,252,44,85,146,33,72,17,123,144,125,73,178,105,50,129,154,56,76,96,94,26,246,157,5,43,222,155,39,180,62,15,75,3,106,101,53,23,184,234,90,157,206,205,173,208,89,191,215,194,143,214,22,227,151,246,22,188,40,115,213,16,15,236,98,11,182,14,186,22,198,42,139,240,2,156,35,88,68,53,91,198,144,100,37,41,238,50,99,42,139,203,127,53,100,57,124,85,57,43,156,185,1,184,196,26,7,3,152,210,190,1,204,183,200,127,228,144,86,128,135,165,231,163,25,146,214,205,43,165,50,232,42,111,163,194,144,218,173,100,123,95,77,54,53,33,0,4,234,18,147,135,244,7,234,233,46,124,198,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dc97d57e-b312-4e08-b9c1-e89d270dbf4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1e2b6732-ac27-4ebc-944d-11d61ba7c223"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"SubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0e380421-2e98-4e4b-850e-cb9b0ae4a752"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc97d57e-b312-4e08-b9c1-e89d270dbf4f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"PageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cb86240c-a8e6-495d-898f-dea6abc09576"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc97d57e-b312-4e08-b9c1-e89d270dbf4f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"ScriptPageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,203,106,195,48,16,60,215,224,127,16,62,57,96,244,3,33,135,198,109,161,151,18,112,75,206,139,180,73,68,108,201,93,73,1,83,250,239,93,213,37,205,195,129,232,178,160,121,236,236,28,128,132,134,0,141,139,164,80,44,196,10,182,40,159,142,63,243,60,59,48,69,69,34,180,161,9,20,85,136,148,136,255,42,89,95,160,44,26,101,126,240,107,71,123,223,131,194,23,211,6,36,22,94,122,201,17,241,60,173,94,14,111,208,97,89,52,87,202,98,198,182,102,83,78,121,46,132,141,109,59,19,95,121,246,112,223,206,154,16,194,31,190,54,97,183,2,226,189,41,70,121,114,88,163,118,216,65,197,174,191,111,164,215,174,235,129,140,119,246,125,232,81,62,127,70,104,43,113,150,184,168,198,30,63,124,162,91,139,42,24,103,229,17,151,175,58,93,51,145,85,166,243,57,240,84,1,73,113,179,188,71,173,39,170,73,91,190,243,140,144,185,86,176,8,231,63,141,194,94,91,242,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("cdf69d29-797e-426f-be4f-873a6f45aabf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc97d57e-b312-4e08-b9c1-e89d270dbf4f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Name = @"ThrowPageLoadParent",
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
			Methods.Add(CreateCreateStructureMethod());
			Methods.Add(CreateCreateModuleStructureMethod());
			Methods.Add(CreateCreateLookupStructureMethod());
			Methods.Add(CreateCreateAdministratedByOperationsStructureMethod());
			Methods.Add(CreateCreateAdministratedByColumnsStructureMethod());
			Methods.Add(CreateCreateAdministratedByRecordsStructureMethod());
			Methods.Add(CreateShowErrorMessageMethod());
			Methods.Add(CreateCellIconClickHandlerMethod());
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

		protected virtual SchemaMethod CreateCreateStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c4e0a033-3eb6-48c9-b89c-db27760594df"),
				Name = "CreateStructure",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructure"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("55a4a39c-2793-464c-b0e0-18418da8fc3d"),
				Name = "name",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8c5f8ba0-58ad-4c23-834a-957a65158147"),
				Name = "isModule",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8f8b323a-39ff-449c-94ac-2a2e469ca32d"),
				Name = "isLookup",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2dfb8ab0-a151-4411-9dc4-f8311f77b41e"),
				Name = "administratedByOperations",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7f1ecb53-fff1-47ad-98a4-c01b362900f4"),
				Name = "administratedByColumns",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7d614fd6-755d-4117-929e-0169f58f5334"),
				Name = "administratedByRecords",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,152,77,111,211,48,24,199,207,68,202,119,48,61,165,82,229,49,16,234,97,226,176,133,77,170,196,160,172,235,118,54,137,187,90,77,227,44,78,58,85,104,210,24,71,144,184,243,49,16,72,131,161,241,21,156,111,132,29,59,73,41,109,9,85,42,209,138,67,155,228,241,243,246,255,53,126,81,71,40,4,46,138,80,135,198,161,131,193,19,208,70,103,24,62,205,45,59,166,49,18,46,204,233,227,33,18,195,133,47,236,164,182,204,33,10,99,39,138,67,153,194,199,23,96,223,143,72,52,46,242,116,178,113,43,45,208,101,56,180,169,239,99,39,34,212,175,131,215,166,113,239,57,26,166,209,226,98,26,151,34,239,100,173,44,156,193,93,215,181,242,106,117,225,166,26,112,168,23,15,125,17,175,90,133,118,250,204,224,1,241,221,189,177,204,109,213,90,110,173,62,221,175,157,199,101,22,89,65,89,247,198,135,56,66,109,20,245,45,149,30,118,91,46,60,166,162,27,226,159,89,117,153,108,107,75,166,59,31,117,22,39,124,25,19,103,112,66,240,69,249,204,83,45,194,22,59,33,140,188,242,36,164,30,242,24,78,171,255,86,121,166,159,105,148,225,211,213,128,254,195,153,1,71,126,87,77,231,95,37,35,134,202,131,177,81,32,39,241,186,179,209,154,43,69,211,98,135,212,141,189,181,127,111,238,19,45,164,4,160,73,223,178,148,158,81,58,136,131,13,160,164,132,148,163,148,251,150,163,180,235,14,137,79,68,125,20,97,97,124,17,96,113,39,230,29,91,123,108,104,158,178,50,28,23,5,47,5,86,187,108,26,85,45,107,9,164,69,228,82,60,143,176,67,67,119,227,120,106,89,75,240,44,34,77,163,56,32,31,16,47,194,33,232,165,23,49,70,122,192,202,86,82,117,62,86,67,191,158,193,237,16,139,164,42,246,148,68,253,54,10,197,111,32,30,152,165,140,54,29,6,40,36,140,250,199,227,0,195,253,243,24,121,13,80,108,76,141,116,67,147,226,117,126,168,143,225,185,139,202,83,147,30,5,95,101,84,135,113,21,39,83,92,2,44,206,23,64,181,174,150,183,85,180,174,119,139,69,173,43,151,229,90,159,187,162,84,175,101,254,154,62,95,220,220,152,74,212,234,9,189,114,169,217,42,91,90,167,14,168,68,164,158,129,43,23,153,45,125,165,69,234,128,191,17,41,215,31,254,145,223,241,207,13,192,191,241,187,228,90,124,174,146,119,252,107,250,200,191,243,31,252,134,223,242,27,97,124,203,191,36,215,201,155,228,3,144,94,252,54,121,47,93,0,255,4,78,105,56,96,1,114,48,176,143,182,155,15,183,31,53,27,233,205,227,7,77,211,168,146,80,103,204,242,90,130,203,140,63,3,96,62,14,91,174,148,56,133,108,50,67,1,234,79,156,66,44,6,253,98,135,216,249,9,14,86,160,120,249,16,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateModuleStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2d686d95-9780-4b64-9af8-e3dbc5df7b05"),
				Name = "CreateModuleStructure",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructure"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,46,74,77,44,73,13,46,41,42,77,6,242,83,53,148,124,243,83,74,115,16,2,74,58,10,64,102,170,142,66,90,98,78,49,118,74,211,26,0,34,104,167,58,76,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateLookupStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("642a3e77-9c49-49fc-82bb-13b6f7ec110c"),
				Name = "CreateLookupStructure",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructure"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,46,74,77,44,73,13,46,41,42,77,6,242,83,53,148,124,242,243,179,75,11,224,2,74,58,10,105,137,57,197,169,58,10,64,145,84,56,7,153,210,180,6,0,84,169,65,92,76,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAdministratedByOperationsStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("468eb996-5e8a-45d8-96b8-3518be136fa0"),
				Name = "CreateAdministratedByOperationsStructure",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructure"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,46,74,77,44,73,13,46,41,42,77,6,242,83,53,148,28,83,114,51,243,50,139,75,138,128,194,41,78,149,254,5,169,64,86,102,126,94,177,146,142,66,90,98,78,113,42,156,2,234,73,69,21,211,180,6,0,50,124,211,113,86,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAdministratedByColumnsStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("76fe75e7-39cd-4753-9055-c1469578483d"),
				Name = "CreateAdministratedByColumnsStructure",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructure"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,46,74,77,44,73,13,46,41,42,77,6,242,83,53,148,28,83,114,51,243,50,139,75,138,128,194,41,78,149,206,249,57,165,185,121,197,74,58,10,105,137,57,197,169,232,20,80,31,140,163,105,13,0,138,90,20,90,83,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAdministratedByRecordsStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d536cdd2-907b-4190-95d3-a595375efee3"),
				Name = "CreateAdministratedByRecordsStructure",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructure"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,46,74,77,44,73,13,46,41,42,77,6,242,83,53,148,28,83,114,51,243,50,139,75,138,128,194,41,78,149,65,169,201,249,69,41,197,74,58,10,105,137,57,197,169,56,40,160,246,84,77,107,0,250,136,86,203,83,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowErrorMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5e76d0f6-a824-46f6-bc83-b05a3d237028"),
				Name = "ShowErrorMessage",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cdff3dea-0bdd-43d2-a45e-820fa0c55779"),
				Name = "errorMessage",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,49,11,194,48,16,133,231,246,87,156,157,18,8,193,189,116,168,133,110,133,14,138,131,56,4,114,150,64,76,203,93,58,136,248,223,45,18,33,58,29,247,189,199,247,6,100,54,19,142,38,160,135,123,254,52,208,205,33,210,236,79,209,121,23,29,178,238,93,176,9,138,178,24,183,170,110,121,249,220,132,249,178,191,42,168,14,134,113,200,100,149,130,72,43,74,48,12,57,175,75,119,3,241,51,187,107,32,172,222,75,120,150,69,30,232,206,163,33,33,235,63,220,90,155,140,226,108,40,184,48,41,64,162,153,18,85,223,193,227,99,65,157,42,155,229,245,6,1,57,42,200,250,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCellIconClickHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("578afe98-604f-40a7-90dd-a0b904e05667"),
				Name = "CellIconClickHandler",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("22f2f023-85f3-4a52-a887-b5386ff17a0c"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8d74405a-5238-4bec-b5cc-d9fdc64096c4"),
				Name = "e",
				CreatedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				ModifiedInSchemaUId = new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,205,142,27,69,16,62,143,159,162,51,135,104,44,141,38,9,8,173,20,179,65,235,159,93,45,34,236,202,38,228,16,229,208,59,83,187,110,50,211,61,233,238,177,99,208,74,73,56,130,196,157,199,64,32,5,130,194,43,140,223,136,234,159,153,181,199,236,6,16,226,96,217,238,170,250,234,171,175,186,171,22,84,18,46,50,56,206,200,62,129,100,242,66,75,122,74,37,45,64,131,84,79,66,103,11,159,14,122,11,244,100,169,224,215,121,58,155,241,60,170,88,70,56,44,71,34,175,10,254,37,205,43,192,16,115,154,76,138,82,175,6,61,118,78,162,200,167,189,181,79,120,149,231,125,114,251,54,137,124,130,230,172,79,190,233,5,22,78,66,42,100,102,115,71,230,160,255,169,18,60,25,131,2,201,104,206,190,6,15,23,19,189,42,65,156,59,167,254,160,23,24,222,169,101,242,57,114,53,241,74,75,198,47,118,17,92,242,22,97,230,220,26,12,224,154,233,21,198,159,210,11,72,198,84,211,153,168,100,10,201,44,157,67,65,147,145,4,170,97,98,189,162,71,136,58,18,156,67,170,153,224,13,68,105,228,66,4,212,134,140,153,53,81,185,250,216,241,137,137,56,251,10,253,31,68,198,253,206,157,250,199,250,93,253,115,76,234,223,234,119,235,215,248,121,185,254,174,254,213,254,173,127,175,255,168,223,212,111,235,55,120,248,109,253,203,250,245,250,213,250,7,98,188,234,183,235,239,141,11,169,127,34,143,133,124,166,74,154,2,25,77,239,237,125,112,239,195,189,216,254,248,232,238,94,47,176,92,146,131,44,139,194,217,74,181,174,97,76,182,185,39,173,41,57,206,12,179,141,64,108,119,220,118,198,216,76,95,157,78,201,33,232,116,126,40,69,49,30,70,54,196,53,51,112,197,90,141,179,237,11,226,3,143,64,127,209,49,122,133,30,68,161,105,97,104,50,5,103,66,228,100,225,67,207,105,174,192,156,170,37,195,180,36,186,106,120,223,36,13,82,170,128,132,7,89,193,56,67,48,108,84,54,92,157,148,128,191,176,70,21,222,55,78,65,3,215,81,96,60,156,65,90,73,36,55,225,23,140,131,161,120,172,92,167,93,243,175,5,142,186,117,90,238,200,30,47,203,179,193,181,204,166,86,211,43,90,146,100,103,219,28,222,207,114,176,85,210,81,46,206,104,126,80,150,51,208,26,181,84,9,134,63,164,10,223,174,75,54,101,23,115,173,108,76,240,201,78,58,83,178,43,21,195,78,150,124,51,102,183,70,135,114,255,47,81,110,20,206,215,253,47,85,115,1,255,117,51,61,234,123,57,93,226,199,95,97,212,120,195,113,227,50,198,228,214,162,141,213,114,101,95,68,27,69,23,16,57,212,135,160,20,78,153,83,202,33,39,197,230,159,125,130,181,104,41,242,71,154,229,76,51,80,201,33,227,153,63,140,76,176,157,79,7,170,180,223,222,160,158,220,125,26,147,112,136,178,109,98,227,243,213,18,233,16,170,200,230,185,37,97,30,243,86,238,118,82,91,214,193,166,45,25,229,64,165,103,111,148,184,36,41,181,47,113,242,34,133,210,40,79,160,249,229,1,102,115,177,156,72,41,164,207,28,181,14,137,63,233,123,93,47,221,248,204,218,153,187,59,133,155,65,95,73,137,114,226,232,174,82,93,73,227,120,21,149,140,58,86,31,36,56,184,139,119,200,114,124,15,24,211,133,73,156,197,105,61,92,153,86,70,225,201,118,88,232,6,96,212,69,219,82,237,90,224,41,20,2,219,223,9,54,144,88,252,223,32,232,182,143,179,63,102,122,126,181,153,163,172,187,170,98,130,76,156,235,72,20,56,156,25,110,66,51,115,147,201,243,138,230,120,79,118,6,123,135,65,226,87,233,142,6,94,81,9,207,43,80,186,89,117,45,129,169,59,255,127,54,156,39,209,74,108,86,86,119,119,223,32,219,13,2,217,235,255,79,214,166,169,183,161,115,42,89,129,91,127,123,247,53,90,163,223,70,187,62,19,52,155,138,101,212,88,227,70,88,196,187,252,19,161,18,225,158,186,9,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdminitrativeObjectsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("801c0f60-c97b-4d5e-8f6f-e5eed3df2748"));
		}

		#endregion

	}

	#endregion

}

