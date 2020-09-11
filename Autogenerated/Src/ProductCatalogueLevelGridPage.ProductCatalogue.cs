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
	using TSWebControls = Terrasoft.UI.WebControls;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ProductCatalogueLevelGridPageSchema

	/// <exclude/>
	public class ProductCatalogueLevelGridPageSchema : Terrasoft.WebApp.BaseSortByPositionGridPageSchema
	{

		#region Constructors: Public

		public ProductCatalogueLevelGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProductCatalogueLevelGridPageSchema(ProductCatalogueLevelGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateUpPositionButton() {
			UpPositionButton.AjaxEvents.Click.IsProcessEventHandler = true;
			UpPositionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"),
				ImageHash = @"28e5147b7e6173c2fb14e6bacd7517ab"
			};
			UpPositionButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateDownPositionButton() {
			DownPositionButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownPositionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"),
				ImageHash = @"2b3c485798ac9920a70b8fe868d08161"
			};
			DownPositionButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
			RealUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
			Name = "ProductCatalogueLevelGridPage";
			ParentSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductCatalogueLevelGridPageEventsProcessSchema();
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
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDownPositionButton();
			UpdateUpPositionButton();
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
			ButtonsControlLayout.MoveItem(5, UpPositionButton);
			ButtonsControlLayout.MoveItem(6, DownPositionButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
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

		protected virtual EmbeddedProcessSchema CreateProductCatalogueLevelGridPageEventsProcessSchema() {
			var schema = new ProductCatalogueLevelGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			DataSource.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("b6edb35d-fb99-4c52-9e2a-2a81ae316795");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("2848b894-d527-42f5-b996-63ea0ab33bf4");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("afb0cb12-8763-4133-9ae6-f680c900c87d");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("dbbec00b-f245-4b81-8a72-896339d4ebc5");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("71b2f6d6-cfce-434f-85ae-a7f651e7104f");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("bd56b415-2c86-41c6-9817-9bceab3fdfc0");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("06940a6e-2b82-480b-b530-8a9b838ca679");
			if (column != null) {
				column.UId = new Guid("705c580e-8afb-4dc5-a343-50e7ed6b4295");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsSortable = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c0388918-b497-4635-a136-cd125a6474ce");
			if (column != null) {
				column.UId = new Guid("e42295d3-1206-4578-b6c8-4ae1ceea42db");
				column.Name = @"ColumnCaption";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("11536eea-7fb7-4afe-826f-8111a5490a74");
			if (column != null) {
				column.UId = new Guid("b025e5b6-e1d6-460a-98e6-80662f3d63ba");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("bd12ea8e-2bc2-42bf-925a-3ab766cc0b9f");
			if (column != null) {
				column.UId = new Guid("50c5d956-dc50-485b-b0b2-67273c9854b8");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.ModifiedInSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ProductCatalogueLevelGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProductCatalogueLevelGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProductCatalogueLevelGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevelGridPageEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevelGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseSortByPositionGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProductCatalogueLevelGridPageSchemaUserControl
	{

		public ProductCatalogueLevelGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCatalogueLevelGridPageEventsProcess";
			SchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6");
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

		private ProcessFlowElement _pageLoadCompleteEventSubProcess1;
		public ProcessFlowElement PageLoadCompleteEventSubProcess1 {
			get {
				return _pageLoadCompleteEventSubProcess1 ?? (_pageLoadCompleteEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess1",
					SchemaElementUId = new Guid("22e61b2e-6907-408a-9315-8014a8a04d7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startPageLoadCompleteMessage;
		public ProcessFlowElement StartPageLoadCompleteMessage {
			get {
				return _startPageLoadCompleteMessage ?? (_startPageLoadCompleteMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartPageLoadCompleteMessage",
					SchemaElementUId = new Guid("260d56e4-28a1-4bc8-9e2e-9ff61ecefbc5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setEditPageUIdScriptTask;
		public ProcessScriptTask SetEditPageUIdScriptTask {
			get {
				return _setEditPageUIdScriptTask ?? (_setEditPageUIdScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetEditPageUIdScriptTask",
					SchemaElementUId = new Guid("73f87eb3-a76e-4a42-a76e-875ed0d9b4f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetEditPageUIdScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowPageLoadCompleteMessageEvent;
		public ProcessThrowMessageEvent IntermediateThrowPageLoadCompleteMessageEvent {
			get {
				return _intermediateThrowPageLoadCompleteMessageEvent ?? (_intermediateThrowPageLoadCompleteMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowPageLoadCompleteMessageEvent",
					SchemaElementUId = new Guid("d7098847-4753-4b5a-b50e-3ca78274e1cb"),
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
			FlowElements[PageLoadCompleteEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess1 };
			FlowElements[StartPageLoadCompleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartPageLoadCompleteMessage };
			FlowElements[SetEditPageUIdScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetEditPageUIdScriptTask };
			FlowElements[IntermediateThrowPageLoadCompleteMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowPageLoadCompleteMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadCompleteEventSubProcess1":
						break;
					case "StartPageLoadCompleteMessage":
						e.Context.QueueTasks.Enqueue("SetEditPageUIdScriptTask");
						break;
					case "SetEditPageUIdScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowPageLoadCompleteMessageEvent");
						break;
					case "IntermediateThrowPageLoadCompleteMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartPageLoadCompleteMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PageLoadCompleteEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartPageLoadCompleteMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartPageLoadCompleteMessage";
					result = StartPageLoadCompleteMessage.Execute(context);
					break;
				case "SetEditPageUIdScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetEditPageUIdScriptTask";
					result = SetEditPageUIdScriptTask.Execute(context, SetEditPageUIdScriptTaskExecute);
					break;
				case "IntermediateThrowPageLoadCompleteMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowPageLoadCompleteMessageEvent.Execute(context);
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

		public virtual bool SetEditPageUIdScriptTaskExecute(ProcessExecutingContext context) {
			EditPageUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			Page.DataSource.LoadRows();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartPageLoadCompleteMessage")) {
							context.QueueTasks.Enqueue("StartPageLoadCompleteMessage");
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

	#region Class: ProductCatalogueLevelGridPageEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevelGridPageEventsProcess : ProductCatalogueLevelGridPageEventsProcess<Terrasoft.WebApp.ProductCatalogueLevelGridPageSchemaUserControl>
	{

		public ProductCatalogueLevelGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCatalogueLevelGridPageSchemaUserControl

	/// <exclude/>
	public partial class ProductCatalogueLevelGridPageSchemaUserControl : Terrasoft.WebApp.BaseSortByPositionGridPageSchemaUserControl
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
			var process = (ProductCatalogueLevelGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProductCatalogueLevelGridPageEventsProcess(UserConnection);
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
			SchemaName = "ProductCatalogueLevelGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevelGridPageEventsProcessSchema

	/// <exclude/>
	public class ProductCatalogueLevelGridPageEventsProcessSchema : Terrasoft.WebApp.BaseSortByPositionGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProductCatalogueLevelGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductCatalogueLevelGridPageEventsProcessSchema(ProductCatalogueLevelGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductCatalogueLevelGridPageEventsProcess";
			UId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf");
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaPageEventsLane = CreatePageEventsLaneLane();
			schemaLaneSet1.Lanes.Add(schemaPageEventsLane);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess1 = CreatePageLoadCompleteEventSubProcess1EventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess1);
			ProcessSchemaStartMessageEvent startpageloadcompletemessage = CreateStartPageLoadCompleteMessageStartMessageEvent();
			pageloadcompleteeventsubprocess1.FlowElements.Add(startpageloadcompletemessage);
			ProcessSchemaScriptTask seteditpageuidscripttask = CreateSetEditPageUIdScriptTaskScriptTask();
			pageloadcompleteeventsubprocess1.FlowElements.Add(seteditpageuidscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowpageloadcompletemessageevent = CreateIntermediateThrowPageLoadCompleteMessageEventIntermediateThrowMessageEvent();
			pageloadcompleteeventsubprocess1.FlowElements.Add(intermediatethrowpageloadcompletemessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("affab7c1-b08d-4022-838c-a3267e0125a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				CurveCenterPosition = new Point(194, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("260d56e4-28a1-4bc8-9e2e-9ff61ecefbc5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("73f87eb3-a76e-4a42-a76e-875ed0d9b4f5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1390b9ad-82a1-41ec-959f-a001a3d6ff04"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				CurveCenterPosition = new Point(356, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("73f87eb3-a76e-4a42-a76e-875ed0d9b4f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7098847-4753-4b5a-b50e-3ca78274e1cb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3f7fba8a-8526-4628-95d9-9137a2ec601e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(548, 193),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreatePageEventsLaneLane() {
			ProcessSchemaLane schemaPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("0ecd0772-23c9-4e5b-8cd8-60251240945e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3f7fba8a-8526-4628-95d9-9137a2ec601e"),
				CreatedInOwnerSchemaUId = new Guid("aad3a89d-581b-4cca-9763-9317d0de11b6"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				Name = @"PageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(519, 193),
				UseBackgroundMode = false
			};
			return schemaPageEventsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("22e61b2e-6907-408a-9315-8014a8a04d7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ecd0772-23c9-4e5b-8cd8-60251240945e"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				Name = @"PageLoadCompleteEventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(400, 165),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartPageLoadCompleteMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("260d56e4-28a1-4bc8-9e2e-9ff61ecefbc5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("22e61b2e-6907-408a-9315-8014a8a04d7d"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				Name = @"StartPageLoadCompleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetEditPageUIdScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("73f87eb3-a76e-4a42-a76e-875ed0d9b4f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("22e61b2e-6907-408a-9315-8014a8a04d7d"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				Name = @"SetEditPageUIdScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,77,201,44,9,72,76,79,13,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,74,53,51,75,77,74,76,74,210,53,55,77,51,209,53,73,50,72,209,181,76,52,55,214,77,53,48,53,54,54,51,53,74,77,52,51,86,210,180,230,229,2,105,214,115,73,44,73,12,206,47,45,74,78,213,243,201,79,76,9,202,47,47,214,0,73,22,165,150,148,22,229,41,148,20,149,166,90,3,0,129,196,57,61,106,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowPageLoadCompleteMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d7098847-4753-4b5a-b50e-3ca78274e1cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("22e61b2e-6907-408a-9315-8014a8a04d7d"),
				CreatedInOwnerSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"),
				Name = @"IntermediateThrowPageLoadCompleteMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 72),
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
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f759fd7f-c235-4aad-9f86-46ed65d3d366"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCatalogueLevelGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9784fa23-cb50-4a56-885c-d059ab150bbf"));
		}

		#endregion

	}

	#endregion

}

