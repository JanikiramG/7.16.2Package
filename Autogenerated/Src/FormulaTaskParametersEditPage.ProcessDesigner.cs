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
	using System.Text.RegularExpressions;
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

	#region Class: FormulaTaskParametersEditPageSchema

	/// <exclude/>
	public class FormulaTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label2;
		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return _label2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionTextEdit {
			get {
				return _captionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label1;
		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return _label1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _setParameterTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SetParameterTextEdit {
			get {
				return _setParameterTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _setParameterToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton SetParameterToolButton {
			get {
				return _setParameterToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _hiddenInsertParameterLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit HiddenInsertParameterLookupEdit {
			get {
				return _hiddenInsertParameterLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _hiddenSetParameterEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit HiddenSetParameterEdit {
			get {
				return _hiddenSetParameterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _pageContainerFormula;
		public Terrasoft.UI.WebControls.Controls.PageContainer PageContainerFormula {
			get {
				return _pageContainerFormula;
			}
		}

		#endregion

		#region Constructors: Public

		public FormulaTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public FormulaTaskParametersEditPageSchema(FormulaTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			RealUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			Name = "FormulaTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "636";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFormulaTaskParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateLabel2());
			ControlLayout2.InsertItem(1, CreateCaptionTextEdit());
			TopControlLayout.InsertItem(1, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateLabel1());
			ControlLayout1.InsertItem(1, CreateSetParameterTextEdit());
			SetParameterTextEdit.InsertItem(0, CreateSetParameterToolButton());
			TopControlLayout.InsertItem(2, CreateHiddenInsertParameterLookupEdit());
			TopControlLayout.InsertItem(3, CreateHiddenSetParameterEdit());
			TopControlLayout.InsertItem(4, CreatePageContainerFormula());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateFormulaTaskParametersEditPageEventsProcessSchema() {
			var schema = new FormulaTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel2() {
			_label2 = new Terrasoft.UI.WebControls.Controls.Label();
			_label2.UId = new Guid("95cb00fb-361e-4d3b-a47d-85ad8c0662fa");
			_label2.Name = "Label2";
			_label2.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_label2.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_label2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label2.Tag = "";
			_label2.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label2.Width = System.Web.UI.WebControls.Unit.Pixel(170);
			_label2.Margins = "3";
			return _label2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionTextEdit() {
			_captionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionTextEdit.UId = new Guid("1c233916-923b-4be9-b63f-7cda5a865250");
			_captionTextEdit.Name = "CaptionTextEdit";
			_captionTextEdit.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_captionTextEdit.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_captionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionTextEdit.Tag = "";
			_captionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionTextEdit.Image = new ControlImage {};
			_captionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionTextEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_captionTextEdit.AlignedByCaption = false;
			return _captionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("e564c196-b8c8-4115-8711-04a966966a22");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_controlLayout2.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel1() {
			_label1 = new Terrasoft.UI.WebControls.Controls.Label();
			_label1.UId = new Guid("d645ff11-2717-42da-b6bc-01454ca64ad6");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_label1.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,253,132,16);
			_label1.Width = System.Web.UI.WebControls.Unit.Pixel(170);
			_label1.Margins = "3";
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateSetParameterToolButton() {
			_setParameterToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_setParameterToolButton.UId = new Guid("070c16f0-bd3a-4163-9b95-f78d2ad3528d");
			_setParameterToolButton.Name = "SetParameterToolButton";
			_setParameterToolButton.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_setParameterToolButton.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_setParameterToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setParameterToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_setParameterToolButton.Tag = "";
			_setParameterToolButton.Image = new ControlImage {};
			return _setParameterToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSetParameterTextEdit() {
			_setParameterTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_setParameterTextEdit.UId = new Guid("4b0ec2e8-add0-4f6e-a3c7-ff0271ff88b9");
			_setParameterTextEdit.Name = "SetParameterTextEdit";
			_setParameterTextEdit.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_setParameterTextEdit.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_setParameterTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setParameterTextEdit.Tag = "";
			_setParameterTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_setParameterTextEdit.Image = new ControlImage {};
			_setParameterTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_setParameterTextEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_setParameterTextEdit.AlignedByCaption = false;
			_setParameterTextEdit.Enabled = false;
			_setParameterTextEdit.Required = true;
			return _setParameterTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("d87d316e-015d-4395-9c30-0c30883d43d5");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_controlLayout1.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateHiddenInsertParameterLookupEdit() {
			_hiddenInsertParameterLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_hiddenInsertParameterLookupEdit.UId = new Guid("1066995f-7034-4863-a76e-8ea3cf0a5545");
			_hiddenInsertParameterLookupEdit.Name = "HiddenInsertParameterLookupEdit";
			_hiddenInsertParameterLookupEdit.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_hiddenInsertParameterLookupEdit.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_hiddenInsertParameterLookupEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_hiddenInsertParameterLookupEdit.Tag = "";
			_hiddenInsertParameterLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_hiddenInsertParameterLookupEdit.Image = new ControlImage {};
			_hiddenInsertParameterLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_hiddenInsertParameterLookupEdit.Hidden = true;
			return _hiddenInsertParameterLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateHiddenSetParameterEdit() {
			_hiddenSetParameterEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_hiddenSetParameterEdit.UId = new Guid("9f06a27b-0739-40db-8663-7925fb6c463b");
			_hiddenSetParameterEdit.Name = "HiddenSetParameterEdit";
			_hiddenSetParameterEdit.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_hiddenSetParameterEdit.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_hiddenSetParameterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_hiddenSetParameterEdit.Tag = "";
			_hiddenSetParameterEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_hiddenSetParameterEdit.Image = new ControlImage {};
			_hiddenSetParameterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_hiddenSetParameterEdit.Hidden = true;
			return _hiddenSetParameterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreatePageContainerFormula() {
			_pageContainerFormula = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_pageContainerFormula.UId = new Guid("0b71f54e-5b38-489f-a423-7659c345635b");
			_pageContainerFormula.Name = "PageContainerFormula";
			_pageContainerFormula.CreatedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_pageContainerFormula.ModifiedInSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			_pageContainerFormula.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_pageContainerFormula.Tag = "";
			_pageContainerFormula.PageSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_pageContainerFormula.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageContainerFormula.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageContainerFormula.StartNewAlignGroup = false;
			_pageContainerFormula.Edges = "";
			return _pageContainerFormula;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new FormulaTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new FormulaTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new FormulaTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: FormulaTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class FormulaTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.FormulaTaskParametersEditPageSchemaUserControl
	{

		public FormulaTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormulaTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130");
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

		public virtual string MetaPathValue {
			get;
			set;
		}

		private ProcessFlowElement _setParameterToolButtonClickEventSubProcess;
		public ProcessFlowElement SetParameterToolButtonClickEventSubProcess {
			get {
				return _setParameterToolButtonClickEventSubProcess ?? (_setParameterToolButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SetParameterToolButtonClickEventSubProcess",
					SchemaElementUId = new Guid("9a96a387-45a2-4036-911f-40db893884a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _setParameterToolButtonClickStartMessage;
		public ProcessFlowElement SetParameterToolButtonClickStartMessage {
			get {
				return _setParameterToolButtonClickStartMessage ?? (_setParameterToolButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SetParameterToolButtonClickStartMessage",
					SchemaElementUId = new Guid("d93e5b00-39b3-4abd-9cd3-86b336bd8ad3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setParameterToolButtonClickScriptTask;
		public ProcessScriptTask SetParameterToolButtonClickScriptTask {
			get {
				return _setParameterToolButtonClickScriptTask ?? (_setParameterToolButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetParameterToolButtonClickScriptTask",
					SchemaElementUId = new Guid("a758e8e8-35ab-4e34-994e-2774a2273f29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetParameterToolButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _initEventSubProcess;
		public ProcessFlowElement InitEventSubProcess {
			get {
				return _initEventSubProcess ?? (_initEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess",
					SchemaElementUId = new Guid("a8351fee-c862-45dd-9034-aa0ddfb54306"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInitStartMessage;
		public ProcessFlowElement ChildInitStartMessage {
			get {
				return _childInitStartMessage ?? (_childInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInitStartMessage",
					SchemaElementUId = new Guid("1839f17a-7070-400b-adf8-971e3e64546f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent BaseInitIntermediateThrowMessageEvent {
			get {
				return _baseInitIntermediateThrowMessageEvent ?? (_baseInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("d7230d53-a658-4922-9652-4ab844811653"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childScriptTask;
		public ProcessScriptTask ChildScriptTask {
			get {
				return _childScriptTask ?? (_childScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildScriptTask",
					SchemaElementUId = new Guid("72eed408-a39c-4e34-a3f2-75fa383d1c05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleateEventSubProcess;
		public ProcessFlowElement PageLoadCompleateEventSubProcess {
			get {
				return _pageLoadCompleateEventSubProcess ?? (_pageLoadCompleateEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleateEventSubProcess",
					SchemaElementUId = new Guid("cfd8558a-bc69-4d45-988b-51796220a556"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage;
		public ProcessFlowElement PageLoadCompleteStartMessage {
			get {
				return _pageLoadCompleteStartMessage ?? (_pageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("afa8e1ef-1779-462d-adda-81ac15ab5e98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleateIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadCompleateIntermediateThrowMessageEvent {
			get {
				return _pageLoadCompleateIntermediateThrowMessageEvent ?? (_pageLoadCompleateIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleateIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("1b0efaa7-b294-45e2-8462-1126a65ed165"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("b8191027-0ec9-432d-a84e-efa59e258f23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _okButtonClickEventSubProcess;
		public ProcessFlowElement OkButtonClickEventSubProcess {
			get {
				return _okButtonClickEventSubProcess ?? (_okButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OkButtonClickEventSubProcess",
					SchemaElementUId = new Guid("aa09ad86-baad-40fe-b404-b2e9dbaa273e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childOkButtonClickStartMessage;
		public ProcessFlowElement ChildOkButtonClickStartMessage {
			get {
				return _childOkButtonClickStartMessage ?? (_childOkButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildOkButtonClickStartMessage",
					SchemaElementUId = new Guid("ba056378-390d-4676-a80f-33b9eeacf933"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseOkButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent BaseOkButtonClickIntermediateThrowMessageEvent {
			get {
				return _baseOkButtonClickIntermediateThrowMessageEvent ?? (_baseOkButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseOkButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("2d2a8388-ab0b-4e47-b547-325db3b43209"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _okButtonClickScriptTask;
		public ProcessScriptTask OkButtonClickScriptTask {
			get {
				return _okButtonClickScriptTask ?? (_okButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickScriptTask",
					SchemaElementUId = new Guid("d9f1cb98-c8c7-421b-8b7c-d107d7f542a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SetParameterToolButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SetParameterToolButtonClickEventSubProcess };
			FlowElements[SetParameterToolButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SetParameterToolButtonClickStartMessage };
			FlowElements[SetParameterToolButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetParameterToolButtonClickScriptTask };
			FlowElements[InitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess };
			FlowElements[ChildInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitStartMessage };
			FlowElements[BaseInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInitIntermediateThrowMessageEvent };
			FlowElements[ChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildScriptTask };
			FlowElements[PageLoadCompleateEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleateEventSubProcess };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleateIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleateIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[OkButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickEventSubProcess };
			FlowElements[ChildOkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildOkButtonClickStartMessage };
			FlowElements[BaseOkButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseOkButtonClickIntermediateThrowMessageEvent };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SetParameterToolButtonClickEventSubProcess":
						break;
					case "SetParameterToolButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("SetParameterToolButtonClickScriptTask");
						break;
					case "SetParameterToolButtonClickScriptTask":
						break;
					case "InitEventSubProcess":
						break;
					case "ChildInitStartMessage":
						e.Context.QueueTasks.Enqueue("BaseInitIntermediateThrowMessageEvent");
						break;
					case "BaseInitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ChildScriptTask");
						break;
					case "ChildScriptTask":
						break;
					case "PageLoadCompleateEventSubProcess":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleateIntermediateThrowMessageEvent":
						break;
					case "PageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("PageLoadCompleateIntermediateThrowMessageEvent");
						break;
					case "OkButtonClickEventSubProcess":
						break;
					case "ChildOkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
						break;
					case "BaseOkButtonClickIntermediateThrowMessageEvent":
						break;
					case "OkButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("BaseOkButtonClickIntermediateThrowMessageEvent");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SetParameterToolButtonClickStartMessage");
			ActivatedEventElements.Add("ChildInitStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("ChildOkButtonClickStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SetParameterToolButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SetParameterToolButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetParameterToolButtonClickStartMessage";
					result = SetParameterToolButtonClickStartMessage.Execute(context);
					break;
				case "SetParameterToolButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetParameterToolButtonClickScriptTask";
					result = SetParameterToolButtonClickScriptTask.Execute(context, SetParameterToolButtonClickScriptTaskExecute);
					break;
				case "InitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitStartMessage";
					result = ChildInitStartMessage.Execute(context);
					break;
				case "BaseInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = BaseInitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ChildScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildScriptTask";
					result = ChildScriptTask.Execute(context, ChildScriptTaskExecute);
					break;
				case "PageLoadCompleateEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleateIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleateIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "OkButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildOkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildOkButtonClickStartMessage";
					result = ChildOkButtonClickStartMessage.Execute(context);
					break;
				case "BaseOkButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = BaseOkButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "OkButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickScriptTask";
					result = OkButtonClickScriptTask.Execute(context, OkButtonClickScriptTaskExecute);
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
				case "MetaPathValue":
					MetaPathValue = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SetParameterToolButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			var processSchema = FindDesignedProcessSchema();
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter", schemaExplorer.ClientID);
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			var sb = new StringBuilder();
			sb.Append("function(columnInfo) {\n");
			sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
			sb.AppendFormat("{0}.setValue(info.metaPath);", Page.HiddenSetParameterEdit.ClientID);
			sb.AppendFormat("{0}.setValue(info.caption);", Page.SetParameterTextEdit.ClientID);
			sb.Append("}");
			handler = sb.ToString();
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = processSchema.Manager.Name;
			schemaExplorer.ShowEditWindow(processSchema.UId, Page.HiddenSetParameterEdit.Text);
			return true;
		}

		public virtual bool ChildScriptTaskExecute(ProcessExecutingContext context) {
			InitializeContextHelpButton();
			if (Ext.IsAjaxRequest) {
				if (SchemaExplorerCreated) {
					InitializeSchemaExplorerWindow();
				}
			} else {
				var formulaPageProcess = GetFormulaPageProcess();
				formulaPageProcess.EditSchemaUId = EditSchemaUId;
				formulaPageProcess.EditSchemaManagerName = EditSchemaManagerName;
				formulaPageProcess.MessagePanelClientId = Page.MainMessagePanel.ClientID;
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var formulaTask = (ProcessSchemaFormulaTask)processSchema.GetBaseElementByUId(EditElementUId);
			Page.CaptionTextEdit.Text = formulaTask.Caption;
			var formulaPageProcess = GetFormulaPageProcess();
			formulaPageProcess.SetFormulaBody(formulaTask.Body);
			if (!string.IsNullOrEmpty(formulaTask.ResultParameterMetaPath)) {
				Page.SetParameterTextEdit.Text = formulaPageProcess.GetPropertyDisplayPathByServerMetaPath(
					formulaPageProcess.GetPropertyServerMetaPathByClientMetaPath(formulaTask.ResultParameterMetaPath));
			}
			if (!string.IsNullOrEmpty(Page.SetParameterTextEdit.Text)) {
				Page.HiddenSetParameterEdit.Text = formulaTask.ResultParameterMetaPath;
			}
			return true;
		}

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var formulaTask = (ProcessSchemaFormulaTask)processSchema.GetBaseElementByUId(EditElementUId);
			var formulaPageProcess = GetFormulaPageProcess();
			ElementNewCaption = Page.CaptionTextEdit.Text;
			formulaTask.Caption.Value = Page.CaptionTextEdit.Text;
			formulaTask.ResultParameterMetaPath = Page.HiddenSetParameterEdit.Text;
			formulaTask.Body = formulaPageProcess.GetFormulaBody();
			processSchema.SchemaManager.SaveDesignedItemInSessionData(UserConnection, processSchema, processSchema.UId);
			return true;
		}

		public override void InitializeSchemaExplorerWindow() {
			Guid ReadDataUserTaskSchemaId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f");
			bool isNewSchemaExplorer = SchemaExplorer == null;
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			if (isNewSchemaExplorer) {
				schemaExplorer = new SchemaStructureExplorer(Page.TopControlLayout, "schemaStructure", false, false);
			}
			if (isNewSchemaExplorer) {
				schemaExplorer.ManagerName = EditSchemaManagerName;
			} else {
				schemaExplorer.IncludedDataValueTypes.Clear();
			}
			schemaExplorer.IgnoredUserTaskSchemas.Clear();
			schemaExplorer.IgnoredUserTaskSchemas.Add(ReadDataUserTaskSchemaId);
			DataValueTypeManager dataValueTypeManager = UserConnection.DataValueTypeManager;
			Collection<DataValueType> stringsTypes = dataValueTypeManager.GetDataValueTypesByGroupName("Strings");
			Collection<DataValueType> numbersTypes = dataValueTypeManager.GetDataValueTypesByGroupName("Numbers");
			Collection<DataValueType> datesTypes = dataValueTypeManager.GetDataValueTypesByGroupName("Dates");
			Guid dbObjectNameUId = dataValueTypeManager.GetItemByName("DBObjectName").UId;
			foreach(DataValueType type in stringsTypes) {
				// TODO CR 139842
				if (type.UId != dbObjectNameUId) {
					schemaExplorer.IncludedDataValueTypes.Add(type.UId, Guid.Empty);
				}
			}
			foreach(DataValueType type in numbersTypes) {
				schemaExplorer.IncludedDataValueTypes.Add(type.UId, Guid.Empty);
			}
			foreach(DataValueType type in datesTypes) {
				schemaExplorer.IncludedDataValueTypes.Add(type.UId, Guid.Empty);
			}
			schemaExplorer.IncludedDataValueTypes.Add(dataValueTypeManager.GetItemByName("Boolean").UId, Guid.Empty);
			schemaExplorer.IncludedDataValueTypes.Add(dataValueTypeManager.GetItemByName("Guid").UId, Guid.Empty);
			schemaExplorer.IncludedDataValueTypes.Add(dataValueTypeManager.GetItemByName("Lookup").UId, Guid.Empty);
			//// #280215 Process: Отключить фильтрацию по типу данных при выборе параметра для сохранения результата "Формулы" в БП
			schemaExplorer.IncludedDataValueTypes.Clear();
			schemaExplorer.IsInputSchemaParameterMode = true;
			SchemaExplorerCreated = true;
			if (!SchemaExplorerRegistered) {
				schemaExplorer.Register();
				SchemaExplorerRegistered = true;
			}
			SchemaExplorer = schemaExplorer;
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.CaptionTextEdit.Text) ?
				ElementNewCaption : Page.CaptionTextEdit.Text;
		}

		public override void InitializeContextHelpButton() {
			base.InitializeContextHelpButton();
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl> GetFormulaPageProcess() {
			var formulaPage = Page.PageContainerFormula.PageInstance as Terrasoft.WebApp.FormulaEditPageSchemaUserControl;
			if (formulaPage != null) {
				return (Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>)formulaPage.Process;
			}
			return null;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SetParameterToolButtonClick":
							if (ActivatedEventElements.Contains("SetParameterToolButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("SetParameterToolButtonClickStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInitStartMessage")) {
							context.QueueTasks.Enqueue("ChildInitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("ChildOkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ChildOkButtonClickStartMessage");
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
			if (!HasMapping("MetaPathValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MetaPathValue", MetaPathValue, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: FormulaTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class FormulaTaskParametersEditPageEventsProcess : FormulaTaskParametersEditPageEventsProcess<Terrasoft.WebApp.FormulaTaskParametersEditPageSchemaUserControl>
	{

		public FormulaTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormulaTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class FormulaTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SetParameterTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SetParameterTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton SetParameterToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("SetParameterToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit HiddenInsertParameterLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("HiddenInsertParameterLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit HiddenSetParameterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("HiddenSetParameterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer PageContainerFormula {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("PageContainerFormula", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SetParameterToolButton.AjaxEvents.Click.Event += SetParameterToolButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SetParameterToolButton.AjaxEvents.Click.Event -= SetParameterToolButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (FormulaTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new FormulaTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void SetParameterToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SetParameterToolButtonClick");
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
			SchemaName = "FormulaTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: FormulaTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class FormulaTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public FormulaTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FormulaTaskParametersEditPageEventsProcessSchema(FormulaTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FormulaTaskParametersEditPageEventsProcess";
			UId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateMetaPathValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ddcf2db0-2f64-4c88-9e00-415bac06bea5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"MetaPathValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateMetaPathValueParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaFormulaTaskParametersEditPageEventsProcessLaneSet = CreateFormulaTaskParametersEditPageEventsProcessLaneSetLaneSet();
			LaneSets.Add(schemaFormulaTaskParametersEditPageEventsProcessLaneSet);
			ProcessSchemaLane schemaAddParameterToolButtonClickLane = CreateAddParameterToolButtonClickLaneLane();
			schemaFormulaTaskParametersEditPageEventsProcessLaneSet.Lanes.Add(schemaAddParameterToolButtonClickLane);
			ProcessSchemaLane schemaInitLane = CreateInitLaneLane();
			schemaFormulaTaskParametersEditPageEventsProcessLaneSet.Lanes.Add(schemaInitLane);
			ProcessSchemaLane schemaPageLoadCompleateLane = CreatePageLoadCompleateLaneLane();
			schemaFormulaTaskParametersEditPageEventsProcessLaneSet.Lanes.Add(schemaPageLoadCompleateLane);
			ProcessSchemaLane schemaOkButtonClickLane = CreateOkButtonClickLaneLane();
			schemaFormulaTaskParametersEditPageEventsProcessLaneSet.Lanes.Add(schemaOkButtonClickLane);
			ProcessSchemaEventSubProcess setparametertoolbuttonclickeventsubprocess = CreateSetParameterToolButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(setparametertoolbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaEventSubProcess pageloadcompleateeventsubprocess = CreatePageLoadCompleateEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleateeventsubprocess);
			ProcessSchemaEventSubProcess okbuttonclickeventsubprocess = CreateOkButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickeventsubprocess);
			ProcessSchemaStartMessageEvent setparametertoolbuttonclickstartmessage = CreateSetParameterToolButtonClickStartMessageStartMessageEvent();
			setparametertoolbuttonclickeventsubprocess.FlowElements.Add(setparametertoolbuttonclickstartmessage);
			ProcessSchemaScriptTask setparametertoolbuttonclickscripttask = CreateSetParameterToolButtonClickScriptTaskScriptTask();
			setparametertoolbuttonclickeventsubprocess.FlowElements.Add(setparametertoolbuttonclickscripttask);
			ProcessSchemaStartMessageEvent childinitstartmessage = CreateChildInitStartMessageStartMessageEvent();
			initeventsubprocess.FlowElements.Add(childinitstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent baseinitintermediatethrowmessageevent = CreateBaseInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			initeventsubprocess.FlowElements.Add(baseinitintermediatethrowmessageevent);
			ProcessSchemaScriptTask childscripttask = CreateChildScriptTaskScriptTask();
			initeventsubprocess.FlowElements.Add(childscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			pageloadcompleateeventsubprocess.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleateintermediatethrowmessageevent = CreatePageLoadCompleateIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadcompleateeventsubprocess.FlowElements.Add(pageloadcompleateintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcompleateeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent childokbuttonclickstartmessage = CreateChildOkButtonClickStartMessageStartMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(childokbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent baseokbuttonclickintermediatethrowmessageevent = CreateBaseOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(baseokbuttonclickintermediatethrowmessageevent);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2becc88a-8d97-4aad-8a2d-d7623d3d38b5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d93e5b00-39b3-4abd-9cd3-86b336bd8ad3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a758e8e8-35ab-4e34-994e-2774a2273f29"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("8d605efc-0f87-4f83-8c79-c5188588fe41"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CurveCenterPosition = new Point(143, 463),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1839f17a-7070-400b-adf8-971e3e64546f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7230d53-a658-4922-9652-4ab844811653"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5a95dbfd-f456-4241-9fbb-07da0d770446"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CurveCenterPosition = new Point(222, 464),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7230d53-a658-4922-9652-4ab844811653"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("72eed408-a39c-4e34-a3f2-75fa383d1c05"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("51a72447-be70-4cb1-b459-e87224bbd4df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CurveCenterPosition = new Point(156, 632),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("afa8e1ef-1779-462d-adda-81ac15ab5e98"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8191027-0ec9-432d-a84e-efa59e258f23"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("9866944c-d934-4df9-8c8a-187de5605188"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CurveCenterPosition = new Point(154, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba056378-390d-4676-a80f-33b9eeacf933"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d9f1cb98-c8c7-421b-8b7c-d107d7f542a4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("3bd519a6-6071-4a89-b91e-558557f27f57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CurveCenterPosition = new Point(290, 217),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d9f1cb98-c8c7-421b-8b7c-d107d7f542a4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d2a8388-ab0b-4e47-b547-325db3b43209"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("d65590a4-cb07-4ae9-a3dd-a9f946d1c027"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CurveCenterPosition = new Point(282, 605),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b8191027-0ec9-432d-a84e-efa59e258f23"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1b0efaa7-b294-45e2-8462-1126a65ed165"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateFormulaTaskParametersEditPageEventsProcessLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaFormulaTaskParametersEditPageEventsProcessLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3b40119b-7c98-48aa-b2f1-f949cc8f775d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"FormulaTaskParametersEditPageEventsProcessLaneSet",
				Position = new Point(5, 5),
				Size = new Size(694, 645),
				UseBackgroundMode = false
			};
			return schemaFormulaTaskParametersEditPageEventsProcessLaneSet;
		}

		protected virtual ProcessSchemaLane CreateAddParameterToolButtonClickLaneLane() {
			ProcessSchemaLane schemaAddParameterToolButtonClickLane = new ProcessSchemaLane(this) {
				UId = new Guid("ed281695-839b-408f-b529-f0adfdb0b0ae"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3b40119b-7c98-48aa-b2f1-f949cc8f775d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"AddParameterToolButtonClickLane",
				Position = new Point(29, 0),
				Size = new Size(665, 159),
				UseBackgroundMode = false
			};
			return schemaAddParameterToolButtonClickLane;
		}

		protected virtual ProcessSchemaLane CreateInitLaneLane() {
			ProcessSchemaLane schemaInitLane = new ProcessSchemaLane(this) {
				UId = new Guid("2dd20086-fa30-4c5d-91c8-d1398bacea9f"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("3b40119b-7c98-48aa-b2f1-f949cc8f775d"),
				CreatedInOwnerSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"InitLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 164),
				Size = new Size(665, 142),
				UseBackgroundMode = false
			};
			return schemaInitLane;
		}

		protected virtual ProcessSchemaLane CreatePageLoadCompleateLaneLane() {
			ProcessSchemaLane schemaPageLoadCompleateLane = new ProcessSchemaLane(this) {
				UId = new Guid("b912403d-c04f-4e63-ab8a-f00e1505d0f2"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("3b40119b-7c98-48aa-b2f1-f949cc8f775d"),
				CreatedInOwnerSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"PageLoadCompleateLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 311),
				Size = new Size(665, 175),
				UseBackgroundMode = false
			};
			return schemaPageLoadCompleateLane;
		}

		protected virtual ProcessSchemaLane CreateOkButtonClickLaneLane() {
			ProcessSchemaLane schemaOkButtonClickLane = new ProcessSchemaLane(this) {
				UId = new Guid("cd47b323-1443-4a14-962c-d5d45ee6c229"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("3b40119b-7c98-48aa-b2f1-f949cc8f775d"),
				CreatedInOwnerSchemaUId = new Guid("cf656bdd-d474-4488-ac1e-d43590d6d130"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"OkButtonClickLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 491),
				Size = new Size(665, 154),
				UseBackgroundMode = false
			};
			return schemaOkButtonClickLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSetParameterToolButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSetParameterToolButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9a96a387-45a2-4036-911f-40db893884a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed281695-839b-408f-b529-f0adfdb0b0ae"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"SetParameterToolButtonClickEventSubProcess",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(246, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSetParameterToolButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSetParameterToolButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d93e5b00-39b3-4abd-9cd3-86b336bd8ad3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a96a387-45a2-4036-911f-40db893884a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SetParameterToolButtonClick",
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"SetParameterToolButtonClickStartMessage",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetParameterToolButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a758e8e8-35ab-4e34-994e-2774a2273f29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a96a387-45a2-4036-911f-40db893884a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"SetParameterToolButtonClickScriptTask",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,81,107,219,48,16,126,31,236,63,8,63,41,16,196,218,215,48,88,215,164,52,133,117,102,238,218,151,192,80,164,75,34,144,37,35,159,150,116,198,255,125,146,237,52,177,179,108,165,236,81,223,221,125,247,221,167,147,230,70,161,226,90,253,130,76,108,32,231,179,93,161,173,3,247,164,140,180,91,58,154,188,127,247,147,59,82,246,130,228,35,233,103,19,94,118,72,134,206,11,244,14,246,161,142,160,112,86,64,89,182,73,161,254,38,240,79,161,84,107,3,50,61,142,53,45,75,116,202,172,201,134,27,169,155,118,45,192,102,121,129,207,39,241,111,176,2,7,70,192,61,207,225,144,124,99,93,206,145,38,219,102,20,86,125,168,127,204,164,194,107,155,23,26,16,82,238,66,58,130,75,198,131,241,216,181,86,96,112,62,29,29,196,23,224,240,121,202,145,103,214,59,17,187,164,167,96,112,225,81,57,244,92,31,192,189,129,203,80,98,96,75,178,70,220,103,175,180,4,215,14,187,100,87,69,1,70,210,100,229,141,64,101,13,21,86,251,220,204,205,202,142,72,181,48,201,32,47,50,170,16,12,156,179,29,50,143,74,179,187,236,235,61,147,32,172,132,227,242,73,191,118,111,74,112,131,149,128,143,92,123,160,145,138,5,47,120,202,113,19,42,198,36,229,107,96,183,74,74,48,25,224,139,85,209,191,158,59,175,224,21,188,136,35,29,104,143,9,31,96,135,231,73,105,82,55,234,143,246,96,201,30,108,107,33,29,68,122,151,254,41,10,9,104,117,81,135,182,127,218,147,23,52,210,180,186,132,83,5,126,225,38,28,28,187,146,178,5,232,96,157,212,138,208,234,178,14,247,82,145,56,173,55,116,145,132,62,139,100,28,225,9,169,235,243,27,53,38,9,132,113,69,183,131,103,180,141,254,169,233,141,218,163,94,59,208,251,95,196,14,24,58,33,221,123,236,189,253,125,140,197,224,105,101,182,177,219,184,16,221,255,211,47,253,62,151,127,95,205,184,78,81,142,131,240,5,25,18,254,34,152,252,6,9,168,183,90,226,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a8351fee-c862-45dd-9034-aa0ddfb54306"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dd20086-fa30-4c5d-91c8-d1398bacea9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1839f17a-7070-400b-adf8-971e3e64546f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8351fee-c862-45dd-9034-aa0ddfb54306"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"ChildInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d7230d53-a658-4922-9652-4ab844811653"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8351fee-c862-45dd-9034-aa0ddfb54306"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"BaseInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("72eed408-a39c-4e34-a3f2-75fa383d1c05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8351fee-c862-45dd-9034-aa0ddfb54306"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"ChildScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,207,74,195,64,16,198,207,9,228,29,246,216,94,242,2,197,131,198,88,115,72,41,138,120,30,154,175,118,203,102,183,157,157,213,208,210,119,119,147,136,52,20,241,50,48,223,159,223,192,84,86,139,38,163,79,40,156,21,116,242,12,115,120,8,34,206,206,230,139,44,213,91,53,43,59,201,43,127,191,167,238,5,199,0,47,115,117,206,210,164,183,94,55,59,180,84,118,7,227,24,92,48,72,208,140,118,82,253,162,167,169,119,109,27,247,53,208,147,75,150,94,20,140,199,80,249,36,86,91,199,109,48,180,166,15,172,217,109,224,189,186,83,75,200,211,141,62,18,110,243,121,217,104,25,79,190,85,77,108,79,246,127,59,53,217,168,243,138,90,76,186,87,250,31,140,58,142,126,37,11,83,24,13,43,195,249,62,146,215,164,237,181,159,255,4,30,35,43,62,129,33,129,173,18,14,88,124,3,182,89,102,81,147,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleateEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleateEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cfd8558a-bc69-4d45-988b-51796220a556"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b912403d-c04f-4e63-ab8a-f00e1505d0f2"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"PageLoadCompleateEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleateEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("afa8e1ef-1779-462d-adda-81ac15ab5e98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cfd8558a-bc69-4d45-988b-51796220a556"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleateIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1b0efaa7-b294-45e2-8462-1126a65ed165"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cfd8558a-bc69-4d45-988b-51796220a556"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"PageLoadCompleateIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b8191027-0ec9-432d-a84e-efa59e258f23"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cfd8558a-bc69-4d45-988b-51796220a556"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,205,110,194,48,12,62,131,196,59,100,183,244,210,23,64,187,20,232,198,97,91,181,178,7,136,136,41,209,210,180,114,92,180,104,218,187,47,97,172,164,66,173,184,197,246,231,239,199,41,176,217,131,181,229,254,8,181,96,237,160,122,100,185,50,114,13,86,85,6,100,17,207,120,178,92,204,79,2,217,161,193,186,211,98,39,236,167,199,243,1,40,191,206,146,1,115,250,4,148,9,11,27,13,53,24,202,220,199,86,242,141,84,116,105,248,50,240,23,162,130,116,37,90,82,141,217,193,23,5,68,26,30,94,41,210,253,135,12,29,133,229,139,27,15,247,130,249,77,255,28,226,22,158,150,61,56,107,164,227,177,84,104,132,45,117,96,252,193,18,42,83,165,91,251,218,105,253,134,155,186,165,33,250,29,108,167,169,16,40,106,32,192,23,32,175,67,199,36,97,223,139,249,236,28,207,107,245,243,145,140,177,53,159,195,63,91,64,114,107,101,91,45,92,32,204,92,9,120,186,10,112,207,62,155,222,30,46,100,110,165,149,63,124,79,112,87,10,127,135,159,169,83,76,7,140,175,240,172,164,4,19,67,199,254,122,196,204,159,21,4,234,208,48,194,14,150,191,111,57,113,29,217,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("aa09ad86-baad-40fe-b404-b2e9dbaa273e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cd47b323-1443-4a14-962c-d5d45ee6c229"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"OkButtonClickEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(321, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ba056378-390d-4676-a80f-33b9eeacf933"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa09ad86-baad-40fe-b404-b2e9dbaa273e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"ChildOkButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2d2a8388-ab0b-4e47-b547-325db3b43209"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa09ad86-baad-40fe-b404-b2e9dbaa273e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"BaseOkButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d9f1cb98-c8c7-421b-8b7c-d107d7f542a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa09ad86-baad-40fe-b404-b2e9dbaa273e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				Name = @"OkButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,65,110,194,48,16,188,87,234,31,114,12,82,229,15,160,94,2,164,228,64,21,53,208,251,42,158,130,213,216,65,246,154,150,223,119,67,19,133,128,122,232,201,158,245,204,236,142,183,244,109,141,16,170,250,0,75,201,113,130,158,147,220,56,189,68,48,123,7,93,94,191,165,179,249,227,195,137,124,242,209,122,27,27,218,82,248,20,126,58,33,229,227,219,108,226,172,94,192,25,5,172,26,88,56,206,206,187,66,167,43,109,184,47,8,188,241,47,105,143,222,91,218,136,60,191,171,95,70,234,13,94,241,181,160,35,155,214,9,187,227,168,30,110,241,205,93,35,213,93,132,127,53,254,64,81,239,212,68,252,67,247,134,16,27,46,201,147,5,195,111,192,50,22,31,6,135,181,209,26,174,194,200,248,203,40,107,245,89,84,247,145,213,24,184,227,92,146,78,63,244,247,216,144,19,145,87,21,157,48,172,173,96,216,66,218,135,32,49,150,196,148,238,2,252,162,117,14,117,151,236,105,186,244,27,168,250,85,120,112,244,46,97,31,49,255,1,185,69,110,50,51,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetFormulaPageProcessMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("066ffcd6-9ce5-4e58-b783-f48614cdedf6"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa829845-323a-4ea4-93af-fb6e78600271"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,219,78,219,64,16,125,6,137,127,24,220,23,35,17,67,66,40,80,74,165,38,65,81,36,110,130,208,247,181,189,14,46,142,109,237,218,165,81,133,212,66,105,31,64,84,253,129,246,165,31,64,171,162,70,229,246,11,235,63,234,172,29,20,156,58,37,45,168,145,28,203,51,115,206,153,221,153,217,173,134,182,9,235,148,152,21,18,144,77,78,89,157,240,237,13,99,139,54,73,205,132,5,112,233,14,84,49,70,85,12,189,56,61,173,63,180,114,51,179,150,149,43,234,121,154,211,11,197,124,206,40,232,186,49,169,79,205,208,57,75,25,155,31,25,214,61,207,1,155,175,208,157,132,103,241,165,239,120,140,50,100,235,53,32,127,232,56,136,121,65,24,240,91,162,9,239,88,54,2,22,26,65,200,232,181,11,9,108,11,212,12,205,49,120,53,50,60,244,27,179,92,85,31,46,117,141,52,168,86,247,252,178,231,6,204,115,150,72,203,11,131,113,80,120,58,94,25,7,139,56,156,118,94,114,225,187,127,149,134,182,76,92,148,98,43,164,73,49,165,69,211,14,18,208,13,187,36,5,138,244,89,248,154,107,56,161,73,227,202,61,35,78,72,235,45,159,114,173,236,80,194,212,78,62,189,144,134,139,111,51,93,231,155,144,193,226,159,154,166,218,175,103,36,75,42,163,206,114,192,204,50,46,128,196,227,86,187,212,8,108,207,213,178,160,200,88,246,28,39,137,120,156,138,120,2,60,96,182,219,224,241,218,145,46,75,69,171,210,32,189,73,165,86,149,121,161,47,183,88,85,54,18,134,184,119,251,235,184,97,83,167,236,46,58,43,9,195,45,58,72,76,239,162,82,145,248,88,67,142,45,152,250,170,254,28,149,164,115,51,158,232,126,156,181,128,54,75,173,14,73,169,139,82,198,52,4,34,159,133,173,64,140,45,53,37,14,129,252,179,221,84,29,146,118,159,152,128,250,106,101,21,202,235,144,159,154,155,45,22,208,38,231,67,34,36,37,140,46,244,166,151,0,7,108,116,217,133,215,92,227,241,33,165,45,54,253,160,37,215,62,180,27,183,255,159,83,190,89,210,204,9,253,7,225,91,69,187,245,189,71,201,193,73,6,169,126,9,15,112,74,220,164,240,189,106,247,43,37,185,255,135,206,146,231,109,135,126,182,210,4,254,224,65,97,118,178,144,159,134,53,230,25,148,243,71,32,62,69,123,226,167,56,139,142,163,247,162,29,237,69,71,16,189,21,109,52,28,225,199,107,113,18,189,67,243,49,136,43,113,9,24,218,22,87,209,62,136,239,226,68,92,136,139,232,48,58,64,23,198,181,65,124,139,14,197,87,113,137,31,167,50,252,68,162,197,185,56,77,120,36,230,44,250,0,209,27,12,57,136,125,23,226,20,159,182,52,34,70,252,136,246,19,89,132,226,3,138,248,18,179,157,199,246,67,5,21,64,124,20,159,7,221,180,254,199,61,175,185,126,216,185,134,214,8,195,173,11,40,91,246,76,121,65,225,197,39,239,163,244,197,86,198,86,15,168,217,117,203,1,31,77,199,172,211,134,205,145,135,154,153,29,127,237,142,19,26,234,7,237,42,236,246,230,128,174,52,229,252,47,47,158,84,176,213,8,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,137,5,37,153,249,121,10,182,10,197,37,69,153,121,233,122,158,197,126,165,57,57,254,69,174,185,5,37,149,26,96,211,160,106,66,82,43,74,92,83,50,75,244,64,12,77,5,123,46,78,215,156,212,220,212,188,18,191,212,114,152,49,86,10,56,117,88,3,0,235,215,165,1,155,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = base.CreateInitializeContextHelpButtonMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,204,203,44,201,76,204,201,172,74,117,206,207,43,73,173,40,241,72,205,41,112,42,45,41,201,207,211,208,180,6,0,21,115,174,228,35,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFormulaPageProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("083175d1-55b4-43a2-bbe0-619627f72bd5"),
				Name = "GetFormulaPageProcess",
				CreatedInSchemaUId = new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,142,177,10,194,64,12,134,103,239,41,226,214,46,247,2,103,5,145,10,221,10,42,206,177,166,90,184,230,74,114,237,34,190,187,156,118,232,38,46,9,36,63,223,255,77,40,208,6,233,71,143,53,222,9,10,72,203,166,177,15,28,177,99,146,195,247,255,57,86,172,17,185,33,64,133,19,137,160,134,54,218,11,93,119,195,96,231,96,121,235,98,202,30,155,7,245,120,86,146,132,146,224,157,233,90,200,150,117,235,2,120,244,62,135,167,89,9,197,81,24,178,95,216,114,34,142,90,75,104,72,117,243,183,196,54,95,8,216,25,227,204,203,204,253,201,199,189,1,176,44,108,129,23,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FormulaTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("849bc6a8-a1d8-485f-b7a4-4b06f0ca0fbd"));
		}

		#endregion

	}

	#endregion

}

