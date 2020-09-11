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
	using System.IO;
	using System.Linq;
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

	#region Class: LeadTypeEditPageSchema

	/// <exclude/>
	public class LeadTypeEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.FileUploadEdit _fileUploadEdit;
		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return _fileUploadEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ImageBox _imageBox;
		public Terrasoft.UI.WebControls.Controls.ImageBox ImageBox {
			get {
				return _imageBox;
			}
		}

		#endregion

		#region Constructors: Public

		public LeadTypeEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LeadTypeEditPageSchema(LeadTypeEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("369598fb-73cc-47ef-8024-51f51a66adaf");
			NameEdit.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("470f0b11-68bd-41aa-a018-b84f9219f99b");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateCustomControls() {
			CustomControls.FitHeightByContent = true;
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			RealUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			Name = "LeadTypeEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLeadTypeEditPageEventsProcessSchema();
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
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.MoveItem(2, CustomControls);
			CustomControls.InsertItem(0, CreateFileUploadEdit());
			CustomControls.InsertItem(1, CreateImageBox());
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

		protected virtual EmbeddedProcessSchema CreateLeadTypeEditPageEventsProcessSchema() {
			var schema = new LeadTypeEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateFileUploadEdit() {
			_fileUploadEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_fileUploadEdit.UId = new Guid("6222ec7a-ea2a-4d5e-be7b-aa42e31e7f27");
			_fileUploadEdit.Name = "FileUploadEdit";
			_fileUploadEdit.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			_fileUploadEdit.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			_fileUploadEdit.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			_fileUploadEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_fileUploadEdit.Tag = "";
			_fileUploadEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_fileUploadEdit.Image = new ControlImage {};
			_fileUploadEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _fileUploadEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageBox CreateImageBox() {
			_imageBox = new Terrasoft.UI.WebControls.Controls.ImageBox();
			_imageBox.UId = new Guid("88bf45cb-140c-415b-b6b9-dbb3a366fa3e");
			_imageBox.Name = "ImageBox";
			_imageBox.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			_imageBox.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			_imageBox.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			_imageBox.Tag = "";
			_imageBox.Image = new ControlImage {};
			_imageBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_imageBox.Edges = "";
			return _imageBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888");
			DataSource.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("9626bfe4-3e3a-4b5a-8a27-0ebffce2a143");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("5827eb9f-573a-450d-9b97-a35c905b3630");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("a94e92a9-e445-4a35-9a95-9ab3809b8861");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("33811061-1b34-4780-98d8-7db2439310ff");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("ce7a83a8-39a2-4cbb-b8a9-1ecb6d380539");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("369598fb-73cc-47ef-8024-51f51a66adaf");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("470f0b11-68bd-41aa-a018-b84f9219f99b");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("0d2e4e45-ca33-47b0-bdd2-9bef56f3b6bf");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("39539b29-f4b5-4d7a-9a08-dc5978876705");
			if (column != null) {
				column.UId = new Guid("1fecd340-acb5-4043-a606-f1aaa8dccef5");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
				column.ModifiedInSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
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
			return new LeadTypeEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new LeadTypeEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LeadTypeEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeEditPageEventsProcess

	/// <exclude/>
	public class LeadTypeEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LeadTypeEditPageSchemaUserControl
	{

		public LeadTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadTypeEditPageEventsProcess";
			SchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040");
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("9eb967ee-dbae-4bf8-b34d-f21251189fc6"),
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
					SchemaElementUId = new Guid("6e2b78d4-a70c-46d4-b84f-5d7415dbdd05"),
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
					SchemaElementUId = new Guid("a56a603a-376b-4155-ad79-cdd63171f1df"),
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
					SchemaElementUId = new Guid("a641d1d9-4ec9-412e-8d98-e1b650b6e8df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("acec2e46-b5b3-496f-b0db-3285b7f4a565"),
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
					SchemaElementUId = new Guid("3b6723ad-b023-4054-82ef-ce5afebf5f67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _fileUploadEditChangeScriptTask;
		public ProcessScriptTask FileUploadEditChangeScriptTask {
			get {
				return _fileUploadEditChangeScriptTask ?? (_fileUploadEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FileUploadEditChangeScriptTask",
					SchemaElementUId = new Guid("503cc14c-f866-4718-b205-7eb6d0b0be5f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FileUploadEditChangeScriptTaskExecute,
				});
			}
		}

		private LocalizableString _newRecordNotSavedMessage;
		public LocalizableString NewRecordNotSavedMessage {
			get {
				return _newRecordNotSavedMessage ?? (_newRecordNotSavedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewRecordNotSavedMessage.Value"));
			}
		}

		private LocalizableString _wrongFileFormat;
		public LocalizableString WrongFileFormat {
			get {
				return _wrongFileFormat ?? (_wrongFileFormat = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WrongFileFormat.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[FileUploadEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FileUploadEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("FileUploadEditChangeScriptTask");
						break;
					case "FileUploadEditChangeScriptTask":
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
			ActivatedEventElements.Add("StartMessage2");
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
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "FileUploadEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FileUploadEditChangeScriptTask";
					result = FileUploadEditChangeScriptTask.Execute(context, FileUploadEditChangeScriptTaskExecute);
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

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var activeRow = Page.DataSource.ActiveRow;
			var sysImageId = activeRow.GetTypedColumnValue<Guid>("ImageId");
			ShowImage(sysImageId);
			return true;
		}

		public virtual bool FileUploadEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			SaveImage();
			return true;
		}

		public virtual void SaveImage() {
			var activeRow = Page.DataSource.ActiveRow;
			Terrasoft.Core.ImageAPI.ImageAPI imageApi = new Core.ImageAPI.ImageAPI(UserConnection);
			if (Page.FileUploadEdit.HasFile) {
				string fileName = Page.FileUploadEdit.FileName;
				Stream stream = new System.IO.MemoryStream(Page.FileUploadEdit.FileBytes);
				string mimeType = GetMimeType(stream);
				if (string.IsNullOrEmpty(mimeType) || !mimeType.Contains("image")) {
					Page.BaseMessagePanel.Clear();
					Page.BaseMessagePanel.AddMessage(Warning, WrongFileFormat);
					Page.FileUploadEdit.Clear();
					return;
				}
				Guid imageId = imageApi.Save(stream, mimeType, fileName);
				stream.Close();
				activeRow.SetColumnValue("ImageId", imageId);
				ShowImage(imageId);
			} else {
				activeRow.SetColumnValue("ImageId", null);
				ShowImage(Guid.Empty);
			}
		}

		public virtual string GetMimeType(Stream stream) {
			string mimeType = null;;
			try {
				using (System.Drawing.Image image = System.Drawing.Image.FromStream(stream)) {
					var codec = System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders()
						.FirstOrDefault(c => c.FormatID == image.RawFormat.Guid);
					mimeType = codec != null ? codec.MimeType : null;
				}
			} catch {
			}
			return mimeType;
		}

		public virtual void ShowImage(Guid sysImageId) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysImage");
			var schemaDataColumn = schema.Columns.FindByName("Data");
			var controlImage = new ControlImage();
			if (!sysImageId.Equals(Guid.Empty)) {
				controlImage.Source = ControlImageSource.EntityColumn;
				controlImage.SchemaUId = schema.UId;
				controlImage.EntityPrimaryColumnValue = sysImageId;
				controlImage.EntitySchemaColumnUId = schemaDataColumn.UId;
				Page.FileUploadEdit.Text = "name";
				var esq = new EntitySchemaQuery(schema);
				var nameColumn = esq.AddColumn("Name").Name;
				var sysImage = esq.GetEntity(UserConnection, sysImageId);
				if (sysImage != null) {
					Page.FileUploadEdit.Text = sysImage.GetTypedColumnValue<string>(nameColumn);
				}
			} else {
				controlImage.Source = ControlImageSource.None;
			}
			controlImage.ResetCache();
			Page.ImageBox.SetImage(controlImage);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "FileUploadEditChange":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
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

	#region Class: LeadTypeEditPageEventsProcess

	/// <exclude/>
	public class LeadTypeEditPageEventsProcess : LeadTypeEditPageEventsProcess<Terrasoft.WebApp.LeadTypeEditPageSchemaUserControl>
	{

		public LeadTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadTypeEditPageSchemaUserControl

	/// <exclude/>
	public partial class LeadTypeEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadEdit)PageContainer.FindPageControl("FileUploadEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ImageBox ImageBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.ImageBox)PageContainer.FindPageControl("ImageBox", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			FileUploadEdit.AjaxEvents.Change.Event += FileUploadEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			FileUploadEdit.AjaxEvents.Change.Event -= FileUploadEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (LeadTypeEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LeadTypeEditPageEventsProcess(UserConnection);
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

		public virtual void FileUploadEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FileUploadEditChange");
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
			SchemaName = "LeadTypeEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeEditPageEventsProcessSchema

	/// <exclude/>
	public class LeadTypeEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public LeadTypeEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LeadTypeEditPageEventsProcessSchema(LeadTypeEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadTypeEditPageEventsProcess";
			UId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask fileuploadeditchangescripttask = CreateFileUploadEditChangeScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(fileuploadeditchangescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNewRecordNotSavedMessageLocalizableString());
			LocalizableStrings.Add(CreateWrongFileFormatLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNewRecordNotSavedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6174af6e-9993-4f69-a17c-c5c0c2a526fe"),
				Name = "NewRecordNotSavedMessage",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWrongFileFormatLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a06df4e0-51db-4a54-a498-03a16a665eb8"),
				Name = "WrongFileFormat",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9fb78c20-2174-4340-8ad2-45bcae3ad037"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				CurveCenterPosition = new Point(186, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6e2b78d4-a70c-46d4-b84f-5d7415dbdd05"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a56a603a-376b-4155-ad79-cdd63171f1df"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e0fa505b-ae44-4c2d-9acf-1b9c449d074c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				CurveCenterPosition = new Point(328, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a56a603a-376b-4155-ad79-cdd63171f1df"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a641d1d9-4ec9-412e-8d98-e1b650b6e8df"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("6f3a9ee7-a320-49d5-b59e-c2964478fb31"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3b6723ad-b023-4054-82ef-ce5afebf5f67"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("503cc14c-f866-4718-b205-7eb6d0b0be5f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("51134d6c-b463-43a0-8d1f-08d2a52c8ca2"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(675, 329),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("dfb46c69-a185-4ca4-be3a-0c470c517864"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("51134d6c-b463-43a0-8d1f-08d2a52c8ca2"),
				CreatedInOwnerSchemaUId = new Guid("f525ba2e-7eeb-4b12-b572-190556ec6040"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 164),
				Size = new Size(646, 165),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("3ee7cd2b-367c-43ca-bef7-d6053dcec444"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("51134d6c-b463-43a0-8d1f-08d2a52c8ca2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(646, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9eb967ee-dbae-4bf8-b34d-f21251189fc6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dfb46c69-a185-4ca4-be3a-0c470c517864"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(420, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6e2b78d4-a70c-46d4-b84f-5d7415dbdd05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9eb967ee-dbae-4bf8-b34d-f21251189fc6"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a56a603a-376b-4155-ad79-cdd63171f1df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9eb967ee-dbae-4bf8-b34d-f21251189fc6"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a641d1d9-4ec9-412e-8d98-e1b650b6e8df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9eb967ee-dbae-4bf8-b34d-f21251189fc6"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,76,46,201,44,75,13,202,47,87,176,85,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,132,201,89,243,114,149,1,213,22,87,22,123,230,2,213,120,166,0,21,195,53,234,185,167,150,132,84,22,164,166,56,231,231,148,230,230,133,37,230,148,166,218,184,151,102,166,216,105,40,65,149,43,105,2,77,8,206,200,47,7,243,53,16,230,128,196,139,82,75,74,139,242,20,74,138,74,83,173,1,12,0,128,224,146,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("acec2e46-b5b3-496f-b0db-3285b7f4a565"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ee7cd2b-367c-43ca-bef7-d6053dcec444"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(424, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3b6723ad-b023-4054-82ef-ce5afebf5f67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("acec2e46-b5b3-496f-b0db-3285b7f4a565"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FileUploadEditChange",
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"StartMessage2",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFileUploadEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("503cc14c-f866-4718-b205-7eb6d0b0be5f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("acec2e46-b5b3-496f-b0db-3285b7f4a565"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Name = @"FileUploadEditChangeScriptTask",
				Position = new Point(120, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,44,75,245,204,77,76,79,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,235,96,48,228,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSaveImageMethod());
			Methods.Add(CreateGetMimeTypeMethod());
			Methods.Add(CreateShowImageMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5dd8b88b-dcb0-4273-9cf6-555e76cbf7fd"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("59c488cb-0e69-4401-9f3a-4dc895969f8a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
		}

		protected virtual SchemaMethod CreateSaveImageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cc7cbd5c-ea85-4419-94f7-1843259ac59e"),
				Name = "SaveImage",
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,194,48,16,60,131,196,63,184,156,140,20,249,7,170,30,128,2,205,129,135,26,40,231,21,89,168,37,63,34,219,1,69,133,127,175,99,99,132,16,149,122,136,188,235,29,207,236,236,230,8,134,192,206,241,35,126,234,19,121,35,43,56,32,123,7,7,133,174,205,14,217,48,213,94,123,221,53,26,3,86,239,29,27,107,131,44,151,30,59,92,229,183,128,240,16,84,220,243,40,60,145,231,40,186,177,104,198,90,41,244,212,90,13,60,49,223,19,26,132,167,92,224,166,18,26,202,73,201,29,251,0,219,222,12,200,79,175,219,177,206,112,117,32,123,127,177,0,137,169,215,135,39,211,107,217,179,118,10,103,16,36,177,241,136,61,21,141,117,40,89,190,100,115,148,218,52,17,243,84,189,77,71,141,67,219,182,152,228,37,151,184,110,170,86,126,134,110,126,205,104,212,8,192,214,76,4,179,220,46,106,33,150,102,34,43,215,208,244,116,64,206,103,242,146,50,63,75,229,128,43,75,251,97,124,253,65,180,219,9,45,141,192,226,28,173,245,241,10,20,10,54,22,8,134,6,161,63,16,195,178,188,230,116,11,70,249,62,50,178,53,90,29,90,63,83,109,36,184,187,231,15,158,239,233,13,186,218,168,54,188,248,111,86,243,50,46,56,47,189,249,180,106,86,192,49,217,207,110,211,201,110,107,74,179,243,101,79,174,45,70,242,219,47,199,10,116,99,45,106,169,190,64,212,72,251,121,148,232,103,73,44,224,139,111,125,10,21,122,119,123,33,40,44,134,105,253,135,79,249,93,60,144,181,166,88,216,78,224,251,5,36,183,73,81,13,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMimeTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3ec46d7f-9dbe-42fe-b5da-3362f20fe798"),
				Name = "GetMimeType",
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c2d0f6a0-aefa-4354-9fd9-50044d3f61a0"),
				Name = "stream",
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Stream",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,193,170,194,64,12,60,183,208,127,136,183,246,146,15,176,84,15,150,74,15,15,65,253,129,101,141,186,208,109,31,217,172,82,196,127,183,219,69,241,224,37,97,146,153,33,19,39,108,250,11,88,99,233,56,254,19,84,208,251,174,43,203,44,21,30,225,145,165,137,119,129,144,31,70,39,100,177,102,117,159,48,182,86,93,8,204,92,43,248,181,196,134,7,123,16,38,101,115,55,183,162,152,13,147,155,98,208,195,137,244,111,229,199,97,19,56,109,127,30,112,75,50,79,106,10,58,118,121,17,124,18,108,12,59,217,113,77,103,229,59,201,39,195,21,104,108,6,182,74,218,26,170,42,94,136,123,117,143,67,220,122,115,42,202,160,254,138,28,143,89,196,236,176,142,24,255,222,132,101,252,201,36,122,102,233,19,180,18,125,13,73,38,196,36,158,251,207,251,202,23,186,78,205,227,79,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowImageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2373d7d8-fa4d-4035-af65-f5595fb7bec4"),
				Name = "ShowImage",
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ff70c4fb-0746-4138-8611-dd54c8cb6318"),
				Name = "sysImageId",
				CreatedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				ModifiedInSchemaUId = new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,93,79,194,48,20,134,175,37,225,63,140,93,117,137,233,31,64,77,100,2,217,133,4,157,120,223,172,71,108,210,181,208,118,200,98,248,239,246,99,99,37,68,19,175,88,219,243,188,239,249,226,64,84,162,171,79,168,73,114,159,108,52,168,92,10,1,149,97,82,224,185,48,204,180,165,127,125,38,130,108,65,225,37,152,66,104,67,68,5,179,118,69,106,64,105,217,234,162,182,143,105,54,29,143,14,103,189,39,98,72,46,121,83,11,171,28,174,112,56,107,188,96,130,246,184,139,59,163,149,20,70,73,238,245,44,38,224,43,201,163,43,228,226,216,71,130,38,186,51,45,40,158,239,27,194,53,90,54,204,126,215,59,211,102,89,242,61,30,221,196,90,184,148,141,170,156,100,44,23,46,187,58,67,110,211,43,208,103,190,41,232,80,133,61,92,133,5,141,181,98,53,81,157,212,59,225,141,115,28,82,253,133,10,22,1,138,141,134,14,246,150,107,7,45,24,135,205,142,75,66,231,148,25,252,6,71,99,145,84,216,110,166,46,200,245,17,244,190,107,95,108,241,210,128,106,81,16,207,250,80,199,157,231,100,57,252,72,105,56,163,212,77,40,205,176,251,233,195,251,106,186,96,187,15,193,1,93,46,207,109,84,182,183,114,83,59,179,19,155,91,195,121,152,211,95,85,245,132,243,121,107,119,64,163,214,222,105,163,152,216,62,160,161,2,239,116,26,143,78,9,112,13,255,219,130,149,20,174,72,75,95,32,175,160,193,228,196,246,204,47,159,207,213,191,204,228,17,151,246,223,224,247,50,70,178,233,15,62,112,146,2,85,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadTypeEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14d7ab42-1904-4ceb-a923-3c60c1b5cd3a"));
		}

		#endregion

	}

	#endregion

}

