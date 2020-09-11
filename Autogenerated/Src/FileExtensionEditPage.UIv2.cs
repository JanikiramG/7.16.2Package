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
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: FileExtensionEditPageSchema

	/// <exclude/>
	public class FileExtensionEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.FileUploadEdit _imageUploadEdit;
		public Terrasoft.UI.WebControls.Controls.FileUploadEdit ImageUploadEdit {
			get {
				return _imageUploadEdit;
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

		public FileExtensionEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public FileExtensionEditPageSchema(FileExtensionEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("e7a46524-e032-45cf-8008-4c1051b5cdc9");
			NameEdit.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("6bc7ef4e-3fff-41a1-a7c3-98634eb69752");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			RealUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			Name = "FileExtensionEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			Height = 300;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFileExtensionEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateImageUploadEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.InsertItem(3, CreateImageBox());
			MainControlLayout.MoveItem(4, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateFileExtensionEditPageEventsProcessSchema() {
			var schema = new FileExtensionEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateImageUploadEdit() {
			_imageUploadEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_imageUploadEdit.UId = new Guid("cd647448-437b-485e-ab92-ae1d42eb280c");
			_imageUploadEdit.Name = "ImageUploadEdit";
			_imageUploadEdit.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			_imageUploadEdit.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			_imageUploadEdit.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			_imageUploadEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_imageUploadEdit.Tag = "";
			_imageUploadEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_imageUploadEdit.Image = new ControlImage {};
			_imageUploadEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _imageUploadEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageBox CreateImageBox() {
			_imageBox = new Terrasoft.UI.WebControls.Controls.ImageBox();
			_imageBox.UId = new Guid("1bd8291c-171d-402f-898a-c31917b0393c");
			_imageBox.Name = "ImageBox";
			_imageBox.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			_imageBox.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			_imageBox.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			_imageBox.Tag = "";
			_imageBox.Image = new ControlImage {};
			_imageBox.Center = true;
			_imageBox.Height = System.Web.UI.WebControls.Unit.Pixel(128);
			_imageBox.Width = System.Web.UI.WebControls.Unit.Pixel(128);
			_imageBox.Edges = "";
			_imageBox.Hidden = true;
			return _imageBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			DataSource.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("64b0ae87-b202-49e1-ad7b-803c1bba3fef");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("69389c8d-20df-421c-a13e-a91c101e9971");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("03061fc8-35c2-4bc4-9cc0-30ccda626bba");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("58e25a22-9518-457c-b75a-5802042c577d");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("92c48df4-6e39-4e76-9deb-300a5e5cc21c");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("e7a46524-e032-45cf-8008-4c1051b5cdc9");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("6bc7ef4e-3fff-41a1-a7c3-98634eb69752");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("dc86f4f1-1224-4efb-898c-3f41d1ec812c");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e608b0e6-c188-4691-a044-a51a063485ea");
			if (column != null) {
				column.UId = new Guid("eb7db6c0-560b-4359-b3e9-3ddbecaf130e");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
				column.ModifiedInSchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
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
			return new FileExtensionEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new FileExtensionEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new FileExtensionEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: FileExtensionEditPageEventsProcess

	/// <exclude/>
	public class FileExtensionEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.FileExtensionEditPageSchemaUserControl
	{

		public FileExtensionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FileExtensionEditPageEventsProcess";
			SchemaUId = new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6e278d9d-f75c-487f-8e0f-d30a1f00927b");
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

		public virtual string FileDataValue {
			get;
			set;
		}

		private ProcessFlowElement _imageChangeSubProcess;
		public ProcessFlowElement ImageChangeSubProcess {
			get {
				return _imageChangeSubProcess ?? (_imageChangeSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ImageChangeSubProcess",
					SchemaElementUId = new Guid("80a7abd6-9f7c-4e4e-aed6-46dee76e4c16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _imageUploadEditChangeMessage;
		public ProcessFlowElement ImageUploadEditChangeMessage {
			get {
				return _imageUploadEditChangeMessage ?? (_imageUploadEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ImageUploadEditChangeMessage",
					SchemaElementUId = new Guid("44d67d9b-ae5b-4ef4-b5a1-fdc13fda5427"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _imageChangeScriptTask;
		public ProcessScriptTask ImageChangeScriptTask {
			get {
				return _imageChangeScriptTask ?? (_imageChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ImageChangeScriptTask",
					SchemaElementUId = new Guid("88a29de5-31cd-4676-8867-db197a96a727"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ImageChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("132fe583-b7ea-4323-8d57-e6d2e53eb704"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteMessage;
		public ProcessFlowElement PageLoadCompleteMessage {
			get {
				return _pageLoadCompleteMessage ?? (_pageLoadCompleteMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteMessage",
					SchemaElementUId = new Guid("4389f951-d898-45de-97c6-20221013823b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteMessageEvent;
		public ProcessThrowMessageEvent PageLoadCompleteMessageEvent {
			get {
				return _pageLoadCompleteMessageEvent ?? (_pageLoadCompleteMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteMessageEvent",
					SchemaElementUId = new Guid("2acf35a7-f261-4f6e-a29a-f585b5f6fcbf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initializeScriptTask;
		public ProcessScriptTask InitializeScriptTask {
			get {
				return _initializeScriptTask ?? (_initializeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitializeScriptTask",
					SchemaElementUId = new Guid("c14b8b83-5570-4732-b67b-d0ecc2143078"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitializeScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ImageChangeSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ImageChangeSubProcess };
			FlowElements[ImageUploadEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ImageUploadEditChangeMessage };
			FlowElements[ImageChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ImageChangeScriptTask };
			FlowElements[PageLoadCompleteSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteSubProcess };
			FlowElements[PageLoadCompleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteMessage };
			FlowElements[PageLoadCompleteMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteMessageEvent };
			FlowElements[InitializeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitializeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ImageChangeSubProcess":
						break;
					case "ImageUploadEditChangeMessage":
						e.Context.QueueTasks.Enqueue("ImageChangeScriptTask");
						break;
					case "ImageChangeScriptTask":
						break;
					case "PageLoadCompleteSubProcess":
						break;
					case "PageLoadCompleteMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteMessageEvent");
						break;
					case "PageLoadCompleteMessageEvent":
						e.Context.QueueTasks.Enqueue("InitializeScriptTask");
						break;
					case "InitializeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ImageUploadEditChangeMessage");
			ActivatedEventElements.Add("PageLoadCompleteMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ImageChangeSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ImageUploadEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImageUploadEditChangeMessage";
					result = ImageUploadEditChangeMessage.Execute(context);
					break;
				case "ImageChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImageChangeScriptTask";
					result = ImageChangeScriptTask.Execute(context, ImageChangeScriptTaskExecute);
					break;
				case "PageLoadCompleteSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteMessage";
					result = PageLoadCompleteMessage.Execute(context);
					break;
				case "PageLoadCompleteMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteMessageEvent.Execute(context);
					break;
				case "InitializeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitializeScriptTask";
					result = InitializeScriptTask.Execute(context, InitializeScriptTaskExecute);
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
				case "FileDataValue":
					FileDataValue = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ImageChangeScriptTaskExecute(ProcessExecutingContext context) {
			FileDataValue = System.Text.Encoding.Default.GetString(Page.ImageUploadEdit.FileBytes);
			Page.DataSource.ActiveRow.SetColumnValue("FileName", 
					Page.ImageUploadEdit.FileName);
			return true;
		}

		public virtual bool InitializeScriptTaskExecute(ProcessExecutingContext context) {
			string fileName = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("FileName");
			if (fileName != null && fileName != "") {
				if (IsCopy) {
					fileName = "";
				}
				Page.ImageUploadEdit.SetValue(fileName);
			}
			return true;
		}

		public override void BeforeSaveRowOnConditionsCorrect(Entity row) {
			if (FileDataValue != null) {
				var fileData = System.Text.Encoding.Default.GetBytes(FileDataValue);
				row.SetStreamValue("Data", new MemoryStream(fileData));
			}
			base.BeforeSaveRowOnConditionsCorrect(row);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ImageUploadEditChange":
							if (ActivatedEventElements.Contains("ImageUploadEditChangeMessage")) {
							context.QueueTasks.Enqueue("ImageUploadEditChangeMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteMessage");
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
			if (!HasMapping("FileDataValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileDataValue", FileDataValue, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: FileExtensionEditPageEventsProcess

	/// <exclude/>
	public class FileExtensionEditPageEventsProcess : FileExtensionEditPageEventsProcess<Terrasoft.WebApp.FileExtensionEditPageSchemaUserControl>
	{

		public FileExtensionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FileExtensionEditPageSchemaUserControl

	/// <exclude/>
	public partial class FileExtensionEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.FileUploadEdit ImageUploadEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadEdit)PageContainer.FindPageControl("ImageUploadEdit", true);
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
			ImageUploadEdit.AjaxEvents.Change.Event += ImageUploadEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ImageUploadEdit.AjaxEvents.Change.Event -= ImageUploadEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (FileExtensionEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new FileExtensionEditPageEventsProcess(UserConnection);
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

		public virtual void ImageUploadEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ImageUploadEditChange");
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
			SchemaName = "FileExtensionEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: FileExtensionEditPageEventsProcessSchema

	/// <exclude/>
	public class FileExtensionEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public FileExtensionEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FileExtensionEditPageEventsProcessSchema(FileExtensionEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FileExtensionEditPageEventsProcess";
			UId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04");
			CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
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

		protected virtual ProcessSchemaParameter CreateFileDataValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba786ef6-a5fe-4e25-a589-a4467e027a3f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"FileDataValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFileDataValueParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess imagechangesubprocess = CreateImageChangeSubProcessEventSubProcess();
			FlowElements.Add(imagechangesubprocess);
			ProcessSchemaEventSubProcess pageloadcompletesubprocess = CreatePageLoadCompleteSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletesubprocess);
			ProcessSchemaStartMessageEvent imageuploadeditchangemessage = CreateImageUploadEditChangeMessageStartMessageEvent();
			imagechangesubprocess.FlowElements.Add(imageuploadeditchangemessage);
			ProcessSchemaScriptTask imagechangescripttask = CreateImageChangeScriptTaskScriptTask();
			imagechangesubprocess.FlowElements.Add(imagechangescripttask);
			ProcessSchemaStartMessageEvent pageloadcompletemessage = CreatePageLoadCompleteMessageStartMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(pageloadcompletemessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompletemessageevent = CreatePageLoadCompleteMessageEventIntermediateThrowMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(pageloadcompletemessageevent);
			ProcessSchemaScriptTask initializescripttask = CreateInitializeScriptTaskScriptTask();
			pageloadcompletesubprocess.FlowElements.Add(initializescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("0a148a55-7b97-4e00-ad85-021e85c6287a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("44d67d9b-ae5b-4ef4-b5a1-fdc13fda5427"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88a29de5-31cd-4676-8867-db197a96a727"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("de685308-f560-4a95-a40e-4ef652d3fb75"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				CurveCenterPosition = new Point(544, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4389f951-d898-45de-97c6-20221013823b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2acf35a7-f261-4f6e-a29a-f585b5f6fcbf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f745201f-09e6-4b5b-b0d4-973a7ae18dac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				CurveCenterPosition = new Point(550, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2acf35a7-f261-4f6e-a29a-f585b5f6fcbf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c14b8b83-5570-4732-b67b-d0ecc2143078"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("082867ba-6723-4bdc-874e-55a1f76a71bb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(828, 186),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b3d51ddb-9d43-4b3e-a4fd-f47c5f41862b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("082867ba-6723-4bdc-874e-55a1f76a71bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(799, 186),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateImageChangeSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaImageChangeSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("80a7abd6-9f7c-4e4e-aed6-46dee76e4c16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3d51ddb-9d43-4b3e-a4fd-f47c5f41862b"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"ImageChangeSubProcess",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(361, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaImageChangeSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImageUploadEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("44d67d9b-ae5b-4ef4-b5a1-fdc13fda5427"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("80a7abd6-9f7c-4e4e-aed6-46dee76e4c16"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ImageUploadEditChange",
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"ImageUploadEditChangeMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateImageChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("88a29de5-31cd-4676-8867-db197a96a727"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("80a7abd6-9f7c-4e4e-aed6-46dee76e4c16"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"ImageChangeScriptTask",
				Position = new Point(183, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,141,203,10,194,48,20,68,215,45,248,15,161,171,10,114,127,160,184,80,219,138,27,17,163,238,67,59,150,64,30,146,222,168,253,123,155,238,221,204,98,56,115,166,213,6,181,98,245,80,38,66,108,133,156,70,134,165,27,190,76,141,235,124,175,221,64,53,158,42,26,166,35,88,114,152,155,242,162,6,208,201,206,121,127,25,175,250,166,215,76,237,236,218,79,140,113,93,173,242,133,72,102,233,99,232,64,187,142,245,27,87,255,33,9,62,120,19,173,91,62,203,34,205,206,202,162,216,136,85,158,101,127,213,137,73,230,0,142,193,9,14,17,213,15,136,96,179,59,191,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("132fe583-b7ea-4323-8d57-e6d2e53eb704"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3d51ddb-9d43-4b3e-a4fd-f47c5f41862b"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"PageLoadCompleteSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(435, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4389f951-d898-45de-97c6-20221013823b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("132fe583-b7ea-4323-8d57-e6d2e53eb704"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"PageLoadCompleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2acf35a7-f261-4f6e-a29a-f585b5f6fcbf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("132fe583-b7ea-4323-8d57-e6d2e53eb704"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"PageLoadCompleteMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitializeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c14b8b83-5570-4732-b67b-d0ecc2143078"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("132fe583-b7ea-4323-8d57-e6d2e53eb704"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40"),
				CreatedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"),
				Name = @"InitializeScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,142,79,11,130,64,16,197,207,10,126,135,105,15,161,151,253,2,102,16,246,7,47,17,89,221,23,29,101,97,221,149,117,182,144,232,187,167,22,226,97,6,230,241,230,247,94,71,86,234,26,42,169,240,44,26,132,4,46,162,70,190,23,36,114,227,108,129,124,87,144,124,226,213,188,248,9,233,214,183,88,166,70,185,70,63,132,114,184,233,166,255,109,200,142,127,2,139,226,192,151,21,132,51,114,149,128,118,74,193,122,13,75,141,177,8,222,129,239,141,222,172,75,77,219,255,110,111,209,133,177,1,230,125,134,153,90,101,205,176,239,173,50,162,60,148,146,120,142,52,181,152,179,198,236,193,109,145,156,213,64,214,97,252,5,206,124,101,177,225,0,0,0 }
			};
			
			return ScriptTask;
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
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6fecb014-62ff-41e9-a00c-1a4179518085"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bc0c1cbe-6662-42df-8c72-3964b92cd437"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
		}

		protected override SchemaMethod CreateBeforeSaveRowOnConditionsCorrectMethod() {
			SchemaMethod method = base.CreateBeforeSaveRowOnConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,203,14,130,48,20,68,215,146,240,15,87,86,109,98,250,3,132,13,160,174,140,137,53,238,43,220,154,38,165,77,218,11,72,140,255,46,248,88,184,157,51,115,198,104,96,59,99,177,86,164,46,202,246,8,235,2,92,111,45,135,71,154,172,6,21,64,127,49,20,32,167,72,216,137,51,222,73,108,93,227,91,227,110,162,70,173,122,75,98,143,84,78,132,241,223,199,243,89,19,252,40,36,146,164,128,170,123,199,44,91,26,217,6,28,142,112,192,206,135,233,67,217,239,142,47,203,103,154,92,85,68,81,162,246,1,165,26,240,228,199,163,171,188,107,13,25,239,98,229,67,192,134,216,252,192,243,23,201,52,61,11,205,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FileExtensionEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a257848-bcdc-48e2-9287-299463fbfd04"));
		}

		#endregion

	}

	#endregion

}

