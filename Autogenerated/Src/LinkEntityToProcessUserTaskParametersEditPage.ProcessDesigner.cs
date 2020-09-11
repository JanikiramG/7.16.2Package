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
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: LinkEntityToProcessUserTaskParametersEditPageSchema

	/// <exclude/>
	public class LinkEntityToProcessUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _entitySchemaEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntitySchemaEdit {
			get {
				return _entitySchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _entitySchemaLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaLookupEdit {
			get {
				return _entitySchemaLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _entityEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityEdit {
			get {
				return _entityEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public LinkEntityToProcessUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LinkEntityToProcessUserTaskParametersEditPageSchema(LinkEntityToProcessUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			RealUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			Name = "LinkEntityToProcessUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema();
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
			TopControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateEntitySchemaEdit());
			ControlLayout1.InsertItem(1, CreateEntitySchemaLookupEdit());
			ControlLayout1.InsertItem(2, CreateEntityEdit());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateLinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new LinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateEntitySchemaEdit() {
			_entitySchemaEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_entitySchemaEdit.UId = new Guid("b328253b-ef0e-4f57-82a0-c38f2eb80b03");
			_entitySchemaEdit.Name = "EntitySchemaEdit";
			_entitySchemaEdit.CreatedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_entitySchemaEdit.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_entitySchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entitySchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entitySchemaEdit.Tag = "";
			_entitySchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entitySchemaEdit.DataValueTypeUId = new Guid("23018567-a13c-4320-8687-fd6f9e3699bd");
			_entitySchemaEdit.Image = new ControlImage {};
			_entitySchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entitySchemaEdit.Enabled = false;
			_entitySchemaEdit.Hidden = true;
			return _entitySchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateEntitySchemaLookupEdit() {
			_entitySchemaLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_entitySchemaLookupEdit.UId = new Guid("58b91e53-77f4-4599-8aab-32084e32593d");
			_entitySchemaLookupEdit.Name = "EntitySchemaLookupEdit";
			_entitySchemaLookupEdit.CreatedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_entitySchemaLookupEdit.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_entitySchemaLookupEdit.CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9");
			_entitySchemaLookupEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entitySchemaLookupEdit.Tag = "";
			_entitySchemaLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entitySchemaLookupEdit.Image = new ControlImage {};
			_entitySchemaLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entitySchemaLookupEdit.Required = true;
			_entitySchemaLookupEdit.LookupSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111");
			_entitySchemaLookupEdit.LookupPageSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			return _entitySchemaLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateEntityEdit() {
			_entityEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_entityEdit.UId = new Guid("7bf0c444-13de-4fc8-bb39-35cd610abb3e");
			_entityEdit.Name = "EntityEdit";
			_entityEdit.CreatedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_entityEdit.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_entityEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityEdit.Tag = "";
			_entityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_entityEdit.Image = new ControlImage {};
			_entityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityEdit.Enabled = false;
			return _entityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("7ca19b95-1ce2-4ccf-8268-69ef9244520d");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_controlLayout1.ModifiedInSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			_controlLayout1.AutoScroll = true;
			return _controlLayout1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new LinkEntityToProcessUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new LinkEntityToProcessUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LinkEntityToProcessUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LinkEntityToProcessUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class LinkEntityToProcessUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LinkEntityToProcessUserTaskParametersEditPageSchemaUserControl
	{

		public LinkEntityToProcessUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LinkEntityToProcessUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
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

		public virtual Guid EntitySchemaEditOldValue {
			get;
			set;
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual Guid PackageUId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessInit;
		public ProcessFlowElement EventSubProcessInit {
			get {
				return _eventSubProcessInit ?? (_eventSubProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInit",
					SchemaElementUId = new Guid("85964dd5-975a-4175-b365-f6bcc976020c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskChildInitAfterBase;
		public ProcessScriptTask ScriptTaskChildInitAfterBase {
			get {
				return _scriptTaskChildInitAfterBase ?? (_scriptTaskChildInitAfterBase = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskChildInitAfterBase",
					SchemaElementUId = new Guid("218969a3-a8ac-4e3e-bfec-b87ab4dd5651"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskChildInitAfterBaseExecute,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("6573c1b1-fdac-48e4-8895-7d74aaa75617"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventInit;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventInit {
			get {
				return _intermediateThrowMessageEventInit ?? (_intermediateThrowMessageEventInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventInit",
					SchemaElementUId = new Guid("0f58ee9b-487e-4dbf-83fb-0dffb0737e81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("23994e42-b0ed-494a-8b0b-ac11e9039ff3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childOkButtonClickMessage;
		public ProcessFlowElement ChildOkButtonClickMessage {
			get {
				return _childOkButtonClickMessage ?? (_childOkButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildOkButtonClickMessage",
					SchemaElementUId = new Guid("0946a8b6-9add-43c5-845f-1b459d9c61f5"),
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
					SchemaElementUId = new Guid("a5131df6-8197-4c26-b1dd-982d9eab5bfb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildOkButtonClick;
		public ProcessScriptTask ScriptChildOkButtonClick {
			get {
				return _scriptChildOkButtonClick ?? (_scriptChildOkButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildOkButtonClick",
					SchemaElementUId = new Guid("e35d1f31-2d9e-4b2d-a017-19f74741cef6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildOkButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _entitySchemaEditChangeEventSubProcess;
		public ProcessFlowElement EntitySchemaEditChangeEventSubProcess {
			get {
				return _entitySchemaEditChangeEventSubProcess ?? (_entitySchemaEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EntitySchemaEditChangeEventSubProcess",
					SchemaElementUId = new Guid("2f430443-abc6-48e4-81ae-f21df2065580"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("7daea2ac-640b-4f37-be0f-0592e34b5b45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _entitySchemaEditChangeScriptTask;
		public ProcessScriptTask EntitySchemaEditChangeScriptTask {
			get {
				return _entitySchemaEditChangeScriptTask ?? (_entitySchemaEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EntitySchemaEditChangeScriptTask",
					SchemaElementUId = new Guid("71acbb21-b7de-4c01-bbcf-92b869a87459"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EntitySchemaEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadComplete;
		public ProcessFlowElement PageLoadComplete {
			get {
				return _pageLoadComplete ?? (_pageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadComplete",
					SchemaElementUId = new Guid("f66cfba6-5b72-4eac-b38e-109fc53aa6c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoqdCompleteStartMessage;
		public ProcessFlowElement PageLoqdCompleteStartMessage {
			get {
				return _pageLoqdCompleteStartMessage ?? (_pageLoqdCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoqdCompleteStartMessage",
					SchemaElementUId = new Guid("c191f13a-19f7-474e-90e3-f899178bfb36"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoqdCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoqdCompleteIntermediateThrowMessageEvent {
			get {
				return _pageLoqdCompleteIntermediateThrowMessageEvent ?? (_pageLoqdCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoqdCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("269f7824-4252-4e2b-a9b7-e47296f493b3"),
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
					SchemaElementUId = new Guid("8238d513-e620-4bbd-9c47-587e384cc1d4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _entitySchemaLookupEditChangeEventSubProcess;
		public ProcessFlowElement EntitySchemaLookupEditChangeEventSubProcess {
			get {
				return _entitySchemaLookupEditChangeEventSubProcess ?? (_entitySchemaLookupEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EntitySchemaLookupEditChangeEventSubProcess",
					SchemaElementUId = new Guid("d807f077-34a6-4732-bbb8-3a7cd19645f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entitySchemaLookupEditChangeStartMessage;
		public ProcessFlowElement EntitySchemaLookupEditChangeStartMessage {
			get {
				return _entitySchemaLookupEditChangeStartMessage ?? (_entitySchemaLookupEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntitySchemaLookupEditChangeStartMessage",
					SchemaElementUId = new Guid("92e00aa6-371a-4a45-90aa-8dc3be7789be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _entitySchemaLookupEditChangeScriptTask;
		public ProcessScriptTask EntitySchemaLookupEditChangeScriptTask {
			get {
				return _entitySchemaLookupEditChangeScriptTask ?? (_entitySchemaLookupEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EntitySchemaLookupEditChangeScriptTask",
					SchemaElementUId = new Guid("b07c23ed-95a3-4571-bd2d-b04a3976b0ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EntitySchemaLookupEditChangeScriptTaskExecute,
				});
			}
		}

		private LocalizableString _lookupValueDisplayPrefix;
		public LocalizableString LookupValueDisplayPrefix {
			get {
				return _lookupValueDisplayPrefix ?? (_lookupValueDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LookupValueDisplayPrefix.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInit };
			FlowElements[ScriptTaskChildInitAfterBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskChildInitAfterBase };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ChildOkButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildOkButtonClickMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptChildOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildOkButtonClick };
			FlowElements[EntitySchemaEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChangeEventSubProcess };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[EntitySchemaEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChangeScriptTask };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[PageLoqdCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteStartMessage };
			FlowElements[PageLoqdCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EntitySchemaLookupEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaLookupEditChangeEventSubProcess };
			FlowElements[EntitySchemaLookupEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaLookupEditChangeStartMessage };
			FlowElements[EntitySchemaLookupEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaLookupEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessInit":
						break;
					case "ScriptTaskChildInitAfterBase":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "IntermediateThrowMessageEventInit":
						e.Context.QueueTasks.Enqueue("ScriptTaskChildInitAfterBase");
						break;
					case "EventSubProcess2":
						break;
					case "ChildOkButtonClickMessage":
						e.Context.QueueTasks.Enqueue("ScriptChildOkButtonClick");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "ScriptChildOkButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EntitySchemaEditChangeEventSubProcess":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("EntitySchemaEditChangeScriptTask");
						break;
					case "EntitySchemaEditChangeScriptTask":
						break;
					case "PageLoadComplete":
						break;
					case "PageLoqdCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoqdCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoqdCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EntitySchemaLookupEditChangeEventSubProcess":
						break;
					case "EntitySchemaLookupEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("EntitySchemaLookupEditChangeScriptTask");
						break;
					case "EntitySchemaLookupEditChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("ChildOkButtonClickMessage");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("PageLoqdCompleteStartMessage");
			ActivatedEventElements.Add("EntitySchemaLookupEditChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTaskChildInitAfterBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskChildInitAfterBase";
					result = ScriptTaskChildInitAfterBase.Execute(context, ScriptTaskChildInitAfterBaseExecute);
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "IntermediateThrowMessageEventInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventInit.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ChildOkButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildOkButtonClickMessage";
					result = ChildOkButtonClickMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptChildOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildOkButtonClick";
					result = ScriptChildOkButtonClick.Execute(context, ScriptChildOkButtonClickExecute);
					break;
				case "EntitySchemaEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "EntitySchemaEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaEditChangeScriptTask";
					result = EntitySchemaEditChangeScriptTask.Execute(context, EntitySchemaEditChangeScriptTaskExecute);
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoqdCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoqdCompleteStartMessage";
					result = PageLoqdCompleteStartMessage.Execute(context);
					break;
				case "PageLoqdCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoqdCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "EntitySchemaLookupEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EntitySchemaLookupEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaLookupEditChangeStartMessage";
					result = EntitySchemaLookupEditChangeStartMessage.Execute(context);
					break;
				case "EntitySchemaLookupEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaLookupEditChangeScriptTask";
					result = EntitySchemaLookupEditChangeScriptTask.Execute(context, EntitySchemaLookupEditChangeScriptTaskExecute);
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
				case "PackageUId":
					PackageUId = reader.GetValue<System.Guid>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EntitySchemaEditOldValue":
					EntitySchemaEditOldValue = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskChildInitAfterBaseExecute(ProcessExecutingContext context) {
			IEnumerable<Guid> packageIds = Terrasoft.Core.Packages.WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, FindDesignedProcessSchema().PackageUId,
				UserConnection.Workspace.Id);
			object[] objectPackageIds = packageIds.Cast<object>().ToArray();
			var packageFilter = new Dictionary<string, object> {
				{ "comparisonType", FilterComparisonType.Equal },
				{ "leftExpressionColumnPath", "SysPackage" },
				{ "useDisplayValue", false },
				{ "rightExpressionParameterValues", objectPackageIds }
			};
			var extendParentFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "ExtendParent"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", new object[] {false}}};
			Page.EntitySchemaLookupEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageFilter);
				filters.Add(extendParentFilter);
			};
			var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (defValues == null) {
				return false;
			}
			if (Ext.IsAjaxRequest) {
				return true;
			}
			DefaultValues = defValues;
			FillPropertyDataSource(Source, (DesignModeClassDescriptor)Descriptor);
			var propertyDataSource = (VirtualDataSource)PropertyDataSource;
			propertyDataSource.SetClientActiveRow();
			BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
			return true;
		}

		public virtual bool ScriptChildOkButtonClickExecute(ProcessExecutingContext context) {
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			bool isEmptyEntitySchemaUId = EntitySchemaUId == Guid.Empty;
			parametersValue["EntitySchemaId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isEmptyEntitySchemaUId ? noneVS : constVS,
				Value = isEmptyEntitySchemaUId ? string.Empty : EntitySchemaUId.ToString()
			};
			if (isEmptyEntitySchemaUId) {
				parametersValue["EntityId"] = new ProcessSchemaParameterValue() {
					ModifiedInSchemaUId = EditSchemaUId,
					Source = noneVS,
					Value = string.Empty
				};
			} else {
				ProcessSchemaParameterValue parameterValue = parametersValue["EntityId"];
				parameterValue.ReferenceSchemaUId = EntitySchemaUId;
			}
			return true;
		}

		public virtual bool EntitySchemaEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			/*
			var parameterValue = (ProcessSchemaParameterValue)Page.EntitySchemaEdit.Value;
			string currentEntitySchemaValue = parameterValue.Value;
			if (EntitySchemaEditOldValue == currentEntitySchemaValue) {
				return true;
			}
			
			Guid entitySchemaUId = Guid.Empty;
			if (parameterValue.Source == ProcessSchemaParameterValueSource.Script) {
				Regex regexLookupValueMacros = GeneratorUtilities.GetRegexLookupValueMacros();
				foreach (Match match in regexLookupValueMacros.Matches(currentEntitySchemaValue)) {
					if (match.Groups.Count != 3) {
						continue;
					}
					string lookupValue = match.Groups[2].Value;
					Guid result;
					if (Guid.TryParse(lookupValue, out result)) {
						Tuple<Guid, string> schemaDescription = GetEntitySchemaDescriptionById(result);
						entitySchemaUId = schemaDescription.Item1;
					}
				}
			}
			
			ProcessSchemaParameterValue entityEditValue = (ProcessSchemaParameterValue)Page.EntityEdit.Value;
			//entityEditValue.ReferenceSchemaUId = entitySchemaUId;
			entityEditValue.Value = string.Empty;
			entityEditValue.DisplayValue = string.Empty;
			entityEditValue.Source = ProcessSchemaParameterValueSource.None;
			Page.EntityEdit.Value = entityEditValue;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			parametersValue["EntityId"] = entityEditValue;
			EntitySchemaEditOldValue = currentEntitySchemaValue;
			*/
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			PackageUId = processSchema.PackageUId;
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameters == null) {
				return true;
			}
			string parameterValue = parameters["EntitySchemaId"].Value;
			if (!string.IsNullOrEmpty(parameterValue)) {
				EntitySchemaUId = new Guid(parameterValue);
				Guid entitySchemaId = GetSchemaIdByUId(EntitySchemaUId);
				EntitySchemaEditOldValue = entitySchemaId;
				Page.EntitySchemaLookupEdit.SetValueAndText(entitySchemaId,
					UserConnection.EntitySchemaManager.GetItemByUId(EntitySchemaUId).Caption);
				Page.EntityEdit.Enabled = true;
				parameters["EntityId"].ReferenceSchemaUId = EntitySchemaUId;
				ProcessSchemaParameterValue paramValue = Page.EntityEdit.ParameterValue;
				paramValue.ReferenceSchemaUId = EntitySchemaUId;
				Page.EntityEdit.Value = paramValue;
			}
			return true;
		}

		public virtual bool EntitySchemaLookupEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaId = (Guid)Page.EntitySchemaLookupEdit.Value;
			if (EntitySchemaEditOldValue == entitySchemaId) {
				return true;
			}
			bool isNotEmpty = entitySchemaId != Guid.Empty;
			if (isNotEmpty) {
				EntitySchemaUId = GetSchemaUIdById(entitySchemaId);
			} else {
				EntitySchemaUId = Guid.Empty;
			}
			UpdateEntityIdParameterValue();
			Page.EntityEdit.SetRequired(isNotEmpty);
			Page.EntityEdit.Enabled = isNotEmpty;
			EntitySchemaEditOldValue = entitySchemaId;
			return true;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl>() {
			//{"EntitySchemaId", Page.EntitySchemaEdit},
			{"EntityId", Page.EntityEdit}
			};
		}

		public virtual Guid GetSchemaUIdById(Guid schemaId) {
			return
				(new Select(UserConnection)
					.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter(schemaId)) as Select)
				.ExecuteScalar<Guid>();
		}

		public virtual Guid GetSchemaIdByUId(Guid schemaUId) {
			DataValueType guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var schemaSelect =
				(Select)new Select(UserConnection)
					.Column("Id")
				.From("VwSysEntitySchemaInPackage")
				.Where("SysWorkspaceId").IsEqual(Column.Parameter(UserConnection.Workspace.Id, guidDvt))
					.And("UId").IsEqual(Column.Parameter(schemaUId, guidDvt))
					.And("SysPackageUId").IsEqual(Column.Parameter(PackageUId, guidDvt));
			return schemaSelect.ExecuteScalar<Guid>();
		}

		public virtual void UpdateEntityIdParameterValue() {
			ProcessSchemaParameterValue parameterValue = Page.EntityEdit.ParameterValue;
			parameterValue.ModifiedInSchemaUId = EditSchemaUId;
			parameterValue.ReferenceSchemaUId = EntitySchemaUId;
			parameterValue.Value = null;
			parameterValue.DisplayValue = null;
			parameterValue.Source = ProcessSchemaParameterValueSource.None;
			Page.EntityEdit.Value = parameterValue;
			//Page.EntityEdit.SetValue(parameterValue);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("ChildOkButtonClickMessage")) {
							context.QueueTasks.Enqueue("ChildOkButtonClickMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "EntitySchemaEditChange":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoqdCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoqdCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "EntitySchemaLookupEditChange":
							if (ActivatedEventElements.Contains("EntitySchemaLookupEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("EntitySchemaLookupEditChangeStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("PackageUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PackageUId", PackageUId, Guid.Empty);
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("EntitySchemaEditOldValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaEditOldValue", EntitySchemaEditOldValue, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: LinkEntityToProcessUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class LinkEntityToProcessUserTaskParametersEditPageEventsProcess : LinkEntityToProcessUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.LinkEntityToProcessUserTaskParametersEditPageSchemaUserControl>
	{

		public LinkEntityToProcessUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LinkEntityToProcessUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class LinkEntityToProcessUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntitySchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("EntitySchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("EntitySchemaLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("EntityEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EntitySchemaEdit.AjaxEvents.Change.Event += EntitySchemaEditChange;
			EntitySchemaLookupEdit.AjaxEvents.Change.Event += EntitySchemaLookupEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntitySchemaEdit.AjaxEvents.Change.Event -= EntitySchemaEditChange;
			EntitySchemaLookupEdit.AjaxEvents.Change.Event -= EntitySchemaLookupEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (LinkEntityToProcessUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LinkEntityToProcessUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void EntitySchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EntitySchemaEditChange");
		}

		public virtual void EntitySchemaLookupEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EntitySchemaLookupEditChange");
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
			SchemaName = "LinkEntityToProcessUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: LinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class LinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public LinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema(LinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LinkEntityToProcessUserTaskParametersEditPageEventsProcess";
			UId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68");
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

		protected virtual ProcessSchemaParameter CreateEntitySchemaEditOldValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a8603f18-70ac-4866-a89f-75dac41d2765"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EntitySchemaEditOldValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a4e64fa-4dd3-4623-af91-3b8dd36e36be"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePackageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("07712c66-5a41-4aef-9584-f25004d553cb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"PackageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaEditOldValueParameter());
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreatePackageUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet328 = CreateLaneSet328LaneSet();
			LaneSets.Add(schemaLaneSet328);
			ProcessSchemaLane schemaLane1053 = CreateLane1053Lane();
			schemaLaneSet328.Lanes.Add(schemaLane1053);
			ProcessSchemaLane schemaLane1054 = CreateLane1054Lane();
			schemaLaneSet328.Lanes.Add(schemaLane1054);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet328.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocessinit = CreateEventSubProcessInitEventSubProcess();
			FlowElements.Add(eventsubprocessinit);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess entityschemaeditchangeeventsubprocess = CreateEntitySchemaEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(entityschemaeditchangeeventsubprocess);
			ProcessSchemaEventSubProcess pageloadcomplete = CreatePageLoadCompleteEventSubProcess();
			FlowElements.Add(pageloadcomplete);
			ProcessSchemaEventSubProcess entityschemalookupeditchangeeventsubprocess = CreateEntitySchemaLookupEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(entityschemalookupeditchangeeventsubprocess);
			ProcessSchemaScriptTask scripttaskchildinitafterbase = CreateScriptTaskChildInitAfterBaseScriptTask();
			eventsubprocessinit.FlowElements.Add(scripttaskchildinitafterbase);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocessinit.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocessinit.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaStartMessageEvent childokbuttonclickmessage = CreateChildOkButtonClickMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(childokbuttonclickmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptchildokbuttonclick = CreateScriptChildOkButtonClickScriptTask();
			eventsubprocess2.FlowElements.Add(scriptchildokbuttonclick);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			entityschemaeditchangeeventsubprocess.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask entityschemaeditchangescripttask = CreateEntitySchemaEditChangeScriptTaskScriptTask();
			entityschemaeditchangeeventsubprocess.FlowElements.Add(entityschemaeditchangescripttask);
			ProcessSchemaStartMessageEvent pageloqdcompletestartmessage = CreatePageLoqdCompleteStartMessageStartMessageEvent();
			pageloadcomplete.FlowElements.Add(pageloqdcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloqdcompleteintermediatethrowmessageevent = CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadcomplete.FlowElements.Add(pageloqdcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcomplete.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent entityschemalookupeditchangestartmessage = CreateEntitySchemaLookupEditChangeStartMessageStartMessageEvent();
			entityschemalookupeditchangeeventsubprocess.FlowElements.Add(entityschemalookupeditchangestartmessage);
			ProcessSchemaScriptTask entityschemalookupeditchangescripttask = CreateEntitySchemaLookupEditChangeScriptTaskScriptTask();
			entityschemalookupeditchangeeventsubprocess.FlowElements.Add(entityschemalookupeditchangescripttask);
			FlowElements.Add(CreateSequenceFlow6516SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6517SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6519SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6520SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLookupValueDisplayPrefixLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLookupValueDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4d1f130d-5354-4f93-b379-f6c7de7d5e0c"),
				Name = "LookupValueDisplayPrefix",
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6516SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6516",
				UId = new Guid("773a39e7-95df-4522-94c0-b802bf38e7b9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(142, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6573c1b1-fdac-48e4-8895-7d74aaa75617"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0f58ee9b-487e-4dbf-83fb-0dffb0737e81"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6517SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6517",
				UId = new Guid("ac3985b2-14f1-4576-82e3-b4913ee87849"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(224, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f58ee9b-487e-4dbf-83fb-0dffb0737e81"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("218969a3-a8ac-4e3e-bfec-b87ab4dd5651"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6519SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6519",
				UId = new Guid("115d5a0d-023d-461e-b2e5-f89a23a450dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e35d1f31-2d9e-4b2d-a017-19f74741cef6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5131df6-8197-4c26-b1dd-982d9eab5bfb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6520SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6520",
				UId = new Guid("3efbabb3-7fbb-43d0-9899-cf0a8c664c84"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0946a8b6-9add-43c5-845f-1b459d9c61f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e35d1f31-2d9e-4b2d-a017-19f74741cef6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b1245237-da9d-4649-b8dd-3a1a214d0fbf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7daea2ac-640b-4f37-be0f-0592e34b5b45"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71acbb21-b7de-4c01-bbcf-92b869a87459"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("5c5eb57c-c648-4999-a2da-339e9c3a6971"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(144, 582),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c191f13a-19f7-474e-90e3-f899178bfb36"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("269f7824-4252-4e2b-a9b7-e47296f493b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("39ebbc3b-ce71-447e-bf8e-02969c42b17e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(230, 580),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("269f7824-4252-4e2b-a9b7-e47296f493b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8238d513-e620-4bbd-9c47-587e384cc1d4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("aee8c624-1b6c-4069-8875-1b1d02e5acef"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("92e00aa6-371a-4a45-90aa-8dc3be7789be"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b07c23ed-95a3-4571-bd2d-b04a3976b0ac"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet328LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet328 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9e31ba91-690f-4999-96c2-b66591c6ae05"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"LaneSet328",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(945, 648),
				UseBackgroundMode = false
			};
			return schemaLaneSet328;
		}

		protected virtual ProcessSchemaLane CreateLane1053Lane() {
			ProcessSchemaLane schemaLane1053 = new ProcessSchemaLane(this) {
				UId = new Guid("c39ca6f3-e063-4eef-9d68-d76eef3ec2d4"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("9e31ba91-690f-4999-96c2-b66591c6ae05"),
				CreatedInOwnerSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"Lane1053",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 320),
				Size = new Size(916, 328),
				UseBackgroundMode = false
			};
			return schemaLane1053;
		}

		protected virtual ProcessSchemaLane CreateLane1054Lane() {
			ProcessSchemaLane schemaLane1054 = new ProcessSchemaLane(this) {
				UId = new Guid("36222b2d-73a3-4e87-b579-50683f8832d1"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("9e31ba91-690f-4999-96c2-b66591c6ae05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"Lane1054",
				Position = new Point(29, 164),
				Size = new Size(916, 151),
				UseBackgroundMode = false
			};
			return schemaLane1054;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3b53f79b-9df8-4907-bfa1-cca8a83e18a5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9e31ba91-690f-4999-96c2-b66591c6ae05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(916, 159),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("85964dd5-975a-4175-b365-f6bcc976020c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c39ca6f3-e063-4eef-9d68-d76eef3ec2d4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EventSubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(292, 132),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInit;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskChildInitAfterBaseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("218969a3-a8ac-4e3e-bfec-b87ab4dd5651"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("85964dd5-975a-4175-b365-f6bcc976020c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"ScriptTaskChildInitAfterBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,111,219,48,12,61,183,64,254,131,144,147,141,25,254,3,107,3,100,142,219,5,216,0,163,105,186,195,176,131,106,209,137,90,69,114,41,185,173,81,228,191,143,138,156,196,94,186,13,61,89,230,199,227,123,36,165,121,174,155,13,32,191,87,112,113,221,72,49,97,53,47,31,249,10,230,194,178,75,118,11,136,220,154,202,165,153,65,72,139,224,179,233,15,131,143,150,34,97,233,164,146,78,146,233,26,92,231,254,42,9,16,203,117,75,24,209,210,2,102,70,107,40,157,52,58,97,87,82,139,25,88,185,210,32,10,52,37,88,187,40,215,176,225,81,188,135,95,206,69,50,58,63,27,102,30,75,166,115,17,127,30,157,155,251,7,242,252,252,197,194,161,232,211,62,106,72,51,110,221,69,8,153,80,137,91,51,37,69,109,228,17,158,57,238,35,175,164,114,128,148,169,225,133,205,228,174,34,199,246,194,58,148,122,149,116,53,38,236,141,120,189,177,113,105,54,53,71,105,141,190,109,107,24,123,85,62,63,27,152,211,252,169,225,138,109,147,144,163,160,114,249,107,141,36,152,192,51,163,154,141,46,184,91,83,246,120,209,218,142,255,248,16,223,88,152,73,91,43,222,222,113,213,248,34,21,87,22,14,126,148,171,117,15,176,224,200,55,64,36,118,209,118,156,156,246,101,59,58,223,118,178,225,213,129,22,148,3,218,125,72,251,71,164,7,166,255,20,158,247,120,140,187,248,191,8,239,188,255,149,237,85,28,118,227,45,164,110,189,238,130,218,144,230,218,73,215,134,141,251,102,204,99,83,231,66,186,180,64,32,250,16,44,93,67,62,93,50,1,10,86,220,1,139,2,34,179,196,22,48,97,199,212,252,153,168,79,113,101,25,196,187,22,249,246,86,59,4,191,137,144,6,52,75,4,206,58,115,58,21,34,26,44,94,252,167,247,116,62,62,100,63,61,1,85,144,75,5,102,80,241,70,185,238,159,219,247,38,56,184,103,195,142,77,8,82,86,44,234,65,210,34,52,74,5,49,8,174,65,29,6,224,9,132,96,154,90,58,183,211,7,254,122,3,79,148,227,6,193,14,155,46,118,200,237,242,200,155,220,164,74,17,175,26,208,181,51,238,248,194,52,88,66,20,62,9,139,194,27,241,221,8,200,20,183,150,126,75,148,181,51,24,247,142,251,75,124,130,67,197,162,59,137,142,182,240,104,140,79,235,17,192,105,114,186,0,151,41,233,231,74,173,124,134,27,243,178,123,47,190,208,211,229,71,110,208,70,244,218,117,71,111,165,46,71,113,242,14,143,228,168,217,35,244,59,244,27,101,203,170,91,122,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6573c1b1-fdac-48e4-8895-7d74aaa75617"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("85964dd5-975a-4175-b365-f6bcc976020c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0f58ee9b-487e-4dbf-83fb-0dffb0737e81"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("85964dd5-975a-4175-b365-f6bcc976020c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("23994e42-b0ed-494a-8b0b-ac11e9039ff3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("36222b2d-73a3-4e87-b579-50683f8832d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(278, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildOkButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0946a8b6-9add-43c5-845f-1b459d9c61f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23994e42-b0ed-494a-8b0b-ac11e9039ff3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"ChildOkButtonClickMessage",
				Position = new Point(22, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a5131df6-8197-4c26-b1dd-982d9eab5bfb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23994e42-b0ed-494a-8b0b-ac11e9039ff3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"IntermediateThrowMessageEvent1",
				Position = new Point(232, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e35d1f31-2d9e-4b2d-a017-19f74741cef6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23994e42-b0ed-494a-8b0b-ac11e9039ff3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"ScriptChildOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,65,78,195,48,16,60,19,41,127,176,122,74,164,42,15,160,4,14,80,161,28,64,21,129,94,16,7,215,222,128,165,196,174,108,167,40,66,253,59,142,29,211,144,54,81,123,204,122,102,118,103,118,179,195,18,113,193,97,157,163,20,173,164,32,160,84,78,190,160,194,43,44,113,5,26,228,26,151,53,228,162,150,4,146,103,3,93,132,193,206,176,136,224,74,159,73,187,183,216,182,208,145,183,30,165,108,181,21,25,84,176,66,15,140,104,38,56,150,205,141,210,146,241,207,249,84,171,91,35,205,10,20,29,73,167,136,215,101,25,163,159,48,184,26,118,73,79,224,17,135,239,75,123,71,113,108,218,239,195,96,35,68,137,152,90,86,91,221,44,185,102,186,113,248,183,140,26,229,163,74,138,30,107,70,19,11,55,2,131,89,222,103,125,66,70,103,31,221,116,19,163,68,206,232,147,160,172,96,64,51,254,175,63,101,250,239,123,110,96,110,63,230,101,100,228,59,127,28,215,126,223,45,203,7,53,74,114,145,57,91,134,58,0,36,175,34,183,128,40,54,153,117,107,59,173,229,204,140,196,114,81,32,231,38,114,136,196,57,183,53,111,184,239,203,212,219,217,247,8,74,5,238,184,198,135,56,28,188,151,154,240,180,232,91,182,175,201,11,20,32,129,19,152,184,38,119,128,18,116,45,57,210,210,252,107,191,15,24,21,84,221,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEntitySchemaEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEntitySchemaEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2f430443-abc6-48e4-81ae-f21df2065580"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b53f79b-9df8-4907-bfa1-cca8a83e18a5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EntitySchemaEditChangeEventSubProcess",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(235, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEntitySchemaEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7daea2ac-640b-4f37-be0f-0592e34b5b45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2f430443-abc6-48e4-81ae-f21df2065580"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"StartMessage2",
				Position = new Point(28, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEntitySchemaEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("71acbb21-b7de-4c01-bbcf-92b869a87459"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2f430443-abc6-48e4-81ae-f21df2065580"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EntitySchemaEditChangeScriptTask",
				Position = new Point(126, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,193,110,219,48,12,61,219,128,255,65,235,201,46,2,7,219,142,105,122,216,18,4,1,214,45,72,218,93,138,30,4,153,73,133,217,146,65,73,219,140,33,255,62,91,178,93,71,141,131,246,34,3,214,227,123,228,19,201,233,117,20,254,166,72,74,138,180,0,13,248,147,230,6,200,156,196,27,148,12,148,218,177,103,40,232,230,228,58,217,208,3,164,75,161,185,174,220,253,50,227,58,181,119,179,40,84,26,185,56,16,102,16,65,232,33,172,35,63,85,235,3,249,158,196,62,235,143,60,107,163,230,163,140,9,249,23,133,1,130,54,40,136,70,203,117,140,194,40,92,25,158,17,24,192,31,214,89,45,223,252,78,151,69,169,171,86,212,203,103,39,13,50,171,120,193,4,7,74,119,12,121,169,93,6,91,56,192,95,130,205,249,77,202,95,166,180,192,59,202,80,170,70,22,4,32,213,18,31,52,207,185,230,160,210,21,232,237,89,120,156,212,169,5,123,137,64,217,51,137,239,168,174,63,133,61,185,24,145,72,45,10,84,60,234,147,75,51,104,74,182,92,233,10,165,41,85,250,85,26,161,201,135,57,249,220,34,2,38,235,96,97,157,12,130,99,115,180,175,154,191,168,214,37,13,89,30,63,61,245,47,25,4,214,122,4,101,114,61,235,52,173,239,247,88,213,70,42,136,7,76,19,34,141,110,209,93,146,193,189,41,115,184,105,98,38,196,137,223,18,101,139,89,128,178,174,115,41,172,173,39,149,14,46,191,84,235,44,110,89,109,18,193,235,94,120,197,152,174,53,20,31,251,186,143,109,43,93,232,132,182,195,154,110,125,239,244,156,204,205,116,234,17,165,91,216,67,253,146,12,134,25,123,53,212,129,126,88,151,133,115,173,239,116,31,182,224,170,204,105,245,70,116,55,20,111,152,137,239,82,52,245,156,173,179,47,160,103,158,121,27,72,117,184,141,247,135,42,178,224,172,121,35,138,213,141,75,119,114,41,157,91,127,188,85,191,74,132,201,115,215,104,190,202,252,12,158,8,248,243,94,237,56,73,220,26,242,216,30,175,156,37,235,236,234,233,172,25,227,27,112,116,1,214,81,215,211,40,28,110,192,255,67,211,232,128,217,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f66cfba6-5b72-4eac-b38e-109fc53aa6c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c39ca6f3-e063-4eef-9d68-d76eef3ec2d4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"PageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 154),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(314, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoqdCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c191f13a-19f7-474e-90e3-f899178bfb36"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f66cfba6-5b72-4eac-b38e-109fc53aa6c3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"PageLoqdCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("269f7824-4252-4e2b-a9b7-e47296f493b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f66cfba6-5b72-4eac-b38e-109fc53aa6c3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"PageLoqdCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8238d513-e620-4bbd-9c47-587e384cc1d4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f66cfba6-5b72-4eac-b38e-109fc53aa6c3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,78,195,48,16,133,215,169,212,59,152,174,18,169,242,5,160,72,208,134,42,18,208,136,2,27,196,194,196,211,98,53,113,34,255,0,17,226,238,56,118,211,218,1,36,150,182,223,251,222,120,102,114,81,23,32,229,186,120,133,138,160,38,56,205,208,21,227,116,1,146,109,57,208,220,127,139,147,211,241,40,39,197,142,108,225,33,163,70,26,88,241,241,201,232,222,136,64,13,17,164,2,5,66,26,237,2,54,68,151,234,145,148,26,36,34,18,45,88,161,88,205,137,104,207,164,18,140,111,167,40,136,203,123,183,181,156,27,38,219,160,216,103,206,16,215,101,153,160,207,241,40,18,160,180,224,72,9,13,70,249,53,30,57,230,177,6,75,233,106,62,0,158,38,41,87,76,181,46,46,163,147,103,108,69,251,164,19,71,192,153,188,53,41,43,145,86,141,106,227,144,151,184,112,159,227,58,195,225,29,45,53,163,67,189,97,71,221,61,130,32,218,56,150,160,250,211,101,107,32,241,0,106,173,254,93,74,153,90,149,180,255,87,8,236,196,185,25,6,246,29,215,117,189,211,77,231,195,107,112,147,184,224,244,30,62,84,28,186,167,198,29,61,72,16,243,154,115,176,99,10,64,55,132,27,182,192,166,230,76,65,245,123,189,120,78,154,206,153,12,106,177,249,41,39,47,37,116,255,222,79,44,250,57,23,59,145,59,216,128,0,94,128,223,221,65,148,13,248,123,117,220,200,251,62,13,43,9,181,135,74,236,233,255,233,3,104,176,108,61,216,44,165,191,165,223,35,235,107,48,134,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEntitySchemaLookupEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEntitySchemaLookupEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d807f077-34a6-4732-bbb8-3a7cd19645f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b53f79b-9df8-4907-bfa1-cca8a83e18a5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EntitySchemaLookupEditChangeEventSubProcess",
				Position = new Point(295, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEntitySchemaLookupEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySchemaLookupEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("92e00aa6-371a-4a45-90aa-8dc3be7789be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d807f077-34a6-4732-bbb8-3a7cd19645f2"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntitySchemaLookupEditChange",
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EntitySchemaLookupEditChangeStartMessage",
				Position = new Point(42, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEntitySchemaLookupEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b07c23ed-95a3-4571-bd2d-b04a3976b0ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d807f077-34a6-4732-bbb8-3a7cd19645f2"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9"),
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Name = @"EntitySchemaLookupEditChangeScriptTask",
				Position = new Point(133, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,10,194,48,16,68,207,22,250,15,235,173,94,250,3,210,139,80,74,65,180,88,234,61,154,85,131,105,83,211,141,80,196,127,183,137,98,67,209,99,152,151,153,217,185,51,13,216,144,160,190,60,94,176,102,57,135,4,162,204,8,190,40,216,25,227,212,211,214,74,93,77,155,114,65,241,158,73,131,203,48,16,39,136,124,196,138,91,201,157,12,73,50,177,94,192,35,12,102,26,201,232,6,72,59,135,103,24,28,148,146,32,186,141,162,180,110,169,135,233,55,152,39,96,27,197,78,254,164,142,252,219,213,111,81,185,43,50,164,239,115,213,231,60,154,148,177,225,128,178,195,127,255,253,200,161,102,213,114,70,248,230,114,94,48,205,106,36,212,238,214,200,186,121,131,185,145,74,164,29,222,140,208,200,253,186,63,200,180,97,7,137,54,116,228,6,236,255,178,147,133,6,214,95,245,5,231,206,179,82,213,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetSchemaUIdByIdMethod());
			Methods.Add(CreateGetSchemaIdByUIdMethod());
			Methods.Add(CreateUpdateEntityIdParameterValueMethod());
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
				UId = new Guid("0150da5d-1570-4e39-80f4-208937245fa0"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("147a578c-31e6-4639-884e-fd304632348e"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4abd165c-a68d-455b-ad6c-ebcea94f4fb0"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("de8ba084-7212-4480-9dbe-8a387a10844f")
			});
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,105,104,42,84,243,114,233,235,87,43,185,230,149,100,150,84,6,39,103,164,230,38,122,166,40,233,40,4,36,166,167,234,33,139,186,166,100,150,212,234,240,114,193,212,162,171,2,203,243,114,213,90,3,0,39,243,184,178,151,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaUIdByIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("03b21973-5ddc-4468-81bc-db5762f9e74b"),
				Name = "GetSchemaUIdById",
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5c446f99-81a0-4a45-b09e-f15f5e1d250c"),
				Name = "schemaId",
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,141,65,10,194,48,16,69,215,233,41,74,86,147,77,47,160,184,41,85,178,19,66,113,61,36,3,45,36,19,156,36,168,183,183,214,238,62,143,255,120,66,181,9,119,10,152,94,189,163,72,190,194,92,72,198,204,188,237,53,179,233,148,26,198,28,91,98,208,179,13,122,3,195,85,114,2,237,62,197,249,133,18,238,236,177,144,16,232,227,97,203,244,108,24,225,111,14,119,20,76,84,73,160,236,134,13,198,244,88,142,228,79,152,222,228,91,37,231,49,162,156,111,109,13,23,48,167,47,186,157,117,19,160,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaIdByUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("853acd55-df73-46da-86e7-740905b5f6c3"),
				Name = "GetSchemaIdByUId",
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f7102cff-ab00-4576-af6e-1e91750413ed"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				ModifiedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,221,106,194,64,16,70,175,21,124,135,37,87,27,40,251,2,214,66,107,82,201,69,139,144,70,175,135,205,160,193,100,98,103,119,181,121,251,142,221,254,104,161,246,110,88,190,57,115,246,203,192,195,10,218,128,47,195,30,213,38,52,117,118,240,106,166,42,135,60,239,137,208,250,166,39,147,157,199,158,128,96,131,108,22,232,11,114,30,200,226,195,240,12,29,234,100,33,128,36,157,78,198,7,96,229,236,22,59,40,177,21,136,154,77,198,35,29,231,148,240,168,226,168,47,239,164,18,26,153,121,223,134,142,116,82,8,74,30,204,35,247,157,78,86,199,114,112,57,249,198,15,229,7,184,160,37,216,157,152,196,212,122,139,44,6,18,90,247,188,115,123,176,120,2,152,194,229,175,1,90,29,169,102,9,44,166,30,249,215,105,243,189,101,138,250,230,171,137,52,26,221,83,173,147,234,58,46,254,182,250,99,89,180,62,109,255,193,252,164,206,56,82,40,163,15,76,23,157,154,252,13,109,240,88,90,104,129,111,79,221,223,233,116,250,14,79,51,83,209,211,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateEntityIdParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0b3c380d-ba4e-45be-a2ec-85925455bd25"),
				Name = "UpdateEntityIdParameterValue",
				CreatedInSchemaUId = new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"),
				CreatedInPackageId = new Guid("4b82e7a6-fdf0-4e2d-934b-d9adcabce6c9"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,14,78,206,72,205,77,12,72,44,74,204,77,45,73,45,10,75,204,41,77,85,40,64,229,218,42,4,36,166,167,234,185,230,149,100,150,84,186,166,100,150,232,161,170,183,230,229,66,213,161,231,155,159,146,153,150,153,154,226,153,7,49,63,212,51,5,104,10,72,43,156,143,169,41,40,53,45,181,40,53,47,57,21,69,15,216,82,60,186,96,78,204,43,205,201,193,148,117,201,44,46,200,73,172,196,175,40,56,191,180,40,25,236,77,220,97,2,81,163,231,151,159,7,242,46,122,120,192,204,47,64,15,23,125,125,116,165,193,169,37,96,73,13,84,181,154,214,0,241,68,169,247,145,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LinkEntityToProcessUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0ba4c98-ab72-4864-8ddc-a6168badab68"));
		}

		#endregion

	}

	#endregion

}

