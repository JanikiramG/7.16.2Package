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
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: BaseManyToManyGridPageSchema

	/// <exclude/>
	public class BaseManyToManyGridPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _parentTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel ParentTabPanel {
			get {
				return _parentTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _parentTab;
		public Terrasoft.UI.WebControls.Controls.Tab ParentTab {
			get {
				return _parentTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _detailTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel DetailTabPanel {
			get {
				return _detailTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _detailTab;
		public Terrasoft.UI.WebControls.Controls.Tab DetailTab {
			get {
				return _detailTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return _buttonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _closeButton;
		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return _closeButton;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseManyToManyGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseManyToManyGridPageSchema(BaseManyToManyGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			RealUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			Name = "BaseManyToManyGridPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 800;
			Height = 600;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseManyToManyGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateParentTabPanel());
			ParentTabPanel.InsertItem(0, CreateParentTab());
			Controls.AddAt(2, CreateDetailTabPanel());
			DetailTabPanel.InsertItem(0, CreateDetailTab());
			Controls.AddAt(3, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateSpacer1());
			ButtonsControlLayout.InsertItem(1, CreateCloseButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseManyToManyGridPageEventsProcessSchema() {
			var schema = new BaseManyToManyGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("b9c7030f-a9e6-4b3b-8450-1c9cc0903a21");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateParentTab() {
			_parentTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_parentTab.UId = new Guid("4a9ccdd4-71ba-4a15-aa4e-df17e8d6b5dd");
			_parentTab.Name = "ParentTab";
			_parentTab.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_parentTab.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_parentTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_parentTab.Tag = "";
			_parentTab.Image = new ControlImage {};
			return _parentTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateParentTabPanel() {
			_parentTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_parentTabPanel.UId = new Guid("151cfcde-1100-4985-8674-f22ee8fe5019");
			_parentTabPanel.Name = "ParentTabPanel";
			_parentTabPanel.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_parentTabPanel.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_parentTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_parentTabPanel.Tag = "";
			_parentTabPanel.ActiveTabIndex = 0;
			_parentTabPanel.HasSplitter = true;
			_parentTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_parentTabPanel.StartNewAlignGroup = false;
			_parentTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _parentTabPanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateDetailTab() {
			_detailTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_detailTab.UId = new Guid("cafbff38-a5bc-4170-b08b-8ced432567dc");
			_detailTab.Name = "DetailTab";
			_detailTab.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_detailTab.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_detailTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailTab.Tag = "";
			_detailTab.Image = new ControlImage {};
			return _detailTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateDetailTabPanel() {
			_detailTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_detailTabPanel.UId = new Guid("fceeb00a-656a-4660-859c-c6d6a166a322");
			_detailTabPanel.Name = "DetailTabPanel";
			_detailTabPanel.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_detailTabPanel.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_detailTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailTabPanel.Tag = "";
			_detailTabPanel.ActiveTabIndex = 0;
			_detailTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailTabPanel.StartNewAlignGroup = false;
			_detailTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _detailTabPanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("7570ab53-32d9-4367-85da-c3fffcf5208d");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_spacer1.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCloseButton() {
			_closeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_closeButton.UId = new Guid("9c73a8f4-a0e1-4751-bbfb-3cbeb821466c");
			_closeButton.Name = "CloseButton";
			_closeButton.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_closeButton.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_closeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_closeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_closeButton.Tag = "";
			_closeButton.Image = new ControlImage {};
			return _closeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("5cd6f7b8-5b71-41a0-8972-23fb4fb73867");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			_buttonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "";
			return _buttonsControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseManyToManyGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseManyToManyGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseManyToManyGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseManyToManyGridPageEventsProcess

	/// <exclude/>
	public class BaseManyToManyGridPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
	{

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public BaseManyToManyGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseManyToManyGridPageEventsProcess";
			SchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
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

		public virtual Guid DetailEntitySchemaId {
			get;
			set;
		}

		public virtual Guid ParentEntitySchemaId {
			get;
			set;
		}

		public virtual Guid DetailGridPageSchemaId {
			get;
			set;
		}

		public virtual Guid ParentGridPageSchemaId {
			get;
			set;
		}

		public virtual Guid DetailAssociationColumnUId {
			get;
			set;
		}

		public virtual Guid ParentPrimaryColumnValue {
			get;
			set;
		}

		public virtual Guid DetailSelectionColumnUId {
			get;
			set;
		}

		public virtual bool IsEntityDetail {
			get;
			set;
		}

		public virtual Object MainPage {
			get;
			set;
		}

		public virtual Guid MainPageProcessUId {
			get;
			set;
		}

		private ProcessFlowElement _baseManyToManyGridPageInitSubProcess;
		public ProcessFlowElement BaseManyToManyGridPageInitSubProcess {
			get {
				return _baseManyToManyGridPageInitSubProcess ?? (_baseManyToManyGridPageInitSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseManyToManyGridPageInitSubProcess",
					SchemaElementUId = new Guid("a3e50ea2-b303-4e5b-83b4-196348a031fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseManyToManyGridPageInitStartMessage;
		public ProcessFlowElement BaseManyToManyGridPageInitStartMessage {
			get {
				return _baseManyToManyGridPageInitStartMessage ?? (_baseManyToManyGridPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseManyToManyGridPageInitStartMessage",
					SchemaElementUId = new Guid("c5a25da1-b8b1-4136-8142-defa6a4dcb51"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseManyToManyGridPageInitScriptTask;
		public ProcessScriptTask BaseManyToManyGridPageInitScriptTask {
			get {
				return _baseManyToManyGridPageInitScriptTask ?? (_baseManyToManyGridPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseManyToManyGridPageInitScriptTask",
					SchemaElementUId = new Guid("355e2114-cbc3-4449-a279-cf0351eb78a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseManyToManyGridPageInitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _parentPrimaryColumnChangedSubProcess;
		public ProcessFlowElement ParentPrimaryColumnChangedSubProcess {
			get {
				return _parentPrimaryColumnChangedSubProcess ?? (_parentPrimaryColumnChangedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ParentPrimaryColumnChangedSubProcess",
					SchemaElementUId = new Guid("3c92ecd9-c044-45d0-a9ca-8cd2891d94bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseManyToManyGridPageGridActiveRowChangedStartMessage;
		public ProcessFlowElement BaseManyToManyGridPageGridActiveRowChangedStartMessage {
			get {
				return _baseManyToManyGridPageGridActiveRowChangedStartMessage ?? (_baseManyToManyGridPageGridActiveRowChangedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseManyToManyGridPageGridActiveRowChangedStartMessage",
					SchemaElementUId = new Guid("d9e963c7-07be-4ccf-b760-5f13f7c8ea82"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseManyToManyGridPageParentPrimaryColumnChangedScriptTask;
		public ProcessScriptTask BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask {
			get {
				return _baseManyToManyGridPageParentPrimaryColumnChangedScriptTask ?? (_baseManyToManyGridPageParentPrimaryColumnChangedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask",
					SchemaElementUId = new Guid("92c5e434-ef73-4777-80e9-25f3c7d06cbf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseManyToManyGridPageParentPrimaryColumnChangedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _gridLoadRowsStartMessage;
		public ProcessFlowElement GridLoadRowsStartMessage {
			get {
				return _gridLoadRowsStartMessage ?? (_gridLoadRowsStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridLoadRowsStartMessage",
					SchemaElementUId = new Guid("e0f99bb8-02f9-4fc9-abab-8d30116f5c6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _closeButtonClickSubProcess;
		public ProcessFlowElement CloseButtonClickSubProcess {
			get {
				return _closeButtonClickSubProcess ?? (_closeButtonClickSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CloseButtonClickSubProcess",
					SchemaElementUId = new Guid("96ebda39-33c8-4a46-800e-5d3f0a835e8e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseManyToManyGridPageCloseButtonClickStartMessage;
		public ProcessFlowElement BaseManyToManyGridPageCloseButtonClickStartMessage {
			get {
				return _baseManyToManyGridPageCloseButtonClickStartMessage ?? (_baseManyToManyGridPageCloseButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseManyToManyGridPageCloseButtonClickStartMessage",
					SchemaElementUId = new Guid("3d01ba1f-2d8b-42d4-be04-bf087ffe1d39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseManyToManyGridPageCloseButtonClickScriptTask;
		public ProcessScriptTask BaseManyToManyGridPageCloseButtonClickScriptTask {
			get {
				return _baseManyToManyGridPageCloseButtonClickScriptTask ?? (_baseManyToManyGridPageCloseButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseManyToManyGridPageCloseButtonClickScriptTask",
					SchemaElementUId = new Guid("a15f2dd0-7a4f-4025-8260-19c3920cb362"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseManyToManyGridPageCloseButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _base2EventSubProcess1;
		public ProcessFlowElement Base2EventSubProcess1 {
			get {
				return _base2EventSubProcess1 ?? (_base2EventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "Base2EventSubProcess1",
					SchemaElementUId = new Guid("a9f2f02f-9190-4cae-b269-9e79c770c117"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _base2StartMessage1;
		public ProcessFlowElement Base2StartMessage1 {
			get {
				return _base2StartMessage1 ?? (_base2StartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Base2StartMessage1",
					SchemaElementUId = new Guid("20023c1f-99fb-40f9-af8d-b64f1abe00c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _base2IntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent Base2IntermediateThrowMessageEvent1 {
			get {
				return _base2IntermediateThrowMessageEvent1 ?? (_base2IntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "Base2IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("0d9039c2-1395-48df-a620-b25b7fe74828"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _base2_PageLoadCompleteScriptTask;
		public ProcessScriptTask Base2_PageLoadCompleteScriptTask {
			get {
				return _base2_PageLoadCompleteScriptTask ?? (_base2_PageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Base2_PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("f4e8e054-305e-4320-b450-21dab32e0eb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Base2_PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseManyToManyGridPageInitSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyGridPageInitSubProcess };
			FlowElements[BaseManyToManyGridPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyGridPageInitStartMessage };
			FlowElements[BaseManyToManyGridPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyGridPageInitScriptTask };
			FlowElements[ParentPrimaryColumnChangedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ParentPrimaryColumnChangedSubProcess };
			FlowElements[BaseManyToManyGridPageGridActiveRowChangedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyGridPageGridActiveRowChangedStartMessage };
			FlowElements[BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask };
			FlowElements[GridLoadRowsStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { GridLoadRowsStartMessage };
			FlowElements[CloseButtonClickSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseButtonClickSubProcess };
			FlowElements[BaseManyToManyGridPageCloseButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyGridPageCloseButtonClickStartMessage };
			FlowElements[BaseManyToManyGridPageCloseButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyGridPageCloseButtonClickScriptTask };
			FlowElements[Base2EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { Base2EventSubProcess1 };
			FlowElements[Base2StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { Base2StartMessage1 };
			FlowElements[Base2IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { Base2IntermediateThrowMessageEvent1 };
			FlowElements[Base2_PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Base2_PageLoadCompleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseManyToManyGridPageInitSubProcess":
						break;
					case "BaseManyToManyGridPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("BaseManyToManyGridPageInitScriptTask");
						break;
					case "BaseManyToManyGridPageInitScriptTask":
						break;
					case "ParentPrimaryColumnChangedSubProcess":
						break;
					case "BaseManyToManyGridPageGridActiveRowChangedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask");
						break;
					case "BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask":
						break;
					case "GridLoadRowsStartMessage":
						e.Context.QueueTasks.Enqueue("BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask");
						break;
					case "CloseButtonClickSubProcess":
						break;
					case "BaseManyToManyGridPageCloseButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("BaseManyToManyGridPageCloseButtonClickScriptTask");
						break;
					case "BaseManyToManyGridPageCloseButtonClickScriptTask":
						break;
					case "Base2EventSubProcess1":
						break;
					case "Base2StartMessage1":
						e.Context.QueueTasks.Enqueue("Base2IntermediateThrowMessageEvent1");
						break;
					case "Base2IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("Base2_PageLoadCompleteScriptTask");
						break;
					case "Base2_PageLoadCompleteScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseManyToManyGridPageInitStartMessage");
			ActivatedEventElements.Add("BaseManyToManyGridPageGridActiveRowChangedStartMessage");
			ActivatedEventElements.Add("GridLoadRowsStartMessage");
			ActivatedEventElements.Add("BaseManyToManyGridPageCloseButtonClickStartMessage");
			ActivatedEventElements.Add("Base2StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseManyToManyGridPageInitSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseManyToManyGridPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyGridPageInitStartMessage";
					result = BaseManyToManyGridPageInitStartMessage.Execute(context);
					break;
				case "BaseManyToManyGridPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyGridPageInitScriptTask";
					result = BaseManyToManyGridPageInitScriptTask.Execute(context, BaseManyToManyGridPageInitScriptTaskExecute);
					break;
				case "ParentPrimaryColumnChangedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseManyToManyGridPageGridActiveRowChangedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyGridPageGridActiveRowChangedStartMessage";
					result = BaseManyToManyGridPageGridActiveRowChangedStartMessage.Execute(context);
					break;
				case "BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask";
					result = BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask.Execute(context, BaseManyToManyGridPageParentPrimaryColumnChangedScriptTaskExecute);
					break;
				case "GridLoadRowsStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridLoadRowsStartMessage";
					result = GridLoadRowsStartMessage.Execute(context);
					break;
				case "CloseButtonClickSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseManyToManyGridPageCloseButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyGridPageCloseButtonClickStartMessage";
					result = BaseManyToManyGridPageCloseButtonClickStartMessage.Execute(context);
					break;
				case "BaseManyToManyGridPageCloseButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyGridPageCloseButtonClickScriptTask";
					result = BaseManyToManyGridPageCloseButtonClickScriptTask.Execute(context, BaseManyToManyGridPageCloseButtonClickScriptTaskExecute);
					break;
				case "Base2EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "Base2StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "Base2StartMessage1";
					result = Base2StartMessage1.Execute(context);
					break;
				case "Base2IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = Base2IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "Base2_PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Base2_PageLoadCompleteScriptTask";
					result = Base2_PageLoadCompleteScriptTask.Execute(context, Base2_PageLoadCompleteScriptTaskExecute);
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
				case "MainPageProcessUId":
					MainPageProcessUId = reader.GetValue<System.Guid>();
				break;
				case "IsEntityDetail":
					IsEntityDetail = reader.GetValue<System.Boolean>();
				break;
				case "DetailSelectionColumnUId":
					DetailSelectionColumnUId = reader.GetValue<System.Guid>();
				break;
				case "ParentPrimaryColumnValue":
					ParentPrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "DetailAssociationColumnUId":
					DetailAssociationColumnUId = reader.GetValue<System.Guid>();
				break;
				case "ParentGridPageSchemaId":
					ParentGridPageSchemaId = reader.GetValue<System.Guid>();
				break;
				case "DetailGridPageSchemaId":
					DetailGridPageSchemaId = reader.GetValue<System.Guid>();
				break;
				case "ParentEntitySchemaId":
					ParentEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "DetailEntitySchemaId":
					DetailEntitySchemaId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool BaseManyToManyGridPageInitScriptTaskExecute(ProcessExecutingContext context) {
			// Property for correct error massage display from base grid page
			MainPage = Page;
			
			// Add parent page container with grid page
			if (ParentGridPageSchemaId != Guid.Empty && ParentEntitySchemaId != Guid.Empty) {
				var parentPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer() {
					UId = Guid.NewGuid(),
					Name = "ParentPageContainer",
					PageSchemaUId = ParentGridPageSchemaId,
					Height = Unit.Percentage(100),
					Width = Unit.Percentage(100) };
				Page.ParentTab.InsertItem(0, parentPageContainer);
				parentPageContainer.PageInstance.Process.SetPropertyValue("EntitySchemaUId", ParentEntitySchemaId);
				parentPageContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			
				// Set parent tab caption
				var entitySchema = UserConnection.EntitySchemaManager.GetItemByUId(ParentEntitySchemaId);
				if (String.IsNullOrEmpty(Page.ParentTab.Caption)) {
					Page.ParentTab.Caption = entitySchema.Caption;
				}
			}
			
			// Add detail page container with grid page
			if (DetailGridPageSchemaId != Guid.Empty && DetailEntitySchemaId != Guid.Empty) {
				var detailPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer() {
					UId = Guid.NewGuid(),
					Name = "DetailPageContainer",
					PageSchemaUId = DetailGridPageSchemaId,
					Height = Unit.Percentage(100),
					Width = Unit.Percentage(100) };
				Page.DetailTab.InsertItem(0, detailPageContainer);
				detailPageContainer.PageInstance.Process.SetPropertyValue("EntitySchemaUId", DetailEntitySchemaId);
				detailPageContainer.PageInstance.Process.SetPropertyValue("IsEntityDetail", IsEntityDetail);
				detailPageContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			
				// TODO: Remove after parameters ambiguity with EntitySchemaUId and SysEntitySchemaId is resolved
				detailPageContainer.PageInstance.Process.SetPropertyValue("SysEntitySchemaId", DetailEntitySchemaId);
				
				// Set detail tab caption
				var entitySchema = UserConnection.EntitySchemaManager.GetItemByUId(DetailEntitySchemaId);
				if (String.IsNullOrEmpty(Page.DetailTab.Caption)) {
					Page.DetailTab.Caption = entitySchema.Caption;
				}
			}
			return true;
		}

		public virtual bool BaseManyToManyGridPageParentPrimaryColumnChangedScriptTaskExecute(ProcessExecutingContext context) {
			var parentTab = Page.ParentTabPanel.Tabs[Page.ParentTabPanel.ActiveTabIndex];
			var parentItem = parentTab.FindPageControlByName("DataSource") as DataSource;
			ParentPrimaryColumnValue = parentItem.ActiveRowPrimaryColumnValue;
			
			var detailTab = Page.DetailTabPanel.Tabs[Page.DetailTabPanel.ActiveTabIndex];
			var detailItem = detailTab.FindPageControlByName("DetailPageContainer") as PageContainer;
			detailItem.PageInstance.ThrowEvent("ParentActiveRowChanged");
			return true;
		}

		public virtual bool BaseManyToManyGridPageCloseButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool Base2_PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var dataSourceControl = Page.ParentTab.FindPageControlByName("DataSource");
			if (dataSourceControl != null) {
				var dataSource = dataSourceControl as DataSource;
				(Page.AspPage as Terrasoft.UI.WebControls.Page).CustomData["SysModule_activeDataSource"] = dataSource.ClientID;
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("BaseManyToManyGridPageInitStartMessage")) {
							context.QueueTasks.Enqueue("BaseManyToManyGridPageInitStartMessage");
						}
						break;
					case "GridActiveRowChanged":
							if (ActivatedEventElements.Contains("BaseManyToManyGridPageGridActiveRowChangedStartMessage")) {
							context.QueueTasks.Enqueue("BaseManyToManyGridPageGridActiveRowChangedStartMessage");
						}
						break;
					case "GridLoadRows":
							if (ActivatedEventElements.Contains("GridLoadRowsStartMessage")) {
							context.QueueTasks.Enqueue("GridLoadRowsStartMessage");
						}
						break;
					case "CloseButtonClick":
							if (ActivatedEventElements.Contains("BaseManyToManyGridPageCloseButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("BaseManyToManyGridPageCloseButtonClickStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("Base2StartMessage1")) {
							context.QueueTasks.Enqueue("Base2StartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("MainPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MainPageProcessUId", MainPageProcessUId, Guid.Empty);
			}
			if (!HasMapping("IsEntityDetail") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEntityDetail", IsEntityDetail, false);
			}
			if (!HasMapping("DetailSelectionColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DetailSelectionColumnUId", DetailSelectionColumnUId, Guid.Empty);
			}
			if (!HasMapping("ParentPrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentPrimaryColumnValue", ParentPrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("DetailAssociationColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DetailAssociationColumnUId", DetailAssociationColumnUId, Guid.Empty);
			}
			if (!HasMapping("ParentGridPageSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentGridPageSchemaId", ParentGridPageSchemaId, Guid.Empty);
			}
			if (!HasMapping("DetailGridPageSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DetailGridPageSchemaId", DetailGridPageSchemaId, Guid.Empty);
			}
			if (!HasMapping("ParentEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentEntitySchemaId", ParentEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("DetailEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DetailEntitySchemaId", DetailEntitySchemaId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseManyToManyGridPageEventsProcess

	/// <exclude/>
	public class BaseManyToManyGridPageEventsProcess : BaseManyToManyGridPageEventsProcess<Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl>
	{

		public BaseManyToManyGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseManyToManyGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseManyToManyGridPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel ParentTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("ParentTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab ParentTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("ParentTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel DetailTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("DetailTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab DetailTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("DetailTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CloseButton", true);
			}
		}

		private Terrasoft.UI.WebControls.Controls.ScriptManager _scriptManager;
		public Terrasoft.UI.WebControls.Controls.ScriptManager ScriptManager {
			get {
				if (this._scriptManager != null) {
					return this._scriptManager;
				}
				if (!this.DesignMode && this.Page != null) {
					this._scriptManager = ScriptManager.GetCurrent(this.Page);
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
				}
				if (this.Page != null) {
					this._scriptManager = ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManagerProxy") as ScriptManager;
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
					this._scriptManager = (ScriptManager)ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManager");
					if (this.DesignMode && this._scriptManager == null) {
						this._scriptManager = new ScriptManager();
						this.Page.Controls.Add(this._scriptManager);
					}
				}
				if (this._scriptManager == null) {
					throw new InvalidOperationException("The Terrasoft Script Manager Control " +
						"is missing from this Page." +
						Environment.NewLine + Environment.NewLine +
						"Please add the following Script Manager tag inside the <body> or " +
						"<form> of this Page." +
						Environment.NewLine + Environment.NewLine + "Example" +
						Environment.NewLine + Environment.NewLine +
						" <ext:Script Manager runat=\"server\" />");
				}
				return this._scriptManager;
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PageLoadComplete(object sender, EventArgs e) {
			if (!((PageContainer)PageContainer).IsPageLoadCompleted) {
				((PageContainer)PageContainer).IsPageLoadCompleted = true;
				ThrowEvent("PageLoadComplete");
			}
		}

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			CloseButton.AjaxEvents.Click.Event += CloseButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			CloseButton.AjaxEvents.Click.Event -= CloseButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseManyToManyGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseManyToManyGridPageEventsProcess(UserConnection);
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

		public virtual void CloseButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CloseButtonClick");
		}

		public virtual void ThrowClientEvent(string message, params object[] parameters) {
			string key = CopyParameters(parameters);
			ScriptManager.AddScript("if (window.opener) { if (window.key) {window.opener.Terrasoft.AjaxMethods.ThrowClientEvent(window.key, '" + message + "', '" + key + "')}}");
		}

		public virtual void AjaxRefresh() {
			ScriptManager.AddScript("window.Terrasoft.AjaxMethods.ThrowClientEvent(null, null);");
		}

		public virtual void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public virtual void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public virtual void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "BaseManyToManyGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseManyToManyGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseManyToManyGridPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseManyToManyGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseManyToManyGridPageEventsProcessSchema(BaseManyToManyGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseManyToManyGridPageEventsProcess";
			UId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateDetailEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3cf599b4-f243-4acd-9d67-a0292daae811"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"DetailEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a829d18d-51e5-4958-ad5e-e7550829314e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"ParentEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailGridPageSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5679387a-88f4-467c-a86c-ddf43c026d22"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"DetailGridPageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentGridPageSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7e22cecf-d803-48ad-8b21-7e36649a91f2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"ParentGridPageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailAssociationColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("36e305b7-8b19-40b1-905c-5a707a6a27a1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"DetailAssociationColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("54e60ded-1e5d-4ca9-ac59-a2d981969960"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"ParentPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailSelectionColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c4ec8e4d-0fb8-45b0-aabc-0989c5d8c5be"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"DetailSelectionColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEntityDetailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4e5280bb-bb86-4f36-bd05-e0d2920dbbd5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"IsEntityDetail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("29cc18b4-a5ba-4c1a-b711-ee8d92aff429"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"MainPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e60f0b8e-4979-4f8c-9c5d-32c1596ebd1e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"MainPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDetailEntitySchemaIdParameter());
			Parameters.Add(CreateParentEntitySchemaIdParameter());
			Parameters.Add(CreateDetailGridPageSchemaIdParameter());
			Parameters.Add(CreateParentGridPageSchemaIdParameter());
			Parameters.Add(CreateDetailAssociationColumnUIdParameter());
			Parameters.Add(CreateParentPrimaryColumnValueParameter());
			Parameters.Add(CreateDetailSelectionColumnUIdParameter());
			Parameters.Add(CreateIsEntityDetailParameter());
			Parameters.Add(CreateMainPageParameter());
			Parameters.Add(CreateMainPageProcessUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet32 = CreateLaneSet32LaneSet();
			LaneSets.Add(schemaLaneSet32);
			ProcessSchemaLane schemaLane96 = CreateLane96Lane();
			schemaLaneSet32.Lanes.Add(schemaLane96);
			ProcessSchemaLane schemaLane97 = CreateLane97Lane();
			schemaLaneSet32.Lanes.Add(schemaLane97);
			ProcessSchemaEventSubProcess basemanytomanygridpageinitsubprocess = CreateBaseManyToManyGridPageInitSubProcessEventSubProcess();
			FlowElements.Add(basemanytomanygridpageinitsubprocess);
			ProcessSchemaEventSubProcess parentprimarycolumnchangedsubprocess = CreateParentPrimaryColumnChangedSubProcessEventSubProcess();
			FlowElements.Add(parentprimarycolumnchangedsubprocess);
			ProcessSchemaEventSubProcess closebuttonclicksubprocess = CreateCloseButtonClickSubProcessEventSubProcess();
			FlowElements.Add(closebuttonclicksubprocess);
			ProcessSchemaEventSubProcess base2eventsubprocess1 = CreateBase2EventSubProcess1EventSubProcess();
			FlowElements.Add(base2eventsubprocess1);
			ProcessSchemaStartMessageEvent basemanytomanygridpageinitstartmessage = CreateBaseManyToManyGridPageInitStartMessageStartMessageEvent();
			basemanytomanygridpageinitsubprocess.FlowElements.Add(basemanytomanygridpageinitstartmessage);
			ProcessSchemaScriptTask basemanytomanygridpageinitscripttask = CreateBaseManyToManyGridPageInitScriptTaskScriptTask();
			basemanytomanygridpageinitsubprocess.FlowElements.Add(basemanytomanygridpageinitscripttask);
			ProcessSchemaStartMessageEvent basemanytomanygridpagegridactiverowchangedstartmessage = CreateBaseManyToManyGridPageGridActiveRowChangedStartMessageStartMessageEvent();
			parentprimarycolumnchangedsubprocess.FlowElements.Add(basemanytomanygridpagegridactiverowchangedstartmessage);
			ProcessSchemaScriptTask basemanytomanygridpageparentprimarycolumnchangedscripttask = CreateBaseManyToManyGridPageParentPrimaryColumnChangedScriptTaskScriptTask();
			parentprimarycolumnchangedsubprocess.FlowElements.Add(basemanytomanygridpageparentprimarycolumnchangedscripttask);
			ProcessSchemaStartMessageEvent gridloadrowsstartmessage = CreateGridLoadRowsStartMessageStartMessageEvent();
			parentprimarycolumnchangedsubprocess.FlowElements.Add(gridloadrowsstartmessage);
			ProcessSchemaStartMessageEvent basemanytomanygridpageclosebuttonclickstartmessage = CreateBaseManyToManyGridPageCloseButtonClickStartMessageStartMessageEvent();
			closebuttonclicksubprocess.FlowElements.Add(basemanytomanygridpageclosebuttonclickstartmessage);
			ProcessSchemaScriptTask basemanytomanygridpageclosebuttonclickscripttask = CreateBaseManyToManyGridPageCloseButtonClickScriptTaskScriptTask();
			closebuttonclicksubprocess.FlowElements.Add(basemanytomanygridpageclosebuttonclickscripttask);
			ProcessSchemaStartMessageEvent base2startmessage1 = CreateBase2StartMessage1StartMessageEvent();
			base2eventsubprocess1.FlowElements.Add(base2startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent base2intermediatethrowmessageevent1 = CreateBase2IntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			base2eventsubprocess1.FlowElements.Add(base2intermediatethrowmessageevent1);
			ProcessSchemaScriptTask base2_pageloadcompletescripttask = CreateBase2_PageLoadCompleteScriptTaskScriptTask();
			base2eventsubprocess1.FlowElements.Add(base2_pageloadcompletescripttask);
			FlowElements.Add(CreateSequenceFlow333SequenceFlow());
			FlowElements.Add(CreateSequenceFlow334SequenceFlow());
			FlowElements.Add(CreateSequenceFlow335SequenceFlow());
			FlowElements.Add(CreateSequenceFlow336SequenceFlow());
			FlowElements.Add(CreateBase2SequenceFlow1SequenceFlow());
			FlowElements.Add(CreateBase2SequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow333SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow333",
				UId = new Guid("0d3355be-270d-4292-ab85-a0711924dd09"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CurveCenterPosition = new Point(163, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c5a25da1-b8b1-4136-8142-defa6a4dcb51"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("355e2114-cbc3-4449-a279-cf0351eb78a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow334SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow334",
				UId = new Guid("39fce25d-428b-4519-bfa5-df7dc48f3908"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CurveCenterPosition = new Point(172, 303),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d9e963c7-07be-4ccf-b760-5f13f7c8ea82"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("92c5e434-ef73-4777-80e9-25f3c7d06cbf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow335SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow335",
				UId = new Guid("47d11473-742e-4b7f-bda4-85ba183b5c4d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d01ba1f-2d8b-42d4-be04-bf087ffe1d39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a15f2dd0-7a4f-4025-8260-19c3920cb362"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow336SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow336",
				UId = new Guid("f98c0178-37d4-46a1-8b06-dca45641d2e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CurveCenterPosition = new Point(194, 406),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e0f99bb8-02f9-4fc9-abab-8d30116f5c6a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("92c5e434-ef73-4777-80e9-25f3c7d06cbf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBase2SequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "Base2SequenceFlow1",
				UId = new Guid("c384826b-448e-4560-a02a-58c193c78f3e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CurveCenterPosition = new Point(422, 255),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20023c1f-99fb-40f9-af8d-b64f1abe00c5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0d9039c2-1395-48df-a620-b25b7fe74828"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBase2SequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "Base2SequenceFlow2",
				UId = new Guid("58ef7b42-ef2f-4155-86ea-1445eb5e0a6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CurveCenterPosition = new Point(533, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0d9039c2-1395-48df-a620-b25b7fe74828"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4e8e054-305e-4320-b450-21dab32e0eb7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet32LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet32 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a7fd851d-553f-4b9d-b087-81faea6424dc"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"LaneSet32",
				Position = new Point(5, 5),
				Size = new Size(818, 682),
				UseBackgroundMode = false
			};
			return schemaLaneSet32;
		}

		protected virtual ProcessSchemaLane CreateLane96Lane() {
			ProcessSchemaLane schemaLane96 = new ProcessSchemaLane(this) {
				UId = new Guid("c04207d4-823b-4cda-89dc-7ad387f028fd"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("a7fd851d-553f-4b9d-b087-81faea6424dc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"Lane96",
				Position = new Point(29, 156),
				Size = new Size(789, 526),
				UseBackgroundMode = false
			};
			return schemaLane96;
		}

		protected virtual ProcessSchemaLane CreateLane97Lane() {
			ProcessSchemaLane schemaLane97 = new ProcessSchemaLane(this) {
				UId = new Guid("aafe984e-ff3b-45b1-a525-9e9cfe95489e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a7fd851d-553f-4b9d-b087-81faea6424dc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"Lane97",
				Position = new Point(29, 0),
				Size = new Size(789, 151),
				UseBackgroundMode = false
			};
			return schemaLane97;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseManyToManyGridPageInitSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseManyToManyGridPageInitSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a3e50ea2-b303-4e5b-83b4-196348a031fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c04207d4-823b-4cda-89dc-7ad387f028fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"BaseManyToManyGridPageInitSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(254, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseManyToManyGridPageInitSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseManyToManyGridPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c5a25da1-b8b1-4136-8142-defa6a4dcb51"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3e50ea2-b303-4e5b-83b4-196348a031fb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"BaseManyToManyGridPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseManyToManyGridPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("355e2114-cbc3-4449-a279-cf0351eb78a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3e50ea2-b303-4e5b-83b4-196348a031fb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"BaseManyToManyGridPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,111,226,48,16,61,23,137,255,48,203,161,10,18,50,236,117,43,14,219,82,177,145,182,128,22,104,207,38,25,130,165,196,65,182,3,66,43,254,251,142,227,80,82,112,63,180,84,61,17,236,231,247,230,227,205,116,187,48,81,249,26,149,217,193,50,87,16,229,74,97,100,0,149,162,127,25,215,154,39,8,177,208,235,148,19,66,229,25,44,184,70,72,148,136,97,77,119,205,198,3,23,114,98,81,125,176,63,55,205,70,179,209,237,194,207,216,2,20,74,83,226,136,89,26,66,162,130,173,48,171,58,129,88,66,48,41,145,67,58,180,28,211,104,133,25,15,99,248,214,135,97,33,98,118,159,173,41,192,235,107,112,184,123,105,132,217,249,81,109,248,219,108,92,109,184,170,212,45,223,221,179,118,31,36,110,97,70,233,113,157,47,13,155,135,236,9,23,246,94,229,169,102,207,31,47,94,5,142,243,106,78,90,149,212,8,183,246,55,104,119,236,197,136,103,54,253,214,228,92,177,85,2,142,73,57,14,127,186,37,244,23,138,100,101,8,51,151,194,176,9,170,136,144,4,10,190,247,122,78,237,73,196,84,64,63,0,246,84,255,82,142,57,141,25,95,176,80,106,106,112,104,48,11,122,29,95,89,218,246,145,231,188,44,3,189,54,92,70,68,168,242,8,181,102,83,52,7,207,60,242,180,192,160,85,239,7,37,216,234,120,251,116,169,202,111,161,13,18,222,194,43,212,65,44,57,190,59,16,205,157,32,73,146,25,137,236,96,70,195,23,16,241,181,17,185,172,124,130,181,40,109,89,169,88,20,155,164,49,32,12,171,231,240,192,37,73,41,54,196,178,154,183,59,18,9,94,77,213,250,122,106,148,144,9,11,245,168,72,211,177,42,29,26,156,180,231,206,69,211,174,92,230,191,165,192,234,113,30,142,173,206,190,217,216,215,134,46,70,42,107,250,145,161,27,148,200,247,135,206,225,62,54,116,78,253,43,135,110,112,174,232,31,58,127,186,159,59,116,78,227,124,232,60,101,41,61,226,57,255,255,161,243,245,233,82,149,80,59,62,199,77,34,47,15,46,165,191,96,166,103,227,193,248,7,252,193,44,223,32,240,165,193,114,227,147,41,232,75,3,207,22,34,41,40,78,231,252,147,98,1,151,49,76,119,250,196,211,66,131,66,157,167,27,140,47,75,235,140,250,173,238,28,87,84,53,186,159,190,162,94,149,126,123,69,29,205,236,91,81,103,183,239,174,40,133,166,80,18,140,42,240,230,31,253,166,219,195,121,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateParentPrimaryColumnChangedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaParentPrimaryColumnChangedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3c92ecd9-c044-45d0-a9ca-8cd2891d94bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c04207d4-823b-4cda-89dc-7ad387f028fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"ParentPrimaryColumnChangedSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 231),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(367, 281),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaParentPrimaryColumnChangedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseManyToManyGridPageGridActiveRowChangedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d9e963c7-07be-4ccf-b760-5f13f7c8ea82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c92ecd9-c044-45d0-a9ca-8cd2891d94bb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridActiveRowChanged",
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"BaseManyToManyGridPageGridActiveRowChangedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 175),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseManyToManyGridPageParentPrimaryColumnChangedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("92c5e434-ef73-4777-80e9-25f3c7d06cbf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c92ecd9-c044-45d0-a9ca-8cd2891d94bb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"BaseManyToManyGridPageParentPrimaryColumnChangedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(168, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,110,194,48,12,134,239,121,138,168,39,184,228,5,162,29,182,178,73,189,160,10,208,46,136,131,105,45,136,148,58,147,235,150,241,246,164,148,134,141,177,91,236,223,250,236,47,61,176,254,2,70,146,13,236,245,139,46,225,128,166,156,26,37,16,122,19,31,237,246,89,240,90,137,235,49,150,5,213,248,189,179,170,79,180,66,176,137,184,132,54,31,142,234,129,145,7,18,14,254,237,188,132,6,103,217,2,4,214,161,227,10,179,185,134,86,223,107,171,198,109,37,187,6,248,156,7,223,53,244,9,190,195,196,29,150,220,142,88,133,211,223,65,171,174,23,213,40,224,252,15,191,197,212,120,244,123,8,158,250,141,180,155,95,66,255,235,119,29,152,2,112,132,60,138,254,106,89,117,167,154,33,41,168,21,160,10,205,230,200,225,244,222,71,217,89,54,254,71,242,205,143,64,7,172,179,185,85,140,210,49,105,225,232,124,1,109,155,129,220,210,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridLoadRowsStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e0f99bb8-02f9-4fc9-abab-8d30116f5c6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c92ecd9-c044-45d0-a9ca-8cd2891d94bb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridLoadRows",
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"GridLoadRowsStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCloseButtonClickSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCloseButtonClickSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("96ebda39-33c8-4a46-800e-5d3f0a835e8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aafe984e-ff3b-45b1-a525-9e9cfe95489e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"CloseButtonClickSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(257, 120),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCloseButtonClickSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseManyToManyGridPageCloseButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3d01ba1f-2d8b-42d4-be04-bf087ffe1d39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96ebda39-33c8-4a46-800e-5d3f0a835e8e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CloseButtonClick",
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"BaseManyToManyGridPageCloseButtonClickStartMessage",
				Position = new Point(14, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseManyToManyGridPageCloseButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a15f2dd0-7a4f-4025-8260-19c3920cb362"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96ebda39-33c8-4a46-800e-5d3f0a835e8e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"BaseManyToManyGridPageCloseButtonClickScriptTask",
				Position = new Point(140, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,11,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,157,57,6,49,68,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBase2EventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaBase2EventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a9f2f02f-9190-4cae-b269-9e79c770c117"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c04207d4-823b-4cda-89dc-7ad387f028fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"Base2EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(313, 175),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBase2EventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBase2StartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("20023c1f-99fb-40f9-af8d-b64f1abe00c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9f2f02f-9190-4cae-b269-9e79c770c117"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"Base2StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBase2IntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0d9039c2-1395-48df-a620-b25b7fe74828"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9f2f02f-9190-4cae-b269-9e79c770c117"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"Base2IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBase2_PageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f4e8e054-305e-4320-b450-21dab32e0eb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9f2f02f-9190-4cae-b269-9e79c770c117"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"Base2_PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,205,10,194,48,16,132,207,22,250,14,177,167,246,146,23,144,30,180,34,244,160,8,86,60,136,200,214,110,37,16,19,217,36,133,34,190,187,137,20,127,232,105,97,119,230,155,217,14,136,53,96,97,167,29,93,176,208,202,146,150,44,103,91,184,34,223,2,161,178,21,212,124,37,84,19,86,131,96,209,111,224,134,105,178,252,56,147,108,22,71,162,101,233,24,54,205,153,114,82,102,236,17,71,147,238,47,207,7,141,245,96,216,151,235,169,147,244,93,102,110,238,97,134,115,133,68,96,116,107,249,190,228,7,172,7,167,225,65,144,241,194,25,171,111,129,113,76,118,189,89,235,198,73,60,195,197,138,14,127,26,159,254,210,121,33,133,127,182,92,250,196,103,28,17,90,71,138,89,114,56,123,1,66,177,208,67,36,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("46b4da2e-0028-4749-9503-d1d38c64a418"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseManyToManyGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"));
		}

		#endregion

	}

	#endregion

}

