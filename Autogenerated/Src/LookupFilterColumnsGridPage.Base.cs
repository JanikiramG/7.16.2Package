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

	#region Class: LookupFilterColumnsGridPageSchema

	/// <exclude/>
	public class LookupFilterColumnsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public LookupFilterColumnsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LookupFilterColumnsGridPageSchema(LookupFilterColumnsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.Enabled = true;
			AddButton.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
			RealUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
			Name = "LookupFilterColumnsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "273";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLookupFilterColumnsGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateLookupFilterColumnsGridPageEventsProcessSchema() {
			var schema = new LookupFilterColumnsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690");
			DataSource.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("f20a1475-fe53-4ae4-9574-17d91ec27dff");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
				column.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f0ef986d-aa55-4583-a24e-9331b41526b5");
			if (column != null) {
				column.UId = new Guid("401cda1b-a1a3-43d8-85f5-074e6d8c1b3a");
				column.Name = @"MetaCaption";
				column.CreatedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
				column.ModifiedInSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
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
			return new LookupFilterColumnsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new LookupFilterColumnsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8eae561d-015b-476e-b53a-dbf514241c09"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LookupFilterColumnsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LookupFilterColumnsGridPageEventsProcess

	/// <exclude/>
	public class LookupFilterColumnsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LookupFilterColumnsGridPageSchemaUserControl
	{

		public LookupFilterColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LookupFilterColumnsGridPageEventsProcess";
			SchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8eae561d-015b-476e-b53a-dbf514241c09");
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

		public virtual Object LookupStructureExplorer {
			get;
			set;
		}

		public virtual bool ColumnsExplorerRegistered {
			get;
			set;
		}

		public virtual Guid LookupEntitySchemaUId {
			get;
			set;
		}

		private ProcessFlowElement _subProcessChildPageLoadComplete;
		public ProcessFlowElement SubProcessChildPageLoadComplete {
			get {
				return _subProcessChildPageLoadComplete ?? (_subProcessChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildPageLoadComplete",
					SchemaElementUId = new Guid("2fee9c97-98ac-4dd2-84e4-f47d65bf3217"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildPageLoadComplete;
		public ProcessScriptTask ScriptChildPageLoadComplete {
			get {
				return _scriptChildPageLoadComplete ?? (_scriptChildPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildPageLoadComplete",
					SchemaElementUId = new Guid("1765eb42-af3f-4f3a-a09a-dc74e36c2dfc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageChildPageLoadComplete;
		public ProcessFlowElement StartMessageChildPageLoadComplete {
			get {
				return _startMessageChildPageLoadComplete ?? (_startMessageChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildPageLoadComplete",
					SchemaElementUId = new Guid("d5c8d870-d561-4cf3-a8bc-93499a157ce2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoadComplete {
			get {
				return _intermediateThrowBasePageLoadComplete ?? (_intermediateThrowBasePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoadComplete",
					SchemaElementUId = new Guid("42445843-3213-4d6e-83dc-5401b8d9f2dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessChildApplyFolderFilter;
		public ProcessFlowElement SubProcessChildApplyFolderFilter {
			get {
				return _subProcessChildApplyFolderFilter ?? (_subProcessChildApplyFolderFilter = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildApplyFolderFilter",
					SchemaElementUId = new Guid("19e76f2e-c90a-4411-8f9f-f0d999e88ff2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChild;
		public ProcessFlowElement StartMessageChild {
			get {
				return _startMessageChild ?? (_startMessageChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChild",
					SchemaElementUId = new Guid("75d9db38-1f05-4309-ba46-e56edfe9fdc8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildApplyFolderFilter;
		public ProcessScriptTask ScriptChildApplyFolderFilter {
			get {
				return _scriptChildApplyFolderFilter ?? (_scriptChildApplyFolderFilter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildApplyFolderFilter",
					SchemaElementUId = new Guid("f38f7fe5-1e62-46ec-990a-57bbfdbbb08c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildApplyFolderFilterExecute,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickEventSubProcess;
		public ProcessFlowElement TreeGridDblClickEventSubProcess {
			get {
				return _treeGridDblClickEventSubProcess ?? (_treeGridDblClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "TreeGridDblClickEventSubProcess",
					SchemaElementUId = new Guid("085cb640-eaeb-426c-bbae-36559398b843"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickStartMessage;
		public ProcessFlowElement TreeGridDblClickStartMessage {
			get {
				return _treeGridDblClickStartMessage ?? (_treeGridDblClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClickStartMessage",
					SchemaElementUId = new Guid("579b29e0-4f3f-47dc-abdb-66c875673765"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTreeGridDblClick;
		public ProcessScriptTask ScriptTreeGridDblClick {
			get {
				return _scriptTreeGridDblClick ?? (_scriptTreeGridDblClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTreeGridDblClick",
					SchemaElementUId = new Guid("69b0e583-6098-4595-a15a-f8d2dcfb6f7b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTreeGridDblClickExecute,
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
					SchemaElementUId = new Guid("42cf5329-047d-4d23-b157-d2b4abe3491b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("2dc60478-1ecf-443d-9fbb-361eb1b6bb73"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("e1673774-832d-4ec9-a8d3-74cbf626beb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _addFilterColumns;
		public ProcessFlowElement AddFilterColumns {
			get {
				return _addFilterColumns ?? (_addFilterColumns = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddFilterColumns",
					SchemaElementUId = new Guid("2ead17fb-d8b0-446b-9f98-2d31a2e43194"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClickEnherited;
		public ProcessFlowElement AddButtonClickEnherited {
			get {
				return _addButtonClickEnherited ?? (_addButtonClickEnherited = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClickEnherited",
					SchemaElementUId = new Guid("656bfb4d-f5d5-48da-84a0-aa8b75dafbda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAddButtonClickEnherited;
		public ProcessScriptTask ScriptAddButtonClickEnherited {
			get {
				return _scriptAddButtonClickEnherited ?? (_scriptAddButtonClickEnherited = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAddButtonClickEnherited",
					SchemaElementUId = new Guid("a922f6db-2404-421f-84da-69391ab4e2db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddButtonClickEnheritedExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessChildInit;
		public ProcessFlowElement SubProcessChildInit {
			get {
				return _subProcessChildInit ?? (_subProcessChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildInit",
					SchemaElementUId = new Guid("1b19ced4-df74-47ad-a9c8-c49378cfb817"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInit;
		public ProcessFlowElement ChildInit {
			get {
				return _childInit ?? (_childInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInit",
					SchemaElementUId = new Guid("90f83bfa-7533-4343-9f9b-cbbaf0b15098"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildInit;
		public ProcessScriptTask ScriptChildInit {
			get {
				return _scriptChildInit ?? (_scriptChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildInit",
					SchemaElementUId = new Guid("5f5cabe0-5d09-4506-adff-fd11241e3b55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
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
					SchemaElementUId = new Guid("25130d0b-a7da-43ba-8f38-7594de80a6af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildPageLoadComplete };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
			FlowElements[StartMessageChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildPageLoadComplete };
			FlowElements[IntermediateThrowBasePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoadComplete };
			FlowElements[SubProcessChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildApplyFolderFilter };
			FlowElements[StartMessageChild.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChild };
			FlowElements[ScriptChildApplyFolderFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildApplyFolderFilter };
			FlowElements[TreeGridDblClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickEventSubProcess };
			FlowElements[TreeGridDblClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickStartMessage };
			FlowElements[ScriptTreeGridDblClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTreeGridDblClick };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[AddFilterColumns.SchemaElementUId] = new Collection<ProcessFlowElement> { AddFilterColumns };
			FlowElements[AddButtonClickEnherited.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickEnherited };
			FlowElements[ScriptAddButtonClickEnherited.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddButtonClickEnherited };
			FlowElements[SubProcessChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildInit };
			FlowElements[ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessChildPageLoadComplete":
						break;
					case "ScriptChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoadComplete");
						break;
					case "StartMessageChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "IntermediateThrowBasePageLoadComplete":
						break;
					case "SubProcessChildApplyFolderFilter":
						break;
					case "StartMessageChild":
						e.Context.QueueTasks.Enqueue("ScriptChildApplyFolderFilter");
						break;
					case "ScriptChildApplyFolderFilter":
						break;
					case "TreeGridDblClickEventSubProcess":
						break;
					case "TreeGridDblClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTreeGridDblClick");
						break;
					case "ScriptTreeGridDblClick":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "AddFilterColumns":
						break;
					case "AddButtonClickEnherited":
						e.Context.QueueTasks.Enqueue("ScriptAddButtonClickEnherited");
						break;
					case "ScriptAddButtonClickEnherited":
						break;
					case "SubProcessChildInit":
						break;
					case "ChildInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageChildPageLoadComplete");
			ActivatedEventElements.Add("StartMessageChild");
			ActivatedEventElements.Add("TreeGridDblClickStartMessage");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("AddButtonClickEnherited");
			ActivatedEventElements.Add("ChildInit");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
					break;
				case "StartMessageChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildPageLoadComplete";
					result = StartMessageChildPageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowBasePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowBasePageLoadComplete.Execute(context);
					break;
				case "SubProcessChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChild";
					result = StartMessageChild.Execute(context);
					break;
				case "ScriptChildApplyFolderFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildApplyFolderFilter";
					result = ScriptChildApplyFolderFilter.Execute(context, ScriptChildApplyFolderFilterExecute);
					break;
				case "TreeGridDblClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "TreeGridDblClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickStartMessage";
					result = TreeGridDblClickStartMessage.Execute(context);
					break;
				case "ScriptTreeGridDblClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTreeGridDblClick";
					result = ScriptTreeGridDblClick.Execute(context, ScriptTreeGridDblClickExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteButtonClick");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "AddFilterColumns":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClickEnherited":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickEnherited";
					result = AddButtonClickEnherited.Execute(context);
					break;
				case "ScriptAddButtonClickEnherited":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddButtonClickEnherited";
					result = ScriptAddButtonClickEnherited.Execute(context, ScriptAddButtonClickEnheritedExecute);
					break;
				case "SubProcessChildInit":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInit";
					result = ChildInit.Execute(context);
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
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
				case "LookupEntitySchemaUId":
					LookupEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ColumnsExplorerRegistered":
					ColumnsExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "ColumnsExplorerCreated":
					ColumnsExplorerCreated = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			if (EditPageUId == Guid.Empty || EditPageUId == null) {
				EditPageUId = new Guid("b03bd450-99d5-416e-b6a6-4b0b70545488");
			}
			return true;
		}

		public virtual bool ScriptChildApplyFolderFilterExecute(ProcessExecutingContext context) {
			var listenerPage = ListenerPage as Terrasoft.WebApp.BaseModulePageSchemaUserControl;
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			
			var dataSourceFilter = (Terrasoft.UI.WebControls.Controls.IDataSourceFilterItem) DataSourceFilter;
			if(!object.ReferenceEquals(DataSourceFilter, null)) {
				for(int i = 0; i < currentStructure.Filters.Count; i++) {
					if(currentStructure.Filters[i].Name.Equals(dataSourceFilter.Name)) {
						currentStructure.Filters[i] = dataSourceFilter;
					}
				}
				if(!currentStructure.Filters.Contains(dataSourceFilter)) {
					currentStructure.Filters.Add(dataSourceFilter);
				}
			} else {
				if(currentStructure.Filters.Count > 0) {
					var filters = new List<IDataSourceFilterItem>();
					foreach (var filter in currentStructure.Filters) {
						if(!filter.Name.Equals("SearchFilter")) {	
							filters.Add(filter);
						}
					}
					foreach (var filter in filters) {
						currentStructure.Filters.Remove(filter);
					}
				}
			}
			dataSource.LoadRows();
			
			return true;
		}

		public virtual bool ScriptTreeGridDblClickExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptAddButtonClickEnheritedExecute(ProcessExecutingContext context) {
			if (SelectedNodePrimaryColumnValue != null && SelectedNodePrimaryColumnValue != Guid.Empty ) {
				var lookupSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysLookup");
				var entitySchemaColumn = lookupSchema.Columns.FindByName("SysEntitySchemaUId");
				var selectedLookup = lookupSchema.CreateEntity(UserConnection);
				if (selectedLookup.FetchFromDB(SelectedNodePrimaryColumnValue)) {
					LookupEntitySchemaUId = selectedLookup.GetTypedColumnValue<Guid>(entitySchemaColumn.ColumnValueName);
					ShowColumnExplorer();
				}
			}
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			if (ColumnsExplorerCreated){
				CreateColumnsExplorerControl();
			}
			return true;
		}

		public virtual void RebuildColumnsList(object sender, AjaxEventArgs e) {
			var EntitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var column = Json.Deserialize(e.ExtraParameters["itemsInfo"]) as JObject;
			string metaPath = column.Value<string>("metaPath");
			string caption = column.Value<string>("caption");
			EntitySchema lookupColumnSchema = EntitySchemaManager.GetInstanceByName("SysLookupSearchColumn");
			Entity lookupColumn = lookupColumnSchema.CreateEntity(Page.UserConnection);
			var lookupUId = Page.UserConnection.SessionData["LookupUid"];
			var condition = new Dictionary<string, object>() {
				{"MetaPath", metaPath},
				{"SysLookup", lookupUId}
			};
			if (!lookupColumn.ExistInDB(condition)) {
				lookupColumn.SetDefColumnValues();
				var lookupColumnId = Guid.NewGuid();
				lookupColumn.SetColumnValue("Id", lookupColumnId);
				lookupColumn.SetColumnValue("MetaPath", metaPath);
				lookupColumn.SetColumnValue("MetaCaption", caption);
				lookupColumn.SetColumnValue("SysLookupId", lookupUId);
				lookupColumn.Save();
				Page.DataSource.LoadRow(lookupColumnId);
			}
		}

		public virtual void ShowColumnExplorer() {
			if (!ColumnsExplorerCreated) {
				CreateColumnsExplorerControl();
			}
			var sructureExplorer = (StructureExplorer)LookupStructureExplorer;
			string managerName = "EntitySchemaManager";
			sructureExplorer.ManagerName = managerName;
			sructureExplorer.ShowEditWindow(LookupEntitySchemaUId, null);
		}

		public virtual void CreateColumnsExplorerControl() {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);	
			var structureExplorer = new StructureExplorer(Page.AddButton, "columns", false, false, string.Empty);
			structureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			structureExplorer.IsShowSystemColumns = true;
			LookupStructureExplorer = structureExplorer;
			
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += new AjaxEventHandler(RebuildColumnsList);
			editComplete.ExtraParameters.Add(param);
			
			ColumnsExplorerCreated = true;
			if (!ColumnsExplorerRegistered) {
				structureExplorer.Register();
				ColumnsExplorerRegistered = true;
			}
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterQuestionScript() {
			return string.Empty;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageChildPageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "ApplyFolderFilter":
							if (ActivatedEventElements.Contains("StartMessageChild")) {
							context.QueueTasks.Enqueue("StartMessageChild");
						}
						break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClickStartMessage")) {
							context.QueueTasks.Enqueue("TreeGridDblClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClickEnherited")) {
							context.QueueTasks.Enqueue("AddButtonClickEnherited");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInit")) {
							context.QueueTasks.Enqueue("ChildInit");
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
			if (!HasMapping("LookupEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LookupEntitySchemaUId", LookupEntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("ColumnsExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnsExplorerRegistered", ColumnsExplorerRegistered, false);
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

	#region Class: LookupFilterColumnsGridPageEventsProcess

	/// <exclude/>
	public class LookupFilterColumnsGridPageEventsProcess : LookupFilterColumnsGridPageEventsProcess<Terrasoft.WebApp.LookupFilterColumnsGridPageSchemaUserControl>
	{

		public LookupFilterColumnsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LookupFilterColumnsGridPageSchemaUserControl

	/// <exclude/>
	public partial class LookupFilterColumnsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (LookupFilterColumnsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LookupFilterColumnsGridPageEventsProcess(UserConnection);
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

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
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
			SchemaName = "LookupFilterColumnsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: LookupFilterColumnsGridPageEventsProcessSchema

	/// <exclude/>
	public class LookupFilterColumnsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public LookupFilterColumnsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LookupFilterColumnsGridPageEventsProcessSchema(LookupFilterColumnsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LookupFilterColumnsGridPageEventsProcess";
			UId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec");
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

		protected virtual ProcessSchemaParameter CreateColumnsExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("92e4e2db-4bb6-4f15-b891-f42ceed4ded9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ColumnsExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ff515dbc-8520-442c-b01c-12c398793ade"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"LookupStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnsExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5f0b6b81-d882-4c25-bfa6-dae886644ee7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ColumnsExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("39f90fce-027d-4bc8-a538-345e234b0c40"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"LookupEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateColumnsExplorerCreatedParameter());
			Parameters.Add(CreateLookupStructureExplorerParameter());
			Parameters.Add(CreateColumnsExplorerRegisteredParameter());
			Parameters.Add(CreateLookupEntitySchemaUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet530 = CreateLaneSet530LaneSet();
			LaneSets.Add(schemaLaneSet530);
			ProcessSchemaLane schemaLane1800 = CreateLane1800Lane();
			schemaLaneSet530.Lanes.Add(schemaLane1800);
			ProcessSchemaLane schemaLane1801 = CreateLane1801Lane();
			schemaLaneSet530.Lanes.Add(schemaLane1801);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet530.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess subprocesschildpageloadcomplete = CreateSubProcessChildPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocesschildpageloadcomplete);
			ProcessSchemaEventSubProcess subprocesschildapplyfolderfilter = CreateSubProcessChildApplyFolderFilterEventSubProcess();
			FlowElements.Add(subprocesschildapplyfolderfilter);
			ProcessSchemaEventSubProcess treegriddblclickeventsubprocess = CreateTreeGridDblClickEventSubProcessEventSubProcess();
			FlowElements.Add(treegriddblclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess addfiltercolumns = CreateAddFilterColumnsEventSubProcess();
			FlowElements.Add(addfiltercolumns);
			ProcessSchemaEventSubProcess subprocesschildinit = CreateSubProcessChildInitEventSubProcess();
			FlowElements.Add(subprocesschildinit);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			subprocesschildpageloadcomplete.FlowElements.Add(scriptchildpageloadcomplete);
			ProcessSchemaStartMessageEvent startmessagechildpageloadcomplete = CreateStartMessageChildPageLoadCompleteStartMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(startmessagechildpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageloadcomplete = CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(intermediatethrowbasepageloadcomplete);
			ProcessSchemaStartMessageEvent startmessagechild = CreateStartMessageChildStartMessageEvent();
			subprocesschildapplyfolderfilter.FlowElements.Add(startmessagechild);
			ProcessSchemaScriptTask scriptchildapplyfolderfilter = CreateScriptChildApplyFolderFilterScriptTask();
			subprocesschildapplyfolderfilter.FlowElements.Add(scriptchildapplyfolderfilter);
			ProcessSchemaStartMessageEvent treegriddblclickstartmessage = CreateTreeGridDblClickStartMessageStartMessageEvent();
			treegriddblclickeventsubprocess.FlowElements.Add(treegriddblclickstartmessage);
			ProcessSchemaScriptTask scripttreegriddblclick = CreateScriptTreeGridDblClickScriptTask();
			treegriddblclickeventsubprocess.FlowElements.Add(scripttreegriddblclick);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage3);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent addbuttonclickenherited = CreateAddButtonClickEnheritedStartMessageEvent();
			addfiltercolumns.FlowElements.Add(addbuttonclickenherited);
			ProcessSchemaScriptTask scriptaddbuttonclickenherited = CreateScriptAddButtonClickEnheritedScriptTask();
			addfiltercolumns.FlowElements.Add(scriptaddbuttonclickenherited);
			ProcessSchemaStartMessageEvent childinit = CreateChildInitStartMessageEvent();
			subprocesschildinit.FlowElements.Add(childinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			subprocesschildinit.FlowElements.Add(scriptchildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			subprocesschildinit.FlowElements.Add(intermediatethrowmessageevent1);
			FlowElements.Add(CreateSequenceFlow10919SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10920SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10927SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10928SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10929SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10932SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10933SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10919SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10919",
				UId = new Guid("8434f8b9-9ca7-4175-ac53-6b64bcf225ec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(151, 1688),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("656bfb4d-f5d5-48da-84a0-aa8b75dafbda"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a922f6db-2404-421f-84da-69391ab4e2db"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10920SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10920",
				UId = new Guid("f637fdfc-e12e-4687-a1b4-8dae2f524983"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(418, 1687),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90f83bfa-7533-4343-9f9b-cbbaf0b15098"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5f5cabe0-5d09-4506-adff-fd11241e3b55"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10927SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10927",
				UId = new Guid("39ffdf19-eaae-409c-8c1b-a6b0fc479574"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(166, 1712),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5c8d870-d561-4cf3-a8bc-93499a157ce2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1765eb42-af3f-4f3a-a09a-dc74e36c2dfc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10928SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10928",
				UId = new Guid("b2e0da13-9d73-467f-99c4-98ae01012358"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(274, 1716),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1765eb42-af3f-4f3a-a09a-dc74e36c2dfc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42445843-3213-4d6e-83dc-5401b8d9f2dc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10929SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10929",
				UId = new Guid("bb7812de-b0be-47c2-a3b7-7c7a98df9ef2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(174, 1698),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75d9db38-1f05-4309-ba46-e56edfe9fdc8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f38f7fe5-1e62-46ec-990a-57bbfdbbb08c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10932SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10932",
				UId = new Guid("cf224461-a64d-40cb-a7c6-4b558456316b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(566, 456),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f5cabe0-5d09-4506-adff-fd11241e3b55"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("25130d0b-a7da-43ba-8f38-7594de80a6af"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10933SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10933",
				UId = new Guid("b06f19e8-6226-4a6a-adcb-3699b18ea430"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(430, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("579b29e0-4f3f-47dc-abdb-66c875673765"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69b0e583-6098-4595-a15a-f8d2dcfb6f7b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("cfff0e6a-3f6c-4bad-a6c3-c690302a23e2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CurveCenterPosition = new Point(420, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2dc60478-1ecf-443d-9fbb-361eb1b6bb73"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e1673774-832d-4ec9-a8d3-74cbf626beb4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet530LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet530 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fa068b0b-1a94-44f2-80e0-c5a819eef25c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"LaneSet530",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(922, 548),
				UseBackgroundMode = false
			};
			return schemaLaneSet530;
		}

		protected virtual ProcessSchemaLane CreateLane1800Lane() {
			ProcessSchemaLane schemaLane1800 = new ProcessSchemaLane(this) {
				UId = new Guid("7c58754c-0a6a-43c9-b6a5-e6da54a949d4"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("fa068b0b-1a94-44f2-80e0-c5a819eef25c"),
				CreatedInOwnerSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"Lane1800",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 364),
				Size = new Size(893, 184),
				UseBackgroundMode = false
			};
			return schemaLane1800;
		}

		protected virtual ProcessSchemaLane CreateLane1801Lane() {
			ProcessSchemaLane schemaLane1801 = new ProcessSchemaLane(this) {
				UId = new Guid("215aacc4-0e47-44db-a4f9-23045c574204"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("fa068b0b-1a94-44f2-80e0-c5a819eef25c"),
				CreatedInOwnerSchemaUId = new Guid("8eae561d-015b-476e-b53a-dbf514241c09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"Lane1801",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 182),
				Size = new Size(893, 177),
				UseBackgroundMode = false
			};
			return schemaLane1801;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("39c1868d-40a9-40f4-b5b7-2e44e8005e54"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("fa068b0b-1a94-44f2-80e0-c5a819eef25c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(893, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2fee9c97-98ac-4dd2-84e4-f47d65bf3217"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c58754c-0a6a-43c9-b6a5-e6da54a949d4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"SubProcessChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(281, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildPageLoadComplete;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1765eb42-af3f-4f3a-a09a-dc74e36c2dfc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fee9c97-98ac-4dd2-84e4-f47d65bf3217"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,77,201,44,9,72,76,79,13,245,76,81,176,181,85,112,47,205,76,209,115,205,45,40,169,84,168,169,81,64,147,204,43,205,201,209,84,168,230,226,68,17,87,200,75,45,7,235,211,80,74,50,48,78,74,49,49,53,208,181,180,76,49,213,53,49,52,75,213,77,50,75,52,211,53,73,50,72,50,55,48,53,49,53,177,176,80,210,180,230,170,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,130,154,208,63,135,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d5c8d870-d561-4cf3-a8bc-93499a157ce2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fee9c97-98ac-4dd2-84e4-f47d65bf3217"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"StartMessageChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("42445843-3213-4d6e-83dc-5401b8d9f2dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fee9c97-98ac-4dd2-84e4-f47d65bf3217"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"IntermediateThrowBasePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildApplyFolderFilterEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildApplyFolderFilter = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("19e76f2e-c90a-4411-8f9f-f0d999e88ff2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("215aacc4-0e47-44db-a4f9-23045c574204"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"SubProcessChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildApplyFolderFilter;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("75d9db38-1f05-4309-ba46-e56edfe9fdc8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e76f2e-c90a-4411-8f9f-f0d999e88ff2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ApplyFolderFilter",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"StartMessageChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildApplyFolderFilterScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f38f7fe5-1e62-46ec-990a-57bbfdbbb08c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e76f2e-c90a-4411-8f9f-f0d999e88ff2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ScriptChildApplyFolderFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,209,110,130,48,20,125,134,175,232,124,194,184,52,190,227,150,56,221,18,19,183,44,58,179,135,101,15,181,220,78,150,210,186,182,232,195,226,191,175,23,80,16,135,9,4,104,207,185,247,156,115,233,142,25,34,83,235,64,129,121,101,95,64,238,200,188,249,201,44,121,3,99,152,213,194,209,119,88,143,183,91,250,192,44,60,235,36,151,128,144,37,223,64,198,86,22,204,68,43,103,180,140,195,157,47,154,48,199,150,58,55,28,75,34,142,78,79,43,37,130,231,198,128,114,75,103,114,238,114,131,184,154,68,39,173,221,56,108,149,125,74,165,3,227,73,81,45,112,53,67,141,149,14,75,79,47,179,105,139,54,115,144,245,73,123,53,14,83,17,221,232,245,55,112,71,23,32,192,43,224,240,248,147,51,105,163,54,248,150,168,92,202,126,159,252,134,129,208,38,74,149,35,169,151,51,140,253,99,116,225,142,150,44,20,149,43,231,49,131,65,65,13,124,203,46,236,71,250,73,95,88,6,180,146,208,54,95,108,150,10,130,224,74,145,179,100,143,86,131,224,16,226,133,150,175,136,85,142,165,234,178,117,213,181,147,56,78,146,75,78,140,13,15,4,164,5,100,95,113,94,166,68,238,201,176,236,131,163,23,229,150,55,163,96,95,252,165,163,127,231,122,31,97,35,156,9,48,190,33,81,205,37,169,234,156,75,149,34,166,33,234,112,143,201,247,150,192,12,223,148,216,30,154,15,16,29,136,134,93,113,50,89,68,91,220,29,34,196,89,207,206,16,22,144,233,29,52,11,23,35,59,132,141,115,50,215,44,89,232,189,69,211,161,1,207,87,196,23,130,248,15,82,65,171,21,218,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateTreeGridDblClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaTreeGridDblClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("085cb640-eaeb-426c-bbae-36559398b843"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("215aacc4-0e47-44db-a4f9-23045c574204"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"TreeGridDblClickEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaTreeGridDblClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("579b29e0-4f3f-47dc-abdb-66c875673765"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("085cb640-eaeb-426c-bbae-36559398b843"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"TreeGridDblClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTreeGridDblClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("69b0e583-6098-4595-a15a-f8d2dcfb6f7b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("085cb640-eaeb-426c-bbae-36559398b843"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ScriptTreeGridDblClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("42cf5329-047d-4d23-b157-d2b4abe3491b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39c1868d-40a9-40f4-b5b7-2e44e8005e54"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"EventSubProcess8",
				Position = new Point(302, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2dc60478-1ecf-443d-9fbb-361eb1b6bb73"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42cf5329-047d-4d23-b157-d2b4abe3491b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"StartMessage3",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e1673774-832d-4ec9-a8d3-74cbf626beb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42cf5329-047d-4d23-b157-d2b4abe3491b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddFilterColumnsEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddFilterColumns = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2ead17fb-d8b0-446b-9f98-2d31a2e43194"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39c1868d-40a9-40f4-b5b7-2e44e8005e54"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"AddFilterColumns",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddFilterColumns;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickEnheritedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("656bfb4d-f5d5-48da-84a0-aa8b75dafbda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ead17fb-d8b0-446b-9f98-2d31a2e43194"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"AddButtonClickEnherited",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddButtonClickEnheritedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a922f6db-2404-421f-84da-69391ab4e2db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ead17fb-d8b0-446b-9f98-2d31a2e43194"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ScriptAddButtonClickEnherited",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,207,78,2,49,16,135,207,75,194,59,84,14,164,123,233,11,32,30,192,93,66,162,196,100,197,123,179,29,220,198,254,217,204,182,106,99,124,119,203,150,196,2,7,146,158,58,51,223,252,230,147,7,66,27,80,208,58,16,59,43,224,5,165,230,24,214,86,121,109,222,184,242,64,238,150,196,120,165,200,124,78,110,119,110,188,20,172,210,189,11,164,36,63,211,73,241,201,145,40,107,63,124,223,180,29,104,78,150,100,63,0,174,173,49,17,37,173,97,149,113,210,133,84,125,230,134,191,3,178,13,184,173,25,28,55,45,172,194,142,107,160,179,38,12,79,35,103,86,46,78,92,200,38,83,142,72,207,151,177,244,59,176,90,26,145,129,242,149,251,173,248,39,14,167,3,211,166,43,26,2,119,144,134,233,249,21,35,65,70,153,231,4,86,131,107,187,26,173,126,92,221,240,92,38,95,69,26,188,72,24,147,92,128,163,161,215,208,131,200,8,247,71,249,15,244,218,10,203,154,142,14,198,176,69,211,217,175,84,168,190,123,101,17,144,142,133,223,233,36,62,4,231,209,16,135,30,22,127,195,99,39,78,37,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1b19ced4-df74-47ad-a9c8-c49378cfb817"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c58754c-0a6a-43c9-b6a5-e6da54a949d4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"SubProcessChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(358, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("90f83bfa-7533-4343-9f9b-cbbaf0b15098"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b19ced4-df74-47ad-a9c8-c49378cfb817"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5f5cabe0-5d09-4506-adff-fd11241e3b55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b19ced4-df74-47ad-a9c8-c49378cfb817"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,206,207,41,205,205,43,118,173,40,200,201,47,74,45,114,46,74,77,44,73,77,209,172,230,226,132,48,209,229,243,243,74,138,242,115,52,52,173,185,106,185,138,82,75,74,139,242,20,74,138,74,83,173,1,54,154,2,238,76,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("25130d0b-a7da-43ba-8f38-7594de80a6af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b19ced4-df74-47ad-a9c8-c49378cfb817"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 61),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateRebuildColumnsListMethod());
			Methods.Add(CreateShowColumnExplorerMethod());
			Methods.Add(CreateCreateColumnsExplorerControlMethod());
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

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterQuestionScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterQuestionScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterCopyPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRebuildColumnsListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f42b7800-dc94-4671-8f1b-234f48dcab57"),
				Name = "RebuildColumnsList",
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a6d92da8-e193-46cb-b471-7e21ebe19229"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8e2aa9c0-9d73-44a2-8b01-85aa44d73201"),
				Name = "e",
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				ModifiedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,79,194,64,16,61,75,194,127,88,247,180,77,72,255,128,31,7,41,33,24,69,99,131,23,227,97,108,7,89,133,93,178,187,5,209,240,223,157,238,150,90,164,6,79,155,118,230,189,55,239,205,172,192,176,129,114,210,109,210,108,134,11,184,5,5,175,104,216,5,155,88,52,125,173,20,102,78,106,21,15,209,237,117,8,222,2,227,17,3,219,198,119,214,237,172,72,41,211,243,98,161,136,252,218,18,101,130,36,33,97,46,63,81,96,60,248,112,6,238,193,192,2,29,26,251,196,165,195,133,29,169,169,230,207,158,246,250,238,229,141,134,33,42,235,140,84,175,140,26,9,224,102,196,23,136,227,71,152,23,120,30,202,151,130,239,26,120,244,3,202,96,89,250,249,19,83,213,61,164,105,132,205,181,126,47,150,125,15,170,126,93,180,89,45,147,26,41,235,64,101,120,181,25,147,29,193,211,141,189,241,240,20,193,100,179,64,210,144,216,35,39,218,67,173,184,111,16,28,134,118,113,79,66,241,254,130,162,42,226,0,157,140,114,162,105,105,139,83,180,150,222,4,28,60,241,48,212,68,230,252,185,222,144,202,101,21,144,194,53,75,164,135,129,217,84,17,245,152,246,107,184,20,17,251,234,118,78,190,248,237,46,229,94,189,145,109,207,87,106,219,84,170,231,218,118,59,91,18,147,83,38,78,155,62,233,0,164,165,228,146,43,81,15,17,5,141,189,182,20,93,130,211,240,225,119,103,69,233,253,228,199,124,168,249,4,134,133,204,227,49,174,203,55,180,253,230,106,16,9,62,202,235,73,119,36,199,65,45,254,255,7,234,87,167,214,219,29,229,113,88,157,104,99,210,73,235,144,176,194,96,216,31,65,185,238,84,23,38,195,248,70,67,254,160,215,226,208,230,246,27,6,224,127,248,13,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a538d51c-4b67-45ed-8c1f-0fa304953df9"),
				Name = "ShowColumnExplorer",
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,193,10,194,48,16,68,207,230,43,98,79,9,136,63,80,60,149,30,4,235,165,136,231,208,196,54,152,100,203,102,99,21,241,223,45,20,161,86,111,195,204,155,217,181,23,46,214,5,184,228,67,44,239,189,3,52,88,160,81,100,180,228,79,182,154,244,18,128,64,8,78,200,156,189,216,77,33,143,152,26,74,104,62,0,223,113,81,211,194,148,7,128,107,234,127,252,156,69,66,27,90,238,85,80,173,193,163,242,102,28,200,202,64,150,30,117,211,25,175,170,41,202,70,118,209,222,86,95,173,217,198,31,182,238,96,40,181,165,179,13,26,6,49,61,52,191,115,218,235,13,15,201,57,153,191,1,24,105,14,250,26,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnsExplorerControlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8c4bb033-a2bb-435f-a701-6c8e37e2ba18"),
				Name = "CreateColumnsExplorerControl",
				CreatedInSchemaUId = new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,221,78,194,48,20,190,166,79,81,119,181,69,211,23,88,188,192,57,227,18,76,8,160,94,24,47,10,61,195,106,215,46,253,129,45,132,119,183,99,208,32,195,171,158,182,223,223,57,237,134,106,92,83,77,43,124,143,37,108,241,2,180,166,70,149,150,188,22,228,29,150,153,146,86,43,97,72,40,166,29,26,44,232,56,226,22,42,83,200,82,69,119,248,207,38,96,94,20,3,50,163,219,36,29,161,141,183,50,86,187,149,117,26,242,166,22,74,131,62,218,206,47,207,227,41,93,3,25,51,246,224,172,85,210,235,175,148,112,149,52,94,189,164,194,64,88,188,36,151,107,146,87,181,109,147,20,13,28,72,222,172,132,99,240,72,45,125,163,194,193,162,173,193,28,125,123,242,199,39,222,225,232,129,75,170,219,174,149,39,46,160,91,139,202,135,232,138,76,121,169,8,239,175,201,23,102,254,165,182,243,214,248,254,179,62,163,23,247,48,72,209,68,169,31,87,15,154,243,247,3,157,20,161,76,85,181,146,32,237,248,155,54,249,198,23,24,24,183,221,177,240,195,188,198,34,1,106,72,126,134,77,209,57,147,244,98,183,125,207,129,242,76,37,19,126,212,51,88,58,46,216,49,252,132,27,155,92,242,27,171,105,120,84,211,189,75,124,248,53,201,33,246,129,119,138,148,105,160,22,88,152,1,47,113,124,115,129,153,193,218,187,128,6,150,224,29,26,13,219,58,1,98,111,48,250,151,28,60,246,191,177,49,72,81,199,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LookupFilterColumnsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e818a2a-d867-48b1-aee3-183f16dc99ec"));
		}

		#endregion

	}

	#endregion

}

