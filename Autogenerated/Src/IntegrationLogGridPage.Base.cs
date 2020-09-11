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

	#region Class: IntegrationLogGridPageSchema

	/// <exclude/>
	public class IntegrationLogGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MenuItem _clearIntegrationLogMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem ClearIntegrationLogMenuItem {
			get {
				return _clearIntegrationLogMenuItem;
			}
		}

		#endregion

		#region Constructors: Public

		public IntegrationLogGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public IntegrationLogGridPageSchema(IntegrationLogGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
			RealUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
			Name = "IntegrationLogGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateIntegrationLogGridPageEventsProcessSchema();
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
			DeleteButton.InsertItem(0, CreateClearIntegrationLogMenuItem());
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

		protected virtual EmbeddedProcessSchema CreateIntegrationLogGridPageEventsProcessSchema() {
			var schema = new IntegrationLogGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateClearIntegrationLogMenuItem() {
			_clearIntegrationLogMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_clearIntegrationLogMenuItem.UId = new Guid("d20998a0-ea11-4454-85f2-2871a80d064b");
			_clearIntegrationLogMenuItem.Name = "ClearIntegrationLogMenuItem";
			_clearIntegrationLogMenuItem.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
			_clearIntegrationLogMenuItem.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
			_clearIntegrationLogMenuItem.CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			_clearIntegrationLogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_clearIntegrationLogMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_clearIntegrationLogMenuItem.Image = new ControlImage {};
			_clearIntegrationLogMenuItem.Tag = "";
			return _clearIntegrationLogMenuItem;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086");
			DataSource.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("738dac02-1b9f-41b1-8c47-d9cebf995432");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("fbe4e2dc-98fe-4cf6-9b96-ae95ba27bab2");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("74d8911c-5359-4833-a748-2f82e757852e");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("6071fc05-3bbc-4942-8cba-54d7921275ef");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("e03415ab-c095-40cc-afc2-6b651c4a33ad");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("0ce6b459-7719-4cc4-96ff-9f8730da3826");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cc2ebf21-ef2d-4ef3-80da-6345649c70c9");
			if (column != null) {
				column.UId = new Guid("25fae6bd-8b75-400f-a604-a7ba9c3d1d82");
				column.Name = @"IntegrationSystem";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0712b7db-3846-47e5-b735-6fc5d962f759");
			if (column != null) {
				column.UId = new Guid("0d59507a-4849-427d-9ae2-2ea0c2a7afe4");
				column.Name = @"SessionNumber";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Descending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0c2b0beb-339d-4e42-bba6-3f06267b831b");
			if (column != null) {
				column.UId = new Guid("2dffb19e-bd31-4032-8ef4-6590d9cea4b4");
				column.Name = @"Date";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 2;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4f45a347-95cf-4c1b-be43-be69fc62806d");
			if (column != null) {
				column.UId = new Guid("2c6dc24f-d21e-4b6f-8f1f-7b760953cd2e");
				column.Name = @"Direction";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("384024d7-330a-4487-90e8-a8bbaf58bb49");
			if (column != null) {
				column.UId = new Guid("433549a4-c288-4c0b-a0de-9d2da1322749");
				column.Name = @"Operation";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("40ad9faa-f737-4828-83d4-90c845b435a5");
			if (column != null) {
				column.UId = new Guid("94f8224d-1b90-4134-aaa0-fe98272c6bc9");
				column.Name = @"Result";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e272fb1a-d751-4cbe-b633-f24086f64cf2");
			if (column != null) {
				column.UId = new Guid("f79679d0-1f32-4490-b5ca-6ae7cfe1728d");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("98bfc088-c17b-4fdd-bafd-fa59253b2c66");
			if (column != null) {
				column.UId = new Guid("d8735496-98c9-4650-be5f-9b1fc1034f2c");
				column.Name = @"ErrorDescription";
				column.CreatedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
				column.ModifiedInSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
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
			return new IntegrationLogGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new IntegrationLogGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new IntegrationLogGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLogGridPageEventsProcess

	/// <exclude/>
	public class IntegrationLogGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.IntegrationLogGridPageSchemaUserControl
	{

		public IntegrationLogGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IntegrationLogGridPageEventsProcess";
			SchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
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

		private Guid _integrationLogEditPageUId = new Guid("2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc");
		public Guid IntegrationLogEditPageUId {
			get {
				return _integrationLogEditPageUId;
			}
			set {
				_integrationLogEditPageUId = value;
			}
		}

		public virtual Guid OneCIntegrationSystemId {
			get;
			set;
		}

		private ProcessFlowElement _childPageLoadCompleteEventSubProcess;
		public ProcessFlowElement ChildPageLoadCompleteEventSubProcess {
			get {
				return _childPageLoadCompleteEventSubProcess ?? (_childPageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ChildPageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("65df8bca-e411-4ee1-95e0-ddc36c919dac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childPageLoadComplete;
		public ProcessFlowElement ChildPageLoadComplete {
			get {
				return _childPageLoadComplete ?? (_childPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildPageLoadComplete",
					SchemaElementUId = new Guid("a928df4c-aeab-41ac-8a5c-56eae9f1e21d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _parentPageLoadComplete;
		public ProcessThrowMessageEvent ParentPageLoadComplete {
			get {
				return _parentPageLoadComplete ?? (_parentPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ParentPageLoadComplete",
					SchemaElementUId = new Guid("573b2302-568a-48b7-aecc-82a470f51d14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _fillTreeGridScriptTask;
		public ProcessScriptTask FillTreeGridScriptTask {
			get {
				return _fillTreeGridScriptTask ?? (_fillTreeGridScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FillTreeGridScriptTask",
					SchemaElementUId = new Guid("99b2de21-5e03-4740-801a-0e748914b637"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FillTreeGridScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("db42c333-1cfc-43a3-99c8-0d113eb85d03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _clearIntegrationLogMenuItemClick;
		public ProcessFlowElement ClearIntegrationLogMenuItemClick {
			get {
				return _clearIntegrationLogMenuItemClick ?? (_clearIntegrationLogMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ClearIntegrationLogMenuItemClick",
					SchemaElementUId = new Guid("19e11df7-9544-46ed-b15c-0d6e9aeed9b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _clearIntegrationLogScriptTask;
		public ProcessScriptTask ClearIntegrationLogScriptTask {
			get {
				return _clearIntegrationLogScriptTask ?? (_clearIntegrationLogScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearIntegrationLogScriptTask",
					SchemaElementUId = new Guid("7719e966-61d7-43f9-a0c9-6ba76d5b7cf8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClearIntegrationLogScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ChildPageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadCompleteEventSubProcess };
			FlowElements[ChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadComplete };
			FlowElements[ParentPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ParentPageLoadComplete };
			FlowElements[FillTreeGridScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillTreeGridScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ClearIntegrationLogMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearIntegrationLogMenuItemClick };
			FlowElements[ClearIntegrationLogScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearIntegrationLogScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ChildPageLoadCompleteEventSubProcess":
						break;
					case "ChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("FillTreeGridScriptTask");
						break;
					case "ParentPageLoadComplete":
						break;
					case "FillTreeGridScriptTask":
						e.Context.QueueTasks.Enqueue("ParentPageLoadComplete");
						break;
					case "EventSubProcess1":
						break;
					case "ClearIntegrationLogMenuItemClick":
						e.Context.QueueTasks.Enqueue("ClearIntegrationLogScriptTask");
						break;
					case "ClearIntegrationLogScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildPageLoadComplete");
			ActivatedEventElements.Add("ClearIntegrationLogMenuItemClick");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ChildPageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadComplete";
					result = ChildPageLoadComplete.Execute(context);
					break;
				case "ParentPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ParentPageLoadComplete.Execute(context);
					break;
				case "FillTreeGridScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FillTreeGridScriptTask";
					result = FillTreeGridScriptTask.Execute(context, FillTreeGridScriptTaskExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ClearIntegrationLogMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearIntegrationLogMenuItemClick";
					result = ClearIntegrationLogMenuItemClick.Execute(context);
					break;
				case "ClearIntegrationLogScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearIntegrationLogScriptTask";
					result = ClearIntegrationLogScriptTask.Execute(context, ClearIntegrationLogScriptTaskExecute);
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
				case "OneCIntegrationSystemId":
					OneCIntegrationSystemId = reader.GetValue<System.Guid>();
				break;
				case "IntegrationLogEditPageUId":
					IntegrationLogEditPageUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool FillTreeGridScriptTaskExecute(ProcessExecutingContext context) {
			string integrationSystemId = (string)Page.GetParameterValue("integrationSystemId");
			if (!string.IsNullOrEmpty(integrationSystemId)) {
				OneCIntegrationSystemId = new Guid(integrationSystemId);
				var currentStructure = Page.DataSource.CurrentStructure;
				var filterGroup = currentStructure.CreateFiltersGroup("OneCIntegrationSystem", LogicalOperationStrict.And);
				var filter = currentStructure.CreateFilterWithParameters(Page.DataSource.Schema, FilterComparisonType.Equal, "IntegrationSystem", OneCIntegrationSystemId);
				filterGroup.Add(filter);
				currentStructure.Filters.Add(filterGroup);
			}
			Page.DataSource.LoadRows();
			EditPageUId = IntegrationLogEditPageUId;
			return true;
		}

		public virtual bool ClearIntegrationLogScriptTaskExecute(ProcessExecutingContext context) {
			try {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
				var delete = new Delete(UserConnection)
					.From(Page.DataSource.Schema.Name);
				delete.Execute();
				Page.ScriptManager.AddScript(Page.TreeGrid.ClientID + ".refreshData();");
			} catch(Exception ex) {
				Page.ScriptManager.AddScript(GetWarningMessageBoxScript(ex.Message));
			}
			return true;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			Page.AddScript(string.Format("{0}.setEnabled({1});", Page.AddButton.ClientID, Json.Serialize(false)));
			Page.AddButton.SetVisible(false);
			Page.AddScript(string.Format("{0}.setEnabled({1});", Page.CopyButton.ClientID, Json.Serialize(false)));
			Page.CopyButton.SetVisible(false);
		}

		public override string GetRegisterQuestionScript() {
			string operationCode = "CanManageAdministration";
			if(UserConnection.DBSecurityEngine.GetCanExecuteOperation(operationCode)) {
				return base.GetRegisterQuestionScript();
			}
			string errorMessage = string.Format(new LocalizableString("Terrasoft.Core",
								"DBSecurityEngine.Exception.CurrentUserCannotExecuteAdminOperation"), operationCode);
			return GetWarningMessageBoxScript(errorMessage);
		}

		public virtual string GetWarningMessageBoxScript(string message) {
			const string messageCallback = @" function() {{}} ";
			return Terrasoft.Configuration.ClientScriptUtilities.GetMessageScript(Warning, message,
				Terrasoft.Configuration.MessageBoxButtons.Ok, Terrasoft.Configuration.MessageBoxIcon.Warning,
				messageCallback);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("ChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("ChildPageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "ClearIntegrationLogMenuItemClick":
							if (ActivatedEventElements.Contains("ClearIntegrationLogMenuItemClick")) {
							context.QueueTasks.Enqueue("ClearIntegrationLogMenuItemClick");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("OneCIntegrationSystemId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OneCIntegrationSystemId", OneCIntegrationSystemId, Guid.Empty);
			}
			if (!HasMapping("IntegrationLogEditPageUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IntegrationLogEditPageUId", IntegrationLogEditPageUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLogGridPageEventsProcess

	/// <exclude/>
	public class IntegrationLogGridPageEventsProcess : IntegrationLogGridPageEventsProcess<Terrasoft.WebApp.IntegrationLogGridPageSchemaUserControl>
	{

		public IntegrationLogGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IntegrationLogGridPageSchemaUserControl

	/// <exclude/>
	public partial class IntegrationLogGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MenuItem ClearIntegrationLogMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ClearIntegrationLogMenuItem", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ClearIntegrationLogMenuItem.AjaxEvents.Click.Event += ClearIntegrationLogMenuItemClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ClearIntegrationLogMenuItem.AjaxEvents.Click.Event -= ClearIntegrationLogMenuItemClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (IntegrationLogGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new IntegrationLogGridPageEventsProcess(UserConnection);
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

		public virtual void ClearIntegrationLogMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("ClearIntegrationLogMenuItemClick");
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
			SchemaName = "IntegrationLogGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLogGridPageEventsProcessSchema

	/// <exclude/>
	public class IntegrationLogGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public IntegrationLogGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public IntegrationLogGridPageEventsProcessSchema(IntegrationLogGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IntegrationLogGridPageEventsProcess";
			UId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
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

		protected virtual ProcessSchemaParameter CreateIntegrationLogEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ac98de30-fa7a-4220-bc3f-3d9083e5f804"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"IntegrationLogEditPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"2b8a098a-23d0-4c3f-98e5-bf0fa597ffbc",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateOneCIntegrationSystemIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba16eea4-6e09-4cd4-9e78-3e080904a670"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"OneCIntegrationSystemId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIntegrationLogEditPageUIdParameter());
			Parameters.Add(CreateOneCIntegrationSystemIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess childpageloadcompleteeventsubprocess = CreateChildPageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(childpageloadcompleteeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent childpageloadcomplete = CreateChildPageLoadCompleteStartMessageEvent();
			childpageloadcompleteeventsubprocess.FlowElements.Add(childpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent parentpageloadcomplete = CreateParentPageLoadCompleteIntermediateThrowMessageEvent();
			childpageloadcompleteeventsubprocess.FlowElements.Add(parentpageloadcomplete);
			ProcessSchemaScriptTask filltreegridscripttask = CreateFillTreeGridScriptTaskScriptTask();
			childpageloadcompleteeventsubprocess.FlowElements.Add(filltreegridscripttask);
			ProcessSchemaStartMessageEvent clearintegrationlogmenuitemclick = CreateClearIntegrationLogMenuItemClickStartMessageEvent();
			eventsubprocess1.FlowElements.Add(clearintegrationlogmenuitemclick);
			ProcessSchemaScriptTask clearintegrationlogscripttask = CreateClearIntegrationLogScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(clearintegrationlogscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("63725845-91c2-4dda-8cdb-f41534ce313b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				CurveCenterPosition = new Point(170, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a928df4c-aeab-41ac-8a5c-56eae9f1e21d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("99b2de21-5e03-4740-801a-0e748914b637"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e0bb0603-fb53-4c8a-897e-ea77bc897998"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				CurveCenterPosition = new Point(310, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("99b2de21-5e03-4740-801a-0e748914b637"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("573b2302-568a-48b7-aecc-82a470f51d14"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("9ff20e59-906d-4714-8da5-bdb462ed54ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("19e11df7-9544-46ed-b15c-0d6e9aeed9b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7719e966-61d7-43f9-a0c9-6ba76d5b7cf8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("95dccca8-c591-4100-b926-0c4b35583f2a"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(760, 341),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("71b726c8-0f99-4eff-82da-7de4bc9661c8"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("95dccca8-c591-4100-b926-0c4b35583f2a"),
				CreatedInOwnerSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 164),
				Size = new Size(731, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("c2c87636-3f3a-47ac-8e17-7602f0422a98"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("95dccca8-c591-4100-b926-0c4b35583f2a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(731, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateChildPageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaChildPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("65df8bca-e411-4ee1-95e0-ddc36c919dac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71b726c8-0f99-4eff-82da-7de4bc9661c8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"ChildPageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(385, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaChildPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a928df4c-aeab-41ac-8a5c-56eae9f1e21d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65df8bca-e411-4ee1-95e0-ddc36c919dac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"ChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateParentPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("573b2302-568a-48b7-aecc-82a470f51d14"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65df8bca-e411-4ee1-95e0-ddc36c919dac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"ParentPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFillTreeGridScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("99b2de21-5e03-4740-801a-0e748914b637"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65df8bca-e411-4ee1-95e0-ddc36c919dac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"FillTreeGridScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,205,106,195,48,16,132,207,13,228,29,84,159,100,8,122,129,208,67,112,211,16,8,77,168,251,115,94,236,141,35,176,37,119,181,106,8,165,239,94,69,78,91,227,186,244,40,102,70,243,105,228,152,180,169,132,54,140,21,1,107,107,242,147,99,108,214,165,184,17,210,69,53,221,65,133,106,133,188,3,130,6,25,233,25,106,143,50,25,73,37,233,124,58,209,123,33,175,187,172,90,187,123,95,215,91,90,54,45,159,228,72,34,77,197,251,116,114,181,53,152,173,71,41,12,30,197,202,235,114,52,28,218,174,222,128,68,225,137,208,112,206,228,11,246,132,33,23,169,111,129,33,183,158,10,84,217,192,242,21,221,235,58,60,105,69,214,183,33,53,188,72,101,132,192,120,23,77,46,186,100,50,10,155,204,196,198,86,186,128,122,219,226,69,8,27,20,172,22,230,7,180,107,251,175,232,69,243,225,123,109,39,135,79,201,139,3,54,48,19,157,57,179,77,11,164,157,53,143,167,22,213,242,213,67,61,19,201,24,224,31,43,71,186,222,14,106,81,150,178,59,71,233,23,235,101,142,158,47,230,206,230,143,233,100,136,187,177,80,62,216,163,147,103,125,89,106,62,27,158,226,231,246,96,194,120,61,45,56,9,67,151,17,161,20,231,159,231,12,102,241,168,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("db42c333-1cfc-43a3-99c8-0d113eb85d03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c2c87636-3f3a-47ac-8e17-7602f0422a98"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(319, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateClearIntegrationLogMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("19e11df7-9544-46ed-b15c-0d6e9aeed9b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db42c333-1cfc-43a3-99c8-0d113eb85d03"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ClearIntegrationLogMenuItemClick",
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"ClearIntegrationLogMenuItemClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateClearIntegrationLogScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7719e966-61d7-43f9-a0c9-6ba76d5b7cf8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db42c333-1cfc-43a3-99c8-0d113eb85d03"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Name = @"ClearIntegrationLogScriptTask",
				Position = new Point(218, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,79,131,64,16,133,207,109,210,255,176,225,4,49,217,63,208,120,104,1,27,15,85,19,52,158,55,203,43,108,44,3,153,29,148,198,248,223,93,22,46,94,60,206,123,51,223,123,25,225,155,250,222,109,55,111,30,156,247,68,176,226,122,210,197,177,130,29,217,201,173,164,198,17,116,222,194,126,228,134,202,41,232,130,231,1,108,230,205,52,9,226,217,144,105,112,168,59,71,206,203,98,36,217,62,96,63,13,171,26,87,8,212,189,34,124,169,34,14,233,223,184,44,108,110,244,3,247,93,250,18,64,186,48,98,170,126,100,11,93,217,22,157,209,79,166,67,4,46,48,189,214,72,163,22,111,42,203,110,144,165,9,235,67,93,47,194,2,124,101,224,196,174,214,249,213,129,228,177,80,119,42,209,140,11,195,183,115,90,0,197,194,63,202,26,177,109,90,78,22,195,92,77,97,202,226,131,254,13,57,65,222,13,147,163,230,12,239,131,121,236,167,213,194,164,87,45,139,1,187,45,67,70,38,37,60,98,255,11,228,134,123,31,127,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetWarningMessageBoxScriptMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6")
			});
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,76,46,201,44,75,44,73,117,42,45,41,201,207,43,214,72,132,242,53,173,121,185,2,18,211,129,10,82,82,130,147,139,50,11,74,52,138,75,138,50,243,210,245,220,242,139,114,19,75,52,148,170,13,106,245,138,83,75,92,243,18,147,114,82,83,52,170,13,107,53,173,149,116,20,96,154,32,6,234,57,231,100,166,230,149,120,186,232,40,120,21,3,185,193,169,69,153,137,57,153,85,169,26,105,137,57,197,169,154,154,200,246,64,181,4,167,150,132,101,22,103,2,77,133,42,162,200,41,206,249,5,149,164,186,5,73,15,166,99,0,35,88,70,234,55,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterQuestionScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterQuestionScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,193,78,195,48,12,134,207,84,234,59,68,57,181,210,212,23,152,56,176,210,113,97,66,80,16,103,47,243,170,72,155,93,57,174,40,32,222,157,52,45,136,137,28,237,216,255,247,57,168,120,234,12,247,40,160,158,169,230,3,154,107,99,107,160,29,16,116,120,115,56,123,242,65,231,182,93,231,153,63,22,47,1,165,102,34,116,83,177,186,221,180,232,6,241,250,222,80,231,9,171,59,212,184,160,25,99,85,241,225,103,119,113,145,82,150,230,51,207,174,4,117,16,50,123,8,105,236,9,187,24,134,242,56,96,152,126,182,78,124,175,69,25,115,191,242,44,204,180,40,194,178,195,16,34,95,132,157,171,213,150,229,12,90,16,190,153,123,118,112,242,31,176,63,97,155,154,133,125,142,67,16,248,168,85,205,130,118,21,163,167,103,255,177,55,163,195,62,105,213,131,8,146,38,89,32,98,93,132,210,73,126,173,108,185,186,60,223,196,186,88,69,161,87,16,138,0,11,237,134,199,197,232,175,67,185,254,6,250,153,121,28,135,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetWarningMessageBoxScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e71cd74c-036d-4b50-9ce6-80ebf3e90d4a"),
				Name = "GetWarningMessageBoxScript",
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("322d4e6c-658c-4e78-9132-33b15f125959"),
				Name = "message",
				CreatedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				ModifiedInSchemaUId = new Guid("7a76c884-6240-48a2-88f8-da3526f10868"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,65,11,130,64,16,133,207,250,43,6,79,10,178,127,64,130,208,67,116,144,14,21,157,183,101,149,193,109,54,102,103,33,16,255,123,134,73,16,120,124,204,123,239,155,103,60,5,129,32,140,212,195,195,134,160,123,219,104,231,238,218,12,176,131,125,6,93,36,35,232,41,47,96,28,167,9,178,42,101,43,145,9,46,150,89,7,223,137,106,60,117,216,71,214,31,163,106,28,90,146,179,97,124,202,85,208,161,160,13,234,96,165,93,250,151,75,126,211,76,51,181,92,177,101,154,108,53,126,131,181,127,213,81,100,126,89,157,134,114,147,255,115,31,205,44,87,78,154,252,237,43,170,55,243,226,214,3,254,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntegrationLogGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a76c884-6240-48a2-88f8-da3526f10868"));
		}

		#endregion

	}

	#endregion

}

