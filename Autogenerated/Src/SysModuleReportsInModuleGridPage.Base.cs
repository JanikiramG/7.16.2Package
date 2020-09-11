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

	#region Class: SysModuleReportsInModuleGridPageSchema

	/// <exclude/>
	public class SysModuleReportsInModuleGridPageSchema : Terrasoft.WebApp.SysModuleReportsGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomLayout {
			get {
				return _bottomLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _bottomSpacer;
		public Terrasoft.UI.WebControls.Controls.Spacer BottomSpacer {
			get {
				return _bottomSpacer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _cancelButton;
		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return _cancelButton;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleReportsInModuleGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportsInModuleGridPageSchema(SysModuleReportsInModuleGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateSaveToFileButton() {
			SaveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToFileButton.Image = new ControlImage {};
			SaveToFileButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateFakeSaveToFileButton() {
			FakeSaveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			FakeSaveToFileButton.Image = new ControlImage {};
			FakeSaveToFileButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			RealUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			Name = "SysModuleReportsInModuleGridPage";
			ParentSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 900;
			Height = 600;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportsInModuleGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateFakeSaveToFileButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateSaveToFileButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SaveToFileButton);
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, ActionButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			ButtonsControlLayout.MoveItem(9, FakeSaveToFileButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			Controls.AddAt(2, CreateBottomLayout());
			BottomLayout.InsertItem(0, CreateBottomSpacer());
			BottomLayout.InsertItem(1, CreateCancelButton());
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleReportsInModuleGridPageEventsProcessSchema() {
			var schema = new SysModuleReportsInModuleGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateBottomSpacer() {
			_bottomSpacer = new Terrasoft.UI.WebControls.Controls.Spacer();
			_bottomSpacer.UId = new Guid("3f9f487b-00f1-4e6d-941c-df08d14e1a53");
			_bottomSpacer.Name = "BottomSpacer";
			_bottomSpacer.CreatedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			_bottomSpacer.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			_bottomSpacer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomSpacer.Tag = "";
			_bottomSpacer.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _bottomSpacer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("6ba2546f-0905-4108-8e15-3ae50d4917e5");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			_cancelButton.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomLayout() {
			_bottomLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomLayout.UId = new Guid("dfa659fd-9130-4205-954f-dc45b16dfe5e");
			_bottomLayout.Name = "BottomLayout";
			_bottomLayout.CreatedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			_bottomLayout.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			_bottomLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomLayout.Tag = "";
			_bottomLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_bottomLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomLayout.StartNewAlignGroup = false;
			_bottomLayout.Image = new ControlImage {};
			_bottomLayout.Edges = "1 0 0 0";
			return _bottomLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3fb83606-040e-4fdb-aeb6-a9357886dcb3");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("b6607c22-ca01-41f0-8637-610221a869b6");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("cb6b495c-384d-4a40-9f93-35c6dfb79a3b");
			if (column != null) {
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("94f2a9f7-55c7-4ecf-9b64-17583ddc058b");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("362bb0b0-d3da-4b01-abe6-a617e1b1257f");
			if (column != null) {
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("1f17f6cb-8a86-408c-9207-d2f8b22ae1b7");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysModuleReportsInModuleGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportsInModuleGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportsInModuleGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsInModuleGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportsInModuleGridPageEventsProcess<TPage> : Terrasoft.WebApp.SysModuleReportsGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportsInModuleGridPageSchemaUserControl
	{

		public SysModuleReportsInModuleGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportsInModuleGridPageEventsProcess";
			SchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
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

		public virtual Guid ParentEntitySchemaId {
			get;
			set;
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess16;
		public ProcessFlowElement PageLoadCompleteEventSubProcess16 {
			get {
				return _pageLoadCompleteEventSubProcess16 ?? (_pageLoadCompleteEventSubProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess16",
					SchemaElementUId = new Guid("837eb407-1659-4103-b340-c690ab390927"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage3;
		public ProcessFlowElement PageLoadCompleteStartMessage3 {
			get {
				return _pageLoadCompleteStartMessage3 ?? (_pageLoadCompleteStartMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage3",
					SchemaElementUId = new Guid("c7dbd58d-dbce-4339-9a43-8b1fade906a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent3 {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent3 ?? (_pageLoadCompleteIntermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("ae9a83ef-9543-4e89-8122-45727f5d7f18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask12;
		public ProcessScriptTask PageLoadCompleteScriptTask12 {
			get {
				return _pageLoadCompleteScriptTask12 ?? (_pageLoadCompleteScriptTask12 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask12",
					SchemaElementUId = new Guid("17714b44-e57f-49c9-bd9b-a1c57f091603"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTask12Execute,
				});
			}
		}

		private ProcessFlowElement _initEventSubProcess16;
		public ProcessFlowElement InitEventSubProcess16 {
			get {
				return _initEventSubProcess16 ?? (_initEventSubProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess16",
					SchemaElementUId = new Guid("7ec68e0a-dbe8-44be-8b97-9a7c52ed0da7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6Init;
		public ProcessFlowElement StartMessage6Init {
			get {
				return _startMessage6Init ?? (_startMessage6Init = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6Init",
					SchemaElementUId = new Guid("059a27a4-a453-4079-9f31-3811b023ee5d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScriptTask11;
		public ProcessScriptTask InitScriptTask11 {
			get {
				return _initScriptTask11 ?? (_initScriptTask11 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask11",
					SchemaElementUId = new Guid("c44dd3e7-4c7b-43c1-884f-b3a4e3a9e3f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTask11Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent4;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent4 {
			get {
				return _initIntermediateThrowMessageEvent4 ?? (_initIntermediateThrowMessageEvent4 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent4",
					SchemaElementUId = new Guid("9393509e-d02b-41ac-b329-9078e6a127e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickEventSubProcess16;
		public ProcessFlowElement CancelButtonClickEventSubProcess16 {
			get {
				return _cancelButtonClickEventSubProcess16 ?? (_cancelButtonClickEventSubProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CancelButtonClickEventSubProcess16",
					SchemaElementUId = new Guid("9b79a49e-4eeb-46f6-8495-c4b4f7b420a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickStartMessage6;
		public ProcessFlowElement CancelButtonClickStartMessage6 {
			get {
				return _cancelButtonClickStartMessage6 ?? (_cancelButtonClickStartMessage6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClickStartMessage6",
					SchemaElementUId = new Guid("8673ad9b-b550-4445-b98a-60c0a85c199d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelButtonClickScriptTask11;
		public ProcessScriptTask CancelButtonClickScriptTask11 {
			get {
				return _cancelButtonClickScriptTask11 ?? (_cancelButtonClickScriptTask11 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelButtonClickScriptTask11",
					SchemaElementUId = new Guid("3c2b1ea9-447e-4cb5-984c-66c189a90c17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTask11Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PageLoadCompleteEventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess16 };
			FlowElements[PageLoadCompleteStartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage3 };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent3 };
			FlowElements[PageLoadCompleteScriptTask12.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask12 };
			FlowElements[InitEventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess16 };
			FlowElements[StartMessage6Init.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6Init };
			FlowElements[InitScriptTask11.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask11 };
			FlowElements[InitIntermediateThrowMessageEvent4.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent4 };
			FlowElements[CancelButtonClickEventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickEventSubProcess16 };
			FlowElements[CancelButtonClickStartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage6 };
			FlowElements[CancelButtonClickScriptTask11.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask11 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadCompleteEventSubProcess16":
						break;
					case "PageLoadCompleteStartMessage3":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent3");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent3":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask12");
						break;
					case "PageLoadCompleteScriptTask12":
						break;
					case "InitEventSubProcess16":
						break;
					case "StartMessage6Init":
						e.Context.QueueTasks.Enqueue("InitScriptTask11");
						break;
					case "InitScriptTask11":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent4");
						break;
					case "InitIntermediateThrowMessageEvent4":
						break;
					case "CancelButtonClickEventSubProcess16":
						break;
					case "CancelButtonClickStartMessage6":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask11");
						break;
					case "CancelButtonClickScriptTask11":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteStartMessage3");
			ActivatedEventElements.Add("StartMessage6Init");
			ActivatedEventElements.Add("CancelButtonClickStartMessage6");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PageLoadCompleteEventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage3";
					result = PageLoadCompleteStartMessage3.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent3.Execute(context);
					break;
				case "PageLoadCompleteScriptTask12":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask12";
					result = PageLoadCompleteScriptTask12.Execute(context, PageLoadCompleteScriptTask12Execute);
					break;
				case "InitEventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6Init";
					result = StartMessage6Init.Execute(context);
					break;
				case "InitScriptTask11":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask11";
					result = InitScriptTask11.Execute(context, InitScriptTask11Execute);
					break;
				case "InitIntermediateThrowMessageEvent4":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent4.Execute(context);
					break;
				case "CancelButtonClickEventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickStartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickStartMessage6";
					result = CancelButtonClickStartMessage6.Execute(context);
					break;
				case "CancelButtonClickScriptTask11":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScriptTask11";
					result = CancelButtonClickScriptTask11.Execute(context, CancelButtonClickScriptTask11Execute);
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
				case "ParentEntitySchemaId":
					ParentEntitySchemaId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PageLoadCompleteScriptTask12Execute(ProcessExecutingContext context) {
			ThrowEvent(context, "GridPageRefreshRow");
			return true;
		}

		public virtual bool InitScriptTask11Execute(ProcessExecutingContext context) {
			/*SelectedModuleId = new Guid(Page.GetParameterValue("SysModuleId").ToString());
			SelectedNodePrimaryColumnValue =  SelectedModuleId;
			ParentEntitySchemaId = new Guid(Page.GetParameterValue("ParentEntitySchemaId").ToString());
			*/
			return true;
		}

		public virtual bool CancelButtonClickScriptTask11Execute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public override void ActivateButtons(bool activate) {
			var buttons = GetButtons();
			var dataSourceRowsCount = Page.DataSource.ActiveRowPrimaryColumnValue == Guid.Empty || !activate ? 0 : 1;
			bool addButtonEnabledByRights = true;
			bool deleteButtonEnabledByRights = true;
			bool editButtonEnabledByRights = true;
			bool copyButtonEnabledByRights = true;
			var entitySchema = Page.DataSource.Schema;
			if (entitySchema != null) {
				var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
				string schemaName = entitySchema.Name;
				deleteButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaDeletingAllowed(schemaName);
				addButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
				copyButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
				editButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaEditingAllowed(schemaName);
			}
			foreach(var control in Page.ButtonsControlLayout.Controls) {
				var button = control as Terrasoft.UI.WebControls.Controls.Button;
				if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
					if (buttons.Contains(button.Name)) {
						switch (button.Name) {
							case "AddButton":
								button.Enabled = addButtonEnabledByRights;
							break;
							case "DeleteButton":
								button.Enabled = (dataSourceRowsCount > 0) && deleteButtonEnabledByRights;
							break;
							case "EditButton":
								button.Enabled = (dataSourceRowsCount > 0) && editButtonEnabledByRights;
							break;
							case "CopyButton":
								button.Enabled = (dataSourceRowsCount > 0) && copyButtonEnabledByRights;
							break;
							default :
								button.Enabled = (dataSourceRowsCount > 0);
							break;
						}
					} else {
						button.Enabled = true;
					}
				}
			}
		}

		public override void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			var typeColumnUId = Page.DataSource.Schema.Columns.GetByName("Type").UId;
			queryStringParameters["SelectedModuleId"] = Json.Serialize(SelectedModuleId);
			queryStringParameters["ParentEntitySchemaId"] = Json.Serialize(ParentEntitySchemaId);
			queryStringParameters["typeColumnUId"] = Json.Serialize(typeColumnUId);
			if (queryStringParameters["typeId"] == "\"8bc259ef42764906b7a623dc59be7fe2\"") {
				queryStringParameters["closeMessage"] = Json.Serialize("ReportEditPageClosed");
			}
		}

		public override void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			var typeColumnUId = Page.DataSource.Schema.Columns.GetByName("Type").UId;
			queryStringParameters["SelectedModuleId"] = SelectedModuleId.ToString();
			queryStringParameters["ParentEntitySchemaId"] = ParentEntitySchemaId.ToString();
			queryStringParameters["typeColumnUId"] = Json.Serialize(typeColumnUId);
			queryStringParameters["closeMessage"] = "ReportEditPageClosed";
		}

		public override void ModifyCopyPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			var typeColumnUId = Page.DataSource.Schema.Columns.GetByName("Type").UId;
			queryStringParameters["SelectedModuleId"] = SelectedModuleId.ToString();
			queryStringParameters["ParentEntitySchemaId"] = ParentEntitySchemaId.ToString();
			queryStringParameters["typeColumnUId"] = Json.Serialize(typeColumnUId);
			queryStringParameters["closeMessage"] = "ReportEditPageClosed";
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage3")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage6Init")) {
							context.QueueTasks.Enqueue("StartMessage6Init");
							ProcessQueue(context);
							return;
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage6")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage6");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ParentEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentEntitySchemaId", ParentEntitySchemaId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsInModuleGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportsInModuleGridPageEventsProcess : SysModuleReportsInModuleGridPageEventsProcess<Terrasoft.WebApp.SysModuleReportsInModuleGridPageSchemaUserControl>
	{

		public SysModuleReportsInModuleGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportsInModuleGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportsInModuleGridPageSchemaUserControl : Terrasoft.WebApp.SysModuleReportsGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer BottomSpacer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("BottomSpacer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleReportsInModuleGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportsInModuleGridPageEventsProcess(UserConnection);
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

		public virtual void CancelButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CancelButtonClick");
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
			SchemaName = "SysModuleReportsInModuleGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsInModuleGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportsInModuleGridPageEventsProcessSchema : Terrasoft.WebApp.SysModuleReportsGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportsInModuleGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportsInModuleGridPageEventsProcessSchema(SysModuleReportsInModuleGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportsInModuleGridPageEventsProcess";
			UId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateParentEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2323ec5d-39c7-4f11-8d7a-a598cc51fb7e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"ParentEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateParentEntitySchemaIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess16 = CreatePageLoadCompleteEventSubProcess16EventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess16);
			ProcessSchemaEventSubProcess initeventsubprocess16 = CreateInitEventSubProcess16EventSubProcess();
			FlowElements.Add(initeventsubprocess16);
			ProcessSchemaEventSubProcess cancelbuttonclickeventsubprocess16 = CreateCancelButtonClickEventSubProcess16EventSubProcess();
			FlowElements.Add(cancelbuttonclickeventsubprocess16);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage3 = CreatePageLoadCompleteStartMessage3StartMessageEvent();
			pageloadcompleteeventsubprocess16.FlowElements.Add(pageloadcompletestartmessage3);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent3 = CreatePageLoadCompleteIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			pageloadcompleteeventsubprocess16.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent3);
			ProcessSchemaScriptTask pageloadcompletescripttask12 = CreatePageLoadCompleteScriptTask12ScriptTask();
			pageloadcompleteeventsubprocess16.FlowElements.Add(pageloadcompletescripttask12);
			ProcessSchemaStartMessageEvent startmessage6init = CreateStartMessage6InitStartMessageEvent();
			initeventsubprocess16.FlowElements.Add(startmessage6init);
			ProcessSchemaScriptTask initscripttask11 = CreateInitScriptTask11ScriptTask();
			initeventsubprocess16.FlowElements.Add(initscripttask11);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent4 = CreateInitIntermediateThrowMessageEvent4IntermediateThrowMessageEvent();
			initeventsubprocess16.FlowElements.Add(initintermediatethrowmessageevent4);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage6 = CreateCancelButtonClickStartMessage6StartMessageEvent();
			cancelbuttonclickeventsubprocess16.FlowElements.Add(cancelbuttonclickstartmessage6);
			ProcessSchemaScriptTask cancelbuttonclickscripttask11 = CreateCancelButtonClickScriptTask11ScriptTask();
			cancelbuttonclickeventsubprocess16.FlowElements.Add(cancelbuttonclickscripttask11);
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1445767867343578678SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("0c020be8-8756-4fa0-aeb4-fa08eb228c6d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				CurveCenterPosition = new Point(194, 97),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7dbd58d-dbce-4339-9a43-8b1fade906a5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ae9a83ef-9543-4e89-8122-45727f5d7f18"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("4e5255ba-4b61-4642-a856-7183f2078656"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				CurveCenterPosition = new Point(446, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ae9a83ef-9543-4e89-8122-45727f5d7f18"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17714b44-e57f-49c9-bd9b-a1c57f091603"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("a9c6833a-4b1c-4af6-9424-0dcc81a60c6a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				CurveCenterPosition = new Point(190, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("059a27a4-a453-4079-9f31-3811b023ee5d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c44dd3e7-4c7b-43c1-884f-b3a4e3a9e3f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("45d1f5cb-a332-4e95-b91f-82a1b0bcd386"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				CurveCenterPosition = new Point(334, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c44dd3e7-4c7b-43c1-884f-b3a4e3a9e3f8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9393509e-d02b-41ac-b329-9078e6a127e1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1445767867343578678SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1445767867343578678",
				UId = new Guid("26d331c4-8ff4-4eae-b482-1cbed6d62b4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8673ad9b-b550-4445-b98a-60c0a85c199d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c2b1ea9-447e-4cb5-984c-66c189a90c17"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2fd555de-389b-46ba-b1b5-d8b341cb2e17"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(955, 538),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("4c953975-c825-44f3-8239-40e3ee0ecca4"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("2fd555de-389b-46ba-b1b5-d8b341cb2e17"),
				CreatedInOwnerSchemaUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"Lane4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 164),
				Size = new Size(926, 374),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("193dd0ac-e2ab-4893-ad6e-e8d5739171ab"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2fd555de-389b-46ba-b1b5-d8b341cb2e17"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"Lane5",
				Position = new Point(29, 0),
				Size = new Size(926, 159),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("837eb407-1659-4103-b340-c690ab390927"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4c953975-c825-44f3-8239-40e3ee0ecca4"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"PageLoadCompleteEventSubProcess16",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(495, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c7dbd58d-dbce-4339-9a43-8b1fade906a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("837eb407-1659-4103-b340-c690ab390927"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"PageLoadCompleteStartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ae9a83ef-9543-4e89-8122-45727f5d7f18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("837eb407-1659-4103-b340-c690ab390927"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTask12ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("17714b44-e57f-49c9-bd9b-a1c57f091603"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("837eb407-1659-4103-b340-c690ab390927"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"PageLoadCompleteScriptTask12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,40,202,47,119,45,75,205,43,209,72,206,207,43,73,173,40,209,81,80,114,47,202,76,9,72,76,79,13,74,77,43,74,45,206,8,202,47,87,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,26,139,250,181,56,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7ec68e0a-dbe8-44be-8b97-9a7c52ed0da7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4c953975-c825-44f3-8239-40e3ee0ecca4"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"InitEventSubProcess16",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 182),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(349, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6InitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("059a27a4-a453-4079-9f31-3811b023ee5d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ec68e0a-dbe8-44be-8b97-9a7c52ed0da7"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"StartMessage6Init",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTask11ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c44dd3e7-4c7b-43c1-884f-b3a4e3a9e3f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ec68e0a-dbe8-44be-8b97-9a7c52ed0da7"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"InitScriptTask11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,189,10,194,48,24,69,247,66,223,33,116,74,59,180,15,80,156,68,138,67,37,16,113,15,205,165,6,242,3,159,95,144,190,189,65,232,162,14,238,247,220,115,134,78,195,99,97,216,57,217,236,113,182,226,32,34,158,98,202,206,74,101,86,244,19,88,25,50,1,12,186,25,159,33,27,189,61,246,121,211,246,215,164,153,92,92,101,219,142,117,181,255,93,146,133,34,23,12,109,199,228,115,136,111,182,188,139,79,99,129,138,0,145,79,145,29,111,122,185,35,152,255,66,126,113,95,69,221,80,87,4,206,20,5,83,198,248,2,205,152,241,127,244,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEvent4IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9393509e-d02b-41ac-b329-9078e6a127e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ec68e0a-dbe8-44be-8b97-9a7c52ed0da7"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"InitIntermediateThrowMessageEvent4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCancelButtonClickEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaCancelButtonClickEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9b79a49e-4eeb-46f6-8495-c4b4f7b420a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("193dd0ac-e2ab-4893-ad6e-e8d5739171ab"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"CancelButtonClickEventSubProcess16",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(290, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCancelButtonClickEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8673ad9b-b550-4445-b98a-60c0a85c199d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b79a49e-4eeb-46f6-8495-c4b4f7b420a2"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"CancelButtonClickStartMessage6",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTask11ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3c2b1ea9-447e-4cb5-984c-66c189a90c17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b79a49e-4eeb-46f6-8495-c4b4f7b420a2"),
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"),
				Name = @"CancelButtonClickScriptTask11",
				Position = new Point(176, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
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
				UId = new Guid("f759fd7f-c235-4aad-9f86-46ed65d3d366"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
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

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,203,110,219,48,16,60,75,95,177,241,33,176,129,64,72,175,17,220,192,15,161,13,80,180,65,156,180,103,74,90,219,68,41,82,224,195,174,208,248,223,75,138,178,42,39,145,146,166,23,1,226,206,206,44,119,103,185,35,18,82,163,181,224,10,166,240,9,245,220,255,140,39,113,184,179,177,156,104,178,18,70,102,120,39,246,106,33,12,215,22,119,75,54,24,45,219,80,52,203,52,221,57,196,173,164,5,145,213,66,48,83,240,239,132,25,132,169,165,53,52,143,146,162,212,21,60,62,194,25,113,104,162,17,174,225,18,174,224,67,28,166,66,48,32,121,238,197,19,78,82,134,249,188,186,163,155,173,118,117,105,105,176,65,229,200,80,227,27,128,152,83,253,6,88,38,202,106,24,230,218,128,92,83,93,173,178,45,22,228,133,251,251,64,28,210,53,140,79,160,103,83,224,134,177,9,252,14,131,186,157,233,10,51,35,45,32,225,27,202,241,200,245,160,80,46,4,231,104,91,35,120,180,156,159,194,226,48,80,90,82,190,1,85,243,126,37,133,75,237,74,69,238,204,226,134,251,243,84,63,178,19,191,81,73,135,103,233,242,173,210,140,49,177,199,124,252,87,208,58,34,24,152,209,235,212,179,178,68,158,247,114,15,77,226,191,201,135,220,240,58,121,98,179,251,168,15,225,90,72,36,217,118,236,6,156,9,174,165,181,21,229,126,176,205,58,45,252,241,23,82,9,163,163,230,79,181,182,240,27,104,75,57,166,19,5,247,40,37,81,98,173,163,135,155,232,7,166,199,164,54,187,225,182,151,115,182,107,40,26,195,193,249,57,120,199,88,120,81,18,137,223,164,109,14,97,13,174,118,203,5,140,28,23,254,210,159,145,149,158,109,52,113,20,151,117,101,29,94,175,74,168,125,24,58,4,19,15,11,212,158,234,108,11,39,33,31,9,50,162,16,70,179,163,109,70,87,245,105,208,32,155,89,216,139,247,25,43,174,241,169,109,240,207,184,67,184,236,184,188,151,115,252,210,227,245,209,93,206,118,103,96,79,122,52,147,214,66,239,83,236,181,96,143,222,162,221,135,247,233,245,238,211,51,189,28,215,196,48,13,255,44,243,148,233,96,63,7,64,102,203,175,199,255,140,201,191,168,53,240,16,30,254,0,200,145,206,195,125,6,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = base.CreateModifyAddPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,81,75,195,48,16,199,159,29,236,59,132,60,181,47,65,234,214,90,100,47,206,33,19,38,195,204,39,231,67,154,92,103,32,77,102,114,21,170,248,221,77,233,211,164,219,219,193,253,238,119,127,238,190,132,39,216,29,97,233,76,219,216,215,181,34,11,178,21,7,96,15,2,5,119,173,151,192,184,252,128,70,176,1,9,236,17,240,190,123,22,13,36,116,23,39,105,202,226,216,221,116,242,217,130,239,56,122,109,15,91,225,99,31,193,135,55,202,193,128,68,80,27,167,90,3,107,69,223,227,138,167,224,44,227,224,181,48,250,27,146,255,76,122,94,23,107,176,184,178,168,177,27,130,141,43,199,184,11,218,147,27,140,249,78,128,94,164,107,146,92,144,13,150,5,161,123,122,91,201,108,94,66,61,203,138,124,86,94,231,85,33,242,236,70,201,121,89,65,81,67,182,167,52,37,63,211,201,213,25,157,52,46,192,6,66,136,127,25,139,70,95,224,232,60,174,148,198,254,117,203,30,87,180,207,248,251,7,188,17,253,62,223,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = base.CreateModifyEditPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,10,194,48,16,132,239,62,69,201,169,189,228,5,196,139,90,68,161,82,76,61,137,135,208,12,26,72,147,154,108,133,250,244,198,214,75,69,193,219,178,51,243,237,207,93,250,132,250,22,43,103,186,198,30,183,42,89,36,165,188,128,175,37,73,225,58,95,131,139,250,138,70,242,209,18,248,6,180,236,247,178,65,202,170,152,100,25,143,177,249,236,214,193,247,130,188,182,151,82,250,40,19,124,56,49,1,131,154,160,10,167,58,131,173,98,231,56,225,179,201,43,55,38,211,236,39,40,214,176,148,91,210,212,143,27,189,97,223,132,127,128,147,179,7,210,46,56,203,5,188,150,70,63,144,78,12,191,57,181,113,1,5,66,136,111,27,48,236,128,214,121,202,149,166,215,43,87,47,93,177,249,19,232,61,179,14,107,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyCopyPageParametersMethod() {
			SchemaMethod method = base.CreateModifyCopyPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,10,194,48,16,132,239,62,69,201,169,189,228,5,196,139,90,68,161,82,76,61,137,135,208,12,26,72,147,154,108,133,250,244,198,214,75,69,193,219,178,51,243,237,207,93,250,132,250,22,43,103,186,198,30,183,42,89,36,165,188,128,175,37,73,225,58,95,131,139,250,138,70,242,209,18,248,6,180,236,247,178,65,202,170,152,100,25,143,177,249,236,214,193,247,130,188,182,151,82,250,40,19,124,56,49,1,131,154,160,10,167,58,131,173,98,231,56,225,179,201,43,55,38,211,236,39,40,214,176,148,91,210,212,143,27,189,97,223,132,127,128,147,179,7,210,46,56,203,5,188,150,70,63,144,78,12,191,57,181,113,1,5,66,136,111,27,48,236,128,214,121,202,149,166,215,43,87,47,93,177,249,19,232,61,179,14,107,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportsInModuleGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c021c65f-fa67-4393-a8bd-0da9b1fff456"));
		}

		#endregion

	}

	#endregion

}

