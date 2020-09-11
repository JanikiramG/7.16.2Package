namespace Terrasoft.WebApp
{

	using DB = Terrasoft.Core.DB;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
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

	#region Class: BaseFoldersEntryGridPageSchema

	/// <exclude/>
	public class BaseFoldersEntryGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _showDinamicFolderButton;
		public Terrasoft.UI.WebControls.Controls.Button ShowDinamicFolderButton {
			get {
				return _showDinamicFolderButton;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseFoldersEntryGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseFoldersEntryGridPageSchema(BaseFoldersEntryGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @""
			};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @""
			};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.EnableDragDrop = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
			RealUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
			Name = "BaseFoldersEntryGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseFoldersEntryGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.InsertItem(4, CreateShowDinamicFolderButton());
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			ButtonsControlLayout.MoveItem(8, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseFoldersEntryGridPageEventsProcessSchema() {
			var schema = new BaseFoldersEntryGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateShowDinamicFolderButton() {
			_showDinamicFolderButton = new Terrasoft.UI.WebControls.Controls.Button();
			_showDinamicFolderButton.UId = new Guid("6bad1b5d-0425-48e9-b54a-088a6a091575");
			_showDinamicFolderButton.Name = "ShowDinamicFolderButton";
			_showDinamicFolderButton.CreatedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
			_showDinamicFolderButton.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
			_showDinamicFolderButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showDinamicFolderButton.Tag = "";
			_showDinamicFolderButton.Image = new ControlImage {};
			_showDinamicFolderButton.Hidden = true;
			return _showDinamicFolderButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			DataSource.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e1d6f0da-a442-45cf-9235-0c635c86c2f2");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
				column.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e46bb69-9788-423c-b7cd-4c624081082d");
			if (column != null) {
				column.UId = new Guid("380c7139-ef81-4320-acf6-21ee0e7f8051");
				column.Name = @"Folder";
				column.CreatedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
				column.ModifiedInSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseFoldersEntryGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseFoldersEntryGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseFoldersEntryGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseFoldersEntryGridPageEventsProcess

	/// <exclude/>
	public class BaseFoldersEntryGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseFoldersEntryGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, BaseFoldersEntryGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("2cb1f9f5-5f6a-47ac-bc38-5b0f1a16f01c");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public BaseFoldersEntryGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseFoldersEntryGridPageEventsProcess";
			SchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3");
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

		private ProcessFlowElement _eventSubProcessChildInit;
		public ProcessFlowElement EventSubProcessChildInit {
			get {
				return _eventSubProcessChildInit ?? (_eventSubProcessChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildInit",
					SchemaElementUId = new Guid("07238616-babd-444b-92e0-c7a0687c1d39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildInit;
		public ProcessFlowElement StartMessageChildInit {
			get {
				return _startMessageChildInit ?? (_startMessageChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildInit",
					SchemaElementUId = new Guid("2b61a94b-ca4e-4bc8-b179-7e8a34fa8b2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskChildInit;
		public ProcessScriptTask ScriptTaskChildInit {
			get {
				return _scriptTaskChildInit ?? (_scriptTaskChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskChildInit",
					SchemaElementUId = new Guid("bfb5d406-98af-4d9c-82fa-a50401ed3f6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskChildInitExecute,
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
					SchemaElementUId = new Guid("2de7af8e-c722-4402-9ddc-7ac38b6e7120"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickChildEventSubProcess;
		public ProcessFlowElement TreeGridDblClickChildEventSubProcess {
			get {
				return _treeGridDblClickChildEventSubProcess ?? (_treeGridDblClickChildEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "TreeGridDblClickChildEventSubProcess",
					SchemaElementUId = new Guid("5056dc7d-43ac-4d6c-a140-972c0900a1b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickChild;
		public ProcessFlowElement TreeGridDblClickChild {
			get {
				return _treeGridDblClickChild ?? (_treeGridDblClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClickChild",
					SchemaElementUId = new Guid("78753b8b-e812-4512-8cbe-951bf3102951"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _subProcess9;
		public ProcessFlowElement SubProcess9 {
			get {
				return _subProcess9 ?? (_subProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9",
					SchemaElementUId = new Guid("ffe25801-b7ca-4d9e-bf2c-cd64b032507e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteYesMessageChild;
		public ProcessFlowElement DeleteYesMessageChild {
			get {
				return _deleteYesMessageChild ?? (_deleteYesMessageChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteYesMessageChild",
					SchemaElementUId = new Guid("014048d1-3742-454a-a9f4-d2858383ae03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDeleteYesMessageChild;
		public ProcessScriptTask ScriptDeleteYesMessageChild {
			get {
				return _scriptDeleteYesMessageChild ?? (_scriptDeleteYesMessageChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDeleteYesMessageChild",
					SchemaElementUId = new Guid("5ae147d2-1491-42a3-a36a-c9e6202dc604"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteYesMessageChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessFolderMenuItemClick;
		public ProcessFlowElement SubProcessFolderMenuItemClick {
			get {
				return _subProcessFolderMenuItemClick ?? (_subProcessFolderMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessFolderMenuItemClick",
					SchemaElementUId = new Guid("b24efe1e-8e57-4dd3-a748-305e1cc1ce95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _folderMenuItemClick;
		public ProcessFlowElement FolderMenuItemClick {
			get {
				return _folderMenuItemClick ?? (_folderMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FolderMenuItemClick",
					SchemaElementUId = new Guid("2b28a3f5-985f-410f-8f90-fab38099e6ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptFolderMenuItemClick;
		public ProcessScriptTask ScriptFolderMenuItemClick {
			get {
				return _scriptFolderMenuItemClick ?? (_scriptFolderMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptFolderMenuItemClick",
					SchemaElementUId = new Guid("79c63366-cfc6-4e28-8914-18bc41de99b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptFolderMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessSelectFolderChild;
		public ProcessFlowElement SubProcessSelectFolderChild {
			get {
				return _subProcessSelectFolderChild ?? (_subProcessSelectFolderChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessSelectFolderChild",
					SchemaElementUId = new Guid("95a74a4c-ea29-4c3a-8432-5a912292baf7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _selectFolderChild;
		public ProcessFlowElement SelectFolderChild {
			get {
				return _selectFolderChild ?? (_selectFolderChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SelectFolderChild",
					SchemaElementUId = new Guid("d1853d86-6fc3-4658-9ac7-79ff9b2d4786"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSelectFolderChild;
		public ProcessScriptTask ScriptSelectFolderChild {
			get {
				return _scriptSelectFolderChild ?? (_scriptSelectFolderChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSelectFolderChild",
					SchemaElementUId = new Guid("7e1f1ea6-3c70-496e-8399-2a52f7e3d15c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSelectFolderChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessPageLoadCompleteChild;
		public ProcessFlowElement SubProcessPageLoadCompleteChild {
			get {
				return _subProcessPageLoadCompleteChild ?? (_subProcessPageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPageLoadCompleteChild",
					SchemaElementUId = new Guid("11018b60-fd33-4b9d-8d80-b335f2dee19b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChild;
		public ProcessFlowElement PageLoadCompleteChild {
			get {
				return _pageLoadCompleteChild ?? (_pageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChild",
					SchemaElementUId = new Guid("f6894e83-f19f-4867-8ab4-589d2cbead12"),
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
					SchemaElementUId = new Guid("1cad67f4-b179-4e8d-8805-79daa7434a6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadCompleteChild;
		public ProcessScriptTask ScriptPageLoadCompleteChild {
			get {
				return _scriptPageLoadCompleteChild ?? (_scriptPageLoadCompleteChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadCompleteChild",
					SchemaElementUId = new Guid("cf266cb7-d345-4ad9-8f11-1e53f8fe8412"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess2Child;
		public ProcessFlowElement SubProcess2Child {
			get {
				return _subProcess2Child ?? (_subProcess2Child = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2Child",
					SchemaElementUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _folderEntryAddButtonClick;
		public ProcessFlowElement FolderEntryAddButtonClick {
			get {
				return _folderEntryAddButtonClick ?? (_folderEntryAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FolderEntryAddButtonClick",
					SchemaElementUId = new Guid("d26ceb73-c028-42d4-8818-d0a30391ad57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initOpenLookupUserTaskScript;
		public ProcessScriptTask InitOpenLookupUserTaskScript {
			get {
				return _initOpenLookupUserTaskScript ?? (_initOpenLookupUserTaskScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitOpenLookupUserTaskScript",
					SchemaElementUId = new Guid("ba85b080-0b01-4137-a9fd-6bf2b8e0b31a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitOpenLookupUserTaskScriptExecute,
				});
			}
		}

		private ProcessScriptTask _applyDataScript;
		public ProcessScriptTask ApplyDataScript {
			get {
				return _applyDataScript ?? (_applyDataScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ApplyDataScript",
					SchemaElementUId = new Guid("52ff6b0e-74fc-4f85-87c3-8ed39d7c6d5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ApplyDataScriptExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayCheckDetailMode;
		public ProcessExclusiveGateway ExclusiveGatewayCheckDetailMode {
			get {
				return _exclusiveGatewayCheckDetailMode ?? (_exclusiveGatewayCheckDetailMode = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayCheckDetailMode",
					SchemaElementUId = new Guid("7a559878-9efc-4da8-bed7-dd4ac3933c42"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGatewayCheckDetailMode.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessFlowElement _startMessageFolderAllowAddDetailMessage;
		public ProcessFlowElement StartMessageFolderAllowAddDetailMessage {
			get {
				return _startMessageFolderAllowAddDetailMessage ?? (_startMessageFolderAllowAddDetailMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageFolderAllowAddDetailMessage",
					SchemaElementUId = new Guid("d7b5c8bf-8310-403d-a296-f58761f13cb2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageLookupGridPageClosed;
		public ProcessFlowElement StartMessageLookupGridPageClosed {
			get {
				return _startMessageLookupGridPageClosed ?? (_startMessageLookupGridPageClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageLookupGridPageClosed",
					SchemaElementUId = new Guid("afd00fec-9e87-49c0-bcae-7ea8c4395c0b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskThrowAllowChildDetailMessage;
		public ProcessScriptTask ScriptTaskThrowAllowChildDetailMessage {
			get {
				return _scriptTaskThrowAllowChildDetailMessage ?? (_scriptTaskThrowAllowChildDetailMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskThrowAllowChildDetailMessage",
					SchemaElementUId = new Guid("ecd2e226-0193-4c2c-951b-68d98266f3c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskThrowAllowChildDetailMessageExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _sequenceFlow13404;
		public ProcessConditionalFlow SequenceFlow13404 {
			get {
				return _sequenceFlow13404 ?? (_sequenceFlow13404 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow13404",
					SchemaElementUId = new Guid("10d5aaca-e829-4499-92e8-48d7c0c27478"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildInit };
			FlowElements[StartMessageChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildInit };
			FlowElements[ScriptTaskChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskChildInit };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[TreeGridDblClickChildEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickChildEventSubProcess };
			FlowElements[TreeGridDblClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickChild };
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[DeleteYesMessageChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesMessageChild };
			FlowElements[ScriptDeleteYesMessageChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteYesMessageChild };
			FlowElements[SubProcessFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessFolderMenuItemClick };
			FlowElements[FolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { FolderMenuItemClick };
			FlowElements[ScriptFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptFolderMenuItemClick };
			FlowElements[SubProcessSelectFolderChild.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSelectFolderChild };
			FlowElements[SelectFolderChild.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectFolderChild };
			FlowElements[ScriptSelectFolderChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSelectFolderChild };
			FlowElements[SubProcessPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPageLoadCompleteChild };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[SubProcess2Child.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2Child };
			FlowElements[FolderEntryAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { FolderEntryAddButtonClick };
			FlowElements[InitOpenLookupUserTaskScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitOpenLookupUserTaskScript };
			FlowElements[ApplyDataScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyDataScript };
			FlowElements[ExclusiveGatewayCheckDetailMode.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayCheckDetailMode };
			FlowElements[StartMessageFolderAllowAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageFolderAllowAddDetailMessage };
			FlowElements[StartMessageLookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageLookupGridPageClosed };
			FlowElements[ScriptTaskThrowAllowChildDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskThrowAllowChildDetailMessage };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessChildInit":
						break;
					case "StartMessageChildInit":
						e.Context.QueueTasks.Enqueue("ScriptTaskChildInit");
						break;
					case "ScriptTaskChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "TreeGridDblClickChildEventSubProcess":
						break;
					case "TreeGridDblClickChild":
						break;
					case "SubProcess9":
						break;
					case "DeleteYesMessageChild":
						e.Context.QueueTasks.Enqueue("ScriptDeleteYesMessageChild");
						break;
					case "ScriptDeleteYesMessageChild":
						break;
					case "SubProcessFolderMenuItemClick":
						break;
					case "FolderMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptFolderMenuItemClick");
						break;
					case "ScriptFolderMenuItemClick":
						break;
					case "SubProcessSelectFolderChild":
						break;
					case "SelectFolderChild":
						e.Context.QueueTasks.Enqueue("ScriptSelectFolderChild");
						break;
					case "ScriptSelectFolderChild":
						break;
					case "SubProcessPageLoadCompleteChild":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						break;
					case "SubProcess2Child":
						break;
					case "FolderEntryAddButtonClick":
						e.Context.QueueTasks.Enqueue("ExclusiveGatewayCheckDetailMode");
						break;
					case "InitOpenLookupUserTaskScript":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "ApplyDataScript":
						break;
					case "ExclusiveGatewayCheckDetailMode":
						if (SequenceFlow13404ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTaskThrowAllowChildDetailMessage");
							break;
						}
						e.Context.QueueTasks.Enqueue("InitOpenLookupUserTaskScript");
						break;
					case "StartMessageFolderAllowAddDetailMessage":
						e.Context.QueueTasks.Enqueue("InitOpenLookupUserTaskScript");
						break;
					case "StartMessageLookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("ApplyDataScript");
						break;
					case "ScriptTaskThrowAllowChildDetailMessage":
						break;
					case "OpenLookupUserTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow13404ExpressionExecute() {
			return Convert.ToBoolean(NeedAddDetailRequest);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageChildInit");
			ActivatedEventElements.Add("TreeGridDblClickChild");
			ActivatedEventElements.Add("DeleteYesMessageChild");
			ActivatedEventElements.Add("FolderMenuItemClick");
			ActivatedEventElements.Add("SelectFolderChild");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("FolderEntryAddButtonClick");
			ActivatedEventElements.Add("StartMessageFolderAllowAddDetailMessage");
			ActivatedEventElements.Add("StartMessageLookupGridPageClosed");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessChildInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildInit";
					result = StartMessageChildInit.Execute(context);
					break;
				case "ScriptTaskChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskChildInit";
					result = ScriptTaskChildInit.Execute(context, ScriptTaskChildInitExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "TreeGridDblClickChildEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "TreeGridDblClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickChild";
					result = TreeGridDblClickChild.Execute(context);
					break;
				case "SubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteYesMessageChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesMessageChild";
					result = DeleteYesMessageChild.Execute(context);
					break;
				case "ScriptDeleteYesMessageChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteYesMessageChild";
					result = ScriptDeleteYesMessageChild.Execute(context, ScriptDeleteYesMessageChildExecute);
					break;
				case "SubProcessFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "FolderMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "FolderMenuItemClick";
					result = FolderMenuItemClick.Execute(context);
					break;
				case "ScriptFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptFolderMenuItemClick";
					result = ScriptFolderMenuItemClick.Execute(context, ScriptFolderMenuItemClickExecute);
					break;
				case "SubProcessSelectFolderChild":
					context.QueueTasks.Dequeue();
					break;
				case "SelectFolderChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectFolderChild";
					result = SelectFolderChild.Execute(context);
					break;
				case "ScriptSelectFolderChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSelectFolderChild";
					result = ScriptSelectFolderChild.Execute(context, ScriptSelectFolderChildExecute);
					break;
				case "SubProcessPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
					break;
				case "SubProcess2Child":
					context.QueueTasks.Dequeue();
					break;
				case "FolderEntryAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "FolderEntryAddButtonClick";
					result = FolderEntryAddButtonClick.Execute(context);
					break;
				case "InitOpenLookupUserTaskScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitOpenLookupUserTaskScript";
					result = InitOpenLookupUserTaskScript.Execute(context, InitOpenLookupUserTaskScriptExecute);
					break;
				case "ApplyDataScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyDataScript";
					result = ApplyDataScript.Execute(context, ApplyDataScriptExecute);
					break;
				case "ExclusiveGatewayCheckDetailMode":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGatewayCheckDetailMode";
					result = ExclusiveGatewayCheckDetailMode.Execute(context);
					break;
				case "StartMessageFolderAllowAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageFolderAllowAddDetailMessage";
					result = StartMessageFolderAllowAddDetailMessage.Execute(context);
					break;
				case "StartMessageLookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageLookupGridPageClosed";
					result = StartMessageLookupGridPageClosed.Execute(context);
					break;
				case "ScriptTaskThrowAllowChildDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskThrowAllowChildDetailMessage";
					result = ScriptTaskThrowAllowChildDetailMessage.Execute(context, ScriptTaskThrowAllowChildDetailMessageExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
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

		public virtual bool ScriptTaskChildInitExecute(ProcessExecutingContext context) {
			SynchronizeDataSourceStructure = true;
			return true;
		}

		public virtual bool ScriptDeleteYesMessageChildExecute(ProcessExecutingContext context) {
			var detailSelectedNodes = Page.TreeGrid.SelectedNodes;
			if (Page.TreeGrid.SelectedNodes.Count < 1) {
				return true;
			}
			var folderId = detailSelectedNodes[0].Values["FolderId"];
			var entityInFolderId = new Guid(detailSelectedNodes[0].Values["Id"].ToString());
			
			var ids = new Collection<QueryParameter>();
			/*var modulePage = Page.PageContainer.Parent.NamingContainer as PageContainer;
			var grid = (modulePage.FindPageControlByName("Grid") as PageContainer);
			if (grid != null) {
				var moduleDataSource = modulePage.FindPageControlByName("DataSource") as EntityDataSource;
				string primaryColumnName = moduleDataSource.Schema.PrimaryColumn.Name;
				string primaryDisplayColumnName = moduleDataSource.Schema.PrimaryDisplayColumn.Name;
				var moduleTreeGrid = grid.FindPageControlByName("TreeGrid") as TreeGrid;
				foreach(var row in moduleTreeGrid.SelectedNodes) {
					ids.Add(new QueryParameter(row.Values[primaryColumnName]));
				}
			} else {
				Page.DataSource.Remove(entityInFolderId);
				return true;
			}*/
			ids.Add(new QueryParameter(SelectedNodePrimaryColumnValue));  //this line is instead of commented
			var defValuesId = SetDefValues();
			var defValues = Page.UserConnection.SessionData[defValuesId.ToString()] as Dictionary<string, object>;
			var defValueColumnName = String.Empty;
			foreach (var value in defValues) {
				defValueColumnName = value.Key.ToString();
				break;
			}		
			var refEntityColumnValueName = Page.DataSource.Schema.Columns.GetByName(defValueColumnName).ColumnValueName;
			var delete =
			new DB.Delete(Page.UserConnection)
				.From(Page.DataSource.Schema.Name)
				.Where("FolderId")
					.IsEqual(new QueryParameter("folderId", folderId))
				.And(refEntityColumnValueName)
					.In(ids)
				as Delete;
			delete.Execute();
			
			var entityId = detailSelectedNodes[0].Values[refEntityColumnValueName];
			new Update(UserConnection, defValueColumnName)
				.Set("ModifiedOn", Column.Parameter(UserConnection.CurrentUser.GetCurrentDateTime()))
				.Where("Id").IsEqual(Column.Parameter(entityId)).Execute();
			
			Page.DataSource.LoadRow(entityInFolderId);
			return true;
		}

		public virtual bool ScriptFolderMenuItemClickExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count < 1) {
				return true;
			}
			Guid folderId = new Guid(selectedNodes[0].Values["FolderId"].ToString());
			var modulePage = (Page.PageContainer.Parent.NamingContainer as PageContainer).PageInstance as PageSchemaUserControl;
			if (modulePage != null) {
				modulePage.Process.SetPropertyValue("GotoFolderId", folderId);
				modulePage.ThrowEvent("SelectFolder");
			}
			if (LocatedInEditPage) {
				Page.ThrowClientEvent("SelectFolder", folderId);
				Page.AddScript("window.opener.focus();");
			}
			return true;
		}

		public virtual bool ScriptSelectFolderChildExecute(ProcessExecutingContext context) {
			if (!IsDetailGrid) {
				if (string.IsNullOrEmpty(ListenerPageProcessUId)) {
					return true;
				}
				var process = UserConnection.IProcessEngine.FindProcessByUId(ListenerPageProcessUId);
				if (process != null) {
					process.ThrowEvent(context, "SelectFolder");
				}
			}
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool InitOpenLookupUserTaskScriptExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			string schemaUId = Page.DataSource.Schema.Columns.GetByName("Folder").ReferenceSchema.UId.ToString();
			OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("useHierarchy", false);
			pageParameters.Add("hideButtons", true);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			filters.Add(new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "FolderType.Id"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", new object[]	{"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"}}}
			);
			filters.Add(new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.IsNotNull},
				{"leftExpressionColumnPath", "Parent"},
				{"useDisplayValue", false}}
			);
			pageParameters.Add("LookupFilters", filters);
			return true;
		}

		public virtual bool ApplyDataScriptExecute(ProcessExecutingContext context) {
			var folderIds = (Dictionary <string, object>)OpenLookupUserTask.GetSelectedValues(UserConnection); 
			if (folderIds.Count == 0) {
				return true;
			}
			var ids = new Collection<Guid>();
			ids.Add(SelectedNodePrimaryColumnValue);
			var dataSource = Page.DataSource;
			Guid defValuesId = SetDefValues();
			var defValues = Page.UserConnection.SessionData[defValuesId.ToString()] as Dictionary<string, object>;
			string defValueColumnName = String.Empty;
			foreach (var value in defValues) {
				defValueColumnName = value.Key.ToString();
				break;
			}		
			var schemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var entityInFolderSchemaName = Page.DataSource.Schema.Name;
			var entityParameterId = new QueryParameter("entityRef", Guid.Empty);
			var folderParameterId = new QueryParameter("FolderId", Guid.Empty);
			var refEntityColumnValueName = Page.DataSource.Schema.Columns.GetByName(defValueColumnName).ColumnValueName;
			Select existingFoldersSelect = new Select(Page.UserConnection).Column(Func.Count("Id")).As("RecordsCount").From(entityInFolderSchemaName).
				Where(refEntityColumnValueName).IsEqual(entityParameterId).
				And("FolderId").IsEqual(folderParameterId) as Select;
			Entity newRow;
			foreach (Guid id in ids) {
				entityParameterId.Value = id;
				foreach (var folderId in folderIds) {
					folderParameterId.Value = folderId.Key;
					using (var dbExecutor = UserConnection.EnsureDBConnection()) {
						using (IDataReader dataReader = existingFoldersSelect.ExecuteReader(dbExecutor)) {
							dataReader.Read();
							if(Page.UserConnection.DBTypeConverter.DBValueToInt(dataReader["RecordsCount"]) > 0) {
								continue;
							}
						}
					}
			 		newRow = dataSource.CreateRow();
					newRow.SetDefColumnValues();
					newRow.SetColumnValue("FolderId", (folderId.Key));
					newRow.SetColumnValue(refEntityColumnValueName, id);
					newRow.Save();
				}
			}
			Page.TreeGrid.RefreshData();
			return true;
		}

		public virtual bool ScriptTaskThrowAllowChildDetailMessageExecute(ProcessExecutingContext context) {
			ListenerThrowEvent(ListenerPageProcessUId, "RequestAddDetailMessage");
			return true;
		}

		public override void CallRefreshDetails(Terrasoft.UI.WebControls.PageSchemaUserControl listenerPage) {
			if (!IsDetailGrid) {
				ListenerThrowEvent(ListenerPageProcessUId, "GridActiveRowChanged");
			}
			/*
			var detailsTabPanel = listenerPage.PageContainer.FindPageControlByName("DetailsTabPanel") as TabPanel;
			if(detailsTabPanel == null || detailsTabPanel.Tabs.Count == 0) {
				return;
			}
			var activeTab = detailsTabPanel.Tabs[detailsTabPanel.ActiveTabIndex];
			var detailPageContainer = activeTab.Items[0] as PageContainer;
			detailPageContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", Guid.Empty);
			listenerPage.Process.SetPropertyValue("FilterColumnValue", Guid.Empty);
			listenerPage.ThrowEvent("RefreshDetails");
			*/
		}

		public override void SetAdditionalDataSourceProperties() {
			string columnName;
			var currentStructure = Page.DataSource.CurrentStructure;
			foreach(var column in currentStructure.Columns) {
				columnName = column.Name;
				column.IsVisible = (columnName == "Folder" || columnName == "Description");
			}
			return;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageChildInit")) {
							context.QueueTasks.Enqueue("StartMessageChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClickChild")) {
							context.QueueTasks.Enqueue("TreeGridDblClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesMessageChild")) {
							context.QueueTasks.Enqueue("DeleteYesMessageChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "FolderMenuItemClick":
							if (ActivatedEventElements.Contains("FolderMenuItemClick")) {
							context.QueueTasks.Enqueue("FolderMenuItemClick");
						}
						break;
					case "SelectFolder":
							if (ActivatedEventElements.Contains("SelectFolderChild")) {
							context.QueueTasks.Enqueue("SelectFolderChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("FolderEntryAddButtonClick")) {
							context.QueueTasks.Enqueue("FolderEntryAddButtonClick");
							ProcessQueue(context);
							return;
						}
						break;
					case "AllowAddDetailMessage":
							if (ActivatedEventElements.Contains("StartMessageFolderAllowAddDetailMessage")) {
							context.QueueTasks.Enqueue("StartMessageFolderAllowAddDetailMessage");
						}
						break;
					case "LookupGridPageClosed":
							if (ActivatedEventElements.Contains("StartMessageLookupGridPageClosed")) {
							context.QueueTasks.Enqueue("StartMessageLookupGridPageClosed");
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

	#region Class: BaseFoldersEntryGridPageEventsProcess

	/// <exclude/>
	public class BaseFoldersEntryGridPageEventsProcess : BaseFoldersEntryGridPageEventsProcess<Terrasoft.WebApp.BaseFoldersEntryGridPageSchemaUserControl>
	{

		public BaseFoldersEntryGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseFoldersEntryGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseFoldersEntryGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button ShowDinamicFolderButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ShowDinamicFolderButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseFoldersEntryGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseFoldersEntryGridPageEventsProcess(UserConnection);
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
			SchemaName = "BaseFoldersEntryGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseFoldersEntryGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseFoldersEntryGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseFoldersEntryGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseFoldersEntryGridPageEventsProcessSchema(BaseFoldersEntryGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseFoldersEntryGridPageEventsProcess";
			UId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c");
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

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b094f3a4-e987-4dac-9996-ad69cde89c94"),
				ContainerUId = new Guid("2cb1f9f5-5f6a-47ac-bc38-5b0f1a16f01c"),
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
				UId = new Guid("042e445c-bd5d-4345-b6bb-a4b076721874"),
				ContainerUId = new Guid("2cb1f9f5-5f6a-47ac-bc38-5b0f1a16f01c"),
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
				UId = new Guid("6c1bae15-036f-4fd6-9ffb-a769f1f93fc3"),
				ContainerUId = new Guid("2cb1f9f5-5f6a-47ac-bc38-5b0f1a16f01c"),
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
				UId = new Guid("12feb0e9-d2e8-4472-a8e6-9debd7309e0e"),
				ContainerUId = new Guid("2cb1f9f5-5f6a-47ac-bc38-5b0f1a16f01c"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet602 = CreateLaneSet602LaneSet();
			LaneSets.Add(schemaLaneSet602);
			ProcessSchemaLane schemaLane2149 = CreateLane2149Lane();
			schemaLaneSet602.Lanes.Add(schemaLane2149);
			ProcessSchemaEventSubProcess eventsubprocesschildinit = CreateEventSubProcessChildInitEventSubProcess();
			FlowElements.Add(eventsubprocesschildinit);
			ProcessSchemaEventSubProcess treegriddblclickchildeventsubprocess = CreateTreeGridDblClickChildEventSubProcessEventSubProcess();
			FlowElements.Add(treegriddblclickchildeventsubprocess);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess subprocessfoldermenuitemclick = CreateSubProcessFolderMenuItemClickEventSubProcess();
			FlowElements.Add(subprocessfoldermenuitemclick);
			ProcessSchemaEventSubProcess subprocessselectfolderchild = CreateSubProcessSelectFolderChildEventSubProcess();
			FlowElements.Add(subprocessselectfolderchild);
			ProcessSchemaEventSubProcess subprocesspageloadcompletechild = CreateSubProcessPageLoadCompleteChildEventSubProcess();
			FlowElements.Add(subprocesspageloadcompletechild);
			ProcessSchemaEventSubProcess subprocess2child = CreateSubProcess2ChildEventSubProcess();
			FlowElements.Add(subprocess2child);
			ProcessSchemaStartMessageEvent startmessagechildinit = CreateStartMessageChildInitStartMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(startmessagechildinit);
			ProcessSchemaScriptTask scripttaskchildinit = CreateScriptTaskChildInitScriptTask();
			eventsubprocesschildinit.FlowElements.Add(scripttaskchildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent treegriddblclickchild = CreateTreeGridDblClickChildStartMessageEvent();
			treegriddblclickchildeventsubprocess.FlowElements.Add(treegriddblclickchild);
			ProcessSchemaStartMessageEvent deleteyesmessagechild = CreateDeleteYesMessageChildStartMessageEvent();
			subprocess9.FlowElements.Add(deleteyesmessagechild);
			ProcessSchemaScriptTask scriptdeleteyesmessagechild = CreateScriptDeleteYesMessageChildScriptTask();
			subprocess9.FlowElements.Add(scriptdeleteyesmessagechild);
			ProcessSchemaStartMessageEvent foldermenuitemclick = CreateFolderMenuItemClickStartMessageEvent();
			subprocessfoldermenuitemclick.FlowElements.Add(foldermenuitemclick);
			ProcessSchemaScriptTask scriptfoldermenuitemclick = CreateScriptFolderMenuItemClickScriptTask();
			subprocessfoldermenuitemclick.FlowElements.Add(scriptfoldermenuitemclick);
			ProcessSchemaStartMessageEvent selectfolderchild = CreateSelectFolderChildStartMessageEvent();
			subprocessselectfolderchild.FlowElements.Add(selectfolderchild);
			ProcessSchemaScriptTask scriptselectfolderchild = CreateScriptSelectFolderChildScriptTask();
			subprocessselectfolderchild.FlowElements.Add(scriptselectfolderchild);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			subprocesspageloadcompletechild.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			subprocesspageloadcompletechild.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocesspageloadcompletechild.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaStartMessageEvent folderentryaddbuttonclick = CreateFolderEntryAddButtonClickStartMessageEvent();
			subprocess2child.FlowElements.Add(folderentryaddbuttonclick);
			ProcessSchemaScriptTask initopenlookupusertaskscript = CreateInitOpenLookupUserTaskScriptScriptTask();
			subprocess2child.FlowElements.Add(initopenlookupusertaskscript);
			ProcessSchemaScriptTask applydatascript = CreateApplyDataScriptScriptTask();
			subprocess2child.FlowElements.Add(applydatascript);
			ProcessSchemaExclusiveGateway exclusivegatewaycheckdetailmode = CreateExclusiveGatewayCheckDetailModeExclusiveGateway();
			subprocess2child.FlowElements.Add(exclusivegatewaycheckdetailmode);
			ProcessSchemaStartMessageEvent startmessagefolderallowadddetailmessage = CreateStartMessageFolderAllowAddDetailMessageStartMessageEvent();
			subprocess2child.FlowElements.Add(startmessagefolderallowadddetailmessage);
			ProcessSchemaStartMessageEvent startmessagelookupgridpageclosed = CreateStartMessageLookupGridPageClosedStartMessageEvent();
			subprocess2child.FlowElements.Add(startmessagelookupgridpageclosed);
			ProcessSchemaScriptTask scripttaskthrowallowchilddetailmessage = CreateScriptTaskThrowAllowChildDetailMessageScriptTask();
			subprocess2child.FlowElements.Add(scripttaskthrowallowchilddetailmessage);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			subprocess2child.FlowElements.Add(openlookupusertask);
			FlowElements.Add(CreateSequenceFlow13394SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13396SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13397SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13398SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13399SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13400SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13402SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13403SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13404ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow13405SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13406SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13407SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13394SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13394",
				UId = new Guid("b449f625-71e6-4688-a3ad-eb4410ac1798"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(140, 600),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d26ceb73-c028-42d4-8818-d0a30391ad57"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a559878-9efc-4da8-bed7-dd4ac3933c42"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13396SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13396",
				UId = new Guid("6459a7da-08d2-4e90-bfcb-fd4b6697ccb3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(446, 602),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("afd00fec-9e87-49c0-bcae-7ea8c4395c0b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52ff6b0e-74fc-4f85-87c3-8ed39d7c6d5b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13397SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13397",
				UId = new Guid("d18990f2-d5ba-4d4c-a04f-f3aebb73bb20"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b28a3f5-985f-410f-8f90-fab38099e6ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79c63366-cfc6-4e28-8914-18bc41de99b4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13398SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13398",
				UId = new Guid("c8129a0b-1853-49d2-ad59-429e2c8515ea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(334, 1689),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f6894e83-f19f-4867-8ab4-589d2cbead12"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1cad67f4-b179-4e8d-8805-79daa7434a6e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13399SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13399",
				UId = new Guid("91c88104-8b70-45a4-a911-48a53b0bdb49"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(414, 1688),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1cad67f4-b179-4e8d-8805-79daa7434a6e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf266cb7-d345-4ad9-8f11-1e53f8fe8412"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13400SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13400",
				UId = new Guid("fffe7629-f95f-4a13-8a83-926f6c3b9647"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(169, 1692),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d1853d86-6fc3-4658-9ac7-79ff9b2d4786"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e1f1ea6-3c70-496e-8399-2a52f7e3d15c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13402SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13402",
				UId = new Guid("1412d3d3-0e45-4425-87d1-3d067639c821"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(180, 1687),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("014048d1-3742-454a-a9f4-d2858383ae03"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ae147d2-1491-42a3-a36a-c9e6202dc604"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13403SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow13403",
				UId = new Guid("80541c49-e088-4812-bf70-2e8724cd754e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(174, 2296),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a559878-9efc-4da8-bed7-dd4ac3933c42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba85b080-0b01-4137-a9fd-6bf2b8e0b31a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow13404ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow13404",
				UId = new Guid("10d5aaca-e829-4499-92e8-48d7c0c27478"),
				ConditionExpression = @"NeedAddDetailRequest",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(228, 2407),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a559878-9efc-4da8-bed7-dd4ac3933c42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ecd2e226-0193-4c2c-951b-68d98266f3c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13405SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13405",
				UId = new Guid("9de6b4a4-68cd-4c04-9034-6d1861591988"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(228, 2312),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7b5c8bf-8310-403d-a296-f58761f13cb2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba85b080-0b01-4137-a9fd-6bf2b8e0b31a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13406SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13406",
				UId = new Guid("35d39985-23da-4e10-98a5-ef7002994d29"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(174, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b61a94b-ca4e-4bc8-b179-7e8a34fa8b2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bfb5d406-98af-4d9c-82fa-a50401ed3f6e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13407SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13407",
				UId = new Guid("15b80192-b021-46fb-8582-d48bc9ed688c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(288, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bfb5d406-98af-4d9c-82fa-a50401ed3f6e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2de7af8e-c722-4402-9ddc-7ac38b6e7120"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1ba7c690-7886-45bd-a99f-a3087a04659f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				CurveCenterPosition = new Point(354, 826),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba85b080-0b01-4137-a9fd-6bf2b8e0b31a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2cb1f9f5-5f6a-47ac-bc38-5b0f1a16f01c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet602LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet602 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b9217d49-1e14-46c9-8e61-0729c1810e2c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"LaneSet602",
				Position = new Point(5, 5),
				Size = new Size(721, 1026),
				UseBackgroundMode = false
			};
			return schemaLaneSet602;
		}

		protected virtual ProcessSchemaLane CreateLane2149Lane() {
			ProcessSchemaLane schemaLane2149 = new ProcessSchemaLane(this) {
				UId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b9217d49-1e14-46c9-8e61-0729c1810e2c"),
				CreatedInOwnerSchemaUId = new Guid("9108b523-71ec-4805-8741-3e79ba1bc9f3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"Lane2149",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(692, 177),
				UseBackgroundMode = false
			};
			return schemaLane2149;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("07238616-babd-444b-92e0-c7a0687c1d39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"EventSubProcessChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(274, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2b61a94b-ca4e-4bc8-b179-7e8a34fa8b2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07238616-babd-444b-92e0-c7a0687c1d39"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"StartMessageChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bfb5d406-98af-4d9c-82fa-a50401ed3f6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07238616-babd-444b-92e0-c7a0687c1d39"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ScriptTaskChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,73,44,73,12,206,47,45,74,78,13,46,41,42,77,46,41,45,74,85,176,85,0,50,83,173,185,138,82,129,220,60,8,7,0,19,84,129,196,51,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2de7af8e-c722-4402-9ddc-7ac38b6e7120"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07238616-babd-444b-92e0-c7a0687c1d39"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateTreeGridDblClickChildEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaTreeGridDblClickChildEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5056dc7d-43ac-4d6c-a140-972c0900a1b8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"TreeGridDblClickChildEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(337, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(98, 119),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaTreeGridDblClickChildEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("78753b8b-e812-4512-8cbe-951bf3102951"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5056dc7d-43ac-4d6c-a140-972c0900a1b8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"TreeGridDblClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ffe25801-b7ca-4d9e-bf2c-cd64b032507e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesMessageChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("014048d1-3742-454a-a9f4-d2858383ae03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffe25801-b7ca-4d9e-bf2c-cd64b032507e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"DeleteYesMessageChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteYesMessageChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5ae147d2-1491-42a3-a36a-c9e6202dc604"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffe25801-b7ca-4d9e-bf2c-cd64b032507e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ScriptDeleteYesMessageChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,203,110,219,48,16,60,219,128,255,129,245,73,10,2,186,61,231,1,36,126,4,65,219,52,141,147,246,16,248,192,152,235,152,173,68,186,148,228,212,40,242,239,221,37,245,182,220,160,23,75,162,135,179,187,179,179,228,86,88,38,33,21,42,154,67,4,203,20,228,141,145,144,176,51,118,43,158,129,223,91,128,43,171,36,111,252,123,50,232,171,21,11,254,129,224,99,147,233,148,157,178,15,33,251,51,232,247,44,164,153,213,44,181,25,224,230,215,65,127,139,113,87,38,146,96,175,37,6,235,72,225,241,253,130,127,19,81,134,111,195,89,142,28,46,78,252,86,208,169,74,119,215,122,86,81,104,120,97,87,153,146,193,27,92,196,194,239,205,60,181,74,63,7,97,136,140,158,83,201,36,167,25,155,136,54,43,163,79,191,102,96,119,183,194,138,24,82,176,231,1,193,71,71,4,143,141,204,34,32,13,10,177,232,103,108,52,70,215,96,241,203,98,150,252,70,196,24,167,92,102,34,97,13,92,94,208,51,74,136,60,65,197,202,103,74,203,2,106,77,116,185,67,42,8,134,36,246,48,220,227,9,243,166,56,162,119,88,71,22,69,94,251,42,217,137,72,197,220,100,118,73,41,191,29,169,130,251,120,83,39,122,181,138,17,123,137,147,145,109,172,138,133,221,161,112,89,172,105,119,25,160,130,243,249,114,13,177,224,183,117,44,233,211,65,52,81,201,38,18,255,197,215,216,82,210,86,197,23,70,69,38,210,232,80,209,5,204,151,92,124,17,213,202,88,16,203,117,64,148,214,188,48,165,91,204,205,17,240,226,247,208,85,252,66,202,128,124,213,52,83,128,36,133,43,247,244,91,56,99,246,112,82,94,25,68,9,56,50,215,172,154,0,119,16,155,45,4,237,97,112,59,91,19,119,52,66,123,28,78,165,158,121,163,63,46,63,204,133,177,209,40,93,171,132,69,104,54,134,79,165,147,20,132,100,102,197,150,38,142,49,7,144,222,202,18,86,190,42,55,150,115,72,39,197,130,155,158,6,164,24,157,135,4,44,54,66,251,169,67,33,147,4,159,84,234,99,141,174,54,182,11,234,206,68,57,56,38,123,234,237,115,204,204,211,15,228,56,111,197,105,248,200,83,240,105,188,73,119,136,203,219,202,92,95,183,132,166,206,150,81,125,27,59,137,28,152,127,132,93,45,47,146,254,9,9,127,146,232,189,158,79,195,194,202,207,78,77,211,156,163,221,210,220,211,30,152,240,43,72,115,99,238,103,16,242,22,93,89,116,132,61,101,103,131,62,53,122,114,201,39,110,33,232,16,58,196,108,249,204,154,56,56,144,135,139,67,160,239,107,176,56,29,229,65,76,139,61,126,157,76,127,101,34,234,114,212,176,56,221,135,199,229,65,31,58,170,11,45,131,67,138,228,180,58,64,175,210,59,53,217,101,143,181,249,186,248,244,55,44,51,44,167,58,184,115,255,191,125,143,28,138,74,183,10,149,240,176,145,2,153,155,26,29,119,184,200,213,129,206,14,134,159,141,84,43,5,242,139,198,58,243,179,167,18,161,101,235,113,102,233,78,160,85,234,108,254,137,170,195,189,194,22,135,97,93,106,18,185,20,120,143,185,168,57,12,91,130,180,27,249,201,8,121,103,94,58,15,137,230,25,241,23,25,176,243,221,11,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessFolderMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessFolderMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b24efe1e-8e57-4dd3-a748-305e1cc1ce95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"SubProcessFolderMenuItemClick",
				Position = new Point(281, 202),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessFolderMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFolderMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2b28a3f5-985f-410f-8f90-fab38099e6ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b24efe1e-8e57-4dd3-a748-305e1cc1ce95"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FolderMenuItemClick",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"FolderMenuItemClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptFolderMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("79c63366-cfc6-4e28-8914-18bc41de99b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b24efe1e-8e57-4dd3-a748-305e1cc1ce95"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ScriptFolderMenuItemClick",
				Position = new Point(77, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,65,107,195,48,12,133,207,203,175,240,114,74,96,152,237,156,237,48,74,87,10,163,20,210,237,50,122,48,182,218,26,92,171,200,118,195,24,251,239,147,147,173,77,96,151,224,200,250,164,247,158,207,138,68,0,7,58,130,89,161,129,32,158,196,90,237,65,110,8,96,65,214,200,118,124,219,20,118,39,170,9,32,103,152,124,20,143,226,161,22,95,197,13,65,76,228,69,164,4,77,241,93,44,146,53,98,135,206,0,45,13,207,246,208,137,92,155,206,248,184,223,202,119,229,18,159,202,151,223,230,114,43,55,216,70,178,126,95,213,117,83,156,89,233,17,77,114,144,245,241,168,170,215,153,63,51,244,81,89,15,196,127,4,62,202,149,58,50,118,41,11,21,196,164,175,238,177,165,15,81,121,13,127,215,173,62,192,81,189,5,160,220,72,232,6,183,163,165,183,108,32,57,215,27,189,150,229,154,80,67,8,28,85,228,227,9,40,126,246,110,170,114,129,17,47,134,238,46,65,176,157,49,191,57,16,118,243,51,43,175,202,33,238,129,41,235,28,97,214,240,138,90,113,88,75,63,55,54,102,166,151,112,133,103,206,50,253,223,136,233,210,158,120,54,166,213,100,79,220,218,89,111,176,147,172,57,167,183,67,157,66,85,55,195,222,241,75,254,0,222,252,116,227,39,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessSelectFolderChildEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessSelectFolderChild = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("95a74a4c-ea29-4c3a-8432-5a912292baf7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"SubProcessSelectFolderChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 370),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessSelectFolderChild;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSelectFolderChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d1853d86-6fc3-4658-9ac7-79ff9b2d4786"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("95a74a4c-ea29-4c3a-8432-5a912292baf7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SelectFolder",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"SelectFolderChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSelectFolderChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7e1f1ea6-3c70-496e-8399-2a52f7e3d15c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("95a74a4c-ea29-4c3a-8432-5a912292baf7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ScriptSelectFolderChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,205,10,130,80,16,70,215,250,20,87,87,10,225,11,136,155,74,67,136,18,170,7,16,157,108,224,54,87,230,142,150,132,239,158,164,65,155,182,135,239,231,224,85,5,94,110,183,32,37,234,29,99,29,170,151,235,224,68,173,48,82,19,229,246,208,105,125,228,244,222,202,16,236,209,10,16,112,81,54,80,176,169,192,218,75,94,135,159,146,195,32,29,147,18,238,32,118,157,209,117,250,146,85,59,167,84,162,46,22,120,99,136,160,18,52,20,229,75,63,165,6,9,162,12,169,94,200,122,152,54,255,93,197,179,221,119,214,75,20,77,126,179,192,2,163,243,141,205,35,237,129,36,168,12,9,60,101,165,252,19,232,233,57,51,186,6,246,195,143,224,232,254,42,191,1,142,62,202,53,11,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPageLoadCompleteChildEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPageLoadCompleteChild = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("11018b60-fd33-4b9d-8d80-b335f2dee19b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"SubProcessPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 552),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(270, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPageLoadCompleteChild;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f6894e83-f19f-4867-8ab4-589d2cbead12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11018b60-fd33-4b9d-8d80-b335f2dee19b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1cad67f4-b179-4e8d-8805-79daa7434a6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11018b60-fd33-4b9d-8d80-b335f2dee19b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(98, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cf266cb7-d345-4ad9-8f11-1e53f8fe8412"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11018b60-fd33-4b9d-8d80-b335f2dee19b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2ChildEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2Child = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77785a65-4179-4ee6-b275-8e128dddfa3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"SubProcess2Child",
				Position = new Point(36, 737),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(588, 275),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2Child;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFolderEntryAddButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d26ceb73-c028-42d4-8818-d0a30391ad57"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"FolderEntryAddButtonClick",
				Position = new Point(14, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitOpenLookupUserTaskScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ba85b080-0b01-4137-a9fd-6bf2b8e0b31a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"InitOpenLookupUserTaskScript",
				Position = new Point(182, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,146,65,111,211,64,16,133,207,68,202,127,176,124,178,69,178,42,37,13,84,45,149,218,164,133,168,40,68,36,129,3,226,48,181,199,241,210,205,174,59,187,11,181,170,252,119,214,107,147,38,17,165,185,112,177,100,251,189,55,111,62,141,54,196,229,34,224,82,27,144,9,142,210,224,93,16,69,51,36,2,173,50,195,230,35,246,21,111,6,74,26,82,66,179,9,44,48,174,30,236,92,23,254,133,141,214,86,54,83,83,31,23,197,39,237,214,167,2,229,71,165,110,109,49,215,72,51,208,183,108,66,42,65,173,175,177,116,83,54,70,190,12,124,100,245,168,38,1,151,72,108,46,249,157,197,209,208,69,233,186,164,78,114,92,194,220,119,244,134,33,24,152,42,75,9,178,169,255,199,6,74,216,165,212,236,61,154,139,114,12,75,140,194,43,37,82,164,48,102,159,49,67,66,55,177,209,206,247,105,236,198,76,128,92,144,65,210,110,174,196,95,193,144,39,134,43,9,84,6,167,117,181,78,160,110,126,96,98,206,124,206,79,160,160,216,53,70,255,112,197,207,78,118,169,219,137,236,60,77,163,112,77,36,236,60,210,137,159,16,91,141,31,56,18,80,146,151,78,159,129,208,248,148,54,231,41,94,88,99,148,212,78,106,200,122,165,163,43,208,111,113,250,184,205,238,50,103,65,198,197,6,173,253,76,30,92,99,244,21,182,65,239,234,131,135,118,235,197,67,152,168,101,1,196,181,146,179,178,64,215,244,202,39,12,182,62,179,203,59,11,98,213,241,14,129,153,185,188,47,200,157,161,75,174,207,101,2,38,119,222,230,82,188,197,17,109,12,142,218,144,235,66,64,249,5,132,197,63,224,154,191,196,23,249,70,222,26,163,215,86,232,170,53,234,206,223,190,59,253,113,154,28,101,125,236,119,15,161,255,170,219,75,241,109,23,14,142,142,187,41,190,62,200,122,248,166,151,29,246,194,213,106,213,110,253,71,30,35,61,86,102,108,197,62,76,220,70,40,205,115,48,154,190,127,187,164,250,172,235,30,21,144,102,167,74,78,104,44,73,127,93,39,191,1,213,148,134,231,136,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateApplyDataScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52ff6b0e-74fc-4f85-87c3-8ed39d7c6d5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ApplyDataScript",
				Position = new Point(490, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,85,219,78,27,49,16,125,222,72,249,7,43,79,182,132,172,190,67,144,32,23,20,181,165,52,73,219,7,196,131,217,157,144,45,137,157,218,222,64,84,241,239,29,123,246,150,11,52,66,89,118,124,124,230,118,102,178,85,150,45,204,42,3,59,201,28,235,51,62,204,83,159,27,173,236,142,93,56,111,115,253,116,198,204,227,111,72,253,165,248,182,1,253,197,152,231,98,243,195,129,157,43,247,44,111,192,207,96,133,167,144,253,84,171,2,28,15,71,3,163,53,68,30,113,206,186,157,124,193,120,237,68,14,76,161,61,235,247,217,39,193,254,118,59,137,5,95,88,205,188,45,224,188,219,121,235,118,182,24,83,30,163,209,240,194,6,102,181,34,174,139,155,34,207,46,185,64,20,30,203,171,44,227,149,239,91,147,193,157,205,215,24,54,226,139,181,142,193,4,100,32,203,148,87,51,83,216,20,144,243,78,61,129,28,214,22,132,4,90,150,193,130,18,152,100,8,154,129,31,86,6,94,211,84,150,138,101,63,85,57,3,231,240,25,184,239,91,116,114,110,102,177,144,92,60,48,229,88,83,225,195,2,163,31,178,212,174,40,153,91,181,14,145,19,139,28,173,55,126,135,208,133,177,160,210,37,227,33,182,109,64,179,92,55,65,82,113,79,18,69,176,252,12,187,86,104,72,152,60,34,225,115,232,65,146,80,198,46,93,194,90,125,85,26,179,181,120,241,32,225,208,252,54,130,247,70,218,231,126,183,103,236,137,144,244,137,131,178,170,16,79,38,122,28,5,66,136,50,206,131,86,73,58,148,225,116,239,242,157,178,104,242,65,94,165,104,190,23,96,27,51,239,17,110,10,139,222,25,11,237,166,34,86,141,37,109,254,159,101,92,106,248,36,137,133,5,37,217,18,224,199,121,16,208,133,50,94,239,2,148,31,119,75,200,3,58,244,70,162,103,240,154,59,143,189,163,168,92,105,165,200,233,133,159,80,105,69,200,199,133,78,105,22,121,15,83,18,66,94,57,222,155,66,106,108,230,162,189,39,228,216,154,53,127,175,67,66,162,102,126,45,193,2,127,47,121,33,39,110,244,167,80,43,126,212,169,120,251,74,103,173,178,54,232,163,142,68,17,81,86,88,1,242,21,50,157,154,151,246,40,196,81,14,127,58,108,16,26,129,35,207,50,134,135,149,202,179,160,250,189,57,170,214,84,96,168,87,22,241,36,71,65,213,68,21,50,204,84,160,76,10,23,166,56,50,102,143,163,87,72,11,111,78,12,208,72,187,194,194,240,186,49,113,81,58,171,40,38,65,55,83,80,200,31,247,88,249,111,255,116,251,37,249,2,66,241,198,119,77,155,52,36,50,60,104,242,241,147,47,78,201,69,14,175,231,187,13,10,82,111,193,98,210,248,30,147,158,155,9,10,167,225,186,223,87,206,131,96,151,213,126,15,159,212,96,19,116,92,240,225,245,45,62,226,55,126,177,36,161,78,98,86,205,170,150,3,108,11,102,98,94,202,16,9,35,105,53,183,116,230,142,206,91,135,123,67,203,219,125,18,31,221,122,79,207,103,168,153,253,123,106,11,228,255,45,254,118,197,18,206,45,192,141,197,5,129,11,199,130,91,134,22,70,80,251,167,238,31,250,125,140,48,122,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayCheckDetailModeExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7a559878-9efc-4da8-bed7-dd4ac3933c42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ExclusiveGatewayCheckDetailMode",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageFolderAllowAddDetailMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d7b5c8bf-8310-403d-a296-f58761f13cb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AllowAddDetailMessage",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"StartMessageFolderAllowAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 9),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageLookupGridPageClosedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("afd00fec-9e87-49c0-bcae-7ea8c4395c0b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"StartMessageLookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskThrowAllowChildDetailMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ecd2e226-0193-4c2c-951b-68d98266f3c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"ScriptTaskThrowAllowChildDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 175),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,240,129,10,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,5,165,22,150,166,22,151,56,166,164,184,164,150,36,102,230,248,2,101,128,106,148,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,170,228,80,243,83,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2cb1f9f5-5f6a-47ac-bc38-5b0f1a16f01c"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0da62f9e-cb08-45a7-8f07-699f7b1980fb"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"),
				Name = @"OpenLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 63),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b290399a-ffe8-44f6-9563-48a4b047270c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("03306833-7f26-459c-b17a-52c6e801dc69"),
				Name = "Terrasoft.Core.DB",
				Alias = "DB",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8d97943d-5eb8-482e-bd8c-b5b2df5c2f0b"),
				Name = "System.Data",
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

		protected override SchemaMethod CreateCallRefreshDetailsMethod() {
			SchemaMethod method = base.CreateCallRefreshDetailsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,111,194,48,12,61,175,191,34,235,169,32,20,184,87,28,88,249,80,165,9,33,96,187,32,14,89,99,32,82,154,160,196,133,85,99,255,125,73,183,162,150,49,105,151,200,121,177,95,252,252,44,118,36,122,76,237,24,144,9,57,51,130,119,200,71,240,240,44,44,130,2,179,62,24,125,158,156,64,97,84,67,11,182,135,133,209,25,88,251,146,242,30,9,125,209,40,67,113,130,165,62,39,7,166,246,192,195,78,28,124,6,253,110,112,98,134,240,138,219,174,217,219,130,41,144,100,72,100,131,139,250,35,209,202,229,56,132,78,133,226,53,98,180,124,42,231,44,135,40,28,183,57,194,14,97,150,212,183,56,16,187,232,215,47,67,162,10,41,201,229,114,219,0,117,129,165,137,46,20,250,172,65,165,216,0,22,70,249,174,125,203,172,210,227,242,92,179,247,170,55,183,224,168,46,72,21,135,247,109,220,16,222,210,231,248,174,220,52,69,200,237,102,176,245,90,90,89,113,112,167,180,26,84,170,44,50,149,185,169,125,91,64,87,128,46,60,130,193,242,149,201,194,141,106,5,18,50,4,62,215,220,25,37,114,102,202,68,203,34,87,213,123,216,35,179,66,112,58,201,143,88,58,151,218,86,252,73,58,21,18,193,252,151,167,177,54,225,18,118,6,236,225,199,64,191,24,221,254,23,137,237,255,136,117,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetAdditionalDataSourcePropertiesMethod() {
			SchemaMethod method = base.CreateSetAdditionalDataSourcePropertiesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,177,10,194,48,16,134,103,243,20,71,166,118,201,11,132,78,45,130,139,8,5,247,24,207,122,144,38,114,73,92,172,239,110,77,5,165,142,199,247,241,253,23,19,147,31,192,6,151,71,191,55,35,106,113,55,12,54,51,163,79,125,226,108,83,102,132,6,14,102,64,213,153,100,250,144,217,162,106,87,138,22,151,192,104,236,181,42,129,18,4,242,127,41,213,22,20,107,120,136,205,119,119,94,88,14,181,124,241,65,106,23,143,20,233,228,222,66,245,171,55,32,183,193,157,145,37,76,19,172,72,135,209,50,221,18,5,47,107,45,158,130,113,222,246,250,5,167,191,76,10,239,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseFoldersEntryGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2538f759-2126-47ae-bdd7-0ec8cbdc697c"));
		}

		#endregion

	}

	#endregion

}

