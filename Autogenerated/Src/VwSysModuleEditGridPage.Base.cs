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

	#region Class: VwSysModuleEditGridPageSchema

	/// <exclude/>
	public class VwSysModuleEditGridPageSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchema
	{

		#region Constructors: Public

		public VwSysModuleEditGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public VwSysModuleEditGridPageSchema(VwSysModuleEditGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @""
			};
			CopyButton.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
			RealUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
			Name = "VwSysModuleEditGridPage";
			ParentSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysModuleEditGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateVwSysModuleEditGridPageEventsProcessSchema() {
			var schema = new VwSysModuleEditGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("af1d238e-f551-4878-b4c3-d52aa8495adb");
			DataSource.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("d5475542-51bb-494b-9735-ab562035a63c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c96032e9-43a8-40ae-ba75-68331d0a34fb");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("387e32fb-fc99-4ca4-ba99-158e2c201c92");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("b9875f37-0dba-47a4-aea4-f559b275c270");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("a187d3a4-b9bb-42a7-8978-bc55ee90418f");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f7b189f1-06c6-4b54-bb04-eaf91625177f");
			if (column != null) {
				column.UId = new Guid("2b8b453c-4e19-4575-9e84-cfc93485c795");
				column.Name = @"SysModuleEntity";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("56c33b79-2d9a-4b49-adb4-79df03d178e9");
			if (column != null) {
				column.UId = new Guid("8429e61c-9791-4fad-866a-1043f35df634");
				column.Name = @"TypeColumnValue";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c53035ba-426a-4b98-a5fa-2d2966b2c908");
			if (column != null) {
				column.UId = new Guid("cd71c218-07ec-43fe-a162-7c1828470e85");
				column.Name = @"UseModuleDetails";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ca35057b-1338-4316-9d6f-8c35f98f5db5");
			if (column != null) {
				column.UId = new Guid("f0612929-2e18-422a-bd5d-9161e4c00ebc");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("011f15ec-018b-488c-8c6f-99158f82b08a");
			if (column != null) {
				column.UId = new Guid("d051e829-d182-4abc-851b-970542a96ab6");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a90e57e9-5e2c-40e8-80e2-3ac8b48f9619");
			if (column != null) {
				column.UId = new Guid("43d207e7-425b-4479-a6c2-bc38e4801d09");
				column.Name = @"HelpContextId";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("ff280538-e61a-416b-a03a-715c349338e5");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae683a77-0faf-4743-a1c2-abadf29f6e98");
			if (column != null) {
				column.UId = new Guid("1cf54287-fb63-4973-81bb-7903708d1230");
				column.Name = @"SysPageSchemaUId";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cab746bc-e566-4366-a425-c2b643e628f9");
			if (column != null) {
				column.UId = new Guid("4ced3045-ffa1-45a7-9b47-0bb970e5ab46");
				column.Name = @"SysWorkspace";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("fcd5ccc3-2a7a-4a9d-b8b8-e78f76efe747");
			if (column != null) {
				column.UId = new Guid("4edbada7-f8a6-4dc2-82aa-1f014a0f3a2f");
				column.Name = @"CardSchemaUId";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a19bf4bf-e22b-49b5-b6e0-918ff6290020");
			if (column != null) {
				column.UId = new Guid("f9734c7c-0d33-4cee-b494-2a755722750a");
				column.Name = @"ActionKindCaption";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f14f9a76-5ad3-47f9-b175-b7648b7bd340");
			if (column != null) {
				column.UId = new Guid("6ad373f9-39ea-4eb4-94c9-c745b2c7cde0");
				column.Name = @"ActionKindName";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("55132174-2b96-4e0a-830c-b8e952b12c45");
			if (column != null) {
				column.UId = new Guid("d15234a6-62c1-4a30-8030-c0d8279f4363");
				column.Name = @"PageCaption";
				column.CreatedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
				column.ModifiedInSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
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
			return new VwSysModuleEditGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new VwSysModuleEditGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwSysModuleEditGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEditGridPageEventsProcess

	/// <exclude/>
	public class VwSysModuleEditGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.VwSysModuleEditGridPageSchemaUserControl
	{

		public VwSysModuleEditGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysModuleEditGridPageEventsProcess";
			SchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
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

		private Guid _editPageUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		public override Guid EditPageUId {
			get {
				return _editPageUId;
			}
			set {
				_editPageUId = value;
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("3d8cce3c-ec10-41da-90c0-f49f10a9210d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteYesMessageStartMessage1;
		public ProcessFlowElement DeleteYesMessageStartMessage1 {
			get {
				return _deleteYesMessageStartMessage1 ?? (_deleteYesMessageStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteYesMessageStartMessage1",
					SchemaElementUId = new Guid("f2046ccc-29a7-4de2-8942-44e58e626567"),
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
					SchemaElementUId = new Guid("9884a780-61bf-4879-a606-6a6343f7e9fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[DeleteYesMessageStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesMessageStartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "DeleteYesMessageStartMessage1":
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
			ActivatedEventElements.Add("DeleteYesMessageStartMessage1");
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
				case "DeleteYesMessageStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesMessageStartMessage1";
					result = DeleteYesMessageStartMessage1.Execute(context);
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

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count == 0) {
				return true;
			}
				
			string primaryRecordValue;
			var dataSource = Page.DataSource;
			bool includeDependencyMessage = false;
			bool includeRightLevelMessage = false;
			string warningMessageId = "WarningMessageId";
			var canDeleteRight = Terrasoft.Core.DB.SchemaRecordRightLevels.CanDelete;
			var canChangeDeleteRight = Terrasoft.Core.DB.SchemaRecordRightLevels.CanChangeDeleteRight;
			
			// Get message panel for current page
			MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			
			// Remove message if it appeared before to avoid duplicating
			if (messagePanel != null) {
				messagePanel.Remove(warningMessageId);
			}
			
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModuleEdit");;
			// Remove selected nodes
			foreach (var node in selectedNodes) {
				primaryRecordValue = node.Values[entitySchema.PrimaryColumn.Name].ToString();
				var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
				var rightLevel = dbSecurityEngine.GetEntitySchemaRecordRightLevel(
					entitySchema.Name, new Guid(primaryRecordValue));
				bool canChangeDelete = (rightLevel & canChangeDeleteRight) == canChangeDeleteRight;
				bool canDelete = (rightLevel & canDeleteRight) == canDeleteRight;
				if (canChangeDelete || canDelete) {
					try {
						var recordId = new Guid(primaryRecordValue);
						var entity = entitySchema.CreateEntity(UserConnection);
						entity.Delete(recordId);
						dataSource.RemoveClientRow(recordId);
					}
					catch (Exception e) {
						includeDependencyMessage = true;
					}
				} else {
					includeRightLevelMessage = true;
				}
			}	
			
			// Show appropriate message
			if (messagePanel != null) {
				string warningMessage = null;
				if (includeDependencyMessage && includeRightLevelMessage) {
					warningMessage = RightLevelDependencyWarningMessage;
				} else if (includeDependencyMessage) {
					warningMessage = DependencyWarningMessage;
				} else if (includeRightLevelMessage) {
					warningMessage = RightLevelWarningMessage;
				}
				if (warningMessage != null) {
					messagePanel.AddMessage(warningMessageId,
						Warning, warningMessage, MessageType.Warning);
				}
			}
			return true;
		}

		public override void LoadViewFilters(bool enabledFilters) {
			base.LoadViewFilters(enabledFilters);
			var dataSource = Page.DataSource;
			var structure = Page.DataSource.CurrentStructure;
			var filters = dataSource.FindFiltersGroupByName("ViewFilters");
			if (filters != null) {
				structure.Filters.Remove(filters);
			}
			filters = structure.CreateFiltersGroup("ViewFilters", LogicalOperationStrict.And);
			DataSourceFilterExpression leftExpression = structure.CreateDataSourceFilterExpression("SysWorkspace");
			DataSourceFilterExpression rightExpression = structure.CreateDataSourceFilterExpression(
				new object[]{ UserConnection.Workspace.Id });
			var filterItem = new DataSourceFilter(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.Equal,
				leftExpression, rightExpression);
			filterItem.Name = "All";
			filterItem.IsEnabled = true;
			filters.Add(filterItem);
			structure.Filters.Add(filters);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesMessageStartMessage1")) {
							context.QueueTasks.Enqueue("DeleteYesMessageStartMessage1");
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

	#region Class: VwSysModuleEditGridPageEventsProcess

	/// <exclude/>
	public class VwSysModuleEditGridPageEventsProcess : VwSysModuleEditGridPageEventsProcess<Terrasoft.WebApp.VwSysModuleEditGridPageSchemaUserControl>
	{

		public VwSysModuleEditGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysModuleEditGridPageSchemaUserControl

	/// <exclude/>
	public partial class VwSysModuleEditGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchemaUserControl
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
			var process = (VwSysModuleEditGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new VwSysModuleEditGridPageEventsProcess(UserConnection);
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
			SchemaName = "VwSysModuleEditGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEditGridPageEventsProcessSchema

	/// <exclude/>
	public class VwSysModuleEditGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysModuleEditGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysModuleEditGridPageEventsProcessSchema(VwSysModuleEditGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysModuleEditGridPageEventsProcess";
			UId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a676227c-1197-410d-9d09-3e896ddf170d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EditPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"9805f700-6b84-47c4-92b4-900cf68e882c",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent deleteyesmessagestartmessage1 = CreateDeleteYesMessageStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(deleteyesmessagestartmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("8ef417e3-c035-4a67-a723-9b768368d229"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				CurveCenterPosition = new Point(182, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2046ccc-29a7-4de2-8942-44e58e626567"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9884a780-61bf-4879-a606-6a6343f7e9fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a46b1368-15f2-4504-b8c7-1107a40d8d44"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(893, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("4273b738-251d-497b-b368-49a5d92ccc88"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a46b1368-15f2-4504-b8c7-1107a40d8d44"),
				CreatedInOwnerSchemaUId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(864, 184),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3d8cce3c-ec10-41da-90c0-f49f10a9210d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4273b738-251d-497b-b368-49a5d92ccc88"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(483, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesMessageStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f2046ccc-29a7-4de2-8942-44e58e626567"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d8cce3c-ec10-41da-90c0-f49f10a9210d"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				Name = @"DeleteYesMessageStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9884a780-61bf-4879-a606-6a6343f7e9fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d8cce3c-ec10-41da-90c0-f49f10a9210d"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,77,111,219,48,12,61,39,64,254,3,151,67,225,0,129,219,123,144,67,243,177,162,192,90,20,73,187,29,138,30,84,139,73,4,56,146,33,201,201,130,181,255,125,148,37,39,182,243,49,108,59,57,150,30,201,71,242,145,206,134,105,48,152,98,98,145,63,42,142,6,134,240,196,150,24,63,107,196,59,45,120,60,175,222,14,58,109,177,128,168,102,17,143,85,46,45,12,135,112,211,131,95,157,118,75,163,205,181,4,171,115,36,252,39,157,116,218,198,106,33,151,144,105,177,102,122,55,195,68,105,254,157,165,5,98,67,28,56,179,108,174,114,157,96,73,96,178,63,33,200,187,82,41,8,153,164,57,199,9,102,40,57,202,100,247,128,198,16,148,44,22,44,53,77,220,76,44,87,246,27,110,48,61,198,5,58,91,166,37,61,195,253,61,39,68,247,71,227,172,27,24,38,76,78,40,109,235,253,18,242,25,181,102,70,45,44,21,64,19,223,81,60,79,86,184,102,62,185,67,116,42,80,105,122,112,53,94,49,185,196,255,112,120,228,128,124,119,218,215,215,112,135,22,214,33,225,140,73,76,97,161,40,100,174,53,82,151,50,58,238,180,67,114,79,197,245,186,250,50,132,177,146,86,171,244,197,138,84,88,65,237,253,42,36,15,135,17,245,178,104,206,173,201,138,103,56,55,175,55,111,125,232,142,152,193,170,235,110,191,16,65,15,152,129,234,121,73,117,134,107,181,193,61,91,82,150,176,192,178,12,153,70,14,239,72,196,17,172,2,182,81,130,3,207,179,84,36,204,82,115,188,10,107,196,191,12,65,230,105,234,21,88,189,137,125,148,168,217,235,158,215,166,239,8,149,70,216,157,47,55,213,224,197,160,166,212,36,137,92,40,25,79,43,183,15,76,146,185,142,169,204,247,210,88,38,19,28,237,30,217,26,163,238,124,103,30,20,207,83,156,114,97,187,189,193,160,154,100,57,50,32,221,204,116,218,46,55,150,172,32,114,225,221,25,201,182,62,137,62,149,227,137,33,126,14,31,23,47,230,181,74,61,126,242,232,177,74,243,181,140,29,173,183,248,89,205,11,181,71,46,227,86,49,108,239,115,36,65,144,217,84,46,133,220,143,92,35,237,201,168,14,43,205,245,94,137,100,216,244,229,10,83,173,87,83,188,78,66,173,26,103,199,178,15,18,183,112,151,11,30,29,39,220,43,136,23,163,221,152,28,138,31,85,216,92,157,156,172,158,91,77,167,46,170,94,207,251,59,225,169,225,195,105,177,73,236,227,227,0,244,141,108,89,189,243,63,124,17,139,252,138,149,115,41,245,193,222,192,215,140,224,181,226,141,73,69,22,125,193,163,122,255,130,173,135,199,158,74,84,134,13,151,135,181,27,198,100,156,10,50,152,169,109,3,233,182,120,139,134,207,41,118,250,51,193,204,69,128,50,181,214,133,213,28,62,3,222,197,39,208,250,66,111,116,97,77,151,54,100,242,217,10,203,98,190,82,91,183,28,180,162,50,81,206,229,218,248,211,46,56,185,234,193,35,202,238,157,165,127,117,117,246,107,18,82,63,242,123,0,30,220,213,191,41,131,67,33,46,5,63,23,224,239,220,254,3,239,19,110,67,157,26,70,181,58,215,151,238,45,231,1,117,180,120,251,133,98,66,144,126,163,49,253,242,67,241,188,203,48,14,160,94,169,133,78,187,254,223,226,55,118,222,20,122,190,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e166c122-42fa-4f50-991f-89f6d5e40e3c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
		}

		protected override SchemaMethod CreateLoadViewFiltersMethod() {
			SchemaMethod method = base.CreateLoadViewFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,203,78,194,64,20,93,75,194,63,140,93,149,164,153,31,48,44,176,130,33,33,106,4,117,97,92,92,218,91,24,157,206,212,59,83,144,16,254,221,105,232,19,52,38,46,103,206,57,247,156,251,88,130,65,62,211,16,63,11,220,78,132,180,72,198,71,5,75,137,113,249,28,92,245,123,27,32,22,131,133,185,206,41,66,54,100,15,176,66,126,83,255,148,20,99,41,143,108,78,63,48,120,152,19,161,178,243,138,82,74,146,163,137,19,52,245,249,68,168,202,253,150,116,158,93,239,238,32,69,223,107,133,244,138,88,34,97,126,85,224,114,200,84,46,229,128,237,251,189,139,58,8,47,233,252,17,83,189,193,138,93,136,15,253,94,99,222,8,66,66,176,216,118,239,250,6,108,166,87,34,2,121,159,33,129,21,90,185,150,68,100,249,72,197,69,217,166,229,163,98,252,149,17,26,227,120,76,98,98,91,207,115,215,223,181,190,55,223,153,23,77,31,38,131,8,189,63,140,72,172,214,255,118,114,227,83,184,101,122,249,142,145,125,125,219,179,39,131,20,106,165,220,211,225,188,78,193,167,49,59,12,58,123,156,90,76,157,91,161,63,117,240,91,251,157,71,107,76,33,96,11,36,2,163,19,203,67,237,162,141,149,21,86,160,41,151,22,234,52,3,18,70,171,197,46,115,232,103,14,50,112,233,186,99,12,78,187,45,18,53,105,120,113,57,46,146,55,146,210,235,34,83,51,62,30,186,131,221,120,176,70,13,31,197,177,223,48,139,138,231,23,213,112,220,57,125,3,25,33,180,161,72,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysModuleEditGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c26469e1-a664-4b63-af89-07ca0ad4ab82"));
		}

		#endregion

	}

	#endregion

}

