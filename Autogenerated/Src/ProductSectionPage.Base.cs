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
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ProductSectionPageSchema

	/// <exclude/>
	public class ProductSectionPageSchema : Terrasoft.WebApp.BaseModulePageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _oKCancelControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout OKCancelControlLayout {
			get {
				return _oKCancelControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _oKButton;
		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return _oKButton;
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

		public ProductSectionPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProductSectionPageSchema(ProductSectionPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateBaseMessagePanel() {
			BaseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			BaseMessagePanel.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Width = System.Web.UI.WebControls.Unit.Pixel(250);
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateGrid() {
			Grid.PageSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
			Grid.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateGridTabPanel() {
			GridTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			GridTabPanel.Collapsible = false;
			GridTabPanel.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateDetailsTabPanel() {
			DetailsTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			DetailsTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
			DetailsTabPanel.Collapsible = false;
			DetailsTabPanel.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateRightControlLayout() {
			RightControlLayout.Image = new ControlImage {};
			RightControlLayout.SplitterSize = 0;
			RightControlLayout.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			RealUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			Name = "ProductSectionPage";
			ParentSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Maximized = true;
			Width = 800;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductSectionPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateRightControlLayout();
			UpdateDetailsTabPanel();
			UpdateGridTabPanel();
			UpdateGridTab();
			UpdateGrid();
			UpdateLeftControlLayout();
			UpdateFilterEditLayout();
			UpdateApplyToolButton();
			UpdateSaveToolButton();
			UpdateFolderLayout();
			UpdateBaseMessagePanel();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, LeftControlLayout);
			LeftControlLayout.MoveItem(0, CustomSearchContainer);
			LeftControlLayout.MoveItem(1, FolderLayout);
			FolderLayout.MoveItem(0, BaseFolder);
			LeftControlLayout.MoveItem(2, FilterEditLayout);
			FilterEditLayout.MoveItem(0, FilterEdit);
			FilterEdit.MoveItem(0, SaveToolButton);
			FilterEdit.MoveItem(1, ApplyToolButton);
			MainControlLayout.MoveItem(1, RightControlLayout);
			RightControlLayout.MoveItem(0, GridTabPanel);
			GridTabPanel.MoveItem(0, GridTab);
			GridTab.MoveItem(0, Grid);
			RightControlLayout.MoveItem(1, DetailsTabPanel);
			RightControlLayout.InsertItem(2, CreateOKCancelControlLayout());
			OKCancelControlLayout.InsertItem(0, CreateSpacer1());
			OKCancelControlLayout.InsertItem(1, CreateOKButton());
			OKCancelControlLayout.InsertItem(2, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateProductSectionPageEventsProcessSchema() {
			var schema = new ProductSectionPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("a7b50562-4bb4-4c00-a492-1879be799ebc");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_spacer1.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("b7c59535-6661-40e3-bed2-39742c7903af");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_oKButton.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_oKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			_oKButton.AutoWidth = false;
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("fbf5edaa-ac38-478a-8b8a-63fc340bcac9");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_cancelButton.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			_cancelButton.AutoWidth = false;
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateOKCancelControlLayout() {
			_oKCancelControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_oKCancelControlLayout.UId = new Guid("4584af34-3396-4bec-9129-bdf059924031");
			_oKCancelControlLayout.Name = "OKCancelControlLayout";
			_oKCancelControlLayout.CreatedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_oKCancelControlLayout.ModifiedInSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			_oKCancelControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKCancelControlLayout.Tag = "";
			_oKCancelControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_oKCancelControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_oKCancelControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_oKCancelControlLayout.FitHeightByContent = true;
			_oKCancelControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_oKCancelControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_oKCancelControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_oKCancelControlLayout.StartNewAlignGroup = false;
			_oKCancelControlLayout.Image = new ControlImage {};
			_oKCancelControlLayout.Edges = "";
			return _oKCancelControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ProductSectionPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProductSectionPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProductSectionPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProductSectionPageEventsProcess

	/// <exclude/>
	public class ProductSectionPageEventsProcess<TPage> : Terrasoft.WebApp.BaseModulePageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProductSectionPageSchemaUserControl
	{

		public ProductSectionPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductSectionPageEventsProcess";
			SchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af");
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

		public virtual bool IsEditMode {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("57f1026a-b701-4847-9b9c-36c220421ade"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageInitMessage;
		public ProcessFlowElement PageInitMessage {
			get {
				return _pageInitMessage ?? (_pageInitMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageInitMessage",
					SchemaElementUId = new Guid("19bd0dff-36e0-4714-a0e3-5b13b714f222"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageInitThrowMessageEvent;
		public ProcessThrowMessageEvent PageInitThrowMessageEvent {
			get {
				return _pageInitThrowMessageEvent ?? (_pageInitThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageInitThrowMessageEvent",
					SchemaElementUId = new Guid("c06b9eb3-5988-4485-94cf-7589ab18886a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageInit",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageInitScriptTask;
		public ProcessScriptTask PageInitScriptTask {
			get {
				return _pageInitScriptTask ?? (_pageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageInitScriptTask",
					SchemaElementUId = new Guid("8718ac8d-4cce-41ce-88a0-8522b6d5891d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageInitScriptTaskExecute,
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
					SchemaElementUId = new Guid("925ac25c-a209-4e33-be46-2617cfa6edfe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickMessage;
		public ProcessFlowElement OKButtonClickMessage {
			get {
				return _oKButtonClickMessage ?? (_oKButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickMessage",
					SchemaElementUId = new Guid("7df74183-c10d-436e-b393-86174d357cf5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _oKScriptTask;
		public ProcessScriptTask OKScriptTask {
			get {
				return _oKScriptTask ?? (_oKScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OKScriptTask",
					SchemaElementUId = new Guid("758f177d-2096-4e5d-b640-1f79a065c7cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OKScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _lookupRecordSelectedMessage;
		public ProcessFlowElement LookupRecordSelectedMessage {
			get {
				return _lookupRecordSelectedMessage ?? (_lookupRecordSelectedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LookupRecordSelectedMessage",
					SchemaElementUId = new Guid("3728ddf9-fc38-41d1-94b6-afe3054287cb"),
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
					SchemaElementUId = new Guid("abadf3e4-185e-4b33-8bf4-ff46f748d28f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickMessage;
		public ProcessFlowElement CancelButtonClickMessage {
			get {
				return _cancelButtonClickMessage ?? (_cancelButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClickMessage",
					SchemaElementUId = new Guid("71dcfbd7-a3fe-45b7-8077-98935c6f0e18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelScript;
		public ProcessScriptTask CancelScript {
			get {
				return _cancelScript ?? (_cancelScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelScript",
					SchemaElementUId = new Guid("bd1d6ce9-b1a8-413d-bb38-477c29df2eda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelScriptExecute,
				});
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
					SchemaElementUId = new Guid("7562e6e0-751b-4ee3-beca-8ac811081dd6"),
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
					SchemaElementUId = new Guid("96cfb20c-b131-4bfe-80be-0518ecf2a633"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask;
		public ProcessScriptTask PageLoadCompleteScriptTask {
			get {
				return _pageLoadCompleteScriptTask ?? (_pageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("a8d12272-8887-43e3-9f46-6c0e1d6ac915"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadCompleteThrowMessageEvent {
			get {
				return _pageLoadCompleteThrowMessageEvent ?? (_pageLoadCompleteThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteThrowMessageEvent",
					SchemaElementUId = new Guid("b0f6e68d-a4d4-4c68-a0fa-9ff422bc1ab5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("52750028-9e5a-4461-a830-e6d8fef2c690"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadMessage3;
		public ProcessFlowElement PageLoadMessage3 {
			get {
				return _pageLoadMessage3 ?? (_pageLoadMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadMessage3",
					SchemaElementUId = new Guid("6846c4cc-625b-4009-84be-3d0fd134c666"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent PageLoadIntermediateThrowMessageEvent1 {
			get {
				return _pageLoadIntermediateThrowMessageEvent1 ?? (_pageLoadIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("7bcb1594-f3fc-4a8f-90b8-144958d431e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadScriptTask;
		public ProcessScriptTask PageLoadScriptTask {
			get {
				return _pageLoadScriptTask ?? (_pageLoadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadScriptTask",
					SchemaElementUId = new Guid("d240d863-e67d-4c7f-9c5b-42ef069aaea1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadScriptTaskExecute,
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
					SchemaElementUId = new Guid("7dec6403-1072-4b43-90c0-dea997da7e08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _tuningModeButtonClickMessage;
		public ProcessFlowElement TuningModeButtonClickMessage {
			get {
				return _tuningModeButtonClickMessage ?? (_tuningModeButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TuningModeButtonClickMessage",
					SchemaElementUId = new Guid("9a083439-d657-451f-a340-6266fc2ebbd8"),
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
					SchemaElementUId = new Guid("26dc5a76-3b6f-4acd-bb9c-c8cca2d85b78"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "TuningModeChanged",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _tuningModeMessageScript;
		public ProcessScriptTask TuningModeMessageScript {
			get {
				return _tuningModeMessageScript ?? (_tuningModeMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TuningModeMessageScript",
					SchemaElementUId = new Guid("ac656614-90ca-4927-aa78-6741201bc4ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TuningModeMessageScriptExecute,
				});
			}
		}

		private LocalizableString _pageCaption;
		public LocalizableString PageCaption {
			get {
				return _pageCaption ?? (_pageCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PageCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PageInitMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageInitMessage };
			FlowElements[PageInitThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageInitThrowMessageEvent };
			FlowElements[PageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageInitScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[OKButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickMessage };
			FlowElements[OKScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OKScriptTask };
			FlowElements[LookupRecordSelectedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupRecordSelectedMessage };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[CancelButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickMessage };
			FlowElements[CancelScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelScript };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[PageLoadCompleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[PageLoadCompleteThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteThrowMessageEvent };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[PageLoadMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadMessage3 };
			FlowElements[PageLoadIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadIntermediateThrowMessageEvent1 };
			FlowElements[PageLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadScriptTask };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[TuningModeButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TuningModeButtonClickMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[TuningModeMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { TuningModeMessageScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "PageInitMessage":
						e.Context.QueueTasks.Enqueue("PageInitScriptTask");
						break;
					case "PageInitThrowMessageEvent":
						break;
					case "PageInitScriptTask":
						e.Context.QueueTasks.Enqueue("PageInitThrowMessageEvent");
						break;
					case "EventSubProcess8":
						break;
					case "OKButtonClickMessage":
						e.Context.QueueTasks.Enqueue("OKScriptTask");
						break;
					case "OKScriptTask":
						break;
					case "LookupRecordSelectedMessage":
						e.Context.QueueTasks.Enqueue("OKScriptTask");
						break;
					case "EventSubProcess9":
						break;
					case "CancelButtonClickMessage":
						e.Context.QueueTasks.Enqueue("CancelScript");
						break;
					case "CancelScript":
						break;
					case "EventSubProcess10":
						break;
					case "PageLoadCompleteMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteThrowMessageEvent");
						break;
					case "PageLoadCompleteThrowMessageEvent":
						break;
					case "EventSubProcess11":
						break;
					case "PageLoadMessage3":
						e.Context.QueueTasks.Enqueue("PageLoadScriptTask");
						break;
					case "PageLoadIntermediateThrowMessageEvent1":
						break;
					case "PageLoadScriptTask":
						e.Context.QueueTasks.Enqueue("PageLoadIntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess12":
						break;
					case "TuningModeButtonClickMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("TuningModeMessageScript");
						break;
					case "TuningModeMessageScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageInitMessage");
			ActivatedEventElements.Add("OKButtonClickMessage");
			ActivatedEventElements.Add("LookupRecordSelectedMessage");
			ActivatedEventElements.Add("CancelButtonClickMessage");
			ActivatedEventElements.Add("PageLoadCompleteMessage");
			ActivatedEventElements.Add("PageLoadMessage3");
			ActivatedEventElements.Add("TuningModeButtonClickMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PageInitMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageInitMessage";
					result = PageInitMessage.Execute(context);
					break;
				case "PageInitThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageInit");
					result = PageInitThrowMessageEvent.Execute(context);
					break;
				case "PageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageInitScriptTask";
					result = PageInitScriptTask.Execute(context, PageInitScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickMessage";
					result = OKButtonClickMessage.Execute(context);
					break;
				case "OKScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKScriptTask";
					result = OKScriptTask.Execute(context, OKScriptTaskExecute);
					break;
				case "LookupRecordSelectedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupRecordSelectedMessage";
					result = LookupRecordSelectedMessage.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickMessage";
					result = CancelButtonClickMessage.Execute(context);
					break;
				case "CancelScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelScript";
					result = CancelScript.Execute(context, CancelScriptExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteMessage";
					result = PageLoadCompleteMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "PageLoadCompleteThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadMessage3";
					result = PageLoadMessage3.Execute(context);
					break;
				case "PageLoadIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = PageLoadIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PageLoadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadScriptTask";
					result = PageLoadScriptTask.Execute(context, PageLoadScriptTaskExecute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "TuningModeButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TuningModeButtonClickMessage";
					result = TuningModeButtonClickMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "TuningModeChanged");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "TuningModeMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "TuningModeMessageScript";
					result = TuningModeMessageScript.Execute(context, TuningModeMessageScriptExecute);
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
				case "IsEditMode":
					IsEditMode = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PageInitScriptTaskExecute(ProcessExecutingContext context) {
			//SysModuleId = new Guid("5f293f6a-765b-49fa-88a5-05c5f698941f");
			SysModuleId = Terrasoft.Configuration.ProductConsts.ProductModuleUId;
			return true;
		}

		public virtual bool OKScriptTaskExecute(ProcessExecutingContext context) {
			var dataSource = GetActiveDataSource();
			string primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
			string primaryDisplayColumnName = dataSource.Schema.PrimaryDisplayColumn.Name;
			//var selValue = GetGridSelectedValue();
			var selRows = GetSelectedActiveRows();
			if(selRows.Count>0)
			{
				var selValue = selRows[0];
				string primaryDisplayColumnValue = string.Empty;
				string schemaUId = dataSource.Schema.UId.ToString();
				string selectedValuesString = string.Empty;
			
				Select select = 
					new Select(UserConnection).
						Column(primaryDisplayColumnName).
							From(dataSource.Schema.Name).
								Where(primaryColumnName).IsEqual(Column.Parameter(selValue))
					as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
						if (dr.Read()) {
							primaryDisplayColumnValue = dr[0].ToString();
						}
					}
				}
			
				var selectedValues = new Dictionary<string, object>();
				Dictionary<string, object> values;
				string serializedData;
				values = new Dictionary<string, object>();
				values.Add(primaryDisplayColumnName, primaryDisplayColumnValue);
				values.Add("schemaUId", schemaUId);
				selectedValues.Add(selValue.ToString(), values);
				serializedData = Json.Serialize(values, new DictionaryJsonConverter());
				selectedValuesString += string.Concat("selectedValues.push({keyValue :", Json.Serialize(selValue), 
							", primaryDisplayColumnName:", Json.Serialize(primaryDisplayColumnName), ", dataValue:", serializedData, "});");		
			
				string script = @"
						var key = window.name;
						if (window.opener) {
						var lookupGridPageParams = window.opener.window.lookupGridPageParams[key];
						var sender = lookupGridPageParams.sender;
						var referenceSchemaUId = '" + schemaUId + @"';
						var selectedValues = []; " + selectedValuesString + @"
						var lookupGridPageCallback = lookupGridPageParams.lookupGridPageCallback;
						if (sender && lookupGridPageCallback) { lookupGridPageCallback.call(lookupGridPageParams.sender, selectedValues, referenceSchemaUId);}}";
						Page.AddScript(script);
					 
					Dictionary <string, object> openLookupSelectedValues = (Dictionary <string, object>)Page.GetParameterValue("openLookupSelectedValues");
					if (openLookupSelectedValues != null) {
						foreach (KeyValuePair<string, object> item in selectedValues) {
							if (openLookupSelectedValues.ContainsKey(item.Key)) {
								openLookupSelectedValues[item.Key] = item.Value;
							} else {
						    	openLookupSelectedValues.Add(item.Key, item.Value);
							}
						}
						string userContextKey = Page.GetParameterValue("tempUserContextUId") == null ? string.Empty : Page.GetParameterValue("tempUserContextUId").ToString();
						if (!string.IsNullOrEmpty(userContextKey)) {
							var sessionData = UserConnection.SessionData[userContextKey] as Dictionary<string, object>;
							sessionData["openLookupSelectedValues"] = openLookupSelectedValues;
							UserConnection.SessionData[userContextKey] = sessionData;
						}
					}
			}	 
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool CancelScriptExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			//MakeCaption();
			return true;
		}

		public virtual bool PageLoadScriptTaskExecute(ProcessExecutingContext context) {
			if (!Ext.IsAjaxRequest) {
				string editMode = (string)Page.GetParameterValue("editMode");
				IsEditMode = string.IsNullOrEmpty(editMode) ? false : Convert.ToBoolean(editMode);
				SetDisplayControls();
				
				var searchValue = ControlUtilities.HtmlDecode((string)Page.GetParameterValue("searchValue"));
				if(!string.IsNullOrEmpty(searchValue)) {
					//SearchPrimaryDisplayColumnValue = searchValue;
					var activeDataSource = GetActiveDataSource();
					var currentStructure = activeDataSource.CurrentStructure;
					var newFilter = currentStructure.CreateFilterWithParameters(activeDataSource.Schema, 
								FilterComparisonType.Equal, activeDataSource.Schema.PrimaryDisplayColumn.Name, searchValue); 
					var quickFilter = currentStructure.Filters.FindByName("QuickFilter");
					if(quickFilter == null) {
						DataSourceFilterCollection filters = null;
						filters = currentStructure.CreateFiltersGroup("QuickFilter", LogicalOperationStrict.And);	
						filters.Add(newFilter);
						currentStructure.Filters.Add((IDataSourceFilterItem) filters);
					}  else {
						(quickFilter as DataSourceFilterCollection).Clear();
						(quickFilter as DataSourceFilterCollection).Add(newFilter);
					}
			
					foreach (var filter in currentStructure.Filters) {
						if(string.IsNullOrEmpty(filter.Name) || !filter.Name.Equals("QuickFilter")) {	
							filter.IsEnabled = false;
						}
					}
				}
				
				
			}
			MakeCaption();
			return true;
		}

		public virtual bool TuningModeMessageScriptExecute(ProcessExecutingContext context) {
			//IsModuleProcessesTuningMode = !IsModuleProcessesTuningMode;
			var messageId = "tuningModeMessage";
			string message = string.Empty;
			if (IsModuleProcessesTuningMode) {
				message = string.Format("{0}",TuningModeCaption.ToString());	
				Page.BaseMessagePanel.Remove(messageId);
				Page.BaseMessagePanel.AddMessage(messageId,
						ModuleProcessInstanceNotExistCaption, message, MessageType.Information);
				Page.BaseMessagePanel.Show();
			} else {
				Page.BaseMessagePanel.Remove(messageId);
				Page.BaseMessagePanel.Hide();
			}
			return true;
		}

		public override void SetDefaultModuleParameters() {
			//TODO 173099, 173091
			if (SysModuleId == Guid.Empty) {
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
				var	primaryColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
						"SysPageSchemaUId", Page.Schema.UId));
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					SysModuleId = entities[0].GetTypedColumnValue<Guid>(primaryColumnName);
				}
			}
			if (SysModuleId != Guid.Empty && (FolderEntryEntitySchemaUId == Guid.Empty || FolderEntitySchemaUId == Guid.Empty || SysEntitySchemaId == Guid.Empty)) {
				var folderCodeColumnName = "FolderMode.Code";
				var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
				var entitySchemaIdColumn = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId");
				var folderCodeModeColumn = entitySchemaQuery.AddColumn(folderCodeColumnName);
				var hasActionsColumnName = entitySchemaQuery.AddColumn("HasActions").Name;
				var codeColumnName = entitySchemaQuery.AddColumn("Code").Name;
				EntitySchemaQueryFilterCollection filters = entitySchemaQuery.Filters;
				filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", SysModuleId));
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				string folderCode = "None";
				var sysModuleCode = string.Empty;
				var entityName = String.Empty;
				if (entities.Count > 0) {
					SysEntitySchemaId = entities[0].GetTypedColumnValue<Guid>(entitySchemaIdColumn.Name);
					var entitySchemaItem = entitySchemaManager.GetItemByUId(
										entities[0].GetTypedColumnValue<Guid>(entitySchemaIdColumn.Name));
					entityName = entitySchemaItem.Name;
					folderCode = entities[0].GetTypedColumnValue<string>(folderCodeModeColumn.Name);
					sysModuleCode = entities[0].GetTypedColumnValue<string>(codeColumnName);
					HasActions = !entities[0].GetTypedColumnValue<bool>(hasActionsColumnName);
				}
				FoldersMode = folderCode;
				if (string.IsNullOrEmpty(entityName)) {
					return;
				}
				if (!string.IsNullOrEmpty(sysModuleCode)) {
					entityName = sysModuleCode;
				}
				var folderSuffix = "Folder";
				var folderEntrySuffix = "InFolder";
				switch (folderCode) {
					case "SingleFolderEntry":
						if (FolderEntitySchemaUId == Guid.Empty) {
							FolderEntitySchemaUId = GetSchemaUIdByName(entityName + folderSuffix);
						}
						break;
					case "MultiFolderEntry":
						if (FolderEntitySchemaUId == Guid.Empty) {
							FolderEntitySchemaUId = GetSchemaUIdByName(entityName + folderSuffix);
						}
						if (FolderEntryEntitySchemaUId == Guid.Empty) {
							FolderEntryEntitySchemaUId = GetSchemaUIdByName(entityName + folderEntrySuffix);
						}	
						break;
					case "None":
						Page.LeftControlLayout.Hidden = true;
						break;
				}
			}
		}

		public override void DisplayDetailsTabPanel(bool show) {
			if(IsEditMode)base.DisplayDetailsTabPanel(show);
		}

		public virtual void SetDisplayControls() {
			/*string formatString = "{0}.hide()";
			var script = GetRegisterAddPageScript(EditPageUId, SysModuleEditId, Guid.Empty);	
			if (!string.IsNullOrEmpty(script)) {
				Page.AddScript(string.Format(formatString, Page.AddMenuItem.ClientID, script));
			}*/
			//Page.LeftControlLayout.Collapsible = true;
			if(IsEditMode)
			{
				Page.DetailsTabPanel.Show();
				Page.OKCancelControlLayout.Hide();
				Page.AddScript(string.Format("{0}.width=250", Page.LeftControlLayout.ClientID));
				//Page.LeftControlLayout.Show();
			}
			else
			{
				Page.DetailsTabPanel.Hide();
				Page.OKCancelControlLayout.Show();
				Page.AddScript(string.Format("{0}.width=0", Page.LeftControlLayout.ClientID));
				//Page.LeftControlLayout.Hide();
			}
			Page.GridTabPanel.HideCollapseTool = !IsEditMode;
			Page.GridTabPanel.HasSplitter = IsEditMode;
			//Page.GridTabPanel.Collapsible = IsEditMode;
			//Page.LeftControlLayout.IsCollapsible = true;
			//Page.LeftControlLayout.Collapsed = !IsEditMode;
			//Page.AddScript(string.Format("{0}.collapse()", Page.LeftControlLayout.ClientID));
		}

		public virtual void MakeCaption() {
			string caption = IsModuleProcessesTuningMode?string.Format(@"{0} ({1})",PageCaption.ToString(),TuningModeCaption.ToString()):PageCaption.ToString();
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = caption;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageInit":
							if (ActivatedEventElements.Contains("PageInitMessage")) {
							context.QueueTasks.Enqueue("PageInitMessage");
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickMessage");
						}
						break;
					case "LookupRecordSelected":
							if (ActivatedEventElements.Contains("LookupRecordSelectedMessage")) {
							context.QueueTasks.Enqueue("LookupRecordSelectedMessage");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadMessage3")) {
							context.QueueTasks.Enqueue("PageLoadMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "TuningModeChanged":
							if (ActivatedEventElements.Contains("TuningModeButtonClickMessage")) {
							context.QueueTasks.Enqueue("TuningModeButtonClickMessage");
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
			if (!HasMapping("IsEditMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEditMode", IsEditMode, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ProductSectionPageEventsProcess

	/// <exclude/>
	public class ProductSectionPageEventsProcess : ProductSectionPageEventsProcess<Terrasoft.WebApp.ProductSectionPageSchemaUserControl>
	{

		public ProductSectionPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductSectionPageSchemaUserControl

	/// <exclude/>
	public partial class ProductSectionPageSchemaUserControl : Terrasoft.WebApp.BaseModulePageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout OKCancelControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("OKCancelControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OKButton", true);
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
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ProductSectionPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProductSectionPageEventsProcess(UserConnection);
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

		public virtual void OKButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OKButtonClick");
		}

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
			SchemaName = "ProductSectionPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProductSectionPageEventsProcessSchema

	/// <exclude/>
	public class ProductSectionPageEventsProcessSchema : Terrasoft.WebApp.BaseModulePageEventsProcessSchema
	{

		#region Constructors: Public

		public ProductSectionPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductSectionPageEventsProcessSchema(ProductSectionPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductSectionPageEventsProcess";
			UId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateSearchPrimaryDisplayColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("100ee50a-9c05-4d76-a38f-4b52e2694679"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SearchPrimaryDisplayColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEditModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5b091004-9271-49e6-8470-fe27edc7e8ea"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"IsEditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsEditModeParameter());
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
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaStartMessageEvent pageinitmessage = CreatePageInitMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(pageinitmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageinitthrowmessageevent = CreatePageInitThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(pageinitthrowmessageevent);
			ProcessSchemaScriptTask pageinitscripttask = CreatePageInitScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(pageinitscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickmessage = CreateOKButtonClickMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(okbuttonclickmessage);
			ProcessSchemaScriptTask okscripttask = CreateOKScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(okscripttask);
			ProcessSchemaStartMessageEvent lookuprecordselectedmessage = CreateLookupRecordSelectedMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(lookuprecordselectedmessage);
			ProcessSchemaStartMessageEvent cancelbuttonclickmessage = CreateCancelButtonClickMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(cancelbuttonclickmessage);
			ProcessSchemaScriptTask cancelscript = CreateCancelScriptScriptTask();
			eventsubprocess9.FlowElements.Add(cancelscript);
			ProcessSchemaStartMessageEvent pageloadcompletemessage = CreatePageLoadCompleteMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(pageloadcompletemessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompletethrowmessageevent = CreatePageLoadCompleteThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(pageloadcompletethrowmessageevent);
			ProcessSchemaStartMessageEvent pageloadmessage3 = CreatePageLoadMessage3StartMessageEvent();
			eventsubprocess11.FlowElements.Add(pageloadmessage3);
			ProcessSchemaIntermediateThrowMessageEvent pageloadintermediatethrowmessageevent1 = CreatePageLoadIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess11.FlowElements.Add(pageloadintermediatethrowmessageevent1);
			ProcessSchemaScriptTask pageloadscripttask = CreatePageLoadScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(pageloadscripttask);
			ProcessSchemaStartMessageEvent tuningmodebuttonclickmessage = CreateTuningModeButtonClickMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(tuningmodebuttonclickmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess12.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask tuningmodemessagescript = CreateTuningModeMessageScriptScriptTask();
			eventsubprocess12.FlowElements.Add(tuningmodemessagescript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatePageCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreatePageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f5f46a35-9db9-4be6-bb9d-fc0139916070"),
				Name = "PageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ee14c331-e627-4a06-8a80-4b20715fad49"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(185, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("19bd0dff-36e0-4714-a0e3-5b13b714f222"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8718ac8d-4cce-41ce-88a0-8522b6d5891d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0189b9b7-dcf6-4fff-b483-30a98f2235d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(377, 93),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8718ac8d-4cce-41ce-88a0-8522b6d5891d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c06b9eb3-5988-4485-94cf-7589ab18886a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("9044a218-af6b-4b4b-bd5a-96d09dfffbaf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7df74183-c10d-436e-b393-86174d357cf5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("758f177d-2096-4e5d-b640-1f79a065c7cf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("059df505-9c3c-4e03-b144-66616eaf705d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71dcfbd7-a3fe-45b7-8077-98935c6f0e18"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd1d6ce9-b1a8-413d-bb38-477c29df2eda"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("ed6f1a00-4691-4e73-beed-e03e48108824"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(212, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3728ddf9-fc38-41d1-94b6-afe3054287cb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("758f177d-2096-4e5d-b640-1f79a065c7cf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("0d3b266c-da9f-4dfb-a78c-287e72f8ec3a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(188, 623),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96cfb20c-b131-4bfe-80be-0518ecf2a633"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a8d12272-8887-43e3-9f46-6c0e1d6ac915"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("c73b51f7-0e65-4585-abd3-3f112a5b3a1c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(354, 624),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a8d12272-8887-43e3-9f46-6c0e1d6ac915"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0f6e68d-a4d4-4c68-a0fa-9ff422bc1ab5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("e821df34-0fce-4081-8fc9-010f1c04ce15"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(437, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6846c4cc-625b-4009-84be-3d0fd134c666"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d240d863-e67d-4c7f-9c5b-42ef069aaea1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("f4be0b76-bfdc-4751-8d38-284f9bbf2436"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(518, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d240d863-e67d-4c7f-9c5b-42ef069aaea1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7bcb1594-f3fc-4a8f-90b8-144958d431e9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("29771477-cfa4-45df-885d-5e05e20cf79d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(156, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9a083439-d657-451f-a340-6266fc2ebbd8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("26dc5a76-3b6f-4acd-bb9c-c8cca2d85b78"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("e4af634f-ebba-4e44-9fd0-87ba5a4344c6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CurveCenterPosition = new Point(156, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("26dc5a76-3b6f-4acd-bb9c-c8cca2d85b78"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac656614-90ca-4927-aa78-6741201bc4ae"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6fe0cdbd-6c69-44a9-aa8d-7fa4b3b44a30"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(859, 1166),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0b6034c3-b19f-4c44-b31d-d09794abadc4"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("6fe0cdbd-6c69-44a9-aa8d-7fa4b3b44a30"),
				CreatedInOwnerSchemaUId = new Guid("900ed0c9-8cc6-4638-929d-50be8e71e2af"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 592),
				Size = new Size(830, 574),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("1b371540-5f70-47d3-8ac4-563ddb4864d9"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("6fe0cdbd-6c69-44a9-aa8d-7fa4b3b44a30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"Lane2",
				Position = new Point(29, 362),
				Size = new Size(830, 225),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("5b210c59-34e9-4556-85a4-bf804840d69b"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("6fe0cdbd-6c69-44a9-aa8d-7fa4b3b44a30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"Lane3",
				Position = new Point(29, 198),
				Size = new Size(830, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("4131e080-76a4-4767-badf-7bd90a6df9a2"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6fe0cdbd-6c69-44a9-aa8d-7fa4b3b44a30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"Lane4",
				Position = new Point(29, 0),
				Size = new Size(830, 193),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("57f1026a-b701-4847-9b9c-36c220421ade"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b6034c3-b19f-4c44-b31d-d09794abadc4"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(546, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageInitMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("19bd0dff-36e0-4714-a0e3-5b13b714f222"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57f1026a-b701-4847-9b9c-36c220421ade"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageInit",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageInitMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageInitThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c06b9eb3-5988-4485-94cf-7589ab18886a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57f1026a-b701-4847-9b9c-36c220421ade"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageInit",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageInitThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8718ac8d-4cce-41ce-88a0-8522b6d5891d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57f1026a-b701-4847-9b9c-36c220421ade"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,15,174,44,246,205,79,41,205,73,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,50,77,51,178,52,78,51,75,212,53,55,51,77,210,53,177,76,75,212,181,176,72,52,213,53,48,77,54,77,51,179,180,176,52,49,76,83,210,180,230,229,66,53,32,36,181,168,40,177,56,63,173,68,207,57,63,47,45,51,189,180,40,177,36,51,63,79,47,160,8,168,38,185,4,40,88,92,82,12,227,65,244,133,122,166,0,141,41,74,45,41,45,202,83,40,41,42,77,181,6,0,237,68,254,63,150,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("925ac25c-a209-4e33-be46-2617cfa6edfe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b371540-5f70-47d3-8ac4-563ddb4864d9"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"EventSubProcess8",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 177),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7df74183-c10d-436e-b393-86174d357cf5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925ac25c-a209-4e33-be46-2617cfa6edfe"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"OKButtonClickMessage",
				Position = new Point(36, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOKScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("758f177d-2096-4e5d-b640-1f79a065c7cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925ac25c-a209-4e33-be46-2617cfa6edfe"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"OKScriptTask",
				Position = new Point(176, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,75,115,219,54,16,62,211,51,254,15,8,15,9,56,230,32,57,71,117,94,178,155,113,211,73,61,97,220,28,52,58,192,36,20,179,166,8,22,0,229,184,25,253,247,238,2,224,83,164,38,246,193,166,23,223,126,251,94,96,199,21,201,184,225,137,172,85,42,200,57,249,40,204,251,212,228,59,113,209,74,105,180,56,61,209,70,229,229,119,82,169,124,203,213,227,82,22,245,182,252,204,183,168,210,233,179,36,189,19,91,206,174,251,40,134,176,3,134,139,92,87,5,255,69,162,1,184,225,123,249,114,7,206,107,81,252,205,139,218,187,254,81,229,89,34,10,145,26,145,89,177,245,221,227,190,200,7,237,96,13,196,69,138,114,139,203,55,212,195,216,82,214,165,121,243,42,58,61,249,121,122,18,140,12,121,208,234,213,26,148,130,35,113,181,10,22,194,46,183,149,121,236,169,104,27,228,205,85,54,25,59,200,217,87,153,88,168,117,175,85,235,7,168,29,224,208,8,224,93,152,30,15,8,16,5,165,120,32,78,78,111,180,80,75,89,150,240,157,203,50,98,120,28,56,199,233,92,149,60,42,248,93,201,45,61,244,185,15,9,190,221,9,37,232,65,199,68,236,74,95,254,91,243,130,250,122,94,115,5,98,35,20,109,114,28,69,72,193,181,247,20,99,175,53,70,73,177,18,217,237,229,15,145,214,70,42,136,105,24,4,187,44,117,173,196,197,135,78,68,163,136,96,13,27,134,43,108,236,47,130,103,2,152,148,171,38,32,153,227,20,238,132,118,54,26,245,32,223,16,154,41,134,128,150,51,8,142,149,61,83,208,34,163,26,6,193,30,127,227,175,189,45,146,239,173,94,69,65,19,171,116,145,91,255,129,252,55,87,218,152,200,219,127,0,247,198,49,205,159,147,157,229,25,180,140,202,121,145,255,39,50,140,126,97,205,62,193,148,3,179,247,89,54,219,24,241,252,0,140,41,194,182,239,195,184,155,1,215,225,131,68,88,116,211,19,189,60,198,62,64,175,210,15,13,2,250,67,67,31,36,141,148,58,104,60,138,19,65,208,35,59,161,176,239,162,9,227,126,174,206,218,193,2,120,202,13,120,63,244,177,170,245,29,253,121,47,30,93,213,95,67,76,35,15,218,174,142,137,235,153,112,58,89,152,198,9,245,217,81,140,9,128,113,6,45,59,106,14,115,1,231,251,104,17,70,139,32,176,157,214,110,29,149,87,184,14,222,133,214,29,108,64,112,31,4,15,121,153,201,7,86,186,253,234,91,222,11,101,37,74,161,154,182,71,157,66,202,251,186,194,141,123,205,191,11,59,196,186,35,113,120,230,255,155,194,174,192,232,122,209,210,105,81,226,72,158,79,242,50,119,218,161,149,216,192,114,41,83,145,244,118,232,139,144,156,245,150,234,25,68,248,162,111,96,52,100,171,245,130,88,141,201,186,247,211,51,116,105,201,139,226,150,167,247,115,190,78,163,187,140,250,72,159,63,159,225,133,36,207,156,176,20,62,232,145,4,197,163,96,226,137,68,69,139,253,62,116,222,160,62,14,89,98,91,130,186,206,112,107,202,182,106,55,47,228,96,199,96,129,255,180,158,36,227,196,210,35,122,145,181,9,119,112,187,245,221,61,29,206,241,133,206,31,76,220,172,201,103,176,198,234,162,104,186,115,35,149,224,233,29,161,159,252,84,94,243,92,29,4,144,27,177,37,121,57,202,88,187,216,143,25,196,93,96,120,94,106,48,64,145,135,193,71,119,39,4,115,122,171,6,187,134,44,217,111,43,119,197,8,246,68,20,90,120,18,2,63,179,60,118,49,54,92,113,143,41,106,168,186,155,166,25,251,218,93,148,70,252,48,159,236,180,207,21,2,200,170,155,14,140,107,58,34,231,46,195,228,237,224,153,65,94,63,137,229,224,42,196,28,63,243,132,87,250,51,24,248,75,89,98,58,244,182,75,173,27,100,173,161,187,252,186,31,61,0,146,238,112,53,36,89,19,120,80,204,223,116,62,115,61,242,213,124,79,98,253,230,14,61,209,19,252,58,239,135,52,124,36,236,113,16,169,155,83,93,225,95,140,226,171,80,138,107,185,49,240,72,100,223,196,45,146,41,89,104,134,128,136,45,11,169,221,203,87,9,83,171,146,24,5,77,246,63,245,142,63,210,235,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLookupRecordSelectedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3728ddf9-fc38-41d1-94b6-afe3054287cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925ac25c-a209-4e33-be46-2617cfa6edfe"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LookupRecordSelected",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"LookupRecordSelectedMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 104),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("abadf3e4-185e-4b33-8bf4-ff46f748d28f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b210c59-34e9-4556-85a4-bf804840d69b"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"EventSubProcess9",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("71dcfbd7-a3fe-45b7-8077-98935c6f0e18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("abadf3e4-185e-4b33-8bf4-ff46f748d28f"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"CancelButtonClickMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bd1d6ce9-b1a8-413d-bb38-477c29df2eda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("abadf3e4-185e-4b33-8bf4-ff46f748d28f"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"CancelScript",
				Position = new Point(211, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7562e6e0-751b-4ee3-beca-8ac811081dd6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b6034c3-b19f-4c44-b31d-d09794abadc4"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 167),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(546, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("96cfb20c-b131-4bfe-80be-0518ecf2a633"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7562e6e0-751b-4ee3-beca-8ac811081dd6"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageLoadCompleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a8d12272-8887-43e3-9f46-6c0e1d6ac915"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7562e6e0-751b-4ee3-beca-8ac811081dd6"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,247,77,204,78,117,78,44,40,201,204,207,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,7,82,201,79,30,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b0f6e68d-a4d4-4c68-a0fa-9ff422bc1ab5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7562e6e0-751b-4ee3-beca-8ac811081dd6"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageLoadCompleteThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(337, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("52750028-9e5a-4461-a830-e6d8fef2c690"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b6034c3-b19f-4c44-b31d-d09794abadc4"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 329),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(546, 191),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6846c4cc-625b-4009-84be-3d0fd134c666"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52750028-9e5a-4461-a830-e6d8fef2c690"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageLoadMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 91),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7bcb1594-f3fc-4a8f-90b8-144958d431e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52750028-9e5a-4461-a830-e6d8fef2c690"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageLoadIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 91),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d240d863-e67d-4c7f-9c5b-42ef069aaea1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52750028-9e5a-4461-a830-e6d8fef2c690"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"PageLoadScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,93,111,218,48,20,125,78,165,254,135,11,79,142,132,220,247,161,106,162,129,117,72,235,199,70,183,61,123,201,5,188,58,118,176,29,86,180,242,223,231,15,2,33,133,77,67,65,65,55,247,156,123,206,185,14,124,14,164,55,121,177,116,106,70,63,217,203,23,92,213,104,108,10,191,47,47,18,99,53,151,11,192,130,219,59,85,32,92,3,137,165,244,145,45,144,222,162,125,100,154,149,104,81,127,99,162,70,210,111,90,251,233,208,225,167,102,114,128,70,164,27,115,95,11,241,160,39,101,101,55,164,233,79,225,61,204,153,48,8,239,32,83,114,141,218,210,39,117,163,148,64,38,15,93,158,116,134,118,204,77,37,216,198,53,90,173,132,33,161,238,174,53,211,96,144,233,124,25,228,184,161,187,150,175,150,11,110,57,26,250,209,150,98,140,185,35,35,255,242,210,98,234,167,97,4,159,147,222,73,27,173,214,52,70,151,92,93,205,66,241,81,243,146,233,205,94,178,168,75,217,168,107,193,60,125,208,207,114,203,215,56,102,150,205,84,173,115,223,230,180,141,58,213,104,57,0,242,90,107,148,118,102,117,157,219,90,123,64,151,131,102,157,158,61,88,226,175,15,92,56,207,14,213,37,162,153,70,102,49,62,255,206,237,114,31,144,33,111,38,204,242,37,150,108,0,158,216,125,34,40,83,101,197,52,55,74,62,109,42,164,147,85,205,196,224,173,186,136,165,167,146,162,247,110,226,160,29,84,58,132,70,252,170,230,249,243,121,249,241,137,113,119,89,220,108,60,17,233,127,62,64,226,17,245,59,61,226,185,6,233,22,187,91,98,114,80,217,56,18,2,157,126,37,97,30,233,33,2,2,87,114,168,253,53,76,115,171,85,93,29,171,25,192,39,181,224,57,19,15,21,106,230,39,56,44,207,45,29,201,34,29,38,109,122,58,42,10,178,223,92,180,145,156,181,239,155,201,180,107,100,106,177,76,27,15,145,98,11,128,254,13,140,206,143,82,97,6,206,39,145,210,204,189,165,122,119,36,255,11,120,194,200,246,242,194,223,230,202,229,149,47,129,248,69,71,153,192,229,217,37,55,251,114,219,60,249,130,70,134,112,154,82,120,125,133,94,171,16,207,165,233,28,14,199,24,67,223,165,238,8,39,146,253,16,88,184,237,134,191,170,104,119,187,19,29,190,225,114,63,238,216,51,102,172,242,38,67,44,26,157,88,9,78,53,14,255,0,165,158,67,29,113,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7dec6403-1072-4b43-90c0-dea997da7e08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4131e080-76a4-4767-badf-7bd90a6df9a2"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"EventSubProcess12",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(383, 172),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTuningModeButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9a083439-d657-451f-a340-6266fc2ebbd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dec6403-1072-4b43-90c0-dea997da7e08"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TuningModeChanged",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"TuningModeButtonClickMessage",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("26dc5a76-3b6f-4acd-bb9c-c8cca2d85b78"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dec6403-1072-4b43-90c0-dea997da7e08"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"TuningModeChanged",
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTuningModeMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ac656614-90ca-4927-aa78-6741201bc4ae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dec6403-1072-4b43-90c0-dea997da7e08"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				Name = @"TuningModeMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,205,106,195,48,16,132,207,54,248,29,84,159,100,48,74,239,166,135,180,164,196,135,4,211,248,5,68,180,73,5,182,100,164,117,126,8,121,247,110,253,147,80,74,124,201,81,51,223,238,206,104,54,203,253,202,170,182,130,194,217,45,120,15,190,108,141,54,123,18,129,189,177,151,9,59,139,194,131,116,172,38,89,238,33,87,132,199,120,115,87,189,28,19,229,209,145,56,130,132,245,130,88,212,13,158,201,215,59,198,39,238,36,236,18,133,193,191,233,79,235,106,137,60,190,188,94,227,244,78,127,200,6,181,53,162,180,155,142,227,73,146,5,52,95,208,176,120,151,126,12,86,72,3,149,248,130,218,30,128,223,58,36,217,67,116,174,212,240,190,227,41,209,65,240,39,121,110,60,74,179,133,181,197,197,73,123,28,242,164,99,253,148,13,91,202,115,3,34,55,187,174,6,17,19,167,55,223,246,200,127,253,43,131,202,67,247,31,79,247,89,106,5,253,210,40,116,128,173,51,12,93,11,217,15,92,75,247,175,19,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetDisplayControlsMethod());
			Methods.Add(CreateMakeCaptionMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a8d2abf8-07ab-4e55-8690-1a75dfa0f6da"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d6630e4d-7a19-48f1-9051-b7afb4319d94"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9eaf8c85-25b4-4106-b135-2ce7c11e0517"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80e9a624-774f-4aa9-bdc1-372108d985e1"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("66c04ada-c3e9-49ab-83a7-051f50d29d99"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1f380c2-17a6-4748-871a-be4cb513b6b0"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cafacd03-d1a2-43da-8fb1-db3dc13351a7"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8a52f61f-eae7-4d4d-8095-62319ae446eb"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f54c9c05-732e-45af-939f-13fc737c792b"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdc1f75a-bdaa-4bb9-913e-3e80b88105af"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7e624e1a-9617-4102-957b-d7222d4aa9d1"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateSetDefaultModuleParametersMethod() {
			SchemaMethod method = base.CreateSetDefaultModuleParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,93,79,219,48,20,125,14,18,255,193,228,1,37,90,21,64,60,76,140,81,9,58,62,42,81,232,86,216,30,166,61,152,198,161,214,146,184,179,29,88,52,248,239,243,71,18,199,137,71,43,237,67,235,75,84,231,250,220,235,115,207,185,206,206,206,205,245,187,107,176,247,122,127,247,224,96,160,159,123,155,27,56,1,193,172,100,19,18,23,41,26,199,224,232,8,156,23,56,142,78,179,37,47,67,240,99,115,195,123,128,20,160,156,99,94,206,230,11,148,193,9,204,225,61,162,224,8,76,197,51,210,139,145,245,110,74,201,3,142,17,141,206,17,175,150,2,255,180,143,225,135,0,50,112,131,40,133,140,36,60,26,17,138,34,21,135,17,139,28,27,14,29,245,188,47,16,45,69,53,57,122,4,167,221,245,192,81,249,0,248,205,145,253,176,130,244,150,20,103,144,150,35,146,22,89,126,5,51,36,32,123,105,162,227,56,214,17,65,255,221,7,66,120,197,134,56,247,180,139,23,132,97,36,159,50,97,127,243,25,78,57,162,76,38,112,64,143,40,130,28,233,152,79,152,47,166,144,10,36,185,33,208,139,35,146,45,33,197,140,228,55,229,82,112,248,173,128,233,64,36,242,60,121,86,217,40,13,119,59,142,253,129,213,56,177,18,134,22,175,130,123,231,217,197,161,52,191,226,76,41,154,115,76,242,224,150,201,220,121,174,255,42,28,41,169,26,71,116,180,200,57,24,130,93,173,37,207,210,90,147,238,243,238,23,137,46,75,175,232,253,8,211,2,189,149,82,28,6,189,206,168,52,207,155,27,207,125,253,110,181,245,11,182,183,65,112,70,82,161,68,81,56,45,219,234,184,237,138,29,60,61,129,38,246,229,48,145,176,29,211,179,141,241,77,162,0,71,36,70,150,174,124,157,72,84,141,34,249,210,119,233,218,248,204,38,89,50,101,69,188,96,173,127,106,33,11,114,92,53,114,133,139,12,140,206,27,117,184,149,122,109,240,13,155,147,134,209,21,248,174,6,52,120,11,200,142,21,165,108,109,215,251,23,205,30,223,216,89,130,205,187,77,126,17,70,117,221,0,244,72,175,93,93,27,13,36,122,62,56,113,171,217,33,129,146,191,48,70,128,175,134,70,203,102,127,118,96,48,78,113,126,223,234,174,116,200,21,201,141,45,88,157,186,122,171,119,104,183,217,226,171,184,159,117,2,86,205,164,174,157,215,156,76,46,193,71,141,196,250,158,224,40,235,16,85,249,73,230,144,111,79,74,33,248,64,205,109,249,251,221,42,116,25,22,51,221,122,26,9,122,22,255,171,50,235,14,12,3,151,37,91,12,116,27,183,46,236,188,111,88,207,56,79,0,109,173,66,186,35,36,29,6,46,135,215,183,135,167,135,176,44,80,150,102,78,82,11,166,82,217,152,93,21,105,122,77,149,152,2,67,102,53,230,61,138,120,65,243,26,84,110,220,114,238,180,184,168,55,91,189,177,34,106,64,51,248,102,69,146,224,239,230,250,240,237,185,168,174,56,19,51,206,91,81,236,17,243,249,2,180,218,85,229,159,67,134,196,44,23,213,166,168,117,83,250,111,148,6,229,97,214,184,19,43,44,207,251,69,44,104,110,44,241,247,68,157,182,197,35,120,101,157,79,55,91,29,221,243,238,196,192,250,122,104,10,157,20,41,199,255,97,157,86,1,43,62,52,250,85,56,54,172,89,74,171,231,117,61,158,147,56,53,78,53,89,234,227,239,18,37,92,140,97,78,73,122,9,75,82,240,232,2,199,49,146,215,41,167,133,30,8,6,68,126,107,253,4,237,121,205,168,65,12,0,0 };
			return method;
		}

		protected override SchemaMethod CreateDisplayDetailsTabPanelMethod() {
			SchemaMethod method = base.CreateDisplayDetailsTabPanelMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,240,44,118,77,201,44,241,205,79,73,213,76,74,44,78,213,115,201,44,46,200,73,172,116,73,45,73,204,204,41,14,73,76,10,72,204,75,205,209,40,206,200,47,215,180,6,0,118,48,41,188,48,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDisplayControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5dcf63c0-226e-4b06-b7dd-3714230ba43a"),
				Name = "SetDisplayControls",
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,81,107,194,48,16,199,159,45,244,59,68,159,90,145,86,6,123,42,62,140,234,92,153,206,177,186,15,16,205,169,129,216,148,36,157,136,248,221,151,198,232,86,237,84,216,99,114,255,203,253,127,119,151,176,45,149,160,217,18,45,184,88,99,149,30,14,61,212,218,117,247,193,138,18,240,252,86,228,58,95,88,32,57,23,52,87,58,54,4,245,1,75,42,21,136,39,66,222,241,18,82,19,242,6,132,170,242,248,153,144,14,74,183,114,204,73,193,160,188,45,47,134,5,37,193,96,157,171,173,31,53,92,135,46,144,215,60,20,15,18,249,86,48,54,17,38,234,29,10,249,62,218,185,78,163,124,47,208,101,108,9,155,240,108,220,122,191,77,119,208,81,58,134,172,72,20,172,131,152,81,200,84,210,239,160,227,147,26,101,223,14,93,39,12,141,120,4,11,21,243,76,9,206,70,120,203,11,21,196,156,49,156,75,58,99,160,73,149,40,32,42,173,122,137,44,49,52,16,248,174,115,242,213,7,133,41,147,83,60,123,199,25,176,32,93,241,141,87,22,57,132,39,175,49,206,230,192,170,37,94,76,87,163,91,108,102,2,27,74,212,170,247,240,216,109,89,188,26,199,22,210,192,53,254,4,59,89,219,187,14,48,9,87,40,206,12,214,83,156,161,222,65,241,127,134,147,49,205,96,36,67,65,73,197,182,29,31,76,57,103,122,126,205,159,177,69,181,41,88,166,57,163,74,111,178,86,87,196,214,68,69,94,93,142,58,249,165,231,68,214,174,212,173,5,4,114,97,223,166,92,237,244,220,102,235,95,123,79,179,191,1,44,52,170,72,254,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e7c84871-5a59-4fa0-8087-176c5917a4cf"),
				Name = "MakeCaption",
				CreatedInSchemaUId = new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,41,202,204,75,87,72,78,44,40,201,204,207,83,176,85,240,44,246,205,79,41,205,73,13,40,202,79,78,45,46,78,45,14,41,205,3,170,0,10,166,218,23,131,21,235,185,229,23,229,38,150,104,56,40,85,27,212,42,104,84,27,214,106,42,233,4,36,166,167,58,67,12,209,11,201,15,6,43,212,208,212,65,104,198,148,212,180,194,174,201,154,151,75,3,36,163,231,88,92,0,162,21,18,139,21,66,82,139,138,18,139,243,211,74,244,66,61,245,194,83,147,156,243,243,74,138,242,115,138,245,64,10,52,245,156,225,206,135,122,196,26,0,190,33,147,167,216,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductSectionPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b08cc6e-f4b4-44f4-9704-e7f856d1e31f"));
		}

		#endregion

	}

	#endregion

}

