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

	#region Class: QuickAddMenuSettingsEditPageSchema

	/// <exclude/>
	public class QuickAddMenuSettingsEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysAdminUnitEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysAdminUnitEdit {
			get {
				return _sysAdminUnitEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _positionEdit1;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit1 {
			get {
				return _positionEdit1;
			}
		}

		#endregion

		#region Constructors: Public

		public QuickAddMenuSettingsEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QuickAddMenuSettingsEditPageSchema(QuickAddMenuSettingsEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("7b65e0c6-644c-4295-9fb7-21202349606a");
			NameEdit.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.Hidden = true;
			DescriptionEdit.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			RealUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			Name = "QuickAddMenuSettingsEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQuickAddMenuSettingsEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateSysAdminUnitEdit());
			MainControlLayout.InsertItem(2, CreatePositionEdit1());
			MainControlLayout.MoveItem(3, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateQuickAddMenuSettingsEditPageEventsProcessSchema() {
			var schema = new QuickAddMenuSettingsEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysAdminUnitEdit() {
			_sysAdminUnitEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysAdminUnitEdit.UId = new Guid("c814a80c-7153-4a31-9982-887e3848b261");
			_sysAdminUnitEdit.Name = "SysAdminUnitEdit";
			_sysAdminUnitEdit.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			_sysAdminUnitEdit.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			_sysAdminUnitEdit.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_sysAdminUnitEdit.Tag = "";
			_sysAdminUnitEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysAdminUnitEdit.Image = new ControlImage {};
			_sysAdminUnitEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysAdminUnitEdit.DataSource = "DataSource";
			_sysAdminUnitEdit.ColumnUId = new Guid("b764bfad-969e-4d37-b169-55c8133775fc");
			return _sysAdminUnitEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePositionEdit1() {
			_positionEdit1 = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_positionEdit1.UId = new Guid("2bf1af42-6ef2-4ab9-a81a-8d32673ead56");
			_positionEdit1.Name = "PositionEdit1";
			_positionEdit1.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			_positionEdit1.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			_positionEdit1.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_positionEdit1.Tag = "";
			_positionEdit1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_positionEdit1.Image = new ControlImage {};
			_positionEdit1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_positionEdit1.DataSource = "DataSource";
			_positionEdit1.ColumnUId = new Guid("b8135a2c-c074-4427-93d8-dab0f93db969");
			_positionEdit1.Enabled = false;
			return _positionEdit1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4aa8a1e1-77b5-421c-9e74-303810fbc561");
			DataSource.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("9ed07a84-53a8-43e0-9a43-8d6244882d90");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("961c80e6-5a97-4b22-97b5-bc7885a10609");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("cdb5cf63-5a42-4cd6-afa1-6fd95f10a77c");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("23473972-ab5f-4d2a-8c9f-1fd5b1aa1895");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("8c0f9cba-46e8-452b-a593-3e7a7cf3d54d");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("44e4effd-b87f-43bb-b3bf-41127209f4e0");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8c43e182-f864-47b7-b369-70f0950aa521");
			if (column != null) {
				column.UId = new Guid("7b65e0c6-644c-4295-9fb7-21202349606a");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5f7ab108-e282-4ce1-9191-fa921423b59f");
			if (column != null) {
				column.UId = new Guid("b764bfad-969e-4d37-b169-55c8133775fc");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9c5ae550-ef98-471c-b03c-1c2aedb70381");
			if (column != null) {
				column.UId = new Guid("b8135a2c-c074-4427-93d8-dab0f93db969");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
				column.ModifiedInSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
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
			return new QuickAddMenuSettingsEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new QuickAddMenuSettingsEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QuickAddMenuSettingsEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuSettingsEditPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuSettingsEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QuickAddMenuSettingsEditPageSchemaUserControl
	{

		public QuickAddMenuSettingsEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuickAddMenuSettingsEditPageEventsProcess";
			SchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651");
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
					SchemaElementUId = new Guid("671bc35a-6f41-48d1-a464-8ad958546c22"),
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
					SchemaElementUId = new Guid("d3656bc9-9ac5-4dfb-bd75-a24b8897d0d3"),
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
					SchemaElementUId = new Guid("d684ac56-9315-49d3-9352-d530f1e88f64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("c254b326-2370-49bc-80ab-13ea3998675b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
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
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
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
			if (IsNew) {
				int Position = 0;
				var selectName = 
					new Select(UserConnection)
					.Column(Func.Count("Position"))
					.From("QuickAddMenuSettings")
					as Select;
				if (selectName.ExecuteScalar<int>() > 0) {
					selectName = 
						new Select(UserConnection)
						.Column(Func.Max("Position"))
						.From("QuickAddMenuSettings")
						as Select;
					Position = selectName.ExecuteScalar<int>()+1; 
				} 
				Page.DataSource.ActiveRow.SetColumnValue("Position",Position);
			}
			return true;
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

	#region Class: QuickAddMenuSettingsEditPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuSettingsEditPageEventsProcess : QuickAddMenuSettingsEditPageEventsProcess<Terrasoft.WebApp.QuickAddMenuSettingsEditPageSchemaUserControl>
	{

		public QuickAddMenuSettingsEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuickAddMenuSettingsEditPageSchemaUserControl

	/// <exclude/>
	public partial class QuickAddMenuSettingsEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysAdminUnitEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysAdminUnitEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("PositionEdit1", true);
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
			var process = (QuickAddMenuSettingsEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QuickAddMenuSettingsEditPageEventsProcess(UserConnection);
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
			SchemaName = "QuickAddMenuSettingsEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuSettingsEditPageEventsProcessSchema

	/// <exclude/>
	public class QuickAddMenuSettingsEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public QuickAddMenuSettingsEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QuickAddMenuSettingsEditPageEventsProcessSchema(QuickAddMenuSettingsEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QuickAddMenuSettingsEditPageEventsProcess";
			UId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
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
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c66f44c7-21b4-464f-9c2b-7bb4d57f0826"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				CurveCenterPosition = new Point(155, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3656bc9-9ac5-4dfb-bd75-a24b8897d0d3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d684ac56-9315-49d3-9352-d530f1e88f64"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6e31d6d9-52c1-4018-adea-6b89af7a1870"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				CurveCenterPosition = new Point(252, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d684ac56-9315-49d3-9352-d530f1e88f64"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c254b326-2370-49bc-80ab-13ea3998675b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3fd5000e-7e38-4807-b51a-4b0bfbdf3347"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(699, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("560e7c41-7c69-47f5-b1ff-6294bda25040"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3fd5000e-7e38-4807-b51a-4b0bfbdf3347"),
				CreatedInOwnerSchemaUId = new Guid("8431e85f-f66a-43a9-aa48-b5af5aee3651"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(670, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("671bc35a-6f41-48d1-a464-8ad958546c22"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("560e7c41-7c69-47f5-b1ff-6294bda25040"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d3656bc9-9ac5-4dfb-bd75-a24b8897d0d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("671bc35a-6f41-48d1-a464-8ad958546c22"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d684ac56-9315-49d3-9352-d530f1e88f64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("671bc35a-6f41-48d1-a464-8ad958546c22"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c254b326-2370-49bc-80ab-13ea3998675b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("671bc35a-6f41-48d1-a464-8ad958546c22"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,208,77,107,2,49,16,6,224,243,10,254,135,97,79,89,42,193,158,183,21,196,42,244,160,216,46,237,125,136,83,9,221,157,64,62,92,161,248,223,59,235,86,170,120,216,75,24,222,76,50,79,98,191,64,189,134,13,181,5,252,140,71,153,229,8,91,23,108,180,142,225,25,166,165,100,7,244,16,168,38,19,55,216,144,164,146,101,76,45,84,231,80,125,4,242,11,199,44,181,156,42,186,93,189,112,117,106,88,173,18,27,169,19,71,149,95,174,205,139,190,101,229,93,163,242,183,100,205,247,124,183,91,19,167,138,98,180,188,15,249,185,1,195,223,128,206,96,133,249,111,208,203,35,153,20,169,50,88,163,127,18,244,76,21,48,131,105,255,136,236,78,59,192,189,245,174,241,120,167,29,230,222,122,179,171,79,28,112,63,60,150,157,241,212,45,91,220,147,126,193,136,149,75,222,144,158,139,241,64,239,174,213,50,172,55,126,98,157,232,202,55,185,84,133,204,61,141,71,158,98,242,12,209,39,42,127,1,240,11,19,19,221,1,0,0 }
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
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QuickAddMenuSettingsEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6707a944-ca72-4036-9c31-ed96be6a92fe"));
		}

		#endregion

	}

	#endregion

}

