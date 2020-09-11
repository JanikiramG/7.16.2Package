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
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: BaseProcessParametersEditPageSchema

	/// <exclude/>
	public class BaseProcessParametersEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _mainMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel MainMessagePanel {
			get {
				return _mainMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return _topControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomControlLayout {
			get {
				return _bottomControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _okButton;
		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return _okButton;
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

		public BaseProcessParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseProcessParametersEditPageSchema(BaseProcessParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			RealUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			Name = "BaseProcessParametersEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "MainMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseProcessParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainMessagePanel());
			Controls.AddAt(1, CreateTopControlLayout());
			Controls.AddAt(2, CreateBottomControlLayout());
			BottomControlLayout.InsertItem(0, CreateContextHelpButton());
			BottomControlLayout.InsertItem(1, CreateSpacer1());
			BottomControlLayout.InsertItem(2, CreateOkButton());
			BottomControlLayout.InsertItem(3, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseProcessParametersEditPageEventsProcessSchema() {
			var schema = new BaseProcessParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateMainMessagePanel() {
			_mainMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_mainMessagePanel.UId = new Guid("994bf297-f16e-4e58-a29a-cd3dbb664f74");
			_mainMessagePanel.Name = "MainMessagePanel";
			_mainMessagePanel.CreatedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_mainMessagePanel.ModifiedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_mainMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainMessagePanel.Tag = "";
			_mainMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_mainMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainMessagePanel.Edges = "0 0 1 0";
			return _mainMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopControlLayout() {
			_topControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topControlLayout.UId = new Guid("985770e3-429a-4648-b758-08e5192c6e9c");
			_topControlLayout.Name = "TopControlLayout";
			_topControlLayout.CreatedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_topControlLayout.ModifiedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_topControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_topControlLayout.Tag = "";
			_topControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_topControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_topControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topControlLayout.Padding = "5 5 5 5";
			_topControlLayout.StartNewAlignGroup = false;
			_topControlLayout.Image = new ControlImage {};
			_topControlLayout.Edges = "";
			return _topControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("7c58a9e3-046b-4238-8dee-c9492e99d6c6");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("e6f23a34-55e5-4731-ba61-2f3fde1bd1a6");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_spacer1.ModifiedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("b4b17033-b1ea-4e03-8fd3-93fc054962d4");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_okButton.ModifiedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_okButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("524a733a-c82f-459f-9c58-339fdd8d8cdd");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_cancelButton.ModifiedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomControlLayout() {
			_bottomControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomControlLayout.UId = new Guid("77952d59-f6b1-4e15-9d41-69e11a93a8df");
			_bottomControlLayout.Name = "BottomControlLayout";
			_bottomControlLayout.CreatedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_bottomControlLayout.ModifiedInSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			_bottomControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomControlLayout.Tag = "";
			_bottomControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_bottomControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_bottomControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomControlLayout.StartNewAlignGroup = false;
			_bottomControlLayout.Image = new ControlImage {};
			_bottomControlLayout.Edges = "1 0 0 0";
			return _bottomControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseProcessParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseProcessParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseProcessParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseProcessParametersEditPageEventsProcess

	/// <exclude/>
	public class BaseProcessParametersEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
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

		public BaseProcessParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseProcessParametersEditPageEventsProcess";
			SchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
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

		public virtual Object PropertyDataSource {
			get;
			set;
		}

		public virtual Object DefaultValues {
			get;
			set;
		}

		public virtual string CallbackClientFunctionName {
			get;
			set;
		}

		public virtual Object ParametersValue {
			get;
			set;
		}

		public virtual Guid EditSchemaUId {
			get;
			set;
		}

		public virtual string EditSchemaManagerName {
			get;
			set;
		}

		public virtual Guid EditElementUId {
			get;
			set;
		}

		public virtual string ManagerName {
			get;
			set;
		}

		public virtual bool SchemaExplorerCreated {
			get;
			set;
		}

		public virtual bool SchemaExplorerRegistered {
			get;
			set;
		}

		public virtual Object SchemaExplorer {
			get;
			set;
		}

		public virtual Object Descriptor {
			get;
			set;
		}

		public virtual Object Source {
			get;
			set;
		}

		public virtual string ElementNewCaption {
			get;
			set;
		}

		public virtual Guid ParameterDataValueTypeUId {
			get;
			set;
		}

		public virtual bool IsParameterLookup {
			get;
			set;
		}

		public virtual Guid ParameterReferenceSchemaUId {
			get;
			set;
		}

		public virtual string SchemaExplorerKey {
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
					SchemaElementUId = new Guid("404ef2d3-9eed-40f9-a5ee-4cdb75895f38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _closeMappingWindowStartMessage;
		public ProcessFlowElement CloseMappingWindowStartMessage {
			get {
				return _closeMappingWindowStartMessage ?? (_closeMappingWindowStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CloseMappingWindowStartMessage",
					SchemaElementUId = new Guid("cf5c03f2-b31e-4174-8ac2-589f9c3762d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _closeMappingWindowScript;
		public ProcessScriptTask CloseMappingWindowScript {
			get {
				return _closeMappingWindowScript ?? (_closeMappingWindowScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CloseMappingWindowScript",
					SchemaElementUId = new Guid("81a59c3a-54ee-4448-bcd0-4e68598470e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CloseMappingWindowScriptExecute,
				});
			}
		}

		private ProcessFlowElement _okButtonClickEventSubProcess2;
		public ProcessFlowElement OkButtonClickEventSubProcess2 {
			get {
				return _okButtonClickEventSubProcess2 ?? (_okButtonClickEventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OkButtonClickEventSubProcess2",
					SchemaElementUId = new Guid("5edbca7a-61f2-4f89-99f0-937ecc5b3c3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickScript;
		public ProcessScriptTask OkButtonClickScript {
			get {
				return _okButtonClickScript ?? (_okButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickScript",
					SchemaElementUId = new Guid("be2ed76f-67ad-41b3-b1fe-066ded53409b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _okButtonClick;
		public ProcessFlowElement OkButtonClick {
			get {
				return _okButtonClick ?? (_okButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClick",
					SchemaElementUId = new Guid("8d2dcce5-069d-4c5c-9d0b-8bec4bef5ed0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickEventSubProcess2;
		public ProcessFlowElement CancelButtonClickEventSubProcess2 {
			get {
				return _cancelButtonClickEventSubProcess2 ?? (_cancelButtonClickEventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CancelButtonClickEventSubProcess2",
					SchemaElementUId = new Guid("aed154a5-add5-4bbd-b97c-7f273e719c46"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelButtonClickScript;
		public ProcessScriptTask CancelButtonClickScript {
			get {
				return _cancelButtonClickScript ?? (_cancelButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelButtonClickScript",
					SchemaElementUId = new Guid("173b5f59-2373-4683-8ca3-3904fb4a33ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClick;
		public ProcessFlowElement CancelButtonClick {
			get {
				return _cancelButtonClick ?? (_cancelButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClick",
					SchemaElementUId = new Guid("5ff4ddaf-3d97-4070-9104-c5f375fef4a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initEventSubProcess2;
		public ProcessFlowElement InitEventSubProcess2 {
			get {
				return _initEventSubProcess2 ?? (_initEventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess2",
					SchemaElementUId = new Guid("73347c4a-2765-411d-897b-0ca96111435f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScript;
		public ProcessScriptTask InitScript {
			get {
				return _initScript ?? (_initScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScript",
					SchemaElementUId = new Guid("8263887c-3586-4d37-9454-1c298b60a664"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptExecute,
				});
			}
		}

		private ProcessFlowElement _initEvent;
		public ProcessFlowElement InitEvent {
			get {
				return _initEvent ?? (_initEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitEvent",
					SchemaElementUId = new Guid("eb71b882-65f3-4fe1-9af9-cdbaf2b1ae87"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess3;
		public ProcessFlowElement PageLoadCompleteEventSubProcess3 {
			get {
				return _pageLoadCompleteEventSubProcess3 ?? (_pageLoadCompleteEventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess3",
					SchemaElementUId = new Guid("1293594a-a239-42dc-95c8-ddd4829751f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScript;
		public ProcessScriptTask PageLoadCompleteScript {
			get {
				return _pageLoadCompleteScript ?? (_pageLoadCompleteScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScript",
					SchemaElementUId = new Guid("492e7541-1c9c-4657-b565-dbb3a4f83e95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEvent;
		public ProcessFlowElement PageLoadCompleteEvent {
			get {
				return _pageLoadCompleteEvent ?? (_pageLoadCompleteEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteEvent",
					SchemaElementUId = new Guid("fdef0cd8-bcfb-4e77-bde5-5fe4876ab9c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildPropertyChange;
		public ProcessFlowElement EventSubProcessChildPropertyChange {
			get {
				return _eventSubProcessChildPropertyChange ?? (_eventSubProcessChildPropertyChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildPropertyChange",
					SchemaElementUId = new Guid("34e2d89f-d003-4603-8c07-a995e611f4a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onPropertyChangeScript;
		public ProcessScriptTask OnPropertyChangeScript {
			get {
				return _onPropertyChangeScript ?? (_onPropertyChangeScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnPropertyChangeScript",
					SchemaElementUId = new Guid("2ee1b163-0d46-4fe0-92b1-2716b70b3f09"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnPropertyChangeScriptExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageOnPropertyChange;
		public ProcessFlowElement StartMessageOnPropertyChange {
			get {
				return _startMessageOnPropertyChange ?? (_startMessageOnPropertyChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageOnPropertyChange",
					SchemaElementUId = new Guid("589892e2-1019-44c1-b776-7b9ccff5e24e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessShowMappingWindow;
		public ProcessFlowElement EventSubProcessShowMappingWindow {
			get {
				return _eventSubProcessShowMappingWindow ?? (_eventSubProcessShowMappingWindow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessShowMappingWindow",
					SchemaElementUId = new Guid("b97739b3-0e94-4234-bc0f-121a6fa9e1e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptShowMappingWindow;
		public ProcessScriptTask ScriptShowMappingWindow {
			get {
				return _scriptShowMappingWindow ?? (_scriptShowMappingWindow = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptShowMappingWindow",
					SchemaElementUId = new Guid("4cf8158b-7bd4-4d53-9611-8875ecb1f209"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptShowMappingWindowExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageShowMappingWindow;
		public ProcessFlowElement StartMessageShowMappingWindow {
			get {
				return _startMessageShowMappingWindow ?? (_startMessageShowMappingWindow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageShowMappingWindow",
					SchemaElementUId = new Guid("d01858b6-37f2-4189-9228-73178862ac06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _windowCaption;
		public LocalizableString WindowCaption {
			get {
				return _windowCaption ?? (_windowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WindowCaption.Value"));
			}
		}

		private LocalizableString _newRecord;
		public LocalizableString NewRecord {
			get {
				return _newRecord ?? (_newRecord = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewRecord.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CloseMappingWindowStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseMappingWindowStartMessage };
			FlowElements[CloseMappingWindowScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseMappingWindowScript };
			FlowElements[OkButtonClickEventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickEventSubProcess2 };
			FlowElements[OkButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScript };
			FlowElements[OkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClick };
			FlowElements[CancelButtonClickEventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickEventSubProcess2 };
			FlowElements[CancelButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScript };
			FlowElements[CancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClick };
			FlowElements[InitEventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess2 };
			FlowElements[InitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScript };
			FlowElements[InitEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEvent };
			FlowElements[PageLoadCompleteEventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess3 };
			FlowElements[PageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScript };
			FlowElements[PageLoadCompleteEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEvent };
			FlowElements[EventSubProcessChildPropertyChange.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildPropertyChange };
			FlowElements[OnPropertyChangeScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPropertyChangeScript };
			FlowElements[StartMessageOnPropertyChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageOnPropertyChange };
			FlowElements[EventSubProcessShowMappingWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessShowMappingWindow };
			FlowElements[ScriptShowMappingWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptShowMappingWindow };
			FlowElements[StartMessageShowMappingWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageShowMappingWindow };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CloseMappingWindowStartMessage":
						e.Context.QueueTasks.Enqueue("CloseMappingWindowScript");
						break;
					case "CloseMappingWindowScript":
						break;
					case "OkButtonClickEventSubProcess2":
						break;
					case "OkButtonClickScript":
						break;
					case "OkButtonClick":
						e.Context.QueueTasks.Enqueue("OkButtonClickScript");
						break;
					case "CancelButtonClickEventSubProcess2":
						break;
					case "CancelButtonClickScript":
						break;
					case "CancelButtonClick":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScript");
						break;
					case "InitEventSubProcess2":
						break;
					case "InitScript":
						break;
					case "InitEvent":
						e.Context.QueueTasks.Enqueue("InitScript");
						break;
					case "PageLoadCompleteEventSubProcess3":
						break;
					case "PageLoadCompleteScript":
						break;
					case "PageLoadCompleteEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScript");
						break;
					case "EventSubProcessChildPropertyChange":
						break;
					case "OnPropertyChangeScript":
						break;
					case "StartMessageOnPropertyChange":
						e.Context.QueueTasks.Enqueue("OnPropertyChangeScript");
						break;
					case "EventSubProcessShowMappingWindow":
						break;
					case "ScriptShowMappingWindow":
						break;
					case "StartMessageShowMappingWindow":
						e.Context.QueueTasks.Enqueue("ScriptShowMappingWindow");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CloseMappingWindowStartMessage");
			ActivatedEventElements.Add("OkButtonClick");
			ActivatedEventElements.Add("CancelButtonClick");
			ActivatedEventElements.Add("InitEvent");
			ActivatedEventElements.Add("PageLoadCompleteEvent");
			ActivatedEventElements.Add("StartMessageOnPropertyChange");
			ActivatedEventElements.Add("StartMessageShowMappingWindow");
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
				case "CloseMappingWindowStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseMappingWindowStartMessage";
					result = CloseMappingWindowStartMessage.Execute(context);
					break;
				case "CloseMappingWindowScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseMappingWindowScript";
					result = CloseMappingWindowScript.Execute(context, CloseMappingWindowScriptExecute);
					break;
				case "OkButtonClickEventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickScript";
					result = OkButtonClickScript.Execute(context, OkButtonClickScriptExecute);
					break;
				case "OkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClick";
					result = OkButtonClick.Execute(context);
					break;
				case "CancelButtonClickEventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScript";
					result = CancelButtonClickScript.Execute(context, CancelButtonClickScriptExecute);
					break;
				case "CancelButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClick";
					result = CancelButtonClick.Execute(context);
					break;
				case "InitEventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "InitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScript";
					result = InitScript.Execute(context, InitScriptExecute);
					break;
				case "InitEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitEvent";
					result = InitEvent.Execute(context);
					break;
				case "PageLoadCompleteEventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScript";
					result = PageLoadCompleteScript.Execute(context, PageLoadCompleteScriptExecute);
					break;
				case "PageLoadCompleteEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteEvent";
					result = PageLoadCompleteEvent.Execute(context);
					break;
				case "EventSubProcessChildPropertyChange":
					context.QueueTasks.Dequeue();
					break;
				case "OnPropertyChangeScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnPropertyChangeScript";
					result = OnPropertyChangeScript.Execute(context, OnPropertyChangeScriptExecute);
					break;
				case "StartMessageOnPropertyChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageOnPropertyChange";
					result = StartMessageOnPropertyChange.Execute(context);
					break;
				case "EventSubProcessShowMappingWindow":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptShowMappingWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptShowMappingWindow";
					result = ScriptShowMappingWindow.Execute(context, ScriptShowMappingWindowExecute);
					break;
				case "StartMessageShowMappingWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageShowMappingWindow";
					result = StartMessageShowMappingWindow.Execute(context);
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
				case "SchemaExplorerKey":
					SchemaExplorerKey = reader.GetValue<System.String>();
				break;
				case "ParameterReferenceSchemaUId":
					ParameterReferenceSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "IsParameterLookup":
					IsParameterLookup = reader.GetValue<System.Boolean>();
				break;
				case "ParameterDataValueTypeUId":
					ParameterDataValueTypeUId = reader.GetValue<System.Guid>();
				break;
				case "ElementNewCaption":
					ElementNewCaption = reader.GetValue<System.String>();
				break;
				case "Source":
					Source = reader.GetSerializableObjectValue();
				break;
				case "Descriptor":
					Descriptor = reader.GetSerializableObjectValue();
				break;
				case "SchemaExplorerRegistered":
					SchemaExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "SchemaExplorerCreated":
					SchemaExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "ManagerName":
					ManagerName = reader.GetValue<System.String>();
				break;
				case "EditElementUId":
					EditElementUId = reader.GetValue<System.Guid>();
				break;
				case "EditSchemaManagerName":
					EditSchemaManagerName = reader.GetValue<System.String>();
				break;
				case "EditSchemaUId":
					EditSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ParametersValue":
					ParametersValue = reader.GetSerializableObjectValue();
				break;
				case "CallbackClientFunctionName":
					CallbackClientFunctionName = reader.GetValue<System.String>();
				break;
				case "PropertyDataSource":
					PropertyDataSource = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool CloseMappingWindowScriptExecute(ProcessExecutingContext context) {
			SchemaExplorerCreated = false;
			return true;
		}

		public virtual bool OkButtonClickScriptExecute(ProcessExecutingContext context) {
			OkClickMethod();
			return true;
		}

		public virtual bool CancelButtonClickScriptExecute(ProcessExecutingContext context) {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool InitScriptExecute(ProcessExecutingContext context) {
			VirtualDataSource propertyDataSource = new VirtualDataSource() {
				//EnableServerActiveRow = true, // if enabled breaks parameter mapping
				Name = "PropertyDataSource",
				CreatedByAjax = (Page.PageContainer as Terrasoft.UI.WebControls.WebControl).CreatedByAjax
			};
			object queryStringValue = Page.Request.QueryString["EditSchemaUId"];
			if (queryStringValue == null) {
				return false;
			}
			EditSchemaUId = new Guid(queryStringValue.ToString());
			queryStringValue = Page.Request.QueryString["callbackFunctionName"];
			if (queryStringValue != null) {
				CallbackClientFunctionName = queryStringValue.ToString();
			}
			queryStringValue = Page.Request.QueryString["EditSchemaManagerName"];
			if (queryStringValue == null) {
				return false;
			}
			EditSchemaManagerName = queryStringValue.ToString();
			queryStringValue = Page.Request.QueryString["editItemUId"];
			if (queryStringValue == null) {
				return false;
			}
			EditElementUId = new Guid(queryStringValue.ToString());
			queryStringValue = Page.Request.QueryString["ManagerName"];
			if (queryStringValue == null) {
				return false;
			}
			ManagerName = queryStringValue.ToString();
			if (string.IsNullOrEmpty(ManagerName)) {
				return false;
			}
			queryStringValue = Page.Request.QueryString["SourceUId"];
			Guid sourceUId;
			if (!Guid.TryParse(queryStringValue as string, out sourceUId) || sourceUId == Guid.Empty) {
				return false;
			}
			queryStringValue = Page.Request.QueryString["OwnerUId"];
			if (queryStringValue != null) {
				Guid ownerUId = new Guid(queryStringValue.ToString());
			}
			if (Ext.IsAjaxRequest) {
				if (SchemaExplorerCreated) {
					InitializeSchemaExplorerWindow();
				}
			}
			propertyDataSource.AjaxEvents.DataChanged.ExtraParameters.Add(new UIControls.Parameter("row", "row.getColumnValue(columnName)", UIControls.ParameterMode.Raw));
			propertyDataSource.AjaxEvents.DataChanged.ExtraParameters.Add(new UIControls.Parameter("columnName", "columnName", UIControls.ParameterMode.Raw));
			propertyDataSource.AjaxEvents.DataChanged.ExtraParameters.Add(new UIControls.Parameter("displayValue", "row.getColumnDisplayValue(columnName)", UIControls.ParameterMode.Raw));
			propertyDataSource.AjaxEvents.DataChanged.SignalName = "OnPropertyChange";
			propertyDataSource.AjaxEvents.DataChanged.AjaxEventTargetControlID = Page.TopControlLayout.ClientID;
			Page.PageContainer.Controls.Add(propertyDataSource);
			PropertyDataSource = propertyDataSource;
			ISchemaManager manager;
			Type type = null;
			BaseProcessUserTaskSchema schema;
			object source = null;
			
			if (ManagerName == "ProcessUserTaskSchemaManager") {
				manager = UserConnection.ProcessUserTaskSchemaManager;
			
				schema = manager.GetInstanceByUId(sourceUId) as BaseProcessUserTaskSchema;
				if (schema == null) {
					return false;
				}
				source = ((ProcessUserTaskSchema)schema).CreateProcessUserTask(UserConnection);
				type = source.GetType();
			
			} else if (ManagerName == "ProcessSchemaManager") {
				//manager = UserConnection.ProcessSchemaManager;
				//source = manager.GetInstanceByUId(new Guid(sourceUId)).CreateProcessUserTask();
				//type = source.GetType();
				type = null;
			} else if (ManagerName == "ProcessSchemaConditionalFlow") {
				type = typeof(ProcessSchemaConditionalFlow);
			}
			if (type == null) {
				return false;
			}
			Source = source;
			Descriptor = UserConnection.AppConnection.DesignModeClassResolver.ResolveClass(
				type,
				UserConnection.Workspace,	
				DesignModeItemKind.All,
				DesignModeUsageType.Available,
				null, //OnGetPropertyChildrenDescriptors,
				null //OnGetExtendedDefValue
			);
			if (!Ext.IsAjaxRequest) {
				ProcessSchema processSchema = FindDesignedProcessSchema();
				var processSchemaActivity = (ProcessSchemaActivity)processSchema.GetBaseElementByUId(EditElementUId);
				ElementNewCaption = processSchemaActivity.Caption;
				var defValues = new Dictionary<string, ProcessSchemaParameterValue>();
				foreach (ProcessSchemaParameter parameter in processSchemaActivity.Parameters) {
					defValues.Add(parameter.Name, parameter.SourceValue);
				}
				DefaultValues = defValues;
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			MakeCaption();
			Page.OkButton.AjaxEvents.Click.CausesValidation = true;
			Page.OkButton.AjaxEvents.Click.Delay = 500;
			return true;
		}

		public virtual bool OnPropertyChangeScriptExecute(ProcessExecutingContext context) {
			var parameters = context.ThrowEventArgs as Dictionary<string, object>;
			
			if (ParametersValue == null) {
				ParametersValue = new Dictionary<string, ProcessSchemaParameterValue>();
			}
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			
			string propertyName = parameters["columnName"].ToString();
			string propertyValue = parameters["row"].ToString();
			string propertyDisplayValue = parameters.ContainsKey("displayValue") ? parameters["displayValue"].ToString() : string.Empty;
			
			ProcessSchemaParameterValue value = new ProcessSchemaParameterValue();
			value.ModifiedInSchemaUId = EditSchemaUId;
			if (IsParameterValueEditor(propertyName, GetEditorsBinding())) {
				object val = Json.Deserialize(propertyValue);
				JObject sourceValueObject = val as JObject;
				if (sourceValueObject != null) {
					value.Source = (ProcessSchemaParameterValueSource)Enum.Parse(typeof(ProcessSchemaParameterValueSource), sourceValueObject["source"].Value<string>());
					if (value.Source != ProcessSchemaParameterValueSource.None) {
						value.Value = sourceValueObject["value"].Value<string>();
						value.DisplayValue = sourceValueObject["displayValue"].Value<string>();
						if (value.Source == ProcessSchemaParameterValueSource.Mapping) {
							value.MetaPath = value.Value;
						}
					}
				}
			} else {
				value.Source = ProcessSchemaParameterValueSource.ConstValue;
				value.Value = propertyValue;
				value.DisplayValue = string.IsNullOrEmpty(propertyDisplayValue) ? value.Value : propertyDisplayValue;
			}
			if (parametersValue.ContainsKey(propertyName)) {
				parametersValue[propertyName] = value;
			} else {
				parametersValue.Add(propertyName, value);
			}
			return true;
		}

		public virtual bool ScriptShowMappingWindowExecute(ProcessExecutingContext context) {
			var parameters = context.ThrowEventArgs as Dictionary<string, object>;
			ShowMappingWindow(parameters);
			return true;
		}

		public virtual void FillPropertyDataSource(object sourceObject, DesignModeClassDescriptor itemDescriptor) {
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			DataSourceStructure dataSourceStructure = propertyDataSource.DefStructure;
			dataSourceStructure.Columns.Clear();
			var dataValueTypeManager = (DataValueTypeManager)UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
			var uidColumn = new DataSourceStructureColumn {
				Name = "UId",
				DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
				Caption = "Идентификатор",
				IsVisible = false
			};
			dataSourceStructure.AddColumn(uidColumn);
			Dictionary<string, Terrasoft.UI.WebControls.WebControl> bindingMap = GetEditorsBinding();
			foreach (var property in itemDescriptor.Properties) {
				var column = new DataSourceStructureColumn {
					Name = property.Name,
					Caption = property.Caption,
					Required = property.IsRequired
				};
				ProcessSchemaParameterValue value = defValues[property.Name];
				var valueDataValueType = dataValueTypeManager.GetInstanceByUId(value.DataValueTypeUId);
				if (IsParameterValueEditor(property.Name, bindingMap)) {
					column.DataValueType = dataValueTypeManager.GetInstanceByName("Lookup");
					column.ReferenceSchemaName = "BaseLookup";
				} else if (valueDataValueType is EntityDataValueType) {
					continue;
				} else if (valueDataValueType is EntityCollectionDataValueType) {
					column.ReferenceSchemaName = "BaseLookup";
					column.DataValueType = valueDataValueType;
				} else if (valueDataValueType is LookupDataValueType) {
					ProcessSchemaParameter processSchemaParameter = value.ProcessParameter;
					EntitySchema refSchema = null;
					if (processSchemaParameter != null) {
						if ((!string.IsNullOrEmpty(processSchemaParameter.ReferenceSchemaName)
								|| processSchemaParameter.ReferenceSchemaUId != Guid.Empty)
								&& processSchemaParameter.ReferenceSchema == null) {
							continue;
						}
						refSchema = processSchemaParameter.ReferenceSchema;
					}
					column.DataValueType = valueDataValueType;
					column.ValueColumnName = column.Name + "Id";
					column.DisplayColumnName = column.Name + "Name";
					column.ReferenceSchemaUId = value.ReferenceSchemaUId;
					if (refSchema == null) {
						refSchema = UserConnection
							.EntitySchemaManager.GetInstanceByUId(value.ReferenceSchemaUId);
					}
					column.ReferenceSchemaName = refSchema.Name;
					column.ReferenceSchemaPrimaryColumnName = refSchema.PrimaryColumn.Name;
					var displayColumn = refSchema.PrimaryDisplayColumn;
					if (displayColumn != null) {
						column.ReferenceSchemaPrimaryDisplayColumnName = displayColumn.Name;
					}
				} else {
					column.DataValueType = valueDataValueType;
				}
				dataSourceStructure.AddColumn(column);
			}
			dataSourceStructure.PrimaryColumnName = "UId";
			dataSourceStructure.PrimaryDisplayColumnName = "Caption";
			Entity row = propertyDataSource.CreateRow();
			object primaryColumnValue;
			if (!sourceObject.TryGetPropertyValue("UId", out primaryColumnValue)) {
				primaryColumnValue = Guid.NewGuid();
			}
			row.SetColumnValue("UId", primaryColumnValue);
			foreach (var property in itemDescriptor.Properties) {
				ProcessSchemaParameterValue value = defValues[property.Name];
				var valueDataValueType = dataValueTypeManager.GetInstanceByUId(value.DataValueTypeUId);
				if (IsParameterValueEditor(property.Name, bindingMap)) {
					value.SchemaUId = EditSchemaUId;
					value.SchemaManagerName = EditSchemaManagerName;
					object objValue = value as object;
					string displayValue = string.Empty;
					if (value != null) {
						var parameterValueEdit = (ProcessSchemaParameterValueEdit)bindingMap[property.Name];
						parameterValueEdit.DataProvider.DataValueTypeUId = value.DataValueTypeUId;
						Type PropertyType = property.PropertyInfo.PropertyType;
						property.ValuesProvider.SerializeValue(UserConnection, sourceObject, PropertyType,
							objValue, out objValue, out displayValue);
					}
					var column = row.Schema.Columns.FindByName(property.Name);
					row.SetColumnBothValues(column, objValue, displayValue);
				} else if (valueDataValueType is EntityDataValueType) {
					continue;
				} else if (valueDataValueType is EntityCollectionDataValueType) {
					continue;
				} else if (valueDataValueType is LookupDataValueType) {
					continue;
				} else if (value.Source != ProcessSchemaParameterValueSource.None) {
					row.SetColumnValue(property.Name, value.Value);
				}
			}
			propertyDataSource.Add(row);
			propertyDataSource.LoadRows();
		}

		public virtual void InitializeSchemaExplorerWindow() {
			var schemaExplorer = Terrasoft.UI.WebControls.Page.FindControlByClientId(Page.TopControlLayout, SchemaExplorerKey, true)
				as UIControls.SchemaStructureExplorer;
			if (schemaExplorer != null) {
				Page.TopControlLayout.Controls.Remove(schemaExplorer);
			}
			schemaExplorer = new UIControls.SchemaStructureExplorer(Page.TopControlLayout, "schemaStructure", false, false);
			SchemaExplorerKey = schemaExplorer.ID;
			schemaExplorer.ManagerName = EditSchemaManagerName;
			schemaExplorer.IncludedDataValueTypes.Clear();
			schemaExplorer.IncludedDataValueTypes.Add(ParameterDataValueTypeUId, ParameterReferenceSchemaUId);
			Guid guidDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Guid").UId;
			if (IsParameterLookup) {
				schemaExplorer.IncludedDataValueTypes.Add(guidDataValueTypeUId, Guid.Empty);
			}
			if (ParameterDataValueTypeUId == guidDataValueTypeUId) {
				schemaExplorer.IncludedDataValueTypes.Add(UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId, Guid.Empty);
			}
			SchemaExplorerCreated = true;
			if (!SchemaExplorerRegistered) {
				schemaExplorer.Register();
				SchemaExplorerRegistered = true;
			}
			SchemaExplorer = schemaExplorer;
		}

		public virtual Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl>();
		}

		public virtual bool IsParameterValueEditor(string propertyName, Dictionary<string, Terrasoft.UI.WebControls.WebControl> map) {
			return map.ContainsKey(propertyName) && map[propertyName] is ProcessSchemaParameterValueEdit;
		}

		public virtual void BindEditors(Dictionary<string, Terrasoft.UI.WebControls.WebControl> bindingMap, VirtualDataSource propertyDataSource, Dictionary<string, ProcessSchemaParameterValue> defValues) {
			foreach (KeyValuePair<string, Terrasoft.UI.WebControls.WebControl> item in bindingMap) {
				string name = item.Key;
				DataSourceStructureColumn column = propertyDataSource.DefStructure.Columns.FindByName(name);
				if (column == null) {
					continue;
				}
				var parameterValueEditor = item.Value as ProcessSchemaParameterValueEdit;
				if (parameterValueEditor != null) {
					Page.AddScript(string.Format("{0}.showMappingWindowSignalName = 'ShowMappingWindow';",
						parameterValueEditor.ClientID));
					if (Ext.IsAjaxRequest) {
						continue;
					}
					parameterValueEditor.DataSource = propertyDataSource.Name;
					parameterValueEditor.ColumnUId = column.UId;
					ProcessSchemaParameterValue parameterValue;
					if (!defValues.TryGetValue(name, out parameterValue)
							|| parameterValue == null
							|| parameterValue.ProcessParameter == null) {
						continue;
					}
					ProcessSchemaParameter processSchemaParameter = parameterValue.ProcessParameter;
					if ((!string.IsNullOrEmpty(processSchemaParameter.ReferenceSchemaName)
							|| processSchemaParameter.ReferenceSchemaUId != Guid.Empty)
							&& processSchemaParameter.ReferenceSchema == null) {
						parameterValueEditor.Hidden = true;
					}
					continue;
				}
				if (!Ext.IsAjaxRequest) {
					var field = (UIControls.Field)item.Value;
					field.DataSource = propertyDataSource.Name;
					field.ColumnUId = column.UId;
				}
				string value = defValues[name].Value;
				bool isNullOrEmptyValue = string.IsNullOrEmpty(value);
				var lookupEdit = item.Value as LookupEdit;
				if (lookupEdit != null) {
					return;
				}
				var checkBoxBase = item.Value as CheckBoxBase;
				if (checkBoxBase != null) {
					checkBoxBase.Value = isNullOrEmptyValue ? "false" : value;
					continue;
				}
				var numberEdit = item.Value as NumberEdit;
				if (numberEdit != null) {
					numberEdit.Value = isNullOrEmptyValue ? 0 : Decimal.Parse(value);
					continue;
				}
				var baseEdit = item.Value as BaseEdit;
				if (baseEdit != null) {
					baseEdit.Value = isNullOrEmptyValue ? string.Empty : value;
				}
			}
		}

		public virtual Dictionary<string, string> GetDurationsDictionary() {
			var durations = new Dictionary<string, string>();
			foreach (ProcessDurationPeriod item in Enum.GetValues(typeof(ProcessDurationPeriod))) {
				durations.Add(item.ToLocalizedString(), ((int)item).ToString());
			}
			return durations;
		}

		public virtual void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.Format("{0} ({1})", WindowCaption, NewRecord);
		}

		public virtual void InitOnLookupChangeEvent(ComboBoxEdit lookup, string signalName) {
			lookup.AjaxEvents.Change.ExtraParameters.Add(new UIControls.Parameter("newValue", "newValue", UIControls.ParameterMode.Raw));
			lookup.AjaxEvents.Change.SignalName = signalName;
			lookup.AjaxEvents.Change.AjaxEventTargetControlID = lookup.ClientID;
		}

		public virtual void SetDefaultValue(ProcessSchemaParameterValue parameter, string value, string displayValue, string propertyName) {
			if (parameter.Source == ProcessSchemaParameterValueSource.None) {
				parameter.Source = ProcessSchemaParameterValueSource.ConstValue;
				parameter.Value = value;
				parameter.DisplayValue = displayValue;
				parameter.ModifiedInSchemaUId = EditSchemaUId;
				if (ParametersValue == null) {
					ParametersValue = new Dictionary<string, ProcessSchemaParameterValue>();
				}
				var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
				var newparameter = parameter.Clone() as ProcessSchemaParameterValue;
				if (parametersValue.ContainsKey(propertyName)) {
					parametersValue[propertyName] = newparameter;
				} else {
					parametersValue.Add(propertyName, newparameter);
				}
			}
		}

		public virtual void GetDesignElementCaption() {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			if (processSchema == null) {
				return;
			}
			var element = processSchema.FindBaseElementByUId(EditElementUId) as ProcessSchemaUserTask;
			ElementNewCaption = element != null ? element.Caption.ToString() : string.Empty;
		}

		public virtual ProcessSchema FindDesignedProcessSchema() {
			var schemaManager = UserConnection.GetSchemaManager(EditSchemaManagerName);
			var pageSchemaManager = schemaManager as PageSchemaManager;
			if (pageSchemaManager != null) {
				return pageSchemaManager.GetDesignInstance(UserConnection, EditSchemaUId).EventsProcessSchema;
			}
			var processSchemaManager = schemaManager as ProcessSchemaManager;
			if (processSchemaManager != null) {
				return processSchemaManager.GetDesignInstance(UserConnection, EditSchemaUId);
			}
			return null;
		}

		public virtual void OkClickMethod() {
			var parameterValues = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameterValues != null && parameterValues.Count > 0) {
				ProcessSchema processSchema = FindDesignedProcessSchema();
				var processSchemaActivity = (ProcessSchemaActivity)processSchema.GetBaseElementByUId(EditElementUId);
				foreach (KeyValuePair<string, ProcessSchemaParameterValue> parameterValue in parameterValues) {
					var parameter = processSchemaActivity.Parameters.GetByName(parameterValue.Key);
					parameter.SourceValue = parameterValue.Value;
					parameter.SourceValue.Value = parameterValue.Value.Value;
					parameter.SourceValue.LocalizableCollectionValue = parameterValue.Value.LocalizableCollectionValue;
					parameter.ReferenceSchemaUId = parameter.SourceValue.ReferenceSchemaUId;
				}
				SaveDesignedProcessSchema(processSchema);
			}
			if (string.IsNullOrEmpty(CallbackClientFunctionName)) {
				return;
			}
			string newCaption = Json.Serialize(ElementNewCaption);
			newCaption = newCaption.Substring(1, newCaption.Length - 2);
			string script = string.Format(@"window.opener.{0}(""{1}"", ""{2}"");", CallbackClientFunctionName, EditElementUId.ToString(), newCaption);
			Page.AddScript(script);
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
		}

		public virtual void InitializeContextHelpButton() {
			if (!GetIsContextHelpButtonHidden() && GetIsContextHelpEnabled()) {
				Page.ContextHelpButton.Hidden = false;
				Page.ContextHelpButton.Image.Source = ControlImageSource.ResourceManager;
				Page.ContextHelpButton.Image.ResourceManagerName = "Terrasoft.WebApp";
				Page.ContextHelpButton.Image.ResourceItemName = "help.png";
				string helpContextId = GetHelpContextId();
				Page.ContextHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(" + (string.IsNullOrEmpty(helpContextId) ?  "null" : helpContextId) + ",'" + Page.ContextHelpButton.ClientID + "')";
			}
		}

		public virtual bool GetIsContextHelpButtonHidden() {
			return true;
		}

		public virtual bool GetIsContextHelpEnabled() {
			return (bool)SysSettings.GetValue(UserConnection, "EnableContextHelp");
		}

		public virtual string GetHelpContextId() {
			return Page.GetParameterValue("helpContextId") as string;
		}

		public virtual void ShowMappingWindow(Dictionary<string, object> parameters) {
			string clientEditCompleteFuncHandlerName = parameters["clientHandler"].ToString();
			string columnName = parameters["columnName"].ToString();
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			var processSchema = FindDesignedProcessSchema();
			ProcessSchemaParameter parameter = ((IParametrizedProcessSchemaElement)processSchema.FindBaseElementByUId(EditElementUId)).Parameters.GetByName(columnName);
			ProcessSchemaParameterValue parameterValue;
			if (parametersValue != null && parametersValue.TryGetValue(columnName, out parameterValue)
					&& parameterValue != null && parameterValue.ReferenceSchemaUId != Guid.Empty) {
				ParameterReferenceSchemaUId = parameterValue.ReferenceSchemaUId;
			} else {
				ParameterReferenceSchemaUId = parameter.ReferenceSchemaUId;
			}
			ParameterDataValueTypeUId = parameter.DataValueType.UId;
			IsParameterLookup = parameter.DataValueType.IsLookup;
			InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter",
				schemaExplorer.ClientID);
			if (string.IsNullOrEmpty(clientEditCompleteFuncHandlerName)) {
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				var sb = new StringBuilder();
				sb.Append("function(columnInfo) {\n");
				sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
				sb.Append("var value = {");
				sb.Append("source: 'Mapping'");
				sb.Append(",value: info.metaPath");
				sb.Append(",displayValue: info.caption");
				sb.Append(",fireEvent: true");
				sb.Append("};");
				//sb.Append("\ndebugger;\n");
				sb.AppendFormat("{0}.setColumnValue('{1}', Ext.util.JSON.encode(value));",
					propertyDataSource.ClientID, columnName);
				sb.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEvent('{0}', 'CloseMappingWindow');", InstanceUId);
				sb.Append("}");
				handler = sb.ToString();
			} else {
				handler = string.Format(@"function(columnInfo) {{ {0}(columnInfo);}}", clientEditCompleteFuncHandlerName);
			}
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", 
				schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", 
				schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = EditSchemaManagerName;
			schemaExplorer.ShowEditWindow(EditSchemaUId, parameter.SourceValue.MetaPath, EditElementUId);
		}

		public virtual void SaveDesignedProcessSchema(ProcessSchema processSchema) {
			var manager = processSchema.ProcessSchemaManager;
			manager.SaveDesignedItemInSessionData(UserConnection, processSchema, processSchema.UId);
		}

		public virtual void UpdateProcessSchemaCustomParameter(ProcessSchemaParameter currentParameter, ProcessSchemaParameter modifiedParameter) {
			currentParameter.Name = modifiedParameter.Name;
			currentParameter.Caption = modifiedParameter.Caption;
			currentParameter.DataValueTypeUId = modifiedParameter.DataValueTypeUId;
			currentParameter.ReferenceSchemaUId = modifiedParameter.ReferenceSchemaUId;
		}

		public virtual void UpdateProcessSchemaUserTaskCustomParameters(ProcessSchema schema, ProcessSchemaUserTask userTask, List<ProcessSchemaParameter> modifiedParameters) {
			var indexes = new List<int>(userTask.Parameters.Count);
			for (int i = 0; i < userTask.Parameters.Count; i++) {
				ProcessSchemaParameter currentParameter = userTask.Parameters[i];
				if (currentParameter.CreatedInSchemaUId == schema.UId) {
					int index = -1;
					for (int j = 0; j < modifiedParameters.Count; j++) {
						ProcessSchemaParameter modifiedParameter = modifiedParameters[j];
						if (currentParameter.UId == modifiedParameter.UId) {
							UpdateProcessSchemaCustomParameter(currentParameter, modifiedParameter);
							index = j;
							break;
						}
					}
					if (index == -1) {
						indexes.Add(i);
					} else {
						modifiedParameters.RemoveAt(index);
					}
				}
			}
			for (int i = indexes.Count - 1; i >= 0; i--) {
				userTask.Parameters.RemoveAt(indexes[i]);
			}
			foreach(ProcessSchemaParameter newParameter in modifiedParameters) {
				userTask.Parameters.Add(newParameter);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CloseMappingWindow":
							if (ActivatedEventElements.Contains("CloseMappingWindowStartMessage")) {
							context.QueueTasks.Enqueue("CloseMappingWindowStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClick")) {
							context.QueueTasks.Enqueue("OkButtonClick");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClick")) {
							context.QueueTasks.Enqueue("CancelButtonClick");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitEvent")) {
							context.QueueTasks.Enqueue("InitEvent");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteEvent")) {
							context.QueueTasks.Enqueue("PageLoadCompleteEvent");
						}
						break;
					case "OnPropertyChange":
							if (ActivatedEventElements.Contains("StartMessageOnPropertyChange")) {
							context.QueueTasks.Enqueue("StartMessageOnPropertyChange");
						}
						break;
					case "ShowMappingWindow":
							if (ActivatedEventElements.Contains("StartMessageShowMappingWindow")) {
							context.QueueTasks.Enqueue("StartMessageShowMappingWindow");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SchemaExplorerKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaExplorerKey", SchemaExplorerKey, null);
			}
			if (!HasMapping("ParameterReferenceSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParameterReferenceSchemaUId", ParameterReferenceSchemaUId, Guid.Empty);
			}
			if (!HasMapping("IsParameterLookup") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsParameterLookup", IsParameterLookup, false);
			}
			if (!HasMapping("ParameterDataValueTypeUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParameterDataValueTypeUId", ParameterDataValueTypeUId, Guid.Empty);
			}
			if (!HasMapping("ElementNewCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ElementNewCaption", ElementNewCaption, null);
			}
			if (Source != null) {
				if (Source.GetType().IsSerializable ||
					Source.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Source", Source, null);
				}
			}
			if (Descriptor != null) {
				if (Descriptor.GetType().IsSerializable ||
					Descriptor.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Descriptor", Descriptor, null);
				}
			}
			if (!HasMapping("SchemaExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaExplorerRegistered", SchemaExplorerRegistered, false);
			}
			if (!HasMapping("SchemaExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaExplorerCreated", SchemaExplorerCreated, false);
			}
			if (!HasMapping("ManagerName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ManagerName", ManagerName, null);
			}
			if (!HasMapping("EditElementUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditElementUId", EditElementUId, Guid.Empty);
			}
			if (!HasMapping("EditSchemaManagerName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaManagerName", EditSchemaManagerName, null);
			}
			if (!HasMapping("EditSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaUId", EditSchemaUId, Guid.Empty);
			}
			if (ParametersValue != null) {
				if (ParametersValue.GetType().IsSerializable ||
					ParametersValue.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ParametersValue", ParametersValue, null);
				}
			}
			if (!HasMapping("CallbackClientFunctionName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CallbackClientFunctionName", CallbackClientFunctionName, null);
			}
			if (PropertyDataSource != null) {
				if (PropertyDataSource.GetType().IsSerializable ||
					PropertyDataSource.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PropertyDataSource", PropertyDataSource, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseProcessParametersEditPageEventsProcess

	/// <exclude/>
	public class BaseProcessParametersEditPageEventsProcess : BaseProcessParametersEditPageEventsProcess<Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl>
	{

		public BaseProcessParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseProcessParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseProcessParametersEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel MainMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("MainMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OkButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
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
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseProcessParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseProcessParametersEditPageEventsProcess(UserConnection);
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

		public virtual void OkButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OkButtonClick");
		}

		public virtual void CancelButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CancelButtonClick");
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
			SchemaName = "BaseProcessParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseProcessParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseProcessParametersEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseProcessParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseProcessParametersEditPageEventsProcessSchema(BaseProcessParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseProcessParametersEditPageEventsProcess";
			UId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreatePropertyDataSourceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e7fe8054-e33d-4fa1-add5-d1b1957d18b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"PropertyDataSource",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("51c2e9fe-83f5-4599-b320-ed00b1eaed84"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"DefaultValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCallbackClientFunctionNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f04d6914-8ef8-42b2-8658-6769141607cc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"CallbackClientFunctionName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParametersValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("74e59eb3-88e8-4360-a02c-e8b95c92fa31"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"ParametersValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4fb7388c-a9bb-4bed-88de-2ff65b70c052"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"EditSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ca81cd22-3179-4516-9375-4f163ff7d824"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"EditSchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditElementUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cf163fc6-50c6-4716-ad01-940650680b7d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"EditElementUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7544c3fd-4702-4864-ad72-ba9f8e06adcf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"ManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d05fce6c-fce3-4f00-bd4b-73a8f3414404"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"SchemaExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e4a666c8-ce9e-4408-8445-eec244b47909"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"SchemaExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3f19b476-8770-4532-a8f2-d54d5050bc20"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"SchemaExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDescriptorParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce549911-61fe-496f-a5af-73fd685d214b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"Descriptor",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSourceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c5e3f3d9-2f1e-4c49-a63b-5e4d4075b8b0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"Source",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateElementNewCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("41d7e88d-5dad-4d40-8183-09498aebf3b6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"ElementNewCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParameterDataValueTypeUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3eaab318-bd00-4867-bbe4-24f0dd6e4841"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"ParameterDataValueTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsParameterLookupParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ecf0f6ec-e81c-4d91-9b37-747cca8092c2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"IsParameterLookup",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParameterReferenceSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8502730e-89ff-43d9-992c-5024a84fdc51"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"ParameterReferenceSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaExplorerKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ec57b088-a81e-46f0-a087-1169731d0e5a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"SchemaExplorerKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePropertyDataSourceParameter());
			Parameters.Add(CreateDefaultValuesParameter());
			Parameters.Add(CreateCallbackClientFunctionNameParameter());
			Parameters.Add(CreateParametersValueParameter());
			Parameters.Add(CreateEditSchemaUIdParameter());
			Parameters.Add(CreateEditSchemaManagerNameParameter());
			Parameters.Add(CreateEditElementUIdParameter());
			Parameters.Add(CreateManagerNameParameter());
			Parameters.Add(CreateSchemaExplorerCreatedParameter());
			Parameters.Add(CreateSchemaExplorerRegisteredParameter());
			Parameters.Add(CreateSchemaExplorerParameter());
			Parameters.Add(CreateDescriptorParameter());
			Parameters.Add(CreateSourceParameter());
			Parameters.Add(CreateElementNewCaptionParameter());
			Parameters.Add(CreateParameterDataValueTypeUIdParameter());
			Parameters.Add(CreateIsParameterLookupParameter());
			Parameters.Add(CreateParameterReferenceSchemaUIdParameter());
			Parameters.Add(CreateSchemaExplorerKeyParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet79 = CreateLaneSet79LaneSet();
			LaneSets.Add(schemaLaneSet79);
			ProcessSchemaLane schemaLane197 = CreateLane197Lane();
			schemaLaneSet79.Lanes.Add(schemaLane197);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess okbuttonclickeventsubprocess2 = CreateOkButtonClickEventSubProcess2EventSubProcess();
			FlowElements.Add(okbuttonclickeventsubprocess2);
			ProcessSchemaEventSubProcess cancelbuttonclickeventsubprocess2 = CreateCancelButtonClickEventSubProcess2EventSubProcess();
			FlowElements.Add(cancelbuttonclickeventsubprocess2);
			ProcessSchemaEventSubProcess initeventsubprocess2 = CreateInitEventSubProcess2EventSubProcess();
			FlowElements.Add(initeventsubprocess2);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess3 = CreatePageLoadCompleteEventSubProcess3EventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocesschildpropertychange = CreateEventSubProcessChildPropertyChangeEventSubProcess();
			FlowElements.Add(eventsubprocesschildpropertychange);
			ProcessSchemaEventSubProcess eventsubprocessshowmappingwindow = CreateEventSubProcessShowMappingWindowEventSubProcess();
			FlowElements.Add(eventsubprocessshowmappingwindow);
			ProcessSchemaStartMessageEvent closemappingwindowstartmessage = CreateCloseMappingWindowStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(closemappingwindowstartmessage);
			ProcessSchemaScriptTask closemappingwindowscript = CreateCloseMappingWindowScriptScriptTask();
			eventsubprocess1.FlowElements.Add(closemappingwindowscript);
			ProcessSchemaScriptTask okbuttonclickscript = CreateOkButtonClickScriptScriptTask();
			okbuttonclickeventsubprocess2.FlowElements.Add(okbuttonclickscript);
			ProcessSchemaStartMessageEvent okbuttonclick = CreateOkButtonClickStartMessageEvent();
			okbuttonclickeventsubprocess2.FlowElements.Add(okbuttonclick);
			ProcessSchemaScriptTask cancelbuttonclickscript = CreateCancelButtonClickScriptScriptTask();
			cancelbuttonclickeventsubprocess2.FlowElements.Add(cancelbuttonclickscript);
			ProcessSchemaStartMessageEvent cancelbuttonclick = CreateCancelButtonClickStartMessageEvent();
			cancelbuttonclickeventsubprocess2.FlowElements.Add(cancelbuttonclick);
			ProcessSchemaScriptTask initscript = CreateInitScriptScriptTask();
			initeventsubprocess2.FlowElements.Add(initscript);
			ProcessSchemaStartMessageEvent initevent = CreateInitEventStartMessageEvent();
			initeventsubprocess2.FlowElements.Add(initevent);
			ProcessSchemaScriptTask pageloadcompletescript = CreatePageLoadCompleteScriptScriptTask();
			pageloadcompleteeventsubprocess3.FlowElements.Add(pageloadcompletescript);
			ProcessSchemaStartMessageEvent pageloadcompleteevent = CreatePageLoadCompleteEventStartMessageEvent();
			pageloadcompleteeventsubprocess3.FlowElements.Add(pageloadcompleteevent);
			ProcessSchemaScriptTask onpropertychangescript = CreateOnPropertyChangeScriptScriptTask();
			eventsubprocesschildpropertychange.FlowElements.Add(onpropertychangescript);
			ProcessSchemaStartMessageEvent startmessageonpropertychange = CreateStartMessageOnPropertyChangeStartMessageEvent();
			eventsubprocesschildpropertychange.FlowElements.Add(startmessageonpropertychange);
			ProcessSchemaScriptTask scriptshowmappingwindow = CreateScriptShowMappingWindowScriptTask();
			eventsubprocessshowmappingwindow.FlowElements.Add(scriptshowmappingwindow);
			ProcessSchemaStartMessageEvent startmessageshowmappingwindow = CreateStartMessageShowMappingWindowStartMessageEvent();
			eventsubprocessshowmappingwindow.FlowElements.Add(startmessageshowmappingwindow);
			FlowElements.Add(CreateSequenceFlow605SequenceFlow());
			FlowElements.Add(CreateSequenceFlow606SequenceFlow());
			FlowElements.Add(CreateSequenceFlow607SequenceFlow());
			FlowElements.Add(CreateSequenceFlow608SequenceFlow());
			FlowElements.Add(CreateSequenceFlow609SequenceFlow());
			FlowElements.Add(CreateSequenceFlow610SequenceFlow());
			FlowElements.Add(CreateSequenceFlow611SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWindowCaptionLocalizableString());
			LocalizableStrings.Add(CreateNewRecordLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1806da1c-9e3e-45c9-a672-2db4c942de16"),
				Name = "WindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewRecordLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("def0b75e-08bb-4e5a-b180-70d784602e5c"),
				Name = "NewRecord",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow605SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow605",
				UId = new Guid("8bf9621a-e8b4-457b-8536-3abb7326ed43"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CurveCenterPosition = new Point(154, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fdef0cd8-bcfb-4e77-bde5-5fe4876ab9c5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("492e7541-1c9c-4657-b565-dbb3a4f83e95"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow606SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow606",
				UId = new Guid("8a5fdb76-e209-4673-9cd6-34a19e9621c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CurveCenterPosition = new Point(158, 182),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb71b882-65f3-4fe1-9af9-cdbaf2b1ae87"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8263887c-3586-4d37-9454-1c298b60a664"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow607SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow607",
				UId = new Guid("b6593634-8979-42c9-a723-6bc5ac8737bf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ff4ddaf-3d97-4070-9104-c5f375fef4a7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("173b5f59-2373-4683-8ca3-3904fb4a33ba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow608SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow608",
				UId = new Guid("c8f531a0-b594-400b-b548-63ec4a0c8cf4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CurveCenterPosition = new Point(163, 526),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("589892e2-1019-44c1-b776-7b9ccff5e24e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2ee1b163-0d46-4fe0-92b1-2716b70b3f09"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow609SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow609",
				UId = new Guid("df74e375-9706-46d0-9c81-eaa547f728f9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CurveCenterPosition = new Point(423, 528),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d01858b6-37f2-4189-9228-73178862ac06"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4cf8158b-7bd4-4d53-9611-8875ecb1f209"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow610SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow610",
				UId = new Guid("5bd9b384-1878-4a8e-b26a-6c67370edb81"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CurveCenterPosition = new Point(176, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8d2dcce5-069d-4c5c-9d0b-8bec4bef5ed0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("be2ed76f-67ad-41b3-b1fe-066ded53409b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow611SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow611",
				UId = new Guid("b53bdad5-5733-4ec7-8a6d-464acd1d1e3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CurveCenterPosition = new Point(625, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf5c03f2-b31e-4174-8ac2-589f9c3762d9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("81a59c3a-54ee-4448-bcd0-4e68598470e5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet79LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet79 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0e659b94-f4aa-48ed-8acc-e39ba93b483d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"LaneSet79",
				Position = new Point(5, 5),
				Size = new Size(1199, 345),
				UseBackgroundMode = false
			};
			return schemaLaneSet79;
		}

		protected virtual ProcessSchemaLane CreateLane197Lane() {
			ProcessSchemaLane schemaLane197 = new ProcessSchemaLane(this) {
				UId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0e659b94-f4aa-48ed-8acc-e39ba93b483d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"Lane197",
				Position = new Point(29, 0),
				Size = new Size(1170, 345),
				UseBackgroundMode = false
			};
			return schemaLane197;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("404ef2d3-9eed-40f9-a5ee-4cdb75895f38"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(294, 175),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(265, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCloseMappingWindowStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cf5c03f2-b31e-4174-8ac2-589f9c3762d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("404ef2d3-9eed-40f9-a5ee-4cdb75895f38"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CloseMappingWindow",
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"CloseMappingWindowStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCloseMappingWindowScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("81a59c3a-54ee-4448-bcd0-4e68598470e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("404ef2d3-9eed-40f9-a5ee-4cdb75895f38"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"CloseMappingWindowScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,206,72,205,77,116,173,40,200,201,47,74,45,114,46,74,77,44,73,77,81,176,85,72,75,204,41,78,181,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,132,192,83,89,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5edbca7a-61f2-4f89-99f0-937ecc5b3c3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"OkButtonClickEventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickEventSubProcess2;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("be2ed76f-67ad-41b3-b1fe-066ded53409b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5edbca7a-61f2-4f89-99f0-937ecc5b3c3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"OkButtonClickScript",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,118,206,201,76,206,246,77,45,201,200,79,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,214,240,155,235,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8d2dcce5-069d-4c5c-9d0b-8bec4bef5ed0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5edbca7a-61f2-4f89-99f0-937ecc5b3c3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"OkButtonClick",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCancelButtonClickEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaCancelButtonClickEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("aed154a5-add5-4bbd-b97c-7f273e719c46"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"CancelButtonClickEventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(240, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCancelButtonClickEventSubProcess2;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("173b5f59-2373-4683-8ca3-3904fb4a33ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aed154a5-add5-4bbd-b97c-7f273e719c46"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"CancelButtonClickScript",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,11,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,157,57,6,49,68,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5ff4ddaf-3d97-4070-9104-c5f375fef4a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aed154a5-add5-4bbd-b97c-7f273e719c46"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"CancelButtonClick",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("73347c4a-2765-411d-897b-0ca96111435f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"InitEventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 359),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(196, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess2;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8263887c-3586-4d37-9454-1c298b60a664"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73347c4a-2765-411d-897b-0ca96111435f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"InitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,219,82,35,55,16,125,54,85,252,131,240,211,184,202,37,127,0,217,84,25,219,108,185,146,5,130,13,60,164,246,65,204,180,97,22,89,154,72,26,204,36,203,191,167,117,153,155,7,123,215,155,165,242,226,177,164,238,163,211,71,82,171,117,155,42,147,51,62,101,134,45,100,174,98,32,153,146,25,40,83,52,186,62,16,1,27,114,187,109,26,13,200,63,199,71,189,209,104,38,216,61,135,5,168,103,80,227,216,164,207,112,45,55,232,101,84,14,67,50,26,145,116,69,192,217,36,228,94,1,123,210,36,99,138,173,193,128,34,107,150,101,169,120,64,160,11,236,65,175,254,85,135,65,127,136,195,19,244,52,144,156,21,227,47,236,5,237,162,43,246,0,212,254,76,164,48,44,21,8,198,52,89,130,82,76,203,149,161,55,115,122,7,247,118,80,73,174,27,255,7,180,133,117,124,244,122,122,124,36,239,191,64,108,200,95,57,168,98,97,20,82,186,101,60,183,132,220,60,215,128,35,218,208,63,234,241,63,251,179,36,53,139,248,17,214,236,102,158,244,63,35,10,70,26,117,33,80,192,156,115,47,151,2,147,43,65,86,140,107,64,135,215,227,163,22,74,16,251,99,158,38,29,32,186,148,190,21,13,6,232,122,16,213,152,113,126,207,226,167,243,92,224,10,73,97,197,222,205,248,164,201,120,18,92,39,60,5,97,154,0,56,227,30,142,62,186,31,20,244,19,19,104,165,246,211,252,110,97,27,104,223,228,124,16,97,192,41,230,6,214,255,117,253,103,28,214,40,238,59,110,128,159,33,232,33,50,90,124,237,154,116,174,47,16,244,82,205,214,153,41,162,6,200,96,215,68,7,69,230,115,68,185,2,86,56,162,203,174,64,228,196,246,210,165,42,174,152,210,208,141,27,243,134,231,58,36,50,55,181,251,128,124,253,90,183,172,60,14,200,5,242,83,184,95,110,48,109,237,221,60,173,163,232,130,147,193,231,128,157,242,234,193,103,47,6,23,195,230,188,64,198,163,218,33,127,78,102,47,25,151,10,84,200,143,126,184,55,23,169,73,25,79,255,134,182,213,93,42,18,185,113,171,221,123,117,147,116,47,15,106,103,155,61,227,222,214,212,246,78,30,153,120,0,148,240,197,40,118,85,222,2,154,142,147,36,178,209,220,204,171,132,93,141,70,125,37,55,253,33,177,31,250,0,102,34,121,190,22,46,206,40,118,255,221,102,66,139,183,188,63,201,4,197,103,27,39,196,123,17,172,105,88,158,173,214,255,198,41,73,117,198,89,225,116,234,168,55,109,12,190,159,136,139,244,65,48,94,94,236,151,162,188,218,253,120,255,32,172,170,123,201,148,11,195,113,156,79,203,243,181,148,89,232,251,157,21,120,138,169,191,175,230,83,156,165,91,42,208,42,70,43,98,151,133,141,179,91,136,224,92,93,83,180,156,183,174,25,172,105,220,23,7,150,69,6,196,216,31,127,140,177,235,140,105,64,228,24,180,190,209,160,150,76,63,121,111,162,221,167,174,69,116,85,126,121,79,127,136,91,73,216,151,75,93,172,96,212,247,39,56,240,65,36,107,133,145,11,112,119,56,221,231,235,38,236,121,78,232,25,48,232,71,48,115,161,13,19,49,156,21,152,133,162,70,178,196,52,186,51,186,211,144,104,74,192,102,90,219,206,162,54,155,244,170,232,163,232,77,192,129,71,42,139,185,45,155,168,29,169,203,81,97,29,60,176,13,196,174,142,75,95,152,188,8,224,220,100,143,192,111,9,59,26,125,75,218,109,73,209,165,10,108,167,164,85,90,175,181,221,21,230,192,99,238,14,173,215,222,125,223,27,39,70,130,101,9,6,194,248,57,199,236,235,227,13,88,246,35,87,209,62,135,198,173,227,157,246,87,22,213,241,210,229,145,154,130,142,85,154,25,249,134,182,227,44,107,180,208,18,211,140,205,80,19,206,180,190,6,45,57,190,68,104,248,227,58,163,64,222,62,36,182,192,238,164,122,210,25,139,97,216,195,193,26,204,150,117,191,225,13,71,199,156,15,91,35,55,26,117,179,2,211,241,51,75,185,125,216,88,3,27,159,125,238,92,10,212,191,206,116,41,79,20,136,58,28,93,218,150,166,152,213,65,36,144,76,97,229,210,241,241,81,89,63,157,236,184,176,91,194,219,140,212,104,125,32,231,72,218,147,133,164,101,233,247,195,51,83,109,23,247,100,75,77,225,222,84,111,13,12,90,230,118,119,217,83,30,74,86,191,99,219,53,172,155,39,52,47,96,51,97,153,85,218,39,207,46,60,13,227,37,185,36,232,160,67,129,51,77,221,66,49,85,252,82,22,105,45,154,213,37,229,188,126,245,81,174,176,64,97,241,227,86,68,149,105,227,1,154,138,29,180,234,139,54,100,169,138,152,191,51,202,97,106,79,208,176,70,164,126,51,59,211,178,54,194,221,179,98,57,55,85,96,21,150,223,255,225,68,216,23,243,233,191,197,254,146,7,148,15,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("eb71b882-65f3-4fe1-9af9-cdbaf2b1ae87"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73347c4a-2765-411d-897b-0ca96111435f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"InitEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1293594a-a239-42dc-95c8-ddd4829751f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"PageLoadCompleteEventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 359),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(215, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess3;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("492e7541-1c9c-4657-b565-dbb3a4f83e95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1293594a-a239-42dc-95c8-ddd4829751f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"PageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,204,78,117,78,44,40,201,204,207,211,208,180,230,229,10,72,76,79,213,243,207,118,42,45,41,201,207,211,115,204,74,172,112,45,75,205,43,41,214,115,206,201,76,206,214,115,78,44,45,78,45,14,75,204,201,76,73,4,233,81,176,85,40,41,42,77,37,172,209,37,53,39,177,18,168,218,212,192,0,168,184,40,181,164,180,40,15,162,21,0,31,63,170,64,130,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fdef0cd8-bcfb-4e77-bde5-5fe4876ab9c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1293594a-a239-42dc-95c8-ddd4829751f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"PageLoadCompleteEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildPropertyChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildPropertyChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("34e2d89f-d003-4603-8c07-a995e611f4a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"EventSubProcessChildPropertyChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 544),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(235, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildPropertyChange;
		}

		protected virtual ProcessSchemaScriptTask CreateOnPropertyChangeScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2ee1b163-0d46-4fe0-92b1-2716b70b3f09"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34e2d89f-d003-4603-8c07-a995e611f4a7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"OnPropertyChangeScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,218,48,20,125,6,137,255,224,229,41,145,80,126,64,25,157,186,129,38,58,65,43,209,238,5,245,193,75,46,197,83,98,71,182,147,46,155,248,239,243,71,66,109,19,65,31,136,132,125,238,185,231,222,123,174,27,204,81,133,57,46,65,2,23,104,142,50,70,37,252,145,233,211,129,179,183,101,3,84,222,241,87,129,176,64,11,146,73,194,40,230,237,103,33,57,161,175,83,196,126,253,134,76,222,206,38,227,201,152,236,81,252,120,98,250,137,139,26,208,124,142,104,93,20,9,250,55,25,143,206,46,17,133,183,33,214,71,206,50,16,98,155,29,160,196,167,40,19,116,27,39,42,217,113,50,110,60,221,61,97,152,98,88,245,37,126,83,138,5,162,138,179,10,184,108,55,10,160,200,223,211,237,162,140,21,117,73,245,69,244,146,62,177,173,9,48,218,130,216,94,153,27,172,26,123,37,106,65,68,85,224,129,224,244,155,26,15,38,84,252,128,54,142,114,7,22,37,232,139,151,197,187,116,211,161,27,100,211,165,203,178,146,173,169,248,66,75,80,227,76,235,2,206,212,97,176,233,154,229,100,79,32,95,81,11,124,94,229,42,126,153,19,121,250,63,179,134,89,9,159,68,99,24,143,221,206,79,209,119,144,246,92,124,37,52,55,53,36,214,82,214,127,90,161,226,191,23,140,166,11,16,192,9,46,200,95,136,189,25,104,117,163,251,7,27,32,88,205,51,48,231,221,201,220,144,40,191,116,16,141,214,2,207,145,159,92,79,143,108,193,91,131,82,36,241,133,6,89,80,178,164,117,153,170,27,1,177,108,43,96,251,15,196,76,207,21,239,34,123,164,70,107,78,59,119,171,5,49,149,26,241,158,56,165,251,106,162,116,195,40,116,149,117,165,245,30,28,16,208,116,214,10,242,207,156,232,192,200,3,36,129,77,7,185,206,106,153,127,164,150,53,174,42,197,210,151,211,41,90,131,84,112,121,176,19,239,11,180,121,142,250,171,63,234,119,68,80,8,48,177,193,140,175,103,86,75,42,228,137,215,239,163,103,202,247,235,176,81,118,65,87,98,163,172,246,192,205,162,198,67,175,131,222,122,55,193,205,224,27,98,223,76,221,198,224,205,244,222,19,119,235,186,5,11,224,59,23,242,210,183,112,230,117,43,204,112,151,231,193,62,55,253,62,42,77,28,100,205,41,146,92,209,252,7,138,50,18,206,140,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageOnPropertyChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("589892e2-1019-44c1-b776-7b9ccff5e24e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34e2d89f-d003-4603-8c07-a995e611f4a7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OnPropertyChange",
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"StartMessageOnPropertyChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessShowMappingWindowEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessShowMappingWindow = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b97739b3-0e94-4234-bc0f-121a6fa9e1e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc397517-3ead-4ae3-8ee3-4830dbfc5f4e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"EventSubProcessShowMappingWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 541),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 139),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessShowMappingWindow;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptShowMappingWindowScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4cf8158b-7bd4-4d53-9611-8875ecb1f209"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b97739b3-0e94-4234-bc0f-121a6fa9e1e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"ScriptShowMappingWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,204,177,10,194,64,16,69,209,94,240,31,166,84,16,127,32,42,8,90,90,41,88,143,235,144,172,224,204,242,246,37,171,127,111,58,219,123,224,78,10,41,10,125,27,13,85,246,146,194,105,31,110,111,3,162,157,39,115,30,209,87,209,42,167,156,152,195,21,223,93,37,178,247,27,137,199,203,18,15,221,114,113,29,162,93,180,148,57,223,179,63,163,173,254,215,245,236,48,142,112,33,70,235,126,9,157,173,183,116,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageShowMappingWindowStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d01858b6-37f2-4189-9228-73178862ac06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b97739b3-0e94-4234-bc0f-121a6fa9e1e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ShowMappingWindow",
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"StartMessageShowMappingWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFillPropertyDataSourceMethod());
			Methods.Add(CreateInitializeSchemaExplorerWindowMethod());
			Methods.Add(CreateGetEditorsBindingMethod());
			Methods.Add(CreateIsParameterValueEditorMethod());
			Methods.Add(CreateBindEditorsMethod());
			Methods.Add(CreateGetDurationsDictionaryMethod());
			Methods.Add(CreateMakeCaptionMethod());
			Methods.Add(CreateInitOnLookupChangeEventMethod());
			Methods.Add(CreateSetDefaultValueMethod());
			Methods.Add(CreateGetDesignElementCaptionMethod());
			Methods.Add(CreateFindDesignedProcessSchemaMethod());
			Methods.Add(CreateOkClickMethodMethod());
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
			Methods.Add(CreateGetHelpContextIdMethod());
			Methods.Add(CreateShowMappingWindowMethod());
			Methods.Add(CreateSaveDesignedProcessSchemaMethod());
			Methods.Add(CreateUpdateProcessSchemaCustomParameterMethod());
			Methods.Add(CreateUpdateProcessSchemaUserTaskCustomParametersMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateFillPropertyDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("abcad915-15e6-4bf1-9efa-a2cdc15a29c4"),
				Name = "FillPropertyDataSource",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7b38d6a9-4515-4c2f-9887-bb1a9bbcbd2c"),
				Name = "sourceObject",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("56c36d57-0fae-4a18-a3c6-44766370ea42"),
				Name = "itemDescriptor",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DesignModeClassDescriptor",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,205,110,27,55,16,62,203,128,223,129,214,33,88,161,194,190,64,170,0,177,228,6,2,18,199,240,95,14,69,15,244,238,40,102,187,218,221,146,92,25,106,35,32,40,250,16,125,140,30,82,32,40,208,62,131,252,70,29,254,173,72,137,218,90,237,165,232,193,150,150,51,243,113,230,227,204,112,86,11,202,73,205,171,26,184,92,78,168,164,87,85,195,51,32,35,114,177,187,72,5,185,101,92,54,180,216,44,62,63,62,90,32,68,14,179,91,90,52,32,208,114,2,51,218,20,210,62,163,209,132,101,146,85,37,229,203,47,133,228,172,124,63,84,232,25,8,113,149,221,195,156,94,80,78,231,32,129,107,147,23,8,185,193,191,146,188,201,100,195,129,228,145,181,81,196,247,20,247,111,53,16,43,98,151,142,171,162,153,151,34,29,23,64,121,50,112,65,160,166,118,225,122,89,195,27,90,210,247,192,113,139,100,18,89,31,220,8,224,227,170,44,65,199,150,190,172,107,43,193,208,22,44,7,158,190,2,105,151,146,126,12,162,239,246,109,88,110,28,194,205,74,120,32,145,232,173,252,199,227,163,222,57,114,133,138,253,155,105,222,31,226,115,0,141,130,88,20,202,151,105,41,36,45,51,56,93,42,132,164,255,10,183,237,15,20,194,152,214,42,6,5,186,254,101,253,105,253,219,250,143,199,159,214,159,31,127,94,127,94,255,190,254,21,191,255,249,248,81,239,53,21,183,76,176,187,66,237,51,163,133,128,227,163,213,30,138,95,230,54,168,164,13,79,197,27,201,133,107,224,156,138,106,38,211,155,105,250,14,238,144,85,201,171,66,120,223,95,144,59,86,230,168,253,134,214,184,53,70,115,150,51,89,113,113,106,150,245,17,206,42,14,52,187,39,201,194,203,105,194,74,194,36,204,39,32,50,206,106,180,73,109,102,51,16,3,77,168,82,207,158,206,191,59,0,183,67,170,158,21,57,30,143,173,204,46,105,241,37,124,223,48,14,185,47,159,10,183,138,26,138,202,94,71,101,144,133,254,63,218,84,219,215,129,19,223,60,183,209,104,189,195,243,2,51,42,209,166,105,96,139,203,138,222,30,155,145,100,42,66,151,204,49,36,33,23,222,97,13,12,197,61,195,111,250,79,115,245,117,85,125,215,212,186,96,90,172,75,152,1,7,84,50,84,185,178,56,165,2,172,186,210,94,17,192,52,37,202,247,8,43,76,144,179,82,50,211,62,218,229,214,103,20,149,13,28,0,131,105,82,152,134,16,7,60,192,241,125,148,237,110,255,36,255,12,114,204,171,120,194,169,20,141,45,91,7,82,107,213,10,180,203,134,4,99,66,56,182,97,243,13,171,170,41,10,173,161,28,220,131,124,98,212,172,87,90,51,57,49,61,2,203,228,28,69,111,249,217,188,150,203,61,0,49,94,7,26,170,215,251,240,97,79,60,219,70,152,235,202,17,213,27,83,189,153,67,120,246,236,137,8,100,20,198,17,164,81,175,183,210,255,125,110,158,6,171,173,87,7,231,133,211,214,139,166,137,217,124,179,2,253,244,5,233,227,101,18,100,29,19,117,65,151,93,22,234,179,223,81,144,138,74,151,45,187,162,54,27,60,42,66,226,124,142,194,203,214,240,154,250,217,246,55,253,108,119,255,193,14,161,241,178,108,189,208,113,119,132,123,193,217,28,111,181,128,177,141,113,32,221,64,233,169,195,167,58,102,20,156,69,203,91,104,182,85,60,157,46,198,206,54,64,219,248,183,218,180,150,174,54,190,167,39,225,95,247,100,144,181,99,193,42,62,68,196,72,213,131,207,158,161,163,35,194,190,189,138,149,169,201,28,194,171,135,248,4,57,198,65,66,194,101,245,160,231,138,234,238,91,204,59,212,243,124,209,129,162,76,157,196,137,208,86,111,181,90,122,205,151,152,132,110,122,214,122,137,153,213,72,213,196,80,236,21,185,43,32,182,15,157,195,131,250,76,44,79,232,117,122,5,210,83,116,248,17,236,127,49,22,253,63,7,17,3,235,119,40,101,25,182,37,95,199,250,103,147,104,163,235,173,107,27,155,36,248,225,206,206,112,132,175,63,70,164,181,204,117,230,170,205,105,218,75,78,223,55,109,125,27,243,173,186,214,71,184,19,183,122,71,233,56,45,165,50,216,48,17,57,170,94,111,23,84,83,223,190,203,108,159,67,219,217,183,5,6,78,159,180,171,1,123,236,237,182,110,125,90,206,170,212,87,178,174,56,61,147,89,173,11,87,192,25,45,216,15,96,114,62,188,18,134,196,47,194,97,176,247,208,220,23,238,104,76,29,134,79,254,129,120,55,67,240,102,160,235,206,52,102,247,250,248,21,146,106,71,212,128,84,3,17,20,234,105,37,239,77,64,182,235,13,61,23,118,182,255,111,77,173,7,0,238,31,51,187,96,82,251,3,195,201,168,235,135,1,219,156,207,171,210,97,70,90,225,86,3,48,240,30,177,186,133,70,90,62,94,74,9,194,41,165,136,244,117,69,115,188,14,4,246,224,191,0,130,218,20,97,49,17,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1879d810-0b1b-4548-84db-20d6a8d93272"),
				Name = "InitializeSchemaExplorerWindow",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,91,79,131,48,20,126,222,146,253,135,142,39,72,72,255,192,194,131,187,184,16,167,49,219,208,231,74,15,147,88,90,210,150,41,49,254,119,219,193,80,46,75,166,47,44,225,59,231,187,156,125,28,137,68,42,126,133,140,172,62,114,38,36,72,20,160,61,72,73,148,72,52,142,66,252,12,47,11,193,181,20,76,225,71,114,0,124,155,114,90,191,153,151,11,150,2,215,33,117,79,208,94,228,53,178,33,165,40,180,143,118,45,238,59,40,125,164,101,1,222,100,60,34,10,69,97,67,93,13,238,12,24,235,66,194,121,99,54,25,167,9,114,59,22,167,1,226,5,99,30,250,52,60,131,202,184,33,222,66,38,142,208,97,240,12,239,215,100,220,75,206,225,253,10,83,151,194,58,170,61,239,248,40,33,76,65,253,99,69,123,247,48,162,109,23,56,92,206,186,206,240,61,225,70,82,62,144,12,204,194,138,166,186,34,250,245,190,191,20,242,152,21,20,232,146,104,242,68,88,1,251,50,7,133,23,12,136,116,189,171,231,111,168,253,119,165,145,208,32,91,88,20,82,31,53,208,22,18,144,192,99,168,172,25,208,106,172,139,148,162,131,121,116,55,77,142,72,129,52,39,228,16,235,84,112,220,154,168,147,225,53,232,80,67,54,47,109,70,215,177,116,142,103,122,73,235,102,132,170,49,176,17,226,173,200,171,82,92,31,109,200,155,143,172,14,94,101,185,46,235,170,88,173,139,87,64,65,48,152,241,175,94,254,113,144,42,116,117,146,1,219,237,190,45,36,16,13,246,244,246,35,172,47,56,109,207,108,225,144,42,147,17,134,221,159,225,83,129,70,151,86,127,20,122,30,122,133,55,67,223,224,119,80,151,134,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c007bd00-74f3-4c1f-8494-5edf467902db"),
				Name = "GetEditorsBinding",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, Terrasoft.UI.WebControls.WebControl>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,105,104,90,3,0,159,228,242,37,69,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsParameterValueEditorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e7cf5d11-73ea-481b-a6da-ca7ecaee67a3"),
				Name = "IsParameterValueEditor",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ba1be00d-744f-418a-8e4d-7b022a1007ef"),
				Name = "propertyName",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1936cd92-745e-4d66-9eb5-2d40cb83dded"),
				Name = "map",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, Terrasoft.UI.WebControls.WebControl>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,77,44,208,115,206,207,43,73,204,204,43,246,78,173,212,40,40,202,47,72,45,42,169,244,75,204,77,213,84,80,83,3,41,136,70,22,140,85,200,44,86,8,40,202,79,78,45,46,14,78,206,72,205,77,12,72,44,2,138,151,164,22,133,37,230,148,166,186,166,100,150,88,3,0,191,89,50,109,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBindEditorsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a530b649-b95e-4f4a-8663-7dbd8706a91f"),
				Name = "BindEditors",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("04304efe-683e-4859-b64c-3b55b47fdb50"),
				Name = "bindingMap",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, Terrasoft.UI.WebControls.WebControl>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c00cc94e-165e-4589-b4be-570ac15f8e16"),
				Name = "propertyDataSource",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("92a30eb1-ee2f-4ac4-9efb-7b08401e57d8"),
				Name = "defValues",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,203,110,26,49,20,93,83,169,255,96,88,36,131,132,172,172,75,105,21,94,41,106,75,81,8,205,162,234,194,204,220,1,55,51,246,212,246,36,160,132,127,175,237,121,48,12,134,178,64,192,125,158,123,238,241,13,185,0,226,175,145,247,21,182,63,73,148,194,140,80,241,81,42,65,217,170,131,30,64,8,34,121,168,240,98,130,31,97,57,224,76,9,30,201,202,239,79,136,42,136,17,101,104,73,89,160,179,190,147,164,141,94,223,191,107,100,69,16,35,49,160,158,141,194,186,73,87,123,134,68,145,57,79,133,15,115,37,82,95,165,2,6,60,74,99,134,252,236,171,135,18,193,19,16,106,187,15,197,67,8,203,112,156,197,75,60,214,77,251,219,169,238,225,153,70,109,83,158,134,200,43,10,245,16,75,163,40,3,212,240,53,100,202,82,48,65,59,253,121,38,2,37,68,232,60,5,194,78,63,10,168,226,162,128,107,77,136,72,52,19,220,7,41,231,254,26,98,50,59,202,40,154,58,107,53,15,32,204,200,10,240,109,16,204,125,65,19,229,101,28,225,49,23,49,81,94,235,245,102,135,229,154,191,104,14,19,109,127,212,195,241,151,57,93,49,18,77,51,26,175,231,117,247,117,183,213,49,149,27,174,238,120,16,81,96,106,50,108,91,102,44,202,209,70,225,137,188,253,67,54,247,240,55,5,169,114,104,7,244,88,126,220,37,247,43,113,239,201,32,237,158,204,206,22,183,152,4,58,57,91,146,214,86,96,227,207,176,92,91,83,57,75,51,128,208,90,36,126,16,219,59,80,246,143,149,66,7,241,84,213,242,218,118,206,198,219,91,205,94,232,228,132,27,231,200,74,76,53,93,57,152,115,207,98,232,114,153,123,255,107,88,14,236,53,115,201,76,228,84,3,248,33,70,113,162,182,158,187,46,190,135,16,4,48,253,206,172,195,108,166,66,193,69,57,102,83,90,194,119,41,13,176,237,149,23,184,186,186,176,64,157,43,167,42,190,208,32,0,243,238,245,3,175,176,88,127,176,118,229,167,244,107,94,115,72,33,50,202,242,22,147,242,86,141,141,173,189,127,208,182,188,13,188,92,202,89,248,105,237,238,246,247,238,57,19,20,42,149,249,203,168,241,247,190,247,146,243,8,209,234,250,114,13,34,231,106,109,61,251,122,205,128,17,231,79,105,98,88,59,58,82,223,74,87,113,143,42,193,135,87,72,128,62,162,172,122,6,245,170,252,167,62,223,244,137,132,163,202,131,138,179,60,176,213,132,195,234,85,23,46,102,115,12,252,25,181,66,18,73,104,161,15,25,107,221,83,71,154,165,241,18,132,115,234,105,233,42,144,85,130,15,113,237,29,231,81,221,104,60,67,240,105,76,34,172,101,45,161,178,3,39,188,165,30,212,9,174,159,59,10,104,101,224,33,176,194,124,30,86,174,14,107,171,50,166,81,236,254,1,92,109,212,53,199,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDurationsDictionaryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("60ad30f5-916d-484d-b2ac-c2282c88b057"),
				Name = "GetDurationsDictionary",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,205,10,194,64,12,132,207,246,41,114,220,133,210,23,168,10,66,197,139,135,130,226,125,217,77,53,208,102,75,118,87,169,226,187,219,250,123,241,52,36,147,9,223,156,141,128,75,98,34,121,14,176,0,198,11,84,100,167,209,200,48,15,81,136,143,57,188,116,169,116,153,53,94,208,216,19,168,90,188,197,16,170,119,186,70,33,239,128,34,118,64,12,107,78,93,177,193,120,48,109,194,160,226,208,163,111,254,103,180,214,112,203,102,95,140,98,229,156,154,254,20,123,191,245,214,180,116,69,183,123,18,40,157,131,82,196,81,79,190,30,15,62,251,145,236,158,9,198,36,252,43,84,62,0,174,146,254,83,223,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("eb1754c5-dfa6-43c3-a0ec-aa0717097031"),
				Name = "MakeCaption",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,137,5,37,153,249,121,10,182,10,197,37,69,153,121,233,122,110,249,69,185,137,37,26,74,213,6,181,10,26,213,134,181,154,74,58,10,225,153,121,41,249,229,80,165,58,10,126,169,229,65,169,201,249,69,41,154,214,0,141,215,128,39,111,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitOnLookupChangeEventMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("61ce9a43-0976-4048-a5eb-896fc1e80e22"),
				Name = "InitOnLookupChangeEvent",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("024f97a7-d791-460b-b0e8-5c535124c50b"),
				Name = "lookup",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ComboBoxEdit",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2c719462-d35b-4a72-8777-3e4a763125c7"),
				Name = "signalName",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,201,207,207,46,45,208,115,204,74,172,112,45,75,205,43,41,214,115,206,72,204,75,79,213,115,173,40,41,74,12,72,44,74,204,77,45,73,45,42,214,115,76,73,209,200,75,45,87,8,245,116,206,207,43,41,202,207,41,214,131,203,106,40,1,101,194,18,115,74,83,149,116,20,144,217,216,20,251,230,167,164,234,5,37,150,107,106,90,115,229,224,178,61,56,51,61,47,49,199,15,168,67,193,86,161,24,206,193,163,3,46,18,146,88,148,158,90,2,181,215,211,5,168,31,170,199,57,39,19,40,237,233,98,13,0,72,147,27,78,244,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDefaultValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a091c7f5-eb8b-4e74-b62f-b0f0a3828a84"),
				Name = "SetDefaultValue",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8af55827-9339-4077-a9e8-4e9d38c8ec59"),
				Name = "parameter",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaParameterValue",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8adbbb81-5807-4569-b023-6f582253a2fc"),
				Name = "value",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9846d813-d767-47a2-b660-3414eb8c88ef"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c2c67dab-489a-4917-9f90-0d2d3f9c4c2d"),
				Name = "propertyName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,207,106,195,48,12,135,207,233,83,248,152,64,201,11,116,25,140,118,135,50,86,10,101,187,140,29,76,172,110,2,215,54,146,211,17,70,223,125,78,220,102,249,51,202,122,180,253,233,147,244,51,238,69,234,36,201,3,120,160,124,103,43,42,65,20,133,216,146,45,129,121,87,126,194,65,110,47,192,171,212,21,68,40,223,88,3,153,248,158,37,211,242,127,84,47,173,97,223,94,44,250,134,246,38,8,142,147,151,21,178,211,178,190,0,170,119,28,112,207,86,225,30,65,173,77,236,254,178,86,1,127,84,232,187,115,224,49,172,221,205,197,103,105,33,76,165,117,187,83,50,121,20,6,190,196,10,75,143,214,72,170,239,216,19,154,143,249,181,85,239,211,44,180,58,205,146,163,36,225,38,194,113,11,201,183,250,23,81,29,38,235,236,193,251,155,197,82,135,63,74,179,198,124,69,115,142,99,52,96,243,67,94,162,225,39,168,83,71,214,1,249,122,19,136,44,6,52,194,223,250,200,123,140,171,67,154,20,4,104,134,191,42,243,7,165,6,13,230,131,218,24,225,233,7,110,16,69,195,168,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDesignElementCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("28ee7b31-a3cf-4f00-a667-1cdbd06c5c6e"),
				Name = "GetDesignElementCaption",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,65,14,130,48,16,69,215,246,20,227,174,221,244,0,54,196,4,197,196,141,33,1,14,208,208,81,27,161,144,78,209,16,227,221,69,129,68,220,205,255,243,255,188,73,125,83,34,81,86,94,177,214,208,46,84,4,7,235,204,30,201,94,28,154,244,119,199,133,98,246,12,252,175,16,129,235,170,74,192,147,173,60,134,206,59,197,94,236,174,61,96,133,53,186,48,156,92,52,228,7,16,107,194,100,220,199,125,113,52,60,49,54,76,198,32,5,104,130,5,188,32,244,185,166,155,98,83,234,132,143,157,110,131,109,220,0,152,81,235,241,25,216,206,142,156,50,50,111,178,224,173,187,112,1,27,160,239,40,147,186,13,189,122,3,10,57,247,49,14,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindDesignedProcessSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8708fd2a-adb9-4f9d-a096-5f5f079c68f9"),
				Name = "FindDesignedProcessSchema",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "ProcessSchema"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,203,10,130,64,20,134,215,9,190,195,105,167,16,190,128,184,42,9,23,133,32,62,192,48,158,76,208,99,204,25,221,68,239,222,136,70,94,134,160,237,207,127,251,122,161,128,229,29,27,113,17,36,74,84,16,65,206,168,142,45,17,74,93,181,20,156,81,103,115,135,23,23,213,82,185,138,6,253,208,117,122,83,246,48,66,182,42,92,14,8,134,116,109,50,225,234,6,222,54,188,143,128,186,186,246,225,233,58,59,133,186,83,180,157,24,46,158,144,171,146,18,98,45,72,162,183,100,56,192,247,115,158,20,126,16,247,72,154,83,213,74,100,30,117,115,225,53,33,204,229,95,20,22,223,7,196,86,97,101,177,24,255,198,25,175,79,141,195,68,248,6,21,85,30,6,215,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cf37d341-74d8-4f30-87b9-d6a3cf2a82fd"),
				Name = "OkClickMethod",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,218,48,20,125,166,82,255,195,29,15,149,35,49,171,237,107,71,181,54,133,137,173,98,209,210,143,103,147,92,192,154,99,71,182,3,202,16,255,189,118,76,91,146,65,183,135,68,190,215,247,156,123,238,71,178,98,26,74,166,89,129,22,245,19,19,21,26,24,66,242,234,49,141,11,152,129,59,158,89,174,36,211,245,23,99,53,151,139,1,36,90,101,104,76,154,45,177,96,73,139,228,250,234,244,132,207,129,116,169,63,13,65,86,66,192,217,89,55,43,141,85,37,45,92,195,121,4,155,211,147,94,139,28,202,150,53,132,49,151,249,29,26,190,144,152,183,34,73,228,50,247,86,190,170,125,247,141,19,191,226,182,118,80,146,28,186,136,90,225,244,27,218,91,102,112,36,176,64,105,111,235,199,73,78,70,57,183,59,135,51,155,60,115,165,145,101,75,32,63,176,110,202,72,24,215,255,213,159,78,249,192,101,183,33,161,13,161,148,215,27,39,255,96,89,244,125,96,141,244,122,234,172,78,243,169,211,216,136,238,189,249,105,170,42,157,97,80,48,236,8,160,205,251,56,128,126,4,251,39,248,94,101,76,240,63,108,38,48,86,66,96,179,92,31,50,30,71,116,210,252,194,57,106,148,25,134,30,185,89,237,83,182,84,252,29,234,185,182,238,73,217,10,15,47,88,107,0,190,161,219,176,234,97,234,116,98,166,110,193,127,234,81,81,218,154,196,76,136,25,203,126,199,130,187,181,25,87,178,81,237,167,19,133,249,106,180,149,150,129,37,48,128,196,117,204,74,31,231,116,127,55,74,210,20,53,247,181,35,217,237,223,244,45,196,11,104,1,222,13,154,86,179,64,73,46,6,251,254,123,148,11,187,132,207,112,233,209,187,172,38,211,188,180,142,96,87,199,88,233,130,89,242,181,191,118,159,154,90,83,85,162,116,221,219,156,111,73,191,191,185,216,246,251,3,112,135,75,119,136,174,220,249,120,165,3,104,127,57,244,65,165,65,86,180,47,203,107,73,216,2,233,77,158,167,141,24,18,52,249,11,66,30,80,107,102,212,220,210,199,9,125,198,89,172,164,213,74,24,234,49,81,0,154,178,49,104,44,148,65,247,39,120,1,199,221,132,254,221,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3c3f4819-1b88-4a0d-a4a4-68f2fb2ab320"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,209,78,195,32,20,134,175,245,41,142,92,108,144,25,30,64,99,204,156,141,229,194,205,168,137,215,108,61,237,170,20,8,80,157,49,190,187,208,106,178,213,52,122,5,252,124,124,252,80,151,64,79,110,48,8,191,48,58,224,46,228,168,236,85,27,130,209,121,93,20,168,41,131,201,4,134,68,166,229,90,97,65,25,131,143,227,163,59,89,33,255,117,158,247,2,184,128,82,42,143,231,163,156,104,82,254,96,90,183,193,72,39,192,25,213,165,125,200,239,209,119,147,91,169,99,232,254,82,13,240,165,108,146,151,60,162,115,210,155,50,240,39,92,207,173,37,255,245,136,128,205,143,100,27,33,110,117,149,14,251,224,106,93,65,138,190,21,162,136,76,252,172,124,63,162,108,252,162,249,179,220,101,175,168,131,231,11,85,111,94,248,74,199,49,174,187,240,176,245,158,148,251,173,121,75,107,74,96,6,180,47,194,133,95,182,74,173,92,214,216,240,78,15,106,49,184,4,32,58,110,19,56,131,193,214,12,200,233,52,137,70,74,246,141,196,117,2,167,44,190,252,243,11,225,246,0,130,55,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cdaefdec-a9c1-4433-8196-ed67558bc814"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c21667fa-c63d-4cb0-ab66-a2d90b4b879c"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetHelpContextIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e0006610-05e6-47ef-bc2a-ef0deb7bdde2"),
				Name = "GetHelpContextId",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,115,79,45,9,72,44,74,204,77,45,73,45,10,75,204,41,77,213,80,202,72,205,41,112,206,207,43,73,173,40,241,76,81,210,84,72,44,86,40,46,41,202,204,75,183,6,0,132,208,221,229,57,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowMappingWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6f5b063d-bed8-432c-b024-ea2ea572943c"),
				Name = "ShowMappingWindow",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2b8c3f77-f3da-4793-b83f-dfdf0e4bd3c6"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,219,110,219,56,16,125,78,129,254,3,87,15,181,4,8,236,229,49,110,138,205,181,235,197,38,45,106,55,125,216,20,5,35,141,109,238,202,164,64,82,113,92,195,255,222,225,197,178,46,246,6,91,244,205,154,203,225,153,225,204,161,181,81,92,204,72,86,112,16,230,50,231,230,92,46,202,2,12,92,85,34,251,131,137,188,0,117,195,22,64,78,72,201,20,254,48,160,244,223,145,143,15,254,232,43,157,200,177,3,138,147,225,243,103,58,96,202,162,90,136,125,201,181,163,155,249,192,84,35,242,150,21,149,205,253,216,177,48,77,46,120,102,184,20,76,173,222,250,211,82,242,81,201,12,180,30,103,115,88,176,58,197,101,188,219,66,55,67,16,248,138,139,252,2,52,159,9,200,91,233,142,204,126,192,29,63,4,136,227,81,112,40,254,189,131,113,89,192,2,123,148,180,14,165,246,200,51,166,33,120,207,86,159,71,121,108,251,30,12,248,153,36,116,87,49,125,15,24,100,123,21,239,218,118,152,157,111,80,217,250,196,96,62,37,113,183,175,191,157,16,81,21,5,121,241,162,219,114,58,81,43,60,214,253,110,156,154,18,89,153,14,118,242,252,217,209,81,19,225,48,182,135,254,4,83,80,32,50,240,196,177,92,27,252,190,226,57,189,92,148,102,149,144,53,66,214,245,236,9,63,121,26,18,43,222,16,40,52,252,31,176,3,56,216,233,109,196,5,51,204,29,57,89,149,208,205,110,57,169,79,30,233,58,247,47,41,255,173,202,255,200,24,105,31,98,211,4,55,156,21,56,81,97,146,30,203,66,42,80,95,112,118,228,178,94,20,221,114,34,116,59,218,174,137,183,224,130,85,153,169,20,108,93,187,29,157,251,13,198,100,111,240,151,208,243,215,173,9,219,28,130,175,164,90,48,19,71,75,71,140,174,95,109,190,53,37,164,46,62,74,241,26,218,116,233,185,83,144,209,69,18,198,51,64,142,244,13,14,206,7,229,120,196,79,202,82,226,231,37,44,119,9,202,172,108,91,199,178,82,153,147,142,190,17,219,114,203,149,169,88,177,51,14,3,134,190,199,28,1,75,226,53,233,172,226,69,14,202,117,252,72,223,211,211,178,4,145,199,209,20,73,88,249,9,203,49,18,83,137,60,238,68,212,13,180,152,28,189,136,122,249,104,104,101,120,65,255,28,127,184,161,57,100,50,135,102,254,112,111,242,67,144,192,117,207,171,29,241,99,50,184,102,101,137,92,7,189,136,212,37,31,59,2,20,239,1,85,194,204,251,81,57,215,101,193,86,183,141,224,140,149,182,188,126,236,148,227,16,61,224,149,28,19,156,41,232,5,108,66,21,47,95,54,140,119,34,135,251,106,54,195,185,235,181,104,59,65,56,58,84,3,222,178,237,135,23,158,193,250,245,102,144,118,250,134,51,104,251,230,42,75,176,103,118,176,142,250,55,95,79,87,74,218,170,217,63,57,204,238,4,148,98,90,78,13,61,253,135,61,94,131,153,203,92,211,201,92,201,165,199,114,101,35,169,87,150,212,224,188,144,26,66,231,253,90,14,44,27,50,18,218,48,220,19,43,227,221,222,248,210,27,27,119,223,126,252,26,146,213,91,203,192,246,247,3,163,183,38,200,171,53,77,155,13,178,121,122,125,188,194,29,62,14,97,237,244,189,182,104,251,180,160,182,186,39,137,205,128,142,51,197,75,115,205,4,126,40,122,154,231,222,16,119,36,195,174,252,250,205,102,203,157,86,34,190,139,240,156,187,40,181,230,33,113,5,28,150,141,148,68,128,117,101,161,174,3,244,146,39,105,253,36,125,75,89,118,40,255,42,190,29,132,192,37,40,175,189,76,175,234,13,123,63,105,60,151,75,27,26,158,140,93,22,14,102,218,120,131,252,186,248,119,244,58,72,68,74,58,255,71,134,63,0,245,217,190,129,37,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveDesignedProcessSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bd0874d6-d4dd-49b1-820d-f1e107e35bd7"),
				Name = "SaveDesignedProcessSchema",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("26ace62a-e5b6-44df-acfe-d6bd44bc3742"),
				Name = "processSchema",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,77,204,75,76,79,45,82,176,85,40,40,202,79,78,45,46,14,78,206,72,205,77,212,11,64,230,249,66,20,89,115,65,85,235,5,39,150,165,186,164,22,103,166,231,165,166,120,150,164,230,122,230,5,3,21,103,230,231,185,36,150,36,106,132,22,167,22,57,231,231,229,165,38,151,0,133,116,80,77,70,227,234,133,122,166,104,90,115,1,0,253,222,224,13,139,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateProcessSchemaCustomParameterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b1aed4d4-f71c-41a5-a18e-3b1659cd26b2"),
				Name = "UpdateProcessSchemaCustomParameter",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cb821c14-3db7-4d5c-a117-16981cb8d4ff"),
				Name = "currentParameter",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaParameter",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4bf34b93-40f7-45d1-99d2-e49c1f32266a"),
				Name = "modifiedParameter",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaParameter",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,46,45,42,74,205,43,9,72,44,74,204,77,45,73,45,210,243,3,210,10,182,10,185,249,41,153,105,153,169,41,168,18,214,92,201,232,234,157,19,11,74,50,243,243,176,106,129,202,97,209,229,146,88,146,24,150,152,83,154,26,82,89,144,26,234,153,130,85,59,186,34,44,230,4,165,166,165,2,69,146,83,131,147,51,82,115,19,113,153,132,169,204,26,0,102,135,203,97,249,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateProcessSchemaUserTaskCustomParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2628f1f0-4708-4c09-9e7a-65c2f7292b15"),
				Name = "UpdateProcessSchemaUserTaskCustomParameters",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("243f2398-5985-40f3-bc80-2420b463b3d0"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9fa2b10a-ef70-4f61-99d9-93c27823ae9e"),
				Name = "userTask",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9dcdbb42-0b0c-4cbc-b208-b3070c8f7222"),
				Name = "modifiedParameters",
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<ProcessSchemaParameter>",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,193,110,131,48,12,134,207,225,41,124,164,234,64,235,153,82,169,234,169,210,14,213,182,158,170,29,50,98,212,208,17,166,36,116,147,38,222,125,78,66,219,117,128,4,2,131,253,217,191,243,159,185,6,169,4,126,163,129,28,20,126,193,147,52,118,41,149,93,197,173,65,253,202,205,41,221,113,205,107,180,168,77,186,105,90,101,103,89,84,54,26,98,202,2,73,101,143,25,61,150,48,153,79,191,231,243,25,252,68,108,167,155,2,141,121,41,142,88,243,107,26,20,173,214,168,236,237,67,62,6,59,200,183,44,98,178,132,248,127,126,186,209,200,45,138,173,10,228,253,86,64,158,131,241,65,74,145,111,206,252,188,78,44,241,147,5,177,216,85,70,21,100,84,36,163,110,132,44,37,138,161,138,170,87,193,166,116,12,74,137,58,196,29,42,167,131,141,43,233,71,31,84,221,84,48,182,255,20,164,246,110,134,77,107,108,83,95,179,7,220,135,33,113,230,135,96,151,133,84,33,124,167,77,158,252,107,23,133,219,141,217,39,185,181,245,67,244,166,73,215,66,196,210,163,58,192,15,131,225,239,200,14,159,177,110,206,184,182,129,21,42,34,186,186,123,47,93,184,126,229,144,192,194,121,107,21,60,150,36,190,249,152,207,238,233,232,188,66,45,60,27,121,113,140,39,14,140,12,127,11,164,26,57,172,201,142,78,248,223,114,215,238,23,188,53,200,104,78,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseProcessParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"));
		}

		#endregion

	}

	#endregion

}

