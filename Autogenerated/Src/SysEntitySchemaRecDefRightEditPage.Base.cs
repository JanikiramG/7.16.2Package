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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysEntitySchemaRecDefRightEditPageSchema

	/// <exclude/>
	public class SysEntitySchemaRecDefRightEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _authorEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit AuthorEdit {
			get {
				return _authorEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _granteeEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit GranteeEdit {
			get {
				return _granteeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SysEntitySchemaRecDefRightEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysEntitySchemaRecDefRightEditPageSchema(SysEntitySchemaRecDefRightEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			RealUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			Name = "SysEntitySchemaRecDefRightEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 200;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntitySchemaRecDefRightEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateAuthorEdit());
			MainControlLayout.InsertItem(1, CreateGranteeEdit());
			MainControlLayout.MoveItem(2, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysEntitySchemaRecDefRightEditPageEventsProcessSchema() {
			var schema = new SysEntitySchemaRecDefRightEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateAuthorEdit() {
			_authorEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_authorEdit.UId = new Guid("0ddba7b8-4f36-4da0-80ef-734d960bcedd");
			_authorEdit.Name = "AuthorEdit";
			_authorEdit.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			_authorEdit.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			_authorEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_authorEdit.Tag = "";
			_authorEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_authorEdit.Image = new ControlImage {};
			_authorEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_authorEdit.LookupSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			return _authorEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateGranteeEdit() {
			_granteeEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_granteeEdit.UId = new Guid("c02bb6c4-82c7-4dc2-a388-543bc5ecfb1c");
			_granteeEdit.Name = "GranteeEdit";
			_granteeEdit.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			_granteeEdit.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			_granteeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_granteeEdit.Tag = "";
			_granteeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_granteeEdit.Image = new ControlImage {};
			_granteeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_granteeEdit.LookupSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			return _granteeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8");
			DataSource.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("73fe960e-9843-43b2-b80a-beed7eabc11a");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("265ba930-6a82-4231-bf54-037c3fcc8010");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("a8bef019-6200-4b1a-be54-bcfd56b87b93");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a664cd58-5f8c-440e-9c83-b60609b838a7");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("3327450f-ea31-40f7-9a96-9ed15103b098");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("da2e27e4-45dc-4041-949e-25041f52bc84");
			if (column != null) {
				column.UId = new Guid("0ddea623-fcd9-4a38-b5c5-91885f01f9f0");
				column.Name = @"Author";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4d59ed87-eb02-40c1-a313-093a1d56427d");
			if (column != null) {
				column.UId = new Guid("ac19b4be-b0f7-4174-ae21-d23a50794b7c");
				column.Name = @"Grantee";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("aad5dad3-f79d-4259-b41e-28091d8ba81a");
			if (column != null) {
				column.UId = new Guid("87167062-8d3c-4ad0-a596-b6d6069ba98c");
				column.Name = @"Operation";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("dfe9fd43-db84-4526-8206-131381e9effa");
			if (column != null) {
				column.UId = new Guid("aa45cc8b-b146-4b62-97bb-ca185f3a4631");
				column.Name = @"RightLevel";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("04aaec36-56c3-44a5-8e2c-49a52c23d99b");
			if (column != null) {
				column.UId = new Guid("544afd4b-b96a-4016-b7dd-cbc06d83b9d3");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0e13b37d-f7ae-4127-8749-01c1e67487b9");
			if (column != null) {
				column.UId = new Guid("f2a3977c-a3b7-4c08-bb99-6b6b602fb2c4");
				column.Name = @"SubjectSchemaUId";
				column.CreatedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
				column.ModifiedInSchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
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
			return new SysEntitySchemaRecDefRightEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysEntitySchemaRecDefRightEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysEntitySchemaRecDefRightEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecDefRightEditPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecDefRightEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysEntitySchemaRecDefRightEditPageSchemaUserControl
	{

		#region Class: UserTaskChildRefreshGridFlowElement

		/// <exclude/>
		public class UserTaskChildRefreshGridFlowElement : TreeGridLoadRowUserTask
		{

			public UserTaskChildRefreshGridFlowElement(UserConnection userConnection, SysEntitySchemaRecDefRightEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskChildRefreshGrid";
				IsLogging = false;
				SchemaElementUId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SysEntitySchemaRecDefRightEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaRecDefRightEditPageEventsProcess";
			SchemaUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
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

		public virtual int Operation {
			get;
			set;
		}

		public virtual int RightLevel {
			get;
			set;
		}

		public virtual Guid GranteeId {
			get;
			set;
		}

		public virtual Guid AuthorId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessChildOkButtonClick;
		public ProcessFlowElement EventSubProcessChildOkButtonClick {
			get {
				return _eventSubProcessChildOkButtonClick ?? (_eventSubProcessChildOkButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildOkButtonClick",
					SchemaElementUId = new Guid("efc4d6de-1ceb-49db-96f3-7369eb154b2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildOKButtonClick;
		public ProcessFlowElement StartMessageChildOKButtonClick {
			get {
				return _startMessageChildOKButtonClick ?? (_startMessageChildOKButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildOKButtonClick",
					SchemaElementUId = new Guid("48d1a0be-94bd-4eca-9208-49a82ab20ab7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("a346dd03-34ee-4d76-9174-790cdd84c010"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildOkButtonClickExecute,
				});
			}
		}

		private UserTaskChildRefreshGridFlowElement _userTaskChildRefreshGrid;
		public UserTaskChildRefreshGridFlowElement UserTaskChildRefreshGrid {
			get {
				return _userTaskChildRefreshGrid ?? (_userTaskChildRefreshGrid = new UserTaskChildRefreshGridFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptChildClose;
		public ProcessScriptTask ScriptChildClose {
			get {
				return _scriptChildClose ?? (_scriptChildClose = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildClose",
					SchemaElementUId = new Guid("e12c0eff-9d0a-4a7b-8792-9dc67c9f3080"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildCloseExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildPageLoadComplete;
		public ProcessFlowElement EventSubProcessChildPageLoadComplete {
			get {
				return _eventSubProcessChildPageLoadComplete ?? (_eventSubProcessChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildPageLoadComplete",
					SchemaElementUId = new Guid("2e1e9c66-d1d7-4403-b491-c53c1d9b81c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildpageLoadComplete;
		public ProcessFlowElement StartMessageChildpageLoadComplete {
			get {
				return _startMessageChildpageLoadComplete ?? (_startMessageChildpageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildpageLoadComplete",
					SchemaElementUId = new Guid("d52eabca-af95-4ceb-b229-c36a1c2f856e"),
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
					SchemaElementUId = new Guid("47b45905-e369-453f-993a-0ef805c01336"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessChildOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildOkButtonClick };
			FlowElements[StartMessageChildOKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildOKButtonClick };
			FlowElements[ScriptChildOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildOkButtonClick };
			FlowElements[UserTaskChildRefreshGrid.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskChildRefreshGrid };
			FlowElements[ScriptChildClose.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildClose };
			FlowElements[EventSubProcessChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildPageLoadComplete };
			FlowElements[StartMessageChildpageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildpageLoadComplete };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessChildOkButtonClick":
						break;
					case "StartMessageChildOKButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptChildOkButtonClick");
						break;
					case "ScriptChildOkButtonClick":
						e.Context.QueueTasks.Enqueue("UserTaskChildRefreshGrid");
						break;
					case "UserTaskChildRefreshGrid":
							e.Context.QueueTasks.Enqueue("ScriptChildClose");
						break;
					case "ScriptChildClose":
						break;
					case "EventSubProcessChildPageLoadComplete":
						break;
					case "StartMessageChildpageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "ScriptChildPageLoadComplete":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageChildOKButtonClick");
			ActivatedEventElements.Add("StartMessageChildpageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessChildOkButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildOKButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildOKButtonClick";
					result = StartMessageChildOKButtonClick.Execute(context);
					break;
				case "ScriptChildOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildOkButtonClick";
					result = ScriptChildOkButtonClick.Execute(context, ScriptChildOkButtonClickExecute);
					break;
				case "UserTaskChildRefreshGrid":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskChildRefreshGrid";
					result = UserTaskChildRefreshGrid.Execute(context);
					break;
				case "ScriptChildClose":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildClose";
					result = ScriptChildClose.Execute(context, ScriptChildCloseExecute);
					break;
				case "EventSubProcessChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildpageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildpageLoadComplete";
					result = StartMessageChildpageLoadComplete.Execute(context);
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
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
				case "AuthorId":
					AuthorId = reader.GetValue<System.Guid>();
				break;
				case "GranteeId":
					GranteeId = reader.GetValue<System.Guid>();
				break;
				case "RightLevel":
					RightLevel = reader.GetValue<System.Int32>();
				break;
				case "Operation":
					Operation = reader.GetValue<System.Int32>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptChildOkButtonClickExecute(ProcessExecutingContext context) {
			var authorId = Page.AuthorEdit.Value == null ? Guid.Empty : new Guid(Page.AuthorEdit.Value.ToString());
			var granteeId = Page.GranteeEdit.Value == null ? Guid.Empty : new Guid(Page.GranteeEdit.Value.ToString());
			var schemaName = UserConnection.EntitySchemaManager.GetItemByUId(EntitySchemaUId).Name;
			if (IsNew) {
				EntityPrimaryColumnValue = UserConnection.DBSecurityEngine.SetEntitySchemaRecordDefRightLevel(authorId, granteeId,
					EntitySchemaUId, (Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation) Operation, 
						(Terrasoft.Core.Configuration.EntitySchemaRecordRightLevel) RightLevel);
			} else {
				Query update = new Update(UserConnection, "SysEntitySchemaRecordDefRight")
					.Set("AuthorSysAdminUnitId", Column.Parameter(authorId))
					.Set("GranteeSysAdminUnitId", Column.Parameter(granteeId))
					.Where("Id").IsEqual(Column.Parameter(EntityPrimaryColumnValue));
				update.Execute();
				OperationLogger.Instance.LogEntitySchemaRecordDefRightEdit(UserConnection, EntityPrimaryColumnValue);
			}
			var treeGridId = Page.GetParameterValue("treeGridId") == null ? String.Empty :
											Page.GetParameterValue("treeGridId").ToString();
			UserTaskChildRefreshGrid.Page = Page;
			UserTaskChildRefreshGrid.TreeGridClientID = treeGridId;
			UserTaskChildRefreshGrid.PrimaryColumnValue = EntityPrimaryColumnValue;
			return true;
		}

		public virtual bool ScriptChildCloseExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageSolution");
			Page.AuthorEdit.Required = true;
			Page.GranteeEdit.Required = true;
			var recordIdObj = Page.GetParameterValue("recordId");
			var schemaIdObj = Page.GetParameterValue("ParentEntityId");
			var operation = Page.GetParameterValue("operation");
			if (new Guid(recordIdObj.ToString()) == Guid.Empty) {
				EntityPrimaryColumnValue = Guid.NewGuid();
				EntitySchemaUId = WorkspaceUtilities.GetSchemaUIdById(new Guid(schemaIdObj.ToString()), UserConnection);
				Operation = Convert.ToInt32(operation.ToString());
				RightLevel = 1;
				IsNew = true;
			} else {
				EntityPrimaryColumnValue = new Guid(recordIdObj.ToString());
				GetRightInfo();
			}
			return true;
		}

		public virtual void GetRightInfo() {
			var select = new Terrasoft.Core.DB.Select(Page.UserConnection)
				.Column("SysEntitySchemaRecordDefRight", "Id")
				.Column("SysEntitySchemaRecordDefRight", "SubjectSchemaUId")
				.Column("Author", "Id").As("AuthorId")
				.Column("Author", "Name").As("AuthorName")
				.Column("Grantee", "Id").As("GranteeId")
				.Column("Grantee", "Name").As("GranteeName")
				.Column("SysEntitySchemaRecordDefRight", "Operation").As("Operation")
				.Column("SysEntitySchemaRecordDefRight", "RightLevel").As("RightLevel")
				.Column("Position").As("Position")
				.From("SysEntitySchemaRecordDefRight")
				.InnerJoin("SysAdminUnit").As("Author").On("Author", "Id").IsEqual("SysEntitySchemaRecordDefRight", "AuthorSysAdminUnitId")
				.InnerJoin("SysAdminUnit").As("Grantee").On("Grantee", "Id").IsEqual("SysEntitySchemaRecordDefRight", "GranteeSysAdminUnitId")
				.Where("SysEntitySchemaRecordDefRight", "Id").IsEqual(Terrasoft.Core.DB.Column.Parameter(EntityPrimaryColumnValue)) 
				as Terrasoft.Core.DB.Select;;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						int ordinal = reader.GetOrdinal("GranteeId");
						GranteeId = new Guid(reader.GetValue(ordinal).ToString());
						ordinal = reader.GetOrdinal("GranteeName");
						var granteeName = reader.GetValue(ordinal).ToString();
						Page.GranteeEdit.SetValueAndText(GranteeId, granteeName);
						ordinal = reader.GetOrdinal("AuthorId");
						AuthorId = new Guid(reader.GetValue(ordinal).ToString());
						ordinal = reader.GetOrdinal("AuthorName");
						var authorName = reader.GetValue(ordinal).ToString();
						Page.AuthorEdit.SetValueAndText(AuthorId, authorName);
						ordinal = reader.GetOrdinal("Operation");
						Operation = Convert.ToInt32(reader.GetValue(ordinal).ToString());
						ordinal = reader.GetOrdinal("RightLevel");
						RightLevel = Convert.ToInt32(reader.GetValue(ordinal).ToString());			
						ordinal = reader.GetOrdinal("SubjectSchemaUId");
						EntitySchemaUId = new Guid(reader.GetValue(ordinal).ToString());			
					}
				}
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("StartMessageChildOKButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageChildOKButtonClick");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageChildpageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageChildpageLoadComplete");
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
			if (!HasMapping("AuthorId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AuthorId", AuthorId, Guid.Empty);
			}
			if (!HasMapping("GranteeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("GranteeId", GranteeId, Guid.Empty);
			}
			if (!HasMapping("RightLevel") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RightLevel", RightLevel, 0);
			}
			if (!HasMapping("Operation") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("Operation", Operation, 0);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecDefRightEditPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecDefRightEditPageEventsProcess : SysEntitySchemaRecDefRightEditPageEventsProcess<Terrasoft.WebApp.SysEntitySchemaRecDefRightEditPageSchemaUserControl>
	{

		public SysEntitySchemaRecDefRightEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaRecDefRightEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysEntitySchemaRecDefRightEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit AuthorEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("AuthorEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit GranteeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("GranteeEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysEntitySchemaRecDefRightEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysEntitySchemaRecDefRightEditPageEventsProcess(UserConnection);
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
			SchemaName = "SysEntitySchemaRecDefRightEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecDefRightEditPageEventsProcessSchema

	/// <exclude/>
	public class SysEntitySchemaRecDefRightEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntitySchemaRecDefRightEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntitySchemaRecDefRightEditPageEventsProcessSchema(SysEntitySchemaRecDefRightEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntitySchemaRecDefRightEditPageEventsProcess";
			UId = new Guid("d55985fe-dd01-451f-b341-6ba191920117");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateOperationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b781f966-0102-41e3-b295-b0d17848b220"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"Operation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRightLevelParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a1b6929e-b13f-46fe-9441-815d0bc15de9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"RightLevel",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGranteeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7766bb1a-a9ae-4b4a-8c57-069a0a5b1cee"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"GranteeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAuthorIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("01538918-f8df-4362-bfef-40fc48ce875e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"AuthorId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateOperationParameter());
			Parameters.Add(CreateRightLevelParameter());
			Parameters.Add(CreateGranteeIdParameter());
			Parameters.Add(CreateAuthorIdParameter());
		}

		protected virtual void InitializeUserTaskChildRefreshGridParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fee618df-02fc-433c-9cd8-684c4c23ad27"),
				ContainerUId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
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
				UId = new Guid("dd8e3364-0bd4-4fbe-b996-1f9774d91581"),
				ContainerUId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"TreeGridClientID",
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
				UId = new Guid("90a0d866-0744-4873-b1e1-2c2d52381d7a"),
				ContainerUId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"PrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("18452725-27b7-436e-86bc-338854c9abb0"),
				ContainerUId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"LoadRows",
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocesschildokbuttonclick = CreateEventSubProcessChildOkButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocesschildokbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocesschildpageloadcomplete = CreateEventSubProcessChildPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocesschildpageloadcomplete);
			ProcessSchemaStartMessageEvent startmessagechildokbuttonclick = CreateStartMessageChildOKButtonClickStartMessageEvent();
			eventsubprocesschildokbuttonclick.FlowElements.Add(startmessagechildokbuttonclick);
			ProcessSchemaScriptTask scriptchildokbuttonclick = CreateScriptChildOkButtonClickScriptTask();
			eventsubprocesschildokbuttonclick.FlowElements.Add(scriptchildokbuttonclick);
			ProcessSchemaUserTask usertaskchildrefreshgrid = CreateUserTaskChildRefreshGridUserTask();
			eventsubprocesschildokbuttonclick.FlowElements.Add(usertaskchildrefreshgrid);
			ProcessSchemaScriptTask scriptchildclose = CreateScriptChildCloseScriptTask();
			eventsubprocesschildokbuttonclick.FlowElements.Add(scriptchildclose);
			ProcessSchemaStartMessageEvent startmessagechildpageloadcomplete = CreateStartMessageChildpageLoadCompleteStartMessageEvent();
			eventsubprocesschildpageloadcomplete.FlowElements.Add(startmessagechildpageloadcomplete);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			eventsubprocesschildpageloadcomplete.FlowElements.Add(scriptchildpageloadcomplete);
			FlowElements.Add(CreateSequenceFlowChildOkButtonClickSequenceFlow());
			FlowElements.Add(CreateSequenceFlowChildPageLoadComlpeteSequenceFlow());
			FlowElements.Add(CreateSequenceFlowUserTaskChilfRefrechGridSequenceFlow());
			FlowElements.Add(CreateSequenceFlowChildCloseWindowSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowChildOkButtonClickSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowChildOkButtonClick",
				UId = new Guid("273736b0-314b-4585-987a-0222cf228c6b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				CurveCenterPosition = new Point(161, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48d1a0be-94bd-4eca-9208-49a82ab20ab7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a346dd03-34ee-4d76-9174-790cdd84c010"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowChildPageLoadComlpeteSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowChildPageLoadComlpete",
				UId = new Guid("fd912c05-e68d-4cef-967b-1266358e1078"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				CurveCenterPosition = new Point(454, 75),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d52eabca-af95-4ceb-b229-c36a1c2f856e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("47b45905-e369-453f-993a-0ef805c01336"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowUserTaskChilfRefrechGridSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowUserTaskChilfRefrechGrid",
				UId = new Guid("7d0a3261-d1e0-4ca2-a3aa-96dab1f03e1b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				CurveCenterPosition = new Point(298, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a346dd03-34ee-4d76-9174-790cdd84c010"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowChildCloseWindowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowChildCloseWindow",
				UId = new Guid("07ebf913-00a4-488f-b37d-c8206b1133f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				CurveCenterPosition = new Point(440, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e12c0eff-9d0a-4a7b-8792-9dc67c9f3080"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e4b448be-50f2-461b-a290-635e0d0ce317"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(847, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0c5dff66-3652-4810-929e-4f712c434111"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e4b448be-50f2-461b-a290-635e0d0ce317"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(818, 184),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildOkButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildOkButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("efc4d6de-1ceb-49db-96f3-7369eb154b2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c5dff66-3652-4810-929e-4f712c434111"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"EventSubProcessChildOkButtonClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(501, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildOkButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildOKButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("48d1a0be-94bd-4eca-9208-49a82ab20ab7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efc4d6de-1ceb-49db-96f3-7369eb154b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"StartMessageChildOKButtonClick",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a346dd03-34ee-4d76-9174-790cdd84c010"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efc4d6de-1ceb-49db-96f3-7369eb154b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"ScriptChildOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,219,142,155,48,16,125,206,74,251,15,22,79,70,66,254,128,86,81,181,155,160,8,105,187,77,67,210,125,182,96,0,171,96,210,97,156,45,170,250,239,181,77,54,161,155,176,189,240,128,60,214,153,115,198,103,102,14,18,153,52,84,181,152,228,108,206,214,178,4,113,231,227,56,87,36,190,200,218,0,155,207,153,54,117,205,62,176,149,81,185,136,155,61,245,236,29,211,240,236,47,248,213,44,177,109,83,66,165,75,30,134,239,111,111,14,86,168,68,169,9,224,172,180,26,46,254,85,234,34,237,138,86,151,85,208,200,71,217,88,78,182,235,0,23,173,214,144,145,106,181,136,53,41,234,83,143,248,40,181,165,68,177,2,74,8,154,251,126,151,228,124,12,176,113,40,28,143,37,86,5,227,73,247,8,207,33,251,113,123,51,27,96,107,84,141,196,126,209,214,166,209,199,87,188,86,92,222,167,144,25,180,232,88,151,74,131,72,129,198,34,27,200,90,204,151,80,108,84,89,209,3,28,160,230,47,109,137,206,190,69,86,116,246,170,184,136,241,45,32,202,174,45,72,44,90,4,251,211,133,42,13,202,139,199,14,50,94,227,211,30,6,64,200,78,199,136,57,254,217,127,241,249,154,67,54,58,91,191,126,50,168,59,240,94,125,54,128,61,51,251,92,146,243,199,53,116,231,3,254,187,85,17,11,210,190,155,246,38,8,93,141,206,63,30,12,35,103,225,119,121,163,244,78,43,74,242,32,98,67,39,196,90,162,237,26,1,158,156,12,71,185,199,25,250,115,242,201,252,99,246,83,5,8,60,176,224,80,36,93,252,205,200,154,95,36,77,77,134,31,207,217,224,130,136,191,219,153,176,6,248,187,83,19,30,218,210,205,99,162,59,146,58,3,97,227,105,55,220,10,92,24,56,41,238,58,50,108,7,33,192,10,85,62,90,69,160,83,249,30,205,131,51,40,8,71,139,57,108,218,203,106,250,137,241,223,223,208,140,22,213,22,227,10,223,202,238,235,162,82,117,190,129,2,161,171,28,82,56,170,99,97,111,193,182,71,230,69,173,64,83,178,180,41,103,177,55,249,175,173,236,148,109,150,8,129,12,106,75,110,163,95,209,74,112,137,50,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskChildRefreshGridUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("72172c1f-af9b-4da3-abbf-cd9a5470d3f0"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efc4d6de-1ceb-49db-96f3-7369eb154b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"UserTaskChildRefreshGrid",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 37),
				SchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskChildRefreshGridParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildCloseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e12c0eff-9d0a-4a7b-8792-9dc67c9f3080"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efc4d6de-1ceb-49db-96f3-7369eb154b2d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"ScriptChildClose",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(393, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2e1e9c66-d1d7-4403-b491-c53c1d9b81c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c5dff66-3652-4810-929e-4f712c434111"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"EventSubProcessChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(554, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(254, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildpageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d52eabca-af95-4ceb-b229-c36a1c2f856e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e1e9c66-d1d7-4403-b491-c53c1d9b81c2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"StartMessageChildpageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("47b45905-e369-453f-993a-0ef805c01336"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e1e9c66-d1d7-4403-b491-c53c1d9b81c2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,193,78,194,64,16,61,203,87,108,56,181,137,105,162,30,13,7,173,13,105,162,66,168,232,121,109,135,118,165,157,197,233,20,36,134,127,119,182,64,169,137,145,227,190,125,111,222,123,51,243,26,40,180,136,144,178,177,24,60,220,39,144,54,100,120,27,97,110,16,130,176,128,116,25,106,140,190,4,103,152,172,128,180,99,122,67,1,159,52,234,28,18,91,54,14,26,250,183,131,169,188,131,187,134,11,75,81,102,56,152,193,103,99,8,50,53,82,76,13,28,8,99,210,200,0,127,51,214,154,20,65,106,41,139,179,201,251,135,224,123,13,240,84,147,174,128,129,94,117,217,128,55,60,178,156,177,83,213,105,1,149,62,167,146,55,32,71,200,82,242,164,181,199,98,255,40,59,142,19,153,133,242,16,54,106,220,152,204,235,229,13,94,108,194,100,48,247,124,95,141,70,237,127,16,85,43,222,250,234,123,112,177,247,157,146,169,52,109,67,217,92,133,237,116,117,96,62,195,166,157,40,14,7,110,210,182,154,199,110,67,111,150,150,245,74,167,48,103,83,26,54,80,187,156,29,227,94,10,157,66,245,214,209,15,117,169,230,191,110,238,156,38,189,246,242,179,6,98,145,196,200,55,215,94,215,186,63,68,52,51,147,23,252,8,107,40,69,116,37,64,92,75,248,238,140,59,5,101,13,103,42,159,91,160,76,149,126,173,83,140,11,235,182,178,27,16,112,67,184,183,249,1,164,18,60,112,191,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetRightInfoMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4c959a8d-b8ea-4cf1-9355-188fd0a51517"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fc51d554-d3c5-4da4-9e2a-6cb0bf52a898"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateGetRightInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5350202d-487e-4dac-adc3-cdc2e3c60d6b"),
				Name = "GetRightInfo",
				CreatedInSchemaUId = new Guid("d55985fe-dd01-451f-b341-6ba191920117"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,193,110,218,64,16,61,19,41,255,96,113,50,18,242,161,61,162,30,72,112,17,85,85,16,134,246,188,193,19,188,145,189,219,142,215,36,168,234,191,119,240,172,237,53,132,98,162,70,2,196,62,191,121,111,118,118,103,188,19,232,229,144,194,198,120,159,60,5,207,222,10,16,69,174,31,77,112,175,17,130,201,93,16,149,143,253,133,216,66,176,206,1,239,181,82,4,72,173,6,183,55,61,162,165,69,166,252,126,180,207,67,101,164,217,71,155,4,50,177,132,141,198,120,2,143,75,185,77,76,127,232,245,103,113,255,186,128,168,120,120,34,35,126,188,62,14,31,23,38,209,88,9,7,227,188,130,206,19,191,137,12,90,84,6,92,242,20,133,50,0,45,89,139,29,235,58,84,71,216,162,167,202,23,183,59,255,9,40,14,101,181,74,206,250,42,157,242,207,87,216,65,106,133,92,192,85,90,232,92,58,126,205,242,64,250,140,58,187,100,86,18,103,116,27,240,139,150,156,218,56,206,164,90,43,105,90,117,166,197,252,244,200,102,121,248,171,16,105,135,45,113,160,43,95,29,198,191,221,171,35,98,251,227,179,237,238,111,35,95,75,224,71,2,8,29,111,127,237,120,218,100,124,38,193,66,32,93,28,3,232,179,218,2,101,38,112,207,79,191,139,180,128,193,192,35,91,145,159,109,212,209,232,246,166,200,165,218,122,254,142,154,59,126,8,95,96,83,24,141,212,224,237,246,13,66,149,23,8,147,187,6,242,73,254,55,233,59,2,8,34,134,67,48,143,137,128,229,96,89,194,126,35,111,35,123,207,137,76,193,243,57,44,56,208,42,209,94,79,42,227,81,93,164,18,41,9,90,202,20,204,156,177,86,171,141,202,136,26,176,227,105,90,200,216,111,2,203,146,248,86,114,16,172,116,100,144,50,39,71,14,239,98,198,173,202,252,195,134,183,13,220,138,59,235,197,161,229,124,180,146,97,44,13,29,7,135,140,85,188,130,23,227,215,91,25,186,22,93,18,109,230,26,147,171,245,59,212,196,157,139,77,73,68,141,94,93,17,22,124,181,32,213,54,134,142,126,151,28,157,193,200,236,26,32,62,221,229,29,160,161,100,102,202,124,252,240,191,234,226,206,80,166,55,200,91,93,73,228,178,241,233,75,144,237,221,105,179,126,195,85,176,230,127,232,135,190,244,249,11,139,201,95,69,10,8,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaRecDefRightEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d55985fe-dd01-451f-b341-6ba191920117"));
		}

		#endregion

	}

	#endregion

}

