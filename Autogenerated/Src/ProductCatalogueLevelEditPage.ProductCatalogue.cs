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
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: ProductCatalogueLevelEditPageSchema

	/// <exclude/>
	public class ProductCatalogueLevelEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _productColumnEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ProductColumnEdit {
			get {
				return _productColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _entityColumnEditToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton EntityColumnEditToolButton {
			get {
				return _entityColumnEditToolButton;
			}
		}

		#endregion

		#region Constructors: Public

		public ProductCatalogueLevelEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProductCatalogueLevelEditPageSchema(ProductCatalogueLevelEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("64241869-6a45-43b4-9ea3-d180d1964c9e");
			NameEdit.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.Enabled = false;
			DescriptionEdit.Hidden = true;
			DescriptionEdit.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateCustomControls() {
			CustomControls.FitHeightByContent = true;
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			RealUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			Name = "ProductCatalogueLevelEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			Width = 600;
			Height = 400;
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductCatalogueLevelEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.MoveItem(2, CustomControls);
			CustomControls.InsertItem(0, CreateProductColumnEdit());
			ProductColumnEdit.InsertItem(0, CreateEntityColumnEditToolButton());
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateProductCatalogueLevelEditPageEventsProcessSchema() {
			var schema = new ProductCatalogueLevelEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateEntityColumnEditToolButton() {
			_entityColumnEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_entityColumnEditToolButton.UId = new Guid("77143f5e-1622-48d5-9eb7-b123c908faec");
			_entityColumnEditToolButton.Name = "EntityColumnEditToolButton";
			_entityColumnEditToolButton.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			_entityColumnEditToolButton.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			_entityColumnEditToolButton.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			_entityColumnEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_entityColumnEditToolButton.Tag = "";
			_entityColumnEditToolButton.Image = new ControlImage {};
			return _entityColumnEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateProductColumnEdit() {
			_productColumnEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_productColumnEdit.UId = new Guid("339d4e2e-5aa9-45ff-a640-302e75247b4b");
			_productColumnEdit.Name = "ProductColumnEdit";
			_productColumnEdit.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			_productColumnEdit.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			_productColumnEdit.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			_productColumnEdit.Tag = "";
			_productColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_productColumnEdit.Image = new ControlImage {};
			_productColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_productColumnEdit.DataSource = "DataSource";
			_productColumnEdit.ColumnUId = new Guid("2f2f7ba1-550a-42b1-9d0d-e794739ae796");
			_productColumnEdit.Enabled = false;
			_productColumnEdit.Required = true;
			return _productColumnEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			DataSource.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("5042afac-793d-44c8-898b-6843973160b9");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("2b8cfc11-1499-49a6-937b-689128df06a6");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("b056c683-be96-4deb-930e-69097a0c2901");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a88eb33c-9747-42bc-bd71-b2cc2c6e8525");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("dd2e02c4-2c23-4f56-81fc-64a972a631f1");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("44271be4-9a39-4d9d-88b9-5580535c3183");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("bd12ea8e-2bc2-42bf-925a-3ab766cc0b9f");
			if (column != null) {
				column.UId = new Guid("3d9664cf-8598-407a-8490-0a3b452a5f83");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("06940a6e-2b82-480b-b530-8a9b838ca679");
			if (column != null) {
				column.UId = new Guid("64241869-6a45-43b4-9ea3-d180d1964c9e");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("11536eea-7fb7-4afe-826f-8111a5490a74");
			if (column != null) {
				column.UId = new Guid("6c1d152b-8cc5-4684-83a6-6b8cbe6a2904");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c0388918-b497-4635-a136-cd125a6474ce");
			if (column != null) {
				column.UId = new Guid("2f2f7ba1-550a-42b1-9d0d-e794739ae796");
				column.Name = @"ColumnCaption";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7e2a9c23-8528-4e3c-acc0-c4ed42bd9c65");
			if (column != null) {
				column.UId = new Guid("a4b597da-bb80-4815-8763-2f7352310d5f");
				column.Name = @"ColumnPath";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("015b2058-0373-438a-86bb-e690d5164fbc");
			if (column != null) {
				column.UId = new Guid("efa03540-7f50-4277-a060-97fe002c2627");
				column.Name = @"ReferenceSchemaName";
				column.CreatedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.ModifiedInSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ProductCatalogueLevelEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProductCatalogueLevelEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProductCatalogueLevelEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevelEditPageEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevelEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProductCatalogueLevelEditPageSchemaUserControl
	{

		public ProductCatalogueLevelEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCatalogueLevelEditPageEventsProcess";
			SchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63");
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

		public virtual bool ColumnsExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnsStructureExplorer {
			get;
			set;
		}

		public virtual string EntityColumn_ColumnCaption {
			get;
			set;
		}

		public virtual string EntityColumn_MetaPath {
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
					SchemaElementUId = new Guid("995b38e5-9a97-4204-a66d-584cb7fec7a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entityColumnEditToolButtonClickMessage;
		public ProcessFlowElement EntityColumnEditToolButtonClickMessage {
			get {
				return _entityColumnEditToolButtonClickMessage ?? (_entityColumnEditToolButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntityColumnEditToolButtonClickMessage",
					SchemaElementUId = new Guid("393ec3bd-7a6a-4109-a22d-ebdd3299b74f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _openStructureExplorerScriptTask;
		public ProcessScriptTask OpenStructureExplorerScriptTask {
			get {
				return _openStructureExplorerScriptTask ?? (_openStructureExplorerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenStructureExplorerScriptTask",
					SchemaElementUId = new Guid("df73a725-758e-4f1e-9c63-0786cf985704"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenStructureExplorerScriptTaskExecute,
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
					SchemaElementUId = new Guid("734e1a05-a647-4c8b-9f38-f4c8e4c64524"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initStartMessage1;
		public ProcessFlowElement InitStartMessage1 {
			get {
				return _initStartMessage1 ?? (_initStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage1",
					SchemaElementUId = new Guid("da2a7816-c279-4dc9-ab83-efc158015b45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent1 {
			get {
				return _initIntermediateThrowMessageEvent1 ?? (_initIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("522a721f-e6cf-4ebb-954d-c24134dba223"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initScriptTask1;
		public ProcessScriptTask InitScriptTask1 {
			get {
				return _initScriptTask1 ?? (_initScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask1",
					SchemaElementUId = new Guid("d2cb237a-9ef1-4da1-805b-22212c610d85"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[EntityColumnEditToolButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityColumnEditToolButtonClickMessage };
			FlowElements[OpenStructureExplorerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenStructureExplorerScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[InitStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage1 };
			FlowElements[InitIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent1 };
			FlowElements[InitScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "EntityColumnEditToolButtonClickMessage":
						e.Context.QueueTasks.Enqueue("OpenStructureExplorerScriptTask");
						break;
					case "OpenStructureExplorerScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "InitStartMessage1":
						e.Context.QueueTasks.Enqueue("InitScriptTask1");
						break;
					case "InitIntermediateThrowMessageEvent1":
						break;
					case "InitScriptTask1":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent1");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EntityColumnEditToolButtonClickMessage");
			ActivatedEventElements.Add("InitStartMessage1");
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
				case "EntityColumnEditToolButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityColumnEditToolButtonClickMessage";
					result = EntityColumnEditToolButtonClickMessage.Execute(context);
					break;
				case "OpenStructureExplorerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenStructureExplorerScriptTask";
					result = OpenStructureExplorerScriptTask.Execute(context, OpenStructureExplorerScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage1";
					result = InitStartMessage1.Execute(context);
					break;
				case "InitIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "InitScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask1";
					result = InitScriptTask1.Execute(context, InitScriptTask1Execute);
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
				case "EntityColumn_MetaPath":
					EntityColumn_MetaPath = reader.GetValue<System.String>();
				break;
				case "EntityColumn_ColumnCaption":
					EntityColumn_ColumnCaption = reader.GetValue<System.String>();
				break;
				case "ColumnsStructureExplorer":
					ColumnsStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "ColumnsExplorerCreated":
					ColumnsExplorerCreated = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool OpenStructureExplorerScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaManager = (EntitySchemaManager)Page.UserConnection.GetSchemaManager("EntitySchemaManager");
			var moduleEntitySchema = entitySchemaManager.GetInstanceByName("Product");
			ShowColumnExplorer(moduleEntitySchema);
			return true;
		}

		public virtual bool InitScriptTask1Execute(ProcessExecutingContext context) {
			if (ColumnsExplorerCreated){
				StructureExplorer structureExplorer = (StructureExplorer) ColumnsStructureExplorer;
				if (structureExplorer == null) {
					ColumnsExplorerCreated = true;
					structureExplorer = CreateColumnsExplorerControl(
						Page.ProductColumnEdit,
						new AjaxEventHandler(ColumnsExplorer_SetColumnMetaPathInfoHandler)) 
						as StructureExplorer;
					//structureExplorer.Register();
					ColumnsStructureExplorer = structureExplorer;
				}
			}
			return true;
		}

		public virtual void ShowColumnExplorer(Schema entitySchema) {
			StructureExplorer structureExplorer = (StructureExplorer) ColumnsStructureExplorer;
			if (structureExplorer == null) {
				ColumnsExplorerCreated = true;
				structureExplorer = CreateColumnsExplorerControl(
					Page.ProductColumnEdit,
					new AjaxEventHandler(ColumnsExplorer_SetColumnMetaPathInfoHandler)) 
					as StructureExplorer;
				structureExplorer.Register();
				ColumnsStructureExplorer = structureExplorer;
			}
			Guid schemaUId = entitySchema.UId;
			string managerName = "EntitySchemaManager";
			structureExplorer.ManagerName = managerName;
			structureExplorer.ShowEditWindow(entitySchema, null);
		}

		public virtual StructureExplorer CreateColumnsExplorerControl(TextEdit textEdit, AjaxEventHandler setColumnMetaPathInfo_AjaxEventHandler) {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);	
			var structureExplorer = new StructureExplorer(textEdit, "columns", false, false, string.Empty);
			
			List<string> excludeTypes = new List<string> { 
				"Guid", 
				"Binary", 
				"File", 
				"Image", 
				"ImageLookup",
				"Color",
				"Text", 
				"MaxSizeText", 
				"HashText",
				"SecureText",
				"ShortText",
				"MediumText",
				"LongText",
				"Boolean",
				"Money",
				"Float",
				"Float1",
				"Float2",
				"Float3",
				"Float4",
				"Integer",
				"DateTime"
			};
			
			structureExplorer.IsShowSystemColumns = false;
			structureExplorer.ExcludeDataValueTypes = excludeTypes.ToArray();
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += setColumnMetaPathInfo_AjaxEventHandler;
			editComplete.ExtraParameters.Add(param);
			return structureExplorer;
		}

		public virtual void ColumnsExplorer_SetColumnMetaPathInfoHandler(object sender, AjaxEventArgs e) {
			var jObject = (JObject)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			EntityColumn_MetaPath = jObject.Value<string>("metaPath");
			EntityColumn_ColumnCaption = jObject.Value<string>("caption");
			var columnType = jObject.Value<string>("dataValueTypeName");
			
			if (columnType!="Lookup" && columnType!="Enum" && columnType!="MultiLookup") {
				Page.ProductColumnEdit.Text = string.Empty;
				return;
			}
			
			TranslateMetaPath();
			if (!string.IsNullOrWhiteSpace(EntityColumn_ColumnCaption)) {
				Page.ProductColumnEdit.Text = EntityColumn_ColumnCaption;
			} 
			else {
				Page.ProductColumnEdit.Text = EntityColumn_MetaPath;
			}
			
			if (string.IsNullOrWhiteSpace(Page.NameEdit.Text)) {
				Page.NameEdit.Text = Page.ProductColumnEdit.Text;
			} 
		}

		public virtual void TranslateMetaPath() {
			var activeRow = Page.DataSource.ActiveRow;
			var entitySchemaManager = (EntitySchemaManager)Page.UserConnection.GetSchemaManager("EntitySchemaManager");
			var refSchema = entitySchemaManager.GetInstanceByName("Product") as EntitySchema;
			var metaPath = EntityColumn_MetaPath;
			string resultPath = string.Empty;
			string referenceSchemaName = string.Empty;
			
			if (refSchema==null || string.IsNullOrWhiteSpace(metaPath)) {
				return;
			}
			
			var columnIDs = metaPath.Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);
			
			foreach(var columnID in columnIDs) {
				var column = refSchema.Columns.First((col)=>(col.UId.ToString() == columnID));
				resultPath += (column.Name + "."); 
				refSchema = column.ReferenceSchema as EntitySchema;
			}
			
			referenceSchemaName = refSchema.Name;
			resultPath = resultPath.Trim('.');
			
			if (activeRow != null) {
				activeRow.SetColumnValue("ColumnPath", resultPath);
				activeRow.SetColumnValue("ReferenceSchemaName", referenceSchemaName);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EntityColumnEditToolButtonClick":
							if (ActivatedEventElements.Contains("EntityColumnEditToolButtonClickMessage")) {
							context.QueueTasks.Enqueue("EntityColumnEditToolButtonClickMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage1")) {
							context.QueueTasks.Enqueue("InitStartMessage1");
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
			if (!HasMapping("EntityColumn_MetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityColumn_MetaPath", EntityColumn_MetaPath, null);
			}
			if (!HasMapping("EntityColumn_ColumnCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityColumn_ColumnCaption", EntityColumn_ColumnCaption, null);
			}
			if (ColumnsStructureExplorer != null) {
				if (ColumnsStructureExplorer.GetType().IsSerializable ||
					ColumnsStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnsStructureExplorer", ColumnsStructureExplorer, null);
				}
			}
			if (!HasMapping("ColumnsExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnsExplorerCreated", ColumnsExplorerCreated, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevelEditPageEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevelEditPageEventsProcess : ProductCatalogueLevelEditPageEventsProcess<Terrasoft.WebApp.ProductCatalogueLevelEditPageSchemaUserControl>
	{

		public ProductCatalogueLevelEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCatalogueLevelEditPageSchemaUserControl

	/// <exclude/>
	public partial class ProductCatalogueLevelEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit ProductColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ProductColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton EntityColumnEditToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("EntityColumnEditToolButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EntityColumnEditToolButton.AjaxEvents.Click.Event += EntityColumnEditToolButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntityColumnEditToolButton.AjaxEvents.Click.Event -= EntityColumnEditToolButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ProductCatalogueLevelEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProductCatalogueLevelEditPageEventsProcess(UserConnection);
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

		public virtual void EntityColumnEditToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EntityColumnEditToolButtonClick");
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
			SchemaName = "ProductCatalogueLevelEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevelEditPageEventsProcessSchema

	/// <exclude/>
	public class ProductCatalogueLevelEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProductCatalogueLevelEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductCatalogueLevelEditPageEventsProcessSchema(ProductCatalogueLevelEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductCatalogueLevelEditPageEventsProcess";
			UId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2");
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateColumnsExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a2ce496-ea90-4b65-b9e1-d17377e79f00"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"ColumnsExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnsStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4f455f7e-5765-42c5-8b1b-487f4ddb6212"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"ColumnsStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityColumn_ColumnCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5187ca55-a628-4e14-a611-ee74c4033b1e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"EntityColumn_ColumnCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityColumn_MetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e3233285-2872-48ba-b2b8-cca42a8a56a7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"EntityColumn_MetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateColumnsExplorerCreatedParameter());
			Parameters.Add(CreateColumnsStructureExplorerParameter());
			Parameters.Add(CreateEntityColumn_ColumnCaptionParameter());
			Parameters.Add(CreateEntityColumn_MetaPathParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet2.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent entitycolumnedittoolbuttonclickmessage = CreateEntityColumnEditToolButtonClickMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(entitycolumnedittoolbuttonclickmessage);
			ProcessSchemaScriptTask openstructureexplorerscripttask = CreateOpenStructureExplorerScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(openstructureexplorerscripttask);
			ProcessSchemaStartMessageEvent initstartmessage1 = CreateInitStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(initstartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent1 = CreateInitIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(initintermediatethrowmessageevent1);
			ProcessSchemaScriptTask initscripttask1 = CreateInitScriptTask1ScriptTask();
			eventsubprocess2.FlowElements.Add(initscripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d431512a-efa9-4fcc-95fe-932e8b001e97"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("393ec3bd-7a6a-4109-a22d-ebdd3299b74f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df73a725-758e-4f1e-9c63-0786cf985704"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("07889659-9055-43bf-8299-1e838d77a44e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				CurveCenterPosition = new Point(169, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da2a7816-c279-4dc9-ab83-efc158015b45"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2cb237a-9ef1-4da1-805b-22212c610d85"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("5bf520e2-ec7a-4147-9ab7-4c9be6db8040"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				CurveCenterPosition = new Point(296, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2cb237a-9ef1-4da1-805b-22212c610d85"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("522a721f-e6cf-4ebb-954d-c24134dba223"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2ecf7fe8-e863-466c-850a-0ad5f9ec1ddb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(695, 183),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("4d667825-6ef5-46aa-ab77-f2064ecbdfbf"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2ecf7fe8-e863-466c-850a-0ad5f9ec1ddb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(666, 183),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("65cd9108-8b95-4f35-b5d9-388497a4d548"),
				ContainerItemIndex = 2,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"LaneSet2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 193),
				Size = new Size(695, 178),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("7a2a92b2-899d-408f-ab42-a69736860a33"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("65cd9108-8b95-4f35-b5d9-388497a4d548"),
				CreatedInOwnerSchemaUId = new Guid("e66ebabb-75f4-4b0d-9a73-e0533652ea63"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(666, 178),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("995b38e5-9a97-4204-a66d-584cb7fec7a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d667825-6ef5-46aa-ab77-f2064ecbdfbf"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(465, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntityColumnEditToolButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("393ec3bd-7a6a-4109-a22d-ebdd3299b74f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("995b38e5-9a97-4204-a66d-584cb7fec7a5"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityColumnEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"EntityColumnEditToolButtonClickMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenStructureExplorerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("df73a725-758e-4f1e-9c63-0786cf985704"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("995b38e5-9a97-4204-a66d-584cb7fec7a5"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"OpenStructureExplorerScriptTask",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,65,10,194,64,12,69,247,130,119,24,102,53,221,244,2,197,141,165,136,11,165,80,60,64,24,131,45,204,36,146,102,170,189,189,83,87,74,187,201,226,243,255,123,153,64,12,146,14,58,119,190,199,8,23,32,120,160,152,131,113,205,58,46,218,124,203,219,136,82,51,17,122,29,152,202,19,234,95,201,217,141,165,45,170,253,110,202,178,200,247,20,240,183,145,93,27,31,44,216,51,141,10,228,241,56,95,33,162,179,173,228,177,215,47,171,235,249,85,115,72,145,154,247,51,176,100,239,26,189,20,5,53,9,25,149,132,213,7,251,24,5,41,238,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("734e1a05-a647-4c8b-9f38-f4c8e4c64524"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a2a92b2-899d-408f-ab42-a69736860a33"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(281, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("da2a7816-c279-4dc9-ab83-efc158015b45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("734e1a05-a647-4c8b-9f38-f4c8e4c64524"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"InitStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("522a721f-e6cf-4ebb-954d-c24134dba223"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("734e1a05-a647-4c8b-9f38-f4c8e4c64524"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"InitIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d2cb237a-9ef1-4da1-805b-22212c610d85"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("734e1a05-a647-4c8b-9f38-f4c8e4c64524"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Name = @"InitScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,205,10,130,64,16,62,175,208,59,204,209,133,208,7,16,15,17,66,29,2,201,7,136,37,71,51,182,221,24,199,18,162,119,111,77,131,112,133,57,205,124,127,243,53,21,132,91,171,187,155,105,179,254,174,45,33,109,9,21,99,41,95,171,64,20,76,221,153,59,194,223,17,90,111,147,66,232,193,36,76,162,222,37,113,170,141,51,93,208,73,193,116,90,75,24,140,197,114,40,103,230,120,56,136,136,165,36,35,108,206,181,134,201,234,112,32,137,92,213,24,229,100,75,199,29,113,89,217,240,250,123,51,248,132,205,85,245,217,3,13,239,148,41,53,210,188,157,83,129,19,239,128,172,114,197,151,189,169,236,4,150,18,190,66,170,133,197,199,69,28,123,169,163,35,214,77,203,206,73,38,127,143,251,205,167,126,247,3,225,189,10,220,16,186,189,25,203,249,0,113,174,3,165,212,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateShowColumnExplorerMethod());
			Methods.Add(CreateCreateColumnsExplorerControlMethod());
			Methods.Add(CreateColumnsExplorer_SetColumnMetaPathInfoHandlerMethod());
			Methods.Add(CreateTranslateMetaPathMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95e0bfa6-9310-40b5-a2c8-473b54807fb2"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("29072a36-08a6-45b5-b544-4a81f7754952"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4bfbfdfd-4617-42dc-98d2-00346718bf49"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
		}

		protected virtual SchemaMethod CreateShowColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fcbc903d-874c-4f9e-a4de-851936ecb4c9"),
				Name = "ShowColumnExplorer",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("deda5947-417f-479b-998d-610817551804"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Schema",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,65,107,132,48,16,133,207,10,254,135,97,79,9,44,254,1,217,67,89,164,187,7,139,52,148,30,75,216,204,106,74,76,74,140,117,75,233,127,239,88,45,181,234,117,230,125,47,239,77,68,240,221,37,116,30,243,219,155,113,30,61,180,171,201,1,152,88,14,57,28,157,233,26,219,174,54,89,18,235,43,176,13,155,3,216,206,24,14,159,73,28,77,244,239,242,232,81,6,84,244,20,97,72,22,209,86,140,81,181,68,157,13,222,25,70,76,84,202,10,211,210,59,69,232,40,203,149,14,251,97,101,177,135,187,87,121,203,223,209,134,147,180,202,160,103,11,171,23,129,19,86,96,144,165,12,245,217,94,221,36,230,28,6,31,217,194,86,229,117,222,244,17,43,221,6,122,133,103,127,133,87,44,213,90,161,164,255,74,226,251,78,43,104,47,53,54,242,233,60,156,134,130,235,240,33,126,38,41,141,72,70,168,182,21,52,210,82,115,255,32,27,36,221,46,159,9,139,113,181,27,197,139,136,197,63,110,230,178,169,22,181,235,135,123,62,107,171,92,207,230,113,246,227,215,102,223,255,136,145,76,79,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnsExplorerControlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("96fe09f9-932f-4686-a3d5-66fdd4f6a8c4"),
				Name = "CreateColumnsExplorerControl",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fff5f616-38d7-40a3-9697-178a2763250f"),
				Name = "textEdit",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TextEdit",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("79fabd97-5cdb-4743-bf4a-3ce054eec4c3"),
				Name = "setColumnMetaPathInfo_AjaxEventHandler",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventHandler",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,83,193,110,219,48,12,61,215,128,255,193,240,41,69,11,1,221,118,75,55,32,205,220,213,64,2,20,139,187,30,7,46,102,18,173,178,100,72,116,98,111,216,191,143,142,12,71,89,118,202,123,52,245,248,164,199,236,193,38,53,88,168,146,143,137,198,67,82,160,181,224,204,134,196,75,46,94,241,199,220,104,178,70,57,49,130,231,190,27,9,237,36,149,132,149,203,245,198,164,183,201,25,25,123,150,166,68,241,21,14,215,211,171,56,218,243,44,71,182,89,83,99,49,107,107,101,44,218,97,238,234,223,250,132,176,165,172,148,196,210,107,163,154,74,59,22,222,128,114,56,254,176,152,212,91,145,85,53,117,215,211,56,138,163,133,116,116,239,203,159,18,108,215,170,41,177,232,106,116,195,152,179,239,191,147,56,186,74,191,52,178,100,229,30,62,72,13,182,27,200,163,84,56,192,188,130,237,25,94,24,243,214,212,233,109,95,152,27,246,235,97,193,150,135,182,37,180,43,249,11,131,202,19,184,157,167,61,91,225,154,47,27,240,157,177,116,162,75,44,101,83,157,248,194,232,237,137,61,24,163,16,244,208,106,52,118,30,62,42,3,20,192,187,0,191,11,240,251,0,127,240,56,215,132,91,28,238,241,25,8,11,89,97,26,71,127,142,207,122,145,154,200,29,59,62,172,58,199,169,207,125,60,252,196,199,92,166,255,235,207,124,22,172,12,223,64,53,99,40,97,70,162,48,51,222,190,110,210,103,57,55,85,205,55,211,52,251,9,109,182,103,144,240,155,80,95,86,188,89,124,244,114,200,216,234,68,22,244,178,90,120,84,120,181,27,86,64,242,222,151,72,240,12,180,235,215,247,251,168,242,4,186,84,104,47,142,183,100,97,220,112,39,102,101,57,57,254,133,122,219,22,217,145,190,244,54,253,11,103,146,10,56,105,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnsExplorer_SetColumnMetaPathInfoHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cc53253b-c046-4f6d-a402-2f31691371fb"),
				Name = "ColumnsExplorer_SetColumnMetaPathInfoHandler",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6c127b40-b0ea-404c-bc80-4d4aac3ac220"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("027647d8-9df2-4846-82db-d647cc364dbb"),
				Name = "e",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				ModifiedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,203,78,195,48,16,69,215,141,148,127,112,179,168,146,77,126,0,202,166,100,209,138,62,36,42,88,32,132,134,116,218,186,56,118,100,143,171,22,196,191,99,231,81,168,170,32,88,217,26,207,189,115,238,120,15,154,237,230,175,59,204,137,13,89,60,169,175,201,196,40,153,222,162,65,205,65,240,119,140,49,205,14,164,97,1,26,10,36,212,230,41,226,132,133,25,203,181,138,158,147,171,48,200,36,113,58,142,148,176,133,124,153,34,185,94,218,58,207,198,61,125,0,97,241,218,144,230,114,115,19,71,69,211,17,93,104,235,99,4,37,113,37,187,13,242,186,161,210,239,93,138,188,146,45,143,37,118,107,86,64,80,149,124,219,204,37,169,212,97,192,215,44,254,214,247,135,209,157,82,111,182,140,216,96,192,206,234,153,180,197,101,117,106,5,241,70,146,176,143,48,232,45,96,131,233,66,171,149,205,169,206,147,173,56,165,75,60,248,53,215,60,105,86,148,116,116,243,123,26,201,106,233,110,159,30,102,169,65,26,1,132,237,18,99,15,233,17,251,141,112,108,102,86,136,185,126,220,186,63,184,47,33,199,184,123,131,201,95,136,186,229,158,138,133,1,10,131,255,245,105,249,219,96,62,66,119,130,202,216,255,201,201,239,39,249,217,131,27,244,11,70,69,252,5,140,69,121,181,216,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateTranslateMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("78e71c38-f52f-463f-8dab-62e063c395c3"),
				Name = "TranslateMetaPath",
				CreatedInSchemaUId = new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,203,110,219,48,16,60,199,128,255,129,213,37,36,18,240,7,2,21,104,147,180,240,33,137,97,37,233,161,40,10,130,89,71,4,36,210,32,87,14,140,196,255,222,37,41,75,10,236,158,4,238,206,206,204,62,180,85,158,41,141,102,11,43,247,198,74,182,84,175,32,111,20,170,202,117,94,131,252,118,200,93,205,103,91,194,130,69,131,187,74,215,208,170,59,101,9,237,169,138,223,30,135,69,162,122,10,224,175,157,181,64,60,206,202,159,128,159,64,188,56,81,89,136,94,204,195,58,39,72,226,132,112,100,91,216,128,202,106,248,190,187,87,45,240,98,233,221,75,167,177,16,76,5,54,229,238,41,91,64,181,84,88,19,99,206,94,187,166,107,237,223,187,62,78,176,128,222,216,87,18,15,93,131,61,54,199,228,109,187,193,221,20,178,6,15,164,158,37,162,131,99,236,124,102,214,140,15,173,148,165,237,154,134,125,124,28,112,139,112,79,129,7,255,171,54,8,213,70,105,224,7,147,66,176,247,249,236,204,3,118,222,18,213,62,178,197,46,116,50,189,184,9,36,119,0,203,106,211,24,228,22,222,152,174,149,255,253,231,253,92,158,239,47,89,149,100,82,242,97,19,151,16,228,10,90,183,133,100,144,134,224,13,4,145,140,174,157,7,165,107,62,149,96,198,142,114,217,207,152,38,249,161,49,153,39,25,228,15,227,3,114,78,8,81,126,141,31,249,180,120,145,143,46,27,225,130,149,229,192,40,162,240,217,100,212,23,116,76,57,41,211,56,47,88,33,233,30,88,66,141,215,208,67,86,159,23,112,98,231,105,100,167,247,52,58,143,129,171,8,155,108,124,124,200,71,111,90,78,195,20,195,54,199,63,230,75,201,226,62,243,96,134,176,172,0,243,56,158,85,211,209,89,230,71,100,43,46,39,212,169,251,255,87,173,142,125,167,242,163,104,228,217,255,3,15,52,187,50,203,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCatalogueLevelEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52fa844c-d5aa-492e-a7f0-c0ff5bfa69c2"));
		}

		#endregion

	}

	#endregion

}

