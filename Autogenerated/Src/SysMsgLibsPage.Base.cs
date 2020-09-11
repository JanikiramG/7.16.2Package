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
	using System.IO;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
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

	#region Class: SysMsgLibsPageSchema

	/// <exclude/>
	public class SysMsgLibsPageSchema : Terrasoft.WebApp.BaseLookupGridPageSchema
	{

		#region Constructors: Public

		public SysMsgLibsPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysMsgLibsPageSchema(SysMsgLibsPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateDownloadTemplateForImportProductsButton() {
			DownloadTemplateForImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownloadTemplateForImportProductsButton.Image = new ControlImage {};
			DownloadTemplateForImportProductsButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateImportProductsButton() {
			ImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ImportProductsButton.Image = new ControlImage {};
			ImportProductsButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
			RealUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
			Name = "SysMsgLibsPage";
			ParentSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysMsgLibsPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateImportProductsButton();
			UpdateDownloadTemplateForImportProductsButton();
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
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			ButtonsControlLayout.MoveItem(7, DownloadTemplateForImportProductsButton);
			ButtonsControlLayout.MoveItem(8, ImportProductsButton);
			ButtonsControlLayout.MoveItem(9, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysMsgLibsPageEventsProcessSchema() {
			var schema = new SysMsgLibsPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("89b9f170-8aed-4f41-8659-c787b50df837");
			DataSource.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("26790557-d51b-4a5e-a03c-971b472ae488");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("d5d1fa7a-2c69-4ff9-8e12-064528ad4683");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("81f1943a-d9d4-4caa-92b8-6627bc4dcba1");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("fa79b1bc-5fd6-4a2c-878f-bfba97c60335");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4edc483e-5af2-4ea3-806b-66c44c5a60dd");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("ea9359b0-a34e-4441-9e86-520e3560ee82");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("655d8d91-0b00-4589-9d7f-756877866cb1");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("ba68d1a9-b061-4c63-b55c-13bb13e0a565");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("89894058-584f-48fa-850c-292358d9cd1e");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4ad66197-8e63-4298-ac37-981399166904");
			if (column != null) {
				column.UId = new Guid("b6085bfc-9548-44ac-b3c6-8276a8cac9b6");
				column.Name = @"FullClassName";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6eea683c-19c3-4347-b1db-1d9de5c232ab");
			if (column != null) {
				column.UId = new Guid("4fbb778e-edea-4ff4-9fde-895ca35c357b");
				column.Name = @"SetupPageSchemaName";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e1f7baaf-124a-478c-b3d9-d31202568c5c");
			if (column != null) {
				column.UId = new Guid("4aaab309-ecd0-485d-8bfe-0b322bc6405f");
				column.Name = @"LicOperations";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("88da31ac-dcbb-49e8-bdfb-30685ca1cae0");
			if (column != null) {
				column.UId = new Guid("5666d58f-3f19-454a-b6bc-8e58ec7f0102");
				column.Name = @"CtiProviderName";
				column.CreatedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.ModifiedInSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysMsgLibsPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysMsgLibsPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysMsgLibsPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgLibsPageEventsProcess

	/// <exclude/>
	public class SysMsgLibsPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysMsgLibsPageSchemaUserControl
	{

		public SysMsgLibsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgLibsPageEventsProcess";
			SchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514");
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

		private Guid _editPageUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
		public override Guid EditPageUId {
			get {
				return _editPageUId;
			}
			set {
				_editPageUId = value;
			}
		}

		private ProcessFlowElement _pageLoadEventSubProcess;
		public ProcessFlowElement PageLoadEventSubProcess {
			get {
				return _pageLoadEventSubProcess ?? (_pageLoadEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadEventSubProcess",
					SchemaElementUId = new Guid("0da55343-2985-442d-bb7f-f76a0558caf4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteMessage;
		public ProcessFlowElement PageLoadCompleteMessage {
			get {
				return _pageLoadCompleteMessage ?? (_pageLoadCompleteMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteMessage",
					SchemaElementUId = new Guid("3f058c2e-edcd-4b36-a09c-af470d72ab27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setParametersUserTask;
		public ProcessScriptTask SetParametersUserTask {
			get {
				return _setParametersUserTask ?? (_setParametersUserTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetParametersUserTask",
					SchemaElementUId = new Guid("48b831a1-8814-43bc-9887-808165c08f74"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetParametersUserTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowPageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowPageLoadComplete {
			get {
				return _intermediateThrowPageLoadComplete ?? (_intermediateThrowPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowPageLoadComplete",
					SchemaElementUId = new Guid("256431d5-0f4f-46f5-aa38-8a731884ea64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
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
					SchemaElementUId = new Guid("aac64d38-c9ef-4a1f-bf9c-048405fc62f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage134657;
		public ProcessFlowElement StartMessage134657 {
			get {
				return _startMessage134657 ?? (_startMessage134657 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage134657",
					SchemaElementUId = new Guid("d7f69490-9ea9-4339-9b7f-986d3ab7dcde"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent33466889;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent33466889 {
			get {
				return _intermediateThrowMessageEvent33466889 ?? (_intermediateThrowMessageEvent33466889 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent33466889",
					SchemaElementUId = new Guid("2ad5e9b8-25ab-459f-90ef-b1aae2d11fa0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("41ade0db-37e7-4cdb-b016-39518acfb58c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PageLoadEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadEventSubProcess };
			FlowElements[PageLoadCompleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteMessage };
			FlowElements[SetParametersUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetParametersUserTask };
			FlowElements[IntermediateThrowPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowPageLoadComplete };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage134657.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage134657 };
			FlowElements[IntermediateThrowMessageEvent33466889.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent33466889 };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadEventSubProcess":
						break;
					case "PageLoadCompleteMessage":
						e.Context.QueueTasks.Enqueue("SetParametersUserTask");
						break;
					case "SetParametersUserTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowPageLoadComplete");
						break;
					case "IntermediateThrowPageLoadComplete":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage134657":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent33466889");
						break;
					case "IntermediateThrowMessageEvent33466889":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteMessage");
			ActivatedEventElements.Add("StartMessage134657");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PageLoadEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteMessage";
					result = PageLoadCompleteMessage.Execute(context);
					break;
				case "SetParametersUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetParametersUserTask";
					result = SetParametersUserTask.Execute(context, SetParametersUserTaskExecute);
					break;
				case "IntermediateThrowPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowPageLoadComplete.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage134657":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage134657";
					result = StartMessage134657.Execute(context);
					break;
				case "IntermediateThrowMessageEvent33466889":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent33466889.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
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

		public virtual bool SetParametersUserTaskExecute(ProcessExecutingContext context) {
			EditPageUId = new Guid("71c37611-0d56-45e6-bf96-255642763b2d");
			//Page.DataSource.LoadRows();
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var structure = dataSource.CurrentStructure;
			var existFilter = dataSource.FindFiltersGroupByName("MessageLibraries");
			if (existFilter != null) {
				structure.Filters.Remove(existFilter);
			}
			//structure.Filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, 
			//		FilterComparisonType.Equal, "[VwSysSchemaInfo:Id:SysPageSchemaU].SysWorkspace", UserConnection.Workspace.Id));
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage134657")) {
							context.QueueTasks.Enqueue("StartMessage134657");
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

	#region Class: SysMsgLibsPageEventsProcess

	/// <exclude/>
	public class SysMsgLibsPageEventsProcess : SysMsgLibsPageEventsProcess<Terrasoft.WebApp.SysMsgLibsPageSchemaUserControl>
	{

		public SysMsgLibsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgLibsPageSchemaUserControl

	/// <exclude/>
	public partial class SysMsgLibsPageSchemaUserControl : Terrasoft.WebApp.BaseLookupGridPageSchemaUserControl
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
			var process = (SysMsgLibsPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysMsgLibsPageEventsProcess(UserConnection);
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
			SchemaName = "SysMsgLibsPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgLibsPageEventsProcessSchema

	/// <exclude/>
	public class SysMsgLibsPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysMsgLibsPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysMsgLibsPageEventsProcessSchema(SysMsgLibsPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysMsgLibsPageEventsProcess";
			UId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a676227c-1197-410d-9d09-3e896ddf170d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
					Value = @"71c37611-0d56-45e6-bf96-255642763b2d",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaCurrentLaneSet = CreateCurrentLaneSetLaneSet();
			LaneSets.Add(schemaCurrentLaneSet);
			ProcessSchemaLane schemaCurrentLane = CreateCurrentLaneLane();
			schemaCurrentLaneSet.Lanes.Add(schemaCurrentLane);
			ProcessSchemaEventSubProcess pageloadeventsubprocess = CreatePageLoadEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaStartMessageEvent pageloadcompletemessage = CreatePageLoadCompleteMessageStartMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(pageloadcompletemessage);
			ProcessSchemaScriptTask setparametersusertask = CreateSetParametersUserTaskScriptTask();
			pageloadeventsubprocess.FlowElements.Add(setparametersusertask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowpageloadcomplete = CreateIntermediateThrowPageLoadCompleteIntermediateThrowMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(intermediatethrowpageloadcomplete);
			ProcessSchemaStartMessageEvent startmessage134657 = CreateStartMessage134657StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage134657);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent33466889 = CreateIntermediateThrowMessageEvent33466889IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent33466889);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(initscripttask);
			FlowElements.Add(CreateSequenceFlow31SequenceFlow());
			FlowElements.Add(CreateSequenceFlow32SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow31SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow31",
				UId = new Guid("c951f624-bb6d-468c-b09d-b54797a397d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				CurveCenterPosition = new Point(142, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3f058c2e-edcd-4b36-a09c-af470d72ab27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48b831a1-8814-43bc-9887-808165c08f74"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow32SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow32",
				UId = new Guid("166a9fbf-45d9-46b0-9f53-f38f4d5baa11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				CurveCenterPosition = new Point(257, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48b831a1-8814-43bc-9887-808165c08f74"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("256431d5-0f4f-46f5-aa38-8a731884ea64"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("fd39fecf-596f-49f4-af8a-d0a383be1924"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				CurveCenterPosition = new Point(512, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7f69490-9ea9-4339-9b7f-986d3ab7dcde"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2ad5e9b8-25ab-459f-90ef-b1aae2d11fa0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d8ee7618-456d-4a21-9727-14ab05d5e796"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				CurveCenterPosition = new Point(644, 97),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2ad5e9b8-25ab-459f-90ef-b1aae2d11fa0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("41ade0db-37e7-4cdb-b016-39518acfb58c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateCurrentLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaCurrentLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8f23613c-eda9-48ec-b0f7-4e97d94ca95e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"CurrentLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1673, 179),
				UseBackgroundMode = false
			};
			return schemaCurrentLaneSet;
		}

		protected virtual ProcessSchemaLane CreateCurrentLaneLane() {
			ProcessSchemaLane schemaCurrentLane = new ProcessSchemaLane(this) {
				UId = new Guid("5f434352-96cc-437d-8c6f-8ebf80e812ce"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8f23613c-eda9-48ec-b0f7-4e97d94ca95e"),
				CreatedInOwnerSchemaUId = new Guid("02e29db5-924c-44c0-b4a7-24dd648d5514"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"CurrentLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1644, 179),
				UseBackgroundMode = false
			};
			return schemaCurrentLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0da55343-2985-442d-bb7f-f76a0558caf4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5f434352-96cc-437d-8c6f-8ebf80e812ce"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"PageLoadEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3f058c2e-edcd-4b36-a09c-af470d72ab27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da55343-2985-442d-bb7f-f76a0558caf4"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"PageLoadCompleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetParametersUserTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("48b831a1-8814-43bc-9887-808165c08f74"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da55343-2985-442d-bb7f-f76a0558caf4"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"SetParametersUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,77,201,44,9,72,76,79,13,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,50,55,76,54,54,55,51,52,212,53,72,49,53,211,53,49,77,53,211,77,74,179,52,211,53,50,53,53,51,49,50,55,51,78,50,74,81,210,180,230,229,210,215,7,105,215,115,73,44,73,12,206,47,45,74,78,213,243,201,79,76,9,202,47,47,214,0,73,23,165,150,148,22,229,41,148,20,149,166,90,3,0,81,155,205,92,108,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("256431d5-0f4f-46f5-aa38-8a731884ea64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da55343-2985-442d-bb7f-f76a0558caf4"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"IntermediateThrowPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("aac64d38-c9ef-4a1f-bf9c-048405fc62f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5f434352-96cc-437d-8c6f-8ebf80e812ce"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(378, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(368, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage134657StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d7f69490-9ea9-4339-9b7f-986d3ab7dcde"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aac64d38-c9ef-4a1f-bf9c-048405fc62f4"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"StartMessage134657",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent33466889IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2ad5e9b8-25ab-459f-90ef-b1aae2d11fa0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aac64d38-c9ef-4a1f-bf9c-048405fc62f4"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"IntermediateThrowMessageEvent33466889",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("41ade0db-37e7-4cdb-b016-39518acfb58c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aac64d38-c9ef-4a1f-bf9c-048405fc62f4"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,65,79,131,48,24,134,207,144,240,31,42,39,72,72,119,223,178,131,162,51,36,106,22,113,238,96,60,116,244,155,107,132,22,191,182,40,49,254,119,219,48,25,102,199,190,223,243,189,125,218,142,33,225,204,176,82,89,172,128,44,201,154,189,1,189,30,147,69,20,118,14,209,6,109,101,44,122,226,132,211,220,34,130,52,229,223,244,72,195,151,208,102,37,106,3,248,159,95,9,201,135,92,223,162,178,237,85,255,192,26,72,226,123,208,218,221,123,39,118,200,80,128,142,83,215,36,246,36,153,54,93,44,137,180,117,157,146,239,40,12,70,33,122,236,163,143,208,168,14,166,27,190,228,39,10,103,179,115,248,146,243,228,148,230,8,204,192,48,219,10,115,88,51,116,90,30,76,38,242,101,117,128,134,101,196,55,6,193,64,231,170,105,157,177,86,242,169,111,129,222,124,88,86,103,36,126,121,254,44,123,61,44,20,114,175,230,5,159,187,192,255,237,16,110,94,169,59,111,21,190,235,150,85,16,103,100,163,125,155,148,80,25,161,36,29,71,180,224,169,127,8,130,83,149,196,57,195,226,23,59,225,132,243,181,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2ec18d58-d5ad-4b15-9d7a-8ac963b89dfd"),
				Name = "Terrasoft.Configuration",
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
				UId = new Guid("775363c7-62ae-4a8d-b363-4350699b5cf2"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("51e927e4-70cf-41b6-867a-8768292a856e"),
				Name = "System.Data",
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMsgLibsPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9443fc7d-e97f-4cef-92db-e42dc72db90e"));
		}

		#endregion

	}

	#endregion

}

