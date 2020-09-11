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
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.WebApp;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: VwSysProcessListPageSchema

	/// <exclude/>
	public class VwSysProcessListPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _runProcessButton;
		public Terrasoft.UI.WebControls.Controls.Button RunProcessButton {
			get {
				return _runProcessButton;
			}
		}

		#endregion

		#region Constructors: Public

		public VwSysProcessListPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public VwSysProcessListPageSchema(VwSysProcessListPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ImageAsSprite = true;
			AddButton.Enabled = true;
			AddButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateCopyButton() {
			CopyButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CopyButton.Image = new ControlImage {};
			CopyButton.Enabled = true;
			CopyButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateEditButton() {
			EditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			EditButton.Image = new ControlImage {};
			EditButton.Enabled = true;
			EditButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.Enabled = true;
			DeleteButton.Hidden = true;
			DeleteButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			RealUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			Name = "VwSysProcessListPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysProcessListPageEventsProcessSchema();
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
			ButtonsControlLayout.InsertItem(4, CreateSpacer1());
			ButtonsControlLayout.InsertItem(5, CreateRunProcessButton());
			ButtonsControlLayout.MoveItem(6, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(7, ActionButton);
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.MoveItem(9, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateVwSysProcessListPageEventsProcessSchema() {
			var schema = new VwSysProcessListPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("c62bb002-c545-451a-98a7-10e348034e22");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			_spacer1.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Pixel(10);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateRunProcessButton() {
			_runProcessButton = new Terrasoft.UI.WebControls.Controls.Button();
			_runProcessButton.UId = new Guid("8cfe4074-6867-4aac-bcef-a3e1bf2ddc76");
			_runProcessButton.Name = "RunProcessButton";
			_runProcessButton.CreatedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			_runProcessButton.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			_runProcessButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_runProcessButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_runProcessButton.Tag = "";
			_runProcessButton.Image = new ControlImage {};
			_runProcessButton.ImageAsSprite = false;
			_runProcessButton.Hidden = true;
			return _runProcessButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("842e74a2-e737-476c-b3d0-8aa3d5ddd229");
			DataSource.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("0b5c5abc-cd98-44d1-9ab1-53ba0a8835b1");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("461026e1-dfef-4930-8932-3abfec366e3a");
			if (column != null) {
				column.UId = new Guid("1736d44f-64bf-4f8c-9cdd-b0408909541a");
				column.Name = @"UId";
				column.CreatedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c97f8e06-d4ec-418a-9a9e-819c86536812");
			if (column != null) {
				column.UId = new Guid("0fc01af4-2937-46eb-8384-d080ef3bb52e");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5480f92c-1fb9-4b5d-b746-bf7ebb287bd2");
			if (column != null) {
				column.UId = new Guid("10a3b395-8a6a-43e5-b66e-9dc746b0460e");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1ae1e084-b27a-4812-acd7-500e96a84786");
			if (column != null) {
				column.UId = new Guid("06652acc-3bed-4b3b-bbbe-c0c3051dc654");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.ModifiedInSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new VwSysProcessListPageSchemaUserControl();
		}

		public override object Clone() {
			return new VwSysProcessListPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb98a036-e560-484d-9d68-36007533448c"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwSysProcessListPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessListPageEventsProcess

	/// <exclude/>
	public class VwSysProcessListPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.VwSysProcessListPageSchemaUserControl
	{

		#region Class: OpenProcessDesignerUserTaskFlowElement

		/// <exclude/>
		public class OpenProcessDesignerUserTaskFlowElement : OpenPageUserTask
		{

			public OpenProcessDesignerUserTaskFlowElement(UserConnection userConnection, VwSysProcessListPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenProcessDesignerUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowErrorMessageUserTaskFlowElement

		/// <exclude/>
		public class ShowErrorMessageUserTaskFlowElement : QuestionUserTask
		{

			public ShowErrorMessageUserTaskFlowElement(UserConnection userConnection, VwSysProcessListPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowErrorMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public VwSysProcessListPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysProcessListPageEventsProcess";
			SchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cb98a036-e560-484d-9d68-36007533448c");
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

		public virtual Guid ProcessSchemaUId {
			get;
			set;
		}

		public virtual string DisplayMode {
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
					SchemaElementUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClickChild;
		public ProcessFlowElement AddButtonClickChild {
			get {
				return _addButtonClickChild ?? (_addButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClickChild",
					SchemaElementUId = new Guid("733aca86-eafe-456b-9747-a40fcdd4485f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addOpenProcessDesignerScriptTask;
		public ProcessScriptTask AddOpenProcessDesignerScriptTask {
			get {
				return _addOpenProcessDesignerScriptTask ?? (_addOpenProcessDesignerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddOpenProcessDesignerScriptTask",
					SchemaElementUId = new Guid("b8b9e82e-685c-49fa-a2fa-e3f53bb60610"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddOpenProcessDesignerScriptTaskExecute,
				});
			}
		}

		private OpenProcessDesignerUserTaskFlowElement _openProcessDesignerUserTask;
		public OpenProcessDesignerUserTaskFlowElement OpenProcessDesignerUserTask {
			get {
				return _openProcessDesignerUserTask ?? (_openProcessDesignerUserTask = new OpenProcessDesignerUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _editButtonClickChild;
		public ProcessFlowElement EditButtonClickChild {
			get {
				return _editButtonClickChild ?? (_editButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditButtonClickChild",
					SchemaElementUId = new Guid("105cea1d-308f-4fad-8496-e03a6e682316"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _editOpenProcessDesignerScriptTask;
		public ProcessScriptTask EditOpenProcessDesignerScriptTask {
			get {
				return _editOpenProcessDesignerScriptTask ?? (_editOpenProcessDesignerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EditOpenProcessDesignerScriptTask",
					SchemaElementUId = new Guid("e414c00e-03ee-41bf-968d-66283727417b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EditOpenProcessDesignerScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _processDesignerClosed;
		public ProcessFlowElement ProcessDesignerClosed {
			get {
				return _processDesignerClosed ?? (_processDesignerClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProcessDesignerClosed",
					SchemaElementUId = new Guid("39dac27d-1a60-40f9-b7ce-0c18b8e305f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processDesignerClosedScriptTask;
		public ProcessScriptTask ProcessDesignerClosedScriptTask {
			get {
				return _processDesignerClosedScriptTask ?? (_processDesignerClosedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessDesignerClosedScriptTask",
					SchemaElementUId = new Guid("bb3a99d4-5aeb-453b-b118-4af43c354969"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessDesignerClosedScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _copyButtonClickScriptTask;
		public ProcessScriptTask CopyButtonClickScriptTask {
			get {
				return _copyButtonClickScriptTask ?? (_copyButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CopyButtonClickScriptTask",
					SchemaElementUId = new Guid("5607d250-35ba-4a1c-8f73-cffc8b155e40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CopyButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _copyButtonClickChild;
		public ProcessFlowElement CopyButtonClickChild {
			get {
				return _copyButtonClickChild ?? (_copyButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CopyButtonClickChild",
					SchemaElementUId = new Guid("d40426cd-b86a-4e67-9ed2-06e1b720aa9d"),
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
					SchemaElementUId = new Guid("d33497e2-375e-4074-bf0c-d74e75d3e2eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteButtonClickChild;
		public ProcessFlowElement DeleteButtonClickChild {
			get {
				return _deleteButtonClickChild ?? (_deleteButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClickChild",
					SchemaElementUId = new Guid("aa3d3780-f8ff-4eef-95d1-b0f826bcf599"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteButtonClickScriptTask;
		public ProcessScriptTask DeleteButtonClickScriptTask {
			get {
				return _deleteButtonClickScriptTask ?? (_deleteButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteButtonClickScriptTask",
					SchemaElementUId = new Guid("9f51b656-e62d-4aad-8510-9be13182c2db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _deleteYesMessageChild;
		public ProcessFlowElement DeleteYesMessageChild {
			get {
				return _deleteYesMessageChild ?? (_deleteYesMessageChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteYesMessageChild",
					SchemaElementUId = new Guid("401921ca-7fe1-44a7-b819-463fa9a22cb3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("4e373af6-dbd5-4809-a52e-bf9cb4fe5e69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("11a8fa62-3f53-49a2-98f0-cf878c48c9d4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _basePrepareFiltersChild;
		public ProcessFlowElement BasePrepareFiltersChild {
			get {
				return _basePrepareFiltersChild ?? (_basePrepareFiltersChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BasePrepareFiltersChild",
					SchemaElementUId = new Guid("bf59c077-8d69-438b-b77b-b925666fe776"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _basePrepareFilters;
		public ProcessThrowMessageEvent BasePrepareFilters {
			get {
				return _basePrepareFilters ?? (_basePrepareFilters = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BasePrepareFilters",
					SchemaElementUId = new Guid("5fc983a1-bc8b-4d54-bc35-3f8821c183f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BasePrepareFilters",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _applyFilterScriptTask;
		public ProcessScriptTask ApplyFilterScriptTask {
			get {
				return _applyFilterScriptTask ?? (_applyFilterScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ApplyFilterScriptTask",
					SchemaElementUId = new Guid("cd40f21f-dade-42c9-b9d2-eee17b7f40d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ApplyFilterScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess11;
		public ProcessFlowElement EventSubProcess11 {
			get {
				return _eventSubProcess11 ?? (_eventSubProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11",
					SchemaElementUId = new Guid("6590413c-899a-4d8a-a24d-761666bea7f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickChild;
		public ProcessFlowElement TreeGridDblClickChild {
			get {
				return _treeGridDblClickChild ?? (_treeGridDblClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClickChild",
					SchemaElementUId = new Guid("b2153889-d2b8-44df-823c-a2153bd70646"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwEditButtonClickChild;
		public ProcessThrowMessageEvent ThrowEditButtonClickChild {
			get {
				return _throwEditButtonClickChild ?? (_throwEditButtonClickChild = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowEditButtonClickChild",
					SchemaElementUId = new Guid("9c06cbc7-62c4-4962-8be7-ba75c075ee44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EditButtonClick",
				});
			}
		}

		private ProcessFlowElement _eventSubProcess12;
		public ProcessFlowElement EventSubProcess12 {
			get {
				return _eventSubProcess12 ?? (_eventSubProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess12",
					SchemaElementUId = new Guid("0f93ae30-d3a7-465c-8fbe-572afca5b84d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _runProcessButtonClick;
		public ProcessFlowElement RunProcessButtonClick {
			get {
				return _runProcessButtonClick ?? (_runProcessButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RunProcessButtonClick",
					SchemaElementUId = new Guid("fef2ab2b-f95d-4e5f-ae8a-57888c1a7f6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _runProcessScriptTask;
		public ProcessScriptTask RunProcessScriptTask {
			get {
				return _runProcessScriptTask ?? (_runProcessScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunProcessScriptTask",
					SchemaElementUId = new Guid("d5e8198c-9608-4425-a618-391071efd30e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RunProcessScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("2f0bc530-01e7-4ecb-a337-8325e85eb9d1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _showErrorMessage;
		public ProcessFlowElement ShowErrorMessage {
			get {
				return _showErrorMessage ?? (_showErrorMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShowErrorMessage",
					SchemaElementUId = new Guid("54dcd4a0-5e05-40dc-ab1f-fb906c5b74a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ShowErrorMessageUserTaskFlowElement _showErrorMessageUserTask;
		public ShowErrorMessageUserTaskFlowElement ShowErrorMessageUserTask {
			get {
				return _showErrorMessageUserTask ?? (_showErrorMessageUserTask = new ShowErrorMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("256e3395-a8e2-4182-a501-6adcceb3821e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeViewModeStartMessage1;
		public ProcessFlowElement ChangeViewModeStartMessage1 {
			get {
				return _changeViewModeStartMessage1 ?? (_changeViewModeStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeViewModeStartMessage1",
					SchemaElementUId = new Guid("97c66a2a-b4ba-4cc8-8fa7-17625516ed97"),
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
					SchemaElementUId = new Guid("25d847c9-22e0-4379-98aa-903ddedaf906"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private LocalizableString _defaultBisnessProcessCaption;
		public LocalizableString DefaultBisnessProcessCaption {
			get {
				return _defaultBisnessProcessCaption ?? (_defaultBisnessProcessCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DefaultBisnessProcessCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[AddButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickChild };
			FlowElements[AddOpenProcessDesignerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddOpenProcessDesignerScriptTask };
			FlowElements[OpenProcessDesignerUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenProcessDesignerUserTask };
			FlowElements[EditButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickChild };
			FlowElements[EditOpenProcessDesignerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EditOpenProcessDesignerScriptTask };
			FlowElements[ProcessDesignerClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessDesignerClosed };
			FlowElements[ProcessDesignerClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessDesignerClosedScriptTask };
			FlowElements[CopyButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CopyButtonClickScriptTask };
			FlowElements[CopyButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { CopyButtonClickChild };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[DeleteButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickChild };
			FlowElements[DeleteButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickScriptTask };
			FlowElements[DeleteYesMessageChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesMessageChild };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[BasePrepareFiltersChild.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePrepareFiltersChild };
			FlowElements[BasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePrepareFilters };
			FlowElements[ApplyFilterScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyFilterScriptTask };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[TreeGridDblClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickChild };
			FlowElements[ThrowEditButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowEditButtonClickChild };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[RunProcessButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcessButtonClick };
			FlowElements[RunProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcessScriptTask };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[ShowErrorMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowErrorMessage };
			FlowElements[ShowErrorMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowErrorMessageUserTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[ChangeViewModeStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeViewModeStartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "AddButtonClickChild":
						e.Context.QueueTasks.Enqueue("AddOpenProcessDesignerScriptTask");
						break;
					case "AddOpenProcessDesignerScriptTask":
						e.Context.QueueTasks.Enqueue("OpenProcessDesignerUserTask");
						break;
					case "OpenProcessDesignerUserTask":
						break;
					case "EditButtonClickChild":
						e.Context.QueueTasks.Enqueue("EditOpenProcessDesignerScriptTask");
						break;
					case "EditOpenProcessDesignerScriptTask":
						e.Context.QueueTasks.Enqueue("OpenProcessDesignerUserTask");
						break;
					case "ProcessDesignerClosed":
						e.Context.QueueTasks.Enqueue("ProcessDesignerClosedScriptTask");
						break;
					case "ProcessDesignerClosedScriptTask":
						break;
					case "CopyButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenProcessDesignerUserTask");
						break;
					case "CopyButtonClickChild":
						e.Context.QueueTasks.Enqueue("CopyButtonClickScriptTask");
						break;
					case "EventSubProcess9":
						break;
					case "DeleteButtonClickChild":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "DeleteButtonClickScriptTask":
						break;
					case "DeleteYesMessageChild":
						e.Context.QueueTasks.Enqueue("DeleteButtonClickScriptTask");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess8":
						break;
					case "BasePrepareFiltersChild":
						e.Context.QueueTasks.Enqueue("BasePrepareFilters");
						break;
					case "BasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ApplyFilterScriptTask");
						break;
					case "ApplyFilterScriptTask":
						break;
					case "EventSubProcess11":
						break;
					case "TreeGridDblClickChild":
						e.Context.QueueTasks.Enqueue("ThrowEditButtonClickChild");
						break;
					case "ThrowEditButtonClickChild":
						break;
					case "EventSubProcess12":
						break;
					case "RunProcessButtonClick":
						e.Context.QueueTasks.Enqueue("RunProcessScriptTask");
						break;
					case "RunProcessScriptTask":
						break;
					case "EventSubProcess13":
						break;
					case "ShowErrorMessage":
						e.Context.QueueTasks.Enqueue("ShowErrorMessageUserTask");
						break;
					case "ShowErrorMessageUserTask":
						break;
					case "EventSubProcess10":
						break;
					case "ChangeViewModeStartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AddButtonClickChild");
			ActivatedEventElements.Add("EditButtonClickChild");
			ActivatedEventElements.Add("ProcessDesignerClosed");
			ActivatedEventElements.Add("CopyButtonClickChild");
			ActivatedEventElements.Add("DeleteButtonClickChild");
			ActivatedEventElements.Add("DeleteYesMessageChild");
			ActivatedEventElements.Add("BasePrepareFiltersChild");
			ActivatedEventElements.Add("TreeGridDblClickChild");
			ActivatedEventElements.Add("RunProcessButtonClick");
			ActivatedEventElements.Add("ShowErrorMessage");
			ActivatedEventElements.Add("ChangeViewModeStartMessage1");
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
				case "AddButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickChild";
					result = AddButtonClickChild.Execute(context);
					break;
				case "AddOpenProcessDesignerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddOpenProcessDesignerScriptTask";
					result = AddOpenProcessDesignerScriptTask.Execute(context, AddOpenProcessDesignerScriptTaskExecute);
					break;
				case "OpenProcessDesignerUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenProcessDesignerUserTask";
					result = OpenProcessDesignerUserTask.Execute(context);
					break;
				case "EditButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditButtonClickChild";
					result = EditButtonClickChild.Execute(context);
					break;
				case "EditOpenProcessDesignerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditOpenProcessDesignerScriptTask";
					result = EditOpenProcessDesignerScriptTask.Execute(context, EditOpenProcessDesignerScriptTaskExecute);
					break;
				case "ProcessDesignerClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessDesignerClosed";
					result = ProcessDesignerClosed.Execute(context);
					break;
				case "ProcessDesignerClosedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessDesignerClosedScriptTask";
					result = ProcessDesignerClosedScriptTask.Execute(context, ProcessDesignerClosedScriptTaskExecute);
					break;
				case "CopyButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CopyButtonClickScriptTask";
					result = CopyButtonClickScriptTask.Execute(context, CopyButtonClickScriptTaskExecute);
					break;
				case "CopyButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "CopyButtonClickChild";
					result = CopyButtonClickChild.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickChild";
					result = DeleteButtonClickChild.Execute(context);
					break;
				case "DeleteButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickScriptTask";
					result = DeleteButtonClickScriptTask.Execute(context, DeleteButtonClickScriptTaskExecute);
					break;
				case "DeleteYesMessageChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesMessageChild";
					result = DeleteYesMessageChild.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "BasePrepareFiltersChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "BasePrepareFiltersChild";
					result = BasePrepareFiltersChild.Execute(context);
					break;
				case "BasePrepareFilters":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BasePrepareFilters");
					result = BasePrepareFilters.Execute(context);
					break;
				case "ApplyFilterScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyFilterScriptTask";
					result = ApplyFilterScriptTask.Execute(context, ApplyFilterScriptTaskExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "TreeGridDblClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickChild";
					result = TreeGridDblClickChild.Execute(context);
					break;
				case "ThrowEditButtonClickChild":
					context.QueueTasks.Dequeue();
					result = ThrowEditButtonClickChild.Execute(context);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "RunProcessButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "RunProcessButtonClick";
					result = RunProcessButtonClick.Execute(context);
					break;
				case "RunProcessScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RunProcessScriptTask";
					result = RunProcessScriptTask.Execute(context, RunProcessScriptTaskExecute);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "ShowErrorMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowErrorMessage";
					result = ShowErrorMessage.Execute(context);
					break;
				case "ShowErrorMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowErrorMessageUserTask";
					result = ShowErrorMessageUserTask.Execute(context);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeViewModeStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeViewModeStartMessage1";
					result = ChangeViewModeStartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
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
				case "DisplayMode":
					DisplayMode = reader.GetValue<System.String>();
				break;
				case "ProcessSchemaUId":
					ProcessSchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool AddOpenProcessDesignerScriptTaskExecute(ProcessExecutingContext context) {
			MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0],
				"BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.Remove("CustomPackageErrorMessage");
			}
			try {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageProcessDesign");
				ProcessSchemaUId = Guid.NewGuid();
				CreateProcess(ProcessSchemaUId);
				OpenProcessDesignerUserTask.OpenerInstanceId = InstanceUId;
				OpenProcessDesignerUserTask.UseCurrentActivePage = true;
				OpenProcessDesignerUserTask.PageUrl = "Designers/ProcessSchemaDesigner.aspx";
				OpenProcessDesignerUserTask.PageParameters = new Dictionary<string, string> {
					{"Id", ProcessSchemaUId.ToString()},
					{"viewMode", "1"},
					{"isNewSchema", "1"}
				};
				OpenProcessDesignerUserTask.CloseMessage = "ProcessDesignerClosed";
				return true;
			} catch (Exception e) {
				if (messagePanel != null) {
					messagePanel.AddMessage("CustomPackageErrorMessage", String.Empty, e.Message, MessageType.Error);
				}
				return false;
			}
		}

		public virtual bool EditOpenProcessDesignerScriptTaskExecute(ProcessExecutingContext context) {
			MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0],
				"BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.Remove("CustomPackageErrorMessage");
			}
			try {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageProcessDesign");
			} catch (Exception e) {
				if (messagePanel != null) {
					messagePanel.AddMessage("CustomPackageErrorMessage", String.Empty, e.Message, MessageType.Error);
				}
				return false;
			}
			ProcessSchemaUId = Page.DataSource.ActiveRowPrimaryColumnValue;
			var manager = UserConnection.ProcessSchemaManager;
			var designSchemaManagerItem = manager.DesignItem(UserConnection, ProcessSchemaUId);
			OpenProcessDesignerUserTask.OpenerInstanceId = InstanceUId;
			OpenProcessDesignerUserTask.UseCurrentActivePage = true;
			OpenProcessDesignerUserTask.PageUrl = "Designers/ProcessSchemaDesigner.aspx";
			OpenProcessDesignerUserTask.PageParameters = new Dictionary<string, string> {
				{"Id", ProcessSchemaUId.ToString()},
				{"viewMode", "1"}
			};
			OpenProcessDesignerUserTask.CloseMessage = "ProcessDesignerClosed";
			return true;
		}

		public virtual bool ProcessDesignerClosedScriptTaskExecute(ProcessExecutingContext context) {
			ISchemaManagerItem<ProcessSchema> processSchemaManagerItem = UserConnection.ProcessSchemaManager
				.FindItemByUId(ProcessSchemaUId);
			if (processSchemaManagerItem == null) {
				return true;
			}
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
			Page.DataSource.SelectedItemPrimaryColumnValues.Clear();
			Page.DataSource.SelectedItemPrimaryColumnValues.Add(ProcessSchemaUId);
			Page.DataSource.SetClientActiveRow(ProcessSchemaUId, true);
			return true;
		}

		public virtual bool CopyButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0],
				"BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.Remove("CustomPackageErrorMessage");
			}
			try {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageProcessDesign");
			} catch (Exception e) {
				if (messagePanel != null) {
					messagePanel.AddMessage("CustomPackageErrorMessage", String.Empty, e.Message, MessageType.Error);
				}
				return false;
			}
			var processSchemaUId = CreateNewModuleProcess();
			var manager = UserConnection.ProcessSchemaManager;
			var managerItem = manager.DesignItem(UserConnection, processSchemaUId);
			OpenProcessDesignerUserTask.OpenerInstanceId = InstanceUId;
			OpenProcessDesignerUserTask.UseCurrentActivePage = true;
			OpenProcessDesignerUserTask.PageUrl = "Designers/ProcessSchemaDesigner.aspx";
			OpenProcessDesignerUserTask.PageParameters = new Dictionary<string, string> {
				{"Id", processSchemaUId.ToString()},
				{"viewMode", "1"}
			};
			OpenProcessDesignerUserTask.CloseMessage = "ProcessDesignerClosed";
			return true;
		}

		public virtual bool DeleteButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0],
				"BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.Remove("CustomPackageErrorMessage");
			}
			try {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageProcessDesign");
			} catch (Exception e) {
				if (messagePanel != null) {
					messagePanel.AddMessage("CustomPackageErrorMessage", String.Empty, e.Message, MessageType.Error);
				}
				return false;
			}
			var manager = UserConnection.ProcessSchemaManager;
			var schemaUIds = new ObservableCollection<Guid>(Page.DataSource.SelectedItemPrimaryColumnValues);
			foreach (var processSchemaUId in Page.DataSource.SelectedItemPrimaryColumnValues) {
				manager.RemoveRunningProcessDataByUId(UserConnection, processSchemaUId);
				ProcessSchemaUId = processSchemaUId;
				manager.RemoveItemByUId(processSchemaUId, UserConnection);
			}
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
			return true;
		}

		public virtual bool ApplyFilterScriptTaskExecute(ProcessExecutingContext context) {
			var currentStructure = Page.DataSource.CurrentStructure;	
			var sysWorkspaceFilter = currentStructure.CreateFilterWithParameters(Page.DataSource.Schema, FilterComparisonType.Equal, "SysWorkspace", Page.UserConnection.Workspace.Id);	
			currentStructure.Filters.Add(sysWorkspaceFilter);
			var maxVersionFilter = Page.DataSource.FindFilterByName("MaxVersion");
			if (maxVersionFilter == null) {
				maxVersionFilter = currentStructure.CreateFilterWithParameters(Page.DataSource.Schema, FilterComparisonType.Equal, "IsMaxVersion", 1);
				maxVersionFilter.Name = "MaxVersion";
				currentStructure.Filters.Add(maxVersionFilter);
			} else {
				maxVersionFilter.IsEnabled = DisplayMode != "AllVersion";
			}
			return true;
		}

		public virtual bool RunProcessScriptTaskExecute(ProcessExecutingContext context) {
			MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0],
				"BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.Remove("CustomPackageErrorMessage");
			}
			try {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageProcessDesign");
			} catch (Exception e) {
				if (messagePanel != null) {
					messagePanel.AddMessage("CustomPackageErrorMessage", String.Empty, e.Message, MessageType.Error);
				}
				return false;
			}
			var processSchemaId = Page.DataSource.ActiveRowPrimaryColumnValue;
			var processSchemaManagerItem = UserConnection.ProcessSchemaManager.GetItemByUId(processSchemaId); 
			ProcessSchema processSchema = processSchemaManagerItem.SafeInstance;
			if (processSchema == null) {
				string caption = processSchemaManagerItem.Caption;
				ShowErrorMessageUserTask.Icon = "ERROR";
				ShowErrorMessageUserTask.Buttons = "OK";
				ShowErrorMessageUserTask.MessageText = string.Format(ModuleProcessInstanceNotExistMessage, caption);
				ShowErrorMessageUserTask.Page = Page;
				Page.ThrowEvent("ShowErrorMessage");
				return true;
			}
			var moduleProcess = processSchema.CreateProcess(UserConnection);
			if (processSchema.Parameters.ExistsByName("PageInstanceId")) {
				string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
				string pageInstanceId = instanceId + Page.PageContainer.UniqueID;
				moduleProcess.SetPropertyValue("PageInstanceId", pageInstanceId);
			}
			if (processSchema.Parameters.ExistsByName("Page")) {
				moduleProcess.SetPropertyValue("Page", Page);
			}
			moduleProcess.Execute(Page.UserConnection);
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Page.TreeGrid.Clear();
			Page.DataSource.LoadStructure(null, true);
			Page.DataSource.LoadRows();
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = base.GetButtons();
			buttons.Add(Page.RunProcessButton.Name);
			return buttons;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			bool isEnabled = false;
			if (Page.TreeGrid.SelectedNodes.Count != 0) {
				TreeGridNode node = Page.TreeGrid.SelectedNodes[0];
				var processSchemaName = node.Values["Name"].ToString();
				var managerItem = UserConnection.ProcessSchemaManager.FindItemByName(processSchemaName);
				if (managerItem != null && managerItem.ParentUId == Guid.Empty) {
					int version = UserConnection.ProcessSchemaManager.GetMaxVersionByParentUId(managerItem.UId);
					isEnabled = version == 0;
				}
			}
			Page.DeleteButton.Enabled = Page.DeleteButton.Enabled && isEnabled;
		}

		public override void InitializeContextHelpButton() {
			if (GetIsContextHelpButtonHidden() || !GetIsContextHelpEnabled()) {
				return;
			}
			bool useLMSDocumentation = false;
			object value;
			var userConnection = Page.UserConnection;
			if (Terrasoft.Core.Configuration.SysSettings.TryGetValue(userConnection, "UseLMSDocumentation", out value)) {
				useLMSDocumentation = Convert.ToBoolean(value);
			}
			if (!useLMSDocumentation) {
				base.InitializeContextHelpButton();
				return;
			}
			//string lmsUrl = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(userConnection, "LMSUrl", null);
			//lmsUrl = Terrasoft.Common.ServiceStackTextHelper.Serialize(lmsUrl);
			//string configurationVersion = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(userConnection,
			//	"ConfigurationVersion", null);
			//configurationVersion = Terrasoft.Common.ServiceStackTextHelper.Serialize(configurationVersion);
			string helpContextId = "99999";
			helpContextId = Terrasoft.Common.ServiceStackTextHelper.Serialize(helpContextId);
			var contextHelpButton = Page.ContextHelpButton;
			//contextHelpButton.CustomConfig.Add(new Terrasoft.UI.WebControls.Controls.ConfigItem("lmsUrl", lmsUrl));
			contextHelpButton.CustomConfig.Add(new Terrasoft.UI.WebControls.Controls.ConfigItem("helpContextId", helpContextId));
			contextHelpButton.CustomConfig.Add(new Terrasoft.UI.WebControls.Controls.ConfigItem("productEdition", "\"BPMS\""));
			//contextHelpButton.CustomConfig.Add(new Terrasoft.UI.WebControls.Controls.ConfigItem("configurationVersion", configurationVersion));
			contextHelpButton.Hidden = false;
			contextHelpButton.Image.Source = ControlImageSource.ResourceManager;
			contextHelpButton.Image.ResourceManagerName = "Terrasoft.WebApp";
			contextHelpButton.Image.ResourceItemName = "help.png";
			contextHelpButton.AjaxEvents.Click.OnClientEvent =
				"Terrasoft.HelpContext.showHelp(" +	helpContextId +	",'" + contextHelpButton.ClientID + "')";
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return String.Empty;
		}

		public override string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return String.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return String.Empty;
		}

		public virtual void CreateProcess(Guid processUId) {
			var schemaManager = Page.UserConnection.ProcessSchemaManager;
			var name = schemaManager.GenerateItemUniqueName(schemaManager.ItemName);
			var managerItem = schemaManager.CreateSchema(name, null, Page.UserConnection, Guid.NewGuid(), true);
			string caption = "Business Process";
			managerItem.Instance.Tag = caption;
			managerItem.Instance.PackageUId = WorkspaceUtilities.ForceGetCustomPackageUId(Page.UserConnection);
			var processSchemaCaption = new LocalizableString();
			var number = name.Remove(0, 7);
			var cultures = new List<CultureInfo>(GeneralResourceStorage.Cultures);
			//DefaultBisnessProcessCaption.HasValue;
			DefaultBisnessProcessCaption.LoadCultureValues();
			IDictionary<CultureInfo, string> cultureValues = DefaultBisnessProcessCaption.CultureValues;
			foreach(KeyValuePair<CultureInfo, string> cultureInfo in cultureValues) {
				string cultureValue = string.Concat(cultureInfo.Value, " ",number);
				processSchemaCaption.SetCultureValue(cultureInfo.Key, cultureValue);
				CultureInfo foundCulture = null;
				foreach (CultureInfo culture in cultures) {
					if (culture.Name == cultureInfo.Key.Name) {
						foundCulture = culture;
						break;
					}
				}
				if (foundCulture != null) {
					cultures.Remove(foundCulture);
				}
			}
			foreach (CultureInfo culture in cultures) {
				string cultureValue = string.Concat(caption, " ", number);
				processSchemaCaption.SetCultureValue(culture, cultureValue);
			}
			managerItem.Instance.Caption = processSchemaCaption;
			UserConnection.ProcessSchemaManager.BuildDefEventHandlerSchemaProperties((ProcessSchema)managerItem.Instance, new DesignModeEventDescriptor());
			UserConnection.ProcessSchemaManager.SaveDesignedItemInSessionData(UserConnection, (ProcessSchema)managerItem.Instance, managerItem.Instance.UId);				
			ProcessSchemaUId = managerItem.Instance.UId;
		}

		public virtual Guid CreateNewModuleProcess() {
			var processSchemaUId = Page.DataSource.ActiveRowPrimaryColumnValue;
			var manager = UserConnection.ProcessSchemaManager;
			var managerItemOld =  manager.GetItemByUId(processSchemaUId);
			var newModuleProcessSchemaId = Guid.NewGuid();
			var systemUserConnection = UserConnection.AppConnection.SystemUserConnection as SystemUserConnection;
			string schemaData = SchemaImporter.ExportSchema(managerItemOld.Id, systemUserConnection);
			schemaData = schemaData.Replace(processSchemaUId.ToString("D").ToLower(), newModuleProcessSchemaId.ToString("D").ToLower());
			schemaData = schemaData.Replace(managerItemOld.Name, GenerateModuleProcessUniqueName());
			var customPackageUId = WorkspaceUtilities.ForceGetCustomPackageUId(UserConnection);
			var sink = SchemaImporter.ImportSchemaToWorkspace(schemaData, customPackageUId, UserConnection);
			
			return newModuleProcessSchemaId;
		}

		public virtual string GenerateModuleProcessUniqueName() {
			string prefix = "ModuleProcess";
			string name;
			var entitySchemaColumnName = "Name";
			var entitySchemaName = "VwSysSchemaInWorkspace";
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName(entitySchemaName);
			var entitySchemaQueryFilterParameterName = entitySchemaColumnName;
			var entitySchemaQueryFilterParameterValue = prefix;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchemaName);
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Contain, entitySchemaQueryFilterParameterName, entitySchemaQueryFilterParameterValue));
			var entitySchemaColumn = entitySchemaQuery.AddColumn(entitySchemaColumnName);     
			var queryResult = entitySchemaQuery.GetEntityCollection(UserConnection);  
			if (queryResult.Count == 0) {
				name = string.Concat(prefix, "1");
				return name;
			}
			var queryStringsResult = new List<string>();
			foreach (var queryResultEntity in queryResult) {	
				var stringValue = queryResultEntity.GetTypedColumnValue<string>(entitySchemaColumn.ValueExpression.QueryColumnAlias);
				if (queryStringsResult.IndexOf(stringValue) < 0) {
					queryStringsResult.Add(stringValue);
				}
			}
			int counter = 0;
			bool nameIsUnique;
			do {
				counter++;
				name = string.Concat(prefix, counter.ToString(CultureInfo.InvariantCulture));
				nameIsUnique = true;
				foreach (var presentStringValue in queryStringsResult) {	
					if (name == presentStringValue) {
						nameIsUnique = false;
						break;
					}
				}
			} while (!nameIsUnique);
			return name;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClickChild")) {
							context.QueueTasks.Enqueue("AddButtonClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "EditButtonClick":
							if (ActivatedEventElements.Contains("EditButtonClickChild")) {
							context.QueueTasks.Enqueue("EditButtonClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "ProcessDesignerClosed":
							if (ActivatedEventElements.Contains("ProcessDesignerClosed")) {
							context.QueueTasks.Enqueue("ProcessDesignerClosed");
						}
						break;
					case "CopyButtonClick":
							if (ActivatedEventElements.Contains("CopyButtonClickChild")) {
							context.QueueTasks.Enqueue("CopyButtonClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClickChild")) {
							context.QueueTasks.Enqueue("DeleteButtonClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesMessageChild")) {
							context.QueueTasks.Enqueue("DeleteYesMessageChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("BasePrepareFiltersChild")) {
							context.QueueTasks.Enqueue("BasePrepareFiltersChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClickChild")) {
							context.QueueTasks.Enqueue("TreeGridDblClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "RunProcessButtonClick":
							if (ActivatedEventElements.Contains("RunProcessButtonClick")) {
							context.QueueTasks.Enqueue("RunProcessButtonClick");
						}
						break;
					case "ShowErrorMessage":
							if (ActivatedEventElements.Contains("ShowErrorMessage")) {
							context.QueueTasks.Enqueue("ShowErrorMessage");
						}
						break;
					case "ChangeViewMode":
							if (ActivatedEventElements.Contains("ChangeViewModeStartMessage1")) {
							context.QueueTasks.Enqueue("ChangeViewModeStartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("DisplayMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DisplayMode", DisplayMode, null);
			}
			if (!HasMapping("ProcessSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ProcessSchemaUId", ProcessSchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessListPageEventsProcess

	/// <exclude/>
	public class VwSysProcessListPageEventsProcess : VwSysProcessListPageEventsProcess<Terrasoft.WebApp.VwSysProcessListPageSchemaUserControl>
	{

		public VwSysProcessListPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysProcessListPageSchemaUserControl

	/// <exclude/>
	public partial class VwSysProcessListPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button RunProcessButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("RunProcessButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			CopyButton.AjaxEvents.Click.Event += CopyButtonClick;
			EditButton.AjaxEvents.Click.Event += EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
			RunProcessButton.AjaxEvents.Click.Event += RunProcessButtonClick;
			TreeGrid.AjaxEvents.DblClick.Event += TreeGridDblClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			CopyButton.AjaxEvents.Click.Event -= CopyButtonClick;
			EditButton.AjaxEvents.Click.Event -= EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
			RunProcessButton.AjaxEvents.Click.Event -= RunProcessButtonClick;
			TreeGrid.AjaxEvents.DblClick.Event -= TreeGridDblClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (VwSysProcessListPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new VwSysProcessListPageEventsProcess(UserConnection);
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

		public virtual void CopyButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CopyButtonClick");
		}

		public virtual void EditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EditButtonClick");
		}

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
		}

		public virtual void RunProcessButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("RunProcessButtonClick");
		}

		public virtual void TreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridDblClick");
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
			SchemaName = "VwSysProcessListPage";
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessListPageEventsProcessSchema

	/// <exclude/>
	public class VwSysProcessListPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysProcessListPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysProcessListPageEventsProcessSchema(VwSysProcessListPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysProcessListPageEventsProcess";
			UId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101");
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

		protected virtual ProcessSchemaParameter CreateProcessSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b6dd153d-3a0a-4b99-9375-18df57c812f6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ProcessSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDisplayModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("682cd7d2-917f-4cc8-b52a-fd4cc2a89d07"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"DisplayMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateProcessSchemaUIdParameter());
			Parameters.Add(CreateDisplayModeParameter());
		}

		protected virtual void InitializeOpenProcessDesignerUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("073efe62-8eec-4e96-b720-88ef1b9c3403"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("50f0b1a6-8780-4402-ae0d-1d47dfde7802"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("933fcfe8-3706-4697-9055-35f03a99ced3"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("714e2673-15fd-47b1-b32f-3b3e8c1db66a"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b0a93ed5-9b42-4062-a359-35aab2aaf663"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("39718f9d-c1d2-49e2-85e4-13ee26feb4a4"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9be5d04a-fc20-40d2-b547-469652d54cf4"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("79997d10-175f-4be3-a5eb-abe47dfc98f4"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("757cd680-e168-4ff5-9020-4ae6eb904b16"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("09a8b3a4-9cf1-43ae-adfe-fb9f72ce2718"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4f145a05-d837-4aeb-bb87-f8ca5f1ae9dc"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("8ed0d9a2-b1a8-458d-bdf9-c9811d385e13"),
				ContainerUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeShowErrorMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("95be5262-4173-4855-a29e-2a8e1a477c19"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b2f9e808-ac7f-47da-9aa4-22fc2724f5ae"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("54cb7362-0368-462e-9a51-1713c1d382b3"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("00e2ab80-039b-41c3-a46e-f45c0fc04da9"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("86e4a1ff-24eb-4242-81b8-d1660dfb8826"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0d880896-eea3-45c5-acae-dac1738e02fe"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c347ecf5-bddd-400b-a999-cda75ee253c4"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("149ca9b7-06e8-410d-b89b-c8730364ea01"),
				ContainerUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaLane schemaLane6 = CreateLane6Lane();
			schemaLaneSet1.Lanes.Add(schemaLane6);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent addbuttonclickchild = CreateAddButtonClickChildStartMessageEvent();
			eventsubprocess1.FlowElements.Add(addbuttonclickchild);
			ProcessSchemaScriptTask addopenprocessdesignerscripttask = CreateAddOpenProcessDesignerScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(addopenprocessdesignerscripttask);
			ProcessSchemaUserTask openprocessdesignerusertask = CreateOpenProcessDesignerUserTaskUserTask();
			eventsubprocess1.FlowElements.Add(openprocessdesignerusertask);
			ProcessSchemaStartMessageEvent editbuttonclickchild = CreateEditButtonClickChildStartMessageEvent();
			eventsubprocess1.FlowElements.Add(editbuttonclickchild);
			ProcessSchemaScriptTask editopenprocessdesignerscripttask = CreateEditOpenProcessDesignerScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(editopenprocessdesignerscripttask);
			ProcessSchemaStartMessageEvent processdesignerclosed = CreateProcessDesignerClosedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(processdesignerclosed);
			ProcessSchemaScriptTask processdesignerclosedscripttask = CreateProcessDesignerClosedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(processdesignerclosedscripttask);
			ProcessSchemaScriptTask copybuttonclickscripttask = CreateCopyButtonClickScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(copybuttonclickscripttask);
			ProcessSchemaStartMessageEvent copybuttonclickchild = CreateCopyButtonClickChildStartMessageEvent();
			eventsubprocess1.FlowElements.Add(copybuttonclickchild);
			ProcessSchemaStartMessageEvent deletebuttonclickchild = CreateDeleteButtonClickChildStartMessageEvent();
			eventsubprocess9.FlowElements.Add(deletebuttonclickchild);
			ProcessSchemaScriptTask deletebuttonclickscripttask = CreateDeleteButtonClickScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(deletebuttonclickscripttask);
			ProcessSchemaStartMessageEvent deleteyesmessagechild = CreateDeleteYesMessageChildStartMessageEvent();
			eventsubprocess9.FlowElements.Add(deleteyesmessagechild);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent basepreparefilterschild = CreateBasePrepareFiltersChildStartMessageEvent();
			eventsubprocess8.FlowElements.Add(basepreparefilterschild);
			ProcessSchemaIntermediateThrowMessageEvent basepreparefilters = CreateBasePrepareFiltersIntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(basepreparefilters);
			ProcessSchemaScriptTask applyfilterscripttask = CreateApplyFilterScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(applyfilterscripttask);
			ProcessSchemaStartMessageEvent treegriddblclickchild = CreateTreeGridDblClickChildStartMessageEvent();
			eventsubprocess11.FlowElements.Add(treegriddblclickchild);
			ProcessSchemaIntermediateThrowMessageEvent throweditbuttonclickchild = CreateThrowEditButtonClickChildIntermediateThrowMessageEvent();
			eventsubprocess11.FlowElements.Add(throweditbuttonclickchild);
			ProcessSchemaStartMessageEvent runprocessbuttonclick = CreateRunProcessButtonClickStartMessageEvent();
			eventsubprocess12.FlowElements.Add(runprocessbuttonclick);
			ProcessSchemaScriptTask runprocessscripttask = CreateRunProcessScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(runprocessscripttask);
			ProcessSchemaStartMessageEvent showerrormessage = CreateShowErrorMessageStartMessageEvent();
			eventsubprocess13.FlowElements.Add(showerrormessage);
			ProcessSchemaUserTask showerrormessageusertask = CreateShowErrorMessageUserTaskUserTask();
			eventsubprocess13.FlowElements.Add(showerrormessageusertask);
			ProcessSchemaStartMessageEvent changeviewmodestartmessage1 = CreateChangeViewModeStartMessage1StartMessageEvent();
			eventsubprocess10.FlowElements.Add(changeviewmodestartmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDefaultBisnessProcessCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDefaultBisnessProcessCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7f0e1a13-9747-4a7c-872c-795ab855d83d"),
				Name = "DefaultBisnessProcessCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("cb67b1f6-5ad4-4b8d-83bb-c6b1a24d7f9a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(122, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("733aca86-eafe-456b-9747-a40fcdd4485f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8b9e82e-685c-49fa-a2fa-e3f53bb60610"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d9e7c1e1-ed5c-4ee9-9f41-0b129b11e791"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(250, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b8b9e82e-685c-49fa-a2fa-e3f53bb60610"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("6417b1b9-13bc-4812-9a5c-84ecdd8d62e9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(168, 240),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("401921ca-7fe1-44a7-b819-463fa9a22cb3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9f51b656-e62d-4aad-8510-9be13182c2db"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("4ec6f1ee-8f54-4d55-817e-40c238488122"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(158, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("105cea1d-308f-4fad-8496-e03a6e682316"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e414c00e-03ee-41bf-968d-66283727417b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("50430468-81d3-4ad2-aad1-848a9cb630f4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(152, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aa3d3780-f8ff-4eef-95d1-b0f826bcf599"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4e373af6-dbd5-4809-a52e-bf9cb4fe5e69"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("b1b71e8c-639a-4371-8f7d-b425070bc57f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(499, 231),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("39dac27d-1a60-40f9-b7ce-0c18b8e305f2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb3a99d4-5aeb-453b-b118-4af43c354969"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("f445367d-7f3a-4714-9d7c-528ddece4690"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(146, 560),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf59c077-8d69-438b-b77b-b925666fe776"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5fc983a1-bc8b-4d54-bc35-3f8821c183f3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("dcd62a44-5150-4f9a-866d-66d5e1329791"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(242, 554),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5fc983a1-bc8b-4d54-bc35-3f8821c183f3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd40f21f-dade-42c9-b9d2-eee17b7f40d6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("657bd17f-c9eb-43d5-810c-2c87efb34c43"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(150, 910),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b2153889-d2b8-44df-823c-a2153bd70646"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9c06cbc7-62c4-4962-8be7-ba75c075ee44"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("60784dcf-428a-4b17-8755-a3350fa51ddd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fef2ab2b-f95d-4e5f-ae8a-57888c1a7f6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5e8198c-9608-4425-a618-391071efd30e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("64fd32e4-2584-4f29-aca0-59cec11ccc23"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(340, 1086),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54dcd4a0-5e05-40dc-ab1f-fb906c5b74a3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("bf540376-35eb-4341-b3d4-bfc8ad2fd458"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ea631318-01e8-4929-9de0-0ce6f4817c70"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(278, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e414c00e-03ee-41bf-968d-66283727417b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("0a52f308-ea60-4426-81d8-2e0a9ba2ecc6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ea631318-01e8-4929-9de0-0ce6f4817c70"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(296, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5607d250-35ba-4a1c-8f73-cffc8b155e40"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("cfb87064-ca40-4268-9c55-2c163480a683"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("ea631318-01e8-4929-9de0-0ce6f4817c70"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(153, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d40426cd-b86a-4e67-9ed2-06e1b720aa9d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5607d250-35ba-4a1c-8f73-cffc8b155e40"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("5d2aefc6-c946-40f5-bbe8-240a21a58da9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CurveCenterPosition = new Point(466, 661),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97c66a2a-b4ba-4cc8-8fa7-17625516ed97"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("25d847c9-22e0-4379-98aa-903ddedaf906"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("578e40f6-f734-46ef-8a27-b27519b1062c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(774, 1119),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("db43d6ec-9ce8-45af-a1e1-89d261b1ee68"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("578e40f6-f734-46ef-8a27-b27519b1062c"),
				CreatedInOwnerSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(745, 415),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("d792d80d-47da-454a-9767-7584c55656f2"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("578e40f6-f734-46ef-8a27-b27519b1062c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"Lane2",
				Position = new Point(29, 420),
				Size = new Size(745, 151),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("1c2b77b9-1ef2-4191-ad68-919f41264921"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("578e40f6-f734-46ef-8a27-b27519b1062c"),
				CreatedInOwnerSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 576),
				Size = new Size(745, 182),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("aaa45633-de01-4e66-a7a2-f8218fd0558f"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("578e40f6-f734-46ef-8a27-b27519b1062c"),
				CreatedInOwnerSchemaUId = new Guid("cb98a036-e560-484d-9d68-36007533448c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"Lane5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 763),
				Size = new Size(745, 175),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaLane CreateLane6Lane() {
			ProcessSchemaLane schemaLane6 = new ProcessSchemaLane(this) {
				UId = new Guid("b6c8719a-1d88-4bd1-815c-52dc11f45def"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("578e40f6-f734-46ef-8a27-b27519b1062c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"Lane6",
				Position = new Point(29, 943),
				Size = new Size(745, 176),
				UseBackgroundMode = false
			};
			return schemaLane6;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db43d6ec-9ce8-45af-a1e1-89d261b1ee68"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(595, 401),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("733aca86-eafe-456b-9747-a40fcdd4485f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"AddButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddOpenProcessDesignerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b8b9e82e-685c-49fa-a2fa-e3f53bb60610"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"AddOpenProcessDesignerScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,193,142,218,48,16,61,131,196,63,184,57,5,41,114,187,231,237,86,98,67,90,113,160,139,10,156,170,30,44,103,22,44,18,59,26,59,64,180,202,191,239,216,73,90,224,176,244,228,248,205,123,111,102,60,147,37,88,43,118,176,18,26,10,86,94,94,158,88,106,180,67,83,108,157,42,148,83,96,249,119,165,243,30,140,87,68,228,51,91,133,179,7,237,239,47,127,146,201,120,20,61,11,11,203,11,179,40,97,14,107,152,50,97,217,37,254,56,25,171,87,22,95,229,253,244,196,116,93,20,83,246,70,78,151,17,254,11,74,115,132,56,74,107,235,76,185,18,242,64,161,12,209,96,239,25,77,201,176,157,140,29,54,65,189,181,128,84,154,6,233,148,209,124,254,188,6,89,163,114,77,166,119,74,83,217,123,144,135,84,232,236,76,184,131,151,10,80,120,38,165,16,122,41,180,207,140,70,146,249,28,172,218,233,224,63,234,161,181,220,67,41,182,139,156,94,234,71,173,114,254,19,78,254,140,3,41,69,16,110,80,199,183,146,64,161,116,250,202,30,208,23,188,17,246,192,125,12,112,161,173,19,90,66,200,49,92,72,126,79,77,31,105,141,8,218,205,168,243,35,248,25,145,131,31,193,61,169,167,110,209,79,63,26,98,246,243,85,249,3,204,133,173,206,209,255,248,173,4,138,18,28,57,145,173,134,19,155,171,48,16,129,205,87,235,80,233,93,194,186,243,91,24,219,232,45,90,228,180,50,183,175,198,55,102,29,104,241,180,77,58,222,81,193,105,105,114,32,118,244,16,13,168,178,52,139,78,214,7,8,111,239,149,154,22,230,239,214,250,254,111,120,33,156,135,134,17,92,141,122,120,207,150,73,225,228,158,197,217,89,66,229,27,99,208,109,239,199,187,125,189,220,179,60,239,115,127,180,224,9,235,94,128,103,101,229,154,132,1,239,35,201,240,95,109,154,10,120,208,132,37,107,255,149,251,42,10,27,234,125,7,4,170,62,128,244,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenProcessDesignerUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("09ae9416-df13-4d26-bf54-2bc9e6df70ab"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"OpenProcessDesignerUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 37),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenProcessDesignerUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("105cea1d-308f-4fad-8496-e03a6e682316"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EditButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEditOpenProcessDesignerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e414c00e-03ee-41bf-968d-66283727417b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EditOpenProcessDesignerScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,143,218,48,16,61,131,196,127,112,115,10,82,228,182,231,118,87,218,13,84,226,128,138,22,232,165,234,97,228,204,130,69,98,71,99,135,15,173,248,239,29,59,161,34,172,180,244,228,100,102,222,243,188,55,227,57,58,7,27,92,128,193,82,84,215,63,15,34,183,198,147,45,215,94,151,218,107,116,242,135,54,69,23,76,23,92,40,159,92,29,207,46,232,126,127,249,147,141,134,131,228,25,28,206,175,200,146,76,120,106,112,44,192,137,235,248,183,209,80,191,138,180,119,239,167,7,97,154,178,28,139,55,102,186,206,200,23,172,236,30,211,36,111,156,183,213,2,212,142,83,83,34,75,29,103,50,102,194,243,104,232,233,20,209,107,135,196,173,25,84,94,91,35,39,207,75,84,13,105,127,154,154,141,54,220,246,22,213,46,7,51,61,114,220,227,207,26,9,66,37,95,1,102,14,38,220,76,86,49,249,4,157,222,152,150,95,40,240,106,43,210,233,81,97,29,202,5,182,205,126,44,165,175,229,169,40,186,166,63,210,147,137,165,39,109,54,114,90,213,254,148,9,148,93,38,187,216,184,58,213,40,35,38,244,54,96,241,3,66,223,144,17,175,80,58,108,253,232,68,44,213,22,43,88,207,10,158,109,28,219,4,60,44,109,67,138,39,201,22,237,241,197,30,22,164,43,160,83,110,203,166,50,191,160,108,2,199,30,72,84,209,15,98,236,141,173,61,246,214,53,234,48,69,180,173,151,153,121,172,152,163,99,147,173,177,33,152,246,105,51,113,219,117,16,200,35,50,189,145,32,5,216,10,220,78,134,28,243,27,231,193,40,140,42,47,63,140,190,3,230,143,188,33,66,227,91,39,130,63,76,16,182,246,14,50,84,174,41,188,151,228,146,115,159,123,189,95,194,18,92,125,76,254,131,110,1,4,21,122,38,98,86,131,7,49,209,209,19,158,203,119,23,23,34,19,237,249,24,87,235,45,153,21,201,123,195,228,202,182,235,147,142,207,89,44,219,107,60,204,109,17,22,43,249,154,240,102,156,239,116,147,151,246,223,75,14,10,111,234,98,186,8,146,186,165,139,126,253,5,131,15,91,144,84,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProcessDesignerClosedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("39dac27d-1a60-40f9-b7ce-0c18b8e305f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProcessDesignerClosed",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ProcessDesignerClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(372, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessDesignerClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb3a99d4-5aeb-453b-b118-4af43c354969"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ProcessDesignerClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(470, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,65,75,196,48,16,133,207,22,250,31,114,236,130,228,15,232,10,187,21,165,160,80,182,174,247,161,121,106,32,157,200,36,113,89,196,255,110,90,47,149,237,234,113,102,222,247,102,222,52,93,255,134,129,30,137,233,21,210,68,12,215,173,248,30,33,252,12,110,212,251,188,156,233,212,90,237,3,164,246,204,232,163,245,172,219,5,101,89,92,232,59,203,102,36,182,199,125,99,170,95,170,220,88,93,149,133,125,81,213,249,61,107,197,201,185,149,250,204,102,130,152,132,85,148,132,204,125,149,69,155,117,250,73,128,123,177,70,215,14,36,213,104,57,245,111,41,82,231,147,244,208,15,158,204,206,31,194,226,176,131,203,25,48,93,217,138,29,72,142,181,119,105,224,103,114,9,225,15,219,255,200,141,89,78,124,234,19,107,103,193,113,147,127,249,129,124,233,9,118,57,165,30,225,249,19,190,1,186,251,21,245,193,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCopyButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5607d250-35ba-4a1c-8f73-cffc8b155e40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"CopyButtonClickScriptTask",
				Position = new Point(120, 275),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,193,142,155,48,16,61,39,82,254,193,245,137,72,200,109,207,237,86,202,18,42,229,144,22,53,201,169,234,193,130,217,196,10,216,104,108,178,65,171,252,123,199,6,42,216,149,54,61,25,207,204,123,51,239,121,216,130,181,242,8,153,212,80,178,106,124,121,96,137,209,14,77,121,112,170,84,78,129,21,223,149,46,250,96,148,81,161,88,217,58,156,125,208,254,254,244,39,94,204,103,252,81,90,216,142,200,120,204,28,54,176,100,210,178,113,252,203,98,174,158,88,52,233,251,225,129,233,166,44,151,236,133,152,198,25,241,11,42,115,129,136,39,141,117,166,202,100,126,166,84,138,104,176,231,228,75,34,188,45,230,14,219,128,62,88,64,26,77,67,238,148,209,98,253,184,131,188,65,229,218,84,31,149,166,177,79,144,159,19,169,211,43,197,29,252,172,1,165,175,164,22,82,111,165,246,157,209,228,68,190,6,171,142,186,227,103,185,116,249,137,69,233,53,135,218,151,51,232,134,125,95,202,84,203,170,40,250,161,223,211,19,179,157,67,165,143,34,173,106,215,198,12,68,159,137,7,27,247,109,13,34,96,252,108,51,18,63,67,112,13,106,246,36,75,11,157,31,23,137,172,238,132,236,242,19,84,242,176,41,252,251,34,72,7,63,224,121,107,138,166,28,164,70,158,200,35,170,96,0,82,225,43,31,179,49,85,103,19,78,49,27,7,21,225,250,155,232,220,243,193,104,74,21,191,25,203,55,167,119,208,19,223,1,61,108,47,237,89,248,28,241,107,235,164,206,33,200,24,46,132,190,3,166,143,164,65,4,237,86,212,254,2,126,119,137,192,175,230,29,164,175,60,160,255,41,248,144,179,31,39,62,12,97,33,109,125,229,255,65,151,73,148,21,56,34,34,86,13,207,108,173,130,39,18,219,175,54,188,122,204,186,243,91,216,159,23,190,41,248,91,195,196,222,116,59,18,45,111,113,40,187,168,240,162,126,123,248,103,78,207,127,187,51,77,82,154,127,191,171,87,248,170,46,164,11,47,169,223,172,224,215,95,66,41,154,63,57,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCopyButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d40426cd-b86a-4e67-9ed2-06e1b720aa9d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e49b780b-43ef-4fe9-881e-26a84f64a8dc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CopyButtonClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"CopyButtonClickChild",
				Position = new Point(29, 289),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d33497e2-375e-4074-bf0c-d74e75d3e2eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d792d80d-47da-454a-9767-7584c55656f2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EventSubProcess9",
				Position = new Point(29, 2),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(402, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("aa3d3780-f8ff-4eef-95d1-b0f826bcf599"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d33497e2-375e-4074-bf0c-d74e75d3e2eb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"DeleteButtonClickChild",
				Position = new Point(28, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9f51b656-e62d-4aad-8510-9be13182c2db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d33497e2-375e-4074-bf0c-d74e75d3e2eb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"DeleteButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,205,107,219,48,20,63,39,144,255,65,203,201,1,99,118,207,50,104,28,175,20,22,26,226,166,151,177,195,171,252,146,136,202,146,121,146,210,154,177,255,125,146,229,130,227,64,97,167,224,247,241,251,210,203,22,141,129,19,238,64,161,100,245,240,99,197,114,173,44,105,121,176,66,10,43,208,100,63,132,170,250,98,178,243,131,217,157,105,186,223,190,104,126,125,253,157,206,166,147,249,26,12,110,7,96,243,148,89,114,184,96,96,216,176,190,156,77,197,145,37,87,188,95,86,76,57,41,23,236,143,71,26,118,178,61,214,250,130,201,60,119,198,234,122,7,252,213,183,10,34,77,61,230,124,225,1,255,206,166,150,218,110,251,96,144,188,52,133,220,10,173,178,205,186,68,238,72,216,182,80,39,161,188,236,51,242,215,28,84,241,238,235,22,31,27,36,8,147,158,2,212,22,84,96,38,205,61,248,6,141,56,169,136,207,56,88,126,102,73,241,206,177,9,227,12,163,216,207,173,92,123,185,171,170,94,244,103,126,82,86,90,18,234,148,21,117,99,219,148,97,214,119,210,143,24,159,218,6,179,110,39,104,155,120,243,19,66,235,72,177,35,72,131,49,143,11,16,171,59,59,228,159,117,148,74,239,176,228,103,172,33,154,166,101,220,49,93,237,240,80,25,191,166,240,141,61,190,248,221,11,188,72,204,181,148,17,224,219,189,19,213,247,120,15,27,176,80,106,71,28,179,18,67,31,171,7,139,245,142,68,13,212,250,29,87,171,103,144,14,77,80,123,212,132,16,146,12,92,205,80,134,167,100,66,177,255,197,140,39,19,45,244,215,178,119,74,249,0,63,158,209,99,173,91,143,158,92,135,144,222,208,119,105,238,198,154,86,55,115,203,27,198,32,46,114,140,103,211,81,244,253,181,118,46,159,8,241,158,68,149,229,18,129,146,208,26,187,255,169,161,218,235,55,211,53,251,71,14,255,170,229,63,218,53,228,31,196,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesMessageChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("401921ca-7fe1-44a7-b819-463fa9a22cb3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d33497e2-375e-4074-bf0c-d74e75d3e2eb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"DeleteYesMessageChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4e373af6-dbd5-4809-a52e-bf9cb4fe5e69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d33497e2-375e-4074-bf0c-d74e75d3e2eb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("11a8fa62-3f53-49a2-98f0-cf878c48c9d4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c2b77b9-1ef2-4191-ad68-919f41264921"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(305, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBasePrepareFiltersChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bf59c077-8d69-438b-b77b-b925666fe776"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a8fa62-3f53-49a2-98f0-cf878c48c9d4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"BasePrepareFiltersChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBasePrepareFiltersIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("5fc983a1-bc8b-4d54-bc35-3f8821c183f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a8fa62-3f53-49a2-98f0-cf878c48c9d4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"BasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateApplyFilterScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cd40f21f-dade-42c9-b9d2-eee17b7f40d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a8fa62-3f53-49a2-98f0-cf878c48c9d4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ApplyFilterScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,144,79,107,131,64,16,197,207,17,252,14,91,79,10,178,208,179,228,144,154,4,60,164,4,108,155,243,212,157,54,75,215,93,187,127,66,165,228,187,119,23,139,136,134,222,122,28,230,205,251,189,55,23,208,164,113,90,163,180,181,213,174,177,78,35,89,147,35,188,35,221,130,133,90,57,221,32,45,103,146,98,21,71,23,127,106,122,115,82,250,195,116,208,224,158,11,139,218,31,207,253,104,169,17,236,239,254,196,237,249,8,26,90,244,131,73,231,160,186,57,99,11,57,25,196,165,106,59,208,220,40,249,212,119,72,119,159,14,68,78,146,122,66,77,242,33,236,179,9,114,41,177,177,92,73,58,238,105,197,178,144,118,17,106,32,24,186,97,44,93,214,200,138,161,96,11,95,47,94,229,45,199,122,243,200,123,46,217,176,124,232,31,125,175,52,57,140,71,73,240,225,111,36,93,250,172,137,116,66,100,228,59,142,86,55,40,255,254,196,202,76,98,230,228,62,36,93,4,161,161,144,79,51,173,20,116,127,126,115,110,18,156,175,4,133,193,155,101,105,101,118,18,94,5,50,15,218,114,211,9,232,15,138,33,185,243,220,141,16,19,238,53,142,52,122,158,36,30,140,197,15,114,41,107,151,189,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6590413c-899a-4d8a-a24d-761666bea7f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aaa45633-de01-4e66-a7a2-f8218fd0558f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b2153889-d2b8-44df-823c-a2153bd70646"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6590413c-899a-4d8a-a24d-761666bea7f5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"TreeGridDblClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowEditButtonClickChildIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9c06cbc7-62c4-4962-8be7-ba75c075ee44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6590413c-899a-4d8a-a24d-761666bea7f5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ThrowEditButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0f93ae30-d3a7-465c-8fbe-572afca5b84d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6c8719a-1d88-4bd1-815c-52dc11f45def"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EventSubProcess12",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(182, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRunProcessButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fef2ab2b-f95d-4e5f-ae8a-57888c1a7f6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0f93ae30-d3a7-465c-8fbe-572afca5b84d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RunProcessButtonClick",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"RunProcessButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRunProcessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d5e8198c-9608-4425-a618-391071efd30e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0f93ae30-d3a7-465c-8fbe-572afca5b84d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"RunProcessScriptTask",
				Position = new Point(77, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,111,219,48,12,61,39,64,254,131,230,147,141,5,194,238,69,15,77,226,14,198,144,38,136,147,238,48,236,160,217,76,34,212,150,60,137,78,99,12,251,239,163,252,209,218,105,23,108,151,124,72,143,239,241,145,20,151,96,173,56,192,90,40,200,88,222,255,115,203,230,90,161,209,217,14,101,38,81,130,229,247,82,165,237,161,191,38,32,191,179,69,253,221,30,218,111,159,190,79,39,227,145,55,19,22,150,61,50,111,202,208,148,16,48,97,89,255,252,102,50,150,123,230,15,116,63,220,50,85,102,89,192,126,17,83,255,134,111,32,215,39,240,189,121,105,81,231,107,145,60,209,85,104,140,54,45,167,23,16,225,239,201,24,77,85,71,239,44,24,74,77,65,130,82,43,190,152,197,144,148,70,98,21,170,131,84,148,246,17,146,167,185,80,225,153,206,17,86,5,24,225,144,36,33,212,82,40,167,108,116,66,228,11,176,242,160,26,126,150,8,76,142,204,15,207,9,20,14,206,160,73,246,186,149,161,151,187,52,109,147,190,230,103,202,98,52,82,29,120,152,23,88,77,25,240,246,102,218,149,113,91,21,192,235,24,151,219,136,204,143,12,96,105,20,219,139,204,66,83,143,147,48,172,104,140,196,201,17,114,17,165,212,222,186,115,11,129,34,214,165,73,168,153,84,165,19,108,244,243,218,200,92,152,106,174,179,50,87,143,34,43,29,205,27,142,166,62,38,66,200,137,236,162,212,235,119,144,252,51,160,67,207,170,93,148,250,23,249,4,55,108,50,30,68,13,213,72,226,111,234,60,22,123,136,148,69,161,18,104,39,234,34,182,223,7,91,87,148,154,216,244,238,10,239,188,129,184,186,198,71,253,220,239,140,179,187,21,246,137,71,73,205,225,133,155,205,106,227,93,133,206,74,68,173,172,67,175,190,92,135,118,205,133,51,18,188,201,152,223,107,147,11,244,151,58,45,179,110,46,59,219,15,26,195,179,180,248,50,30,173,189,224,170,140,155,128,118,16,28,174,30,136,237,209,16,250,4,10,125,239,50,176,158,255,110,190,220,131,126,29,175,188,159,213,101,81,249,220,128,192,238,214,31,206,74,240,94,203,40,53,35,114,64,48,150,215,198,236,172,122,160,3,223,115,73,118,174,163,212,11,6,77,149,47,23,148,130,239,111,193,24,97,245,30,249,46,226,95,225,71,183,166,106,227,65,127,131,5,252,149,147,111,117,243,234,252,218,110,75,93,12,116,137,190,167,245,177,121,75,238,195,73,8,218,45,134,239,148,252,89,66,180,112,28,131,234,240,24,144,126,210,178,193,170,126,93,111,76,77,47,212,218,181,246,159,85,234,106,243,47,226,36,89,151,161,17,26,70,180,219,177,217,248,111,123,215,31,135,63,94,122,140,150,78,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2f0bc530-01e7-4ecb-a337-8325e85eb9d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6c8719a-1d88-4bd1-815c-52dc11f45def"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EventSubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(224, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(302, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShowErrorMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("54dcd4a0-5e05-40dc-ab1f-fb906c5b74a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2f0bc530-01e7-4ecb-a337-8325e85eb9d1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ShowErrorMessage",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ShowErrorMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateShowErrorMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("801b152d-133c-4faa-8edb-514f0a5963e9"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2f0bc530-01e7-4ecb-a337-8325e85eb9d1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ShowErrorMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 43),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowErrorMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("256e3395-a8e2-4182-a501-6adcceb3821e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c2b77b9-1ef2-4191-ad68-919f41264921"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(199, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeViewModeStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("97c66a2a-b4ba-4cc8-8fa7-17625516ed97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("256e3395-a8e2-4182-a501-6adcceb3821e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeViewMode",
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ChangeViewModeStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(7, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("25d847c9-22e0-4379-98aa-903ddedaf906"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("256e3395-a8e2-4182-a501-6adcceb3821e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(98, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,41,74,77,117,47,202,76,209,115,206,73,77,44,210,208,180,230,229,10,0,137,187,36,150,36,6,231,151,22,37,167,234,249,228,39,166,4,151,20,149,38,151,148,22,165,106,228,149,230,228,232,40,0,185,169,184,212,6,229,151,23,131,13,42,74,5,234,200,3,171,181,6,0,203,104,139,176,109,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateProcessMethod());
			Methods.Add(CreateCreateNewModuleProcessMethod());
			Methods.Add(CreateGenerateModuleProcessUniqueNameMethod());
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
				UId = new Guid("93ef6706-0f4b-4160-985e-d688ab5dbbac"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("69ea8edd-204c-4423-9a13-70ce7fe82dac"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("225fa426-8add-45ee-abac-7c87313de914"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c2decd1a-e86a-4e73-a495-861fa9c4afb1"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b97bef1c-5a54-4670-8e26-fdf1d274ff1e"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("81db2df7-14e5-4d0c-b486-095a15f0d585"),
				Name = "Terrasoft.WebApp",
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
				UId = new Guid("bd014cf8-eaa7-42fc-95d8-5ac8e83d7567"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("f22d92fb-0351-4268-afec-308cab404801")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1f643230-0306-4303-be57-0bd9f74bcbec"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
		}

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,72,74,44,78,213,115,79,45,113,130,136,104,104,90,115,65,37,245,28,83,82,52,2,18,211,83,245,130,74,243,2,138,242,147,83,139,139,33,170,244,252,18,115,83,129,10,139,82,75,74,139,242,96,134,89,3,0,77,251,193,105,89,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,61,107,195,48,16,157,109,200,127,80,51,4,123,17,217,131,135,38,77,77,134,4,131,147,44,37,195,217,190,164,2,89,10,146,28,106,74,255,123,79,118,157,26,74,75,65,8,164,123,31,119,239,10,176,200,31,75,39,110,224,112,217,56,167,149,141,224,235,29,47,38,97,161,181,100,194,174,21,20,18,43,150,176,51,72,139,84,16,103,22,101,112,65,190,55,136,169,17,21,207,81,98,233,176,218,233,10,45,95,233,70,57,246,144,176,121,204,222,39,97,48,192,124,149,41,127,37,236,15,254,203,252,68,38,193,13,12,187,26,93,162,181,121,249,138,53,236,160,246,76,47,192,143,32,27,66,78,253,223,244,196,247,58,119,70,168,75,20,15,204,26,20,57,152,141,195,154,56,7,139,102,165,149,34,19,161,21,207,198,178,219,30,201,159,133,170,60,124,217,122,209,232,135,117,39,237,71,31,75,211,144,170,145,146,205,102,99,71,158,129,65,229,14,27,74,45,97,105,67,19,174,235,171,107,251,56,2,65,233,220,208,88,106,229,159,189,165,232,182,240,118,236,57,203,246,46,63,238,133,211,187,235,49,24,239,236,238,67,219,240,197,143,73,72,167,75,255,137,66,31,54,207,191,25,191,215,104,200,187,244,226,19,49,145,173,101,63,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = base.CreateInitializeContextHelpButtonMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,205,111,218,48,20,63,131,212,255,193,245,165,137,138,204,121,234,58,9,40,26,145,198,86,45,208,93,122,49,201,131,186,117,108,100,59,180,221,186,255,125,207,56,168,132,68,19,147,6,7,72,30,239,253,190,252,33,150,36,250,12,46,177,35,173,28,188,184,9,200,245,176,116,78,171,137,200,115,80,81,76,222,222,200,249,97,203,88,241,133,132,60,138,99,242,235,172,219,49,224,74,163,174,206,186,191,207,186,11,173,37,41,45,124,153,166,55,58,43,11,80,142,59,161,21,185,38,75,46,45,96,151,94,60,66,230,200,134,203,210,191,110,184,241,3,6,241,21,214,67,239,45,95,1,155,215,170,216,42,80,238,12,140,225,86,47,29,27,105,3,248,165,150,98,85,154,45,9,75,95,109,10,206,9,181,178,108,102,94,81,247,157,103,137,234,248,61,66,231,77,133,180,71,116,89,201,170,140,181,251,64,160,13,24,199,102,122,136,102,129,171,40,204,132,0,188,198,243,150,193,128,184,224,22,88,162,132,19,92,138,159,208,136,61,242,40,181,64,251,125,235,12,26,34,178,176,115,35,145,255,232,4,118,246,63,6,132,79,205,24,80,36,98,162,115,85,74,233,169,251,253,86,154,162,240,208,96,54,34,131,212,241,236,105,86,169,6,227,203,193,76,20,70,3,76,37,58,219,23,119,7,198,134,8,255,155,5,79,213,161,163,22,150,154,169,35,100,28,103,177,13,200,83,84,118,31,176,191,90,211,36,71,2,250,193,127,40,54,28,254,243,239,212,53,132,184,58,56,217,225,6,218,157,157,198,206,218,229,80,175,178,81,105,157,46,66,128,108,144,231,145,130,231,61,113,243,132,253,128,133,7,51,90,90,182,255,128,3,137,131,34,162,97,217,49,239,106,253,189,182,147,16,213,18,64,190,122,34,39,163,93,27,157,151,153,27,231,162,186,38,232,61,29,222,78,211,123,74,227,248,116,177,182,109,53,36,111,221,129,237,222,195,29,190,119,243,54,91,146,194,111,150,84,151,38,131,112,181,121,33,219,106,40,178,239,96,183,15,83,174,176,104,254,130,114,208,249,149,23,30,146,190,187,70,203,131,245,154,30,1,225,19,216,205,251,85,102,107,181,106,159,27,60,242,151,241,6,47,89,12,79,138,236,137,125,83,248,139,239,219,34,185,198,219,116,79,193,228,125,199,48,251,160,159,253,123,68,201,101,167,126,60,47,59,180,119,129,229,230,241,98,1,60,185,193,63,233,69,76,175,254,0,230,34,206,111,66,7,0,0 };
			return method;
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,46,41,202,204,75,215,115,205,45,40,169,180,6,0,123,132,81,183,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterCopyPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,46,41,202,204,75,215,115,205,45,40,169,180,6,0,123,132,81,183,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,46,41,202,204,75,215,115,205,45,40,169,180,6,0,123,132,81,183,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6abbad85-04e4-409e-a210-4bfbb9e2187b"),
				Name = "CreateProcess",
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("85f9b38d-b853-4706-bc67-688917a4bcb8"),
				Name = "processUId",
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				ModifiedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,79,27,49,16,61,7,137,255,224,230,228,149,86,166,183,30,82,56,144,180,16,21,80,68,72,123,118,188,147,96,177,107,167,254,8,162,21,255,189,227,143,133,93,8,81,212,67,178,201,236,155,55,239,205,216,179,229,134,88,113,15,13,191,230,138,175,193,144,83,50,195,39,91,88,48,99,173,20,8,39,181,98,51,163,5,88,59,239,66,71,199,71,91,76,87,188,1,204,234,177,176,11,80,96,184,131,169,131,102,161,228,111,15,55,8,163,125,80,120,25,194,69,102,106,82,60,132,223,17,142,13,32,93,170,79,67,201,146,40,95,215,229,46,181,37,185,240,178,98,55,240,24,158,180,40,137,51,62,86,177,206,72,181,38,130,111,2,14,139,12,207,189,149,10,157,145,236,112,136,168,142,14,54,85,214,113,37,128,221,241,53,226,115,230,71,160,25,23,15,24,93,76,43,196,254,210,230,193,110,184,128,133,147,181,116,18,44,251,174,141,128,11,112,99,111,157,110,94,209,116,135,139,182,43,155,110,235,199,47,202,21,60,146,43,45,120,45,255,240,101,13,243,232,140,182,73,202,55,203,56,204,208,42,118,11,141,222,2,253,92,146,47,45,64,248,218,121,3,182,101,146,214,125,29,167,216,84,173,244,25,77,19,172,111,193,106,143,162,231,78,155,160,49,99,108,224,57,57,153,192,138,99,224,92,218,208,195,220,194,172,145,93,114,251,147,215,30,16,185,23,119,165,121,149,105,35,222,70,23,211,137,140,109,224,230,169,43,172,36,105,134,103,173,131,148,130,54,246,214,232,241,35,251,74,227,121,18,247,244,7,60,197,216,140,75,179,183,76,8,18,169,250,85,11,242,247,248,104,208,30,170,206,155,112,124,99,148,225,60,5,119,180,195,194,34,162,36,67,50,44,211,152,130,221,193,174,49,179,121,56,42,175,180,61,26,148,94,246,138,70,154,142,7,178,210,94,181,157,13,115,198,251,18,32,217,59,161,93,108,38,234,88,204,238,6,114,69,218,186,236,38,222,245,83,242,70,71,140,103,248,224,77,213,12,29,197,119,75,172,252,16,127,62,227,87,248,4,246,94,198,167,36,52,179,181,90,218,35,220,133,70,191,200,241,252,50,206,3,45,29,52,176,52,129,52,38,242,159,115,122,63,159,231,15,22,199,235,189,222,197,143,137,7,236,99,118,238,101,93,225,53,248,182,5,229,46,185,170,106,48,9,129,240,13,152,176,130,40,237,165,22,187,212,148,113,37,76,192,202,181,186,214,21,68,62,252,43,140,220,224,26,160,69,113,160,160,57,223,66,162,129,42,84,152,170,57,98,16,62,225,142,211,183,75,251,32,101,59,187,135,27,180,24,225,241,26,28,31,245,56,210,30,254,40,101,244,15,116,229,243,194,253,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateNewModuleProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2f5da7aa-41e3-4195-ac29-22d424020812"),
				Name = "CreateNewModuleProcess",
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,205,110,194,48,12,190,243,20,17,167,32,85,121,1,180,3,131,13,33,13,86,81,186,157,163,212,98,17,77,210,57,9,29,111,63,183,101,99,165,32,237,148,216,242,247,227,47,57,74,100,21,58,5,222,103,234,3,140,204,87,5,123,96,169,220,131,88,200,32,51,23,81,129,152,169,160,143,176,117,117,138,218,72,60,205,93,25,141,125,147,101,132,233,232,72,28,70,90,130,32,65,115,15,56,119,214,2,65,156,21,233,95,242,117,55,213,131,172,2,152,215,178,17,253,233,136,37,132,166,251,120,34,51,252,218,221,164,67,91,168,215,174,136,37,244,4,90,243,203,168,11,177,129,186,57,249,121,220,159,60,49,246,189,13,205,206,170,234,79,149,221,194,72,207,110,245,167,35,31,80,219,61,243,173,143,38,58,162,63,155,50,149,195,64,123,61,125,53,151,174,201,251,235,139,85,145,220,52,73,254,123,148,151,66,108,161,42,165,130,65,66,98,231,178,214,12,31,47,198,19,170,94,92,13,200,39,201,221,208,238,33,254,33,126,181,198,70,26,72,216,18,44,160,12,208,19,203,173,254,140,208,12,180,196,205,171,168,232,131,51,169,84,7,226,232,126,222,187,195,131,175,136,57,15,186,212,65,131,23,207,142,190,32,253,137,249,213,52,31,36,213,190,180,182,135,97,244,221,165,107,238,220,175,8,191,108,148,12,220,36,108,32,48,66,8,17,237,221,32,167,223,77,100,171,195,80,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGenerateModuleProcessUniqueNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a597de45-c106-4d00-86dd-2dd22ef2387f"),
				Name = "GenerateModuleProcessUniqueName",
				CreatedInSchemaUId = new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,218,64,16,124,182,127,197,213,79,135,130,172,244,217,33,82,138,104,133,212,180,105,201,199,243,197,172,195,41,102,143,222,157,11,86,197,127,239,158,215,80,131,93,37,188,96,221,205,204,206,206,174,237,188,213,248,34,54,22,10,189,19,19,145,220,154,101,85,194,157,53,57,56,151,100,177,99,0,170,53,100,241,111,101,5,160,215,190,94,228,43,88,171,169,41,171,53,126,163,187,64,13,255,73,31,116,184,126,220,46,106,199,71,115,124,50,246,213,109,84,62,68,184,85,168,94,192,18,231,193,129,157,26,68,200,189,54,152,206,250,160,62,155,104,3,98,233,23,240,115,116,94,97,14,159,234,96,73,158,123,28,245,181,126,84,96,235,207,186,244,96,239,148,37,12,61,180,237,12,199,240,62,137,71,85,86,65,131,83,255,15,135,238,17,182,98,118,126,46,7,186,27,247,2,167,102,122,138,41,219,112,233,205,114,41,251,183,83,11,202,3,99,158,180,95,29,237,58,25,71,124,60,53,235,141,178,218,25,188,175,55,144,210,104,188,210,56,126,87,102,111,163,154,88,70,3,99,224,124,207,66,103,211,212,10,223,202,225,129,140,50,17,126,141,228,175,192,248,9,174,42,253,160,22,173,8,167,77,244,146,87,78,158,110,96,80,139,117,33,100,71,138,82,168,144,4,39,226,114,36,254,196,17,242,126,240,123,19,34,202,149,151,60,233,177,72,62,38,212,95,100,193,87,22,219,151,106,255,207,220,162,33,185,163,199,176,0,95,181,243,87,172,118,45,137,92,24,154,83,190,18,242,172,37,182,46,52,118,15,201,81,20,71,1,201,10,135,205,235,241,66,243,97,166,109,154,13,238,88,181,31,109,218,0,102,59,234,203,185,240,106,54,9,242,221,77,169,149,11,93,30,131,58,105,43,157,227,18,118,223,11,217,113,52,18,87,109,122,209,0,33,172,107,23,76,210,123,74,77,83,234,121,200,190,249,84,92,102,241,179,49,101,147,233,220,61,160,38,161,44,94,154,32,218,162,46,46,178,55,198,211,2,211,123,195,14,228,148,234,87,22,230,88,24,242,77,57,106,133,190,61,12,155,26,117,203,145,172,183,161,106,116,50,163,144,17,37,184,232,12,224,48,164,147,62,121,86,77,106,108,114,50,64,229,144,206,203,22,170,116,161,110,20,61,83,225,215,240,180,111,66,18,219,149,46,65,200,15,93,2,249,238,46,224,95,69,40,163,71,3,6,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysProcessListPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5cdeb4a-486d-45d6-89ac-eec984e9e101"));
		}

		#endregion

	}

	#endregion

}

