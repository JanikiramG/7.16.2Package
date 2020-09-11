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

	#region Class: ProductInLeadTypeEditPageSchema

	/// <exclude/>
	public class ProductInLeadTypeEditPageSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MenuItem _addProduct;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddProduct {
			get {
				return _addProduct;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _addFolder;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddFolder {
			get {
				return _addFolder;
			}
		}

		#endregion

		#region Constructors: Public

		public ProductInLeadTypeEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProductInLeadTypeEditPageSchema(ProductInLeadTypeEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @""
			};
			CopyButton.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			RealUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			Name = "ProductInLeadTypeEditPage";
			ParentSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductInLeadTypeEditPageEventsProcessSchema();
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
			AddButton.InsertItem(0, CreateAddProduct());
			AddButton.InsertItem(1, CreateAddFolder());
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

		protected virtual EmbeddedProcessSchema CreateProductInLeadTypeEditPageEventsProcessSchema() {
			var schema = new ProductInLeadTypeEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddProduct() {
			_addProduct = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addProduct.UId = new Guid("70bc2fd9-8ab1-4e4e-b2be-174f85af7284");
			_addProduct.Name = "AddProduct";
			_addProduct.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			_addProduct.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			_addProduct.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			_addProduct.AjaxEvents.Click.IsProcessEventHandler = true;
			_addProduct.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addProduct.Image = new ControlImage {};
			_addProduct.Tag = "";
			return _addProduct;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddFolder() {
			_addFolder = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addFolder.UId = new Guid("993f4921-3a4f-46bb-acaf-8c3f9a127419");
			_addFolder.Name = "AddFolder";
			_addFolder.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			_addFolder.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			_addFolder.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			_addFolder.AjaxEvents.Click.IsProcessEventHandler = true;
			_addFolder.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addFolder.Image = new ControlImage {};
			_addFolder.Tag = "";
			return _addFolder;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7");
			DataSource.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("59a1bc25-5042-4a03-8e68-559ff7037471");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("3525ddad-0e14-4765-a3dc-8561f46adf61");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("a1926b27-fcef-4ce5-a3f6-2cd41b4bfeb2");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a90995af-ca61-43f6-be42-2a43e34d496f");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("e8d19a2a-5447-463b-bb8f-6236bc2b705e");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("b3a7a7f0-9494-46e0-bcda-ef3bc47296c8");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2b6f3712-6f24-4801-9fbd-ccdc1623e8d8");
			if (column != null) {
				column.UId = new Guid("897979ce-6d0d-446b-9d72-36a4c41d94a4");
				column.Name = @"Product";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0fcce791-2c61-478a-a45e-456c0004b3dd");
			if (column != null) {
				column.UId = new Guid("e5dfd28f-cb11-4692-acd3-bf566b239178");
				column.Name = @"ProductFolder";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9f959d0f-1b57-4fab-b3ab-b0b8f5f87417");
			if (column != null) {
				column.UId = new Guid("a98f599e-bc14-492d-bc90-38c213bad6a6");
				column.Name = @"LeadType";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("637345a6-9354-4561-a1f7-48702546ff5f");
			if (column != null) {
				column.UId = new Guid("65173543-e833-4db8-8a6b-c89eb522ff02");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d5291c1a-2394-4f21-b24b-e7607cb2b9cf");
			if (column != null) {
				column.UId = new Guid("e85664e7-2607-4e39-872f-096f4658f887");
				column.Name = @"ProductTypeInLeadType";
				column.CreatedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
				column.ModifiedInSchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
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
			return new ProductInLeadTypeEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProductInLeadTypeEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProductInLeadTypeEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProductInLeadTypeEditPageEventsProcess

	/// <exclude/>
	public class ProductInLeadTypeEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProductInLeadTypeEditPageSchemaUserControl
	{

		#region Class: OpenLookUpPageUserTaskFlowElement

		/// <exclude/>
		public class OpenLookUpPageUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookUpPageUserTaskFlowElement(UserConnection userConnection, ProductInLeadTypeEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookUpPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowCountInsertedUserTaskFlowElement

		/// <exclude/>
		public class ShowCountInsertedUserTaskFlowElement : QuestionUserTask
		{

			public ShowCountInsertedUserTaskFlowElement(UserConnection userConnection, ProductInLeadTypeEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowCountInsertedUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ProductInLeadTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductInLeadTypeEditPageEventsProcess";
			SchemaUId = new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f7b0e950-5395-44ec-843c-14ac397a12e5");
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

		public virtual string RecordType {
			get;
			set;
		}

		public virtual int CountInserting {
			get;
			set;
		}

		public virtual int CountInserted {
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
					SchemaElementUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addProductStartMessage;
		public ProcessFlowElement AddProductStartMessage {
			get {
				return _addProductStartMessage ?? (_addProductStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddProductStartMessage",
					SchemaElementUId = new Guid("08c85838-be78-41e9-bb98-b6f23f23d009"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addProductPrepareLookupScriptTask;
		public ProcessScriptTask AddProductPrepareLookupScriptTask {
			get {
				return _addProductPrepareLookupScriptTask ?? (_addProductPrepareLookupScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddProductPrepareLookupScriptTask",
					SchemaElementUId = new Guid("b52d52f1-2d1f-49cb-b54a-2bfc0763f892"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddProductPrepareLookupScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _addFolderStartMessage;
		public ProcessFlowElement AddFolderStartMessage {
			get {
				return _addFolderStartMessage ?? (_addFolderStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddFolderStartMessage",
					SchemaElementUId = new Guid("fa671b8c-e9fe-4a70-9bf0-5f7d7da696c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addProductFolderPrepareLookupScriptTask;
		public ProcessScriptTask AddProductFolderPrepareLookupScriptTask {
			get {
				return _addProductFolderPrepareLookupScriptTask ?? (_addProductFolderPrepareLookupScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddProductFolderPrepareLookupScriptTask",
					SchemaElementUId = new Guid("268bfdec-5708-4d44-b0ee-81eb96eda0b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddProductFolderPrepareLookupScriptTaskExecute,
				});
			}
		}

		private OpenLookUpPageUserTaskFlowElement _openLookUpPageUserTask;
		public OpenLookUpPageUserTaskFlowElement OpenLookUpPageUserTask {
			get {
				return _openLookUpPageUserTask ?? (_openLookUpPageUserTask = new OpenLookUpPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEvent1;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEvent1 {
			get {
				return _intermediateCatchMessageEvent1 ?? (_intermediateCatchMessageEvent1 = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEvent1",
					SchemaElementUId = new Guid("f9eea79f-e144-4c8d-b23b-3e4c559c198e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _lookupGridPageClosedScriptTask;
		public ProcessScriptTask LookupGridPageClosedScriptTask {
			get {
				return _lookupGridPageClosedScriptTask ?? (_lookupGridPageClosedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LookupGridPageClosedScriptTask",
					SchemaElementUId = new Guid("417696e0-faa8-415c-9f75-7d677079f0a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LookupGridPageClosedScriptTaskExecute,
				});
			}
		}

		private ShowCountInsertedUserTaskFlowElement _showCountInsertedUserTask;
		public ShowCountInsertedUserTaskFlowElement ShowCountInsertedUserTask {
			get {
				return _showCountInsertedUserTask ?? (_showCountInsertedUserTask = new ShowCountInsertedUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("1ca281f4-dd21-41a7-87f6-80880676059f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("96704c6b-79dc-4748-9a66-3a34baf79c98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("6636b3af-d108-49d9-bf7e-0f7921d24846"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteYesStartMessage;
		public ProcessFlowElement DeleteYesStartMessage {
			get {
				return _deleteYesStartMessage ?? (_deleteYesStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteYesStartMessage",
					SchemaElementUId = new Guid("74419547-792c-4f1e-a891-3d703115f678"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteScriptTask;
		public ProcessScriptTask DeleteScriptTask {
			get {
				return _deleteScriptTask ?? (_deleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteScriptTask",
					SchemaElementUId = new Guid("f4897316-a422-420e-893d-b22fe64b6b4e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("33033377-04ba-40de-9864-b89a9fc4f388"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _countInsertedMessage;
		public LocalizableString CountInsertedMessage {
			get {
				return _countInsertedMessage ?? (_countInsertedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CountInsertedMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[AddProductStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddProductStartMessage };
			FlowElements[AddProductPrepareLookupScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddProductPrepareLookupScriptTask };
			FlowElements[AddFolderStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddFolderStartMessage };
			FlowElements[AddProductFolderPrepareLookupScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddProductFolderPrepareLookupScriptTask };
			FlowElements[OpenLookUpPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookUpPageUserTask };
			FlowElements[IntermediateCatchMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent1 };
			FlowElements[LookupGridPageClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosedScriptTask };
			FlowElements[ShowCountInsertedUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowCountInsertedUserTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[DeleteYesStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesStartMessage };
			FlowElements[DeleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "AddProductStartMessage":
						e.Context.QueueTasks.Enqueue("AddProductPrepareLookupScriptTask");
						break;
					case "AddProductPrepareLookupScriptTask":
						e.Context.QueueTasks.Enqueue("OpenLookUpPageUserTask");
						break;
					case "AddFolderStartMessage":
						e.Context.QueueTasks.Enqueue("AddProductFolderPrepareLookupScriptTask");
						break;
					case "AddProductFolderPrepareLookupScriptTask":
						e.Context.QueueTasks.Enqueue("OpenLookUpPageUserTask");
						break;
					case "OpenLookUpPageUserTask":
						ActivatedEventElements.Add("IntermediateCatchMessageEvent1");
						break;
					case "IntermediateCatchMessageEvent1":
						e.Context.QueueTasks.Enqueue("LookupGridPageClosedScriptTask");
						break;
					case "LookupGridPageClosedScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ShowCountInsertedUserTask":
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ShowCountInsertedUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
					case "Terminate1":
						break;
					case "EventSubProcess8":
						break;
					case "DeleteYesStartMessage":
						e.Context.QueueTasks.Enqueue("DeleteScriptTask");
						break;
					case "DeleteScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(CountInserting > 0);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AddProductStartMessage");
			ActivatedEventElements.Add("AddFolderStartMessage");
			ActivatedEventElements.Add("DeleteYesStartMessage");
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
				case "AddProductStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddProductStartMessage";
					result = AddProductStartMessage.Execute(context);
					break;
				case "AddProductPrepareLookupScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddProductPrepareLookupScriptTask";
					result = AddProductPrepareLookupScriptTask.Execute(context, AddProductPrepareLookupScriptTaskExecute);
					break;
				case "AddFolderStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddFolderStartMessage";
					result = AddFolderStartMessage.Execute(context);
					break;
				case "AddProductFolderPrepareLookupScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddProductFolderPrepareLookupScriptTask";
					result = AddProductFolderPrepareLookupScriptTask.Execute(context, AddProductFolderPrepareLookupScriptTaskExecute);
					break;
				case "OpenLookUpPageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookUpPageUserTask";
					result = OpenLookUpPageUserTask.Execute(context);
					break;
				case "IntermediateCatchMessageEvent1":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent1";
					result = IntermediateCatchMessageEvent1.Execute(context);
					break;
				case "LookupGridPageClosedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageClosedScriptTask";
					result = LookupGridPageClosedScriptTask.Execute(context, LookupGridPageClosedScriptTaskExecute);
					break;
				case "ShowCountInsertedUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowCountInsertedUserTask";
					result = ShowCountInsertedUserTask.Execute(context);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteYesStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesStartMessage";
					result = DeleteYesStartMessage.Execute(context);
					break;
				case "DeleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteScriptTask";
					result = DeleteScriptTask.Execute(context, DeleteScriptTaskExecute);
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
				case "CountInserted":
					CountInserted = reader.GetValue<System.Int32>();
				break;
				case "CountInserting":
					CountInserting = reader.GetValue<System.Int32>();
				break;
				case "RecordType":
					RecordType = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool AddProductPrepareLookupScriptTaskExecute(ProcessExecutingContext context) {
			InitOpenLookUpPageUserTask("Product", context);
			return true;
		}

		public virtual bool AddProductFolderPrepareLookupScriptTaskExecute(ProcessExecutingContext context) {
			InitOpenLookUpPageUserTask("ProductFolder", context);
			return true;
		}

		public virtual bool LookupGridPageClosedScriptTaskExecute(ProcessExecutingContext context) {
			var selectedValues = (Dictionary <string, object>)OpenLookUpPageUserTask.GetSelectedValues(UserConnection);
			CountInserting = selectedValues.Count;
			CountInserted = 0;
			if (CountInserting == 0) {
				return true;
			}
			CountInserting = selectedValues.Count;
			var existingEntities = GetExistingEntities();
			foreach (var selectedValue in selectedValues) {
				AddEntityToTarget(new Guid(selectedValue.Key), existingEntities);
			}
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
			if (CountInserting > 0) {
				ShowCountInsertedUserTask.Page = Page;
				ShowCountInsertedUserTask.MessageText = string.Format(CountInsertedMessage, CountInserted, CountInserting);
				ShowCountInsertedUserTask.Icon = "INFORMATION";
				ShowCountInsertedUserTask.Buttons = "OK";
			}
			return true;
		}

		public virtual bool DeleteScriptTaskExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count == 0) {
				return true;
			}
			foreach (var node in selectedNodes) {
				var productInLeadTypeId = node.Values.ContainsKey("Id") ? new Guid(node.Values["Id"].ToString()) : Guid.Empty;
				if (productInLeadTypeId == Guid.Empty) {
					continue;
				}
				var schema = UserConnection.EntitySchemaManager.GetInstanceByName("ProductInLeadType");
				var entity = schema.CreateEntity(UserConnection);
				if (entity.FetchFromDB(productInLeadTypeId)) {	
					entity.Delete();
				}
			}
			Page.TreeGrid.RefreshData();
			return true;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public virtual void InitOpenLookUpPageUserTask(string schemaName, ProcessExecutingContext context) {
			RecordType = schemaName;
			OpenLookUpPageUserTask.ProcessKey = context.Process.InstanceUId;
			OpenLookUpPageUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenLookUpPageUserTask.PageParameters;
			pageParameters.Add("schemaName", schemaName);
			pageParameters.Add("editMode", false);
			pageParameters.Add("multiSelectMode", true);
			pageParameters.Add("customClosedEvent", "LookupGridPageClosed");
			if (schemaName != "ProductFolder") {
				return;
			}
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>(); 
			filters.Add(new Dictionary<string, object> { 
			    {"comparisonType", FilterComparisonType.NotEqual},
			    {"leftExpressionColumnPath", "FolderType"},
			    {"useDisplayValue", false},
			    {"rightExpressionParameterValues", new object[] {
					TSConfiguration.LeadConsts.FolderTypeRecentUId
				}}
			});
			pageParameters.Add("LookupFilters", filters);
		}

		public virtual EntityCollection GetExistingEntities() {
			EntitySchemaManager schemaManager = UserConnection.EntitySchemaManager;
			EntitySchemaQuery productInLeadType = new EntitySchemaQuery(schemaManager, "ProductInLeadType");
			productInLeadType.AddColumn("Id");
			productInLeadType.AddColumn("Product");
			productInLeadType.AddColumn("ProductFolder");
			productInLeadType.Filters
				.Add(productInLeadType.CreateFilterWithParameters(FilterComparisonType.Equal, "LeadType", SelectedNodePrimaryColumnValue));
			var entities = productInLeadType.GetEntityCollection(UserConnection);
			return entities;
		}

		public virtual void AddEntityToTarget(Guid id, EntityCollection existingEntities) {
			var idColumn = string.Format("{0}Id", RecordType);
			if (existingEntities.Find(idColumn, id) != null) {
				return;
			}
			if (id == TSConfiguration.LeadConsts.ProductFolderAllProductsUId) {
				return;
			}
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchema productInLeadType = entitySchemaManager.GetInstanceByName("ProductInLeadType");
			Entity productInLeadTypeEntity = productInLeadType.CreateEntity(Page.UserConnection);
			productInLeadTypeEntity.SetDefColumnValues();
			productInLeadTypeEntity.SetColumnValue("Id", Guid.NewGuid());
			productInLeadTypeEntity.SetColumnValue("LeadTypeId", SelectedNodePrimaryColumnValue);
			productInLeadTypeEntity.SetColumnValue(idColumn, id);
			productInLeadTypeEntity.Save();
			CountInserted++;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AddProductClick":
							if (ActivatedEventElements.Contains("AddProductStartMessage")) {
							context.QueueTasks.Enqueue("AddProductStartMessage");
						}
						break;
					case "AddFolderClick":
							if (ActivatedEventElements.Contains("AddFolderStartMessage")) {
							context.QueueTasks.Enqueue("AddFolderStartMessage");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent1")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent1");
					}
					break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesStartMessage")) {
							context.QueueTasks.Enqueue("DeleteYesStartMessage");
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
			if (!HasMapping("CountInserted") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CountInserted", CountInserted, 0);
			}
			if (!HasMapping("CountInserting") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CountInserting", CountInserting, 0);
			}
			if (!HasMapping("RecordType") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RecordType", RecordType, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ProductInLeadTypeEditPageEventsProcess

	/// <exclude/>
	public class ProductInLeadTypeEditPageEventsProcess : ProductInLeadTypeEditPageEventsProcess<Terrasoft.WebApp.ProductInLeadTypeEditPageSchemaUserControl>
	{

		public ProductInLeadTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductInLeadTypeEditPageSchemaUserControl

	/// <exclude/>
	public partial class ProductInLeadTypeEditPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MenuItem AddProduct {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddProduct", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AddFolder {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddFolder", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddProduct.AjaxEvents.Click.Event += AddProductClick;
			AddFolder.AjaxEvents.Click.Event += AddFolderClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddProduct.AjaxEvents.Click.Event -= AddProductClick;
			AddFolder.AjaxEvents.Click.Event -= AddFolderClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ProductInLeadTypeEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProductInLeadTypeEditPageEventsProcess(UserConnection);
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

		public virtual void AddProductClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddProductClick");
		}

		public virtual void AddFolderClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddFolderClick");
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
			SchemaName = "ProductInLeadTypeEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProductInLeadTypeEditPageEventsProcessSchema

	/// <exclude/>
	public class ProductInLeadTypeEditPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProductInLeadTypeEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductInLeadTypeEditPageEventsProcessSchema(ProductInLeadTypeEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductInLeadTypeEditPageEventsProcess";
			UId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
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

		protected virtual ProcessSchemaParameter CreateRecordTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8044c7a0-1951-4e8e-b4a4-82fc3461ddda"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"RecordType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCountInsertingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("46f178fc-505c-48cb-b732-bbab001aa3b3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"CountInserting",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCountInsertedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4ff039df-bceb-45c3-b85b-3cb8ba5c719a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"CountInserted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateRecordTypeParameter());
			Parameters.Add(CreateCountInsertingParameter());
			Parameters.Add(CreateCountInsertedParameter());
		}

		protected virtual void InitializeOpenLookUpPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("152985c1-eec8-422d-bdb1-bdae9a91cc9a"),
				ContainerUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
				UId = new Guid("c1f842b4-f112-4373-ad09-db129089ca31"),
				ContainerUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("87ffa893-7b93-4a7b-ae10-68368c4ccbc1"),
				ContainerUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("20538e88-7a4e-46df-9779-86c66d6e654a"),
				ContainerUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeShowCountInsertedUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b16ae10a-fb04-4d42-bc2f-a28f8de12ec6"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bf942cd1-8f3d-434e-8d46-e5d27d97a1a2"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
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
				UId = new Guid("b1388517-84cc-4108-b322-7296bb717f48"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
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
				UId = new Guid("aa3a98d2-2541-4671-9f5c-7932d8720501"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
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
				UId = new Guid("70ee3d7a-04bb-4d52-a8ce-f31f60b5ee11"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4d44db39-5d0c-4267-9d14-95ce903a6275"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
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
				UId = new Guid("b9103534-44fd-4fb8-844f-c267b6a16022"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
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
				UId = new Guid("d29bf148-fb78-4729-86c2-a76cbb9b2da6"),
				ContainerUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
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
					Value = @"",
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaStartMessageEvent addproductstartmessage = CreateAddProductStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(addproductstartmessage);
			ProcessSchemaScriptTask addproductpreparelookupscripttask = CreateAddProductPrepareLookupScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(addproductpreparelookupscripttask);
			ProcessSchemaStartMessageEvent addfolderstartmessage = CreateAddFolderStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(addfolderstartmessage);
			ProcessSchemaScriptTask addproductfolderpreparelookupscripttask = CreateAddProductFolderPrepareLookupScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(addproductfolderpreparelookupscripttask);
			ProcessSchemaUserTask openlookuppageusertask = CreateOpenLookUpPageUserTaskUserTask();
			eventsubprocess1.FlowElements.Add(openlookuppageusertask);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent1 = CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatecatchmessageevent1);
			ProcessSchemaScriptTask lookupgridpageclosedscripttask = CreateLookupGridPageClosedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(lookupgridpageclosedscripttask);
			ProcessSchemaUserTask showcountinsertedusertask = CreateShowCountInsertedUserTaskUserTask();
			eventsubprocess1.FlowElements.Add(showcountinsertedusertask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess1.FlowElements.Add(exclusivegateway3);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			eventsubprocess1.FlowElements.Add(terminate1);
			ProcessSchemaStartMessageEvent deleteyesstartmessage = CreateDeleteYesStartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(deleteyesstartmessage);
			ProcessSchemaScriptTask deletescripttask = CreateDeleteScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(deletescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCountInsertedMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCountInsertedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ee8255ed-33be-4c59-9682-3f8dfe651b6a"),
				Name = "CountInsertedMessage",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("07bd171f-0c1e-46f5-b692-f870f7a64e81"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("08c85838-be78-41e9-bb98-b6f23f23d009"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b52d52f1-2d1f-49cb-b54a-2bfc0763f892"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8b95c375-1b63-40ef-82eb-3e6018417cb1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fa671b8c-e9fe-4a70-9bf0-5f7d7da696c5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("268bfdec-5708-4d44-b0ee-81eb96eda0b2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f3cbce4c-9287-400c-b29b-b8c173620692"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(468, 263),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b52d52f1-2d1f-49cb-b54a-2bfc0763f892"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c4821c4d-1f42-4c92-b402-46c28e2483c8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(470, 342),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("268bfdec-5708-4d44-b0ee-81eb96eda0b2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("8950bf28-4b74-4ee9-8da4-730977d60b5b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(560, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9eea79f-e144-4c8d-b23b-3e4c559c198e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("35454c39-33be-4dab-8f71-b5688016d531"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(688, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9eea79f-e144-4c8d-b23b-3e4c559c198e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("417696e0-faa8-415c-9f75-7d677079f0a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("0ed6f975-9c4f-45c1-bb9e-b3161b4244b0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(726, 133),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("417696e0-faa8-415c-9f75-7d677079f0a1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ca281f4-dd21-41a7-87f6-80880676059f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("9c9a374b-532e-4e51-8d64-d7ba96f5d8bb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(184, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("74419547-792c-4f1e-a891-3d703115f678"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4897316-a422-420e-893d-b22fe64b6b4e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("33033377-04ba-40de-9864-b89a9fc4f388"),
				ConditionExpression = @"CountInserting > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(852, 172),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ca281f4-dd21-41a7-87f6-80880676059f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow9",
				UId = new Guid("bb8ca478-b9a2-45f0-990a-e0080173b3b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CurveCenterPosition = new Point(858, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ca281f4-dd21-41a7-87f6-80880676059f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96704c6b-79dc-4748-9a66-3a34baf79c98"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6ba2ab69-02bb-4401-9246-8ecf2488fe45"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1188, 469),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("9de8e107-7ecf-4b8a-8680-08233a62508e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6ba2ab69-02bb-4401-9246-8ecf2488fe45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1159, 469),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9de8e107-7ecf-4b8a-8680-08233a62508e"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1039, 270),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddProductStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("08c85838-be78-41e9-bb98-b6f23f23d009"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddProductClick",
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"AddProductStartMessage",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddProductPrepareLookupScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b52d52f1-2d1f-49cb-b54a-2bfc0763f892"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"AddProductPrepareLookupScriptTask",
				Position = new Point(134, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,241,47,72,205,243,201,207,207,14,45,8,72,76,79,13,45,78,45,10,73,44,206,214,80,10,40,202,79,41,77,46,81,210,81,72,206,207,43,73,173,40,209,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,196,218,17,197,61,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddFolderStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fa671b8c-e9fe-4a70-9bf0-5f7d7da696c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddFolderClick",
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"AddFolderStartMessage",
				Position = new Point(50, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddProductFolderPrepareLookupScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("268bfdec-5708-4d44-b0ee-81eb96eda0b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"AddProductFolderPrepareLookupScriptTask",
				Position = new Point(134, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,241,47,72,205,243,201,207,207,14,45,8,72,76,79,13,45,78,45,10,73,44,206,214,80,10,40,202,79,41,77,46,113,203,207,73,73,45,82,210,81,72,206,207,43,73,173,40,209,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,182,64,147,237,67,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookUpPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("53a433b6-2016-4779-9d1c-026b6236aa11"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"OpenLookUpPageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 93),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookUpPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("f9eea79f-e144-4c8d-b23b-3e4c559c198e"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"IntermediateCatchMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLookupGridPageClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("417696e0-faa8-415c-9f75-7d677079f0a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"LookupGridPageClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(533, 93),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,78,195,48,16,60,83,169,255,96,229,228,72,81,196,189,80,169,244,165,168,143,160,54,229,110,146,109,107,90,188,149,189,233,67,136,127,199,78,0,225,128,42,78,150,103,103,103,118,199,62,10,205,12,236,33,39,40,158,196,190,4,195,238,25,31,200,156,36,42,161,47,236,206,144,150,106,19,49,124,126,177,172,110,152,30,64,77,17,119,171,195,163,216,192,202,128,206,132,217,197,99,160,165,167,195,93,169,143,74,65,165,21,118,218,173,62,150,138,18,101,113,178,146,214,200,119,142,171,186,207,131,194,210,110,45,38,215,140,55,251,109,37,100,111,237,214,141,6,42,181,98,164,75,176,212,247,255,59,29,237,250,112,150,198,177,134,138,36,201,42,0,187,204,176,129,114,183,192,26,53,136,124,203,248,177,25,27,147,170,225,81,79,214,43,138,74,225,146,97,38,244,6,136,43,56,177,113,41,11,238,209,227,9,92,194,232,215,44,97,189,142,75,58,206,52,192,88,203,34,238,239,65,232,106,158,10,31,8,18,75,44,117,14,241,20,69,177,192,83,61,236,31,137,117,191,2,91,110,241,228,165,252,253,142,78,210,38,224,142,206,85,226,12,140,177,164,12,206,228,242,173,126,73,60,66,253,42,136,123,29,159,196,136,121,168,119,181,173,225,117,183,36,71,101,109,130,100,62,74,23,179,94,150,164,243,224,122,199,67,73,132,202,189,102,144,78,130,58,199,159,255,228,3,112,131,113,242,250,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowCountInsertedUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9de298ad-05c8-49b6-8577-f82b9c5bf5f4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"ShowCountInsertedUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(827, 142),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowCountInsertedUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("1ca281f4-dd21-41a7-87f6-80880676059f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(694, 93),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("96704c6b-79dc-4748-9a66-3a34baf79c98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df2af413-f2ef-48c9-8a89-23cedd560f01"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"Terminate1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(841, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6636b3af-d108-49d9-bf7e-0f7921d24846"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9de8e107-7ecf-4b8a-8680-08233a62508e"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 287),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1043, 168),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("74419547-792c-4f1e-a891-3d703115f678"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6636b3af-d108-49d9-bf7e-0f7921d24846"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"DeleteYesStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f4897316-a422-420e-893d-b22fe64b6b4e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6636b3af-d108-49d9-bf7e-0f7921d24846"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Name = @"DeleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,75,107,195,48,16,132,207,14,228,63,8,159,164,139,232,185,193,20,242,36,180,13,161,73,123,41,61,8,105,19,11,226,85,144,228,20,19,242,223,187,126,20,236,16,208,109,103,246,155,89,93,148,103,1,78,160,35,152,141,51,16,88,198,182,234,8,114,239,1,86,222,26,185,235,79,39,227,145,61,48,62,112,200,153,43,49,178,44,99,79,130,93,199,163,196,67,44,61,178,232,75,32,253,109,60,58,56,15,74,231,140,95,136,134,228,97,22,135,212,214,88,143,207,222,153,82,199,53,190,129,50,251,234,12,107,67,145,106,147,252,82,167,178,193,97,84,22,195,43,84,60,93,155,84,176,23,134,240,203,86,165,53,188,39,252,174,135,63,114,239,118,209,91,60,114,33,216,115,35,146,139,226,28,43,138,150,212,93,30,2,179,158,176,205,150,104,194,90,108,42,37,183,46,108,208,57,20,138,242,125,6,240,148,11,169,145,117,40,23,36,141,213,174,153,190,43,164,123,122,185,2,98,132,168,80,195,180,218,168,2,120,186,189,71,167,98,210,109,134,102,3,109,110,17,114,70,23,140,208,238,229,67,154,248,111,210,122,228,18,162,206,151,222,21,243,233,163,114,116,134,107,82,23,234,228,115,250,135,8,92,116,189,232,13,255,255,3,14,30,66,62,87,81,53,162,254,239,254,1,220,70,233,156,62,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitOpenLookUpPageUserTaskMethod());
			Methods.Add(CreateGetExistingEntitiesMethod());
			Methods.Add(CreateAddEntityToTargetMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e166c122-42fa-4f50-991f-89f6d5e40e3c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitOpenLookUpPageUserTaskMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6363e733-72d0-40b2-beb9-763a92214a31"),
				Name = "InitOpenLookUpPageUserTask",
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f41be613-8595-4724-b4fa-980bee6c874e"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d04f5ffa-34e9-4391-8290-416d13cc1908"),
				Name = "context",
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,93,79,227,48,16,124,166,82,255,131,47,79,141,84,229,15,240,33,157,74,65,232,56,174,130,150,23,196,131,177,55,173,193,177,115,222,53,71,85,245,191,223,58,105,73,91,169,136,188,197,153,153,221,153,113,238,65,249,160,167,203,26,196,185,64,181,128,74,222,201,10,78,251,189,63,53,184,91,239,223,102,245,68,206,97,134,16,166,18,223,138,73,240,10,16,127,193,146,9,202,59,130,15,218,30,22,55,14,73,58,5,179,27,253,133,2,191,76,100,224,41,4,1,89,197,193,63,113,105,20,25,239,100,88,138,51,164,96,220,124,40,252,203,43,40,186,24,228,172,245,46,131,168,15,137,131,47,88,249,183,166,179,242,190,106,241,83,235,65,214,5,145,13,119,82,201,143,192,65,27,250,237,117,2,151,210,226,81,92,21,45,153,7,176,188,223,6,78,33,30,69,171,136,228,171,145,245,8,122,252,14,142,24,159,37,71,177,190,14,70,39,35,237,199,44,41,152,82,12,186,77,197,143,115,145,113,43,58,42,186,242,86,67,200,114,177,234,247,78,2,80,12,142,241,235,126,111,228,109,90,133,3,60,235,130,60,204,241,66,148,198,238,20,245,61,18,119,38,250,189,13,179,177,179,95,242,33,65,172,24,46,248,89,101,202,87,181,12,6,189,75,183,146,61,95,53,42,163,189,227,226,206,211,248,111,148,118,61,220,242,44,148,52,254,168,3,223,67,158,193,107,198,202,77,36,45,82,106,109,4,141,94,71,136,8,151,6,107,43,151,143,210,198,207,242,58,64,48,243,197,142,228,103,63,13,28,25,159,60,181,6,158,158,155,116,79,166,15,35,239,74,51,143,65,38,167,197,45,72,205,39,72,88,116,59,220,131,226,54,249,31,97,198,154,123,88,31,187,1,109,217,173,255,52,111,147,103,126,250,31,114,192,226,55,182,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExistingEntitiesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85330c55-4ac4-4ee5-9b83-cbe9aed38cf1"),
				Name = "GetExistingEntities",
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				ResultValueTypeName = "EntityCollection"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,205,106,195,48,16,132,207,13,228,29,132,79,10,132,188,64,232,161,24,167,4,218,224,146,254,156,23,107,104,4,210,202,89,75,45,126,251,202,117,9,117,77,105,143,187,124,51,187,59,91,113,180,177,63,54,39,120,186,39,166,87,136,234,38,213,181,122,234,32,101,96,70,19,109,224,77,53,151,108,151,139,239,221,135,4,233,85,43,193,164,38,238,249,14,100,30,251,22,217,138,241,174,102,164,158,12,92,171,162,254,169,44,86,121,194,204,111,115,99,76,25,92,242,172,139,189,249,155,249,178,253,55,184,11,206,64,126,193,119,214,69,72,183,92,92,13,74,61,7,74,1,69,140,216,139,141,167,154,132,60,6,141,30,155,101,240,45,137,237,2,127,242,213,57,145,203,199,95,110,94,171,35,92,206,28,230,16,12,106,177,158,164,31,87,124,38,151,176,26,22,123,35,81,24,2,181,232,114,190,243,53,110,17,199,192,179,210,141,31,212,211,135,14,54,130,152,132,47,78,219,15,134,155,231,199,23,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddEntityToTargetMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f672da49-bfd8-4513-b5f0-d43b1439a498"),
				Name = "AddEntityToTarget",
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d82ab9b4-7dae-47c3-8a2c-8dc9ecb7c815"),
				Name = "id",
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cdbfb7af-f9cc-4649-a77c-01efde0c188b"),
				Name = "existingEntities",
				CreatedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				ModifiedInSchemaUId = new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,81,107,194,48,20,133,159,39,248,31,178,62,165,40,97,239,210,135,173,83,41,108,82,86,221,123,104,174,46,144,38,114,147,184,21,241,191,47,173,58,212,186,13,159,66,114,207,253,206,61,73,54,28,137,20,169,81,190,210,36,33,214,161,212,43,54,49,88,113,71,163,237,195,46,19,209,144,188,65,105,80,204,235,53,196,163,126,79,46,9,133,47,105,93,144,142,181,147,78,130,101,19,169,5,61,146,134,129,25,147,251,132,104,175,84,76,182,253,222,29,130,243,168,67,247,110,15,144,130,36,9,153,23,169,209,75,185,242,200,157,52,154,189,0,15,8,109,157,101,57,26,225,75,55,49,74,0,62,42,117,216,219,69,38,186,196,77,136,1,205,40,117,81,126,64,197,95,185,230,43,192,144,104,97,1,3,81,67,217,26,76,193,157,41,104,52,238,182,69,49,225,150,92,41,4,179,211,83,178,222,207,148,233,102,238,230,122,130,225,149,49,26,215,44,132,226,186,132,167,122,198,43,160,81,126,217,26,197,63,244,46,247,112,158,116,43,44,69,224,238,32,160,121,176,99,231,145,27,236,47,60,86,128,123,134,229,254,205,222,185,242,96,233,63,242,19,45,141,218,191,49,245,82,176,25,124,54,43,141,111,105,63,150,91,76,1,42,204,11,98,102,4,228,40,43,142,245,137,248,6,236,217,31,252,171,141,111,160,77,155,26,175,155,231,1,12,246,131,193,232,27,21,191,178,195,19,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductInLeadTypeEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e9cc1bb-c3d6-4c78-acae-eb05ac8b0c4c"));
		}

		#endregion

	}

	#endregion

}

