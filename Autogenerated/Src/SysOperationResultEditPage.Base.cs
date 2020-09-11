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

	#region Class: SysOperationResultEditPageSchema

	/// <exclude/>
	public class SysOperationResultEditPageSchema : Terrasoft.WebApp.BaseCodeLookupEditPageSchema
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

		public SysOperationResultEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysOperationResultEditPageSchema(SysOperationResultEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("99c044b8-3654-4f56-9575-1f7c4791483e");
			NameEdit.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateCodeEdit() {
			CodeEdit.Image = new ControlImage {};
			CodeEdit.ColumnUId = new Guid("8bb02161-6af1-4bbd-a827-84aef678a4a4");
			CodeEdit.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("d5cd6d77-ee31-4bf6-94d3-3741cbb70664");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			RealUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			Name = "SysOperationResultEditPage";
			ParentSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			Height = 290;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysOperationResultEditPageEventsProcessSchema();
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
			UpdateCodeEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, CodeEdit);
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.InsertItem(3, CreateImageEdit());
			MainControlLayout.InsertItem(4, CreateImageBox());
			MainControlLayout.MoveItem(5, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateSysOperationResultEditPageEventsProcessSchema() {
			var schema = new SysOperationResultEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateImageEdit() {
			_imageEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_imageEdit.UId = new Guid("c1c6cbad-c400-45dd-957b-d783a228dd2c");
			_imageEdit.Name = "ImageEdit";
			_imageEdit.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			_imageEdit.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			_imageEdit.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			_imageEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_imageEdit.Tag = "";
			_imageEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_imageEdit.Image = new ControlImage {};
			_imageEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _imageEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageBox CreateImageBox() {
			_imageBox = new Terrasoft.UI.WebControls.Controls.ImageBox();
			_imageBox.UId = new Guid("9b9f5d8c-21e8-4423-bd8b-16b99f0d05f3");
			_imageBox.Name = "ImageBox";
			_imageBox.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			_imageBox.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			_imageBox.CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			_imageBox.Tag = "";
			_imageBox.Image = new ControlImage {};
			_imageBox.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_imageBox.Width = System.Web.UI.WebControls.Unit.Pixel(50);
			_imageBox.Edges = "";
			return _imageBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e");
			DataSource.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e77dd097-aabe-4a0c-8b5d-d71d2182a3c0");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("164a5d6b-8154-4478-a526-65c6b60b5405");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("d0c3cb49-2428-4989-8913-c238d58b665c");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("0bd5dc96-357e-4414-9f4a-1a90c2c13163");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("8bbf4506-27f6-41d4-a65e-bf4be6cb8baf");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("99c044b8-3654-4f56-9575-1f7c4791483e");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("d5cd6d77-ee31-4bf6-94d3-3741cbb70664");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("8bb02161-6af1-4bbd-a827-84aef678a4a4");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("d138b3ca-acb2-4d40-9271-705fa4eed615");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("59993ff0-1373-4acf-9eff-e2cec861f065");
			if (column != null) {
				column.UId = new Guid("a5cbacc5-7a42-43d9-8833-a4cde2cf3a3e");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
				column.ModifiedInSchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
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
			return new SysOperationResultEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysOperationResultEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysOperationResultEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationResultEditPageEventsProcess

	/// <exclude/>
	public class SysOperationResultEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysOperationResultEditPageSchemaUserControl
	{

		public SysOperationResultEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysOperationResultEditPageEventsProcess";
			SchemaUId = new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a673fa5f-2f9f-43e6-842c-5369bac76010");
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
					SchemaElementUId = new Guid("73f665ea-a1ab-4837-8749-9d8c95fab75e"),
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
					SchemaElementUId = new Guid("498e0a0f-e71d-4c77-9c0b-251c991939ce"),
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
					SchemaElementUId = new Guid("9e0e51a9-508c-4a3c-8dd6-1e31abefc24a"),
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
					SchemaElementUId = new Guid("2b71e6ce-64d1-4b99-a5d1-48ae62899053"),
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
					SchemaElementUId = new Guid("f2ba1e00-193a-4970-8951-779931c2ee2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("e434a97e-a742-47c1-b7d8-f4e952817377"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptExecute,
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
					SchemaElementUId = new Guid("21bb51ff-2638-46aa-80cc-83e0dae8161f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
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
			FlowElements[PageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScript };
			FlowElements[PageLoadCompleteThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteThrowMessage };
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
					case "PageLoadCompleteScript":
						break;
					case "PageLoadCompleteThrowMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScript");
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
				case "PageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScript";
					result = PageLoadCompleteScript.Execute(context, PageLoadCompleteScriptExecute);
					break;
				case "PageLoadCompleteThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteThrowMessage.Execute(context);
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
			Guid imageId = activeRow.GetTypedColumnValue<Guid>("ImageId");
			MemoryStream imageData = new MemoryStream(Page.ImageEdit.FileBytes);
			if (imageData != null && imageData.Length > 0 && imageId == Guid.Empty) {
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysImage");
				var entity = entitySchema.CreateEntity(UserConnection);
				entity.SetDefColumnValues();
				imageId = entity.PrimaryColumnValue; 
				entity.SetColumnValue("Name", Page.ImageEdit.FileName);
				entity.SetStreamValue("Data", imageData);
				if(!entity.Save()){
					return false;
				}
			}
			activeRow.SetColumnValue("ImageId", imageId);
			if (!IsNew && !IsCopy) {
				Page.DataSource.ActiveRow.Save();
			}
			InitializeModuleImages();
			return true;
		}

		public virtual bool PageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			InitializeModuleImages();
			return true;
		}

		public virtual void InitializeModuleImages() {
			Guid imageId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ImageId");
			if (imageId != Guid.Empty) {
				EntitySchemaManager esm = UserConnection.EntitySchemaManager;
				EntitySchema imageEntitySchema = esm.FindInstanceByName("SysImage");
				var controlImage = new ControlImage();
				controlImage.Source = ControlImageSource.EntityColumn;
				controlImage.SchemaUId = imageEntitySchema.UId;
				controlImage.EntityPrimaryColumnValue = imageId;
				controlImage.EntitySchemaColumnUId = imageEntitySchema.Columns.GetByName("Data").UId;
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

	#region Class: SysOperationResultEditPageEventsProcess

	/// <exclude/>
	public class SysOperationResultEditPageEventsProcess : SysOperationResultEditPageEventsProcess<Terrasoft.WebApp.SysOperationResultEditPageSchemaUserControl>
	{

		public SysOperationResultEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysOperationResultEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysOperationResultEditPageSchemaUserControl : Terrasoft.WebApp.BaseCodeLookupEditPageSchemaUserControl
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
			ImageEdit.AjaxEvents.Change.Event += ImageEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ImageEdit.AjaxEvents.Change.Event -= ImageEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysOperationResultEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysOperationResultEditPageEventsProcess(UserConnection);
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
			SchemaName = "SysOperationResultEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationResultEditPageEventsProcessSchema

	/// <exclude/>
	public class SysOperationResultEditPageEventsProcessSchema : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysOperationResultEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysOperationResultEditPageEventsProcessSchema(SysOperationResultEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysOperationResultEditPageEventsProcess";
			UId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01");
			CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35");
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
			ProcessSchemaScriptTask pageloadcompletescript = CreatePageLoadCompleteScriptScriptTask();
			eventsubprocess2.FlowElements.Add(pageloadcompletescript);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompletethrowmessage = CreatePageLoadCompleteThrowMessageIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcompletethrowmessage);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6917eb6b-b1aa-4976-9019-8fad120a3fae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("498e0a0f-e71d-4c77-9c0b-251c991939ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e0e51a9-508c-4a3c-8dd6-1e31abefc24a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("de6332c9-23d9-475b-8b99-f8d5193fae76"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				CurveCenterPosition = new Point(400, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2ba1e00-193a-4970-8951-779931c2ee2b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("21bb51ff-2638-46aa-80cc-83e0dae8161f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("ed6a45f0-1a3d-4716-b889-c0838a181311"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				CurveCenterPosition = new Point(400, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21bb51ff-2638-46aa-80cc-83e0dae8161f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e434a97e-a742-47c1-b7d8-f4e952817377"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c48d4536-4be1-47d1-8b79-e07c63de23b0"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(617, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ec69a8b7-3f47-4aa2-8734-85c9a761024a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("c48d4536-4be1-47d1-8b79-e07c63de23b0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(588, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("73f665ea-a1ab-4837-8749-9d8c95fab75e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec69a8b7-3f47-4aa2-8734-85c9a761024a"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImageEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("498e0a0f-e71d-4c77-9c0b-251c991939ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73f665ea-a1ab-4837-8749-9d8c95fab75e"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ImageEditChange",
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"ImageEditChangeMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9e0e51a9-508c-4a3c-8dd6-1e31abefc24a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73f665ea-a1ab-4837-8749-9d8c95fab75e"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"ScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,77,107,194,64,16,61,43,248,31,214,28,100,3,178,244,110,21,218,104,37,80,69,154,182,247,37,153,232,194,102,87,54,155,72,90,250,223,59,155,15,19,165,133,28,194,206,123,111,222,188,153,146,27,194,99,43,74,120,211,23,178,36,7,126,4,182,230,150,71,186,48,49,176,167,174,182,152,140,183,133,72,136,200,16,17,38,8,189,210,216,22,236,123,117,134,36,208,178,200,212,39,151,5,60,58,240,138,122,97,3,247,124,228,239,32,211,166,138,172,1,158,53,58,174,17,42,41,184,144,97,145,214,46,106,234,38,17,150,189,8,9,207,149,133,220,169,136,148,208,158,60,69,118,33,37,153,205,122,69,246,10,234,104,79,100,69,30,174,239,206,241,146,56,83,108,147,157,109,229,147,239,201,120,84,226,244,160,172,176,85,20,159,32,115,94,62,114,48,129,86,10,112,58,173,216,102,80,221,113,133,74,198,141,27,170,220,114,21,163,171,61,207,128,122,81,149,215,118,235,57,7,178,40,56,212,103,1,142,103,161,17,165,183,173,106,102,3,102,17,216,53,164,131,56,115,90,151,251,240,91,224,193,224,147,169,6,200,5,185,145,25,84,168,231,188,122,115,242,71,186,174,114,103,160,89,69,203,116,177,34,243,26,113,227,38,165,211,14,207,75,160,190,239,50,29,25,176,133,81,36,229,50,7,7,251,153,140,241,235,175,229,222,85,119,34,243,110,83,221,150,167,97,190,199,203,192,21,226,95,160,207,237,210,254,61,209,214,197,162,238,23,42,97,5,151,226,11,118,58,41,36,212,93,154,24,91,131,214,96,90,191,212,255,239,179,0,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2b71e6ce-64d1-4b99-a5d1-48ae62899053"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec69a8b7-3f47-4aa2-8734-85c9a761024a"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f2ba1e00-193a-4970-8951-779931c2ee2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b71e6ce-64d1-4b99-a5d1-48ae62899053"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"PageLoadCompleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e434a97e-a742-47c1-b7d8-f4e952817377"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b71e6ce-64d1-4b99-a5d1-48ae62899053"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"PageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,201,76,204,201,172,74,245,205,79,41,205,73,245,204,77,76,79,45,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,113,59,217,52,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("21bb51ff-2638-46aa-80cc-83e0dae8161f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b71e6ce-64d1-4b99-a5d1-48ae62899053"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				Name = @"PageLoadCompleteThrowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 65),
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
			Methods.Add(CreateInitializeModuleImagesMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5b2f5de1-3399-4b62-baf1-b53c5fa7e849"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
		}

		protected virtual SchemaMethod CreateInitializeModuleImagesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0355dfb2-2217-41e2-b8b3-a412708584f1"),
				Name = "InitializeModuleImages",
				CreatedInSchemaUId = new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,110,131,48,16,133,215,68,202,29,92,86,176,241,5,82,42,53,52,165,44,90,69,161,233,222,130,73,107,9,236,200,54,73,81,149,187,119,176,65,114,126,144,178,51,227,239,189,121,204,56,107,121,69,120,195,190,33,175,72,66,214,120,160,47,204,176,66,182,170,4,250,92,26,126,128,141,60,210,12,204,103,183,135,42,149,117,219,136,47,86,183,240,152,161,248,41,10,115,39,15,227,197,124,198,119,36,26,237,30,18,210,19,116,213,236,77,23,147,191,249,44,88,9,195,77,87,148,63,208,176,119,38,144,83,4,116,131,157,183,26,84,42,133,0,236,40,5,189,1,46,46,244,46,246,89,37,233,205,232,43,23,85,46,180,97,162,132,101,247,193,26,136,194,162,211,54,166,13,25,28,152,34,165,20,70,201,218,86,81,40,224,72,82,175,20,89,208,135,168,155,9,178,62,55,12,202,197,112,195,185,22,218,116,91,59,225,171,208,20,235,87,10,7,172,21,210,170,243,70,62,26,76,74,156,167,83,76,53,116,183,186,95,233,56,158,126,229,97,124,51,10,46,102,200,97,191,157,24,125,119,172,214,112,55,109,84,123,63,236,172,131,75,124,3,26,76,202,240,39,220,114,236,99,181,87,75,249,75,199,69,250,18,235,113,142,189,241,170,2,63,255,137,0,30,236,235,156,32,135,236,167,127,15,202,155,221,44,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysOperationResultEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96ecd4e0-4610-46d8-8e82-230a95d4ac01"));
		}

		#endregion

	}

	#endregion

}

