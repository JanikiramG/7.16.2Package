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

	#region Class: UserSessionDetailGridPageSchema

	/// <exclude/>
	public class UserSessionDetailGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _terminateSessionButton;
		public Terrasoft.UI.WebControls.Controls.Button TerminateSessionButton {
			get {
				return _terminateSessionButton;
			}
		}

		#endregion

		#region Constructors: Public

		public UserSessionDetailGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public UserSessionDetailGridPageSchema(UserSessionDetailGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Hidden = true;
			AddButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.Hidden = true;
			DeleteButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"9332ded81fb6fd89ce8c95fb6800043c"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
			RealUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
			Name = "UserSessionDetailGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateUserSessionDetailGridPageEventsProcessSchema();
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
			ButtonsControlLayout.InsertItem(0, CreateTerminateSessionButton());
			ButtonsControlLayout.MoveItem(1, AddButton);
			ButtonsControlLayout.MoveItem(2, CopyButton);
			ButtonsControlLayout.MoveItem(3, EditButton);
			ButtonsControlLayout.MoveItem(4, DeleteButton);
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, ActionButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateUserSessionDetailGridPageEventsProcessSchema() {
			var schema = new UserSessionDetailGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateTerminateSessionButton() {
			_terminateSessionButton = new Terrasoft.UI.WebControls.Controls.Button();
			_terminateSessionButton.UId = new Guid("0a3d09c7-82a1-41ba-885c-ddc20108b535");
			_terminateSessionButton.Name = "TerminateSessionButton";
			_terminateSessionButton.CreatedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
			_terminateSessionButton.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
			_terminateSessionButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_terminateSessionButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_terminateSessionButton.Tag = "";
			_terminateSessionButton.Image = new ControlImage {};
			return _terminateSessionButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			DataSource.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("dc25c5f8-99c0-4b14-a061-45f6acdba1ef");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
				column.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a3557536-73b8-4621-8374-8f2c77fc1abd");
			if (column != null) {
				column.UId = new Guid("6836d9a0-48c7-45e3-9fec-feb5da01d76b");
				column.Name = @"SessionStartDate";
				column.CreatedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
				column.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Descending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("86a0a1f4-7d2d-45da-b313-8f96c983215c");
			if (column != null) {
				column.UId = new Guid("5d345232-fd7d-4bcd-b5f0-c23e2c4d9018");
				column.Name = @"SessionEndDate";
				column.CreatedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
				column.ModifiedInSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new UserSessionDetailGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new UserSessionDetailGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new UserSessionDetailGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: UserSessionDetailGridPageEventsProcess

	/// <exclude/>
	public class UserSessionDetailGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.UserSessionDetailGridPageSchemaUserControl
	{

		#region Class: TerminateSessionUserMessageFlowElement

		/// <exclude/>
		public class TerminateSessionUserMessageFlowElement : QuestionUserTask
		{

			public TerminateSessionUserMessageFlowElement(UserConnection userConnection, UserSessionDetailGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "TerminateSessionUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public UserSessionDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UserSessionDetailGridPageEventsProcess";
			SchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8");
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

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("b0ebf8e8-8786-4bce-8bd4-b902ec119c27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initialize;
		public ProcessFlowElement Initialize {
			get {
				return _initialize ?? (_initialize = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Initialize",
					SchemaElementUId = new Guid("813af259-b317-4322-aac8-1c250f92a772"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initializeScript;
		public ProcessScriptTask InitializeScript {
			get {
				return _initializeScript ?? (_initializeScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitializeScript",
					SchemaElementUId = new Guid("ad4742ac-7790-4a78-9d24-e3ca46e75d7b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitializeScriptExecute,
				});
			}
		}

		private ProcessFlowElement _terminateSessionSubProcess;
		public ProcessFlowElement TerminateSessionSubProcess {
			get {
				return _terminateSessionSubProcess ?? (_terminateSessionSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "TerminateSessionSubProcess",
					SchemaElementUId = new Guid("bfcf3cd6-3739-495a-b782-1050b0cf7897"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _terminateSessionButtonClick;
		public ProcessFlowElement TerminateSessionButtonClick {
			get {
				return _terminateSessionButtonClick ?? (_terminateSessionButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TerminateSessionButtonClick",
					SchemaElementUId = new Guid("8ed5e6b7-4bf2-411a-8c65-27951b120129"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _terminateSessionButtonScript;
		public ProcessScriptTask TerminateSessionButtonScript {
			get {
				return _terminateSessionButtonScript ?? (_terminateSessionButtonScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TerminateSessionButtonScript",
					SchemaElementUId = new Guid("3e0e7fd2-2f48-4163-8297-339caebad6f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TerminateSessionButtonScriptExecute,
				});
			}
		}

		private TerminateSessionUserMessageFlowElement _terminateSessionUserMessage;
		public TerminateSessionUserMessageFlowElement TerminateSessionUserMessage {
			get {
				return _terminateSessionUserMessage ?? (_terminateSessionUserMessage = new TerminateSessionUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _terminateSessionNoMessageSubProcess;
		public ProcessFlowElement TerminateSessionNoMessageSubProcess {
			get {
				return _terminateSessionNoMessageSubProcess ?? (_terminateSessionNoMessageSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "TerminateSessionNoMessageSubProcess",
					SchemaElementUId = new Guid("101ba50e-1d83-4b52-b162-413cfb1ed2b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _terminateSessionNoMessage;
		public ProcessFlowElement TerminateSessionNoMessage {
			get {
				return _terminateSessionNoMessage ?? (_terminateSessionNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TerminateSessionNoMessage",
					SchemaElementUId = new Guid("ec349a10-ad08-41af-8a11-654c3ca56428"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _terminateSessionNoMessageScript;
		public ProcessScriptTask TerminateSessionNoMessageScript {
			get {
				return _terminateSessionNoMessageScript ?? (_terminateSessionNoMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TerminateSessionNoMessageScript",
					SchemaElementUId = new Guid("8227cfa8-1e8b-478a-a535-02c59d8f44ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TerminateSessionNoMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _terminateSessionYesMessageScriptSubProcess;
		public ProcessFlowElement TerminateSessionYesMessageScriptSubProcess {
			get {
				return _terminateSessionYesMessageScriptSubProcess ?? (_terminateSessionYesMessageScriptSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "TerminateSessionYesMessageScriptSubProcess",
					SchemaElementUId = new Guid("84bd36d8-6f9d-43e1-92a6-b05d3dc6309a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _terminateSessionYesMessage;
		public ProcessFlowElement TerminateSessionYesMessage {
			get {
				return _terminateSessionYesMessage ?? (_terminateSessionYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TerminateSessionYesMessage",
					SchemaElementUId = new Guid("bf87da21-ddef-4ca9-9864-10827f8e9fdb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _terminateSessionYesMessageScript;
		public ProcessScriptTask TerminateSessionYesMessageScript {
			get {
				return _terminateSessionYesMessageScript ?? (_terminateSessionYesMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TerminateSessionYesMessageScript",
					SchemaElementUId = new Guid("1808abf9-4b2e-4cff-83f8-fe28123f2bf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TerminateSessionYesMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteSubProcess;
		public ProcessFlowElement PageLoadCompleteSubProcess {
			get {
				return _pageLoadCompleteSubProcess ?? (_pageLoadCompleteSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteSubProcess",
					SchemaElementUId = new Guid("08e9c547-da30-4743-a505-d5acd71a70fb"),
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
					SchemaElementUId = new Guid("c62567e8-3bc6-433c-945b-7e7e6da49fc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediatePageLoadComplete;
		public ProcessThrowMessageEvent IntermediatePageLoadComplete {
			get {
				return _intermediatePageLoadComplete ?? (_intermediatePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediatePageLoadComplete",
					SchemaElementUId = new Guid("3d0b1deb-ea16-4c51-8a32-cd4b8fceede6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("d62ed61c-5c27-4f75-bca9-48c8202b99fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptExecute,
				});
			}
		}

		private LocalizableString _terminateSessionMessage;
		public LocalizableString TerminateSessionMessage {
			get {
				return _terminateSessionMessage ?? (_terminateSessionMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TerminateSessionMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[Initialize.SchemaElementUId] = new Collection<ProcessFlowElement> { Initialize };
			FlowElements[InitializeScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitializeScript };
			FlowElements[TerminateSessionSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionSubProcess };
			FlowElements[TerminateSessionButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionButtonClick };
			FlowElements[TerminateSessionButtonScript.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionButtonScript };
			FlowElements[TerminateSessionUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionUserMessage };
			FlowElements[TerminateSessionNoMessageSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionNoMessageSubProcess };
			FlowElements[TerminateSessionNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionNoMessage };
			FlowElements[TerminateSessionNoMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionNoMessageScript };
			FlowElements[TerminateSessionYesMessageScriptSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionYesMessageScriptSubProcess };
			FlowElements[TerminateSessionYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionYesMessage };
			FlowElements[TerminateSessionYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateSessionYesMessageScript };
			FlowElements[PageLoadCompleteSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteSubProcess };
			FlowElements[ChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadComplete };
			FlowElements[IntermediatePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediatePageLoadComplete };
			FlowElements[PageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess9":
						break;
					case "Initialize":
						e.Context.QueueTasks.Enqueue("InitializeScript");
						break;
					case "InitializeScript":
						break;
					case "TerminateSessionSubProcess":
						break;
					case "TerminateSessionButtonClick":
						e.Context.QueueTasks.Enqueue("TerminateSessionButtonScript");
						break;
					case "TerminateSessionButtonScript":
						e.Context.QueueTasks.Enqueue("TerminateSessionUserMessage");
						break;
					case "TerminateSessionUserMessage":
						break;
					case "TerminateSessionNoMessageSubProcess":
						break;
					case "TerminateSessionNoMessage":
						e.Context.QueueTasks.Enqueue("TerminateSessionNoMessageScript");
						break;
					case "TerminateSessionNoMessageScript":
						break;
					case "TerminateSessionYesMessageScriptSubProcess":
						break;
					case "TerminateSessionYesMessage":
						e.Context.QueueTasks.Enqueue("TerminateSessionYesMessageScript");
						break;
					case "TerminateSessionYesMessageScript":
						break;
					case "PageLoadCompleteSubProcess":
						break;
					case "ChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediatePageLoadComplete");
						break;
					case "IntermediatePageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScript");
						break;
					case "PageLoadCompleteScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("Initialize");
			ActivatedEventElements.Add("TerminateSessionButtonClick");
			ActivatedEventElements.Add("TerminateSessionNoMessage");
			ActivatedEventElements.Add("TerminateSessionYesMessage");
			ActivatedEventElements.Add("ChildPageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "Initialize":
					context.QueueTasks.Dequeue();
					context.SenderName = "Initialize";
					result = Initialize.Execute(context);
					break;
				case "InitializeScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitializeScript";
					result = InitializeScript.Execute(context, InitializeScriptExecute);
					break;
				case "TerminateSessionSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "TerminateSessionButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "TerminateSessionButtonClick";
					result = TerminateSessionButtonClick.Execute(context);
					break;
				case "TerminateSessionButtonScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "TerminateSessionButtonScript";
					result = TerminateSessionButtonScript.Execute(context, TerminateSessionButtonScriptExecute);
					break;
				case "TerminateSessionUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TerminateSessionUserMessage";
					result = TerminateSessionUserMessage.Execute(context);
					break;
				case "TerminateSessionNoMessageSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "TerminateSessionNoMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TerminateSessionNoMessage";
					result = TerminateSessionNoMessage.Execute(context);
					break;
				case "TerminateSessionNoMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "TerminateSessionNoMessageScript";
					result = TerminateSessionNoMessageScript.Execute(context, TerminateSessionNoMessageScriptExecute);
					break;
				case "TerminateSessionYesMessageScriptSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "TerminateSessionYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TerminateSessionYesMessage";
					result = TerminateSessionYesMessage.Execute(context);
					break;
				case "TerminateSessionYesMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "TerminateSessionYesMessageScript";
					result = TerminateSessionYesMessageScript.Execute(context, TerminateSessionYesMessageScriptExecute);
					break;
				case "PageLoadCompleteSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadComplete";
					result = ChildPageLoadComplete.Execute(context);
					break;
				case "IntermediatePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediatePageLoadComplete.Execute(context);
					break;
				case "PageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScript";
					result = PageLoadCompleteScript.Execute(context, PageLoadCompleteScriptExecute);
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

		public virtual bool InitializeScriptExecute(ProcessExecutingContext context) {
			Page.DataSource.DefStructure.Columns.FindByName("SysUser").IsVisible = true;
			Page.DataSource.DefStructure.Columns.FindByName("SysUser_Contact_Name").IsVisible = true;
			return true;
		}

		public virtual bool TerminateSessionButtonScriptExecute(ProcessExecutingContext context) {
			TerminateSessionUserMessage.Page = Page;
			TerminateSessionUserMessage.MessageText = TerminateSessionMessage;
			TerminateSessionUserMessage.Icon = "QUESTION";
			TerminateSessionUserMessage.Buttons = "YESNO";
			TerminateSessionUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "TerminateSessionYesMessage"},
				{"no", "TerminateSessionNoMessage"},
			};
			return true;
		}

		public virtual bool TerminateSessionNoMessageScriptExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool TerminateSessionYesMessageScriptExecute(ProcessExecutingContext context) {
			Update userSessionUpdate = new Update(Page.UserConnection, "SysUserSession")
			    .Set("SessionEndDate", Column.Parameter(Page.UserConnection.CurrentUser.GetCurrentDateTime(), UserConnection.DataValueTypeManager.GetInstanceByName("DateTime")))
			    .Set("SessionEndMethod", Column.Parameter(SessionEndMethod.Terminate))
			    .Where("Id").IsEqual(Column.Parameter(Page.DataSource.ActiveRowPrimaryColumnValue))
				    .And("SessionEndDate").IsNull() as Update;
			if (userSessionUpdate.Execute() > 0){
				Page.TreeGrid.RefreshSelectedNode();
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			Page.DataSource.EnableServerActiveRow = true;
			return true;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			var dataSource = Page.DataSource;
			var dataSourceRowsCount = dataSource.ActiveRowPrimaryColumnValue == Guid.Empty || !activate ? 0 : 1;
			var sessionEnded = dataSource.ActiveRow != null && dataSource.ActiveRow.GetTypedColumnValue<DateTime>("SessionEndDate") != new DateTime();
			Page.TerminateSessionButton.Enabled = dataSourceRowsCount > 0 && !sessionEnded;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Initialize":
							if (ActivatedEventElements.Contains("Initialize")) {
							context.QueueTasks.Enqueue("Initialize");
						}
						break;
					case "TerminateSessionButtonClick":
							if (ActivatedEventElements.Contains("TerminateSessionButtonClick")) {
							context.QueueTasks.Enqueue("TerminateSessionButtonClick");
						}
						break;
					case "TerminateSessionNoMessage":
							if (ActivatedEventElements.Contains("TerminateSessionNoMessage")) {
							context.QueueTasks.Enqueue("TerminateSessionNoMessage");
						}
						break;
					case "TerminateSessionYesMessage":
							if (ActivatedEventElements.Contains("TerminateSessionYesMessage")) {
							context.QueueTasks.Enqueue("TerminateSessionYesMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("ChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("ChildPageLoadComplete");
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

	#region Class: UserSessionDetailGridPageEventsProcess

	/// <exclude/>
	public class UserSessionDetailGridPageEventsProcess : UserSessionDetailGridPageEventsProcess<Terrasoft.WebApp.UserSessionDetailGridPageSchemaUserControl>
	{

		public UserSessionDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UserSessionDetailGridPageSchemaUserControl

	/// <exclude/>
	public partial class UserSessionDetailGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button TerminateSessionButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("TerminateSessionButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			TerminateSessionButton.AjaxEvents.Click.Event += TerminateSessionButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			TerminateSessionButton.AjaxEvents.Click.Event -= TerminateSessionButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (UserSessionDetailGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new UserSessionDetailGridPageEventsProcess(UserConnection);
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

		public virtual void TerminateSessionButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("TerminateSessionButtonClick");
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
			SchemaName = "UserSessionDetailGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: UserSessionDetailGridPageEventsProcessSchema

	/// <exclude/>
	public class UserSessionDetailGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public UserSessionDetailGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public UserSessionDetailGridPageEventsProcessSchema(UserSessionDetailGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UserSessionDetailGridPageEventsProcess";
			UId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeTerminateSessionUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("728689f6-50bf-42b8-8ec9-68d3ba00755f"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
				UId = new Guid("459419fc-a069-4148-ab41-a857f27cc808"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
				UId = new Guid("f5116604-1ca7-4bd9-a6a9-5928175eb1e0"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
				UId = new Guid("74a5f855-4c9d-4bba-b81d-73e786fdfe20"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
				UId = new Guid("0587f24d-6bac-449b-b9db-dbd6f34c599c"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
				UId = new Guid("57ae2152-19b1-4589-ad20-920411858732"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
				UId = new Guid("ee71869d-c5ea-4e8e-a73f-bc98912ac2c3"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
				UId = new Guid("aafa65a5-b3f4-4736-b2a5-41cce27d2d49"),
				ContainerUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
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
			ProcessSchemaLaneSet schemaLaneSet518 = CreateLaneSet518LaneSet();
			LaneSets.Add(schemaLaneSet518);
			ProcessSchemaLane schemaLane1743 = CreateLane1743Lane();
			schemaLaneSet518.Lanes.Add(schemaLane1743);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet518.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess terminatesessionsubprocess = CreateTerminateSessionSubProcessEventSubProcess();
			FlowElements.Add(terminatesessionsubprocess);
			ProcessSchemaEventSubProcess terminatesessionnomessagesubprocess = CreateTerminateSessionNoMessageSubProcessEventSubProcess();
			FlowElements.Add(terminatesessionnomessagesubprocess);
			ProcessSchemaEventSubProcess terminatesessionyesmessagescriptsubprocess = CreateTerminateSessionYesMessageScriptSubProcessEventSubProcess();
			FlowElements.Add(terminatesessionyesmessagescriptsubprocess);
			ProcessSchemaEventSubProcess pageloadcompletesubprocess = CreatePageLoadCompleteSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletesubprocess);
			ProcessSchemaStartMessageEvent initialize = CreateInitializeStartMessageEvent();
			eventsubprocess9.FlowElements.Add(initialize);
			ProcessSchemaScriptTask initializescript = CreateInitializeScriptScriptTask();
			eventsubprocess9.FlowElements.Add(initializescript);
			ProcessSchemaStartMessageEvent terminatesessionbuttonclick = CreateTerminateSessionButtonClickStartMessageEvent();
			terminatesessionsubprocess.FlowElements.Add(terminatesessionbuttonclick);
			ProcessSchemaScriptTask terminatesessionbuttonscript = CreateTerminateSessionButtonScriptScriptTask();
			terminatesessionsubprocess.FlowElements.Add(terminatesessionbuttonscript);
			ProcessSchemaUserTask terminatesessionusermessage = CreateTerminateSessionUserMessageUserTask();
			terminatesessionsubprocess.FlowElements.Add(terminatesessionusermessage);
			ProcessSchemaStartMessageEvent terminatesessionnomessage = CreateTerminateSessionNoMessageStartMessageEvent();
			terminatesessionnomessagesubprocess.FlowElements.Add(terminatesessionnomessage);
			ProcessSchemaScriptTask terminatesessionnomessagescript = CreateTerminateSessionNoMessageScriptScriptTask();
			terminatesessionnomessagesubprocess.FlowElements.Add(terminatesessionnomessagescript);
			ProcessSchemaStartMessageEvent terminatesessionyesmessage = CreateTerminateSessionYesMessageStartMessageEvent();
			terminatesessionyesmessagescriptsubprocess.FlowElements.Add(terminatesessionyesmessage);
			ProcessSchemaScriptTask terminatesessionyesmessagescript = CreateTerminateSessionYesMessageScriptScriptTask();
			terminatesessionyesmessagescriptsubprocess.FlowElements.Add(terminatesessionyesmessagescript);
			ProcessSchemaStartMessageEvent childpageloadcomplete = CreateChildPageLoadCompleteStartMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(childpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatepageloadcomplete = CreateIntermediatePageLoadCompleteIntermediateThrowMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(intermediatepageloadcomplete);
			ProcessSchemaScriptTask pageloadcompletescript = CreatePageLoadCompleteScriptScriptTask();
			pageloadcompletesubprocess.FlowElements.Add(pageloadcompletescript);
			FlowElements.Add(CreateSequenceFlow10524SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTerminateSessionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTerminateSessionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b3dbe6af-721d-4afe-9e91-a0e747c95762"),
				Name = "TerminateSessionMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10524SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10524",
				UId = new Guid("81b9ad2e-4d72-49c6-bc5a-d79d57f4937b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				CurveCenterPosition = new Point(168, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("813af259-b317-4322-aac8-1c250f92a772"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad4742ac-7790-4a78-9d24-e3ca46e75d7b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b95e7788-eb73-4f00-8fbe-0e95a896cb5d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8ed5e6b7-4bf2-411a-8c65-27951b120129"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e0e7fd2-2f48-4163-8297-339caebad6f1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("df7589ab-5670-43ac-85d5-9d83c1c1103d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				CurveCenterPosition = new Point(397, 65),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec349a10-ad08-41af-8a11-654c3ca56428"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8227cfa8-1e8b-478a-a535-02c59d8f44ee"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("28187be3-8db6-465a-85df-c83e9d82315e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				CurveCenterPosition = new Point(478, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf87da21-ddef-4ca9-9864-10827f8e9fdb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1808abf9-4b2e-4cff-83f8-fe28123f2bf9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("8a4f5e87-119b-4859-b801-b721c8a41c96"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				CurveCenterPosition = new Point(271, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e0e7fd2-2f48-4163-8297-339caebad6f1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("8859c2d6-1b47-487f-ad2b-656e42d3ac02"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				CurveCenterPosition = new Point(435, 400),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c62567e8-3bc6-433c-945b-7e7e6da49fc4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d0b1deb-ea16-4c51-8a32-cd4b8fceede6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("f47c6c49-18be-48ac-8bd5-78e400b55938"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				CurveCenterPosition = new Point(562, 400),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d0b1deb-ea16-4c51-8a32-cd4b8fceede6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d62ed61c-5c27-4f75-bca9-48c8202b99fa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet518LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet518 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8e833fa6-18f8-4200-b4f7-61437cab1a6c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"LaneSet518",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(757, 564),
				UseBackgroundMode = false
			};
			return schemaLaneSet518;
		}

		protected virtual ProcessSchemaLane CreateLane1743Lane() {
			ProcessSchemaLane schemaLane1743 = new ProcessSchemaLane(this) {
				UId = new Guid("b6319935-893d-42a5-96a5-5ba4352ae16a"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("8e833fa6-18f8-4200-b4f7-61437cab1a6c"),
				CreatedInOwnerSchemaUId = new Guid("0bb993d8-70c1-4105-878a-0ea423b31fa8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"Lane1743",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 324),
				Size = new Size(728, 240),
				UseBackgroundMode = false
			};
			return schemaLane1743;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("42623a26-cad5-40b2-91dd-6bc9d4d1477f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8e833fa6-18f8-4200-b4f7-61437cab1a6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(728, 319),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b0ebf8e8-8786-4bce-8bd4-b902ec119c27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6319935-893d-42a5-96a5-5ba4352ae16a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitializeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("813af259-b317-4322-aac8-1c250f92a772"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0ebf8e8-8786-4bce-8bd4-b902ec119c27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Initialize",
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"Initialize",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitializeScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ad4742ac-7790-4a78-9d24-e3ca46e75d7b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0ebf8e8-8786-4bce-8bd4-b902ec119c27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"InitializeScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,6,50,83,211,130,75,138,74,147,75,74,139,82,245,156,243,115,74,115,243,138,245,220,50,243,82,156,42,253,18,115,83,53,148,130,43,139,67,139,83,139,148,52,245,60,139,195,50,139,51,147,114,82,21,108,21,128,90,82,173,121,185,2,200,52,45,222,57,63,175,36,49,185,36,30,36,138,221,232,162,84,160,33,121,16,30,0,67,17,229,69,181,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateTerminateSessionSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaTerminateSessionSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bfcf3cd6-3739-495a-b782-1050b0cf7897"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42623a26-cad5-40b2-91dd-6bc9d4d1477f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(349, 298),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaTerminateSessionSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTerminateSessionButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8ed5e6b7-4bf2-411a-8c65-27951b120129"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bfcf3cd6-3739-495a-b782-1050b0cf7897"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TerminateSessionButtonClick",
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionButtonClick",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTerminateSessionButtonScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3e0e7fd2-2f48-4163-8297-339caebad6f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bfcf3cd6-3739-495a-b782-1050b0cf7897"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionButtonScript",
				Position = new Point(127, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,177,14,130,48,16,134,103,73,120,135,166,51,241,5,80,7,35,3,3,160,82,6,70,66,46,164,131,87,211,59,162,132,240,238,22,237,96,136,145,165,255,93,238,251,254,84,129,189,105,108,24,74,32,210,6,43,2,155,185,177,233,96,123,118,143,216,139,57,226,48,80,127,72,159,10,158,236,132,37,233,175,43,29,105,107,208,201,242,82,37,165,74,139,92,174,240,199,158,217,32,205,74,157,148,121,177,198,95,129,238,142,7,191,207,34,194,67,156,116,203,142,108,236,176,35,182,26,187,72,124,242,32,198,48,216,140,114,0,146,145,144,203,234,26,200,55,201,41,122,131,104,126,113,185,249,198,38,247,73,11,220,91,20,108,123,136,95,92,28,201,164,127,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateTerminateSessionUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5242baf2-b6f3-4496-b888-ff8e306556de"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bfcf3cd6-3739-495a-b782-1050b0cf7897"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 198),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeTerminateSessionUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateTerminateSessionNoMessageSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaTerminateSessionNoMessageSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("101ba50e-1d83-4b52-b162-413cfb1ed2b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42623a26-cad5-40b2-91dd-6bc9d4d1477f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionNoMessageSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(251, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaTerminateSessionNoMessageSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTerminateSessionNoMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec349a10-ad08-41af-8a11-654c3ca56428"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("101ba50e-1d83-4b52-b162-413cfb1ed2b9"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TerminateSessionNoMessage",
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTerminateSessionNoMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8227cfa8-1e8b-478a-a535-02c59d8f44ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("101ba50e-1d83-4b52-b162-413cfb1ed2b9"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionNoMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateTerminateSessionYesMessageScriptSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaTerminateSessionYesMessageScriptSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("84bd36d8-6f9d-43e1-92a6-b05d3dc6309a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42623a26-cad5-40b2-91dd-6bc9d4d1477f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionYesMessageScriptSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 156),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(250, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaTerminateSessionYesMessageScriptSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTerminateSessionYesMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bf87da21-ddef-4ca9-9864-10827f8e9fdb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84bd36d8-6f9d-43e1-92a6-b05d3dc6309a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TerminateSessionYesMessage",
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTerminateSessionYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1808abf9-4b2e-4cff-83f8-fe28123f2bf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84bd36d8-6f9d-43e1-92a6-b05d3dc6309a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"TerminateSessionYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,79,107,195,48,12,197,207,43,244,59,152,156,98,40,102,247,178,65,215,149,210,67,75,105,146,237,108,226,215,53,144,216,157,108,175,11,99,223,125,74,218,109,208,63,190,73,214,251,233,73,42,246,70,7,136,232,65,25,188,175,156,45,142,153,7,97,113,16,199,32,93,235,55,168,130,107,166,206,90,148,129,203,70,34,201,90,95,252,235,18,57,28,8,126,42,67,72,147,83,114,102,205,51,3,146,145,152,186,58,54,86,173,53,233,6,1,116,141,169,166,145,8,54,116,89,53,71,56,133,29,33,175,26,164,114,36,206,4,252,165,95,116,29,145,183,123,44,181,101,102,175,92,88,31,180,45,241,212,174,184,93,154,252,34,18,41,111,216,92,34,236,156,185,102,244,188,70,229,160,166,178,76,252,99,189,238,64,220,101,97,18,169,22,126,246,30,117,157,94,31,184,51,156,185,72,37,212,132,71,248,192,198,29,214,84,53,154,218,163,160,159,166,3,223,245,228,137,53,23,203,236,122,172,98,93,167,82,104,127,58,209,120,56,168,182,34,189,184,163,154,125,162,140,124,66,41,30,197,189,252,98,110,239,35,39,96,78,149,81,27,108,9,126,151,161,230,149,194,172,156,225,90,166,125,15,7,132,16,201,138,64,17,227,31,152,115,240,27,40,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("08e9c547-da30-4743-a505-d5acd71a70fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6319935-893d-42a5-96a5-5ba4352ae16a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"PageLoadCompleteSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(441, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c62567e8-3bc6-433c-945b-7e7e6da49fc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08e9c547-da30-4743-a505-d5acd71a70fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"ChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediatePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3d0b1deb-ea16-4c51-8a32-cd4b8fceede6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08e9c547-da30-4743-a505-d5acd71a70fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"IntermediatePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d62ed61c-5c27-4f75-bca9-48c8202b99fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08e9c547-da30-4743-a505-d5acd71a70fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"),
				Name = @"PageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,205,75,76,202,73,13,78,45,42,75,45,114,76,46,201,44,75,13,202,47,87,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,204,224,101,21,59,0,0,0 }
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,187,10,194,64,16,236,253,138,141,69,136,205,161,173,26,197,71,72,27,52,216,175,222,34,7,247,144,123,40,129,124,188,167,241,133,104,185,179,179,51,59,179,71,71,108,113,240,226,140,158,150,193,123,163,93,134,143,121,48,233,157,209,2,71,143,91,19,236,129,32,135,10,143,196,214,47,228,155,177,49,23,183,50,65,251,72,125,163,157,195,109,89,89,161,208,54,43,35,131,210,59,148,33,106,230,80,6,193,89,161,78,190,129,182,133,228,233,15,115,24,194,24,70,157,137,35,231,132,209,133,230,196,255,168,67,146,131,14,82,66,154,254,220,179,146,124,221,156,136,127,248,79,99,24,170,133,162,89,214,223,190,44,110,96,127,112,215,163,11,60,41,89,108,228,94,64,77,86,9,29,209,199,69,215,28,43,52,238,229,215,119,239,70,102,49,77,124,44,249,12,50,185,2,157,67,179,189,129,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new UserSessionDetailGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1702f4a3-2a36-42bb-abf5-a29e014d7d7e"));
		}

		#endregion

	}

	#endregion

}

