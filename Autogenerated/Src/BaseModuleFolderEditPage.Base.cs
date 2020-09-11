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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: BaseModuleFolderEditPageSchema

	/// <exclude/>
	public class BaseModuleFolderEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _descriptionEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return _descriptionEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseModuleFolderEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseModuleFolderEditPageSchema(BaseModuleFolderEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			RealUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			Name = "BaseModuleFolderEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 400;
			Height = 230;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseModuleFolderEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateDescriptionEdit());
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

		protected virtual EmbeddedProcessSchema CreateBaseModuleFolderEditPageEventsProcessSchema() {
			var schema = new BaseModuleFolderEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("a7e7fd75-642c-4e78-bb95-cea048d78b5c");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			_nameEdit.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("49936fd0-ac5a-4058-8739-0be4750bc3aa");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateDescriptionEdit() {
			_descriptionEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_descriptionEdit.UId = new Guid("aa857551-e384-4833-96b6-ce6ee8ed2e92");
			_descriptionEdit.Name = "DescriptionEdit";
			_descriptionEdit.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			_descriptionEdit.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			_descriptionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_descriptionEdit.Tag = "";
			_descriptionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_descriptionEdit.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_descriptionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_descriptionEdit.DataSource = "DataSource";
			_descriptionEdit.ColumnUId = new Guid("55b13609-94f1-4a54-81f6-babd79950a07");
			return _descriptionEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
			DataSource.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("52510277-a8b3-40c3-ba55-ad86458f76fe");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("49936fd0-ac5a-4058-8739-0be4750bc3aa");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("527b9e4e-7dbf-4721-a112-72b423b3365a");
			if (column != null) {
				column.UId = new Guid("4d4c61f2-3684-460d-84a8-502b740697e0");
				column.Name = @"Parent";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("dea05b8b-4b45-4e14-b18a-cfd3f1141073");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("9a905fad-40ef-48c3-bbe2-50415855d3c2");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("8c2228d7-f761-4385-9957-aabd64cde81d");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("0ec0e36e-0577-4bad-be3d-477e538b2cf5");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("55b13609-94f1-4a54-81f6-babd79950a07");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e44c8807-bc0e-4415-b41c-2272c8fbdf42");
			if (column != null) {
				column.UId = new Guid("c404396b-fe95-44cf-88f8-38b9bced7406");
				column.Name = @"FolderType";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4d5be702-fa8a-4b6b-97d0-f666b99f108e");
			if (column != null) {
				column.UId = new Guid("62f66aef-adb8-496b-ae69-59d1a33e9095");
				column.Name = @"SearchData";
				column.CreatedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				column.ModifiedInSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
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
			return new BaseModuleFolderEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseModuleFolderEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseModuleFolderEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseModuleFolderEditPageEventsProcess

	/// <exclude/>
	public class BaseModuleFolderEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseModuleFolderEditPageSchemaUserControl
	{

		public BaseModuleFolderEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseModuleFolderEditPageEventsProcess";
			SchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236");
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

		public virtual string TreeGridId {
			get;
			set;
		}

		public virtual string CacheItemName {
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
					SchemaElementUId = new Guid("370c393a-bd59-47f8-a99f-a6f13a26e8b6"),
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
					SchemaElementUId = new Guid("2237505a-4ca0-46ed-b242-2e9766ef717b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _child_DataSourceSavedScriptTask;
		public ProcessScriptTask Child_DataSourceSavedScriptTask {
			get {
				return _child_DataSourceSavedScriptTask ?? (_child_DataSourceSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_DataSourceSavedScriptTask",
					SchemaElementUId = new Guid("6ef4acef-5637-4275-8786-b81f6a42fe25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_DataSourceSavedScriptTaskExecute,
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
					SchemaElementUId = new Guid("47a3db72-2325-43d4-b96a-9f6bec1b3659"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2FolderPageLoadComplete;
		public ProcessFlowElement EventSubProcess2FolderPageLoadComplete {
			get {
				return _eventSubProcess2FolderPageLoadComplete ?? (_eventSubProcess2FolderPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2FolderPageLoadComplete",
					SchemaElementUId = new Guid("0c7e22f9-c356-460e-a298-0379edd644a6"),
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
					SchemaElementUId = new Guid("6e437b9f-e61e-4b03-89b3-14eaa683225d"),
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
					SchemaElementUId = new Guid("16356c0b-658a-437a-b29c-41273a1f1d8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
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
					SchemaElementUId = new Guid("fa5db397-0560-4eea-a517-eaa8ceb5e7ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _folderCaption;
		public LocalizableString FolderCaption {
			get {
				return _folderCaption ?? (_folderCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FolderCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[Child_DataSourceSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_DataSourceSavedScriptTask };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess2FolderPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2FolderPageLoadComplete };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("Child_DataSourceSavedScriptTask");
						break;
					case "Child_DataSourceSavedScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess2FolderPageLoadComplete":
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "ScriptPageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
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
			ActivatedEventElements.Add("PageLoadCompleteChild");
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "Child_DataSourceSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_DataSourceSavedScriptTask";
					result = Child_DataSourceSavedScriptTask.Execute(context, Child_DataSourceSavedScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceSaved");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess2FolderPageLoadComplete":
					context.QueueTasks.Dequeue();
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
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
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
				case "CacheItemName":
					CacheItemName = reader.GetValue<System.String>();
				break;
				case "TreeGridId":
					TreeGridId = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool Child_DataSourceSavedScriptTaskExecute(ProcessExecutingContext context) {
			if (IsNew && !string.IsNullOrEmpty(CacheItemName)) {
				UserConnection.SessionCache.Remove(CacheItemName);
			}
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			string queryString = Page.Request.QueryString.ToString();
			if (queryString.Contains("entitySchemaUId")) {
				dataSource.SchemaUId = new Guid(Page.Request.QueryString["entitySchemaUId"].ToString());
			}
			if (queryString.Contains("cacheItemName")) {
				CacheItemName = Page.Request.QueryString["cacheItemName"].ToString();
			}
			return true;
		}

		public override void MakeCaption() {
			if(IsCaptionExists) {
				return;
			}
			/*var columnName = Page.DataSource.Schema.FindPrimaryDisplayColumnName();
			var primaryDisplayColumnName = String.Empty;
			if(string.IsNullOrEmpty(columnName)) {
				primaryDisplayColumnName = EditingRecordCaption;
			} else {
				primaryDisplayColumnName = columnName;
			}
			var caption = FolderCaption;
			caption = string.Format("{0} ({1})", caption, NewRecordCaption);
			(Page.AspPage as Terrasoft.UI.Core.Page).Caption = caption;*/
			
			var columnName = Page.DataSource.Schema.FindPrimaryDisplayColumnName();
			var primaryDisplayColumnName = String.Empty;
			var record = Page.GetParameterValue("recordId");
			var recordId = record != null ? new Guid(record.ToString()) : Guid.Empty;
			bool isNew = recordId.IsEmpty() || Convert.ToBoolean(Page.GetParameterValue("Copy"));
			if (isNew) {
				primaryDisplayColumnName = NewRecordCaption;
			} else {
				if(string.IsNullOrEmpty(columnName)) {
					primaryDisplayColumnName = EditingRecordCaption;
				} else {
					primaryDisplayColumnName = Page.DataSource.Rows[0].GetTypedColumnValue<string>(columnName);
				}
			}
			var caption = FolderCaption;
			caption = string.Format("{0} ({1})", caption, primaryDisplayColumnName);
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = caption;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
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
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("CacheItemName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CacheItemName", CacheItemName, null);
			}
			if (!HasMapping("TreeGridId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TreeGridId", TreeGridId, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseModuleFolderEditPageEventsProcess

	/// <exclude/>
	public class BaseModuleFolderEditPageEventsProcess : BaseModuleFolderEditPageEventsProcess<Terrasoft.WebApp.BaseModuleFolderEditPageSchemaUserControl>
	{

		public BaseModuleFolderEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseModuleFolderEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseModuleFolderEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("DescriptionEdit", true);
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
			var process = (BaseModuleFolderEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseModuleFolderEditPageEventsProcess(UserConnection);
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
			SchemaName = "BaseModuleFolderEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseModuleFolderEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseModuleFolderEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseModuleFolderEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseModuleFolderEditPageEventsProcessSchema(BaseModuleFolderEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseModuleFolderEditPageEventsProcess";
			UId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateTreeGridIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("183f8708-5d72-4b23-9d73-52be13771ed3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"TreeGridId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCacheItemNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fcf8331b-8340-490f-8a6d-509728e4a2e3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"CacheItemName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateTreeGridIdParameter());
			Parameters.Add(CreateCacheItemNameParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet249 = CreateLaneSet249LaneSet();
			LaneSets.Add(schemaLaneSet249);
			ProcessSchemaLane schemaLane692 = CreateLane692Lane();
			schemaLaneSet249.Lanes.Add(schemaLane692);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2folderpageloadcomplete = CreateEventSubProcess2FolderPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocess2folderpageloadcomplete);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask child_datasourcesavedscripttask = CreateChild_DataSourceSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(child_datasourcesavedscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2folderpageloadcomplete.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			eventsubprocess2folderpageloadcomplete.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			eventsubprocess2folderpageloadcomplete.FlowElements.Add(pageloadcompletechild);
			FlowElements.Add(CreateSequenceFlow4053SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4054SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFolderCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFolderCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dd8b4b8d-f49b-4174-89eb-7afeb116cc67"),
				Name = "FolderCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4053SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4053",
				UId = new Guid("f1db6701-a21a-4fb3-9790-5342dd8d3ede"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				CurveCenterPosition = new Point(147, 692),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fa5db397-0560-4eea-a517-eaa8ceb5e7ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("16356c0b-658a-437a-b29c-41273a1f1d8c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4054SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4054",
				UId = new Guid("b3e94020-95b6-48af-b15f-8391a39bf320"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				CurveCenterPosition = new Point(241, 693),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("16356c0b-658a-437a-b29c-41273a1f1d8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e437b9f-e61e-4b03-89b3-14eaa683225d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("251a06a7-f326-47ce-bf66-a1e62b118eea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				CurveCenterPosition = new Point(460, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2237505a-4ca0-46ed-b242-2e9766ef717b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6ef4acef-5637-4275-8786-b81f6a42fe25"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e15900a0-371d-4162-8f14-5e2c8e038985"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				CurveCenterPosition = new Point(582, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6ef4acef-5637-4275-8786-b81f6a42fe25"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("47a3db72-2325-43d4-b96a-9f6bec1b3659"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet249LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet249 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e7b43ccb-a6f5-4426-a793-054b8bad9055"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"LaneSet249",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(798, 179),
				UseBackgroundMode = false
			};
			return schemaLaneSet249;
		}

		protected virtual ProcessSchemaLane CreateLane692Lane() {
			ProcessSchemaLane schemaLane692 = new ProcessSchemaLane(this) {
				UId = new Guid("84a41fc4-5bf5-44f0-8f35-f6fb240f2130"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e7b43ccb-a6f5-4426-a793-054b8bad9055"),
				CreatedInOwnerSchemaUId = new Guid("0622ef1c-1b6b-477b-9443-bd08b8e57236"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"Lane692",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(769, 179),
				UseBackgroundMode = false
			};
			return schemaLane692;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("370c393a-bd59-47f8-a99f-a6f13a26e8b6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84a41fc4-5bf5-44f0-8f35-f6fb240f2130"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(327, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2237505a-4ca0-46ed-b242-2e9766ef717b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("370c393a-bd59-47f8-a99f-a6f13a26e8b6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_DataSourceSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6ef4acef-5637-4275-8786-b81f6a42fe25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("370c393a-bd59-47f8-a99f-a6f13a26e8b6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"Child_DataSourceSavedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,246,75,45,87,80,83,83,80,44,46,41,202,204,75,215,3,10,148,230,228,248,23,185,230,22,148,84,106,56,39,38,103,164,122,150,164,230,250,37,230,166,106,106,42,84,243,114,113,134,22,167,22,57,231,231,229,165,38,151,100,230,231,233,5,167,22,23,3,105,176,74,189,160,212,220,252,178,84,52,109,214,188,92,181,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,232,125,56,46,122,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("47a3db72-2325-43d4-b96a-9f6bec1b3659"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("370c393a-bd59-47f8-a99f-a6f13a26e8b6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2FolderPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2FolderPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0c7e22f9-c356-460e-a298-0379edd644a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84a41fc4-5bf5-44f0-8f35-f6fb240f2130"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"EventSubProcess2FolderPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(351, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2FolderPageLoadComplete;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6e437b9f-e61e-4b03-89b3-14eaa683225d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c7e22f9-c356-460e-a298-0379edd644a6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("16356c0b-658a-437a-b29c-41273a1f1d8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c7e22f9-c356-460e-a298-0379edd644a6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,177,14,130,64,16,68,107,239,43,54,84,71,115,63,64,172,48,49,52,70,69,43,66,177,129,85,175,224,136,199,158,134,24,254,221,75,32,128,26,233,38,179,59,59,111,31,104,161,68,198,180,118,182,32,88,195,30,175,164,54,163,19,137,134,173,54,87,184,59,178,109,218,235,97,235,72,222,108,88,29,166,145,58,213,189,144,97,36,244,5,228,44,166,226,218,48,106,211,200,128,12,107,110,211,226,70,21,158,147,50,8,67,120,137,213,196,161,198,145,239,50,244,132,173,211,165,252,87,154,253,220,203,103,28,30,164,91,64,41,208,167,18,166,106,135,21,13,32,241,220,91,248,54,251,74,231,31,239,119,194,18,59,107,128,173,163,232,13,117,192,163,92,105,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fa5db397-0560-4eea-a517-eaa8ceb5e7ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c7e22f9-c356-460e-a298-0379edd644a6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
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
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,207,79,219,48,20,62,19,41,255,131,151,147,141,144,97,215,49,152,182,208,162,92,186,138,118,219,1,113,48,205,43,88,114,236,232,217,161,139,74,255,119,28,59,180,20,169,20,161,105,167,72,121,239,251,241,222,251,44,231,180,176,185,168,157,52,122,240,87,90,103,25,89,166,201,1,130,107,80,159,166,201,42,77,142,15,31,4,146,153,81,77,165,71,162,2,114,70,198,226,14,248,133,112,98,98,26,156,1,159,204,238,161,18,124,40,117,57,70,89,9,108,47,164,173,149,104,243,53,138,50,207,214,17,213,59,26,60,237,196,161,212,119,124,80,213,174,245,221,114,78,109,252,83,216,81,163,212,79,12,21,186,177,194,162,219,55,40,7,165,116,158,225,10,102,6,203,126,208,110,44,2,202,194,62,240,70,40,110,34,236,33,114,248,234,208,168,18,112,195,185,169,244,174,135,6,43,225,104,182,60,89,17,186,252,188,98,217,209,51,252,136,140,96,177,101,170,91,15,13,123,253,110,235,238,75,132,37,83,64,20,214,204,29,255,85,240,220,32,240,174,194,120,190,150,234,249,78,15,143,211,164,55,248,255,15,213,117,99,24,230,89,242,18,220,88,160,111,118,128,191,133,106,128,102,177,161,40,51,182,133,40,58,76,15,254,116,70,180,191,51,249,70,52,44,200,101,35,75,26,43,124,106,162,36,245,23,255,18,42,107,241,91,99,20,145,214,239,115,77,84,148,62,49,49,43,140,60,62,146,220,232,7,64,231,89,126,248,102,16,154,238,50,153,155,186,205,24,11,225,35,52,176,238,141,216,235,75,110,199,235,221,33,254,64,138,15,94,232,188,5,127,157,130,43,179,176,215,39,55,221,2,166,109,13,101,108,14,43,248,26,205,158,191,244,23,148,254,249,3,216,229,119,255,67,248,3,183,254,162,14,141,178,59,223,67,154,60,1,77,131,93,174,219,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseModuleFolderEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b55275d7-d78d-4274-a5f6-5b92aaf5f70a"));
		}

		#endregion

	}

	#endregion

}

