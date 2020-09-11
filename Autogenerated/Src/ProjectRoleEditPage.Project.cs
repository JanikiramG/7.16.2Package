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

	#region Class: ProjectRoleEditPageSchema

	/// <exclude/>
	public class ProjectRoleEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.FloatEdit _externalRateEdit;
		public Terrasoft.UI.WebControls.Controls.FloatEdit ExternalRateEdit {
			get {
				return _externalRateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FloatEdit _internalRateEdit;
		public Terrasoft.UI.WebControls.Controls.FloatEdit InternalRateEdit {
			get {
				return _internalRateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _jobTitleEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit JobTitleEdit {
			get {
				return _jobTitleEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ProjectRoleEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProjectRoleEditPageSchema(ProjectRoleEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("9f2e478a-0eb3-4fa2-9cf9-d1f2d7e2154d");
			NameEdit.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("3f36671d-ee32-4099-9501-13a53c7fa549");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			RealUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			Name = "ProjectRoleEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProjectRoleEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateExternalRateEdit());
			MainControlLayout.InsertItem(2, CreateInternalRateEdit());
			MainControlLayout.InsertItem(3, CreateJobTitleEdit());
			MainControlLayout.MoveItem(4, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateProjectRoleEditPageEventsProcessSchema() {
			var schema = new ProjectRoleEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FloatEdit CreateExternalRateEdit() {
			_externalRateEdit = new Terrasoft.UI.WebControls.Controls.FloatEdit();
			_externalRateEdit.UId = new Guid("f075a3c5-6ac5-43e3-bb9c-63ab1d4968a3");
			_externalRateEdit.Name = "ExternalRateEdit";
			_externalRateEdit.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			_externalRateEdit.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			_externalRateEdit.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			_externalRateEdit.Tag = "";
			_externalRateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_externalRateEdit.Image = new ControlImage {};
			_externalRateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_externalRateEdit.DataSource = "DataSource";
			_externalRateEdit.ColumnUId = new Guid("937a10d7-6c45-4231-9e26-89e45c34dfbd");
			return _externalRateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FloatEdit CreateInternalRateEdit() {
			_internalRateEdit = new Terrasoft.UI.WebControls.Controls.FloatEdit();
			_internalRateEdit.UId = new Guid("a68572ca-9438-4b63-bfa5-285fb51f6416");
			_internalRateEdit.Name = "InternalRateEdit";
			_internalRateEdit.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			_internalRateEdit.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			_internalRateEdit.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			_internalRateEdit.Tag = "";
			_internalRateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_internalRateEdit.Image = new ControlImage {};
			_internalRateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_internalRateEdit.DataSource = "DataSource";
			_internalRateEdit.ColumnUId = new Guid("52977de1-d30a-4a70-8d9f-e4213b86022e");
			return _internalRateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateJobTitleEdit() {
			_jobTitleEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_jobTitleEdit.UId = new Guid("dd8c6447-f2d0-431e-b355-65befd491069");
			_jobTitleEdit.Name = "JobTitleEdit";
			_jobTitleEdit.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			_jobTitleEdit.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			_jobTitleEdit.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			_jobTitleEdit.Tag = "";
			_jobTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_jobTitleEdit.Image = new ControlImage {};
			_jobTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_jobTitleEdit.DataSource = "DataSource";
			_jobTitleEdit.ColumnUId = new Guid("2c300e17-bceb-4431-b4d6-13aeade16cd7");
			return _jobTitleEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("fea6a5b4-c59a-4824-9844-49b5694b53df");
			DataSource.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("19ac860d-394e-4ceb-9159-355c518bfdf6");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("2c1f0ca6-c4cd-4ba0-a6d8-61e3c3d5af86");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("1a4477f2-f563-4650-a1d7-a708bf9031f8");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("d43a32ac-89c2-417d-98f0-875497e02f65");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("6ffacd55-4c84-4971-82f0-d4cc683bb94b");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("9f2e478a-0eb3-4fa2-9cf9-d1f2d7e2154d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("3f36671d-ee32-4099-9501-13a53c7fa549");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("c904840c-4745-404d-9519-32a2e32fbc9f");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1c0f586f-b552-444a-9126-d5ef80205f70");
			if (column != null) {
				column.UId = new Guid("937a10d7-6c45-4231-9e26-89e45c34dfbd");
				column.Name = @"ExternalRate";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e4dc8763-b985-4d80-ab26-5a9fd007e63b");
			if (column != null) {
				column.UId = new Guid("52977de1-d30a-4a70-8d9f-e4213b86022e");
				column.Name = @"InternalRate";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("60d0cd19-0ac3-4f03-a125-35421aaeee0e");
			if (column != null) {
				column.UId = new Guid("2c300e17-bceb-4431-b4d6-13aeade16cd7");
				column.Name = @"JobTitle";
				column.CreatedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
				column.ModifiedInSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
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
			return new ProjectRoleEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProjectRoleEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProjectRoleEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProjectRoleEditPageEventsProcess

	/// <exclude/>
	public class ProjectRoleEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProjectRoleEditPageSchemaUserControl
	{

		public ProjectRoleEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProjectRoleEditPageEventsProcess";
			SchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede");
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
					SchemaElementUId = new Guid("0ecfd01c-da77-42e0-aec4-00ea0e8f5b5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage;
		public ProcessFlowElement PageLoadCompleteStartMessage {
			get {
				return _pageLoadCompleteStartMessage ?? (_pageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("cecd1bae-9ce9-481f-b05c-37754213ba51"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask1;
		public ProcessScriptTask PageLoadCompleteScriptTask1 {
			get {
				return _pageLoadCompleteScriptTask1 ?? (_pageLoadCompleteScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask1",
					SchemaElementUId = new Guid("dae46f58-f098-4620-854d-0f228fecdee6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTask1Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent1 {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent1 ?? (_pageLoadCompleteIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("bab2723a-3c27-4c17-be80-35df5796c26b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private LocalizableString _externalRateEditCaption;
		public LocalizableString ExternalRateEditCaption {
			get {
				return _externalRateEditCaption ?? (_externalRateEditCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ExternalRateEditCaption.Value"));
			}
		}

		private LocalizableString _internalRateEditCaption;
		public LocalizableString InternalRateEditCaption {
			get {
				return _internalRateEditCaption ?? (_internalRateEditCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InternalRateEditCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask1 };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask1");
						break;
					case "PageLoadCompleteScriptTask1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent1");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
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
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask1";
					result = PageLoadCompleteScriptTask1.Execute(context, PageLoadCompleteScriptTask1Execute);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent1.Execute(context);
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

		public virtual bool PageLoadCompleteScriptTask1Execute(ProcessExecutingContext context) {
			var currencyName = GetDefCurrencyName();
			Page.ExternalRateEdit.Caption = string.Format(ExternalRateEditCaption ,currencyName);
			Page.InternalRateEdit.Caption = string.Format(InternalRateEditCaption ,currencyName);
			return true;
		}

		public virtual string GetDefCurrencyName() {
			var connection = Page.UserConnection;
			Guid primaryCurrencyId = new Guid (SysSettings.GetValue(connection, "PrimaryCurrency").ToString());
			var entitySchemaManager = Page.UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "Currency");
			var currencyName = entitySchemaQuery.AddColumn ("Symbol");
			var shortName = entitySchemaQuery.AddColumn ("ShortName");
			var entity = entitySchemaQuery.GetEntity(Page.UserConnection, primaryCurrencyId);
			if (entity != null) {
				string symbol = entity.GetTypedColumnValue<string>(currencyName.Name);
				string shortNameValue = entity.GetTypedColumnValue<string>(shortName.Name);
				return string.IsNullOrEmpty(symbol) ? shortNameValue : symbol;
			}
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
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

	#region Class: ProjectRoleEditPageEventsProcess

	/// <exclude/>
	public class ProjectRoleEditPageEventsProcess : ProjectRoleEditPageEventsProcess<Terrasoft.WebApp.ProjectRoleEditPageSchemaUserControl>
	{

		public ProjectRoleEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProjectRoleEditPageSchemaUserControl

	/// <exclude/>
	public partial class ProjectRoleEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.FloatEdit ExternalRateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FloatEdit)PageContainer.FindPageControl("ExternalRateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FloatEdit InternalRateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FloatEdit)PageContainer.FindPageControl("InternalRateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit JobTitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("JobTitleEdit", true);
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
			var process = (ProjectRoleEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProjectRoleEditPageEventsProcess(UserConnection);
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
			SchemaName = "ProjectRoleEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProjectRoleEditPageEventsProcessSchema

	/// <exclude/>
	public class ProjectRoleEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProjectRoleEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProjectRoleEditPageEventsProcessSchema(ProjectRoleEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProjectRoleEditPageEventsProcess";
			UId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask1 = CreatePageLoadCompleteScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(pageloadcompletescripttask1);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent1 = CreatePageLoadCompleteIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExternalRateEditCaptionLocalizableString());
			LocalizableStrings.Add(CreateInternalRateEditCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExternalRateEditCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6f01efde-4c27-4501-a77c-e4307d0644a8"),
				Name = "ExternalRateEditCaption",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInternalRateEditCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("344e6c92-e510-42d3-9b71-eb8ae95e26d5"),
				Name = "InternalRateEditCaption",
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("00f9a254-6134-4dd6-b405-24905848ee5c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				CurveCenterPosition = new Point(172, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cecd1bae-9ce9-481f-b05c-37754213ba51"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dae46f58-f098-4620-854d-0f228fecdee6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("cbe7d2f9-8645-471c-b1da-871383c4c5c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				CurveCenterPosition = new Point(282, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dae46f58-f098-4620-854d-0f228fecdee6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bab2723a-3c27-4c17-be80-35df5796c26b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d2e50b6d-b610-4439-a254-1636c6c6b6eb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(971, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0b1f3dcd-b1e7-4976-a1f1-21ba4efa3ccd"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d2e50b6d-b610-4439-a254-1636c6c6b6eb"),
				CreatedInOwnerSchemaUId = new Guid("83a629a9-3d60-4f08-81ba-eb622ced2ede"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(942, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0ecfd01c-da77-42e0-aec4-00ea0e8f5b5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b1f3dcd-b1e7-4976-a1f1-21ba4efa3ccd"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(301, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cecd1bae-9ce9-481f-b05c-37754213ba51"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ecfd01c-da77-42e0-aec4-00ea0e8f5b5a"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dae46f58-f098-4620-854d-0f228fecdee6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ecfd01c-da77-42e0-aec4-00ea0e8f5b5a"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				Name = @"PageLoadCompleteScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,46,45,42,74,205,75,174,244,75,204,77,85,176,85,112,79,45,113,73,77,115,70,18,212,208,180,230,229,10,72,76,79,213,115,173,40,73,45,202,75,204,9,74,44,73,117,77,201,44,209,115,78,44,40,201,204,207,3,106,43,46,41,202,204,75,215,115,203,47,202,77,44,209,64,87,8,83,167,131,108,25,220,88,207,60,34,141,69,87,136,211,216,162,212,146,210,162,60,133,146,162,210,84,107,0,175,36,246,212,228,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("bab2723a-3c27-4c17-be80-35df5796c26b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ecfd01c-da77-42e0-aec4-00ea0e8f5b5a"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 58),
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
			Methods.Add(CreateGetDefCurrencyNameMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
		}

		protected virtual SchemaMethod CreateGetDefCurrencyNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8bf656a9-5d33-45a8-babd-7596f3c374ea"),
				Name = "GetDefCurrencyName",
				CreatedInSchemaUId = new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"),
				CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,201,110,131,48,16,61,55,18,255,48,229,100,164,136,15,104,186,168,66,81,148,67,211,84,164,189,187,48,77,144,192,68,99,59,149,85,245,223,59,44,129,80,56,228,226,195,248,173,99,159,36,65,82,42,133,137,201,74,5,15,176,149,123,12,223,53,82,212,77,23,222,108,101,179,20,142,148,21,146,92,100,137,80,37,110,157,50,92,225,55,212,151,34,118,58,70,99,50,181,215,225,10,205,135,204,45,138,94,122,14,254,118,200,247,131,112,87,198,134,152,33,130,128,77,78,156,5,149,201,140,139,147,3,22,242,69,42,14,67,211,161,42,143,1,76,248,203,49,215,15,64,106,152,184,96,187,203,233,155,69,114,3,243,102,210,20,28,33,197,68,76,46,216,55,107,219,36,237,96,35,11,100,173,145,126,248,156,166,81,153,219,66,129,240,99,87,124,150,121,199,213,135,146,204,117,196,51,210,31,110,113,146,200,107,107,234,136,137,165,206,199,111,92,73,102,95,208,54,134,91,222,136,205,243,0,126,188,217,141,174,31,15,116,29,188,115,171,44,118,238,136,109,192,250,35,220,55,208,71,113,185,145,176,58,42,253,78,232,92,164,230,92,39,216,113,122,53,66,99,73,65,131,8,215,122,195,129,95,105,89,28,185,116,147,53,128,167,255,102,119,109,13,22,248,245,102,67,137,154,186,248,3,153,78,15,201,43,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProjectRoleEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("489b14b9-2b7f-4943-9587-409f396ca8fc"));
		}

		#endregion

	}

	#endregion

}

