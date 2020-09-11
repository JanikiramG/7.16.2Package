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

	#region Class: SysModuleReportsGridPageSchema

	/// <exclude/>
	public class SysModuleReportsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _saveToFileButton;
		public Terrasoft.UI.WebControls.Controls.Button SaveToFileButton {
			get {
				return _saveToFileButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _fakeSaveToFileButton;
		public Terrasoft.UI.WebControls.Controls.Button FakeSaveToFileButton {
			get {
				return _fakeSaveToFileButton;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleReportsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportsGridPageSchema(SysModuleReportsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			RealUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			Name = "SysModuleReportsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportsGridPageEventsProcessSchema();
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
			ButtonsControlLayout.InsertItem(4, CreateSaveToFileButton());
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, ActionButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			ButtonsControlLayout.InsertItem(9, CreateFakeSaveToFileButton());
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleReportsGridPageEventsProcessSchema() {
			var schema = new SysModuleReportsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSaveToFileButton() {
			_saveToFileButton = new Terrasoft.UI.WebControls.Controls.Button();
			_saveToFileButton.UId = new Guid("47d84795-8a4b-4f3c-adcd-a7aef1210e07");
			_saveToFileButton.Name = "SaveToFileButton";
			_saveToFileButton.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			_saveToFileButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			_saveToFileButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_saveToFileButton.Tag = "";
			_saveToFileButton.Image = new ControlImage {};
			_saveToFileButton.Margins = "0 0 0 10";
			return _saveToFileButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateFakeSaveToFileButton() {
			_fakeSaveToFileButton = new Terrasoft.UI.WebControls.Controls.Button();
			_fakeSaveToFileButton.UId = new Guid("33327dc5-f92b-4b38-b088-f76ceec7521c");
			_fakeSaveToFileButton.Name = "FakeSaveToFileButton";
			_fakeSaveToFileButton.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			_fakeSaveToFileButton.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			_fakeSaveToFileButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_fakeSaveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_fakeSaveToFileButton.Tag = "";
			_fakeSaveToFileButton.Image = new ControlImage {};
			_fakeSaveToFileButton.Hidden = true;
			return _fakeSaveToFileButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297");
			DataSource.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("88768030-fd63-42f6-852b-c35480e24055");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("63cac257-612e-4a92-87f3-d7de1915187f");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("710b25e1-22db-4b17-9668-04a37d07ce45");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a8ae4e1a-0bb9-495b-8f2e-f2d88970312a");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("75b5649b-2c5e-4fde-a1af-0fb941ab85ba");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fb83606-040e-4fdb-aeb6-a9357886dcb3");
			if (column != null) {
				column.UId = new Guid("fbe1b357-8a12-459f-be7c-ce872bb05377");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b6607c22-ca01-41f0-8637-610221a869b6");
			if (column != null) {
				column.UId = new Guid("48137d1c-047a-4459-a801-0f37b10df56b");
				column.Name = @"SysModule";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cb6b495c-384d-4a40-9f93-35c6dfb79a3b");
			if (column != null) {
				column.UId = new Guid("1b16d7c2-e652-4e2a-b952-1415eebe35fe");
				column.Name = @"File";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("94f2a9f7-55c7-4ecf-9b64-17583ddc058b");
			if (column != null) {
				column.UId = new Guid("73237936-3e2d-4080-bb6d-e4a6303b8fe6");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("362bb0b0-d3da-4b01-abe6-a617e1b1257f");
			if (column != null) {
				column.UId = new Guid("7f1aadcb-c831-4c05-bb35-bf05239ac372");
				column.Name = @"FileName";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1f17f6cb-8a86-408c-9207-d2f8b22ae1b7");
			if (column != null) {
				column.UId = new Guid("96135ebe-d14d-4589-a6c9-d45721199b28");
				column.Name = @"SysOptionsPageSchemaUId";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8e01622f-e04b-480a-859a-01df55c30729");
			if (column != null) {
				column.UId = new Guid("cb414270-1321-4ebe-91c0-92f19f49e267");
				column.Name = @"SysReportSchemaUId";
				column.CreatedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
				column.ModifiedInSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
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
			return new SysModuleReportsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportsGridPageSchemaUserControl
	{

		#region Class: UserMessageUserTask2FlowElement

		/// <exclude/>
		public class UserMessageUserTask2FlowElement : QuestionUserTask
		{

			public UserMessageUserTask2FlowElement(UserConnection userConnection, SysModuleReportsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserMessageUserTask2";
				IsLogging = false;
				SchemaElementUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowNotMSWordReportUserTask2FlowElement

		/// <exclude/>
		public class ShowNotMSWordReportUserTask2FlowElement : QuestionUserTask
		{

			public ShowNotMSWordReportUserTask2FlowElement(UserConnection userConnection, SysModuleReportsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowNotMSWordReportUserTask2";
				IsLogging = false;
				SchemaElementUId = new Guid("97fd0034-6559-4785-8190-94623a646121");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SysModuleReportsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportsGridPageEventsProcess";
			SchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
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

		public virtual Guid SysModuleEntityId {
			get;
			set;
		}

		public virtual Guid SelectedModuleId {
			get;
			set;
		}

		public virtual bool IsMSWordReport {
			get;
			set;
		}

		public virtual Guid ReportTypeId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("ec811c86-9d12-4d7f-a3f2-314f94a04ab6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _reportEditPageClosedStartMessage;
		public ProcessFlowElement ReportEditPageClosedStartMessage {
			get {
				return _reportEditPageClosedStartMessage ?? (_reportEditPageClosedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ReportEditPageClosedStartMessage",
					SchemaElementUId = new Guid("57922a3f-e97e-4f23-9bd0-850515b88ad4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask8;
		public ProcessScriptTask ScriptTask8 {
			get {
				return _scriptTask8 ?? (_scriptTask8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask8",
					SchemaElementUId = new Guid("7ec56277-3237-43d7-9204-b339dbe20b45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8Execute,
				});
			}
		}

		private UserMessageUserTask2FlowElement _userMessageUserTask2;
		public UserMessageUserTask2FlowElement UserMessageUserTask2 {
			get {
				return _userMessageUserTask2 ?? (_userMessageUserTask2 = new UserMessageUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess14;
		public ProcessFlowElement EventSubProcess14 {
			get {
				return _eventSubProcess14 ?? (_eventSubProcess14 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess14",
					SchemaElementUId = new Guid("b50c441a-73e0-49c5-b483-ae0313db5f6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _saveFileTemplateQuestionYesMessageStartMessage;
		public ProcessFlowElement SaveFileTemplateQuestionYesMessageStartMessage {
			get {
				return _saveFileTemplateQuestionYesMessageStartMessage ?? (_saveFileTemplateQuestionYesMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveFileTemplateQuestionYesMessageStartMessage",
					SchemaElementUId = new Guid("983a5889-66aa-4aba-901c-30582fc5000d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask10;
		public ProcessScriptTask ScriptTask10 {
			get {
				return _scriptTask10 ?? (_scriptTask10 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask10",
					SchemaElementUId = new Guid("e97a699e-f8cb-4ff9-83e9-cb401d5e5d3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask10Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess15;
		public ProcessFlowElement EventSubProcess15 {
			get {
				return _eventSubProcess15 ?? (_eventSubProcess15 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess15",
					SchemaElementUId = new Guid("c04701ef-2583-4f33-bc7f-68192da3aa0c"),
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
					SchemaElementUId = new Guid("1782f20c-0ac5-4459-b466-e3bc77cb0d5d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask9;
		public ProcessScriptTask ScriptTask9 {
			get {
				return _scriptTask9 ?? (_scriptTask9 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask9",
					SchemaElementUId = new Guid("a878a401-3c3a-4386-9bfe-6eb2ac258cdb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask9Execute,
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
					SchemaElementUId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _saveToFileButtonClickStartMessage;
		public ProcessFlowElement SaveToFileButtonClickStartMessage {
			get {
				return _saveToFileButtonClickStartMessage ?? (_saveToFileButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveToFileButtonClickStartMessage",
					SchemaElementUId = new Guid("fc0c62b9-ea01-4b04-8ac3-fdf137172e02"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("d8d65461-ac39-4a93-8604-d3d292dc8370"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("287f7d90-45f5-4470-bbc4-afd6e0f8409c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("cbcba9f2-dc98-4350-b951-395c6359d6b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask6;
		public ProcessScriptTask ScriptTask6 {
			get {
				return _scriptTask6 ?? (_scriptTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask6",
					SchemaElementUId = new Guid("592b7731-28d4-476c-a073-9a672453f1ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6Execute,
				});
			}
		}

		private ShowNotMSWordReportUserTask2FlowElement _showNotMSWordReportUserTask2;
		public ShowNotMSWordReportUserTask2FlowElement ShowNotMSWordReportUserTask2 {
			get {
				return _showNotMSWordReportUserTask2 ?? (_showNotMSWordReportUserTask2 = new ShowNotMSWordReportUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("f00c8afa-fa88-45ab-873a-30adcab7142c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("d2e4d56b-1be6-42dd-bafd-a1cbea812f0a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("073fdfe8-78e1-4788-9557-3cf0ee921bcd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceActiveRowChanged",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("d3888e54-1231-469d-9ec9-d25f82f5fbab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("3d1bc8ee-bd99-4aef-9a40-31a6c98bbfae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteYesChildMessage;
		public ProcessFlowElement DeleteYesChildMessage {
			get {
				return _deleteYesChildMessage ?? (_deleteYesChildMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteYesChildMessage",
					SchemaElementUId = new Guid("0fe6e49e-d495-40b1-b204-b12bf151f9e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _deleteYesBaseMessage;
		public ProcessThrowMessageEvent DeleteYesBaseMessage {
			get {
				return _deleteYesBaseMessage ?? (_deleteYesBaseMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DeleteYesBaseMessage",
					SchemaElementUId = new Guid("b8fe9ae0-dd5c-4052-8133-f1254bcbc69c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteYesMessage",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _deleteYesMessageChildScriptTask;
		public ProcessScriptTask DeleteYesMessageChildScriptTask {
			get {
				return _deleteYesMessageChildScriptTask ?? (_deleteYesMessageChildScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteYesMessageChildScriptTask",
					SchemaElementUId = new Guid("10147362-b9c9-460f-8f8b-22a45be76e9f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteYesMessageChildScriptTaskExecute,
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
					SchemaElementUId = new Guid("7be07856-137e-4742-9581-5982c25cd9f8"),
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
					SchemaElementUId = new Guid("42b9d99e-ba47-46f5-83cd-31fb7624a07d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("0496b6c0-7ddc-456d-ae1e-75b63552f248"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("c31f9103-2be7-4ccc-9971-3fbfe09287a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("eaf48617-2725-41d6-877b-5ee8f52bedd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("8dee6722-8746-4b98-8874-fe5bbd6276ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask7;
		public ProcessScriptTask ScriptTask7 {
			get {
				return _scriptTask7 ?? (_scriptTask7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask7",
					SchemaElementUId = new Guid("e214b3ca-e3f0-4f6a-8bc8-aec93db78a7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7Execute,
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
					SchemaElementUId = new Guid("77a344ee-d145-41dd-a979-3c37b41fc7a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess11_a25d890e3c13448f943b7210574b644f;
		public ProcessFlowElement EventSubProcess11_a25d890e3c13448f943b7210574b644f {
			get {
				return _eventSubProcess11_a25d890e3c13448f943b7210574b644f ?? (_eventSubProcess11_a25d890e3c13448f943b7210574b644f = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11_a25d890e3c13448f943b7210574b644f",
					SchemaElementUId = new Guid("a25d890e-3c13-448f-943b-7210574b644f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask11_3a295464a1954edaae547f3f770cdfd5;
		public ProcessScriptTask ScriptTask11_3a295464a1954edaae547f3f770cdfd5 {
			get {
				return _scriptTask11_3a295464a1954edaae547f3f770cdfd5 ?? (_scriptTask11_3a295464a1954edaae547f3f770cdfd5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask11_3a295464a1954edaae547f3f770cdfd5",
					SchemaElementUId = new Guid("3a295464-a195-4eda-ae54-7f3f770cdfd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask11_3a295464a1954edaae547f3f770cdfd5Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67;
		public ProcessThrowMessageEvent IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67 {
			get {
				return _intermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67 ?? (_intermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67",
					SchemaElementUId = new Guid("604862da-6966-48b3-b4bd-ddf7d0828d67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _startMessage4_c20452014444449cafb1aa4c68beac00;
		public ProcessFlowElement StartMessage4_c20452014444449cafb1aa4c68beac00 {
			get {
				return _startMessage4_c20452014444449cafb1aa4c68beac00 ?? (_startMessage4_c20452014444449cafb1aa4c68beac00 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_c20452014444449cafb1aa4c68beac00",
					SchemaElementUId = new Guid("c2045201-4444-449c-afb1-aa4c68beac00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("92162d1a-5ef3-42ff-8fdb-d9910a467ef4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _operationNotSupported;
		public LocalizableString OperationNotSupported {
			get {
				return _operationNotSupported ?? (_operationNotSupported = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OperationNotSupported.Value"));
			}
		}

		private LocalizableString _mSWordDisplayValue;
		public LocalizableString MSWordDisplayValue {
			get {
				return _mSWordDisplayValue ?? (_mSWordDisplayValue = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MSWordDisplayValue.Value"));
			}
		}

		private LocalizableString _saveFileTemplateQuestion;
		public LocalizableString SaveFileTemplateQuestion {
			get {
				return _saveFileTemplateQuestion ?? (_saveFileTemplateQuestion = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SaveFileTemplateQuestion.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[ReportEditPageClosedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReportEditPageClosedStartMessage };
			FlowElements[ScriptTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8 };
			FlowElements[UserMessageUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { UserMessageUserTask2 };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[SaveFileTemplateQuestionYesMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveFileTemplateQuestionYesMessageStartMessage };
			FlowElements[ScriptTask10.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask10 };
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask9.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask9 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[SaveToFileButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveToFileButtonClickStartMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[ScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6 };
			FlowElements[ShowNotMSWordReportUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowNotMSWordReportUserTask2 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[DeleteYesChildMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesChildMessage };
			FlowElements[DeleteYesBaseMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesBaseMessage };
			FlowElements[DeleteYesMessageChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesMessageChildScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess11_a25d890e3c13448f943b7210574b644f.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11_a25d890e3c13448f943b7210574b644f };
			FlowElements[ScriptTask11_3a295464a1954edaae547f3f770cdfd5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask11_3a295464a1954edaae547f3f770cdfd5 };
			FlowElements[IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67 };
			FlowElements[StartMessage4_c20452014444449cafb1aa4c68beac00.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_c20452014444449cafb1aa4c68beac00 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess13":
						break;
					case "ReportEditPageClosedStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask8");
						break;
					case "ScriptTask8":
						e.Context.QueueTasks.Enqueue("UserMessageUserTask2");
						break;
					case "UserMessageUserTask2":
						break;
					case "EventSubProcess14":
						break;
					case "SaveFileTemplateQuestionYesMessageStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask10");
						break;
					case "ScriptTask10":
						break;
					case "EventSubProcess15":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask9");
						break;
					case "ScriptTask9":
						break;
					case "EventSubProcess9":
						break;
					case "SaveToFileButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask6");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						break;
					case "ScriptTask6":
						e.Context.QueueTasks.Enqueue("ShowNotMSWordReportUserTask2");
						break;
					case "ShowNotMSWordReportUserTask2":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "ScriptTask4":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "EventSubProcess1":
						break;
					case "DeleteYesChildMessage":
						e.Context.QueueTasks.Enqueue("DeleteYesBaseMessage");
						break;
					case "DeleteYesBaseMessage":
						e.Context.QueueTasks.Enqueue("DeleteYesMessageChildScriptTask");
						break;
					case "DeleteYesMessageChildScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess12":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask7");
						break;
					case "ScriptTask7":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess11_a25d890e3c13448f943b7210574b644f":
						break;
					case "ScriptTask11_3a295464a1954edaae547f3f770cdfd5":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67");
						break;
					case "IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67":
						break;
					case "StartMessage4_c20452014444449cafb1aa4c68beac00":
						e.Context.QueueTasks.Enqueue("ScriptTask11_3a295464a1954edaae547f3f770cdfd5");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(!IsMSWordReport);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ReportEditPageClosedStartMessage");
			ActivatedEventElements.Add("SaveFileTemplateQuestionYesMessageStartMessage");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("SaveToFileButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("DeleteYesChildMessage");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage4_c20452014444449cafb1aa4c68beac00");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "ReportEditPageClosedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReportEditPageClosedStartMessage";
					result = ReportEditPageClosedStartMessage.Execute(context);
					break;
				case "ScriptTask8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8";
					result = ScriptTask8.Execute(context, ScriptTask8Execute);
					break;
				case "UserMessageUserTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserMessageUserTask2";
					result = UserMessageUserTask2.Execute(context);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "SaveFileTemplateQuestionYesMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveFileTemplateQuestionYesMessageStartMessage";
					result = SaveFileTemplateQuestionYesMessageStartMessage.Execute(context);
					break;
				case "ScriptTask10":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask10";
					result = ScriptTask10.Execute(context, ScriptTask10Execute);
					break;
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask9":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask9";
					result = ScriptTask9.Execute(context, ScriptTask9Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "SaveToFileButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveToFileButtonClickStartMessage";
					result = SaveToFileButtonClickStartMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "ScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6";
					result = ScriptTask6.Execute(context, ScriptTask6Execute);
					break;
				case "ShowNotMSWordReportUserTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowNotMSWordReportUserTask2";
					result = ShowNotMSWordReportUserTask2.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceActiveRowChanged");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteYesChildMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesChildMessage";
					result = DeleteYesChildMessage.Execute(context);
					break;
				case "DeleteYesBaseMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteYesMessage");
					result = DeleteYesBaseMessage.Execute(context);
					break;
				case "DeleteYesMessageChildScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesMessageChildScriptTask";
					result = DeleteYesMessageChildScriptTask.Execute(context, DeleteYesMessageChildScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7";
					result = ScriptTask7.Execute(context, ScriptTask7Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess11_a25d890e3c13448f943b7210574b644f":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask11_3a295464a1954edaae547f3f770cdfd5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask11_3a295464a1954edaae547f3f770cdfd5";
					result = ScriptTask11_3a295464a1954edaae547f3f770cdfd5.Execute(context, ScriptTask11_3a295464a1954edaae547f3f770cdfd5Execute);
					break;
				case "IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67.Execute(context);
					break;
				case "StartMessage4_c20452014444449cafb1aa4c68beac00":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_c20452014444449cafb1aa4c68beac00";
					result = StartMessage4_c20452014444449cafb1aa4c68beac00.Execute(context);
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
				case "ReportTypeId":
					ReportTypeId = reader.GetValue<System.Guid>();
				break;
				case "IsMSWordReport":
					IsMSWordReport = reader.GetValue<System.Boolean>();
				break;
				case "SelectedModuleId":
					SelectedModuleId = reader.GetValue<System.Guid>();
				break;
				case "SysModuleEntityId":
					SysModuleEntityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask8Execute(ProcessExecutingContext context) {
			if (UserConnection.SessionData["IsFileChanged"] == null || 
				!(bool)UserConnection.SessionData["IsFileChanged"]) {
				UserConnection.SessionData.Remove("IsFileChanged");
				return false;
			}
			
			UserMessageUserTask2.Page = Page;
			UserMessageUserTask2.MessageText = SaveFileTemplateQuestion;
			UserMessageUserTask2.Icon = "QUESTION";
			UserMessageUserTask2.Buttons = "YESNO";
			UserMessageUserTask2.ResponseMessages = new Dictionary<string, string> {
				{"yes", "SaveFileTemplateQuestionYesMessage"}
			};
			return true;
		}

		public virtual bool ScriptTask10Execute(ProcessExecutingContext context) {
			var script = new StringBuilder("var okButton = Ext.getCmp('");
			script.Append(Page.FakeSaveToFileButton.ClientID);
			script.Append("');");
			script.Append("okButton.fireEvent('click', okButton);");
			Page.AddScript(script.ToString());
			
			return true;
		}

		public virtual bool ScriptTask9Execute(ProcessExecutingContext context) {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") 
				as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleReport");
			var fileColumnName = entitySchemaQuery.AddColumn("File");
			var fileNameColumnName = entitySchemaQuery.AddColumn("Caption");
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, entitySchemaQuery.RootSchema.GetPrimaryColumnName(), 
				Page.DataSource.ActiveRowPrimaryColumnValue));
			var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
			foreach (var record in collection) {
				var data = record.GetColumnValue(fileColumnName.Name) as byte[];
				var Response = Page.Response;
				var fileName = string.Concat(record.GetTypedColumnValue<string>(fileNameColumnName.Name), ".docx");
				TSConfiguration.PageResponse.Write(Response, data, fileName, TSConfiguration.ContentType.StreamType);
			}
			
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count < 1) {
				return false;
			}
			
			Page.DataSource.LoadRow(new Guid(selectedNodes[0].Values["Id"].ToString()));
			if (Page.DataSource.Rows.Count < 1) {
				return false;
			}
			var currentRow = Page.DataSource.Rows[0];
			var typeId = new Guid(currentRow.GetColumnValue("TypeId").ToString());
			IsMSWordReport = typeId == new Guid("8BC259EF-4276-4906-B7A6-23DC59BE7FE2");
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			var currentRow = Page.DataSource.Rows[0];
			var data = currentRow.GetColumnValue("File") as byte[];
			var Response = System.Web.HttpContext.Current.Response;
			var fileName = string.Concat(currentRow.GetTypedColumnValue<string>("Caption"), ".docx");
			TSConfiguration.PageResponse.Write(Response, data, fileName, TSConfiguration.ContentType.XmlType);
			
			return true;
		}

		public virtual bool ScriptTask6Execute(ProcessExecutingContext context) {
			ShowNotMSWordReportUserTask2.Page = Page;
			ShowNotMSWordReportUserTask2.Icon = "WARNING";
			ShowNotMSWordReportUserTask2.Buttons = "OK";
			ShowNotMSWordReportUserTask2.WindowCaption = Warning;
			ShowNotMSWordReportUserTask2.MessageText = OperationNotSupported;
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			Page.AddButton.Enabled = SelectedModuleId != Guid.Empty; 
			SelectedNodePrimaryColumnValue = SelectedModuleId;
			return true;
		}

		public virtual bool DeleteYesMessageChildScriptTaskExecute(ProcessExecutingContext context) {
			Terrasoft.Configuration.SysModuleFolderUtilities.ResetModuleReportCache(UserConnection.SessionCache.WithLocalCaching(Terrasoft.Configuration.CacheUtilities.WorkspaceCacheGroup));
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			IsDetailGrid = true;
			
			return true;
		}

		public virtual bool ScriptTask7Execute(ProcessExecutingContext context) {
			Page.SaveToFileButton.AjaxEvents.Click.IsUpload = true;
			Page.FakeSaveToFileButton.AjaxEvents.Click.IsUpload = true;
			
			return true;
		}

		public virtual bool ScriptTask11_3a295464a1954edaae547f3f770cdfd5Execute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var reportTypeUIds = GetReportTypeUIds();
			var filter = dataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "Type", reportTypeUIds.Cast<object>().ToArray());
			dataSource.CurrentStructure.Filters.Add(filter);
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = base.GetButtons();
			buttons.Add(Page.SaveToFileButton.Name);
			return buttons;
		}

		public override void GetDefValues() {
			DefValuesId = SetDefValues();
			var defValues = UserConnection.SessionData[DefValuesId.ToString()] as Dictionary<string, object>;
			defValues["SysModule"] = SelectedModuleId;
			//Код, который компилируется только в Workspace CR173527,CR173547
			defValues["SysWorkspace"] = UserConnection.Workspace.Id;
		}

		public override Dictionary<string, string> GetEditPages() {
			TypeColumnUId = new Guid("94f2a9f7-55c7-4ecf-9b64-17583ddc058b");
			
			var typeEditPageUIds = new Dictionary<Guid, Dictionary<string, Guid>>();
			typeEditPageUIds.Add(new Guid("8BC259EF-4276-4906-B7A6-23DC59BE7FE2"),
				new Dictionary <string, Guid>() {
					{"EditPageUId", new Guid("41899fab-093e-4808-86db-5794b9836745")},
					{"SysModuleEditId", Guid.Empty}
				}
			);
			
			
			TypeEditPageUIds = typeEditPageUIds;
			
			var listEditPages = new Dictionary <string, string>();
			var key = "41899fab-093e-4808-86db-5794b9836745&8BC259EF-4276-4906-B7A6-23DC59BE7FE2"; //MSWord
			listEditPages[key] = MSWordDisplayValue.Value;
			return listEditPages;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			base.ModifyAddPageParameters(openPageParameters, queryStringParameters);
			var typeColumnUId = Page.DataSource.Schema.Columns.GetByName("Type").UId;
			string dataSourceClientId = "window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']]";
			queryStringParameters["ParentEntityId"] = dataSourceClientId + ".activeRow.getPrimaryColumnValue()";
			queryStringParameters["typeColumnUId"] = Json.Serialize(typeColumnUId);
			if (queryStringParameters["typeId"] == "\"8bc259ef42764906b7a623dc59be7fe2\"") {
				queryStringParameters["closeMessage"] = Json.Serialize("ReportEditPageClosed");
			}
		}

		public override void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			base.ModifyEditPageParameters(openPageParameters, queryStringParameters);
			var typeColumnUId = Page.DataSource.Schema.Columns.GetByName("Type").UId;
			string dataSourceClientId = "window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']]";
			queryStringParameters["ParentEntityId"] = dataSourceClientId + ".activeRow.getPrimaryColumnValue()";
			queryStringParameters["typeColumnUId"] = Json.Serialize(typeColumnUId);
			queryStringParameters["closeMessage"] = "ReportEditPageClosed";
		}

		public override void ModifyCopyPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			base.ModifyCopyPageParameters(openPageParameters, queryStringParameters);
			var typeColumnUId = Page.DataSource.Schema.Columns.GetByName("Type").UId;
			string dataSourceClientId = "window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']]";
			queryStringParameters["ParentEntityId"] = dataSourceClientId + ".activeRow.getPrimaryColumnValue()";
			queryStringParameters["typeColumnUId"] = Json.Serialize(typeColumnUId);
			queryStringParameters["closeMessage"] = "ReportEditPageClosed";
		}

		public virtual List<Guid> GetReportTypeUIds() {
			return new List<Guid> { new Guid("8BC259EF-4276-4906-B7A6-23DC59BE7FE2") };
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ReportEditPageClosed":
							if (ActivatedEventElements.Contains("ReportEditPageClosedStartMessage")) {
							context.QueueTasks.Enqueue("ReportEditPageClosedStartMessage");
						}
						break;
					case "SaveFileTemplateQuestionYesMessage":
							if (ActivatedEventElements.Contains("SaveFileTemplateQuestionYesMessageStartMessage")) {
							context.QueueTasks.Enqueue("SaveFileTemplateQuestionYesMessageStartMessage");
						}
						break;
					case "FakeSaveToFileButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "SaveToFileButtonClick":
							if (ActivatedEventElements.Contains("SaveToFileButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("SaveToFileButtonClickStartMessage");
						}
						break;
					case "DataSourceActiveRowChanged":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesChildMessage")) {
							context.QueueTasks.Enqueue("DeleteYesChildMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("StartMessage4_c20452014444449cafb1aa4c68beac00")) {
							context.QueueTasks.Enqueue("StartMessage4_c20452014444449cafb1aa4c68beac00");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ReportTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ReportTypeId", ReportTypeId, Guid.Empty);
			}
			if (!HasMapping("IsMSWordReport") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsMSWordReport", IsMSWordReport, false);
			}
			if (!HasMapping("SelectedModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedModuleId", SelectedModuleId, Guid.Empty);
			}
			if (!HasMapping("SysModuleEntityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleEntityId", SysModuleEntityId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportsGridPageEventsProcess : SysModuleReportsGridPageEventsProcess<Terrasoft.WebApp.SysModuleReportsGridPageSchemaUserControl>
	{

		public SysModuleReportsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button SaveToFileButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SaveToFileButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button FakeSaveToFileButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("FakeSaveToFileButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SaveToFileButton.AjaxEvents.Click.Event += SaveToFileButtonClick;
			FakeSaveToFileButton.AjaxEvents.Click.Event += FakeSaveToFileButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SaveToFileButton.AjaxEvents.Click.Event -= SaveToFileButtonClick;
			FakeSaveToFileButton.AjaxEvents.Click.Event -= FakeSaveToFileButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleReportsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportsGridPageEventsProcess(UserConnection);
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

		public virtual void SaveToFileButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SaveToFileButtonClick");
		}

		public virtual void FakeSaveToFileButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("FakeSaveToFileButtonClick");
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
			SchemaName = "SysModuleReportsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportsGridPageEventsProcessSchema(SysModuleReportsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportsGridPageEventsProcess";
			UId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef");
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

		protected override ProcessSchemaParameter CreateMailboxSyncSettingsLinkIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ed6b59a-be57-4f10-b1b4-0a2ce8323923"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"MailboxSyncSettingsLinkId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleEntityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8686535e-cdfb-42d8-b91c-da2e90c659f0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"SysModuleEntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fc5aa6e3-9f00-495b-8081-41f92647312e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"SelectedModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMSWordReportParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b55aae56-69a1-44e9-b5fc-95d0ad154752"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"IsMSWordReport",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateReportTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("41caf1c5-9a1c-46f4-9584-3b6967479ee9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ReportTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSysModuleEntityIdParameter());
			Parameters.Add(CreateSelectedModuleIdParameter());
			Parameters.Add(CreateIsMSWordReportParameter());
			Parameters.Add(CreateReportTypeIdParameter());
		}

		protected virtual void InitializeUserMessageUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3ad8e981-b54c-4aac-9b70-b248371217a1"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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
				UId = new Guid("78e8b660-aa08-48ff-8a81-db91996c71ce"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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
				UId = new Guid("09023e6c-d291-43cf-9433-67020b7548ba"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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
				UId = new Guid("a068eb47-f86a-40fe-a2a9-420167abb9b1"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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
				UId = new Guid("f9f35307-78ac-49a6-86fe-1b55570f2882"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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
				UId = new Guid("c317dc2a-8ccc-4f9a-8131-45b6cd3f9c00"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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
				UId = new Guid("232fcd4c-8cd5-4671-a51a-879126f27ce2"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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
				UId = new Guid("2c9b9f67-5f3d-4354-9a51-946cb85c1dd1"),
				ContainerUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
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

		protected virtual void InitializeShowNotMSWordReportUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e7074472-6854-4b94-b771-14f78a1104c4"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
				UId = new Guid("2b4dc29c-463f-449d-8a91-31e15539019b"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
				UId = new Guid("9ccff75a-92cf-462b-916c-f308e008ac96"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
				UId = new Guid("fde0d12b-2fe4-4475-9c13-a66f77579e10"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
				UId = new Guid("40238e1f-5fd8-4f5b-bd01-8264813a98f7"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
				UId = new Guid("58b35f92-47e6-4517-b4ff-f76bc40be499"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
				UId = new Guid("ee29b819-1463-4034-a880-331cfeddd33f"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
				UId = new Guid("52a8e905-713c-46bf-b725-b9c34e96dd27"),
				ContainerUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
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
			ProcessSchemaLaneSet schemaLaneSet578 = CreateLaneSet578LaneSet();
			LaneSets.Add(schemaLaneSet578);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet578.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess11_a25d890e3c13448f943b7210574b644f = CreateEventSubProcess11_a25d890e3c13448f943b7210574b644fEventSubProcess();
			FlowElements.Add(eventsubprocess11_a25d890e3c13448f943b7210574b644f);
			ProcessSchemaStartMessageEvent reporteditpageclosedstartmessage = CreateReportEditPageClosedStartMessageStartMessageEvent();
			eventsubprocess13.FlowElements.Add(reporteditpageclosedstartmessage);
			ProcessSchemaScriptTask scripttask8 = CreateScriptTask8ScriptTask();
			eventsubprocess13.FlowElements.Add(scripttask8);
			ProcessSchemaUserTask usermessageusertask2 = CreateUserMessageUserTask2UserTask();
			eventsubprocess13.FlowElements.Add(usermessageusertask2);
			ProcessSchemaStartMessageEvent savefiletemplatequestionyesmessagestartmessage = CreateSaveFileTemplateQuestionYesMessageStartMessageStartMessageEvent();
			eventsubprocess14.FlowElements.Add(savefiletemplatequestionyesmessagestartmessage);
			ProcessSchemaScriptTask scripttask10 = CreateScriptTask10ScriptTask();
			eventsubprocess14.FlowElements.Add(scripttask10);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess15.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask9 = CreateScriptTask9ScriptTask();
			eventsubprocess15.FlowElements.Add(scripttask9);
			ProcessSchemaStartMessageEvent savetofilebuttonclickstartmessage = CreateSaveToFileButtonClickStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(savetofilebuttonclickstartmessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess9.FlowElements.Add(exclusivegateway3);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask5);
			ProcessSchemaScriptTask scripttask6 = CreateScriptTask6ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask6);
			ProcessSchemaUserTask shownotmswordreportusertask2 = CreateShowNotMSWordReportUserTask2UserTask();
			eventsubprocess9.FlowElements.Add(shownotmswordreportusertask2);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage5);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent deleteyeschildmessage = CreateDeleteYesChildMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(deleteyeschildmessage);
			ProcessSchemaIntermediateThrowMessageEvent deleteyesbasemessage = CreateDeleteYesBaseMessageIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(deleteyesbasemessage);
			ProcessSchemaScriptTask deleteyesmessagechildscripttask = CreateDeleteYesMessageChildScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(deleteyesmessagechildscripttask);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess12.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask7 = CreateScriptTask7ScriptTask();
			eventsubprocess12.FlowElements.Add(scripttask7);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess12.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask11_3a295464a1954edaae547f3f770cdfd5 = CreateScriptTask11_3a295464a1954edaae547f3f770cdfd5ScriptTask();
			eventsubprocess11_a25d890e3c13448f943b7210574b644f.FlowElements.Add(scripttask11_3a295464a1954edaae547f3f770cdfd5);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessage1_604862da696648b3b4bdddf7d0828d67 = CreateIntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67IntermediateThrowMessageEvent();
			eventsubprocess11_a25d890e3c13448f943b7210574b644f.FlowElements.Add(intermediatethrowmessage1_604862da696648b3b4bdddf7d0828d67);
			ProcessSchemaStartMessageEvent startmessage4_c20452014444449cafb1aa4c68beac00 = CreateStartMessage4_c20452014444449cafb1aa4c68beac00StartMessageEvent();
			eventsubprocess11_a25d890e3c13448f943b7210574b644f.FlowElements.Add(startmessage4_c20452014444449cafb1aa4c68beac00);
			FlowElements.Add(CreateSequenceFlow12615SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12616SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12619SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12620SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15_30da596e22fd49b6a5894608c1ed6dceSequenceFlow());
			FlowElements.Add(CreateSequenceFlow17_0ac15c6608bf484db24b75b94c1bf6a2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOperationNotSupportedLocalizableString());
			LocalizableStrings.Add(CreateMSWordDisplayValueLocalizableString());
			LocalizableStrings.Add(CreateSaveFileTemplateQuestionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOperationNotSupportedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5c235175-3daf-4139-8bba-15012beb56ea"),
				Name = "OperationNotSupported",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMSWordDisplayValueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cd4ca18d-dcdc-45ea-8f2d-043675b458cd"),
				Name = "MSWordDisplayValue",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSaveFileTemplateQuestionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("40f42c03-6780-43ce-8b9e-df3a1dae11ac"),
				Name = "SaveFileTemplateQuestion",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12615SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12615",
				UId = new Guid("f6531b47-162b-4707-909c-b5ac079af57b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(192, 273),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42b9d99e-ba47-46f5-83cd-31fb7624a07d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0496b6c0-7ddc-456d-ae1e-75b63552f248"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12616SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12616",
				UId = new Guid("79820bcf-f955-4804-85b0-2ae52132c3ef"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(192, 273),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0496b6c0-7ddc-456d-ae1e-75b63552f248"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c31f9103-2be7-4ccc-9971-3fbfe09287a0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12619SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12619",
				UId = new Guid("c9d4704f-c94b-493f-ae14-ea3b5b4237f4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(144, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2e4d56b-1be6-42dd-bafd-a1cbea812f0a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3888e54-1231-469d-9ec9-d25f82f5fbab"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12620SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12620",
				UId = new Guid("9f929666-b3a7-4e9a-9f8d-6ddc449808f5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(269, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3888e54-1231-469d-9ec9-d25f82f5fbab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("073fdfe8-78e1-4788-9557-3cf0ee921bcd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b0fedfc2-f188-48ba-b979-8ae5f7b83989"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(594, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b8fe9ae0-dd5c-4052-8133-f1254bcbc69c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("10147362-b9c9-460f-8f8b-22a45be76e9f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("3669b1a9-8350-421d-8584-1ea51271b899"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(485, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0fe6e49e-d495-40b1-b204-b12bf151f9e8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8fe9ae0-dd5c-4052-8133-f1254bcbc69c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("21358627-45a4-4970-8e21-408eec5baf31"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc0c62b9-ea01-4b04-8ac3-fdf137172e02"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8d65461-ac39-4a93-8604-d3d292dc8370"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("16bb8b31-ec90-4c3d-b85c-857c7dd40e59"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(335, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8d65461-ac39-4a93-8604-d3d292dc8370"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("287f7d90-45f5-4470-bbc4-afd6e0f8409c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("9bd4190a-c97b-4b04-a77f-d7625eceeaac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(452, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("287f7d90-45f5-4470-bbc4-afd6e0f8409c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cbcba9f2-dc98-4350-b951-395c6359d6b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("92162d1a-5ef3-42ff-8fdb-d9910a467ef4"),
				ConditionExpression = @"!IsMSWordReport",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(438, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("287f7d90-45f5-4470-bbc4-afd6e0f8409c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("592b7731-28d4-476c-a073-9a672453f1ac"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("30f311e3-6591-43c1-8b17-039d7cdd2143"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(573, 179),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("592b7731-28d4-476c-a073-9a672453f1ac"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("89040f66-33ac-4c81-98c2-2f7aee84d108"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(174, 874),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8dee6722-8746-4b98-8874-fe5bbd6276ef"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e214b3ca-e3f0-4f6a-8bc8-aec93db78a7c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("739ab89b-e559-4cd7-bea7-089da68afc89"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(331, 872),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e214b3ca-e3f0-4f6a-8bc8-aec93db78a7c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77a344ee-d145-41dd-a979-3c37b41fc7a2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("05633b81-3b91-4741-99a9-e747465a90ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(207, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("57922a3f-e97e-4f23-9bd0-850515b88ad4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ec56277-3237-43d7-9204-b339dbe20b45"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("612e1491-e684-4960-8481-532e31f64b6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(364, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ec56277-3237-43d7-9204-b339dbe20b45"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("b7bd5dc6-4130-471a-af62-3d80d708caef"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(210, 460),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1782f20c-0ac5-4459-b466-e3bc77cb0d5d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a878a401-3c3a-4386-9bfe-6eb2ac258cdb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("b726f032-d912-4c0f-81ac-868e1e38a061"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(198, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("983a5889-66aa-4aba-901c-30582fc5000d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e97a699e-f8cb-4ff9-83e9-cb401d5e5d3b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15_30da596e22fd49b6a5894608c1ed6dceSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15_30da596e22fd49b6a5894608c1ed6dce",
				UId = new Guid("30da596e-22fd-49b6-a589-4608c1ed6dce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c2045201-4444-449c-afb1-aa4c68beac00"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3a295464-a195-4eda-ae54-7f3f770cdfd5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17_0ac15c6608bf484db24b75b94c1bf6a2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17_0ac15c6608bf484db24b75b94c1bf6a2",
				UId = new Guid("0ac15c66-08bf-484d-b24b-75b94c1bf6a2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3a295464-a195-4eda-ae54-7f3f770cdfd5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("604862da-6966-48b3-b4bd-ddf7d0828d67"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet578LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet578 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d80eb378-a306-4908-8b8e-114d12e42e8f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"LaneSet578",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(719, 367),
				UseBackgroundMode = false
			};
			return schemaLaneSet578;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d80eb378-a306-4908-8b8e-114d12e42e8f"),
				CreatedInOwnerSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(690, 367),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ec811c86-9d12-4d7f-a3f2-314f94a04ab6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(546, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateReportEditPageClosedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("57922a3f-e97e-4f23-9bd0-850515b88ad4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec811c86-9d12-4d7f-a3f2-314f94a04ab6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ReportEditPageClosed",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ReportEditPageClosedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask8ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7ec56277-3237-43d7-9204-b339dbe20b45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec811c86-9d12-4d7f-a3f2-314f94a04ab6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,49,111,194,48,16,133,231,70,202,127,184,122,74,36,148,161,107,154,14,5,42,101,40,20,18,6,132,58,184,112,132,168,198,70,62,135,22,1,255,189,103,154,169,146,135,78,231,59,191,239,157,253,218,45,36,11,66,59,52,90,227,218,181,70,103,21,18,113,29,73,39,87,162,164,151,86,225,112,39,117,131,27,241,14,69,1,186,83,10,46,23,136,163,187,251,228,195,24,149,254,195,32,133,51,115,97,32,155,227,222,28,49,249,195,165,57,83,22,93,103,53,108,165,34,228,254,26,71,113,228,157,94,25,151,13,250,99,45,233,243,33,123,227,14,10,240,37,15,72,250,65,141,223,142,149,149,60,162,95,87,227,254,160,164,195,89,135,228,95,22,162,203,181,209,140,137,217,98,92,213,229,116,34,66,194,231,206,57,163,201,107,151,227,106,50,13,10,231,72,7,22,98,127,225,9,141,95,48,106,111,9,73,123,122,36,103,91,221,12,224,183,62,221,114,60,139,19,146,24,128,8,125,96,137,212,59,10,142,235,202,219,251,16,157,237,48,255,1,219,209,116,107,253,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserMessageUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ac5ad389-aca6-46c5-81cd-50faf6bbedb0"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec811c86-9d12-4d7f-a3f2-314f94a04ab6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"UserMessageUserTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(309, 58),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserMessageUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b50c441a-73e0-49c5-b483-ae0313db5f6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 184),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveFileTemplateQuestionYesMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("983a5889-66aa-4aba-901c-30582fc5000d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b50c441a-73e0-49c5-b483-ae0313db5f6c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SaveFileTemplateQuestionYesMessage",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"SaveFileTemplateQuestionYesMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask10ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e97a699e-f8cb-4ff9-83e9-cb401d5e5d3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b50c441a-73e0-49c5-b483-ae0313db5f6c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(154, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,65,14,130,48,16,69,247,36,220,161,233,166,37,49,189,0,113,1,8,137,59,19,184,64,67,71,210,80,219,166,78,171,199,23,1,221,232,122,254,123,255,79,146,129,220,199,160,61,146,35,177,240,32,61,6,109,167,58,106,163,32,112,154,150,187,155,235,136,232,236,146,104,159,40,38,192,230,230,57,163,69,153,103,27,43,42,239,193,42,126,145,19,136,78,206,208,203,4,131,235,180,129,13,21,141,209,96,241,124,250,101,40,43,202,63,42,250,105,21,87,29,160,77,11,205,217,104,244,56,179,195,119,209,78,174,181,149,82,253,106,224,187,104,112,219,47,188,120,103,242,44,0,198,96,9,134,8,229,11,60,18,6,173,247,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c04701ef-2583-4f33-bc7f-68192da3aa0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess15",
				Position = new Point(35, 379),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1782f20c-0ac5-4459-b466-e3bc77cb0d5d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c04701ef-2583-4f33-bc7f-68192da3aa0c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FakeSaveToFileButtonClick",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"StartMessage2",
				Position = new Point(36, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask9ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a878a401-3c3a-4386-9bfe-6eb2ac258cdb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c04701ef-2583-4f33-bc7f-68192da3aa0c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,110,219,48,12,61,55,64,254,65,240,73,6,12,253,64,182,1,133,215,237,212,33,139,179,245,48,236,192,218,76,34,192,150,60,138,78,103,12,251,247,81,118,220,38,113,14,187,196,33,249,222,227,19,201,35,144,66,199,150,251,162,60,96,3,143,224,96,143,164,222,171,181,124,205,152,52,23,181,53,249,163,173,144,204,103,228,83,74,39,15,115,141,36,85,203,197,29,4,181,69,34,8,126,199,38,247,132,102,128,90,12,230,6,103,181,92,28,175,28,125,237,144,122,241,227,240,69,61,92,231,245,13,239,153,74,138,62,60,250,170,171,113,131,173,39,78,210,147,238,206,214,152,251,186,107,220,23,104,80,68,103,141,204,125,85,141,8,157,124,18,244,5,53,146,254,159,158,67,203,214,187,65,97,14,20,113,70,10,145,160,231,213,156,16,24,71,204,147,229,195,26,72,58,70,130,150,153,142,249,220,55,45,144,13,222,109,251,86,198,250,171,131,58,187,97,105,227,61,159,246,40,27,91,147,109,128,250,183,103,232,52,139,123,26,214,253,17,24,10,223,81,137,230,190,100,123,196,141,127,185,32,124,135,186,195,116,154,73,233,235,26,203,248,200,155,179,144,110,227,194,242,87,156,254,22,162,113,231,198,48,10,237,228,38,160,60,40,29,21,9,75,79,149,178,238,76,59,85,127,196,95,172,86,98,79,58,141,160,40,127,102,74,95,238,214,196,159,84,201,245,61,247,140,63,126,174,78,18,27,12,173,119,1,167,3,159,226,169,62,173,89,234,129,201,186,189,220,172,43,129,245,91,211,56,237,234,172,243,187,17,248,65,207,79,100,116,33,7,105,42,95,254,30,46,225,110,91,136,226,206,238,59,130,248,58,19,109,76,46,204,19,89,70,61,133,217,240,226,236,213,84,166,174,201,18,177,12,126,56,128,130,101,144,77,252,27,251,252,93,46,150,11,66,238,200,41,166,14,87,255,0,63,205,130,147,234,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess9",
				Position = new Point(35, 543),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(641, 242),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveToFileButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fc0c62b9-ea01-4b04-8ac3-fdf137172e02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SaveToFileButtonClick",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"SaveToFileButtonClickStartMessage",
				Position = new Point(36, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d8d65461-ac39-4a93-8604-d3d292dc8370"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask1",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,65,79,131,48,24,134,207,146,240,31,26,78,112,160,153,184,129,4,61,8,99,132,68,141,25,68,15,102,135,134,126,91,72,176,93,62,218,45,198,248,223,173,184,41,219,201,91,147,239,125,159,62,239,142,33,233,161,131,70,1,127,148,28,122,114,75,158,216,6,104,141,0,5,182,156,86,227,107,98,91,237,154,184,39,13,154,73,45,20,185,33,151,30,249,176,173,11,4,165,81,144,53,235,122,48,249,79,219,178,173,1,57,103,138,85,82,99,3,244,94,50,190,148,123,87,192,158,20,186,229,167,196,215,201,138,62,179,78,155,151,83,114,103,69,107,89,41,108,197,198,245,60,239,160,112,78,52,180,127,152,236,204,220,70,35,130,80,166,112,220,122,134,49,223,39,63,81,245,190,133,146,155,216,175,231,95,153,22,160,50,217,233,55,49,168,186,78,61,132,29,111,108,107,56,101,255,80,189,72,228,75,216,74,84,134,117,132,142,168,206,117,154,5,179,56,95,248,211,32,10,253,105,60,9,253,52,186,11,253,224,106,158,205,226,52,143,22,121,224,124,211,14,147,20,106,72,190,0,102,17,61,153,188,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("287f7d90-45f5-4470-bbc4-afd6e0f8409c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cbcba9f2-dc98-4350-b951-395c6359d6b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,205,106,195,48,16,132,239,129,188,131,208,201,6,179,228,158,182,23,151,180,167,80,226,208,20,66,15,27,123,99,4,182,100,86,171,52,126,251,74,78,221,191,147,88,237,124,179,51,23,100,85,7,102,178,178,115,31,234,94,189,96,75,240,136,130,149,11,92,19,196,95,127,92,189,175,151,139,75,148,54,113,17,69,63,4,60,145,148,174,11,189,125,197,46,80,166,55,166,35,157,43,244,234,52,10,29,103,112,71,126,112,214,83,132,171,209,11,245,112,160,19,60,139,12,165,179,66,87,129,242,230,9,179,242,11,60,71,191,45,246,9,244,194,198,182,16,129,26,37,251,155,97,63,14,212,252,10,114,119,19,63,100,186,196,65,140,179,58,47,148,134,198,213,87,157,71,235,125,21,109,206,166,13,140,105,11,169,246,124,25,14,108,132,178,121,44,166,214,197,119,146,66,253,135,167,10,118,202,0,111,125,151,222,116,99,185,96,146,192,86,9,7,90,127,2,57,218,241,230,106,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("592b7731-28d4-476c-a073-9a672453f1ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,206,65,10,194,48,16,5,208,189,224,29,66,15,224,194,109,233,66,93,72,145,166,210,84,178,14,102,168,69,152,9,147,9,245,248,38,30,192,172,102,243,254,255,99,94,180,105,146,193,88,98,63,65,32,150,71,4,158,93,124,31,15,119,183,128,234,84,57,237,126,103,254,209,254,73,152,105,99,79,147,238,245,181,169,249,115,18,33,140,37,50,222,170,218,174,232,105,187,184,32,235,111,198,58,198,21,151,90,108,128,24,243,239,51,124,36,135,198,0,236,74,65,246,38,133,66,193,231,10,6,73,140,74,56,65,251,5,96,102,204,221,15,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowNotMSWordReportUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("97fd0034-6559-4785-8190-94623a646121"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("994c143d-2fad-4bd7-b033-141e704760af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ShowNotMSWordReportUserTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(533, 142),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowNotMSWordReportUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f00c8afa-fa88-45ab-873a-30adcab7142c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess8",
				Position = new Point(35, 811),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d2e4d56b-1be6-42dd-bafd-a1cbea812f0a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f00c8afa-fa88-45ab-873a-30adcab7142c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"StartMessage5",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("073fdfe8-78e1-4788-9557-3cf0ee921bcd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f00c8afa-fa88-45ab-873a-30adcab7142c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"IntermediateThrowMessageEvent3",
				Position = new Point(232, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d3888e54-1231-469d-9ec9-d25f82f5fbab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f00c8afa-fa88-45ab-873a-30adcab7142c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,204,49,10,131,64,16,5,208,222,83,140,23,216,11,44,22,70,150,144,34,34,8,233,55,206,39,8,179,187,50,204,20,222,222,202,46,253,227,45,249,135,48,50,63,220,172,213,144,106,254,10,152,6,90,33,216,12,252,110,236,130,23,83,63,208,211,119,14,169,28,118,70,234,110,48,55,198,162,123,201,122,78,77,188,212,79,22,199,159,33,118,10,115,173,100,234,136,23,154,205,169,31,121,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3d1bc8ee-bd99-4aef-9a40-31a6c98bbfae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 961),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(312, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesChildMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0fe6e49e-d495-40b1-b204-b12bf151f9e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d1bc8ee-bd99-4aef-9a40-31a6c98bbfae"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"DeleteYesChildMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDeleteYesBaseMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b8fe9ae0-dd5c-4052-8133-f1254bcbc69c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d1bc8ee-bd99-4aef-9a40-31a6c98bbfae"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"DeleteYesBaseMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteYesMessageChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("10147362-b9c9-460f-8f8b-22a45be76e9f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d1bc8ee-bd99-4aef-9a40-31a6c98bbfae"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"DeleteYesMessageChildScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,77,59,14,130,64,16,237,77,188,131,37,52,123,1,74,18,109,180,65,8,245,102,121,192,196,205,14,153,153,45,188,189,184,20,86,86,47,239,223,67,196,43,207,230,90,78,51,45,89,188,17,39,247,124,235,131,167,28,113,229,56,65,6,163,72,70,80,215,65,97,135,213,97,99,177,214,135,21,213,160,144,125,33,33,28,117,168,238,88,60,55,146,173,119,14,62,126,41,165,165,234,255,156,150,248,239,106,100,121,233,230,3,138,126,19,206,91,93,55,231,147,192,178,164,139,73,70,243,1,141,29,62,112,192,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7be07856-137e-4742-9581-5982c25cd9f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 1149),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(353, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("42b9d99e-ba47-46f5-83cd-31fb7624a07d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7be07856-137e-4742-9581-5982c25cd9f8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0496b6c0-7ddc-456d-ae1e-75b63552f248"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7be07856-137e-4742-9581-5982c25cd9f8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,118,73,45,73,204,204,113,47,202,76,81,176,85,40,41,42,77,181,230,229,226,229,42,74,45,41,45,202,131,240,1,124,4,60,124,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c31f9103-2be7-4ccc-9971-3fbfe09287a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7be07856-137e-4742-9581-5982c25cd9f8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eaf48617-2725-41d6-877b-5ee8f52bedd5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 1324),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8dee6722-8746-4b98-8874-fe5bbd6276ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaf48617-2725-41d6-877b-5ee8f52bedd5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask7ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e214b3ca-e3f0-4f6a-8bc8-aec93db78a7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaf48617-2725-41d6-877b-5ee8f52bedd5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,78,44,75,13,201,119,203,204,73,117,42,45,41,201,207,211,115,204,74,172,112,45,75,205,43,41,214,115,206,201,76,206,214,243,44,14,45,200,201,79,76,81,176,85,40,41,42,77,181,230,229,10,0,105,116,75,204,78,37,71,51,47,87,81,106,73,105,81,30,132,15,0,129,182,149,93,132,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("77a344ee-d145-41dd-a979-3c37b41fc7a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaf48617-2725-41d6-877b-5ee8f52bedd5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11_a25d890e3c13448f943b7210574b644fEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11_a25d890e3c13448f943b7210574b644f = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a25d890e-3c13-448f-943b-7210574b644f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04f148e8-80cd-4cfa-b659-569ab03b0536"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"EventSubProcess11_a25d890e3c13448f943b7210574b644f",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(20, 1538),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(351, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11_a25d890e3c13448f943b7210574b644f;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask11_3a295464a1954edaae547f3f770cdfd5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3a295464-a195-4eda-ae54-7f3f770cdfd5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a25d890e-3c13-448f-943b-7210574b644f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"ScriptTask11_3a295464a1954edaae547f3f770cdfd5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(107, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,205,14,130,48,16,132,239,62,69,227,169,36,164,47,128,154,16,252,137,55,34,24,207,43,93,21,3,20,183,91,18,222,222,98,19,255,142,51,251,237,204,12,64,66,3,67,97,28,85,40,150,34,135,43,170,245,219,73,102,131,39,8,123,67,92,142,61,30,247,218,122,106,135,124,248,241,100,20,200,75,221,48,146,39,62,161,42,35,4,198,237,235,114,170,249,150,3,65,139,94,88,25,204,204,180,61,80,109,77,55,197,169,205,195,65,19,139,249,36,230,241,95,185,202,192,242,194,156,239,88,241,74,70,170,52,41,17,140,50,242,3,190,59,29,17,118,92,48,185,138,29,161,10,77,86,165,90,203,48,210,63,16,250,91,39,60,132,201,19,204,182,46,224,10,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("604862da-6966-48b3-b4bd-ddf7d0828d67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a25d890e-3c13-448f-943b-7210574b644f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"IntermediateThrowMessage1_604862da696648b3b4bdddf7d0828d67",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(224, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4_c20452014444449cafb1aa4c68beac00StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c2045201-4444-449c-afb1-aa4c68beac00"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a25d890e-3c13-448f-943b-7210574b644f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				Name = @"StartMessage4_c20452014444449cafb1aa4c68beac00",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(38, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetReportTypeUIdsMethod());
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

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,72,74,44,78,213,115,79,45,113,130,136,104,104,90,115,65,37,245,28,83,82,52,2,18,211,83,245,130,19,203,82,67,242,221,50,115,82,33,170,244,252,18,115,83,129,10,139,82,75,74,139,242,96,134,89,3,0,186,10,120,46,89,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,77,11,75,204,41,77,45,246,76,81,176,85,8,78,45,113,129,9,104,104,90,243,114,149,37,22,41,164,192,68,128,10,66,139,83,139,156,243,243,242,82,147,75,50,243,243,244,130,83,139,139,129,180,75,98,73,98,180,11,194,36,189,144,252,224,146,162,204,188,116,13,205,88,133,196,98,5,151,76,176,242,196,162,74,155,98,176,184,142,66,126,82,22,208,12,59,160,21,112,227,163,149,130,43,139,125,243,83,74,115,82,149,98,193,142,201,1,42,73,77,129,8,121,166,0,213,234,235,95,152,117,97,223,133,45,58,10,23,118,93,216,119,177,9,136,27,46,118,95,216,9,230,94,216,115,97,255,133,29,23,118,95,216,1,20,108,190,176,245,98,211,197,198,139,253,10,32,85,23,118,95,236,1,41,81,184,176,73,33,60,191,40,187,184,32,49,57,85,193,57,200,208,220,216,212,200,92,7,194,48,49,71,119,12,92,41,216,61,104,126,135,75,234,1,157,6,0,125,201,56,87,71,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetEditPagesMethod() {
			SchemaMethod method = base.CreateGetEditPagesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,77,107,131,48,24,199,207,21,252,14,226,97,40,152,214,106,98,18,186,21,250,98,199,14,133,65,187,237,48,118,80,19,139,204,106,241,101,67,74,191,251,162,110,171,182,151,30,146,64,242,228,247,127,217,86,7,190,72,227,114,159,188,60,49,229,65,73,248,183,242,88,70,76,83,41,12,45,143,134,24,32,20,96,0,121,16,2,234,59,16,140,49,34,54,99,129,137,136,175,234,19,89,146,165,47,47,83,10,1,114,89,84,60,123,59,46,80,249,47,107,25,5,69,148,38,94,86,221,215,88,163,123,145,23,89,148,236,140,70,111,58,213,106,214,37,101,56,99,76,59,123,34,243,133,133,168,187,2,208,194,14,128,212,116,192,28,207,28,96,217,203,5,162,115,23,175,92,75,213,13,89,26,244,181,149,190,150,166,43,71,49,51,56,170,29,45,213,232,132,135,99,66,105,232,249,192,164,54,7,144,152,4,16,135,249,0,97,10,125,74,108,7,67,164,234,39,163,165,108,170,124,157,178,50,110,172,55,164,154,50,116,247,135,162,58,137,17,177,218,162,100,105,123,93,211,101,230,255,74,227,40,47,254,30,174,251,60,103,106,207,182,192,250,223,39,175,196,244,77,25,238,110,106,116,162,140,70,235,205,91,154,49,89,234,153,122,23,82,31,66,171,125,92,70,249,33,246,170,87,47,46,249,176,217,133,161,140,23,101,150,244,179,76,126,0,4,216,139,197,118,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = base.CreateModifyAddPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,209,75,195,48,16,198,159,29,236,127,8,121,105,139,18,164,110,157,67,124,208,57,101,194,100,172,234,203,54,36,77,174,51,208,54,51,73,55,163,248,191,155,172,224,24,204,189,29,199,125,191,239,187,187,140,106,32,99,201,69,110,111,56,159,208,37,76,168,162,37,24,80,58,148,43,168,246,91,103,232,163,6,101,83,163,68,181,220,181,163,171,118,107,77,21,50,118,5,3,89,212,101,245,50,226,232,26,121,49,185,163,134,166,178,86,12,72,202,222,161,164,164,25,209,228,1,204,173,125,114,140,16,63,59,37,142,136,147,57,148,222,226,17,255,19,14,10,1,149,217,34,241,70,84,92,110,102,195,79,67,56,48,201,33,244,229,18,76,24,176,90,27,89,122,191,123,1,5,15,34,194,101,73,214,180,168,33,154,5,169,213,110,209,186,128,55,202,140,88,195,46,87,176,88,96,103,123,112,181,25,118,181,51,31,86,70,24,59,226,120,225,66,28,72,118,138,48,105,184,83,185,241,113,38,74,148,84,217,102,215,87,159,33,140,142,184,236,157,110,107,242,168,101,69,82,80,130,22,226,11,194,189,1,127,112,145,163,240,8,172,161,184,131,205,241,101,198,226,110,31,242,78,220,75,58,253,243,36,235,209,36,190,224,172,219,207,160,151,67,60,199,56,66,223,237,214,201,63,56,86,72,13,99,208,218,189,243,80,52,60,133,149,84,102,200,133,241,31,31,248,113,142,125,198,159,95,198,44,246,201,96,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = base.CreateModifyEditPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,193,78,132,48,16,134,239,251,20,164,23,32,154,190,0,241,34,162,89,147,53,100,81,47,132,152,74,71,108,82,90,108,7,176,62,189,45,68,55,36,187,183,201,116,254,239,255,103,250,206,44,208,131,230,226,195,21,92,96,201,58,40,153,97,61,32,24,155,232,1,212,182,117,29,125,141,96,92,133,70,168,238,212,78,179,221,196,76,132,110,128,92,203,177,87,47,123,30,221,68,65,75,239,24,178,74,143,166,5,90,181,159,208,51,186,142,88,250,0,120,235,158,60,34,33,207,94,73,82,234,101,217,206,46,240,136,255,235,114,41,64,225,66,36,179,80,92,207,117,241,141,148,67,171,57,36,161,236,0,147,184,29,45,234,62,216,221,11,144,60,78,41,215,61,157,152,28,33,173,227,202,89,191,231,40,225,141,181,40,38,56,197,138,155,134,100,187,179,123,213,196,215,222,187,80,40,208,237,57,105,124,134,51,193,174,34,66,87,236,81,207,33,77,105,68,207,140,91,55,125,13,17,146,244,178,201,230,110,139,199,163,213,138,86,96,4,147,226,7,146,205,64,122,145,211,74,109,225,0,214,250,187,47,24,114,132,65,27,252,251,218,60,188,115,146,253,2,163,252,248,49,246,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyCopyPageParametersMethod() {
			SchemaMethod method = base.CreateModifyCopyPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,193,78,195,48,12,134,239,123,138,42,151,182,2,229,5,42,46,148,129,134,52,84,173,192,165,170,80,214,152,18,41,141,75,226,174,132,167,39,233,36,166,73,219,205,114,252,127,255,111,103,47,28,240,45,74,245,233,75,28,125,37,122,168,132,21,3,16,88,151,225,8,230,188,117,155,124,79,96,125,77,86,153,254,212,206,139,213,65,216,132,252,8,37,234,105,48,111,27,153,220,37,81,203,31,4,137,26,39,219,1,175,187,47,24,4,63,142,56,254,4,116,239,95,2,34,99,175,65,201,114,30,100,197,202,45,240,68,254,235,74,173,192,208,66,100,179,50,18,231,102,253,67,92,66,135,18,178,88,246,64,89,218,77,142,112,136,118,143,10,180,76,115,46,113,224,7,161,39,200,155,180,246,46,236,57,105,248,16,29,169,3,156,98,165,109,203,138,213,197,189,26,22,234,224,189,54,164,200,111,36,107,67,134,11,193,110,18,198,143,216,29,206,49,77,101,213,32,172,63,110,250,30,35,100,249,117,147,179,187,45,30,207,14,13,175,193,42,161,213,47,100,103,3,249,85,78,167,209,193,22,156,11,119,95,48,108,7,35,90,90,75,69,241,47,202,248,46,89,241,7,136,48,116,155,246,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetReportTypeUIdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("be7e2ed4-6e89-495d-be5f-22bbe96421a1"),
				Name = "GetReportTypeUIds",
				CreatedInSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,240,201,44,46,177,113,47,205,76,177,83,168,6,11,128,216,26,74,22,78,206,70,166,150,174,110,186,38,70,230,102,186,38,150,6,102,186,78,230,142,102,186,70,198,46,206,166,150,78,174,230,110,174,70,74,154,10,181,214,0,49,235,6,126,75,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"));
		}

		#endregion

	}

	#endregion

}

