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

	#region Class: BaseImageLookupEditPageSchema

	/// <exclude/>
	public class BaseImageLookupEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.FileUploadEdit _imageEdit;
		public Terrasoft.UI.WebControls.Controls.FileUploadEdit ImageEdit {
			get {
				return _imageEdit;
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

		public BaseImageLookupEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseImageLookupEditPageSchema(BaseImageLookupEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			RealUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			Name = "BaseImageLookupEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseImageLookupEditPageEventsProcessSchema();
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
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.InsertItem(2, CreateImageEdit());
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

		protected virtual EmbeddedProcessSchema CreateBaseImageLookupEditPageEventsProcessSchema() {
			var schema = new BaseImageLookupEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateImageEdit() {
			_imageEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_imageEdit.UId = new Guid("2e06e037-0930-4352-adaa-f9c504889b89");
			_imageEdit.Name = "ImageEdit";
			_imageEdit.CreatedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			_imageEdit.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			_imageEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_imageEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_imageEdit.Tag = "";
			_imageEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_imageEdit.Image = new ControlImage {};
			_imageEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _imageEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageBox CreateImageBox() {
			_imageBox = new Terrasoft.UI.WebControls.Controls.ImageBox();
			_imageBox.UId = new Guid("2e9f72ad-a5ff-4795-b567-5764cef25dc0");
			_imageBox.Name = "ImageBox";
			_imageBox.CreatedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			_imageBox.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			_imageBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_imageBox.Tag = "";
			_imageBox.Image = new ControlImage {};
			_imageBox.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_imageBox.Width = System.Web.UI.WebControls.Unit.Pixel(50);
			_imageBox.Edges = "";
			return _imageBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseImageLookupEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseImageLookupEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseImageLookupEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseImageLookupEditPageEventsProcess

	/// <exclude/>
	public class BaseImageLookupEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseImageLookupEditPageSchemaUserControl
	{

		public BaseImageLookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseImageLookupEditPageEventsProcess";
			SchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
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
					SchemaElementUId = new Guid("7207bbf5-7920-4225-b818-30c2c1b756d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _imageEditChangeMessage;
		public ProcessFlowElement ImageEditChangeMessage {
			get {
				return _imageEditChangeMessage ?? (_imageEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ImageEditChangeMessage",
					SchemaElementUId = new Guid("d53f5ded-a424-493b-a0a1-38b2873356d0"),
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
					SchemaElementUId = new Guid("36637ce1-dc50-42dd-aca5-c56c73866bd1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("10b26550-91d0-4daf-b730-0e62cd487a0b"),
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
					SchemaElementUId = new Guid("85b3271f-0fea-446a-be4d-d123e6706f64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteThrowMessage;
		public ProcessThrowMessageEvent PageLoadCompleteThrowMessage {
			get {
				return _pageLoadCompleteThrowMessage ?? (_pageLoadCompleteThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteThrowMessage",
					SchemaElementUId = new Guid("dedeb81c-b327-482b-b612-fa8378481230"),
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
					SchemaElementUId = new Guid("1c7e5cd7-d987-46ae-b6d8-7d6d4c9b2fca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptExecute,
				});
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
			FlowElements[ImageEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ImageEditChangeMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadCompleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteMessage };
			FlowElements[PageLoadCompleteThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteThrowMessage };
			FlowElements[PageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ImageEditChangeMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadCompleteMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteThrowMessage");
						break;
					case "PageLoadCompleteThrowMessage":
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
			ActivatedEventElements.Add("ImageEditChangeMessage");
			ActivatedEventElements.Add("PageLoadCompleteMessage");
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
				case "ImageEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImageEditChangeMessage";
					result = ImageEditChangeMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteMessage";
					result = PageLoadCompleteMessage.Execute(context);
					break;
				case "PageLoadCompleteThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteThrowMessage.Execute(context);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var activeRow = Page.DataSource.ActiveRow;
			if (IsSysImageColumn()) {
				SaveImage();
			} else {
				var picture = new MemoryStream(Page.ImageEdit.FileBytes);
				Page.DataSource.ActiveRow.SetStreamValue("Image", picture);
				if (!IsCopy) {
					Page.DataSource.ActiveRow.Save();
				}
				InitializeModuleImages(Guid.Empty);
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			if (IsCopy && IsSysImageColumn()) {
				CopyImage();
			} else {
				InitializeModuleImages(Guid.Empty);
			}
			return true;
		}

		public virtual void InitializeModuleImages(Guid imageId) {
			var activeRow = Page.DataSource.ActiveRow;
			if (IsSysImageColumn()) {
				var sysImageId = activeRow.GetTypedColumnValue<Guid>("ImageId");
				var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysImage");
				var schemaDataColumn = schema.Columns.FindByName("Data");
				var controlImage = new ControlImage();
				if (!sysImageId.Equals(Guid.Empty)) {
					controlImage.Source = ControlImageSource.EntityColumn;
					controlImage.SchemaUId = schema.UId;
					controlImage.EntityPrimaryColumnValue = sysImageId;
					controlImage.EntitySchemaColumnUId = schemaDataColumn.UId;
					var esq = new EntitySchemaQuery(schema);
					var nameColumn = esq.AddColumn("Name").Name;
					var sysImage = esq.GetEntity(UserConnection, sysImageId);
					if (sysImage != null) {
						Page.ImageEdit.Text = sysImage.GetTypedColumnValue<string>(nameColumn);
					}
				} else {
					controlImage.Source = ControlImageSource.None;
				}
				controlImage.ResetCache();
				Page.ImageBox.SetImage(controlImage);
				Page.ImageBox.Hidden = false;
			} else if ((activeRow.GetStreamValue("Image") != null && activeRow.GetStreamValue("Image").Length > 0) || activeRow.GetColumnValue("Image") != null) {
				var controlImage = new ControlImage();
				controlImage.Source = ControlImageSource.EntityColumn;
				controlImage.SchemaUId = Page.DataSource.SchemaUId;
				controlImage.EntityPrimaryColumnValue = activeRow.PrimaryColumnValue;
				controlImage.EntitySchemaColumnUId = Page.DataSource.Schema.Columns.GetByName("Image").UId;
				controlImage.UsePrimaryImageColumn = false;
				controlImage.UsePrimaryImageColumn = true;
				controlImage.UsePrimaryImageColumn = false;	
				controlImage.ResetCache();
				Page.ImageBox.Image = controlImage;	
				Page.ImageBox.Hidden = false;
			} else {
				Page.ImageBox.Hidden = true;
			}
		}

		public virtual void SaveImage() {
			var activeRow = Page.DataSource.ActiveRow;
			Terrasoft.Core.ImageAPI.ImageAPI imageApi = new Core.ImageAPI.ImageAPI(UserConnection);
			if (Page.ImageEdit.HasFile) {
				string fileName = Page.ImageEdit.FileName;
				Stream stream = new System.IO.MemoryStream(Page.ImageEdit.FileBytes);
				string mimeType = GetMimeType(stream);
				if (string.IsNullOrEmpty(mimeType) || !mimeType.Contains("image")) {
					Page.BaseMessagePanel.Clear();
					Page.BaseMessagePanel.AddMessage(Warning, WrongFileFormat);
					Page.ImageEdit.Clear();
					return;
				}
				Guid imageId = imageApi.Save(stream, mimeType, fileName);
				stream.Close();
				activeRow.SetColumnValue("ImageId", imageId);
				InitializeModuleImages(imageId);
			} else {
				activeRow.SetColumnValue("ImageId", null);
				InitializeModuleImages(Guid.Empty);
			}
		}

		public virtual string GetMimeType(Stream stream) {
			string mimeType = null;
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

		public virtual void CopyImage() {
			var activeRow = Page.DataSource.ActiveRow;
			var sysImageId = activeRow.GetTypedColumnValue<Guid>("ImageId");
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysImage");
			if (!sysImageId.Equals(Guid.Empty)) {
				var esq = new EntitySchemaQuery(schema);
				esq.AddColumn("Name");
				esq.AddColumn("Data");
				esq.AddColumn("PreviewData");
				esq.AddColumn("MimeType");
				esq.AddColumn("HasRef");
				var sysImage = esq.GetEntity(UserConnection, sysImageId);
				if (sysImage != null) {
					var newImageGuid = Guid.NewGuid();
					var imageFile = schema.CreateEntity(UserConnection);
					imageFile.SetDefColumnValues();
					imageFile.SetColumnValue("Id", newImageGuid);
					imageFile.SetColumnValue("Name", sysImage.GetTypedColumnValue<string>("Name"));
					imageFile.SetStreamValue("Data", sysImage.GetStreamValue("Data"));
					imageFile.SetColumnValue("MimeType", sysImage.GetTypedColumnValue<string>("MimeType"));
					imageFile.SetColumnValue("HasRef", sysImage.GetTypedColumnValue<int>("HasRef"));
					imageFile.SetStreamValue("PreviewData", sysImage.GetStreamValue("PreviewData"));
					imageFile.Save();
					activeRow.SetColumnValue("ImageId", newImageGuid);
					InitializeModuleImages(newImageGuid);
				}
			}
		}

		public virtual bool IsSysImageColumn() {
			var activeRow = Page.DataSource.ActiveRow;
			var imageColumn = activeRow.Schema.FindSchemaColumnByPath("Image");
			if (imageColumn != null && imageColumn.ReferenceSchema != null && imageColumn.ReferenceSchema.Name == "SysImage") {
				return true;
			}
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ImageEditChange":
							if (ActivatedEventElements.Contains("ImageEditChangeMessage")) {
							context.QueueTasks.Enqueue("ImageEditChangeMessage");
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseImageLookupEditPageEventsProcess

	/// <exclude/>
	public class BaseImageLookupEditPageEventsProcess : BaseImageLookupEditPageEventsProcess<Terrasoft.WebApp.BaseImageLookupEditPageSchemaUserControl>
	{

		public BaseImageLookupEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseImageLookupEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseImageLookupEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.FileUploadEdit ImageEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadEdit)PageContainer.FindPageControl("ImageEdit", true);
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
			NameEdit.AjaxEvents.Change.Event += NameEditChange;
			ImageEdit.AjaxEvents.Change.Event += ImageEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			NameEdit.AjaxEvents.Change.Event -= NameEditChange;
			ImageEdit.AjaxEvents.Change.Event -= ImageEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseImageLookupEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseImageLookupEditPageEventsProcess(UserConnection);
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

		public virtual void NameEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("NameEditChange");
		}

		public virtual void ImageEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ImageEditChange");
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
			SchemaName = "BaseImageLookupEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseImageLookupEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseImageLookupEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseImageLookupEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseImageLookupEditPageEventsProcessSchema(BaseImageLookupEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseImageLookupEditPageEventsProcess";
			UId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected override ProcessSchemaParameter CreateIsSchemaBlockedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e94b7441-fe92-4ee4-8d4f-87b19243ba8f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsSchemaBlocked",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsBasePageSchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("90d70a5e-6760-4c16-aee5-72ae0d658bcf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsBasePageSchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsBasePageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a6ae48c2-3893-4327-b7ae-32a2ebe53f95"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsBasePage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateFolderUidBasePageEntityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba3f4652-ef88-479e-b84a-48d63b1d2182"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"FolderUidBasePageEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override ProcessSchemaParameter CreatePrimaryEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("991a5f57-ead8-475e-a652-57483dd1e1e9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"PrimaryEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent imageeditchangemessage = CreateImageEditChangeMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(imageeditchangemessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent pageloadcompletemessage = CreatePageLoadCompleteMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcompletemessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompletethrowmessage = CreatePageLoadCompleteThrowMessageIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcompletethrowmessage);
			ProcessSchemaScriptTask pageloadcompletescript = CreatePageLoadCompleteScriptScriptTask();
			eventsubprocess2.FlowElements.Add(pageloadcompletescript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWrongFileFormatLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWrongFileFormatLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9195e87e-d037-471a-995f-afa61e2b27da"),
				Name = "WrongFileFormat",
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("8f189c68-3205-44cc-b1cb-b63beb686182"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d53f5ded-a424-493b-a0a1-38b2873356d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36637ce1-dc50-42dd-aca5-c56c73866bd1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a7655603-ccfb-42a2-a021-3e0bf34747e1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CurveCenterPosition = new Point(426, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("85b3271f-0fea-446a-be4d-d123e6706f64"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dedeb81c-b327-482b-b612-fa8378481230"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("edc08741-7b67-40bd-b3a4-e1d907202534"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CurveCenterPosition = new Point(518, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dedeb81c-b327-482b-b612-fa8378481230"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c7e5cd7-d987-46ae-b6d8-7d6d4c9b2fca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ea6d36fe-a4c3-45d2-83d6-3548b7e6329f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1198, 170),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("910ec9c3-e37e-4f8b-b266-76c88296c5bb"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ea6d36fe-a4c3-45d2-83d6-3548b7e6329f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1169, 170),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7207bbf5-7920-4225-b818-30c2c1b756d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("910ec9c3-e37e-4f8b-b266-76c88296c5bb"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImageEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d53f5ded-a424-493b-a0a1-38b2873356d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7207bbf5-7920-4225-b818-30c2c1b756d9"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ImageEditChange",
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"ImageEditChangeMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("36637ce1-dc50-42dd-aca5-c56c73866bd1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7207bbf5-7920-4225-b818-30c2c1b756d9"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"ScriptTask1",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,187,106,196,48,16,69,107,27,252,15,202,86,50,4,253,192,146,34,217,71,112,177,16,34,72,63,216,179,203,128,100,25,105,228,69,9,251,239,145,101,92,38,197,52,243,56,247,204,12,94,64,207,52,227,167,187,139,23,241,1,55,84,71,96,208,46,250,30,213,235,54,219,55,53,93,133,236,130,78,161,179,121,235,224,76,180,163,108,91,241,211,212,149,134,25,75,91,182,121,243,33,208,4,44,131,57,7,76,212,115,244,152,241,35,222,197,5,173,243,73,179,71,176,178,228,149,195,211,64,172,206,100,240,45,49,134,133,82,253,41,163,52,242,10,248,2,19,81,238,10,97,247,188,37,149,235,69,247,169,11,7,55,165,213,241,63,94,214,47,230,213,35,87,55,18,19,24,250,198,139,27,162,89,31,11,242,61,210,160,78,118,226,84,126,108,106,143,57,108,20,236,35,238,127,1,161,92,82,44,73,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("10b26550-91d0-4daf-b730-0e62cd487a0b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("910ec9c3-e37e-4f8b-b266-76c88296c5bb"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(320, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("85b3271f-0fea-446a-be4d-d123e6706f64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10b26550-91d0-4daf-b730-0e62cd487a0b"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"PageLoadCompleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("dedeb81c-b327-482b-b612-fa8378481230"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10b26550-91d0-4daf-b730-0e62cd487a0b"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"PageLoadCompleteThrowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1c7e5cd7-d987-46ae-b6d8-7d6d4c9b2fca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10b26550-91d0-4daf-b730-0e62cd487a0b"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Name = @"PageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,118,206,47,168,84,80,83,83,240,44,14,174,44,246,204,77,76,79,117,206,207,41,205,205,211,208,212,84,168,230,229,226,4,201,131,133,53,52,173,121,185,106,21,82,115,138,83,193,18,158,121,153,37,153,137,57,153,85,169,190,249,41,165,57,169,96,69,197,26,238,165,153,41,122,174,185,5,37,149,96,245,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,63,204,4,212,115,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitializeModuleImagesMethod());
			Methods.Add(CreateSaveImageMethod());
			Methods.Add(CreateGetMimeTypeMethod());
			Methods.Add(CreateCopyImageMethod());
			Methods.Add(CreateIsSysImageColumnMethod());
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
				UId = new Guid("afe423c4-8cce-4471-9bed-65f28b69e1b4"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4ccf419f-1986-439e-ac12-e87aa0332379"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c")
			});
		}

		protected virtual SchemaMethod CreateInitializeModuleImagesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa6f201b-8fb9-43b8-833e-2a3b87c26f61"),
				Name = "InitializeModuleImages",
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0c647301-b19f-4a63-8c61-7e98dbdab10e"),
				Name = "imageId",
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,79,227,48,16,61,23,137,255,96,114,64,142,132,172,189,151,173,4,221,194,86,218,69,44,129,189,91,201,80,34,37,14,216,78,33,130,254,119,198,31,73,92,146,178,101,47,137,18,207,123,243,230,205,140,215,92,18,158,234,124,13,55,213,51,249,78,174,249,10,216,15,174,121,82,213,50,5,118,214,158,77,15,15,242,123,66,151,42,105,212,178,196,168,121,85,212,165,160,113,76,94,15,15,38,107,228,81,254,100,153,33,81,71,202,46,65,223,54,143,144,57,192,95,94,212,112,122,89,231,217,140,70,62,60,138,167,45,69,250,0,37,71,248,157,2,57,175,132,0,164,169,4,91,8,157,235,38,177,167,191,185,64,148,52,188,75,161,52,23,41,156,55,87,188,4,26,181,218,62,18,154,130,92,122,164,118,191,152,251,86,236,34,23,89,139,55,113,61,54,173,132,150,85,97,25,17,39,224,153,204,131,95,212,6,26,83,142,250,202,217,226,169,230,133,162,166,64,182,40,31,117,227,13,154,132,108,204,185,139,164,33,161,183,220,213,234,228,77,135,72,171,254,206,122,236,43,193,143,97,156,99,185,150,121,201,101,19,88,111,96,157,218,93,48,151,196,161,194,84,189,143,93,82,99,20,168,39,239,79,8,255,83,131,108,168,3,198,93,172,64,163,187,86,32,144,157,101,126,50,104,100,154,16,197,204,188,186,248,86,172,143,198,166,187,28,116,123,66,78,130,170,92,50,211,152,14,124,132,242,234,162,240,173,152,216,41,183,39,139,44,215,236,22,94,116,224,203,232,196,42,45,115,177,154,209,94,191,75,179,193,199,134,64,161,224,139,109,190,170,132,173,210,16,108,129,110,64,129,158,115,244,205,77,88,47,246,188,122,97,9,78,189,157,190,16,51,18,247,51,207,50,48,30,223,227,56,154,68,94,164,177,133,110,45,103,162,37,240,210,86,233,55,50,138,91,195,200,241,49,249,103,48,251,5,98,165,31,200,140,124,139,201,219,219,54,32,240,112,192,222,95,29,123,173,218,127,111,208,206,5,250,120,219,117,103,3,212,39,235,212,151,59,60,222,193,51,220,175,113,37,221,37,133,70,182,119,84,107,250,152,74,220,9,175,33,184,162,131,25,216,47,90,203,17,225,159,83,79,190,54,196,109,159,67,136,229,216,111,134,95,119,71,122,237,155,119,5,224,23,152,216,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveImageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ea35b4e5-5ef0-4332-8fff-da939b84dedf"),
				Name = "SaveImage",
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,75,110,194,48,16,93,131,196,29,92,86,70,66,190,64,213,5,80,160,89,4,80,67,203,122,68,6,100,201,31,100,59,160,180,112,247,58,54,14,168,106,171,46,162,204,196,207,239,51,147,35,24,2,91,199,143,248,170,79,228,137,172,96,143,236,25,28,20,186,50,91,100,163,116,246,216,235,174,209,24,176,122,231,216,68,27,100,153,244,216,209,42,107,11,194,67,113,224,158,71,225,137,252,140,162,111,22,205,68,43,133,158,90,171,129,39,230,59,66,131,112,192,76,75,238,216,11,216,25,23,56,32,159,189,110,199,58,195,213,158,236,252,135,5,72,76,54,111,232,217,245,196,115,117,10,103,16,36,177,241,21,157,20,181,117,40,89,182,100,57,74,109,234,136,249,174,217,176,140,107,135,182,241,148,68,37,151,184,174,15,141,232,28,93,126,237,104,164,15,192,198,125,4,179,204,46,42,33,150,102,42,15,174,166,233,234,128,156,207,228,33,117,126,120,202,1,87,150,246,195,188,250,131,24,178,19,220,140,193,98,142,214,250,122,5,10,5,155,8,4,67,131,208,47,136,81,89,94,123,186,1,163,188,143,33,217,24,173,246,77,158,153,54,18,220,221,245,91,220,123,102,131,174,50,170,41,47,254,153,87,188,140,203,204,74,159,59,173,149,21,112,76,201,135,237,96,134,237,94,210,216,252,177,39,215,22,35,121,251,123,177,2,221,68,139,74,170,119,16,21,210,126,22,37,250,195,36,22,240,153,226,142,131,224,31,152,235,178,18,24,80,150,222,65,46,4,133,197,48,181,255,144,43,191,147,191,152,155,184,44,172,44,144,127,1,161,132,134,142,19,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMimeTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42408f8a-5767-48a2-ae15-f6fd473f24fc"),
				Name = "GetMimeType",
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0163ca43-1c2f-4418-9798-f340688f5822"),
				Name = "stream",
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				ModifiedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Stream",
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,193,170,194,64,12,60,183,208,127,136,183,246,146,15,176,84,15,150,150,30,228,129,190,31,88,214,168,11,221,86,178,217,39,69,252,247,215,237,162,120,240,146,48,73,102,152,137,19,54,195,5,172,177,244,59,221,8,42,24,124,223,151,89,42,60,193,35,75,19,239,194,62,63,78,78,200,98,205,234,62,99,236,172,186,16,152,165,86,240,109,137,13,143,246,40,76,202,230,110,105,69,177,8,38,127,138,65,143,39,210,223,153,111,133,93,184,233,134,243,136,45,201,50,169,41,240,216,229,69,208,73,176,49,236,228,135,107,58,43,223,75,62,11,110,64,99,51,178,85,210,213,80,85,209,33,30,212,61,14,177,245,230,84,148,129,253,145,56,154,89,197,232,176,141,24,247,175,131,245,235,37,201,51,75,159,160,149,232,107,72,50,35,38,241,60,188,191,87,254,3,152,203,65,255,78,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyImageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ce5b7a7-1c06-45c8-aae2-5b3d523082d9"),
				Name = "CopyImage",
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,75,110,194,48,16,93,131,196,29,66,86,70,66,190,64,91,164,22,40,205,2,68,73,219,189,149,12,212,146,227,64,236,36,74,43,238,94,219,9,249,40,110,211,149,23,239,51,51,111,70,206,72,226,144,64,210,12,14,113,238,60,56,123,114,2,188,34,146,248,113,154,4,128,31,111,216,221,100,156,41,174,40,132,23,41,142,23,42,114,45,196,27,144,111,197,25,194,101,204,210,136,127,16,150,194,253,38,165,225,2,185,21,221,157,221,28,130,79,136,136,82,191,11,72,150,49,231,160,92,98,142,215,92,82,89,248,6,221,18,174,68,137,182,245,184,144,132,7,240,84,236,72,4,200,245,171,6,140,31,61,58,104,218,180,132,215,151,148,48,129,116,101,188,142,206,178,152,205,156,239,201,120,164,235,130,184,168,162,28,114,167,93,233,53,133,164,64,101,79,218,113,164,104,248,49,172,6,65,174,46,234,218,0,157,145,21,216,39,144,81,200,127,197,183,52,2,157,149,21,124,33,226,0,199,18,106,199,173,58,215,76,149,71,217,60,234,134,55,111,237,197,104,117,48,181,118,170,198,78,25,43,163,48,182,42,5,3,233,160,148,181,201,107,7,185,126,145,209,27,22,213,148,103,202,116,245,50,33,188,76,128,72,176,246,80,234,106,13,246,65,174,224,216,58,8,129,44,148,22,174,78,37,116,231,157,222,134,4,102,59,205,240,214,51,20,50,161,252,180,184,173,210,98,233,75,53,85,84,89,154,189,117,45,251,184,205,165,211,88,189,228,255,54,215,92,197,144,117,117,34,3,198,148,203,69,115,78,67,67,183,111,246,143,217,59,167,221,243,36,25,84,27,110,254,133,222,134,171,207,192,182,102,143,83,73,9,163,95,176,141,195,148,129,129,5,234,17,175,147,241,245,7,166,211,36,99,183,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsSysImageColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8527f2ef-4ee4-4360-8597-508bfc0d9428"),
				Name = "IsSysImageColumn",
				CreatedInSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"),
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,77,10,194,48,16,70,215,22,114,135,177,139,82,55,185,64,201,194,31,4,55,82,218,19,12,113,98,3,73,10,105,82,41,226,221,141,180,74,151,238,134,153,247,189,249,70,244,128,50,232,145,154,254,1,2,106,188,19,63,97,192,182,143,94,18,223,127,111,21,203,198,196,106,155,128,99,111,162,117,137,254,37,121,43,59,178,200,207,218,221,230,113,102,14,83,141,161,43,243,203,39,150,239,146,68,43,40,215,146,173,0,23,141,129,162,88,187,121,67,138,60,57,73,179,237,79,140,95,209,18,8,1,121,59,13,203,79,120,178,108,227,41,68,239,32,248,72,169,195,139,101,203,66,161,25,168,122,3,170,232,254,207,5,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseImageLookupEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0"));
		}

		#endregion

	}

	#endregion

}

